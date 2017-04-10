using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis;
using Google.Apis.Auth;
using Google.Apis.Drive.v2;
using Google.Apis.Auth.OAuth2;
using System.Threading;
using Google.Apis.Util.Store;


namespace GoogleApiDriveUpdateFile
{
    class GoogleAppUpdateFileDI
    {








        public static string Autentificacion()
        {

            string[] MarcoAutentificacion = new string[]
        {
            DriveService.Scope.Drive,
            DriveService.Scope.DriveFile
        
        };
            var clienID = "842993450601-39np4vrmoo6qf541ercdhtsjn35acmbn.apps.googleusercontent.com";
            var clavesecreta = "CgEUyo0Dq0wJa_d7Qkqs5pt8";
            var credencial = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
            {
                ClientId = clienID,
                ClientSecret = clavesecreta
            },

                    MarcoAutentificacion,
                    Environment.UserName,
              CancellationToken.None,
              new FileDataStore("Daimto.GoogleDrive.Auth.Store")).Result;

            return "";



        }

    }


}
