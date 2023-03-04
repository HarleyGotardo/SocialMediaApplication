using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public abstract class Message
    {
        public string MessageContent { get; private set; }
        public string DateAndTimeOfTheMessage { get; private set; }
        public string MessageType { get; private set; }

        public Message(string messageContent, string dateAndTimeOfTheMessage, string messageType) 
        { 
            this.MessageContent = messageContent;
            this.DateAndTimeOfTheMessage = dateAndTimeOfTheMessage;
            this.MessageType = messageType;
        }
        
    }
}
