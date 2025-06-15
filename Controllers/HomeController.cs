using EmoAttributes.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace EmoAttributes.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly IEmoAttributesRepository _repo;

        // コンストラクタでリポジトリを注入
        public HomeController(IEmoAttributesRepository repo)
        {
            _repo = repo;
        }

        // Indexアクションで全てのEmoAttributeを取得
        [Route("index")]
        public IActionResult Index()
        {
            var emoAttributes = _repo.GetAll();
            return View(emoAttributes);
        }
    }
}
