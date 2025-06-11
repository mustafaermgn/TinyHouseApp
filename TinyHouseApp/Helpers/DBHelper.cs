using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;

namespace TinyHouseApp.Helpers
{
    public static class DBHelper
    {
        private static readonly string connString = ConfigurationManager.ConnectionStrings["TinyHouseDB"].ConnectionString;

        public static DataTable GetDataTable(string sql, params SqlParameter[] pars)
        {
            var dt = new DataTable();
            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(sql, conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    if (pars != null) cmd.Parameters.AddRange(pars);
                    da.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
       
                throw new Exception("Veri çekme hatası: " + ex.Message, ex);
            }
        }

        public static int ExecuteNonQuery(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
           
                throw new Exception("Sorgu çalıştırma hatası: " + ex.Message, ex);
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            return ExecuteNonQuery(sql, CommandType.Text, parameters);
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] pars)
        {
            try
            {
                using (var conn = new SqlConnection(connString))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    if (pars != null) cmd.Parameters.AddRange(pars);
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
               
                throw new Exception("Skaler değer çekme hatası: " + ex.Message, ex);
            }
        }

        public static DataTable GetHouseImages(int houseId)
        {
            return GetDataTable(
                "SELECT * FROM HouseImages WHERE HouseID=@h",
                new SqlParameter("@h", houseId)
            );
        }

        public static int AddHouseImage(int houseId, string path)
        {
            return ExecuteNonQuery(
                "INSERT INTO HouseImages(HouseID,ImagePath) VALUES(@h,@p)",
                new SqlParameter("@h", houseId),
                new SqlParameter("@p", path)
            );
        }

        public static int DeleteHouseImage(int imageId)
        {
            return ExecuteNonQuery(
                "DELETE FROM HouseImages WHERE ImageID=@i",
                new SqlParameter("@i", imageId)
            );
        }
    }
}