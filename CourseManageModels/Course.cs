using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManageModels
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseContent { get; set; }
        public int ClassHour { get; set; }
        public int CourseHour { get; set; }
        public int Credit { get; set; }
        public int TeacherId { get; set; }
        public int CategoryId { get; set; }

        //简单扩展实体属性
        public string CategoryName { get; set; }
        public string TeacherName { get; set; }
    }
}
