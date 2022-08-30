
/*      how I was trying to do it
Factorial(4);

void Factorial(int UserInput)
{
     for (int factorial = 1; factorial <= UserInput; factorial++)
     { 
        factorial *= UserInput;
        Console.WriteLine(factorial);

     }
    
}
*/

//How Greg did it
int target = 4;
int product = FactorialG(target);

for(int idx = 1; idx <= target; idx++)
{
    product *= idx;
}
Console.WriteLine($"{target}! is {product}");



int FactorialG(int nbr) 
{ 
    
   if(nbr == 1)
    {
        return 1;
    }
    return nbr * FactorialG(nbr - 1);

}                                                       //Need to make sure the function has a command to stop calling itself


