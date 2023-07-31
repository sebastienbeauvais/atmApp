using System;

public class cardHolder
{
    //What makes up a card holder??

    //Generate the constructor

    public String getCardNumber()
    {
        //generate getter for cardNumber
    }
    //create the rest of the getter methods (hint: 1 per class attribute)

    public void setCardNumber()
    {
        // create setter for card number
    }
    //create the rest of the setter methods (hint: 1 per class attribute)

    public static void Main(String[] args)
    {
        void printMenuOptions()
        {
            //print the menu options for user (hint: what can you do at an ATM?)
        }

        void deposit()
        {
            //logic to make a deposit. Wrap in a try catch to ensure valid input
            //parse readLine for deposit amount
        }

        void widthdraw()
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

        // Greet user
        Console.WriteLine("Welcome " + currentUser.getFirstName() + " " + currentUser.getLastName());
    }

}

