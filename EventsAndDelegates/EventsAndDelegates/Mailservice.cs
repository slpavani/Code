using System;

namespace EventsAndDelegates
{
    public class Mailservice
    {
        //event Handler in subscriber
        public void OnVideoEncoded(object source,  videoEventArgs e)
        {
            Console.WriteLine("Mail servcie: Sending email" + e.video.Title);
        }
    }
}