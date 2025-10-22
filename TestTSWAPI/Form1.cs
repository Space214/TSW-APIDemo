using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace TestTSWAPI
{

    public partial class Output_TB : Form
    {
        public string baseUrl = "http://localhost:31270/";
        public string Method = "info/";
        public string Endpoint = "CurrentDrivableActor"; // Example from the C40-8W: CurrentDrivableActor/Simulation/Grid1.MaximumResistance


        public Output_TB()
        {
            InitializeComponent();
        }

        private async void Refresh_B_Click(object sender, EventArgs e)
        {
            // Reset the textbox
            Response_TB.Text = "";

            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            HttpClient client = new HttpClient(handler);

            // Setup the request and send the DTGCommKey
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}{Method}{Endpoint}");
            request.Headers.Add("DTGCommKey", $"{APIKey_TB.Text}"); //  5: esWXNFopMdEjPBHCIV3k7jVfF9uA9WALv1J8NcOQbV0=    6: g19lecZ6PdkCaYQ24OiOxlVOkCR7ABsJt3T+d/b7MrU=

            try
            {
                // Send the request
                HttpResponseMessage response = await client.SendAsync(request);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read and display the response content
                string responseBody = await response.Content.ReadAsStringAsync();
                Response_TB.Text = responseBody;
            }
            catch (HttpRequestException er)
            {
                // If something doesn't work... give the error in the textbox
                Response_TB.Text = $"Response Error: {er.Message}";
            }
        }

        private void Method_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the Method for sending
            Method = Method_CB.Text.ToLower() + "/";
        }

        private void EndPoint_TB_TextChanged(object sender, EventArgs e)
        {
            // Update the end point
            Endpoint = EndPoint_TB.Text;
        }
    }
}
