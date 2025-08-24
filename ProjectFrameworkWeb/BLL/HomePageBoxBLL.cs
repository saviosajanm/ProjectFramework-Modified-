using ProjectFrameworkWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProjectFrameworkWeb.BLL
{
    public class HomePageBoxBLL : BLLBase
    {
        public List<HomePageBox> GetHomePageBoxes()
        {
            var boxes = new List<HomePageBox>();
            string query = "SELECT * FROM home_page_boxes_tb ORDER BY DisplayOrder";
            DataSet ds = m_objDatabaseUtils.GetRecords("HomePageBoxes", query);

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
            return boxes;
        }

        public void AddHomePageBox(HomePageBox box)
        {
            string maxOrderQuery = "SELECT MAX(DisplayOrder) FROM home_page_boxes_tb";
            DataSet ds = m_objDatabaseUtils.GetRecords("MaxOrder", maxOrderQuery);
            int newOrder = 1;
            if (ds != null && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                newOrder = Convert.ToInt32(ds.Tables[0].Rows[0][0]) + 1;
            }

            string query = $"INSERT INTO home_page_boxes_tb (Heading, SubHeading, Link, DisplayOrder) VALUES ('{m_objDatabaseUtils.FormatSQLField(box.Heading)}', '{m_objDatabaseUtils.FormatSQLField(box.SubHeading)}', '{m_objDatabaseUtils.FormatSQLField(box.Link)}', {newOrder})";
            m_objDatabaseUtils.ExceuteQuery(query);
        }

        public void UpdateHomePageBox(HomePageBox box)
        {
            string query = $"UPDATE home_page_boxes_tb SET Heading = '{m_objDatabaseUtils.FormatSQLField(box.Heading)}', SubHeading = '{m_objDatabaseUtils.FormatSQLField(box.SubHeading)}', Link = '{m_objDatabaseUtils.FormatSQLField(box.Link)}' WHERE ID = {box.ID}";
            m_objDatabaseUtils.ExceuteQuery(query);
        }

        public void DeleteHomePageBox(int id)
        {
            if (id == 1) return; // Prevent deleting the default box
            string query = $"DELETE FROM home_page_boxes_tb WHERE ID = {id}";
            m_objDatabaseUtils.ExceuteQuery(query);
        }

        public void UpdateOrder(List<int> orderedIds)
        {
            var queries = new List<string>();
            for (int i = 0; i < orderedIds.Count; i++)
            {
                queries.Add($"UPDATE home_page_boxes_tb SET DisplayOrder = {i + 1} WHERE ID = {orderedIds[i]};");
            }
            m_objDatabaseUtils.ExecuteSQLTransactionEx(queries);
        }
    }
}