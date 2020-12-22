using System;
namespace Lab
{ 
    public class Document
    {
        private string text;

        public Document(string text)
        {
            this.text = text;
        }

        public void SetText(String text) { this.text = text; }

        public override string ToString()
        {
            return text;
        }
    }
}
