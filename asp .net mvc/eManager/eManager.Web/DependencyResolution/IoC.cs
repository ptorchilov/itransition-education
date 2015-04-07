namespace eManager.Web.DependencyResolution
{
    using Domain;
    using Infrastructure;
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