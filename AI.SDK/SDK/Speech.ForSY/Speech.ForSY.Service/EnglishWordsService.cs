using Speech.ForSY.Model;
using Speech.ForSY.Model.filter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Speech.ForSY.Service
{
    public class EnglishWordsService
    {

        public static List<EnglishWordsModel> GetEnglishWorlds(EnglishWordSearch searchFilter)
        {
            List<EnglishWordsModel> retList = new List<EnglishWordsModel>();
            if (!string.IsNullOrEmpty(searchFilter.ID) || !string.IsNullOrEmpty(searchFilter.CatagoryID) || !string.IsNullOrEmpty(searchFilter.English))
            {
                string sqlStr = @"SELECT E.ID
                              ,E.CatagoryID
	                          ,S.CatagoryTitle 
	                          ,S.DefaultImages
                              ,E.English
                              ,E.PhoneticSymbol
                              ,E.Chiness
                              ,E.Remark
                              ,E.VoiceByte
                              ,E.VoiceFullFilePath
                              ,E.OrderBy 
                              ,E.CreateTime
                              ,E.UpdateTime
                              FROM  dbo.Speech_EnglishWords E INNER JOIN Speech_StudyCatagory S ON E.CatagoryID=S.ID WHERE 1=1 ";

                string filter = "";
                if (!string.IsNullOrEmpty(searchFilter.ID))
                    filter += string.Format("AND E.ID = '{0}' ", searchFilter.ID);

                if (!string.IsNullOrEmpty(searchFilter.English))
                    filter += string.Format("AND E.English = '{0}' ", searchFilter.English);

                if (!string.IsNullOrEmpty(searchFilter.CatagoryID))
                    filter += string.Format("AND E.CatagoryID = '{0}' ", searchFilter.CatagoryID);

                filter += " ORDER BY OrderBy  ";

                var dataSet = SqlDbHelper.GetDataSet(string.Format("{0} {1}", sqlStr, filter));
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    //遍历一个表多行多列
                    foreach (DataRow mDr in dataSet.Tables[0].Rows)
                    {
                        retList.Add(new EnglishWordsModel
                        {
                            ID = mDr["ID"].ToString(),
                            CatagoryID = mDr["CatagoryID"].ToString(),
                            CatagoryTitle = mDr["CatagoryTitle"].ToString(),
                            Chiness = mDr["Chiness"].ToString(),
                            DefaultImages = mDr["DefaultImages"].ToString(),
                            English = mDr["English"].ToString(),
                            OrderBy = Convert.ToInt32(mDr["OrderBy"].ToString()),
                            PhoneticSymbol = mDr["PhoneticSymbol"].ToString(),
                            Remark = mDr["Remark"].ToString(),
                            CreateTime = Convert.ToDateTime(mDr["CreateTime"]),
                            UpdateTime = Convert.ToDateTime(mDr["UpdateTime"]),
                            VoiceByte = mDr["VoiceByte"].ToString(),
                            VoiceFullFilePath = mDr["VoiceFullFilePath"].ToString()
                        });
                    }
                }

            }
            return retList;
        }

    }
}
