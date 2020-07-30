# azuread-daemon-service-sample

Use AzureAd daemon mechanism to implement application-application token authentication&authorization. 
http://svcnsuzlsjira:8090/pages/viewpage.action?pageId=87949402

This repo only includes service side code.

Client side code is simple:

```csharp
using Microsoft.IdentityModel.Clients.ActiveDirectory;

string clientId = "";
string clientSecret = "";
string instance = "https://login.microsoftonline.com/{0}";
string tenantId = "";
var resourceId = "";

var authority = string.Format(CultureInfo.InvariantCulture, instance, tenant);
var authContext = new AuthenticationContext(authority);
var clientCredential = new ClientCredential(clientId, clientSecret);
AuthenticationResult result = await authContext.AcquireTokenAsync(resourceId, clientCredential);
```
