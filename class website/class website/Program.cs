using System;

public class Website
{
    // Поля класса
    private string name;
    private string url;
    private string description;
    private string ipAddress;

    // Метод для ввода данных
    public void InputData()
    {
        Console.Write("Введите название сайта: ");
        name = Console.ReadLine();

        Console.Write("Введите URL сайта: ");
        url = Console.ReadLine();

        Console.Write("Введите описание сайта: ");
        description = Console.ReadLine();

        Console.Write("Введите IP адрес сайта: ");
        ipAddress = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Название сайта: " + name);
        Console.WriteLine("URL сайта: " + url);
        Console.WriteLine("Описание сайта: " + description);
        Console.WriteLine("IP адрес сайта: " + ipAddress);
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public string GetUrl()
    {
        return url;
    }

    public void SetUrl(string value)
    {
        url = value;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string value)
    {
        description = value;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    public void SetIpAddress(string value)
    {
        ipAddress = value;
    }
}

public class Program
{
    public static void Main()
    {
        Website site = new Website();
        site.InputData();

        Console.WriteLine("\nИнформация о сайте:");
        site.DisplayData();

        Console.WriteLine("\nНазвание сайта через геттер: " + site.GetName());
        site.SetName("Новый сайт");
        Console.WriteLine("Новое название сайта через геттер: " + site.GetName());
    }
}
