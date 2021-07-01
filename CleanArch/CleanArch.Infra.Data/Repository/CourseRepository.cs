using System.Collections.Generic;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniDbContext _uniDbContext;

        public CourseRepository(UniDbContext uniDbContext)
        {
            _uniDbContext = uniDbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _uniDbContext.Courses;
        }
    }
}