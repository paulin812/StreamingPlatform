using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Entities
{
    public class Artist : BaseEntity
    {
        public Artist()
        {
           
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SongsList { get; set; }
        public string GenreList { get; set; }
    }
}
