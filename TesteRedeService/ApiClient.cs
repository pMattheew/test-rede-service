using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRedeService
{
	internal static class ApiClient
	{
		private static readonly HttpClient httpClient = new HttpClient();

		public static async Task<string> GetDataFromApiAsync(string apiUrl)
		{
			try
			{
				HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

				if (response.IsSuccessStatusCode)
				{
					return await response.Content.ReadAsStringAsync();
				}
				else
				{
					Console.WriteLine($"HTTP request failed with status code: {response.StatusCode}");
					return null;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching data from API: {ex.Message}");
				return null;
			}
		}

		public static async Task<string> DownloadImageAsync(string imageUrl)
		{
			try
			{
				byte[] imageBytes = await httpClient.GetByteArrayAsync(imageUrl);

				string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "downloaded_image.png");

				File.WriteAllBytes(fileName, imageBytes);

				return fileName;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error downloading image: {ex.Message}");
				return null;
			}
		}
	}
}
