﻿using System;
using System.IO;
using System.Net.Http;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MainApp.Blazor.Server.Host.Menus;
using MainApp.EntityFrameworkCore;
using MainApp.Localization;
using MainApp.MultiTenancy;
using Volo.Abp;
using Volo.Abp.Account;
using Volo.Abp.Account.Web;
using Volo.Abp.AspNetCore.Authentication.JwtBearer;
using Volo.Abp.AspNetCore.Components.Server.BasicTheme;
using Volo.Abp.AspNetCore.Components.Server.BasicTheme.Bundling;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic.Bundling;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Blazor.Server;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Blazor.Server;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Swashbuckle;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.Blazor.Server;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Volo.Abp.Threading;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;

namespace MainApp.Blazor.Server.Host
{
    [DependsOn(
        typeof(MainAppEntityFrameworkCoreModule),
        typeof(MainAppApplicationModule),
        typeof(MainAppHttpApiModule),
        typeof(AbpAspNetCoreMvcUiBasicThemeModule),
        typeof(AbpAutofacModule),
        typeof(AbpSwashbuckleModule),
        typeof(AbpAspNetCoreAuthenticationJwtBearerModule),
        typeof(AbpAspNetCoreSerilogModule),
        typeof(AbpAccountWebIdentityServerModule),
        typeof(AbpAccountApplicationModule),
        typeof(AbpAspNetCoreComponentsServerBasicThemeModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpIdentityEntityFrameworkCoreModule),
        typeof(AbpAuditLoggingEntityFrameworkCoreModule),
        typeof(AbpIdentityBlazorServerModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(AbpFeatureManagementEntityFrameworkCoreModule),
        typeof(AbpTenantManagementBlazorServerModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpTenantManagementEntityFrameworkCoreModule),
        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpSettingManagementBlazorServerModule),
        typeof(AbpSettingManagementApplicationModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(MainAppBlazorServerModule)
    )]
    public class MainAppBlazorHostModule: AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
            {
                options.AddAssemblyResource(
                    typeof(MainAppResource),
                    typeof(MainAppDomainModule).Assembly,
                    typeof(MainAppDomainSharedModule).Assembly,
                    typeof(MainAppApplicationModule).Assembly,
                    typeof(MainAppApplicationContractsModule).Assembly,
                    typeof(MainAppBlazorHostModule).Assembly
                );
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var hostingEnvironment = context.Services.GetHostingEnvironment();
            var configuration = context.Services.GetConfiguration();

            Configure<AbpDbContextOptions>(options =>
            {
                options.UseSqlServer();
            });

            Configure<AbpBundlingOptions>(options =>
            {
                // MVC UI
                options.StyleBundles.Configure(
                    BasicThemeBundles.Styles.Global,
                    bundle =>
                    {
                        bundle.AddFiles("/global-styles.css");
                    }
                );

                //BLAZOR UI
                options.StyleBundles.Configure(
                    BlazorBasicThemeBundles.Styles.Global,
                    bundle =>
                    {
                        bundle.AddFiles("/blazor-global-styles.css");
                        //You can remove the following line if you don't use Blazor CSS isolation for components
                        bundle.AddFiles("/MainApp.Blazor.Server.Host.styles.css");
                    }
                );
            });

            context.Services.AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.Authority = configuration["AuthServer:Authority"];
                    options.RequireHttpsMetadata = Convert.ToBoolean(configuration["AuthServer:RequireHttpsMetadata"]);
                    options.Audience = "MainApp";
                });

            if(hostingEnvironment.IsDevelopment())
            {
                Configure<AbpVirtualFileSystemOptions>(options =>
                {
                    options.FileSets.ReplaceEmbeddedByPhysical<MainAppDomainSharedModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}MainApp.Domain.Shared", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<MainAppDomainModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}MainApp.Domain", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<MainAppApplicationContractsModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}MainApp.Application.Contracts", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<MainAppApplicationModule>(Path.Combine(hostingEnvironment.ContentRootPath, string.Format("..{0}..{0}src{0}MainApp.Application", Path.DirectorySeparatorChar)));
                    options.FileSets.ReplaceEmbeddedByPhysical<MainAppBlazorHostModule>(hostingEnvironment.ContentRootPath);
                });
            }

            context.Services.AddAbpSwaggerGen(
                options =>
                {
                    options.SwaggerDoc("v1", new OpenApiInfo { Title = "MainApp API", Version = "v1" });
                    options.DocInclusionPredicate((docName, description) => true);
                    options.CustomSchemaIds(type => type.FullName);
                });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Languages.Add(new LanguageInfo("cs", "cs", "Čeština"));
                options.Languages.Add(new LanguageInfo("en", "en", "English"));
                options.Languages.Add(new LanguageInfo("en-GB", "en-GB", "English (UK)"));
                options.Languages.Add(new LanguageInfo("fi", "fi", "Finnish"));
                options.Languages.Add(new LanguageInfo("fr", "fr", "Français"));
                options.Languages.Add(new LanguageInfo("hi", "hi", "Hindi", "in"));
                options.Languages.Add(new LanguageInfo("it", "it", "Italian", "it"));
                options.Languages.Add(new LanguageInfo("hu", "hu", "Magyar"));
                options.Languages.Add(new LanguageInfo("pt-BR", "pt-BR", "Português (Brasil)"));
                options.Languages.Add(new LanguageInfo("ru", "ru", "Русский"));
                options.Languages.Add(new LanguageInfo("sk", "sk", "Slovak"));
                options.Languages.Add(new LanguageInfo("tr", "tr", "Türkçe"));
                options.Languages.Add(new LanguageInfo("zh-Hans", "zh-Hans", "简体中文"));
                options.Languages.Add(new LanguageInfo("zh-Hant", "zh-Hant", "繁體中文"));
            });

            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = MultiTenancyConsts.IsEnabled;
            });

            context.Services.AddTransient(sp => new HttpClient
            {
                BaseAddress = new Uri("/")
            });

            context.Services
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new MainAppMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AppAssembly = typeof(MainAppBlazorHostModule).Assembly;
            });
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var env = context.GetEnvironment();
            var app = context.GetApplicationBuilder();

            app.UseAbpRequestLocalization();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCorrelationId();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseJwtTokenMiddleware();

            if (MultiTenancyConsts.IsEnabled)
            {
                app.UseMultiTenancy();
            }

            app.UseUnitOfWork();
            app.UseIdentityServer();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseAbpSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "MainApp API");
            });
            app.UseConfiguredEndpoints();

            using (var scope = context.ServiceProvider.CreateScope())
            {
                AsyncHelper.RunSync(async () =>
                {
                    await scope.ServiceProvider
                        .GetRequiredService<IDataSeeder>()
                        .SeedAsync();
                });
            }
        }
    }
}
