﻿using Destiny.Core.Flow.Reflection;
using System;
using System.Collections.Generic;
using System.Text;
using Destiny.Core.Flow.Extensions;
using System.Linq;

namespace Destiny.Core.Flow.Mapping
{
    public class EntityManager : IEntityManager
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityManager(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

 
        public void Initialize()
        {
         
            //var typeFinder = _serviceProvider.GetService<ITypeFinder>();
            //typeFinder.NotNull(nameof(typeFinder));
            //Type[] types= typeFinder.Find(o => o.IsDeriveClassFrom<IEntityMappingConfiguration>()).Distinct().ToArray();
        }
    }
}
