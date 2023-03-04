using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaApplicationFacebook
{
    public abstract class Message
    {
        public UserProfile Sender { get; private set; }
        public string MessageContent { get; private set; }
        public string DateAndTimeOfTheMessage { get; private set; }
        public PostMessageType MessageType { get; private set; }

        public Message(UserProfile sender, string messageContent, string dateAndTimeOfTheMessage, PostMessageType messageType) 
        { 
            this.Sender = sender;
            this.MessageContent = messageContent;
            this.DateAndTimeOfTheMessage = dateAndTimeOfTheMessage;
            this.MessageType = messageType;
        }       
    }
}
