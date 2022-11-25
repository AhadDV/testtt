
internal class Student
{
    string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            while (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("nameyi duzgun daxil et");
                value = Console.ReadLine();
            }
            _name = value;
        }
    }

    string _surName;
    public string SurName
    {
        get
        {
            return _surName;
        }
        set
        {
            while (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("surnameyi duzgun daxil et");
                value = Console.ReadLine();
            }
            _surName = value;
        }
    }


    public Student(string name, string surname)
    {
        Name = name;
        SurName = surname;
    }

    public override string ToString()
    {
        return $"{Name}  {SurName}";
    }
}
