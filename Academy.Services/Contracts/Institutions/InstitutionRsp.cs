
using System.Dynamic;

namespace Academy.Services.Contracts.Institutions
{
    public class InstitutionRsp<T>
    {
        public string Code {set; get;} = string.Empty;
        public string? Message {set; get;}
        public T? Result {set; get;}
        
    }
}