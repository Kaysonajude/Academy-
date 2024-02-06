using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Core.Entities
{
    public class Program : Entity
    {
        public string Name {set; get;} = string.Empty;
        public Guid CourseId {set; get;}
        public Course? Course {set; get;}
    }
}