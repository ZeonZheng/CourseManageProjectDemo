using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class TeacherManager
    {
        private TeacherService teacherService = new TeacherService();

        public Teacher TeacherLogin(Teacher teacher)
        {
            teacher = teacherService.TeacherLogin(teacher);
            return teacher;
        }
    }
}
