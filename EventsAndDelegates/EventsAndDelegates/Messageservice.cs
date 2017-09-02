using System;

namespace EventsAndDelegates
{
    public class Messageservice
    {
        //event Handler in subscriber
        public void OnVideoEncoded(object source, videoEventArgs e)
        {
            Console.WriteLine("Text servcie: Sending Text msg" + e.video.Title);
        }
    }
}