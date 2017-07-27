using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsnaflarDB.Entity;
using EsnaflarDB.DAL.IRepositories;
using System.Data.SqlClient;
using System.Data;


namespace EsnaflarDB.DAL.Repositories
{
    public class SehirManagement:AbstractManagement,ICrudRepository<Sehir,int>
    {
        public bool Add(Sehir obj)
        {
            SqlCommand cmd = new SqlCommand("Insert into Sehir(SehirID,SehirAdi) values(@SehirID,@SehirAdi)", _conn);
            cmd.Parameters.AddWithValue("@SehirID", obj.SehirID);
            cmd.Parameters.AddWithValue("@SehirAdi", obj.SehirAdi);

            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                _conn.Dispose();
                cmd.Dispose();
            }
        }

        public bool Update(Sehir obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Sehir obj)
        {
            throw new NotImplementedException();
        }

        public List<Sehir> Get()
        {
            List<Sehir> sehirler = new List<Sehir>();
            SqlCommand cmd = new SqlCommand("Select * from Sehirler", _conn);

            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Sehir sehir = new Sehir();
                        sehir.SehirID = Convert.ToInt32(dr["SehirID"]);
                        sehir.SehirAdi = dr["SehirAdi"].ToString();
                        sehirler.Add(sehir);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                _conn.Dispose();
            }

            return sehirler;
        }

        public Sehir Get(int id)
        {
            Sehir sehir = null;
            SqlCommand cmd = new SqlCommand("Select * from Sehirler where SehirID=@SehirID", _conn);
            cmd.Parameters.AddWithValue("@SehirID", id);

            try
            {
                if (_conn.State == ConnectionState.Closed)
                {
                    _conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        sehir = new Sehir();
                        sehir.SehirID = Convert.ToInt32(dr["SehirID"]);
                        sehir.SehirAdi = dr["SehirAdi"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
                _conn.Dispose();
            }

            return sehir;
        }
    }
}
