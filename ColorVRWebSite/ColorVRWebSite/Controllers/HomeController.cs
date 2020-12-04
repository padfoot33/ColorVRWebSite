using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColorVRWebSite.Data.Interfaces;
using ColorVRWebSite.ViewModels;

namespace ColorVRWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayGroundRepository _playGroundRepository;
        public HomeController(IPlayGroundRepository playGroundRepository)
        {
            _playGroundRepository = playGroundRepository;
        }
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                preferedPlayGrounds = _playGroundRepository.PreferredPlayGrounds
            };
            return View(homeViewModel);
        }
    }
}
