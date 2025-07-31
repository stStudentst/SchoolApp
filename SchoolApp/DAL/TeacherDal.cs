using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using SchoolApp.Entities;

namespace SchoolApp.DAL
    {
        public class TeacherDal
        {
            private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\School.mdf;Integrated Security=True";

        public List<Teacher> GetAllTeachers()
            {
                var teachers = new List<Teacher>();

                using (SqlConnection con = new SqlConnection(CONNECTION_STRING))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Teachers", con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        teachers.Add(new Teacher
                        {
                            Id = (int)reader["Id"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Email = reader["Email"].ToString()
                        });
                    }
                }

                return teachers;
            }
        }
    }
