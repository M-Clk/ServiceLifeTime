using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLifeTime.Models
{
    public interface IUtilitySingleton
    {
       string Key { get; set; }
       string Name { get; set; }
    }
    public interface IUtilityTransient
    {
       string Key { get; set; }
       string Name { get; set; }
    }
    public interface IUtilityScoped
    {
       string Key { get; set; }
       string Name { get; set; }
    }
    class UtilitySingleton : IUtilitySingleton
    {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = nameof(UtilitySingleton);
    }
    class UtilityTransient : IUtilityTransient
    {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = nameof(UtilityTransient);
    }
    class UtilityScoped : IUtilityScoped
    {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = nameof(UtilityScoped);
    }
}
