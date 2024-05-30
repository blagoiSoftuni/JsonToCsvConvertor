using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System;
using CsvHelper;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace JsonToCsvConvertor
{
    internal class BusinessLogic
    {
        public BusinessLogic()
        {



             private static readonly HttpClient client = new HttpClient(); 
    

        public void CheckUserInput(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                throw new ArgumentException("User input cannot be empty.");
            }

            if (!IsApiPathValid(userInput))
            {
                throw new ArgumentException("Invalid API path.");
            }
        }

        private bool IsApiPathValid(string userInput)
        {
            string pattern = @"https:\/\/restcountries\.com\/v3\.1\/(name|region)\/\w+";
            return Regex.IsMatch(userInput, pattern);
        }

        public async Task<string> GetJsonAsync(string userInput)
        {
            try
            {
                string response = await GetResponseAsync(userInput);
                var deserializedResponse = DeserializeJson(response);
                return SerializeJson(deserializedResponse);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed to get JSON response.", ex);
            }
        }

        private async Task<string> GetResponseAsync(string userInput)
        {
            HttpResponseMessage response = await client.GetAsync(userInput);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        private IEnumerable<Country> DeserializeJson(string responseAsString)
        {
            try
            {
                return JsonConvert.DeserializeObject<IEnumerable<Country>>(responseAsString);
            }
            catch (JsonException ex)
            {
                throw new ApplicationException("Failed to deserialize JSON.", ex);
            }
        }

        private string SerializeJson(IEnumerable<Country> deserializedResponse)
        {
            return JsonConvert.SerializeObject(deserializedResponse, Formatting.Indented);
        }

        public string GetCsv(string jsonString)
        {
            var records = JsonConvert.DeserializeObject<IEnumerable<Country>>(jsonString);
            using (var writer = new StringWriter())
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
                return writer.ToString();
            }
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        // Add more properties as needed
    }
}
   