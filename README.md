# cs_lesson3.4
do循环




Console.WriteLine("What balance would you like to have?");

do

{

targetBalance = Convert.ToDouble(Console.ReadLine());

if (targetBalance <= balance)

Console.WriteLine("You must enter an amount greater than " +

"your current balance!\nPlease enter another value.");

}


