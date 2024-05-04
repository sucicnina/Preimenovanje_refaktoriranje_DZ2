//Preimenovanje:
//Zadatak 2:
class Product
{
    public string Name { get; private set; } 
    public decimal Price { get; private set; } 
    public bool IsStocked { get; set; } 

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
        this.IsStocked = false;
    }
}

class Inventory
{
    List<Product> products; 

    public Inventory(List<Product> products) 
    {
        this.products = products;
    }

    public void Restock(Product product)
    {
        foreach (Product prod in products)
        { 
            if (product == prod)
                prod.IsStocked = true;
        }
    }
    public void RemoveSoldOut()
    { 
        products.RemoveAll(product => product.IsStocked == false);
    }
}

//Zadatak 4:
public class Note
{
    public string Title { get; set; }
    public string Text { get; set; }
    public DateTime Date { get; private set; }

    public Note(string title, string text)
    {
        Title = title;
        Text = text;
        Date = DateTime.Now;
    }
}

public class Notebook
{
    public string Author { get; private set; }
    public List<Note> notes;

    public Notebook(string author)
    {
        Author = author;
        notes = new List<Note>();
    }

    public void AddNote(Note note)
    {
        notes.Add(note);
    }
}

//Zadatak 5:

public class Location
{
    public DateTime CreatedAt { get; private set; } 
    public double Latitude { get; private set; } 
    public double Longitude { get; private set; } 

    public Location(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
        CreatedAt = DateTime.Now;
    }
}

public class PathManager
{
    private List<Location> locations; 

    public PathManager()
    {
        locations = new List<Location>();
    }

    public void AddNewLocation(Location location)
    {
        locations.Add(location);
    }

    public void RemoveLocation(Location location)
    {
        locations.Remove(location);
    }
}
