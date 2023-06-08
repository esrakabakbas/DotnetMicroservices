using Amazon.Runtime.Internal;
using FreeCourse.Services.Catalog.DTO;
using FreeCourse.Services.Catalog.Interfaces;
using FreeCourse.Services.Catalog.Services;
using FreeCourse.Shared.ControllerBases;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    internal class CourseController : CustomBaseController
    {
        private readonly ICourseService _courseService;
        public  CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet("{id}")]
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

        public async Task<IActionResult> GetAllCourses()
        {
            try
            {
                var response = await _courseService.GetAllCoursesAsync();
                return CreateActionResultInstance(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Route("/api/[controller]/GetAllCoursesByUserId/{userId}")]
        public async Task<IActionResult> GetAllCoursesByUserId(string userId)
        {
            try
            {
                var response = await _courseService.GetAllCoursesByUserIdAsync(userId);
                return CreateActionResultInstance(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPost]
        public async Task<IActionResult> CreateCourse(CourseCreateDTO courseCreateDTO)
        {
            try
            {
                var response = await _courseService.CreateCourseAsync(courseCreateDTO);
                return CreateActionResultInstance(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpPut]
        public async Task<IActionResult> UpdateCourse(CourseUpdateDTO courseUpdateDTO)
        {
            try
            {
                var response = await _courseService.UpdateCourseAsync(courseUpdateDTO);
                return CreateActionResultInstance(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourse(string id)
        {
            try
            {
                var response = await _courseService.DeleteCourseAsync(id);
                return CreateActionResultInstance(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
