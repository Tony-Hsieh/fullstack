using System;
using System.Collections.Generic;
using System.Text;
using Antra.Training.Company.Data.Models;
using System.Data.SqlClient;
namespace Antra.Training.Company.Data.Repositories
{
    public class DeptRepository : IRepository<Dept>
    {
        CompanyDBContext db;
        public DeptRepository()
        {
            db = new CompanyDBContext();
        }

        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete from Dept where id=@id";
                cmd.Parameters.AddWithValue("@id", id);


                cmd.Connection = connection;

                int r = cmd.ExecuteNonQuery();

                connection.Close();
                return r;
            }

        }

        public IEnumerable<Dept> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Id, DName, Loc from Dept";

                cmd.Connection = connection;

                SqlDataReader reader = cmd.ExecuteReader();
                List<Dept> lstCollection = new List<Dept>();
                while (reader.Read())
                {
                    Dept d = new Dept();
                    d.Id = Convert.ToInt32(reader["Id"]);
                    d.DName = Convert.ToString(reader["DName"]);
                    d.Loc = Convert.ToString(reader["Loc"]);
                    lstCollection.Add(d);
                }
                connection.Close();
                return lstCollection;
            }

        }

        public Dept GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Id, DName, Loc from Dept where id=@id";
                cmd.Parameters.AddWithValue("@id", id);

                cmd.Connection = connection;

                SqlDataReader reader = cmd.ExecuteReader();
                Dept d = new Dept();
                while (reader.Read())
                {

                    d.Id = Convert.ToInt32(reader["Id"]);
                    d.DName = Convert.ToString(reader["DName"]);
                    d.Loc = Convert.ToString(reader["Loc"]);

                }
                connection.Close();
                return d;
            }


        }

        public int Insert(Dept obj)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into Dept values (@dname,@loc)";
                cmd.Parameters.AddWithValue("@dname", obj.DName);
                cmd.Parameters.AddWithValue("@loc", obj.Loc);

                cmd.Connection = connection;

                int r = cmd.ExecuteNonQuery();

                connection.Close();
                return r;
            }


            //connection.Dispose();
            //cmd.Dispose();

        }

        public int Update(Dept obj)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update dept set DName =@dname, Loc =@loc where Id =@id";
                cmd.Parameters.AddWithValue("@dname", obj.DName);
                cmd.Parameters.AddWithValue("@loc", obj.Loc);
                cmd.Parameters.AddWithValue("@id", obj.Id);

                cmd.Connection = connection;

                int r = cmd.ExecuteNonQuery();

                connection.Close();
                return r;
            }

        }
    }
}
