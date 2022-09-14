using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{

    static void Main(string[] args)
    {
        Dictionary<string, string> inputDict = new Dictionary<string, string>();
        string[] inputs;
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] outputArr = new string[m, 4];

        for (int i = 0; i < n; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            string inputName = inputs[0];
            string inputSignal = inputs[1];
            inputDict.Add(inputName, inputSignal);
        }
        for (int i = 0; i < m; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            outputArr[i, 0] = inputs[0]; //string output name (letter)
            outputArr[i, 1] = inputs[1]; //string type (operator)
            outputArr[i, 2] = inputs[2]; //input letter 1
            outputArr[i, 3] = inputs[3]; //input letter 2
        }
        for (int i = 0; i < m; i++)
        {
            string outputCode = "";

            switch (outputArr[i, 1])
            {
                case "AND":
                    for (int j = 0; j < inputDict[outputArr[i,2]].Length; j++)
                    {
                        if (inputDict[outputArr[i,2]][j] == '-' && inputDict[outputArr[i,3]][j] == '-')
                        {
                            outputCode += "-";
                        } else {
                            outputCode += "_";
                        }
                    }
                    break;
                case "OR":
                    for (int j = 0; j < inputDict[outputArr[i,2]].Length; j++)
                    {
                        if (inputDict[outputArr[i,2]][j] == '-' || inputDict[outputArr[i,3]][j] == '-')
                        {
                            outputCode += "-";
                        } else {
                            outputCode += "_";
                        }
                    }
                    break;
                case "XOR":
                    for (int j = 0; j < inputDict[outputArr[i,2]].Length; j++)
                    {
                        if (inputDict[outputArr[i,2]][j] == '-' ^ inputDict[outputArr[i,3]][j] == '-')
                        {
                            outputCode += "-";
                        } else {
                            outputCode += "_";
                        }
                    }
                    break;
                case "NAND":
                    for (int j = 0; j < inputDict[outputArr[i,2]].Length; j++)
                    {
                        if (!(inputDict[outputArr[i,2]][j] == '-' && inputDict[outputArr[i,3]][j] == '-'))
                        {
                            outputCode += "-";
                        } else {
                            outputCode += "_";
                        }
                    }
                    break;
                case "NOR":
                    for (int j = 0; j < inputDict[outputArr[i,2]].Length; j++)
                    {
                        if (!(inputDict[outputArr[i,2]][j] == '-' || inputDict[outputArr[i,3]][j] == '-'))
                        {
                            outputCode += "-";
                        } else {
                            outputCode += "_";
                        }
                    }
                    break;
                case "NXOR":
                    for (int j = 0; j < inputDict[outputArr[i,2]].Length; j++)
                    {
                        if (inputDict[outputArr[i,2]][j] == '_' ^ inputDict[outputArr[i,3]][j] == '_')
                        {
                            outputCode += "_";
                        } else {
                            outputCode += "-";
                        }
                    }
                    break;
                
                default:
                    break;
            }
            
            // Write an answer using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(outputArr[i,0] + " " + outputCode);
        }
    }
}