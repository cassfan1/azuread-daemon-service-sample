# azuread-daemon-service-sample

Use AzureAd daemon mechanism to implement application-application token authentication&authorization.

This repo only includes service side code.

Client side code is simple:

```csharp
string clientId = "";
string clientSecret = "";
string instance = "https://login.microsoftonline.com/{0}";
string tenant = "";
var resourceId = "";

var authority = string.Format(CultureInfo.InvariantCulture, instance, tenant);
var authContext = new AuthenticationContext(authority);
var clientCredential = new ClientCredential(clientId, clientSecret);
AuthenticationResult result = await authContext.AcquireTokenAsync(resourceId, clientCredential);
```
