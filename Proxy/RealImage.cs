namespace Zadanie
{
    public class RealImage : IImage
    {
        String filename;

        public RealImage(String filename)
        {
            this.filename = filename;
            System.Console.WriteLine($"Loading image {this.filename}");
        }

        public void Display()
        {
            System.Console.WriteLine("Displaying image");
        }
    }
}