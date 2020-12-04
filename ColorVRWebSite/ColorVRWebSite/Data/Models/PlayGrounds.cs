using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColorVRWebSite.Data.Models
{
    public class PlayGrounds
    {
        [Key]
        public int PGId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnail { get; set; }
        public bool isPreferedPG { get; set; }
        public int CategoryId { get; set; }
        public virtual Category category { get; set; }

    }

}
