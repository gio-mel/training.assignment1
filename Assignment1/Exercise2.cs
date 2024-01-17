namespace Assignment1;

public class PhotoBook
{
    private int _numPages;

    public PhotoBook()
    {
        _numPages = 16;
    }
    
    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }

    public int GetNumberPages()
    {
        return _numPages;
    }
}

public class BigPhotoBook : PhotoBook
{
    private int _numPages;

    public BigPhotoBook() : base(64) { }
}

public class PhotoBookTest
{
    public static void Main()
    {
        var defaultPhotoBook = new PhotoBook();
        Console.WriteLine(defaultPhotoBook.GetNumberPages());

        var customPhotoBook = new PhotoBook(50);
        Console.WriteLine(customPhotoBook.GetNumberPages());

        var bigPhotoBook = new BigPhotoBook();
        Console.WriteLine(bigPhotoBook.GetNumberPages());
    }
}