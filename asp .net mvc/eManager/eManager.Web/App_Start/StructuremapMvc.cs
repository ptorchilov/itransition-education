using eManager.Web.App_Start;
using System.Web.Mvc;
using StructureMap;
using eManager.Web.DependencyResolution;

[assembly: WebActivator.PreApplicationStartMethod(typeof(StructuremapMvc), "Start")]

namespace eManager.Web.App_Start
{
    

    public static class StructuremapMvc
    {
        public static void Start()
        {
            var container = IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}