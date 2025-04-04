using System;
using MySqlConnector;

public class MySQLInserter
{
    private string connectionString = "Server=localhost;Database=centralita;User ID=root;Password=Conejo14@;";

    public void InsertLlamada(Llamada llamada)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO llamadas (num_origen, num_destino, duracion, precio) VALUES (@num_origen, @num_destino, @duracion, @precio)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@num_origen", llamada.getNumOrigen());
                    cmd.Parameters.AddWithValue("@num_destino", llamada.getNumDestino());
                    cmd.Parameters.AddWithValue("@duracion", llamada.getDuracion());
                    cmd.Parameters.AddWithValue("@precio", llamada.calcularPrecio());

                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Llamada insertada exitosamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error insertando llamada: " + ex.Message);
            }
        }
    }
}
