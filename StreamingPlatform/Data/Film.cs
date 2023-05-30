using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistApp.DAL.Entities
{
    public class Film : BaseEntity
    {
        public Film()
        {
           
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public  DateTime Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual List<Film> Songs { get; set; }

        public virtual Artist Artist { get; set; }
    }
}
