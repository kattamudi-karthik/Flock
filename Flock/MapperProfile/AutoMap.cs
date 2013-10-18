﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flock.MapperProfile
{
    public class AutoMap : IAutoMap
    {
        public TDestination Map<TSource, TDestination>(TSource sourceObject)
        {
            return AutoMapper.Mapper.Map<TSource, TDestination>(sourceObject);
        }

        public TDestination Map<TSource, TDestination>(TSource sourceObject, TDestination destination)
        {
            return AutoMapper.Mapper.Map<TSource, TDestination>(sourceObject, destination);
        }

        public IEnumerable<TDestination> Map<TSource, TDestination>(IEnumerable<TSource> sourceObject)
        {
            return AutoMapper.Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(sourceObject);
        }
    }
}