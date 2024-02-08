using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Core.Entities
{
    public abstract class Entity
    {
        public Guid Id {set; get;}
        public string CreatedBy {set; get;}= string.Empty;
        public string ModifiedBy {set; get;} = string.Empty;
        public DateTime DateCreated {set; get;}
        public DateTime DateModified {set; get;}
    }
}