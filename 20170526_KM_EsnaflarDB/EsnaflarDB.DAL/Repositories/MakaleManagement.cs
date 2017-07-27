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
    public class MakaleManagement : AbstractManagement, IMakaleRepository, IAdd<Makale>
    {
        public List<Makale> GetForKategori(int id)
        {           
            List<Makale> makaleler = new List<Makale>();

            SqlCommand cmd = new SqlCommand("Select * from Makaleler where KategoriID=@KategoriID", _conn);
            cmd.Parameters.AddWithValue("@KategoriID", id);
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
                        Makale makale = new Makale();
                        makale.MakaleID = Convert.ToInt32(dr["MakaleID"]);
                        makale.Baslik = dr["Baslik"].ToString();
                        makale.Icerik = dr["Icerik"].ToString();
                        makale.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                        makale.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]);
                        makale.YazarID = (Guid)dr["YazarID"];
                        makale.OkunmaSayisi = Convert.ToInt32(dr["OkunmaSayisi"]);
                        makale.ToplamPuan = Convert.ToInt32(dr["ToplamPuan"]);
                        makale.OyVerenKisiSayisi = Convert.ToInt32(dr["OyVerenKisiSayisi"]);
                        makaleler.Add(makale);
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

            return makaleler;
        }

        public List<Makale> Get()
        {
            List<Makale> makaleler = new List<Makale>();
            SqlCommand cmd = new SqlCommand("Select * from Makaleler", _conn);

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
                            Makale makale = new Makale();
                            makale.MakaleID = Convert.ToInt32(dr["MakaleID"]);
                            makale.Baslik = dr["Baslik"].ToString();
                            makale.Icerik = dr["Icerik"].ToString();
                            makale.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                            makale.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]);
                            makale.YazarID = (Guid)dr["YazarID"];
                            makale.OkunmaSayisi = Convert.ToInt32(dr["OkunmaSayisi"]);
                            makale.ToplamPuan = Convert.ToInt32(dr["ToplamPuan"]);
                            makale.OyVerenKisiSayisi = Convert.ToInt32(dr["OyVerenKisiSayisi"]);
                            makaleler.Add(makale);                      
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

                return makaleler;
            }

        public Makale Get(int id)
        {
                Makale makale = null;
                SqlCommand cmd = new SqlCommand("Select * from Kategoriler where MakaleID=@MakaleID", _conn);
                cmd.Parameters.AddWithValue("@MakaleID", id);

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
                            makale = new Makale();
                            makale.MakaleID = Convert.ToInt32(dr["MakaleID"]);
                            makale.Baslik = dr["Baslik"].ToString();
                            makale.Icerik = dr["Icerik"].ToString();
                            makale.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                            makale.KayitTarihi = Convert.ToDateTime(dr["KayitTarihi"]);
                            makale.YazarID = (Guid)dr["YazarID"];
                            makale.OkunmaSayisi = ((dr["OkunmaSayisi"])!=DBNull.Value? Convert.ToInt32(dr["OkunmaSayisi"]):0);
                            makale.ToplamPuan = Convert.ToInt32(dr["ToplamPuan"]);
                            makale.OyVerenKisiSayisi = ((dr["OyVerenKisiSayisi"]) != DBNull.Value ? Convert.ToInt32(dr["OyVerenKisiSayisi"]) : 0);
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

                return makale;
           }



        public bool Add(Makale obj)   //makale eklemesi yapıyoruz
        {
            SqlCommand cmd = new SqlCommand("Insert into Makaleler(Baslik, Icerik,CategoryID,YazarID values(@Baslik, @Icerik,@CategoryID,@YazarID)", _conn);
            cmd.Parameters.AddWithValue("@Baslik", obj.Baslik);
            cmd.Parameters.AddWithValue("@Icerik", obj.Icerik);
            cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryID);
            cmd.Parameters.AddWithValue("@YazarID", obj.YazarID);

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
    }
}
