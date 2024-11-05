using System;

public class Store
{
    private string name;
    private string address;
    private string profileDescription;
    private string contactPhone;
    private string contactEmail;

    public void InputData()
    {
        Console.Write("Введите название магазина: ");
        name = Console.ReadLine();

        Console.Write("Введите адрес магазина: ");
        address = Console.ReadLine();

        Console.Write("Введите описание профиля магазина: ");
        profileDescription = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        contactPhone = Console.ReadLine();

        Console.Write("Введите контактный e-mail: ");
        contactEmail = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Название магазина: " + name);
        Console.WriteLine("Адрес магазина: " + address);
        Console.WriteLine("Описание профиля магазина: " + profileDescription);
        Console.WriteLine("Контактный телефон: " + contactPhone);
        Console.WriteLine("Контактный e-mail: " + contactEmail);
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetAddress(string value)
    {
        address = value;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public void SetProfileDescription(string value)
    {
        profileDescription = value;
    }

    public string GetContactPhone()
    {
        return contactPhone;
    }

    public void SetContactPhone(string value)
    {
        contactPhone = value;
    }

    public string GetContactEmail()
    {
        return contactEmail;
    }

    public void SetContactEmail(string value)
    {
        contactEmail = value;
    }
}

public class Program
{
    public static void Main()
    {
        Store store = new Store();

        store.InputData();

        Console.WriteLine("\nИнформация о магазине:");
        store.DisplayData();

        Console.WriteLine("\nНазвание магазина через геттер: " + store.GetName());
        store.SetName("Новый магазин");
        Console.WriteLine("Новое название магазина через геттер: " + store.GetName());
    }
}