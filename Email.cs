using System;
namespace Lab
{
    public class Email: Document
    {
        // instance variables for the sender, recipient, and title of an email message
        private string sender, recipient, title;

        public Email(string sender, string recipient, string title, string body) : base(body)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.title = title;
        }

        public string GetSender() { return sender; }
        public void SetGender(string sender) { this.sender = sender; }

        public string GetRecipient() { return recipient; }
        public void SetRecipient(string recipient) { this.recipient = recipient; }

        public string GetTitle() { return title; }
        public void SetTitle(string title) { this.title = title; }

        public override string ToString()
        {
            return $"sender={sender} recipient={recipient} title={title} body={base.ToString()}";
        }
    }
}
