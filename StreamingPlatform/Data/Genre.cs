using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Entities
{
    public class Genre : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
