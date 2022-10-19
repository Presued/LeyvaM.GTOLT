//Manuel Leyva
//10-19-22
//Greater Than Or Less than 
//The user will be able to input numbers and the user will see if its grater than or less than
//Peer Review:

string iChoice = "";

int rNum1; 
int rNum2; 
int wResult;
bool cNum1; 
bool cNum2;

do{

do{
Console.WriteLine("Please Type A Whole Number");
cNum1 = Int32.TryParse(Console.ReadLine(), out rNum1);
if (cNum1 == false)
{
    Console.WriteLine(" That's Not A Number, Try Again Bro ");
}
}while(cNum1 == false);


do{
Console.WriteLine("Please Type A Second Whole Number");
//string n2 = Console.ReadLine();
cNum1 = Int32.TryParse(Console.ReadLine(), out rNum2);
if (cNum1 == false)
{
    Console.WriteLine(" That's Not A Number, Try Again Bro ");
}
}while(cNum1 == false);

if (rNum1 > rNum2)
{
    Console.WriteLine($"{rNum1} is greater than {rNum2}");
    
    Console.WriteLine($"{rNum2} is less than {rNum1}");
   
    Console.WriteLine($"{rNum1} is not equal to {rNum2}");
    
}

if(rNum1 < rNum2)
{
    Console.WriteLine($"{rNum1} is less than {rNum2}");
    
    Console.WriteLine($"{rNum2} is greater than {rNum1}");
   
    Console.WriteLine($"{rNum1} is not equal to {rNum2}");
    
}

if(rNum1 == rNum2)
{
    Console.WriteLine($"{rNum1} is not less than {rNum2}");
    
    Console.WriteLine($"{rNum2} is not greater than {rNum1}");  
    
    Console.WriteLine($"{rNum1} is equal to {rNum2}");
   
}

do
{
    Console.WriteLine("Do you want to Run the program again Yes or No?");
    iChoice = Console.ReadLine().ToUpper();
    if(iChoice != "YES" && iChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (iChoice !="YES" && iChoice != "NO");
}while(iChoice == "YES");
