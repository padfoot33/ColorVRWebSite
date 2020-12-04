using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColorVRWebSite.Data.Models;
namespace ColorVRWebSite.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<PlayGrounds> preferedPlayGrounds { get; set; }
    }
}
