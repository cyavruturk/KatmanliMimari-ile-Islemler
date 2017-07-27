using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsnaflarDB.Entity;
using EsnaflarDB.DAL.IRepositories;
using System.Data.SqlClient;
using System.Data;
using Extension;

namespace EsnaflarDB.DAL.Repositories
{
    public class UyeKisiselManagement : AbstractManagement, ICrudRepository<UyeKisisel, int>
    {

        public bool Add(UyeKisisel obj)
        {
            SqlCommand cmd = new SqlCommand("Insert into UyeKisisel(UyeID,Ad,Soyad,Cinsiyet,DogumTarihi,Telefon,Adres,IlceID) values(@UyeID,@Ad,@Soyad,@Cinsiyet,@DogumTarihi,@Telefon,@Adres,@IlceID)", _conn);
            cmd.Parameters.AddWithValue("@UyeID", obj.UyeID);
            cmd.Parameters.AddWithValue("@Ad", obj.Ad);
            cmd.Parameters.AddWithValue("@Soyad", obj.Soyad);
            cmd.Parameters.AddWithValue("@Cinsiyet", obj.Cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi", obj.DogumTarihi);
            cmd.Parameters.AddWithValue("@Telefon", obj.Telefon);
            cmd.Parameters.AddWithValue("@Adres", obj.Adres);
            cmd.Parameters.AddWithValue("@IlceID", obj.IlceID);

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

        public bool Update(UyeKisisel obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(UyeKisisel obj)
        {
            throw new NotImplementedException();
        }

        public List<UyeKisisel> Get()
        {
            List<UyeKisisel> uyekisiseller = new List<UyeKisisel>();
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
                        UyeKisisel UyeKisisel = new UyeKisisel();
                        UyeKisisel.UyeID = (Guid)(dr["UyeID"]);
                        UyeKisisel.Ad = dr["Ad"].ToString();
                        UyeKisisel.Soyad = dr["Soyad"].ToString();
                        UyeKisisel.Cinsiyet = (bool)dr["Cinsiyet"];
                        UyeKisisel.DogumTarihi = Convert.ToDateTime(dr["DogumTarihi"]);
                        UyeKisisel.Telefon = (dr["Telefon"]).ToString();
                        UyeKisisel.Adres = dr["Adres"].ToString();
                        UyeKisisel.IlceID = Convert.ToInt32(dr["IlceID"]);
                        uyekisiseller.Add(UyeKisisel);
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

            return uyekisiseller;
        }

        public UyeKisisel Get(int id)
        {
            UyeKisisel UyeKisisel = null;
            SqlCommand cmd = new SqlCommand("Select * from UyeKisisel where UyeID=@UyeID", _conn);
            cmd.Parameters.AddWithValue("@UyeID", id);

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
                        UyeKisisel = new UyeKisisel();
                        UyeKisisel.UyeID = (Guid)(dr["UyeID"]);
                        UyeKisisel.Ad = dr["Ad"].ToString();
                        UyeKisisel.Soyad = dr["Soyad"].ToString();
                        UyeKisisel.Cinsiyet = (bool)dr["Cinsiyet"];
                        UyeKisisel.DogumTarihi = Convert.ToDateTime(dr["DogumTarihi"]);
                        UyeKisisel.Telefon = (dr["Telefon"]).ToString();
                        UyeKisisel.Adres = dr["Adres"].ToString();
                        UyeKisisel.IlceID = Convert.ToInt32(dr["IlceID"]);
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

            return UyeKisisel;
        }
    }
}
