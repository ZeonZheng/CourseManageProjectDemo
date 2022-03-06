using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CourseManageModels;

namespace CourseManageDAL
{
    public class TeacherService
    {
        public Teacher TeacherLogin( Teacher teacher)
        {
            string sql = $"select TeacherName, TeacherId from Teacher where loginAccount='{teacher.LoginAccount}' and LoginPwd='{teacher.LoginPwd}'";
            
            SqlDataReader reader = SQLHelper.GetReader(sql);

            if (reader.Read())
            {
                teacher.TeacherId = (int)reader["TeacherId"];
                teacher.TeacherName = reader["TeacherName"].ToString();
            }
            else
            {
                teacher = null;
            }
            reader.Close();
            return teacher;
        }
    }
}
