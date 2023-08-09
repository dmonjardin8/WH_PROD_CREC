using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using RestSharp;
using System.Data.SqlClient;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using wh_Creciendo.Modelo;

namespace wh_Creciendo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Verificacion_CrecController : ControllerBase
    {

        private readonly ILogger<Verificacion_CrecController> _logger;

        private static int GuardarBitacora(int PERSON_ID, string EVENT_NAME, string FLOW_ID, string RESPONSE, string NAME_CLIENT, string CURP_CLIENT, string OCR_CLIENT, string DATA, string VERIFICATION_ID)
        {

            var sqlConn = new SqlConnection(SqlConn.ObtenerConec());
            try
            {
                sqlConn.Open();
                var sqlComm = new SqlCommand(Models.GuardarBitacora, sqlConn);
            
                sqlComm.Parameters.AddWithValue("@PERSON_ID", PERSON_ID);
                sqlComm.Parameters.AddWithValue("@EVENT_NAME", EVENT_NAME);
                sqlComm.Parameters.AddWithValue("@FLOW_ID", FLOW_ID);
                sqlComm.Parameters.AddWithValue("@RESPONSE", RESPONSE);
                sqlComm.Parameters.AddWithValue("@NAME_CLIENT", NAME_CLIENT);
                sqlComm.Parameters.AddWithValue("@CURP_CLIENT", CURP_CLIENT);
                sqlComm.Parameters.AddWithValue("@OCR_CLIENT", OCR_CLIENT);
                sqlComm.Parameters.AddWithValue("@DATA", DATA);
                sqlComm.Parameters.AddWithValue("@VERIFICATION_ID", VERIFICATION_ID);
                sqlComm.ExecuteNonQuery();

                return 0;
            }
            catch (System.Exception e)
            {
                //Mandar Correo
               
                return 1;
            }
            finally
            {
                sqlConn.Close();
            }
        }
        public Verificacion_CrecController(ILogger<Verificacion_CrecController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Verificacion_Crec")]
        public async Task<ActionResult> Verificaciones(ResValidacion datos)
        {

            var RESPONSE = datos;

            var options = new RestClientOptions("https://api.getmati.com")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/oauth?grant_type=client_credentials", Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Basic NjBmOGE0NjJlODk4N2UwMDFiOGUzZDFiOjZHMFVUNUcwMEpSTkM1M1JIR0NBMVkzTTJFVFRCWU5Q");
            request.AddParameter("grant_type", "client_credentials");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);

            var resulsms = new respuesta();

            var resuljson = new ResValidacion1();

            var res = "";
            var curp ="";
            var full ="";
            string JSON1 = "";
            string JSON2 = "";

            JSON1 = JsonConvert.SerializeObject(datos);


            var respuestaEnvios = response.Content;
            resulsms = JsonConvert.DeserializeObject<respuesta>(respuestaEnvios);

            if (datos.resource.Length > 0)
            {
                if (resulsms.access_token.Length > 0)
                {
                    var data = "";
                    var client2 = new HttpClient();
                    string URL = datos.resource;
                    HttpContent content2 = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                    client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", resulsms.access_token);

                    var httpResponse = await client2.GetAsync(URL);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        var result = await httpResponse.Content.ReadAsStringAsync();
                        
                        resuljson = JsonConvert.DeserializeObject<ResValidacion1>(result);
                        JSON2 = JsonConvert.SerializeObject(result);
                         res =   resuljson.steps[3].data.ocrNumber;
                         curp = resuljson.documents[0].steps[4].data.curp.value;
                        full = resuljson.documents[0].steps[4].data.fullName.value;
                    }

                      int prueba = GuardarBitacora(Convert.ToInt32( 1),datos.eventName, datos.flowId, JSON1, full, curp, res, JSON2,"");


                }
            }
            return Ok();
        }
    }
}