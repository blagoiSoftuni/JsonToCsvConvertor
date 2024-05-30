﻿// See https://aka.ms/new-console-template for more information


            double[] prices = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double priceBall = prices[0];
            double priceBlock = prices[1];
            double priceMat = prices[2];
            int people = int.Parse(Console.ReadLine());

            int ballsBought = 0;
            double sumBalls = 0;
            int blocksBought = 0;
            double sumBlocks = 0;
            int matsBought = 0;
            double sumMats = 0;

            for (int i = 1; i <= people; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    ballsBought++;
                }
                else
                {
                    sumBalls += priceBall;
                    ballsBought++;
                }
            }
            for (int i = 1; i <= people*2; i++)
            {
                sumBlocks += priceBlock;
                blocksBought++;
            }
            for (int i = 1; i <= people; i++)
            {
                sumMats += priceMat;
                matsBought++;
            }

            double percentage = matsBought * 0.20;

            for (int i = 0; i < percentage; i++)
            {
                matsBought++;
                sumMats += priceMat;
            }

            Console.WriteLine($"{(sumMats+sumBlocks+sumBalls):f2}$ needed for equipment.");
        
    