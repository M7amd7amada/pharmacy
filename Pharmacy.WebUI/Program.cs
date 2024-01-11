WebApplication app = WebApplication.CreateBuilder().ConfigureServices().Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboards}/{action=Index}/{id?}");

await app.RunAsync();