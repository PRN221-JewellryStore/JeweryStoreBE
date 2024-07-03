using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceImpl
{
    public class CounterService : ICounterService
    {
        ICounterRepository _counterRepository;
        private readonly IMapper _mapper;


        public CounterService(ICounterRepository counterRepository, IMapper mapper)
        {
            _counterRepository = counterRepository;
            _mapper = mapper;
        }

        public async Task<CounterDTO> Add(CounterDTO CounterDTO)
        {
            var Counter = _mapper.Map<CounterEntity>(CounterDTO);
            _counterRepository.Add(Counter);
           await _counterRepository.UnitOfWork.SaveChangesAsync();
            var CounterEntity = _mapper.Map<CounterDTO>(Counter);

            return CounterEntity;

        }

        public Task Delete(CounterEntity counter, UserDTO user)
        {
            var getCounter = _counterRepository.FindAsync(x => x.ID == counter.ID && x.DeleterID == null).ToString();
            if (getCounter == null) {
                throw new ArgumentNullException(nameof(CounterEntity), "Already Deleted");
            }
            else
            {
                counter.DeleterID = user.ID;
                counter.DeletedAt= DateTime.Now;
                _counterRepository.Update(counter);
                _counterRepository.UnitOfWork.SaveChangesAsync().Wait();

                throw new ArgumentNullException(nameof(CounterEntity), "Deleted Success");

            }

        }

        public async Task<List<CounterEntity>> GetAll()
        {
            var getAll = await _counterRepository.FindAllAsync();
            var getActive = getAll.Where(c => c.DeleterID == null).ToList();
            return getActive;
        }

        public Task<CounterEntity> GetById(int id)
        {
           return _counterRepository.FindAsync(p=> p.ID == id); 
        }

        public async Task Update(CounterDTO counterDTO, int id)
        {
            var existingCounterEntity = await _counterRepository.FindAsync(p => p.ID == id);
            if (existingCounterEntity == null)
            {
                throw new NotFoundException($"Counter with ID {id} not found");
            }

            _mapper.Map(counterDTO, existingCounterEntity);
            _counterRepository.Update(existingCounterEntity);
            await _counterRepository.UnitOfWork.SaveChangesAsync();
        }
        /*  var existingCounterEntity = await _counterRepository.FindAsync(p => p.ID == id);
          if (existingCounterEntity == null)
          {
              throw new Exception("Entity not found");
          }

          // Map the properties from the DTO to the existing entity
          _mapper.Map(CounterDTO, existingCounterEntity);

          // Update the entity in the repository
         // var Counter = _mapper.Map<CounterEntity>(CounterDTO);

           _counterRepository.Update(existingCounterEntity);

          // Save the changes asynchronously
          await _counterRepository.UnitOfWork.SaveChangesAsync();
*/
    }
    }/**/
