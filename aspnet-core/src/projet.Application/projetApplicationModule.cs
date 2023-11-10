using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using projet.Authorization;

namespace projet
{
    [DependsOn(
        typeof(projetCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class projetApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<projetAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(projetApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
