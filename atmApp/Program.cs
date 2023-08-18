using System;

public class cardHolder
{
    //cardHolder attributes
    String cardNumber;
    int cardPin;
    double accountBalance;
    String firstName;
    String lastName;

    //constructor fir cardHolder class
    public cardHolder(String cardNumber, int cardPin, double accountBalance, String firstName, String lastName){
        this.cardNumber = cardNumber;
        this.cardPin = cardPin;
        this.accountBalance = accountBalance;
        this.firstName = firstName;
        this.lastName = lastName;  
    } 
    
    //getter methods
    public String getCardNumber()
    {
        return cardNumber;
    }
    
    public int getCardPin()
    {
        return cardPin;
    }

    public double getAccountBalance()
    {
        return accountBalance;
    }

    public string getFirstName()
    {
        return firstName;
    }

    public string getLastName()
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

    public void setAccountBalance(double newAccountBalance)
    {
        accountBalance = newAccountBalance;
    }

    public void setFistName(String newFistName)
    {
        firstName = newFistName;
    }

    public void setLastName(string newLastName)
    {
        lastName = newLastName;
    }

    public static void Main(String[] args)
    {
        void printMenuOptions()
        {
            Console.WriteLine("Please pick and option from the menu: ");
            Console.WriteLine("1. Make a Deposit");
            Console.WriteLine("2. Make a Withdrawal");
            Console.WriteLine("3. Check Available Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit()
        {
            //logic to make a deposit. Wrap in a try catch to ensure valid input
            //parse readLine for deposit amount
        }

        void withdraw()
        {
            //logic to make a widthdraw.
            //parse readline for widthdrawAmount and subtrack from current totalAmount
        }

        void checkFunds()
        {
            //print current funds are return to menu
        }

        // creating a list of cardholders
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder(/*properties*/));

        //Prompt user
        Console.WriteLine("Welcome to the ATM APP!");
        Console.WriteLine("Please enter your credit card: ");
        //string debitCardNum = "";
        cardHolder currentUser;

        // logic to login
        while(true)
        {
            try
            {
                String debitCardNum = Console.ReadLine();
                //check against list of users
                currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNum);
                if(currentUser != null) {
                    break;
                }
                else{
                    Console.WriteLine("Card not recognized. Try again.");
                }
                //break out of loop if not null
            }
            catch{ Console.WriteLine("Card not recognized. Try again."); }

        }

        // logic for the user pin validation
        Console.WriteLine("Please enter your pin: ");
        while(true)
        {
            try
            {
                int cardPin = int.Parse(Console.ReadLine());
                //if the current user getPin function returns something that matches cardPin, break
                //break out of loop if not null
            }
            catch{ Console.WriteLine("Incorrect pin. Try again."); }

        }

        // Greet user and give a list of options
        Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName());
        printMenuOptions();
    }

}

