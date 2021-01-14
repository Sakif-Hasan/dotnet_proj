using System;
class algo
{
    public void fizzbuzz(){

        int[] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        int limit = array.Length;

        for(int index = 0; index < limit; index++){

            if(array[index]%3 == 0 && array[index]%5 == 0 ){
                Console.WriteLine("fizzBuzz");
            }
            else if(array[index]%5 == 0){
                Console.WriteLine("buzz");
            }
            else if(array[index]%3 == 0){
                Console.WriteLine("fizz");
            }
            else Console.WriteLine(array[index]);
        }

    }
}