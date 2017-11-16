using Autofac;
using ConsoleApp1.cls;
using ConsoleApp1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace consoleService
{
    public class EngineModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BMW>().As<iCar>();
        }
    }
}
