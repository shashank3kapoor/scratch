using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch.Database
{
    public interface IDataModel : IDisposable
    {
        //DbSet<Blog> Blogs { get; set; }
        //DbSet<Post> Posts { get; set; }

        int SaveChanges();
    }
}
