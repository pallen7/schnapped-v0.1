using Ninject;
using Schnap.Domain.Persistence.Abstract;
using Schnap.Domain.Persistence.Concrete;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Schnap.Client.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IPictureRepository>().To<PictureRepository>();
            kernel.Bind<EFDbContext>().ToSelf();
        }
    }
}
