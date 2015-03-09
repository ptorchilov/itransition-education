namespace eManager.Web.DependenceResolution
{
    using eManager.Domain;
    using eManager.Web.Infrastructure;

    using StructureMap;
    using StructureMap.Graph;

    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });

                x.For<IDepartmentDataSource>().Use<DepartmentDbcs>();
            });

            return ObjectFactory.Container;
        }
    }
}