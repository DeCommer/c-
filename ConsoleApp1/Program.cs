
// Console.Write("Enter your name: ");
// var name = Console.ReadLine();
// Console.WriteLine($"Hello, {name}!");

// int num1 = 26;
// int num2 = 2;

// int remainder = num1 % num2;

// Console.WriteLine(remainder);

// num1 = 99;
// remainder = num1 % num2;

// Console.WriteLine(remainder);


// Console.Write("Enter age to check validity: ");
// string? ageIn = Console.ReadLine();
// int age = Convert.ToInt32(ageIn);

// if (age >= 21) {
//     Console.WriteLine("You are old enough to fug.");
// } else {
//     Console.WriteLine("You are too young to fug!");
// }

//Fizz Buzz

int toNum = 15;

for(int i = 0; i <= toNum; i++) {
    if(toNum % 3 == 0 || toNum % 5 == 0) {
        System.Console.WriteLine("fizzbuzz");
    }else if(toNum % 3 == 0) {
        System.Console.WriteLine("fizz");
    }else if(toNum % 5 == 0) {
        System.Console.WriteLine("buzz");
    }else {
        System.Console.WriteLine(i);
    }
}

