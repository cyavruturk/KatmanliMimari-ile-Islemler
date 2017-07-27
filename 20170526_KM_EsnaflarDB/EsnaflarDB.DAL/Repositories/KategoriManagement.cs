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
    public class KategoriManagement : AbstractManagement, ICrudRepository<Kategori,int>
    {
        public bool Add(Kategori obj)   //kategori eklemesi yapıyoruz
        {
            SqlCommand cmd = new SqlCommand("Insert into Kategoriler(KategoriID,KategoriAdi) values(@KategoriID,@KategoriAdi)", _conn);
            cmd.Parameters.AddWithValue("@KategoriID", obj.KategoriID);
            cmd.Parameters.AddWithValue("@KategoriAdi", obj.KategoriAdi);

            try
            {
                if(_conn.State==ConnectionState.Closed)
                {
                    _conn.Open();
                }
                
                if(cmd.ExecuteNonQuery()>0)
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

        public bool Update(Kategori obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Kategori obj)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> Get()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler", _conn);

            try
            {
                if(_conn.State==ConnectionState.Closed)
                {
                    _conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Kategori kategori = new Kategori();
                        kategori.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                        kategori.KategoriAdi = dr["KategoriAdi"].ToString();
                        kategoriler.Add(kategori);
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

            return kategoriler;

        }

        public Kategori Get(int id)   //seçili id getir
        {
            Kategori kategori = null;
            SqlCommand cmd = new SqlCommand("Select * from Kategoriler where KategoriID=@KategoriID", _conn);
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
                        kategori = new Kategori();
                        kategori.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                        kategori.KategoriAdi = dr["KategoriAdi"].ToString();
                        
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

            return kategori;
        }
    }
}
