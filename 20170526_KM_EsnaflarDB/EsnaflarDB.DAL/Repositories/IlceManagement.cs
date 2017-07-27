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
    public class IlceManagement:AbstractManagement, ICrudRepository<Ilce,int>,IIlceRepository

    {

        public bool Add(Ilce obj)
        {
            SqlCommand cmd = new SqlCommand("Insert into Ilceler(IlceID,IlceAdi,SehirID) values(@IlceID,@IlceAdi,@SehirID)", _conn);
            cmd.Parameters.AddWithValue("@IlceID", obj.IlceID);
            cmd.Parameters.AddWithValue("@IlceAdi", obj.IlceAdi);
            cmd.Parameters.AddWithValue("@SehirID", obj.SehirID);
            

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

        public bool Update(Ilce obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Ilce obj)
        {
            throw new NotImplementedException();
        }

        public List<Ilce> Get() //ilcelerin tümünü getirecek
        {
            List<Ilce> ilceler = new List<Ilce>();
            SqlCommand cmd = new SqlCommand("Select * from Ilceler", _conn);

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
                        Ilce ilce = new Ilce();
                        ilce.IlceID = Convert.ToInt32(dr["IlceID"]);
                        ilce.IlceAdi = dr["IlceAdi"].ToString();
                        ilce.SehirID =Convert.ToInt32(dr["SehirID"]);
                  
                        ilceler.Add(ilce);
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

            return ilceler;
        }

        public Ilce Get(int id)     //İlce id sine göre getiricek 
        {
            Ilce ilce = null;
            SqlCommand cmd = new SqlCommand("Select * from Ilceler where IlceID=@IlceID", _conn);
            cmd.Parameters.AddWithValue("@IlceID", id);

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
                        ilce = new Ilce();
                        ilce.IlceID = Convert.ToInt32(dr["IlceID"]);
                        ilce.IlceAdi = dr["IlceAdi"].ToString();
                        ilce.SehirID = Convert.ToInt32(dr["SehirID"]);
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

            return ilce;
        }

        public List<Ilce> GetAllForCity(int cityId)   //Sehir id si neyse ilce id ona göre getirecek
        {
            List<Ilce> ilceler = new List<Ilce>();
            SqlCommand cmd = new SqlCommand("Select * from Ilceler where SehirID=@SehirID", _conn);
            cmd.Parameters.AddWithValue("SehirID", cityId);

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
                        Ilce ilce = new Ilce();
                        ilce.IlceID = Convert.ToInt32(dr["IlceID"]);
                        ilce.IlceAdi = dr["IlceAdi"].ToString();
                        ilce.SehirID = Convert.ToInt32(dr["SehirID"]);

                        ilceler.Add(ilce);
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

            return ilceler;
        }
    }
}
