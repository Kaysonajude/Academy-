using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Core.Entities;
using Academy.Services.Contracts.Institutions;

namespace Academy.Services.Extension
{
    public static class InstitutionExtension
    {

        public static Institution InstitutionDtoAsEntity(this InstitutionCreateReq req)
        {
            return new Institution
            {
                City = req.City,
                Country = req.Country,
                CreatedBy = "Me",
                DateCreated = DateTime.UtcNow
            };
        }
    }
}