using System;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopMVC.Controllers
{
    public class CastController : Controller
    {
        private ICastService _castSevice;
        public CastController(ICastService castService)
        {
            _castSevice = castService;
        }
        public async Task<IActionResult> CastDetail(int id)
        {
            var movie = await _castSevice.GetCastDetails(id);
            return View(movie);
        }
    }
}
