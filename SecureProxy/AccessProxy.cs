namespace Zadanie
{
    public class AccessProxy : IDocument
    {
        SecureDocument secureDocument;
        User user;

        public AccessProxy(User user)
        {
            this.secureDocument = new SecureDocument();
            this.user = user;
        }

        public void ReadContent()
        {
            if (this.user.hasAccess)
            {
                this.secureDocument.ReadContent();
            }
            else
            {
                System.Console.WriteLine("User has no permission to read the content.");
            }
        }
    }
}