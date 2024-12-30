namespace CPPPPAdvancedProgramming3;

class Program
{
    static void Main(string[] args)
    {
       //Out Keyword Revision and The Usage Difference Between Ref and Out As Parameters.
       //This keyword is especially useful when a method needs to return more than one value
       /*int a;
       ExpMethod(out a);
       ExpMethod(out int b);
       char letter = '1';
       ExpMethod(ref letter);*/
       
       
       //Ref Return
       //When its about datatypes performing deep copy in assignments, variables always utilize from ref reference to indicate that shallow copy will be performed.
       /*int a = 0;
       ref int b = ref RefReturnMethod(ref a);
       b = 10; 
       Console.WriteLine(a);*/
       
       //Critic 1
       //The returned reference can bring the value it is assigned to if ref keyword is not used in the ref method call.
        /*int a = 0;
        int b = RefReturnMethod(ref a);
        Console.WriteLine(b);*/
        
        //Critic 2
        //The returned reference can't belong to a local variable declared within the method's body.
        //Which means that there must be a reference belonging to a global variable, given as an argument to the method to be able to return a reference.
        //Check RefReturnMethodError() declared below.
        
        
        //Ref Locals
        //Basically called to assigning a variable's reference to another declaration where ref keyword is used.
        /*int a = 50;
        ref int b = ref a;
        Console.WriteLine($"a = {a} = b = {b}");*/
    }

    static void ExpMethod(out int no1)
    {
        no1 = 10;
    }
    static void ExpMethod(ref char no2)
    {
        no2 =  '2'; 
    }

    
    static ref int RefReturnMethod(ref int no1)
    {
        no1 = 25;
        return ref no1;
    }
    
    /*static ref int RefReturnMethodError(ref int no1)
    {
        int b;
        return ref b;
    }*/
}