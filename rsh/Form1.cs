using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using SimpleHttpServer;
using SimpleHttpServer.Models;
using System.Threading;

using Viber;
using Viber.Bot;
using ViberAPI;

using System.IO;

using Microsoft.Extensions.Configuration;
using rsh.Core.ViberApi.Models.WebhookModels;
using Newtonsoft.Json;
using System.Net;

namespace rsh
{
    public partial class Form1 : Form
    {
        #region Fields        
        /// <summary>
        /// Viber API.
        /// </summary>
        private IViberBotClient _viberBotClient;

        private string _authToken;
        private string _webhookUrl;
        private string _adminId;
        #endregion Fields.End

        #region MyRegion        
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        // ### Events --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---        
        #region Events        
        private void Form1_Load(object sender, EventArgs e)
        {
            StartHttpServer();
            SetSetting();
        }

        /// <summary>
        /// Получить Содержание запроса
        /// </summary>
        /// <param name="request"></param>
        private void request_RequestContent(HttpRequest request)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke((Action)(() => request_RequestContent(request)));
                return;
            }
            richTextBox1.Text += "\n" + request.Content;
        }
        #endregion


        // ### Methods --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        #region Methods 
        // *** Service *** *** *** *** *** *** *** *** *** *** *** *** *** ***
        #region Service        
        /// <summary>
        /// Установить. Настройки
        /// </summary>
        public void SetSetting()
        {
            _authToken = "ХХХХХХХ";

            _viberBotClient = new ViberBotClient(_authToken);
        }
        
        /// <summary>
        /// Старт сервера.
        /// </summary>
        public void StartHttpServer()
        {
            try
            {
                var route_config = new List<Route>();

                // ЗАМЕТКА. Запрос POST приходит в класс `HttpProcessor.cs` метод "HandleClient"
                // 
                // HttpServer httpServer = new HttpServer(8080, route_config);
                HttpServer httpServer = new HttpServer(8080, route_config);

                #region MyRegion
                httpServer.Processor.RequestContent += request_RequestContent;
                #endregion

                Thread thread = new Thread(new ThreadStart(httpServer.Listen));
                thread.Start();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                string t = ex.StackTrace;
                // throw;
                MessageBox.Show(s + " \r\n "
                                  + t);
            }

        }
        #endregion Service.End

        // *** Webhook *** *** *** *** *** *** *** *** *** *** *** *** *** ***
        #region Webhook
        // *** Webhook/ Viber.Bot +++ +++ +++ +++ +++        
        #region Webhook. Viber.Bot
        /// <summary>
        /// Webhook. Установить
        /// </summary>
        public async Task SetWebhookAsync(string webhookUrl)
        {
            var result = await _viberBotClient.SetWebhookAsync(webhookUrl);
            return;
        }
        #endregion

        // *** Webhook/ ViberAPI +++ +++ +++ +++ +++
        #region Webhook/ ViberAPI        
        public void SetWebhookAsync_VbAPI(string webhookUrl)
        {
            try
            {
                // _webhookUrl = txtb_webhookUrl.Text;

                ViberWebhook viberWebhook = new ViberWebhook(_authToken, webhookUrl, Subscription.All);
                // ViberWebhook viberWebhook = new ViberWebhook(_authToken, webhookUrl, );

                // viberWebhook.Register();
                viberWebhook.RegisterWebhook_my();

            }
            catch (Exception ex)
            {
                string s = ex.Message;
                string t = ex.StackTrace;
                // throw;
                MessageBox.Show(s + " \r\n "
                                  + t);
            }
        }
                
        /// <summary>
        /// Webhook. Реигстрация
        /// </summary>
        /// <param name="endpointRouteURL"></param>
        /// <returns></returns>
        // public StatusCode RemovingYourWebhook(string endpointRouteURL)
        public string RegisterWebhook_my_VbAPI_1(string webhookUrl) // ++
        {
            string result = string.Empty;
            try
            {
                WebhookSettings settings = new WebhookSettings()
                {
                    Url = webhookUrl
                    // Subscription = Subscription
                };

                string json = JsonConvert.SerializeObject((WebhookSettings)settings);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://chatapi.viber.com/pa/set_webhook");
                httpWebRequest.Headers.Add("X-Viber-Auth-Token", _authToken);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                // string result = string.Empty;

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                // RegistrationResponse info = JsonConvert.DeserializeObject<RegistrationResponse>(result);
                // return (StatusCode)info.status;
                result = json + " \r\n - // - \r\n " + result;
                // result = json;
            }
            catch (Exception ex)
            {
                string s = ex.Message;
                string t = ex.StackTrace;
                // throw;
                //MessageBox.Show(s + " \r\n "
                //                  + t);
            }

            return result;
        }
        #endregion Webhook/ ViberAPI.End        
        #endregion Webhook.End
        
        // *** Account *** *** *** *** *** *** *** *** *** *** *** *** *** ***
        #region Account       
        /// <summary>
        /// Аккаунт. Получить информацию.
        /// </summary>
        /// <returns></returns>
        public async Task GetAccountInfoAsyncTest()
        {
            // var result = await _viberBotClient.GetAccountInfoAsync();
            var result = await _viberBotClient.GetAccountInfoAsync();
            
            return;
        }
        #endregion Account.End
        #endregion Methods.End

        // ### Button --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---
        #region Button

        // *** Webhook ***
        #region Webhook
        // *** Webhook.Bot  ***
        #region MyRegion. DLL - Viber.Bot 
        private async void btn_SetWebhookViberBot_Click(object sender, EventArgs e)
        {
            string webhookUrl = txtb_webhookUrl.Text;

            await SetWebhookAsync(webhookUrl);
        }
        #endregion

        // *** Webhook.Api ***
        #region MyRegion. DLL - Viber.Api
        /// <summary>
        /// Webhook. Установить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // private async void btn_SetWebhook_Click(object sender, EventArgs e)
        private void btn_SetWebhook_Click(object sender, EventArgs e)
        {
            // await SetWebhookAsync();
            _webhookUrl = txtb_webhookUrl.Text;

            string webhookUrl = txtb_webhookUrl.Text;

            // SetWebhookAsync_VbAPI(webhookUrl);
            RegisterWebhook_my_VbAPI_1(webhookUrl);

        }
        #endregion        
        #endregion

        /// <summary>
        /// Аккаунт. Получить информацию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_GetAccountInfo_Click(object sender, EventArgs e)
        {
            // await GetAccountInfoAsyncTest();
            var result = await _viberBotClient.GetAccountInfoAsync();

            richTextBox1.Text += "Background        - " + result.Background + "\n";
            // richTextBox1.Text += "EventTypes.Count  - " + result.EventTypes.Count + "\n";
            richTextBox1.Text += "Id                - " + result.Id + "\n";
            richTextBox1.Text += "Members.Count     - " + result.Members.Count + "\n";
            richTextBox1.Text += "Name              - " + result.Name + "\n";
            richTextBox1.Text += "SubscribersCount  - " + result.SubscribersCount + "\n";
            richTextBox1.Text += "Uri               - " + result.Uri + "\n";
            richTextBox1.Text += "Webhook - " + result.Webhook + "\n";

            richTextBox1.Text += "**** **** **** ****" + "\n";
            richTextBox1.Text += "События " + "\n";

            int i = 0;
            //foreach (var item in result.EventTypes)
            //{
            //    i++;

            //    richTextBox1.Text += i.ToString() + " " + item + "\n";
            //}

        }
                     
        private void btn_Clear_richTxtB_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        #endregion

       
    }
}
