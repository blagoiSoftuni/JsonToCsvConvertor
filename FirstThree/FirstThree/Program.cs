﻿// See https://aka.ms/new-console-template for more information

string typeOfFood = Console.ReadLine();
int count = int.Parse(Console.ReadLine());
OneOfTheProduct(typeOfFood, count);
static void OneOfTheProduct(String typeOfFood, int count)
{
    double price = 0;

    if (typeOfFood == "water")
    {

        Console.WriteLine(1.00 * count);
    }

    else if (typeOfFood == "coke")
    {

        Console.WriteLine(1.40 * count);
    }

    else if (typeOfFood == "coffee")
    {

        Console.WriteLine(1.50 * count);
    }

    else if (typeOfFood == "snacks")
    {
        Console.WriteLine($"{2.00 * count}:F2");
        
    }
}