﻿global using Hl7.Fhir.Model;
global using Hl7.Fhir.Rest;

namespace PotatoEMR
{
    public static class GlobalFHIRconfig
    {
        //public const string ServerURL = "https://server.fire.ly";
        public const string ServerURL = "http://hapi.fhir.org/baseR4";
        //public const string ServerURL = "https://r4.smarthealthit.org/";
        public static readonly FhirClient client = new FhirClient(ServerURL);
    }
}
