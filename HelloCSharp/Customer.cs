using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    public class Customer
    {
        private string firstName, lastName, emailAdd, feedBack, serviceProvider, phoneNoHm, rating;

        private int  id; // rating can be array abased on No of providers
        private static int numOfCustomers = 0, newCustomers = 0, currentCustomer = 0, maxCustomers = 100;
        // Class Helpers / Fields
        private static string[] ratings = { "Un - Known", "Worst", "Poor", "Average", "Good", "Excellent" };
        // This can be used if complexity increases and service providers need to be tracked and rated etc.
        // private static string servieProviders[] = {"Telstra", "Optus", "Inet"}; // Add more
        private static Customer[] customers = new Customer[maxCustomers];


        public Customer(int id, string firstName, string lastName, string emailAdd, string phoneNoHm, string rating, string serviceProvider)
        {
            this.id = id;
            this.serviceProvider = serviceProvider;
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAdd = emailAdd;
            this.phoneNoHm = phoneNoHm;
            this.rating = rating;
            numOfCustomers++;
            
        }
        private Customer(int id, string firstName, string lastName, string emailAdd, string phoneNoHm, string rating):
            this(id, firstName, lastName, emailAdd, phoneNoHm, rating, "Un Known"){}
        private Customer(int id, string firstName, string lastName, string emailAdd, string phoneNoHm):
            this(id, firstName, lastName, emailAdd, phoneNoHm, "Un Known")
        { }
        private Customer(int id, string firstName, string lastName, string emailAdd):
            this(id, firstName, lastName, emailAdd, " ", "Un Known")  { }
        private Customer(int id, string firstName, string lastName): 
            this(id, firstName, lastName, " ", "", "Un Known") {}
        private Customer(int id, string firstName) :
            this(id, firstName, " ", " ", "", "Un Known") {}
        private Customer(int id):
            this(id, " ", " ", " ", "", "Un Known")
        {}
        private Customer():
            this(0, " ", " ", " ", "", "Un Known")
        {}


        private static void setFirstName(string firstName) { customers[currentCustomer].firstName = firstName; }
        private static void setLastName(string lastName) { customers[currentCustomer].lastName = lastName; }
        private static void setEmailAdd(string emailAdd) { customers[currentCustomer].emailAdd = emailAdd; }
        private static void setPhoneNoHm(string phoneNoHm) { customers[currentCustomer].phoneNoHm = phoneNoHm; }
        private static void setServiePro(string service) { customers[currentCustomer].serviceProvider = service; }
        private static void setReview(string review) { customers[currentCustomer].feedBack = review; }
        private static void setRating(string rating) { customers[currentCustomer].rating = rating; }
        /// Getters 

        private static string getFirstName() { return customers[currentCustomer].firstName; }
        private static string getLastName() { return customers[currentCustomer].lastName; }
        private static string getEmailAdd() { return customers[currentCustomer].emailAdd; }
        private static string getService() { return customers[currentCustomer].serviceProvider; }
        private static string getPhoneNoHm() { return customers[currentCustomer].phoneNoHm; }
        private static string getReview() { return customers[currentCustomer].feedBack; }
        private static string getRating() { return customers[currentCustomer].rating; }
        private static int getId() { return customers[currentCustomer].id; }



        public static void setUpCustomers() { getCustomers(); }
        public static void onClose() { writeToCustomers(); }
        public static int getCustomerCount() { return numOfCustomers; }


        public static string[] getCustomer(int index)
        {
            int temp = currentCustomer;
            currentCustomer = index;

            string[] customerData =
                    {
                        getFirstName(),
                        getLastName(),
                        getEmailAdd(),
                        getPhoneNoHm(),
                        getRating(),
                        getService()
                        , getReview()
                };
            currentCustomer = temp;
            return customerData;
        }
       public static void updateCustomer(string[] updatedCustomer, int customerIndex)
        {
            if (customerIndex >= 0 && customerIndex <= maxCustomers )
            {
                currentCustomer = customerIndex;

                setFirstName(updatedCustomer[0]);
                setLastName(updatedCustomer[1]);
                setEmailAdd(updatedCustomer[2]);
                setPhoneNoHm(updatedCustomer[3]);

                setRating(updatedCustomer[4]);
                setServiePro(updatedCustomer[5]);
                setReview(updatedCustomer[6]);
                //System.out.println(getFirstName() + "  " + "Rating: " + getRating());
            }
        }
        public static void addNewCustomer(string[] newCustomerData)
        {
            currentCustomer = numOfCustomers;

            string[] newCustomer = checkNewCustomerData(newCustomerData);

            customers[currentCustomer] = new Customer(newID(), newCustomer[0], newCustomer[1], newCustomer[2], newCustomer[3], (newCustomer[4]), newCustomer[5]); // Rating

            //numOfCustomers++;
            currentCustomer = numOfCustomers - 1;
           Console.WriteLine("New Customer Added: " + numOfCustomers);
        }
        // Private
        private static string[] checkNewCustomerData(string[] newCustomer)
        {
            for (int i = 0; i < newCustomer.Length; i++)
            {
                if (newCustomer[i] == null) { newCustomer[i] = " "; }
            }
            return newCustomer;
        }
        private static int newID()
        {
            return numOfCustomers + 1; // could be upgraded when delete etc. comes into play
        }
        private static int stringToInt(string num)
        {
            int value;
            try { value = Int32.Parse((num)); }
            catch (FormatException e) { value = 0; }

            return value;
        }
        private static string intTostring(int convertMePlz)
        {
            try { return convertMePlz.ToString(); }

            catch (FormatException ex) { return intTostring(0); }
        }
        private static void getCustomers()
        {

            string[] lines = new string[1000];
            int gg = 0; int i = 0; int x = 0;

            FileStream inFile = new FileStream("customers.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamIn = new StreamReader(inFile);

            while ((lines[x] = streamIn.ReadLine()) != null)
            {
                int ds = x;
                Console.WriteLine("Input: " + lines[x]);
                if (((ds + 1) % 8) == 0)
                {
                    i = x - 7;
                    Customer.customers[gg] = new Customer(
                            stringToInt(lines[i++]),
                            lines[i++],
                            lines[i++],
                            lines[i++],
                            lines[i++],
                            lines[i++],
                            lines[i]);
                    gg++; newCustomers++;
                }
               // Console.WriteLine(lines[x] + " || x : " + x);
                x++;
            }
                streamIn.Close();

            Console.WriteLine("Num of Customers:     " + numOfCustomers);
             getReviews();
        }
        private static void getReviews()
        {
            string[] reviewlines = new string[1000];
            int y = 0;
            currentCustomer = 0;
            string currentReview = "";           

            FileStream inFile = new FileStream("reviews.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamIn = new StreamReader(inFile);
            while ((reviewlines[y] = streamIn.ReadLine()) != null && currentCustomer < numOfCustomers)
            {
                if (reviewlines[y].Equals("-"))
                {
                    setReview(currentReview);
                    Console.WriteLine(currentReview);
                    currentReview = "";
                    currentCustomer++; 
                    y++;
                }
                currentReview += reviewlines[y];
                y++;
            }
              streamIn.Close();
    
        }

        private static void writeToReviews()
        {
            // will do if needed
        }
        private static void writeToCustomers()
        {
            // string fileName = "/Users/bradkent/Documents/SoftwareEng/Java/workspace/CaoticCallCenter/src/oop1/CaoticCallCenter/DataDiles/Customers.txt";// "C:\\Users\\Battl\\IdeaProjects\\Caotic Call Center\\src\\sample/reviews.txt";
            // try {
            //     FileWriter fileWriter = new FileWriter(fileName);

            //     BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);
            //     currentCustomer = 0;
            //     for(int i = 0; i < numOfCustomers; i++)
            //     {
            //         bufferedWriter.write(intTostring(getId())); //ID
            //         bufferedWriter.newLine();

            //         bufferedWriter.write(getFirstName());// F name
            //         bufferedWriter.newLine();

            //         bufferedWriter.write(getLastName()); // L name
            //         bufferedWriter.newLine();

            //         bufferedWriter.write(getEmailAdd()); // email
            //         bufferedWriter.newLine();

            //         bufferedWriter.write(getPhoneNoHm()); // phone
            //         bufferedWriter.newLine();

            //         bufferedWriter.write(intTostring(getRating())); // rating
            //         bufferedWriter.newLine();

            //         bufferedWriter.write(getService());
            //         bufferedWriter.newLine();

            //         bufferedWriter.newLine();
            //         currentCustomer++;
            //         System.out.println("Writing Customers: " + currentCustomer);
            //     }
            //     bufferedWriter.close();
            // }
            // catch(IOException ex) {System.out.println("Error writing to file '" + fileName + "'");}
            // ex.printStackTrace();
        }




    }
}
