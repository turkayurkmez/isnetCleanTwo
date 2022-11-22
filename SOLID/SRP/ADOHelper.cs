using System.Data.SqlClient;

namespace SRP
{
    public class ADOHelper
    {
        private SqlConnection sqlConnection = null;
        public ADOHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int Execute(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = createCommand(commandText, parameters);
            int affectedResult = 0;
            using (command.Connection)
            {
                command.Connection.Open();
                affectedResult = command.ExecuteNonQuery();
            }

            return affectedResult;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = commandText;
            addParametersToCommand(command, parameters);
            return command;
        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }

    }
}
