This Office 365 API is developed by Mostafa Elzoghbi (Twitter: @MostafaElzoghbi)
---------------------------------------------------------------------------------



Samples of queries to load some data from your own Office 365:

1) Login to Office 365, retrieve User Profile including Access Token:
 http://localhost:29104/api/Office365/login

2) Send a message to the logged in user through Exchange Online:
 http://localhost:29104/api/Office365/SendMessage?address=mostafa.elzoghbi@MostafaMSFT.onmicrosoft.com

3) Get SharePoint sites:
 http://localhost:29104/api/Office365/SPSites?address=mostafa.elzoghbi@MostafaMSFT.onmicrosoft.com

4) Get SharePoint site lists:
 http://localhost:29104/api/Office365/SPSiteLists?address=mostafa.elzoghbi@MostafaMSFT.onmicrosoft.com&siteId=974bce0b-0702-4a2b-8ae6-4610f2e06c54