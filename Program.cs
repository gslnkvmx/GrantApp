var builder = WebApplication.CreateBuilder(args);

builder.Services
        .AddRazorPages();
//.AddRazorPagesOptions(opt => opt.Conventions.AddPageRoute("/Account/Login", ""));

builder.Services.AddAuthentication("AuthCookie").AddCookie("AuthCookie", options =>
{
    options.Cookie.Name = "AuthCookie";
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("BelongToAdmin", policy => policy.RequireClaim("Role", "Admin"));
});

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
