using System;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace projet.Application.Organizations
{
    using Dto;

    public interface IOrganizationTypeAppService: IAsyncCrudAppService<OrganizationTypeDto, Guid, PagedResultRequestDto, CreateOrganizationTypeDto, OrganizationTypeDto>
    {
         
    }
}