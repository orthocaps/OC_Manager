using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocManager
{
    public static class LogCategories
    {
        public static string General = "General";
        public static string SendScans = "SendScans";
        public static string GetData = "GetData";
        public static string Loading = "Loading";

        public static List<string> getAllCategoriesAsList()
        {
            List<string> temp = new List<string>();
            temp.Add(General);
            temp.Add(SendScans);
            temp.Add(GetData);
            temp.Add(Loading);

            return temp;
        }
    }
}
