
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

bool modDiv1 = false;
bool modDiv2 = false;

for(int i = 1; i <= toNum; i++) {

    modDiv1 = i % 3 == 0;
    modDiv2 = i % 5 == 0;

    if(modDiv1 && modDiv2) {
        System.Console.WriteLine("Poo Pee");
    }else if(modDiv1) {
        System.Console.WriteLine("Poo");
    }else if(modDiv2) {
        System.Console.WriteLine("Pee");
    }else {
        System.Console.WriteLine(i);
    }
}

