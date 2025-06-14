global using Hl7.Fhir.Model;
global using Hl7.Fhir.Rest;

namespace PotatoEMR
{
    public static class GlobalFHIRconfig
    {
        public const string ServerURL = "http://hapi.fhir.org/baseR4";
        public static readonly FhirClient client = new FhirClient(ServerURL);
    }
}
