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

    public void AddHouse(House house)
    {
        try
        {
            using (var con = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Houses (Title, Description, ImageData) VALUES (@Title, @Description, @ImageData)";
                using (var cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = house.Title;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = house.Description ?? (object)DBNull.Value;
                  

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Ev eklenirken bir hata oluştu: " + ex.Message);
        }
    }


    public List<House> GetAllHouses()
    {
        var houses = new List<House>();

        using (var con = new SqlConnection(_connectionString))
        {
            string sql = "SELECT Id, Title, Description, ImageData FROM Houses ORDER BY Id DESC";
            using (var cmd = new SqlCommand(sql, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        houses.Add(new House
                        {
                            HouseID = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                         
                        });
                    }
                }
            }
        }

        return houses;
    }
}
