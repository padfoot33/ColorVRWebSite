using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ColorVRWebSite.Data.Interfaces;
using ColorVRWebSite.ViewModels;
using ColorVRWebSite.Data.Models;

namespace ColorVRWebSite.Controllers
{
    public class PlayGroundsController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPlayGroundRepository _playGroundRepository;
        public PlayGroundsController(ICategoryRepository categoryRepository, IPlayGroundRepository playGroundRepository)
        {
            _categoryRepository = categoryRepository;
            _playGroundRepository = playGroundRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<PlayGrounds> playGrounds;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                playGrounds = _playGroundRepository.playGrounds.OrderBy(n => n.PGId);
                currentCategory = "All PlayGrounds";
            }
            else
            {
                if (string.Equals("Physics", _category, StringComparison.OrdinalIgnoreCase))
                {
                    playGrounds = _playGroundRepository.playGrounds.Where(p=>p.category.CategoryName.Equals("Physics")).OrderBy(p => p.Name);
                }
                else
                    playGrounds = _playGroundRepository.playGrounds.Where(p => p.category.CategoryName.Equals("Chemestry")).OrderBy(p => p.Name);
                
                currentCategory = _category;
            }

            return View(new PlayGroundsListViewModel
            {
                playGrounds = playGrounds,
                currentCategory = currentCategory
            });
        }
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<PlayGrounds> playGrounds;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                playGrounds = _playGroundRepository.playGrounds.OrderBy(p => p.PGId);
            }
            else
            {
                playGrounds = _playGroundRepository.playGrounds.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Drink/List.cshtml", new PlayGroundsListViewModel { playGrounds = playGrounds, currentCategory = "All drinks" });
        }
        public ViewResult Details(int drinkId)
        {
            var playGrounds = _playGroundRepository.playGrounds.FirstOrDefault(d => d.PGId == drinkId);
            if (playGrounds == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(playGrounds);
        }
    }
}
