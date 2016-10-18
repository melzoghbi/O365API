# Office 365 Web API using Microsoft Graph
.NET Core Web API that is integrated with Microsoft Graph API.








## Samples of queries to load some data from your Office 365 tenant:

1) Login to Office 365, retrieve User Profile including User Name, Email and Access Token:
[Login Url](http://localhost:29104/api/Office365/Login)

2) Send a message to the logged in user through Exchange Online:
 [Send an Email](http://localhost:29104/api/Office365/SendMessage?address=User_ID@TenantId.onmicrosoft.com)

3) Get SharePoint sites:
 [Get SharePoint sites in Office 365 tenant](http://localhost:29104/api/Office365/SPSites?address=USER_ID@TenantId.onmicrosoft.com)

4) Get SharePoint site lists:
 [Get SharePoint site lists](http://localhost:29104/api/Office365/SPSiteLists?address=USER_ID@TenantId.onmicrosoft.com&siteId=974bce0b-0702-4a2b-8ae6-4610f2e06c54)




## This Office 365 API is developed by Mostafa Elzoghbi (Twitter: @MostafaElzoghbi)
---------------------------------------------------------------------------------
Contribute and let's make it better!