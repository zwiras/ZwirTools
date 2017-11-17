using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using ZwirCore.Utils.Extensions;
using ZwirCore.Utils.Attributes;
using static ZwirCore.Enums.Enums;

namespace ZwirCore.Utils.Results
{
    /// <summary>
    /// Base class for webApi method
    /// </summary>
    public class ApiBaseResult
    {
        /// <summary>
        /// Return webapi data from json
        /// </summary>
        /// <typeparam name="TObject">Type object returned list</typeparam>
        /// <param name="uri">Base address for request</param>
        /// <param name="apiUrl">Request Uri</param>
        /// <param name="mediaTypeEnum">MediaTypeWithQualityHeaderValue as enum with string value</param>
        /// <returns>Returns a list of objects with a request</returns>
        public IEnumerable<TObject> GetDataJson<TObject>(Uri uri, string apiUrl, MediaTypeEnum mediaTypeEnum)
        {
            IEnumerable<TObject> dataDo = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaTypeEnum.GetAttributeValue<EnumValueAttribute, string>(x=>x.Value)));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;

                    dataDo = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<TObject>>(data);
                }
            }
            return dataDo;
        }

        /// <summary>
        /// Return webapi data as string from json
        /// </summary>
        /// <param name="uri">Base address for request</param>
        /// <param name="apiUrl">Request Uri</param>
        /// <param name="mediaTypeEnum">MediaTypeWithQualityHeaderValue as enum with string value</param>
        /// <returns>Returns a list of objects with a request</returns>
        public string GetDataJson(Uri uri, string apiUrl, MediaTypeEnum mediaTypeEnum)
        {
            string dataDo = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(mediaTypeEnum.GetAttributeValue<EnumValueAttribute, string>(x => x.Value)));

                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;

                    dataDo = Newtonsoft.Json.JsonConvert.DeserializeObject<string>(data);
                }
            }
            return dataDo;
        }
    }
}
