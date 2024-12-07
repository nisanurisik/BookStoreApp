using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EfCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                    new Book { Id = 1, Title = "İstanbul", Price = 85 },
                    new Book { Id = 2, Title = "Hatay", Price = 80 },
                    new Book { Id = 3, Title = "Çarşamba", Price = 75 }
                );
        }
    }
}
