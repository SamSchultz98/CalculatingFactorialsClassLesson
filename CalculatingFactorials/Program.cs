
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
int target = 6;
int product = FactorialG(target);





int FactorialG(int nbr) 
{ 
    
   if(nbr == 1)
    {
        return 1;
    }
    return nbr * FactorialG(nbr - 1);


}                                                       //Need to make sure the function has a command to stop calling itself

Console.WriteLine($"{target}! is {product}");
//Recursive Functions take up a lot of memory
//Everytime you call a funtion and it calls itself, the machine has to hold memory to store the instance that is being put on hold
/*
 * another way of doing it
 * int Factorialloop(int nbr) {
 * int product = 1;
 *  for(int idx =1; idx <= target; idx++) {
 *  prodcut *= idx;
 *  }
 *  return product;
 * }
 */