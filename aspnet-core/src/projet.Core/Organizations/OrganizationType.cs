using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Shema;
using Abp.DomainEntities.Auditing;

namespace projet.Core.Organizations
{
    public class OrganizationType
    {
        [Table("AppOrganizationTypes")]
        public class OrganizationType: FullAuditedEntity<int>
        {
            public const int MaxNameLength = 50;

            [StringLength(MaxNameLength)]
            public string Name { get; set; }
        }
    }
}