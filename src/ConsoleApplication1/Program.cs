using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus.Notifications;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hub = NotificationHubClient
                .CreateClientFromConnectionString("Endpoint=sb://NOME_DO_SEU_APP.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=CHAVE_DO_SEU_APP",
                "NOME_DO_SEU_APP");

            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Bem vindos ao VSSummit 2015</text></binding></visual></toast>";
            var toastWithImage = @"<toast><visual><binding template=""ToastImageAndText01""><image id=""1"" src=""https://cdn1.iconfinder.com/data/icons/metro-ui-icon-set/512/Visual_Studio_2012.png"" /><text id=""1"">Bem vindos ao VSSummit15!</text></binding></visual></toast>";
            hub.SendWindowsNativeNotificationAsync(toast).Wait();
        }
    }
}
