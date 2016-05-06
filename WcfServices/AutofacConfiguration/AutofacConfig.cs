using Autofac;
using ClassLibrary1;
using Domain.Invoices;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfServices.Invoices;
using WcfServices.Products;

namespace WcfServices.AutofacConfiguration
{
    public class AutofacConfig
    {
        public static IContainer GetContainer()
        {
            var builder = new ContainerBuilder();

            // Register your service implementations.
            builder.RegisterType<InvoiceService>().As<IInvoiceService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<AppContext>().As<IRepositoryInvoices>().As<IRepositoryProducts>().InstancePerLifetimeScope();

            // Set the dependency resolver.
            return builder.Build();
        }
    }
}