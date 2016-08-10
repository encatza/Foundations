// IT Fdn Class Project Template.cs
// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.

using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;


struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory

        int numberOfItems = 0;

        // create an array of your ItemData struct

        ItemData[] itemprop = new ItemData[100];
        

        // use a never ending loop that shows the user what options they can select 

        // as long as no one Quits, continue the inventory update

        // in that loop, show what user can select from the list

        // read the user's input and then create what case it falls

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("----------------Welcome to inventory tracking system-------------");
            Console.WriteLine();
            Console.WriteLine("Please select an option: ");
            Console.WriteLine();
            Console.WriteLine("[1] - Add and Item  ");
            Console.WriteLine("[2] - Change Item ");
            Console.WriteLine("[3] - Delete an Item ");
            Console.WriteLine("[4] - List all items in the inventory");
            Console.WriteLine("[5] - Quit the programm");
            Console.WriteLine();
            
            string strx = Console.ReadLine();	// read user's input	

            int optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen



            switch (optx)
            {
                case 1: // add an item to the list if this option is selected
                    {

                        Console.Write("Please enter item ID: ");
                        int itemid = Convert.ToInt32(Console.ReadLine());
                        itemprop[numberOfItems].itemIDNo = itemid;
                        Console.WriteLine();


                        Console.Write("Please enter an item description: ");
                        string description = Console.ReadLine();
                        itemprop[numberOfItems].sDescription = description;
                        Console.WriteLine();

                        Console.Write("Please enter price per item: ");
                        string strpriceperitem = Console.ReadLine();
                        double priceperitem = double.Parse(strpriceperitem);
                        itemprop[numberOfItems].dblPricePerItem = priceperitem;
                        Console.WriteLine();

                        Console.Write("Please enter quantity on hand: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        itemprop[numberOfItems].iQuantityOnHand = quantity;
                        Console.WriteLine();

                        Console.Write("Please enter cost of item: ");
                        string strcostperitem = Console.ReadLine();
                        double costpriceperitem = double.Parse(strcostperitem);
                        itemprop[numberOfItems].dblOurCostPerItem = costpriceperitem;
                        Console.WriteLine();


                        itemprop[numberOfItems].dblValueOfItem = itemprop[numberOfItems].iQuantityOnHand * itemprop[numberOfItems].dblPricePerItem;

                        
                        Console.WriteLine();


                        numberOfItems++;

                        break;
                    }


                case 2: //change items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strchgid = Console.ReadLine();
                        int chgid = int.Parse(strchgid);
                        bool fFound = false;


                        // code to show what has to happen if the item in the list is found
                        // reset the count to show a new count for your list 
                        // (Note: your list is now increased by one item)

                        for (int x = 0; x < numberOfItems; x++)
                        {
                            if (itemprop[x].itemIDNo == chgid)
                            {
                                fFound = true;
                                Console.WriteLine();

                                Console.Write("Please enter item ID: ");
                                int itemid = Convert.ToInt32(Console.ReadLine());
                                itemprop[x].itemIDNo = itemid;
                                Console.WriteLine();
                            

                                Console.Write("Please enter an item description: ");
                                string description = Console.ReadLine();
                                itemprop[x].sDescription = description;
                                Console.WriteLine();

                                Console.Write("Please enter price per item: ");
                                string strpriceperitem = Console.ReadLine();
                                double priceperitem = double.Parse(strpriceperitem);
                                itemprop[x].dblPricePerItem = priceperitem;
                                Console.WriteLine();

                                Console.Write("Please enter quantity on hand: ");
                                int quantity = Convert.ToInt32(Console.ReadLine());
                                itemprop[x].iQuantityOnHand = quantity;
                                Console.WriteLine();

                                Console.Write("Please enter cost of item: ");
                                string strcostperitem = Console.ReadLine();
                                double costpriceperitem = double.Parse(strcostperitem);
                                itemprop[x].dblOurCostPerItem = costpriceperitem;
                                Console.WriteLine();

                                itemprop[x].dblValueOfItem = itemprop[x].iQuantityOnHand * itemprop[x].dblPricePerItem;

                                Console.WriteLine();

                                x++;
   
                            }
                        }

                        if (!fFound) // and if not found
                        {
                            Console.WriteLine("Item {0} not found", chgid);
                        }

                        break;
                    }

                case 3: //delete items in the list if this option is selected
                    {
                        Console.Write("Please enter an item ID No:");
                        string strnewid = Console.ReadLine();
                        int newid = int.Parse(strnewid);
                        bool fDeleted = false;

                        // delete the item if you found it
                        // reset the count to show a new count for your list 
                        //(Note: your list is now reduced by one item)	

                        for (int x = 0; x < numberOfItems; x++)
                        {
                            if (itemprop[x].itemIDNo == newid)
                            {
                                fDeleted = true;
                                itemprop[x] = itemprop[x + 1];
                                numberOfItems--;
                               							
                            }
                        }

                        if (fDeleted) // hint the user that you deleted the requested item
                        {
                            Console.WriteLine();
                            Console.WriteLine("Item deleted");
                        }
                        else // if did not find it, hint the user that you did not find it in your list
                        {
                            Console.WriteLine();
                            Console.WriteLine("Item {0} not found", newid);
                        }

                        break;
                    }

                case 4:  //list all items in current database if this option is selected
                    {


                        if (numberOfItems == 0)
                        {
                            Console.WriteLine("No items");
                            Console.WriteLine();
                        }
                        Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                        Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");
                        Console.WriteLine();
                        for (int x = 0; x < numberOfItems; x++)
                        {

                            Console.Write("{0,4}.  ", x);
                            Console.Write("{0,5}  ",itemprop[x].itemIDNo);
                            Console.Write("{0,-20}  ", itemprop[x].sDescription);
                            Console.Write("{0,4}$ ",itemprop[x].dblPricePerItem);
                            Console.Write("{0,3} ", itemprop[x].iQuantityOnHand);
                            Console.Write("{0,4}$ ", itemprop[x].dblOurCostPerItem);
                            Console.Write("{0,5}$ ", itemprop[x].dblValueOfItem);
                            Console.WriteLine();

                        }

                        
                        break;
                    }


                case 5: //quit the program if this option is selected
                    {
                        Console.Write("Are you sure that you want to quit(y/n)?   ");
 
                       
                        string strresp = Console.ReadLine();

                        if (strresp =="y")
                        {
                            optx = 0;   //as long as it is not 5, the process is not breaking	
                            Environment.Exit(1);
                        }
                        break;
                    }

                default:
                    {
                        Console.Write("Invalid Option, try again");
                        break;
                    }
            }
        }
    }
}

