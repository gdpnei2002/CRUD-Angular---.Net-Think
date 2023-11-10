using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using projet.EntityFrameworkCore;
using projet.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace projet.Web.Tests
{
    [DependsOn(
        typeof(projetWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class projetWebTestModule : AbpModule
    {
        public projetWebTestModule(projetEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(projetWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(projetWebMvcModule).Assembly);
        }
    }
}