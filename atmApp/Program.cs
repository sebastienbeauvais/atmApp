using System;

public class cardHolder
{
    //cardHolder attributes
    String cardNumber;
    int cardPin;
    double balance;
    String firstName;
    String lastName;

    //constructor for cardHolder class
    public cardHolder(String cardNumber, int cardPin, double balance, String firstName, String lastName){
        this.cardNumber = cardNumber;
        this.cardPin = cardPin;
        this.balance = balance;
        this.firstName = firstName;
        this.lastName = lastName;  
    } 
    
    //getter methods
    public String getNum() //get the card number
    {
        return cardNumber;
    }
    
    public int getPin() //get card pin number
    {
        return cardPin;
    }

    public double getBalance() // get account balance
    {
        return balance;
    }

    public string getFirstName() //get first name
    {
        return firstName;
    }

    public string getLastName() // get last name
    {
        return lastName;
    }

    //setter methods
    public void setCardNumber(String newCardNumber)
    {
        cardNumber = newCardNumber;
    }
    
    public void setCardPin(int newCardPin)
    {
        cardPin = newCardPin;
    }

    public void setBalance(double newAccountBalance)
    {
        balance = newAccountBalance;
    }

    public void setFistName(String newFistName)
    {
        firstName = newFistName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public static void Main(String[] args)
    {
        void printMenuOptions()
        {
            //print the menu options for user (hint: what can you do at an ATM?)
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Make a deposit");
            Console.WriteLine("2. Make a withdrawal");
            Console.WriteLine("3. Check account balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            //logic to make a deposit. Wrap in a try catch to ensure valid input
            //parse readLine for deposit amount
            Console.WriteLine("How much would you like to deposit: ");
            try
            {
                double deposit = double.Parse(Console.ReadLine());
                currentUser.setBalance(deposit);
                Console.WriteLine("Thank you for your deposit. Your new account balance is " + currentUser.getBalance());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void withdraw(cardHolder currentUser)
        {
            //logic to make a widthdraw.
            //parse readline for widthdrawalAmount and subtrack from current totalAmount
            Console.WriteLine("How much would you like to withdraw: ");
            try
            {
                double withdrawal = double.Parse(Console.ReadLine());
                // Check if user has enough money
                if (withdrawal > currentUser.getBalance())
                {
                    Console.WriteLine("Not enough funds to make withdrawal.");
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawal);
                    Console.WriteLine("Your new account balance is: " + currentUser.getBalance());
                    Console.WriteLine("Please take your withdrawal of " + withdraw + "from the tray below.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void checkFunds(cardHolder currentUser)
        {
            //print current funds are return to menu
            Console.WriteLine("Your account balance is: " + currentUser.getBalance());
        }

        // creating a list of cardholders
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("1112223334445555", 1234, 10990.86, "John", "Smith"));
        cardHolders.Add(new cardHolder("1234123412341234", 1122, 17790.32, "Felicia", "Jones"));
        cardHolders.Add(new cardHolder("1212343456567878", 3357, 124765.11, "Rich", "Gregor"));
        cardHolders.Add(new cardHolder("9900828237561237", 4589, 723.06, "Alice", "Jones"));
        cardHolders.Add(new cardHolder("3452567935722454", 8573, 1029374.83, "Rebecca", "Robbles"));

        //Prompt user
        Console.WriteLine("Welcome to the ATM APP!");
        Console.WriteLine("Please enter your credit card: ");
        string debitCardNum = "";
        cardHolder currentUser;

        // logic to login
        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //check against list of users
                currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNum);
                if(currentUser != null) {
                    break;
                }
                else {
                    Console.WriteLine("Card not recognized. Try again.");
                }
                //break out of loop if not null
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }

        }

        // logic for the user pin validation
        Console.WriteLine("Please enter your pin: ");
        int cardPin = 0;
        while(true)
        {
            try
            {
                cardPin = int.Parse(Console.ReadLine());
                //if the current user getPin function returns something that matches cardPin, break
                //break out of loop if not null
                if(currentUser.getPin() == cardPin) {
                    Console.WriteLine("Thank you, pin authenticated.");
                    break;
                }
                else {
                    Console.WriteLine("Pin incorrect. Try again.");
                }
            }
            catch (Exception e)
            { 
                Console.WriteLine(e.Message); 
            }

        }

        // Greet user
        Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName());
        int option = 0;

        do
        {
            printMenuOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (option == 1) {
                deposit(currentUser);
            }
            else if (option == 2) {
                withdraw(currentUser);
            }
            else if(option == 3) {
                checkFunds(currentUser);
            }
            else if (option == 4) {
                break;
            }
            else {
                option = 0;
            }
        }
        while (option != 4);
        Console.WriteLine("Thank you, have a nice day!");
    }

}

