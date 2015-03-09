using eManager.Web.App_Start;
using System.Web.Mvc;
using eManager.Web.DependenceResolution;
using StructureMap;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(StructuremapMvc), "Start")]

namespace eManager.Web.App_Start
{

    public static class StructuremapMvc
    {
        public static void Start()
        {
            var container = (IContainer)IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}