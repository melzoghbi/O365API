using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Data;

namespace WebAPICore1.Helpers
{
    public class ApiHelper
    {
        static MediaTypeWithQualityHeaderValue Json = new MediaTypeWithQualityHeaderValue("application/json");

        // Get infomation about the current logged in user.
        public static async Task<UserProfile> GetUserInfoAsync(string accessToken)
        {
            UserProfile myInfo = new UserProfile();

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, Settings.GetMeUrl))
                {
                    request.Headers.Accept.Add(Json);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    using (var response = await client.SendAsync(request))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
                            myInfo.Name = json?["displayName"]?.ToString();
                            myInfo.Address = json?["mail"]?.ToString().Trim().Replace(" ", string.Empty);
                        }
                    }
                }
            }

            return myInfo;
        }

        // Construct and send the message that the logged in user wants to send.
        public static async Task<MessageResponse> SendMessageAsync(string accessToken, SendMessageRequest sendMessageRequest)
        {
            var sendMessageResponse = new MessageResponse { Status = SendMessageStatusEnum.NotSent };

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, Settings.SendMessageUrl))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    request.Content = new StringContent(JsonConvert.SerializeObject(sendMessageRequest), Encoding.UTF8, "application/json");
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            sendMessageResponse.Status = SendMessageStatusEnum.Sent;
                            sendMessageResponse.StatusMessage = null;
                        }
                        else
                        {
                            sendMessageResponse.Status = SendMessageStatusEnum.Fail;
                            sendMessageResponse.StatusMessage = response.ReasonPhrase;
                        }
                    }
                }
            }

            return sendMessageResponse;
        }

        public static async Task<MessageResponse> GetSPSites(string accessToken)
        {
            var msgResponse = new MessageResponse { Status = SendMessageStatusEnum.NotSent };

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, Settings.SharePointUrl))
                {
                    request.Headers.Accept.Add(Json);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            msgResponse.Status = SendMessageStatusEnum.Sent;
                            msgResponse.StatusMessage = await response.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            msgResponse.Status = SendMessageStatusEnum.Fail;
                            msgResponse.StatusMessage = response.ReasonPhrase;
                        }
                    }
                }
            }

            return msgResponse;
        }

        public static async Task<MessageResponse> GetSPSiteLists(string accessToken, string siteId)
        {
            var msgResponse = new MessageResponse { Status = SendMessageStatusEnum.NotSent };

            using (var client = new HttpClient())
            {
                string locUrl = Settings.SharePointUrl + "/" + siteId + "/lists";
                using (var request = new HttpRequestMessage(HttpMethod.Get, locUrl ))
                {
                    request.Headers.Accept.Add(Json);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            msgResponse.Status = SendMessageStatusEnum.Sent;
                            msgResponse.StatusMessage = await response.Content.ReadAsStringAsync();
                        }
                        else
                        {
                            msgResponse.Status = SendMessageStatusEnum.Fail;
                            msgResponse.StatusMessage = response.ReasonPhrase;
                        }
                    }
                }
            }

            return msgResponse;
        }

    }
}
