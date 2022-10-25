using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastucture.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastucture.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CourseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Course> GetAll()
        {
            return _applicationDbContext.Courses;
        }
    }
}
