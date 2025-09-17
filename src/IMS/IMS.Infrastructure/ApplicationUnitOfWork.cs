using IMS.Domain;
using IMS.Domain.Entities;
using IMS.Domain.Repositories;
using IMS.Infrastructure.Data;
using IMS.Domain.Repositories;
using IMS.Infrastructure;
using IMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Infrastructure
{
    public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
    {
        public IProductRepository ProductRepository { get; private set; }

        public ApplicationUnitOfWork(ApplicationDbContext context, IProductRepository productRepository)
            : base(context)
        {
            ProductRepository = productRepository;
        }
    }
}