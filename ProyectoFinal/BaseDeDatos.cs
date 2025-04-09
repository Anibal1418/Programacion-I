using System;
using MySqlConnector;

public class MySQLInserter
{
    private string connectionString = "Server=localhost;Database=game_data;User ID=root;Password=*********;";

    public void InsertGameData(int enemigosAbatidos, int rondasSobrevividas)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO datos_sesion (enemigos_abatidos, rondas_sobrevividas) VALUES (@enemigos_abatidos, @rondas_sobrevividas)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@enemigos_abatidos", enemigosAbatidos);
                    cmd.Parameters.AddWithValue("@rondas_sobrevividas", rondasSobrevividas);

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Datos de Sesion Insertados exitosamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error insertando datos: " + ex.Message);
            }
        }
    }
}
