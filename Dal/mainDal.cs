using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buninessObjects;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using buninessObjects;
namespace Dal
{
    public class mainDal
    {
        string path= @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Study\Bachelors\6 semester\EAD\Assignments\TeacherFacilitationSystem\Dal\tsFacility.mdf;Integrated Security=True";
        SqlConnection con;
        public void makeConnection()
        {
            con = new SqlConnection(path);
            con.Open();
             
        }

        public int getQuizId()
        {
            int id = 0;
            makeConnection();
            string query = "select max(qId) from quiz";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                id = (int)cmd.ExecuteScalar();
            }
            catch
            {
                id = 0;
            }

            return id;
        }
        public bool Login(string name, string pass, string designation)
        {
            makeConnection();
            string query = "select * from userInformation  where name=@n AND password=@p AND designation=@d";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter name1 = new SqlParameter("n",name);
            SqlParameter passWord = new SqlParameter("p",pass);
            SqlParameter des = new SqlParameter("d",designation);
            cmd.Parameters.Add(name1);
            cmd.Parameters.Add(passWord);
            cmd.Parameters.Add(des);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                
                con.Close();
                return true;
            }

            return false;
        }

        public void post(announcement a)
        {
            makeConnection();
            string query = "insert into announcement (title,contents,postDate) values(@ti,@co,@pd)";
            SqlParameter t=new SqlParameter("ti",a.Title);
            SqlParameter c = new SqlParameter("co", a.Contents);
            SqlParameter p = new SqlParameter("pd", a.Date);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(t);
            cmd.Parameters.Add(c);
            cmd.Parameters.Add(p);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public List<announcement> getALLPost()
        {
            makeConnection();
            List<announcement> li = new List<buninessObjects.announcement>();
            string query = "select * from announcement";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                announcement a = new buninessObjects.announcement();
                a.Title = (string)reader[1];
                a.Contents = (string)reader[2];
                li.Add(a);

            }
            return li;
        }

        public void addStudent1(user obj)
        {
            makeConnection();
            string query = "insert into userInformation (name,password,email,designation) values (@n,@p,@e,@d)";
            SqlParameter p1 = new SqlParameter("n", obj.Name);
            SqlParameter p2 = new SqlParameter("p", obj.Password);
            SqlParameter p3 = new SqlParameter("e", obj.Email);
            SqlParameter p4 = new SqlParameter("d", obj.Designation);

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.ExecuteNonQuery();
            con.Close();

        }

        public user getDetail(string name)
        {
            user u = new user(); 
            makeConnection();
            string query = "select * from userInformation where name=@n";
            SqlParameter p = new SqlParameter("n", name);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                u.Name = (string)reader[1];
                u.Password = (string)reader[2];
                u.Email = (string)reader[3];
                u.Designation = (string)reader[4];
            }

            return u;
        }

        public void update(user u,string name)
        {
            makeConnection();
            string query = "update userinformation set name=@nm,password=@pw,email=@em where name=@on";

            SqlParameter p1 = new SqlParameter("nm", u.Name);
            SqlParameter p2 = new SqlParameter("pw", u.Password);
            SqlParameter p3 = new SqlParameter("em", u.Email);
            SqlParameter p4 = new SqlParameter("on", name);

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void addResult(result r)
        {
            makeConnection();
            string query = "insert into result (qId,total,attempt,correct,quizTime,name,incorrect) values (@q,@t,@a,@c,@qt,@n,@in)";
            SqlParameter p1=new SqlParameter("q",r.Qid);
            SqlParameter p2 = new SqlParameter("t", r.Total);
            SqlParameter p3 = new SqlParameter("a", r.Attempt);
            SqlParameter p4 = new SqlParameter("c", r.Correct);
            SqlParameter p5 = new SqlParameter("qt", r.Timing);
            SqlParameter p6 = new SqlParameter("n", r.Name);
            SqlParameter p7 = new SqlParameter("in", (r.Attempt-r.Correct));
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updatePassword(string name, string pwd)
        {
            makeConnection();
            string query = "update userinformation set password=@pw where name=@on";

            SqlParameter p1 = new SqlParameter("on",name );
            SqlParameter p2 = new SqlParameter("pw", pwd);
            

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
           

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void addQuiz(List<quiz> li)
        {
            makeConnection();
            int i=getQuizId();
            i = i + 1;
            string query = "insert into quiz(qId,statement,optionA,optionB,optionC,optionD,correct) values (@i,@s,@a,@b,@c,@d,@co)";
            foreach (quiz q in li)
            {
                
                SqlParameter p1 = new SqlParameter("i", i);
                SqlParameter p2 = new SqlParameter("s", q.Statement);
                SqlParameter p3 = new SqlParameter("a", q.OptionA);
                SqlParameter p4 = new SqlParameter("b", q.OptionB);
                SqlParameter p5 = new SqlParameter("c", q.OptionC);
                SqlParameter p6 = new SqlParameter("d", q.OptionD);
                SqlParameter p7 = new SqlParameter("co", q.Correct);

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public List<quiz> startQuiz()
        {
            List<quiz> li = new List<buninessObjects.quiz>();
            makeConnection();
            string query = "select * from quiz where qid=" + getQuizId();
            SqlCommand cmd = new SqlCommand(query, con);
            string co;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                quiz q = new buninessObjects.quiz();
                q.QID = (int)r[1];
                q.Statement = (string)r[2];
                q.OptionA = (string)r[3];
                q.OptionB = (string)r[4];
                q.OptionC = (string)r[5];
                q.OptionD = (string)r[6];
               co = (string)r[7];
               q.Correct = char.Parse(co);
                li.Add(q);

            }

            return li;
        }
         public void deleteQuiz(int id)
        {
            
            makeConnection();
            string query = "delete from quiz where qid=" +id;
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            string query1 = "delete from result where qid=" + id;
            SqlCommand cmd1 = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();
            
        }

         public DataTable getAllQuizez()
         {
             makeConnection();
             DataTable targetTable = new DataTable();
             SqlDataAdapter dl = new SqlDataAdapter();
             SqlCommand forselectAll = new SqlCommand("Select * from quiz", con);
             dl.SelectCommand = forselectAll;
             dl.Fill(targetTable);

             return targetTable;

         }

         public DataTable getReport()
         {
             makeConnection();
             DataTable targetTable = new DataTable();
             SqlDataAdapter dl = new SqlDataAdapter();
             SqlCommand forselectAll = new SqlCommand("Select name,qId,total,attempt,correct,incorrect,quizTime from result", con);
             dl.SelectCommand = forselectAll;
             dl.Fill(targetTable);

             return targetTable;

         }

         public DataTable getPArticularReport(string name)
         {
             makeConnection();
             DataTable targetTable = new DataTable();
             SqlDataAdapter dl = new SqlDataAdapter();
             SqlCommand forselectAll = new SqlCommand("Select name,qId,total,attempt,correct,incorrect,quizTime from result where name=@na", con);

             SqlParameter p = new SqlParameter("na", name);
             forselectAll.Parameters.Add(p);
             dl.SelectCommand = forselectAll;
             dl.Fill(targetTable);

             return targetTable;

         }
    }
}
