using Microsoft.AspNetCore.Mvc;
using EmoAttributes.Repositories;

namespace EmoAttributes.Controllers
{
    [Route("command")]
    public class CommandController : Controller
    {
      [Route("index")]
      public IActionResult Index(int? enemy_hp)
      {
        Console.WriteLine(enemy_hp);
        ViewBag.enemy_hp = enemy_hp ?? 100; // 渡ってこなければ100%にする
        return View();
      }

      [Route("damage")]
      public IActionResult Damage(int skillNumber, int enemyHp)
      {
          int damage = skillNumber * 10;
          int hp = (enemyHp - damage)*100/100 ;
          return RedirectToAction("Index", new { enemy_hp = hp });
      }
    }
}
