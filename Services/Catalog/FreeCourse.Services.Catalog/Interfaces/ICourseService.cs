using AutoMapper;
using FreeCourse.Services.Catalog.Config;
using FreeCourse.Services.Catalog.DTO;
using FreeCourse.Services.Catalog.Models;
using FreeCourse.Shared.DTO;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Interfaces
{
    internal interface ICourseService
    {

         Task<Response<List<CourseDTO>>> GetAllCoursesAsync();

         Task<Response<CourseDTO>> GetCourseById(string id);

          Task<Response<List<CourseDTO>>> GetAllCoursesByUserIdAsync(string userId);

          Task<Response<CourseDTO>> CreateCourseAsync(CourseCreateDTO courseCreateDTO);


          Task<Response<NoContent>> UpdateCourseAsync(CourseUpdateDTO courseUpdateDTO);


          Task<Response<NoContent>> DeleteCourseAsync(string id);
    }
}
