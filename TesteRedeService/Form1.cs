using System.Text.Json;

namespace TesteRedeService
{
	using CorreiosAPI;

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			List<clsTeste> testList = new List<clsTeste>();

			for (decimal i = 0; i < 100; i++)
			{
				clsTeste item = new clsTeste(i);
				testList.Add(item);
			}

			string jsonFile = "testList.json";

			FileUtility.SaveListToJson(testList, jsonFile);

			List<clsTeste> dataList = JsonUtility.LoadJsonData(jsonFile);

			dataGridView1.DataSource = dataList;

			fetchAndFillBanks();
			fetchAndFillImage();
		}

		public static Task<consultaCEPResponse> ConsultaCEP(string cep)
		{
			using (var ws = new AtendeClienteClient())
			{
				return ws.consultaCEPAsync(cep);
			}
		}

		private async void fetchAndFillBanks()
		{
			string apiUrl = "https://brasilapi.com.br/api/banks/v1";
			string json = await ApiClient.GetDataFromApiAsync(apiUrl);

			if (!string.IsNullOrEmpty(json))
			{
				List<Bank> dataList = JsonSerializer.Deserialize<List<Bank>>(json);
				dataGridView2.DataSource = dataList;
			}
		}

		private async void fetchAndFillImage()
		{
			string imageUrl = "https://redeservice.com.br/wp-content/uploads/2020/07/redeservice-logo.png";
			string imagePath = await ApiClient.DownloadImageAsync(imageUrl);

			if (!string.IsNullOrEmpty(imagePath))
			{
				Image image = Image.FromFile(imagePath);

				string base64Image = ImageUtility.ConvertImageToBase64(image);

				pictureBox1.Image = ImageUtility.ImageFromBase64(base64Image);
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			string input = numericUpDown1.Value.ToString();

			displayInput.Text = input;

			FileUtility.AppendLine(input, "numeros_ordenar.txt");
		}

	}
}