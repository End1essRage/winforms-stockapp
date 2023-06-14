using Autofac;
using StockApp.Data;
using StockApp.Services.HistoryService;
using StockApp.Services.ProductService;

namespace StockApp
{
    internal static class Program
    {
        public static IContainer Container;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Container = Configure();
            //Seed Data
            var seeder = new Seeder(Container.Resolve<DataContext>());
            seeder.SeedData();

            Application.Run(new MainForm(Container));
        }

        private static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<HistoryService>().As<IHistoryService>();
            builder.RegisterType<DataContext>();
            builder.RegisterType<MainForm>();
            return builder.Build();
        }
    }
}