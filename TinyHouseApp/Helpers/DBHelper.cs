using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TinyHouseApp.Helpers
{
    public static class DBHelper
    {
        private static readonly string connString = ConfigurationManager.ConnectionStrings["TinyHouseDB"].ConnectionString;

        public static DataTable GetDataTable(string sql, params SqlParameter[] pars)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (pars != null) cmd.Parameters.AddRange(pars);
                da.Fill(dt);
            }
            return dt;
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] pars)
        {
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (pars != null) cmd.Parameters.AddRange(pars);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] pars)
        {
            using (var conn = new SqlConnection(connString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (pars != null) cmd.Parameters.AddRange(pars);
                conn.Open();
                return cmd.ExecuteScalar();
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
