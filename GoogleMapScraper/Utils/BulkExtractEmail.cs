using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace GMapExtractor
{
    public sealed class BulkExtractEmail
    {
        private static HttpClient client = new HttpClient() { Timeout = TimeSpan.FromSeconds(30) };
        public static Queue<EmailIn> EmailQueue = new Queue<EmailIn>();
        private static CancellationTokenSource cts = new CancellationTokenSource();

        public static async void Start(Action<EmailOut> acEmail)
        {
            var token = cts.Token;
            await Execute(acEmail, token).ContinueWith(t =>
            {
                cts = new CancellationTokenSource();
            });
        }
        private static async Task Execute(Action<EmailOut> acEmail, CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                if (EmailQueue.Count > 0)
                {
                    var inEmail = EmailQueue.Dequeue();
                    var soModel = await GetEmail(inEmail.Url);
                    var outEmail = new EmailOut()
                    {
                        Id = inEmail.Id,
                        Email = soModel.Email,
                    };
                    acEmail(outEmail);
                }
                await Task.Delay(2000, token);
            }
        }

        public static void Stop()
        {
            cts.Cancel();
        }


        private static async Task<EmailOut> GetEmail(string url)
        {
            var model = new EmailOut();
            try
            {

                url = url.Contains("http") ? url.Trim() : "https://" + url.Trim();
                var result = await client.GetAsync(url);
                if (result.IsSuccessStatusCode)
                {
                    var str = await result.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(str))
                    {
                        model.Email = ExtractEmail(str);
                    }
                }
                return model;
            }
            catch (Exception)
            {

                return model;
            }
        }


        public static string ExtractEmail(string str)
        {
            string pattern = @"(\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(str);

            foreach (Match match in matches)
            {
                string email = match.Groups[0].Value;
                return email;
            }
            return string.Empty;
        }

    }
}
