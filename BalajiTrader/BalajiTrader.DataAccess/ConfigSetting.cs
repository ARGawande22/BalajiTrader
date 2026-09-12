using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.DataAccess
{
    public class ConfigSetting
    {
        #region
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string Con = ConfigurationManager.AppSettings["Connection"].ToString();
        private static string api = ConfigurationManager.AppSettings["api"].ToString();
        public static string ConnectionString { get; private set; }
        private const string EncryptionKey = "EfiMitra";
        #endregion

        public static async Task<string> GetConnection()
        {
            return ConfigurationManager.ConnectionStrings[Con].ToString();
        }

        public static async Task InitializeAsync()
        {
            try
            {
                //ConnectionString = await GetConnectionStringAsync(Con);
                ConnectionString = await GetConnection();
            }
            catch (Exception ex)
            {
                log.Error("Error Initializing db connection string..." + ex.Message);
            }
        }

        public static async Task<string> GetConnectionStringAsync(string connectionName)
        {
            try
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback =
                        HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                using var client = new HttpClient(handler);

                string url = $"{api}config/connectionstring/{connectionName}";

                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(
                    $"Failed to fetch connection string '{connectionName}' from API.",
                    ex);
            }
        }

        #region Encryption & Decryption
        public static string Decrypt_ConString()
        {
            byte[] Bytes = null;
            byte[] saltBytes = new byte[] { 2, 1, 7, 3, 6, 4, 8, 5 };
            byte[] bytesToBeEncryptedDecrypted = Convert.FromBase64String(ConnectionString);
            byte[] passwordBytesEncryptDecrypt = Encoding.UTF8.GetBytes(EncryptionKey);
            passwordBytesEncryptDecrypt = SHA256.Create().ComputeHash(passwordBytesEncryptDecrypt);

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;
                    var key = new Rfc2898DeriveBytes(passwordBytesEncryptDecrypt, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);
                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncryptedDecrypted, 0, bytesToBeEncryptedDecrypted.Length);
                        cs.Close();
                    }
                    Bytes = ms.ToArray();
                }
            }
            return Encoding.UTF8.GetString(Bytes); ;
        }
        #endregion
    }
}
