using ProjectFramework.Web.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjectFramework.Web.BLL
{
    public class HomePageBoxBLL : BLLBase
    {
        public List<HomePageBox> GetHomePageBoxes()
        {
            var boxes = new List<HomePageBox>();
            try
            {
                string queryString = "SELECT ID, Heading, SubHeading, Link, DisplayOrder FROM home_page_boxes_tb ORDER BY DisplayOrder";
                DataSet ds = m_objDatabaseUtils.GetRecords("HomePageBoxes", queryString);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        boxes.Add(new HomePageBox
                        {
                            ID = Convert.ToInt32(row["ID"]),
                            Heading = row["Heading"].ToString(),
                            SubHeading = row["SubHeading"].ToString(),
                            Link = row["Link"].ToString(),
                            DisplayOrder = Convert.ToInt32(row["DisplayOrder"])
                        });
                    }
                }
            }
            catch (Exception)
            {
                // Handle or log the exception
                throw;
            }
            return boxes;
        }
    }
}