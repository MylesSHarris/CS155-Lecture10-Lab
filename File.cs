using System;
namespace Lab
{
    public class File: Document
    {
        private string pathname;

        public File(string pathname, string text) : base(text)
        {
            this.pathname = pathname;
        }

        public string GetPathname() { return pathname; }
        public void SetPathname(string pathname) { this.pathname = pathname; }

        public override string ToString()
        {
            return $"pathname={pathname} contents={base.ToString()}";
        }
    }
}
