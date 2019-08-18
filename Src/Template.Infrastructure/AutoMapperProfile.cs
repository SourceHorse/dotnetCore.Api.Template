﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Template.Domain.Models;
using Template.Infrastructure.Couchbase.Models;

namespace Template.Infrastructure
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SimpleMessage, SimpleMessageDbModel>();
            CreateMap<SimpleMessageDbModel, SimpleMessage>();
            CreateMap<SimpleMessageCreateRequest, SimpleMessageDbModel>()
                .ForMember(dest => dest.CreatedOn, opt => opt.Equals(new DateTime()))
                .ForMember(dest => dest.Enabled, opt => opt.Equals(true));
            CreateMap<SimpleMessageUpdateRequest, SimpleMessageDbModel>();
        }
    }
}
