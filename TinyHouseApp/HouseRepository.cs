using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Models;

public class HouseRepository
{
    private readonly string _connectionString;

    public HouseRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int AddHouse(House house)
    {
        using (var con = new SqlConnection(_connectionString))
        {
            con.Open();
            string sql = @"INSERT INTO Houses(OwnerID,Title,Description,PricePerNight,Location,IsActive)
                            VALUES(@o,@t,@d,@p,@l,@a); SELECT SCOPE_IDENTITY();";
            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@o", house.OwnerID);
                cmd.Parameters.AddWithValue("@t", house.Title);
                cmd.Parameters.AddWithValue("@d", house.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@p", house.PricePerNight);
                cmd.Parameters.AddWithValue("@l", house.Location ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@a", house.IsActive);
                house.HouseID = Convert.ToInt32(cmd.ExecuteScalar());
            }

            if (house.ImagePaths != null)
            {
                foreach (var path in house.ImagePaths)
                {
                    using var cmdImg = new SqlCommand("INSERT INTO HouseImages(HouseID,ImagePath) VALUES(@h,@p)", con);
                    cmdImg.Parameters.AddWithValue("@h", house.HouseID);
                    cmdImg.Parameters.AddWithValue("@p", path);
                    cmdImg.ExecuteNonQuery();
                }
            }
        }

        return house.HouseID;
    }

    public List<House> GetAllHouses()
    {
        var houses = new List<House>();

        using (var con = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Houses ORDER BY HouseID DESC";
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        houses.Add(new House
                        {
                            HouseID = reader.GetInt32(reader.GetOrdinal("HouseID")),
                            OwnerID = reader.GetInt32(reader.GetOrdinal("OwnerID")),
                            Title = reader.GetString(reader.GetOrdinal("Title")),
                            Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                            PricePerNight = reader.GetDecimal(reader.GetOrdinal("PricePerNight")),
                            Location = reader.IsDBNull(reader.GetOrdinal("Location")) ? null : reader.GetString(reader.GetOrdinal("Location")),
                            IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                            ImagePaths = new List<string>()
                        });
                    }
                }

                // load images for each house
                foreach (var h in houses)
                {
                    cmd.CommandText = "SELECT ImagePath FROM HouseImages WHERE HouseID=@h";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@h", h.HouseID);
                    using var rImg = cmd.ExecuteReader();
                    while (rImg.Read())
                    {
                        h.ImagePaths.Add(rImg.GetString(0));
                    }
                    rImg.Close();
                }
            }
        }

        return houses;
    }
}
