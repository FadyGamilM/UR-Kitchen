namespace UrKitchen.Persistance.Models;

public class User
{
   public int Id {get; set;}
   public string FirstName {get; set;}
   public string LastName {get; set;}
   public string Email {get; set;}
   public string Phone {get; set;}
   public decimal Rate {get; set;}
   public bool Removed {get; set;} = false;
   public List<Order> CreatedOrders {get; set; } = new (); 
   public List<Order> RequestedOrders {get; set; } = new (); 
   public List<Meal> Meals {get; set;} = new ();
   public List<Attendee> Attendees {get; set;} = new ();
}

