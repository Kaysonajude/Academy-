using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Core.Interfaces;

namespace Academy.Repositories.Implementation
{
    public class CourseRepository : ICourseRepository
    {
        public Task<Course> Add(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetById(Guid courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Course> Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}