using System;

namespace C.Sharp.Whats.New
{
    public class Program
    {
        #region 1) Auto-Property

        /// <summary>
        ///     Person - Auto property c#5
        /// </summary>
        //class Person
        //{
        //    private readonly string firstName;

        //    public string FirstName
        //    {
        //        get { return this.firstName; }
        //    }

        //    public Person(string firstName)
        //    {
        //        this.firstName = firstName;
        //    }
        //}

        /// <summary>
        ///     Person - Auto property C#6
        /// </summary>
        //class Person
        //{
        //    public string FirstName { get; }

        //    public Person(string firstName)
        //    {
        //        this.FirstName = firstName;
        //    }
        //}

        #endregion

        #region 2) String Interpolation

        /// <summary>
        ///     Person - String Interpolation c#5
        /// </summary>
        //class Person
        //{
        //    private readonly string firstName;
        //    public string FirstName
        //    {
        //        get { return this.firstName; }
        //    }

        //    private readonly string lastName;
        //    public string LastName
        //    {
        //        get { return this.lastName; }
        //    }

        //    public Person(string firstName, string lastName)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //    }

        //    public override string ToString()
        //    {
        //      return string.Format("Person: {0} {1}", this.FirstName, this.LastName);
        //    }
        //}

        /// <summary>
        ///     Person - String Interpolation C#6
        /// </summary>
        //class Person
        //{
        //    private readonly string firstName;
        //    public string FirstName
        //    {
        //        get { return this.firstName; }
        //    }

        //    private readonly string lastName;
        //    public string LastName
        //    {
        //        get { return this.lastName; }
        //    }

        //    public Person(string firstName, string lastName)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Person: {this.FirstName} {this.LastName}";
        //       //it evaluates expressions! ((Func<string>)(() => { string suffix = ".com"; return suffix; }))()
        //    }


        //}

        #endregion

        #region 3) Expression bodied Members

        /// <summary>
        ///     Person - Expression bodied Members c#5
        /// </summary>
        //class Person
        //{
        //    private readonly string firstName;
        //    public string FirstName
        //    {
        //        get { return this.firstName; }
        //    }

        //    private readonly string lastName;
        //    public string LastName
        //    {
        //        get { return this.lastName; }
        //    }

        //    /// Expression on Properties
        //    public string FullName
        //    {
        //        get { return this.FirstName + " " + this.LastName; }
        //    }

        //    /// Expression on Methods
        //    public void GreetPerson( Person person)
        //    {
        //        Console.WriteLine("{0} says hi to {1}", person.FullName, this.FullName);
        //    }

        //    public Person(string firstName, string lastName)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //    }

        //    public override string ToString()
        //    {
        //        return string.Format("Person: {0} {1}", this.FirstName, this.LastName);
        //    }
        //}

        /// <summary>
        ///     Person - Expression bodied Members c#5
        /// </summary>
        //class Person
        //{
        //    private readonly string firstName;
        //    public string FirstName
        //    {
        //        get { return this.firstName; }
        //    }

        //    private readonly string lastName;
        //    public string LastName
        //    {
        //        get { return this.lastName; }
        //    }

        //    /// Expression on Properties
        //    public string FullName => this.FirstName + " " + this.LastName;

        //    /// Expression on Methods
        //    public void GreetPerson(Person person) => 
        //        Console.WriteLine($"{person.FullName} says hi to {this.FullName}");

        //    public Person(string firstName, string lastName)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Person: {this.FirstName} {this.LastName}";
        //    }

        //    }

        #endregion

        #region 4) Nullability

        //public class Address
        //{
        //    public string PostCode { get; set; } 
        //}

        //class Person
        //{
        //    public Address Address { get; set; }
        //}

        /// <summary>
        ///     Person - Expression bodied Members c#5
        /// </summary>
        //class Person
        //{
        //    private readonly string firstName;
        //    public string FirstName
        //    {
        //        get { return this.firstName; }
        //    }

        //    private readonly string lastName;
        //    public string LastName
        //    {
        //        get { return this.lastName; }
        //    }

        //    /// Expression on Properties
        //    public string FullName => this.FirstName + " " + this.LastName;

        //    /// Expression on Methods
        //    public void GreetPerson(Person person) => 
        //        Console.WriteLine($"{person.FullName} says hi to {this.FullName}");

        //    public Person(string firstName, string lastName)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //    }

        //    public override string ToString()
        //    {
        //        return $"Person: {this.FirstName} {this.LastName}";
        //    }

        //    }

        #endregion

        #region 5) Using NameOf

        class Person
        {
            private readonly string firstName;
            public string FirstName
            {
                get { return this.firstName; }
            }

            public Person(string firstName)
            {
                this.firstName = firstName;
            }

            /// nameOf C#5
            /// 


            //public void GreetPerson(Person person)
            //{
            //    if (person == null)
            //    {
            //        throw new ArgumentNullException("person");
            //    }

            //    Console.WriteLine("{0} says hi to {1}", person.FirstName, this.FirstName);
            //}

            /// nameOf C#6
             
            
            public void GreetPerson(Person person)
            {
                if (person == null)
                {
                    throw new ArgumentNullException(nameof(person));
                }

                Console.WriteLine($"{person.FirstName} says hi to {this.FirstName}");
            }
        }

        /// <summary>
        ///     Person - Auto property C#6
        /// </summary>
        //class Person
        //{
        //    public string FirstName { get; }

        //    public Person(string firstName)
        //    {
        //        this.FirstName = firstName;
        //    }
        //}

        #endregion

        private static void Main(string[] args)
        {

            var person = new Person("Petr");
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person);
            Console.WriteLine(person);

            #region Nullability

            //Nullability C#5
            //string postCode = null;
            //if ((person != null) && (person.Address != null) && (person.Address.PostCode != null))
            //{
            //    postCode = person.Address.PostCode.ToString();
            //}

            //Nullability C#6
            //string postCode = person?.Address?.PostCode?.ToString();
            #endregion
            Console.ReadKey();
        }
    }
}