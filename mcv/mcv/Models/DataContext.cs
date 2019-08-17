using System.Data.Entity;

namespace mcv.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mcv.Models.Student> Students { get; set; }
    }
}