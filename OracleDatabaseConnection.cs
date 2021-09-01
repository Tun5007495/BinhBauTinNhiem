using Oracle.ManagedDataAccess.Client;
using System;

namespace BinhBauTinNhiem
{
    class OracleDatabaseConnection
    {
        public static bool isConnected = false;
        private static OracleConnection oracleConnection = null;
        public static OracleConnection GetConnection()
        {
            return oracleConnection;
        }

        [Obsolete]
        public static OracleConnection Login(string username, string password)
        {
            string connectionStringFormat = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
            string orldb = String.Format(connectionStringFormat, username, password);
            try
            {
                oracleConnection = new OracleConnection(orldb);
                oracleConnection.Open();
                isConnected = true;
                UserUtils.username = username.ToUpper();
                return oracleConnection;
            }
            catch (OracleException e)
            {
                return null;
            }
        }
        public static void CloseConnection()
        {
            if (oracleConnection != null)
            {
                oracleConnection.Close();
                isConnected = false;
            }
        }
    }
}
