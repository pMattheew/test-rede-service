using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteRedeService
{
	internal class ImageUtility
	{
		public static string ConvertImageToBase64(Image image)
		{
			using (MemoryStream memoryStream = new MemoryStream())
			{
				image.Save(memoryStream, ImageFormat.Png); // Change to the appropriate format if needed
				byte[] bytes = memoryStream.ToArray();
				return Convert.ToBase64String(bytes);
			}
		}

		public static Image ImageFromBase64(string base64)
		{
			byte[] bytes = Convert.FromBase64String(base64);
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				return Image.FromStream(memoryStream);
			}
		}
	}
}
