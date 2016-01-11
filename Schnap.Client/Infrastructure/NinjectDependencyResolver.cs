using Moq;
using Ninject;
using Schnap.Domain.Abstract;
using Schnap.Domain.Concrete;
using Schnap.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //Mock<IPictureRepository> mock = new Mock<IPictureRepository>();

            //mock.Setup(m => m.pictures).Returns(new List<Picture>
            //{
            //    new Picture{ picture_id = 1,
            //                 title="holidays",
            //                 description="photos from holiday",
            //                 upload_date=new DateTime(2016,1,1) },

            //    new Picture{ picture_id = 2,
            //                 title="holidays 2",
            //                 description="another from holiday",
            //                 upload_date=new DateTime(2016,1,1) },

            //    new Picture{ picture_id = 3,
            //                 title="cats",
            //                 description="this will be a cat picture",
            //                 upload_date=new DateTime(2016,1,1) }
            //});

            kernel.Bind<IPictureRepository>().To<PictureRepository>();
        }
    }
}
