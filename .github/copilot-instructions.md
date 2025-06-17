Omit needless words
Use as few lines of code as possible, but keep code clear and simple
Above all keep it simple, which generally means fewer/shorter lines, but not always, for example ternary operator is less clear than if/else and does not simplify code
Do not use complex patterns like injection if not neeeded
Fix only what's in scope of question, don't change other code
Provide minimal solution, for example if asked to create html component, don't add CSS
Don't repeat yourself, use definitions from one place so all instances can be changed at once
Prioritize locality so you can understand that source by looking at only a small portion of it
The behaviour of a unit of code should be as obvious as possible by looking only at that unit of code
Do not add obvious comments like "counter++; // increment counter"
Do comment when you change code in one place that affects code in another function or file, make a note on the affected code pointing back to your change
Do not delete existing comments (unless also deleting the code they describe)
C# firely sdk for FHIR models, API https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/model.html
Example: await GlobalFHIRconfig.client.SearchAsync<Patient>(new string[] { $"name={input}", "_count=10" });
Multiple concurrent requests should be bundled together: builder = new TransactionBuilder(client.Endpoint.ToString(), Bundle.BundleType.Batch);
Medical data all in FHIR server, only user settings stored in database
Most logic in Components/Pages
Top level page navigation sets main-content component in Components\Pages\Home.razor to a component in Components\Pages\TopLevel
Patient level page navigation sets patient-content component in Components\Pages\TopLevel\Home.razor  to a component in Components\Pages\PatientLevel
Patient level page includes the request for the initially shown patient-content to batch with patient level request
So patient-content pages (allergy, medication, etc) must be able to take request result as parameter, or make their own request using patient id as parameter
Patient search component takes a function, provides patient result bundle, and calls function with user clicked patient
Do not add @using Hl7.Fhir.Model as it's not needed and causes Task to be an ambiguous reference