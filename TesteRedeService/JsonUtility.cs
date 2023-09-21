using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TesteRedeService
{
	internal class JsonUtility
	{
        public static List<clsTeste> LoadJsonData(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                List<clsTeste> dataList = JsonSerializer.Deserialize<List<clsTeste>>(jsonContent);
                return dataList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading JSON data: " + ex.Message);
                return null;
            }
        }
    }
}
