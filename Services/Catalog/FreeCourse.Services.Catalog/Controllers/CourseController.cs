using Amazon.Runtime.Internal;
using FreeCourse.Services.Catalog.Interfaces;
using FreeCourse.Services.Catalog.Services;
using FreeCourse.Shared.ControllerBases;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Controllers
{
    internal class CourseController : CustomBaseController
    {
        private readonly ICourseService _courseService;
        public  CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IActionResult> GetCourseById(string id)
        {
            try
            {
                var response = await _courseService.GetCourseById(id);
                return CreateActionResultInstance(response);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
