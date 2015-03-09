namespace eManager.Web.DependencyResolution
{
    using eManager.Domain;
    using eManager.Web.Infrastructure;
    using StructureMap;

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