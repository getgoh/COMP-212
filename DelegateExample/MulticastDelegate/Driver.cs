using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
          class Driver
          {
                    public static void Main(string[] args)
                    {
                              Publisher publisher = new Publisher();
                       
                              SendViaMobile send2Mobile = new SendViaMobile("416 1234567");
                              SendViaEmail send2Email = new SendViaEmail("li@my.centennialcollege.ca");

                              //Subscribing for Mobile notifications
                              send2Mobile.Subscribe(publisher);

                              //Emails are not subscribed so it wont receive notifications via Email
                              send2Email.Subscribe(publisher);

                              //Invoking the delegate Only Mobile will receive notifications.
                              publisher.PublishMessage("Hello You Have New Notifications");
                              Console.ReadKey();
                    }
          }
}
