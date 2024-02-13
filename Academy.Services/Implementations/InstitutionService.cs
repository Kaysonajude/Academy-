
using Academy.Services.Contracts.Institutions;
using Academy.Services.Interfaces;
using Academy.Core.Interfaces;
using Academy.Services.Extension;

namespace Academy.Services.Implementations
{
    public class InstitutionService : IInstitutionService
    {
        private readonly IInstitutionRepository _repository;
        public InstitutionService(IInstitutionRepository repository)
        {
            _repository = repository;
        }
        public InstitutionRsp<InstitutionDto> CreateInstitution(InstitutionCreateReq req)
        {
            var newInstitution = req.AsEntity();
            _repository.Add(newInstitution);

            return new InstitutionRsp<InstitutionDto>
            {
                Code = "200",
                Message = string.Empty
            };
        }

        public InstitutionRsp<List<InstitutionDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public InstitutionRsp<InstitutionDto> GetById(Guid InstitutionId)
        {
            throw new NotImplementedException();
        }

        InstitutionRsp<InstitutionDto> UpdateInstitution(InstitutionCreateReq req)
        {
            throw new NotImplementedException();
        }

        
}
}