using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public abstract class Message
    {
        public string DateAndTimeOfTheMessage { get; private set; }
        public PostMessageType MessageType { get; private set; }

        public Message(string dateAndTimeOfTheMessage, PostMessageType messageType) 
        { 
            this.DateAndTimeOfTheMessage = dateAndTimeOfTheMessage;
            this.MessageType = messageType;
        }       
    }
}
