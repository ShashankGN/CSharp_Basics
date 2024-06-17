namespace L17_Enum_demo
{

    enum Gender
    {
        Unknown,
        Male,
        Female
    }
    enum Mobile
    {
        Samsung,
        Apple,
        Oppo
    }
    class Customer
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "John",
                Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Tina",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Abcd",
                Gender = Gender.Unknown
            };

            foreach (Customer customer in customers)
            {
                Console.WriteLine($"Name is {customer.Name},Gender is {GetGender(customer.Gender)}");
            }

            int[] genderValues = (int[])Enum.GetValues(typeof(Gender));
            foreach (int value in genderValues)
            {
                Console.WriteLine(value);
            }

            string[] genderNames=Enum.GetNames(typeof(Gender));
            foreach (string name in genderNames)
            {
                Console.WriteLine(name);
            }

            Gender gender = (Gender)2;
            int mygen=(int)Gender.Male;


            Gender newGender = (Gender)Mobile.Samsung;
        }

        static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Gender";
            }
        }
        
    }
}
