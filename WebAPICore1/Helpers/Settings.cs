using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICore1.Helpers
{
    public static class Settings
    {
        public static string ClientId;
        public static string ClientSecret;

        public static string AzureADAuthority = @"https://login.microsoftonline.com/common";
        public static string LogoutAuthority = @"https://login.microsoftonline.com/common/oauth2/logout?post_logout_redirect_uri=";
        public static string GraphAPIResource = @"https://graph.microsoft.com/";

        public static string SendMessageUrl = @"https://graph.microsoft.com/v1.0/me/microsoft.graph.sendmail";
        public static string SharePointUrl = @"https://graph.microsoft.com/beta/sharePoint/sites";

        public static string GetMeUrl = @"https://graph.microsoft.com/v1.0/me";
        public static string MessageBody = @"<html>
                                            <head>
                                            <meta http-equiv=\'Content-Type\' content=\'text/html; charset=us-ascii\'> <title></title> 
                                            </head>
                                            <body style=\'font-family:calibri\'> 
                                            <p>Congratulations {0},</p> 
                                            <p>This is a message from the Office 365 .NET Core Web API. You are well on your way to incorporating Office 365 services in your web and mobile apps. </p> 
                                            <h3>What&#8217;s next?</h3> <ul>
                                            <li>Check out <a href='http://dev.office.com' target='_blank'>dev.office.com</a> to start building Office 365 apps today with all the latest tools, templates, and guidance to get started quickly.</li>
                                            <li>Head over to the <a href='https://msdn.microsoft.com/office/office365/howto/office-365-unified-api-reference' target='blank'>API reference on MSDN</a> to explore the rest of the APIs.</li>
                                            <li>Browse other <a href='https://github.com/OfficeDev/' target='_blank'>samples on GitHub</a> to see more of the APIs in action.</li>
                                            </ul> 

                                            <h3>Give us feedback</h3> <ul><li>If you have any trouble running this sample, please <a href='https://github.com/melzoghbi/O365API/issues' target='_blank'>log an issue</a>.</li>
                                            <li>For general questions about the Office 365 APIs, post to <a href='http://stackoverflow.com/' target='blank'>Stack Overflow</a>. Make sure that your questions or comments are tagged with [office365].</li>
                                            </ul>
                                            <p>Thanks and happy coding!<br>
                                            Twitter: @MostafaElzoghbi </p> 

                                            <div style=\'text-align:center; font-family:calibri\'> <table style=\'width:100%; font-family:calibri\'> <tbody> <tr> <td>
                                            <a href='https://github.com/melzoghbi/O365API'>See on GitHub</a> </td> <td>
                                            <a href='http://officespdev.uservoice.com/'>Suggest on UserVoice</a> </td> 
                                             </tr> </tbody> </table> </div> </body> </html>";
    
    public static string MessageSubject;

    }
}
