using HIGHCON.GVEI.MOBILE.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace HIGHCON.GVEI.MOBILE.Services
{
   
    public class ServiceWS
    {
        private static string EnderecoBase = "http://lnsiqueira-001-site1.ctempurl.com/api/";

        private RestClient Client { get; set; }

        public ServiceWS()
        {
            Client = new RestClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
        }


        public static User GetUser(string usuario, string senha)
        {
            var URL = EnderecoBase + "Usuario/"+ usuario + "/"+ senha; //usuario + senha 

            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpClient requisicao = new HttpClient();
                HttpResponseMessage resposta = requisicao.GetAsync(URL).GetAwaiter().GetResult();

                if ( resposta.StatusCode == HttpStatusCode.OK)
                {
                    string conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    if (conteudo.Length > 2)
                    {
                        var myObject = JsonConvert.DeserializeObject<User>(conteudo);
                        return myObject;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; 
            }
            
        }
       
    }
}
