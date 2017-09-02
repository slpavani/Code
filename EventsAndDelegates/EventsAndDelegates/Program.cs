using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            video video = new video() {Title = "pavani"};
            var videoEncoder =new VideoEncoder(); //publisher
            var mailservice = new Mailservice();
            var messageservice = new Messageservice(); 
            
            //publisher.event += subscriber.eventhandlerin subscriber
            //mailservice.OnVideoEncoded  -- a pointer or reference to eventhhandler method
            //mailservice.OnVideoEncoded() -- calling a  method
            
            //registering a subscription i.e registering handler to event

            videoEncoder.VideoEncoded += mailservice.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageservice.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}

