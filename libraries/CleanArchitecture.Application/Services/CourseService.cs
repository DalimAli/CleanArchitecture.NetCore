using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Vm;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseVm GetAllCourse()
        {
            return new CourseVm()
            {
                Courses = _courseRepository.GetAll()
            };
        }
    }

}
