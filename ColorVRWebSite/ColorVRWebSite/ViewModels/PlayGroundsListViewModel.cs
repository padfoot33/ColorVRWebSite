using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Models;

namespace ColorVRWebSite.ViewModels
{
    public class PlayGroundsListViewModel
    {
        public IEnumerable<PlayGrounds> playGrounds { get; set; }
        public string currentCategory { get; set; }   
    }
}
