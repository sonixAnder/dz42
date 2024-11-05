using System;

public class Journal
{
    // Поля класса
    private string title;
    private int yearFounded;
    private string description;
    private string contactPhone;
    private string contactEmail;

    // Метод для ввода данных
    public void InputData()
    {
        Console.Write("Введите название журнала: ");
        title = Console.ReadLine();

        Console.Write("Введите год основания: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            yearFounded = year;
        }
        else
        {
            Console.WriteLine("Неверный формат года. Установлено значение по умолчанию (0).");
            yearFounded = 0;
        }

        Console.Write("Введите описание журнала: ");
        description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        contactPhone = Console.ReadLine();

        Console.Write("Введите контактный e-mail: ");
        contactEmail = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Название журнала: " + title);
        Console.WriteLine("Год основания: " + yearFounded);
        Console.WriteLine("Описание журнала: " + description);
        Console.WriteLine("Контактный телефон: " + contactPhone);
        Console.WriteLine("Контактный e-mail: " + contactEmail);
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string value)
    {
        title = value;
    }

    public int GetYearFounded()
    {
        return yearFounded;
    }

    public void SetYearFounded(int value)
    {
        yearFounded = value;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetDescription(string value)
    {
        description = value;
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
        Journal journal = new Journal();

        journal.InputData();

        Console.WriteLine("\nИнформация о журнале:");
        journal.DisplayData();

        Console.WriteLine("\nНазвание журнала через геттер: " + journal.GetTitle());
        journal.SetTitle("Новый журнал");
        Console.WriteLine("Новое название журнала через геттер: " + journal.GetTitle());
    }
}
