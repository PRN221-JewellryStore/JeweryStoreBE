﻿using AutoMapper;
using BusinessObjecs.DTOs;
using BusinessObjecs.Models;
using BusinessObjecs.Models.Configured;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Exceptions;
using Repositories.IRepository;
using Repositories.RepositoryImpl;
using Services.IService;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            try
            {
                var getcounter = CounterDTO.Adapt<CounterEntity>();
                _counterRepository.Add(getcounter);
                await _counterRepository.UnitOfWork.SaveChangesAsync();

                return getcounter.Adapt<CounterDTO>();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Error in Add method: {ex.Message}");
                throw; // Rethrow the exception to propagate it upwards
            }

        }

        public async Task Delete(int id, UserDTO user)
        {
  //          var getCounter = await _counterRepository.FindAsync(x => x.ID == counter.ID && x.DeleterID == null);
            
            var getCounter = await _counterRepository.FindAsync(x => x.ID == id && x.DeleterID == null);
         //   var CounterEntity = counter.Adapt<CounterEntity>();

            if (getCounter == null) {
                Console.WriteLine(" was not found or already deleted.");
                return;
            }
            else
            {
                getCounter.DeleterID = user.ID;
                getCounter.DeletedAt= DateTime.Now;
                _counterRepository.Update(getCounter);
                _counterRepository.UnitOfWork.SaveChangesAsync().Wait();
                await Task.CompletedTask;

            }

        }

        public async Task<List<CounterDTOResponse>> GetAll()
        {
            var getAll = await _counterRepository.getAllwithCategory();
            var getActive = getAll.Where(c => c.DeleterID == null).ToList();
            if (getActive == null)
            {
                throw new NotFoundException($"Counter with  not found");

            }
            return getActive.Adapt<List<CounterDTOResponse>>();
        }

        public async Task<CounterDTOResponse> GetById(int id)
        {
            var counterEntity = await _counterRepository.GetByIdWithCategoryAsync(id);
            if(counterEntity == null)
            {
                throw new NotFoundException($"Counter with ID {id} not found");

            }
            return counterEntity.Adapt<CounterDTOResponse>();
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
