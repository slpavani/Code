using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class videoEventArgs : EventArgs
    {
        public video video { get; set; }
    }





    public class VideoEncoder
    {

        // 1. define a delegate - contract b/w publisher and subscriber.Delegate decides signature for event
        // when ever punblisher invokes/publishes a event
        // 2. define an event
        // 3. raise or publish event

        //old style
        //public delegate void VideoEncodedEventHandler(object source, videoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        //new style of righting eventhandler with delgates
        public event EventHandler<videoEventArgs> VideoEncoded;

        //new style
        public void Encode(video Video)
        {
            //encoding logic
           // OnVideoEncoded();
           Console.WriteLine("Encoding Video...");
           Thread.Sleep(3000);
           OnVideoEncoded(Video);

        }

        //event handler for publisher
        protected virtual void OnVideoEncoded(video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new videoEventArgs() {video =video});

        }

    }
}
