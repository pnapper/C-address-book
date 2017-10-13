using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private int _phone;
    private string _address;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, int phone, string address)
    {
      _name= name;
      _phone = phone;
      _address = address;
      _instances.Add(this);
      _id = _instances.Count;
    }

  // public class Address
  // {
  //   private string _address;
  //   private string _city;
  //   private string _state;
  //   private int _zip;
  //   private static List<Address> _instances = new List<Address> {};

    // public Address(string address, string city, string state, int zip)
    // {
    //   _address = address;
    //   _city = city;
    //   _state = state;
    //   _zip = zip;
    // }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetPhone()
    {
      return _phone;
    }

    public void SetPhone(int newPhone)
    {
      _phone = newPhone;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Contact> GetAll()
    {
      return _instances;
    }

    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void Clear()
    {
      _instances.Clear();
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
