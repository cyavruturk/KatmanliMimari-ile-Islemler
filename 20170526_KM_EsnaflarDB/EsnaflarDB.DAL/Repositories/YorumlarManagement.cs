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
    public class YorumlarManagement : AbstractManagement, ICrudRepository<Yorum, int>
    {
        public bool Add(Yorum obj)
        {
            SqlCommand cmd = new SqlCommand("Insert into Yorumlar(YorumID,AdSoyad,YorumIcerik,Email,MakaleID,WebSitesi,Onaylandimi,YorumTarihi) values(@YorumID,@AdSoyad,@YorumIcerik,@Email,@MakaleID,@WebSitesi,@Onaylandimi,@YorumTarih)", _conn);
            cmd.Parameters.AddWithValue("@YorumID", obj.YorumID);
            cmd.Parameters.AddWithValue("@AdSoyad", obj.AdSoyad);
            cmd.Parameters.AddWithValue("@YorumIcerik", obj.YorumIcerik);
            cmd.Parameters.AddWithValue("@Email", obj.Email);
            cmd.Parameters.AddWithValue("@MakaleID", obj.MakaleID);
            cmd.Parameters.AddWithValue("@WebSitesi", obj.WebSitesi);
            cmd.Parameters.AddWithValue("@Onaylandimi", obj.Onaylandimi);
            cmd.Parameters.AddWithValue("@YorumTarihi", obj.YorumTarihi);

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

        public bool Update(Yorum obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Yorum obj)
        {
            throw new NotImplementedException();
        }

        public List<Yorum> Get()
        {
            List<Yorum> yorumlar = new List<Yorum>();
            SqlCommand cmd = new SqlCommand("Select * from Yorumlar", _conn);

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
                        Yorum yorum = new Yorum();
                        yorum.YorumID = Convert.ToInt32(dr["YorumID"]);
                        yorum.AdSoyad = dr["AdSoyad"].ToString();
                        yorum.YorumIcerik = dr["YorumIcerik"].ToString();
                        yorum.Email = dr["Email"].ToString();
                        yorum.MakaleID = Convert.ToInt32(dr["MakaleID"]);
                        yorum.WebSitesi = (dr["WebSitesi"]).ToString();
                        yorum.Onaylandimi =(bool)dr["Onaylandimi"];
                        yorum.YorumTarihi = Convert.ToDateTime(dr["YorumTarihi"]);
                        yorumlar.Add(yorum);
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

            return yorumlar;
        }

        public Yorum Get(int id)
        {
            Yorum yorum = null;
            SqlCommand cmd = new SqlCommand("Select * from Yorumlar where YorumID=@YorumID", _conn);
            cmd.Parameters.AddWithValue("@YorumID", id);

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
                        yorum = new Yorum();
                        yorum.YorumID = Convert.ToInt32(dr["YorumID"]);
                        yorum.AdSoyad = dr["AdSoyad"].ToString();
                        yorum.YorumIcerik = dr["YorumIcerik"].ToString();
                        yorum.Email = dr["Email"].ToString();
                        yorum.MakaleID = Convert.ToInt32(dr["MakaleID"]);
                        yorum.WebSitesi = (dr["WebSitesi"]).ToString();
                        yorum.Onaylandimi = (bool)dr["Onaylandimi"];
                        yorum.YorumTarihi = Convert.ToDateTime(dr["YorumTarihi"]);
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
            return yorum;
        }
    }
}
