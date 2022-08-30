// See https://aka.ms/new-console-template for more information
var randNum = new Random().Next(0, 100);

while(true){
    Console.Write("Let's guess the number: ");
    int num;

    try{
        num = Convert.ToInt32(Console.ReadLine());
    }catch(Exception e){
        Console.WriteLine(e.Message);
        continue;
    }

    if(num == randNum){
        Console.WriteLine("Congratulation! The correct number is: " + randNum);
        break;
    }

    if (num < randNum){
        Console.WriteLine("The correct number is bigger!");
    }

    if (num > randNum){
        Console.WriteLine("The correct number is smaller!");
    }
}