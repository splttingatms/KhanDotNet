# Khan.Net
## Using Khan.Net
### General
Getting data from KhanAcademy is pretty straightforward. If you only need access to public APIs then use the default client constructor as below. Public APIs are those which do not need authentication and are labeled as *Open Access* in [API Explorer](http://api-explorer.khanacademy.org/).
```c#
var client = new KhanClient();
var topics = await client.TopicTree.GetTopicTreeAsync();
```

## Authenticated APIs
Authenticated calls use OAuth authentication and require tokens. Authenticated APIs are labled as *Login Required* in [API Explorer](http://api-explorer.khanacademy.org/). OAuth requests require consumer key/secret to identify the client and access token/secret to identify the resource owner.

You must first identify your application by specifying your application's *consumer key* and *consumer secret* provided by Khan Academy when you registered your application [here](http://www.khanacademy.org/api-apps/register). Then you need to to identify the resource owner by getting an access token. If you already have an access token/secret, go ahead and use the static authenticator as below.

```c#
var appCredentials = new ConsumerCredentials("CONSUMER_KEY", "CONSUMER_SECRET");
var authenticator = new StaticAuthentication("ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");
var client = new KhanClient(authenticator, appCredentials);
```

If you do not have a resource owner's access token/secret, then use the web authenticator. The web authenticator will open up a browser and ask the resource owner to sign in and approve your application's access. Note: The web authenticator requires administrator privileges to run because a local web server is started to receive the temporary token from Khan Academy.

```c#
var appCredentials = new ConsumerCredentials("CONSUMER_KEY", "CONSUMER_SECRET");
var authenticator = new WebAuthentication(appCredentials);
var client = new KhanClient(authenticator, appCredentials);

var user = await client.User.GetUserAsync(); // will open browser
```

## Demo
The project contains a fully functional console API explorer. If you want to try any of the authenticated APIs, you must add your app's credentials (consumer key/secret) to the **App.config** settings file. If you already have an access token for a particular user then add that to your settings as well.

```xml
<appSettings>
   <add key="ConsumerKey" value="CONSUMER_KEY" />
   <add key="ConsumerSecret" value="CONSUMER_SECRET" />
   <!-- Optional: access token will be retrieved at runtime if not specified but requires administrator privileges
    <add key="AccessToken" value="" />
    <add key="AccessTokenSecret" value="" />
    -->
</appSettings>
```
