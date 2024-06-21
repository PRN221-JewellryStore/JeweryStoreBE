using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjecs.Mapping
{
    interface IMapFrom<T>
    {
        void Mapping(Profile profile);
    }
}
