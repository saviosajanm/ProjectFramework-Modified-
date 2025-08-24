using ProjectFrameworkCommonLib;
using ProjectFramework.Web.Utils;
using System;
using System.Data;

namespace ProjectFramework.Web.BLL
{
    public class BLLBase
    {
        public static string WebApplicationPath { get; set; }
        public DatabaseUtils m_objDatabaseUtils = new DatabaseUtils();

        //Whether to encrypt OTP Password is a strategy which we need to decide later
        //So Just implementing a passthrough function for now
        public static string Encrypt(string Password)
        {
            return PFCrypt.Encrypt(Password); ;
        }

        public static string Decrypt(string EncryptedString)
        {
            return PFCrypt.Decrypt(EncryptedString); ;
        }

        public static string GetAuthenticationToken(string EMail, string userId)
        {
            //Cobine the E Mail and User ID to create authentication token
            //Authentication

            string TokenString = EMail + ":" + userId.ToString();
            string AuthToken = PFCrypt.Encrypt(TokenString);
            return AuthToken;
        }

        public string GetValue(string Key)
        {
            string Data = "";
            try
            {
                string QueryString = "select SettingsValue from settings_tb where SettingsKey='" + Key + "'";
                DataSet ds = m_objDatabaseUtils.GetRecords("SettingsInfo", QueryString);

                if ((ds != null) && (ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0))
                {
                    Data = ds.Tables[0].Rows[0]["SettingsValue"].ToString();

                }

                return Data;
            }
            catch (Exception)
            {
                return Data;
            }
        }
        public bool IsSettingsFiledPresent(string Key)
        {
            bool bResult = false;
            try
            {
                string QueryString = "select SettingsValue from settings_tb where SettingsKey='" + Key + "'";
                DataSet ds = m_objDatabaseUtils.GetRecords("SettingsInfo", QueryString);

                if ((ds != null) && (ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0))
                {
                    bResult = true;

                }
                return bResult;
            }
            catch (Exception)
            {
                return bResult;
            }
        }
        public void SetValue(string Key, string Value)
        {

            string Query = "";
            try
            {
                if (IsSettingsFiledPresent(Key))
                {
                    Query = "update settings_tb set SettingsValue='" + Value + "' where SettingsKey='" + Key + "'";
                }
                else
                {
                    Query = "insert into settings_tb (SettingsKey,SettingsValue) values ('" + Key + "','" + Value + "')";
                }
                m_objDatabaseUtils.ExceuteQuery(Query);

            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }

    }
}