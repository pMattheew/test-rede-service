using System.Text.Json;

namespace TesteRedeService
{
	internal class FileUtility
	{
        private static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public static bool SaveListToJson<T>(List<T> list, string fileName)
        {
            try
            {
                string filePath = Path.Combine(baseDirectory, fileName);
                string jsonString = JsonSerializer.Serialize(list);
                File.WriteAllText(filePath, jsonString);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving list to JSON: " + ex.Message);
                return false;
            }
        }

        public static bool AppendLine(string text, string fileName)
        {
            try
            {
                string filePath = Path.Combine(baseDirectory, fileName);

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(text);
                    writer.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving text to file: " + ex.Message);
                return false;
            }
        }
    }
}
