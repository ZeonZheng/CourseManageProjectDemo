using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourseManageDAL;
using CourseManageModels;

namespace CourseManageBLL
{
    public class CourseManager
    {
        private CourseService courseService = new CourseService();

        #region 添加课程
        public int AddCourse(Course course)
        {
            return courseService.AddCourse(course);
        }
        #endregion

        #region 查询课程
        /// <summary>
        /// 根据多个查询条件动态组合查询
        /// </summary>
        /// <param name="categoryId">课程分类编号</param>
        /// <param name="courseName">课程名称</param>
        /// <returns></returns>
        public List<Course> QueryCourse(int categoryId, string courseName)
        {
            return courseService.QueryCourse(categoryId, courseName);
        }
        #endregion

        #region 修改课程
        public int ModifyCourse(Course course)
        {
            return courseService.ModifyCourse(course);
        }
        #endregion

        #region 删除课程
        public int DeleteCourse(Course course)
        {
            return courseService.DeleteCourse(course);
        }
        #endregion
    }
}
