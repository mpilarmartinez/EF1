using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC1.Context
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            //crear configuración mysql
            string url = "server=localhost;port=3306;user=root;password=Agosto_2022;database=cursonet";

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(url, ServerVersion.AutoDetect(url))
                .Options;

            return new AppDbContext(options);
        }
    }


}
