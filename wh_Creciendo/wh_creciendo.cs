using Newtonsoft.Json;

namespace wh_Creciendo
{
    public class ResValidacion1
    {

        public computed computed { get; set; }

        public List<documentos>? documents { get; set; }

        public bool? expired { get; set; }
        public Data6? flow { get; set; }
        public Data6? identity { get; set; }
        public Data7? metadata { get; set; }
        public List<steps2>? steps { get; set; }


        public bool? masJobToBePostpone { get; set; }
        public string? profileId { get; set; }
        public string? id { get; set; }
        public deviceFingerprint? deviceFingerprint { get; set; }
        public bool? hasProblem { get; set; }

    }

    //public class pruebaddddd
    //{
    //    public string resource { get; set; }
    //    public string eventName { get; set; }
    //    public string flowId { get; set; }
    //    public string timestamp { get; set; }
    //    public string metadata { get; set; }

    //}

    //public class Error5
    //{
    //    public string type { get; set; }
    //    public string code { get; set; }
    //    public string message { get; set; }
    //}

    //public class Root2
    //{
    //    public string eventName { get; set; }
    //    public Step4 step { get; set; }
    //    public string resource { get; set; }
    //    public DateTime timestamp { get; set; }
    //    public string flowId { get; set; }
    //}

    //public class Step4
    //{
    //    public int status { get; set; }
    //    public string id { get; set; }
    //    public Error5 error { get; set; }
    //    public string documentType { get; set; }
    //}









    public class ResValidacion
    {
        public Data7? metadata { get; set; }
        public string? resource { get; set; }
        public deviceFingerprint? deviceFingerprint { get; set; }

        public string? identityStatus { get; set; }
        public computed details { get; set; }

     
        public string? matiDashboardUrl { get; set; }
        public string? status { get; set; }
        public string? eventName { get; set; }
        public string? flowId { get; set; }
        public string? timestamp { get; set; }

    }

    public class respuesta
        {
        public string? access_token { get; set; }
        public string? expiresIn { get; set; }
        public payload? payload { get; set; }
        
    }
    public class payload {

        public user? user { get; set; }
    }
    public class user { 
    
     public string? _id { get; set; }
    }
    public class deviceFingerprint
    {

        public string? ua { get; set; }
        public os? os { get; set; }
        public device? device { get; set; }

        public os? app { get; set; }
        public string? ip { get; set; }
        public bool? vpnDetectionEnabled { get; set; }
        public string? ipRestrictionEnabled { get; set; }

    }
 
    public class os
    {

        public string? name { get; set; }
        public string? version { get; set; }
    }
        public class device {

        public string? vendor { get; set; }
        public string? model { get; set; }
        public string? type { get; set; }
    } 
    public class Data6
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public string? status { get; set; }
        public string? registryUuid { get; set; }

    }
    public class Data7
    {
        public int? id { get; set; }
        public string? name { get; set; }
        public string? status { get; set; }
        public string? registryUuid { get; set; }

    }

    public class fields
    {
        public data7? address { get; set; }
        public data7? cde { get; set; }
        public data7? curp { get; set; }
        public data7? dateOfBirth { get; set; }
        public data7? documentNumber { get; set; }
        public data7? documentType { get; set; }
        public data7? emissionDate { get; set; }
        public data7? expirationDate { get; set; }
        public data7? firstName { get; set; }
        public data7? fullName { get; set; }
        public data7? issueCountry { get; set; }
        public data7? ne { get; set; }
        public data7? ocrNumber { get; set; }
        public data7? sex { get; set; }
        public data7? surname { get; set; }
     
    }
    public class data7
    {
        public string? value { get; set; }
    }
    public class documentos
    {
        public string? country { get; set; }
        public string[]? merchantFields { get; set; }
        public string? region { get; set; }
        public string? type { get; set; }
        public string? subtype { get; set; }
        public List<steps>? steps { get; set; }


        public string? error { get; set; }
        public fields? fields { get; set; }

        public string[] photos { get; set; }

    }
   
        public class steps
    {
        public int? status { get; set; }
        public string? id { get; set; }
        public bool? cacheHit { get; set; }
        public dataaaa? data { get; set; }
        public string? error { get; set; }
        public string? connectedDocumentType { get; set; }
        public string? dataSource { get; set; }

    }
    public class steps2
    {
        public int? status { get; set; }
        public string? id { get; set; }
        public Boolean? cacheHit { get; set; }
        public data4? data { get; set; }
        public string? error { get; set; }
        public string? connectedDocumentType { get; set; }
        public string? dataSource { get; set; }

    }
    public class data5
    {
        public string? country { get; set; }
        public string? countryCode { get; set; }
        public string? region { get; set; }
        public string? regionCode { get; set; }
        public string? city { get; set; }
        public string? zip { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public bool? safe { get; set; }
        public bool? ipRestrictionEnabled { get; set; }
        public bool? vpnDetectionEnabled { get; set; }

        public bool? platform { get; set; }

    }
        public class dataaaa
    {
        public int? age { get; set; }
        public int? ageThreshold { get; set; }
        public bool? underage { get; set; }
        public int? score { get; set; }
        public Datos? fullName { get; set; }
        public Datos? surname { get; set; }
        public Datos? firstName { get; set; }
        public Datos? dateOfBirth { get; set; }
        public Datos? address { get; set; }
        public Datos? emissionDate { get; set; }
        public Datos? documentType { get; set; }
        public Datos? documentNumber { get; set; }
        public Datos? ocrNumber { get; set; }
        public Datos? issueCountry { get; set; }
        public Datos? sex { get; set; }
        public Datos? cde { get; set; }
        public Datos? curp { get; set; }
        public string? error { get; set; }



    }
    public class data4
    {
        public string? country { get; set; }
        public string? countryCode { get; set; }
        public string? region { get; set; }
        public string? regionCode { get; set; }
        public string? city { get; set; }
        public string? zip { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public bool? safe { get; set; }
        public bool? ipRestrictionEnabled { get; set; }
        public bool? vpnDetectionEnabled { get; set; }
        public string? platform { get; set; }
        public string? videoUrl { get; set; }
        public string? spriteUrl { get; set; }
        public string? selfieUrl { get; set; }
        public string? ocrNumber { get; set; }
        public string? curp { get; set; }
        public string? birthDate { get; set; }
        public string? gender { get; set; }
        public string? fullName { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? secondSurname { get; set; }
        public string? nationality { get; set; }
        public registration? registration { get; set; }
        public curpStatus? curpStatus { get; set; }


    }
    public class curpStatus
    {
        public string? type { get; set; }
        
        public string? description { get; set; }
    }
    public class registration
    {
        public string? state { get; set; }
        public municipality? municipality { get; set; }
        public string? year { get; set; }
    }
    public class municipality
    {
        public int? id { get; set; }
        public string? name { get; set; }
    }
        public class Datos
    {
        public string? value { get; set; }
        public string? initialValue { get; set; }
        public string? markedAsNonReadable { get; set; }
        public string? setDefault { get; set; }
        public string? label { get; set; }
        public bool? required { get; set; }
        public List<Datos>? bounds { get; set; }

    }
    public class bounds
    {
        public string? text { get; set; }
       public string[] vertices { get; set; }
        public string? documentSide { get; set; }
        public string? angle { get; set; }
        public string? scale { get; set; }
        public List<position>? position { get; set; }
       

    }

    public class position {
        public string? x { get; set; }
        public string? y { get; set; }
    }
    public class age
    {
        public int? data { get; set; }
    }
    public class data
    {
        public string? data2 { get; set; }
    }
    public class data2
    {
        public bool NationalId { get; set; }
    }


    public class isDocumentExpired
    {
        public data2? data { get; set; }
    }
        public class computed
    {
        public age? age { get; set; }
        public isDocumentExpired? isDocumentExpired { get; set; }
    }


    //// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    //public class Address
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Age
    //{
    //    public int data { get; set; }
    //}

    //public class App
    //{
    //    public string platform { get; set; }
    //    public string version { get; set; }
    //}

    //public class Cde
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Computed
    //{
    //    public Age age { get; set; }
    //    public IsDocumentExpired isDocumentExpired { get; set; }
    //}

    //public class Curp
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class CurpStatus
    //{
    //    public string type { get; set; }
    //    public string description { get; set; }
    //}

    //public class Data
    //{
    //    [JsonProperty("national-id")]
    //    public bool nationalid { get; set; }
    //    public int age { get; set; }
    //    public int ageThreshold { get; set; }
    //    public bool underage { get; set; }
    //    public int? score { get; set; }
    //    public FullName fullName { get; set; }
    //    public Address address { get; set; }
    //    public EmissionDate emissionDate { get; set; }
    //    public DocumentNumber documentNumber { get; set; }
    //    public DateOfBirth dateOfBirth { get; set; }
    //    public ExpirationDate expirationDate { get; set; }
    //    public DocumentType documentType { get; set; }
    //    public FirstName firstName { get; set; }
    //    public IssueCountry issueCountry { get; set; }
    //    public Nationality nationality { get; set; }
    //    public Sex sex { get; set; }
    //    public Surname surname { get; set; }
    //    public Cde cde { get; set; }
    //    public Curp curp { get; set; }
    //    public Ne ne { get; set; }
    //    public OcrNumber ocrNumber { get; set; }
    //    public string country { get; set; }
    //    public string countryCode { get; set; }
    //    public string region { get; set; }
    //    public string regionCode { get; set; }
    //    public string city { get; set; }
    //    public string zip { get; set; }
    //    public double latitude { get; set; }
    //    public double longitude { get; set; }
    //    public bool safe { get; set; }
    //    public bool ipRestrictionEnabled { get; set; }
    //    public bool vpnDetectionEnabled { get; set; }
    //    public string platform { get; set; }
    //    public string videoUrl { get; set; }
    //    public string spriteUrl { get; set; }
    //    public string selfieUrl { get; set; }
    //    public string birthDate { get; set; }
    //    public string gender { get; set; }
    //    public string name { get; set; }
    //    public string secondSurname { get; set; }
    //    public Registration registration { get; set; }
    //    public CurpStatus curpStatus { get; set; }
    //    public string registrationYear { get; set; }
    //    public string emissionYear { get; set; }
    //}

    //public class DateOfBirth
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //    public string format { get; set; }
    //}

    //public class Device
    //{
    //    public string vendor { get; set; }
    //    public string model { get; set; }
    //    public string type { get; set; }
    //}

    //public class DeviceFingerprint
    //{
    //    public string ua { get; set; }
    //    public Os os { get; set; }
    //    public Device device { get; set; }
    //    public App app { get; set; }
    //    public string ip { get; set; }
    //    public bool vpnDetectionEnabled { get; set; }
    //    public string ipRestrictionEnabled { get; set; }
    //}

    //public class Document
    //{
    //    public string country { get; set; }
    //    public List<object> merchantFields { get; set; }
    //    public object region { get; set; }
    //    public string type { get; set; }
    //    public string subtype { get; set; }
    //    public List<Step> steps { get; set; }
    //    public Fields fields { get; set; }
    //    public List<string> photos { get; set; }
    //}

    //public class DocumentNumber
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class DocumentType
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class EmissionDate
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //    public string format { get; set; }
    //}

    //public class ExpirationDate
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //    public string format { get; set; }
    //}

    //public class Fields
    //{
    //    public Address address { get; set; }
    //    public Cde cde { get; set; }
    //    public Curp curp { get; set; }
    //    public DateOfBirth dateOfBirth { get; set; }
    //    public DocumentNumber documentNumber { get; set; }
    //    public DocumentType documentType { get; set; }
    //    public EmissionDate emissionDate { get; set; }
    //    public ExpirationDate expirationDate { get; set; }
    //    public FirstName firstName { get; set; }
    //    public FullName fullName { get; set; }
    //    public IssueCountry issueCountry { get; set; }
    //    public Nationality nationality { get; set; }
    //    public Ne ne { get; set; }
    //    public OcrNumber ocrNumber { get; set; }
    //    public Sex sex { get; set; }
    //    public Surname surname { get; set; }
    //}

    //public class FirstName
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Flow
    //{
    //    public string id { get; set; }
    //    public string name { get; set; }
    //}

    //public class FullName
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Identity
    //{
    //    public string id { get; set; }
    //    public string status { get; set; }
    //}

    //public class IsDocumentExpired
    //{
    //    public Data data { get; set; }
    //}

    //public class IssueCountry
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Metadata
    //{
    //    public string registryUuid { get; set; }
    //    public int id { get; set; }
    //}

    //public class Municipality
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //}

    //public class Nationality
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Ne
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class OcrNumber
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Os
    //{
    //    public string name { get; set; }
    //    public string version { get; set; }
    //}

    //public class Registration
    //{
    //    public string state { get; set; }
    //    public Municipality municipality { get; set; }
    //    public string year { get; set; }
    //}

    //public class Root
    //{
    //    public Computed computed { get; set; }
    //    public List<Document> documents { get; set; }
    //    public bool expired { get; set; }
    //    public Flow flow { get; set; }
    //    public Identity identity { get; set; }
    //    public Metadata metadata { get; set; }
    //    public List<Step> steps { get; set; }
    //    public bool masJobToBePostpone { get; set; }
    //    public string profileId { get; set; }
    //    public string id { get; set; }
    //    public DeviceFingerprint deviceFingerprint { get; set; }
    //    public bool hasProblem { get; set; }
    //}

    //public class Sex
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}

    //public class Step
    //{
    //    public int status { get; set; }
    //    public string id { get; set; }
    //    public object cacheHit { get; set; }
    //    public Data data { get; set; }
    //    public object error { get; set; }
    //    public string connectedDocumentType { get; set; }
    //    public string dataSource { get; set; }
    //}

    //public class Surname
    //{
    //    public string value { get; set; }
    //    public bool required { get; set; }
    //    public string label { get; set; }
    //}












}

