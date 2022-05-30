using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork.DB
{
    public class DBCommands
    {
        public string GetUserRole(string login, string password)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string role = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select user_role from logintable where user_login = @uL and user_password = @uP", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

                object usRole = cmd.ExecuteScalar();
                if (usRole != null)
                {
                    role = usRole.ToString();
                }
            }
            catch
            {
                role = "error";
            }
            finally
            {
                conn.Close();
            }
            return role;

        }

        public int GetUserId(string login, string password)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string id = "";
            int ID = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select id from logintable where user_login = @uL and user_password = @uP", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

                object usId = cmd.ExecuteScalar();
                if(usId != null)
                {
                    id = usId.ToString();
                    ID = Int32.Parse(id);
                }
            }
            catch
            {
                ID = 0;
            }
            finally
            {
                conn.Close();
            }
            return ID;

        }

        public void AddUser(string login, string password, string role)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into logintable (user_login, user_password, user_role) values (@uL, @uP, @uR)", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@uR", MySqlDbType.VarChar).Value = role;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddPersonalData(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into personaldata (user_id, user_name, user_surname, user_birthday, user_email) values (@uI, '---', '---', '2000-01-01', '---')", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddWorkData(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into workdata (user_id, post_id, department_id, education_id, ident_code) values (@uI, '8', '4', '4', '0000000000')", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddMessage(string subject, string text)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into messagetable (mess_date, mess_subject, mess_text) values (@uD, @uS, @uT)", conn);
                cmd.Parameters.Add("@uD", MySqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@uS", MySqlDbType.VarChar).Value = subject;
                cmd.Parameters.Add("@uT", MySqlDbType.VarChar).Value = text;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteUser(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from logintable where id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public string GetUserName(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string name = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select user_name from personaldata where user_id = @uL", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.Int32).Value = id;
                name = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                name = null;
            }
            finally
            {
                conn.Close();
            }
            return name;

        }

        public string GetUserSurname(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string surname = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select user_surname from personaldata where user_id = @uL", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.Int32).Value = id;
                surname = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                surname = null;
            }
            finally
            {
                conn.Close();
            }
            return surname;

        }

        public string GetUserEmail(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string email = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select user_email from personaldata where user_id = @uL", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.Int32).Value = id;
                email = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                email = null;
            }
            finally
            {
                conn.Close();
            }
            return email;

        }

        public string GetUserPost(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string post = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select post_name from post join workdata on post.id = workdata.post_id where workdata.user_id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                post = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                post = null;
            }
            finally
            {
                conn.Close();
            }
            return post;

        }

        public double GetUserSalary(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            double salary = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select salary from post join workdata on post.id = workdata.post_id where workdata.user_id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                salary = Double.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                salary = 0;
            }
            finally
            {
                conn.Close();
            }
            return salary;

        }

        public string GetUserDepartment(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string department = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select department_name from department join workdata on department.id = workdata.department_id where workdata.user_id = @uI;", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                department = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                department = "";
            }
            finally
            {
                conn.Close();
            }
            return department;

        }

        public string GetUserEducation(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string education = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select education_name from education join workdata on education.id = workdata.education_id where workdata.user_id = @uI;", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                education = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                education = "";
            }
            finally
            {
                conn.Close();
            }
            return education;

        }

        public double GetUserEducationAdd(string name)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            double perc = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand("select education_perc from education where education_name = @uI;", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.VarChar).Value = name;
                perc = Double.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {
                perc = 0;
            }
            finally
            {
                conn.Close();
            }
            return perc;

        }

        public string GetUserIdentCode(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            string email = "";

            try
            {
                MySqlCommand cmd = new MySqlCommand("select ident_code from workdata where user_id = @uL", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.Int32).Value = id;
                email = cmd.ExecuteScalar().ToString();
            }
            catch
            {
                email = null;
            }
            finally
            {
                conn.Close();
            }
            return email;

        }

        public DataTable GetUserByName(string text)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("select user_id, user_name, user_surname from personaldata where user_name = @uL or user_surname = @uL", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.VarChar).Value = text;
                dt.Load(cmd.ExecuteReader());
            }
            catch
            {
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        public DataTable GetUserByDepartment(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("select personaldata.user_id, personaldata.user_name, personaldata.user_surname from personaldata join workdata on personaldata.user_id = workdata.user_id where workdata.department_id = @uL", conn);
                cmd.Parameters.Add("@uL", MySqlDbType.Int32).Value = id;
                dt.Load(cmd.ExecuteReader());
            }
            catch
            {
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        public void ChangePersonalData(string name, string surname, string email, int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("update personaldata set user_name = @uN, user_surname = @uS, user_email = @uE where user_id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@uN", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uS", MySqlDbType.VarChar).Value = surname;
                cmd.Parameters.Add("@uE", MySqlDbType.VarChar).Value = email;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("error");
            }
            finally
            {
                conn.Close();
            }

        }

        public void ChangeWorkData(int post, int department, int education, int idcode, int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("update workdata set post_id = @uP, department_id = @uD, education_id = @uE, ident_code = @uC where user_id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@uP", MySqlDbType.Int32).Value = post;
                cmd.Parameters.Add("@uD", MySqlDbType.Int32).Value = department;
                cmd.Parameters.Add("@uE", MySqlDbType.Int32).Value = education;
                cmd.Parameters.Add("@uC", MySqlDbType.Int32).Value = idcode;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("error");
            }
            finally
            {
                conn.Close();
            }

        }

        public void AddDepartment(string name)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into department (department_name) values (@uD)", conn);
                cmd.Parameters.Add("@uD", MySqlDbType.VarChar).Value = name;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void AddPost(string name, int salary)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("insert into post (post_name, salary) values (@uP, @uS)", conn);
                cmd.Parameters.Add("@uP", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("@uS", MySqlDbType.Int32).Value = salary;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteDep(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from department where id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeletePost(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from post where id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                cmd.ExecuteNonQuery();
            }            
            catch
            {
                Console.WriteLine("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetWorkBook(int id)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("select change_date as `Дата`, old_data as `Стара інформація`, new_data as `Нова інформація` from workdatahistory where user_id = @uI", conn);
                cmd.Parameters.Add("@uI", MySqlDbType.Int32).Value = id;
                dt.Load(cmd.ExecuteReader());
            }
            catch
            {
                dt = null;
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

    }
}
