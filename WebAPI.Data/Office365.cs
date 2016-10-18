using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Data
{
    public enum SendMessageStatusEnum
    {
        NotSent,
        Sent,
        Fail
    }

    // Data / schema contracts between this app and the Office 365 unified API server.
    public class MessageResponse
    {
        public SendMessageStatusEnum Status { get; set; }
        public string StatusMessage { get; set; }
    }

    public class SendMessageRequest
    {
        public Message Message { get; set; }

        public bool SaveToSentItems { get; set; }
    }

    public class Message
    {
        public string Subject { get; set; }
        public MessageBody Body { get; set; }
        public List<Recipient> ToRecipients { get; set; }
    }
    public class Recipient
    {
        public EmailRecipient EmailAddress { get; set; }
    }

    public class MessageBody
    {
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class UserProfile
    {
        public string Name { get; set; } = nameof(Name);
        public string Address { get; set; } = nameof(Address);
        public string AccessToken { get; set; } = nameof(AccessToken);
    }

    public class EmailRecipient
    {
        public string Name { get; set; } = nameof(Name);
        public string Address { get; set; } = nameof(Address);
    }
}
