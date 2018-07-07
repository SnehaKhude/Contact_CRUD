using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;
//using System.Net.Http.HttpContent;
//using System.Net.Http.Formatting;

namespace ContactApp_Client.Models
{
    public class ContactClient
    {
        private string BASE_URL = "http://localhost:59874/api/";

        public IEnumerable<Contact> FindAll()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("contact").Result;

                if(response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<IEnumerable<Contact>>().Result;
                }
                return null;
            }
            catch
            {
                throw null;
            }
        }
        public Contact Find(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync("contact/" + id).Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsAsync<Contact>().Result;
                }
                return null;
            }
            catch
            {
                throw null;
            }
        }

        public bool Create(Contact contact)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PostAsJsonAsync("contact",contact).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }

        public bool Edit(Contact contact)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.PutAsJsonAsync("contact/" + contact.ContactId, contact).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.DeleteAsync ("contact/" + id).Result;
                return response.IsSuccessStatusCode;

            }
            catch
            {
                return false;
            }
        }
    }
}