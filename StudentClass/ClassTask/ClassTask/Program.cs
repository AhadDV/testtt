namespace ClassTask
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Group[] groups = { };

            Group group = new Group();
            group.Limit = 3;
            Console.WriteLine("1 add student");
            Console.WriteLine("0 Close");
            string value = Console.ReadLine();


            while (value == "1")
            {
                string name = Console.ReadLine();
                string surname = Console.ReadLine();
                Student student = new Student(name, surname);

                bool status = group.AddStudent(student);

                CheckStatus(status);

                Console.WriteLine("1 add student");
                Console.WriteLine("0 Close");
                value = Console.ReadLine();
            }
            if (value == "2")
            {
                group.GetStudents2();
            }

        }


        static void CheckStatus(bool status)
        {
            if (status)
                Console.WriteLine("elave olundu");
            else
                Console.WriteLine("elave olunmadi");
        }
    }
}