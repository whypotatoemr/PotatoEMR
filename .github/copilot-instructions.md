Omit needless words
Use as few lines of code as possible, but keep code clear and simple
Fix only what's in scope of question, don't change other code
Provide minimal solution, for example if asked to create html component, don't add CSS
Do not add obvious comments like "counter++; // increment counter"
Do comment on code affected by a change you make in a different function or file
C# firely sdk for FHIR models, API https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/model.html
Medical data all in FHIR server, only user settings stored in database
Most logic in Components/Pages
Top level page navigation sets main-content component in Components\Pages\Home.razor to a component in Components\Pages\TopLevel
Patient level page navigation sets main-content component in Components\Pages\TopLevel\Home.razor  to a component in Components\Pages\PatientLevel
Patient search component takes a function, provides patient result bundle, and calls function with user clicked patient
Finish response by saing "Goodbye"