using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Services.Contracts.Institutions
{
    public class InstitutionCreateReq
    {
        public string Name {set; get;} = string.Empty;
        public string City {set; get;}= string.Empty;
        public string State {set; get;}= string.Empty;
        public string Country {set; get;}= string.Empty;

        internal object AsEntity()
        {
            throw new NotImplementedException();
        }
    }
}