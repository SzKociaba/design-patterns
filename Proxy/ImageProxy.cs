namespace Zadanie
{
    public class ImageProxy : IImage
    {
        String filename;
        Boolean displayed = false;

        public ImageProxy(String filename)
        {
            this.filename = filename;
        }

        public void Display()
        {
            if (displayed)
            {
                System.Console.WriteLine("Image already displayed");
                return;
            }
            ;
            RealImage realImage = new RealImage(filename);
            realImage.Display();
            displayed = true;
        }
    }
}