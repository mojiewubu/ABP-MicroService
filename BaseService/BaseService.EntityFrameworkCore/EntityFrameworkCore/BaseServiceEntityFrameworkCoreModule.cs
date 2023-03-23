﻿using Microsoft.Extensions.DependencyInjection;
using System;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.PostgreSql;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace BaseService.EntityFrameworkCore
{
    [DependsOn(
        typeof(BaseServiceDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpAuditLoggingEntityFrameworkCoreModule),
        typeof(AbpPermissionManagementEntityFrameworkCoreModule),
        typeof(AbpSettingManagementEntityFrameworkCoreModule),
        typeof(AbpTenantManagementEntityFrameworkCoreModule),
        typeof(AbpIdentityEntityFrameworkCoreModule)
    )]
    public class BaseServiceEntityFrameworkCoreModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            BaseEfCoreEntityExtensionMappings.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbContextOptions>(options =>
            {
                options.UseNpgsql();
            });

            context.Services.AddAbpDbContext<BaseServiceDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });
        }
    }
}
