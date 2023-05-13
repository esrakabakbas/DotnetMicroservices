using System;

namespace FreeCourse.Services.Catalog.DTO
{
    internal class CourseCreateDTO
    {
        public string CategoryId { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; } // Kursu verenin User Id'si
        public string Description { get; set; }
        public FeatureDTO Feature { get; set; }
    }
}
