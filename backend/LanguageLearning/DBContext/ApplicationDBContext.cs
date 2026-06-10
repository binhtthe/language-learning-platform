using Microsoft.EntityFrameworkCore;
using System;
namespace LanguageLearning.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

    }
}
