using EmoAttributes.Repositories;

var builder = WebApplication.CreateBuilder(args);

// ✅ MVC (コントローラー + Razor Views) を使うために必要
builder.Services.AddControllersWithViews();

// ✅ リポジトリをDIに登録
builder.Services.AddScoped<IEmoAttributesRepository, EmoAttributesRepository>();

var app = builder.Build();

// 静的ファイルやルーティングのミドルウェア（必要なら追加）
app.UseStaticFiles();

// ✅ ルート定義（Home/Index に飛ばす）
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
