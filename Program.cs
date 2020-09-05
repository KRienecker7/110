using System;
using System.Collections.Generic;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();
            p.VariablesTest();


            List<int> nums = new List<int>(){1,2,3,4,5,6,7,8,9,123,567,123,78,16,723,10,135,2,46,78};
            p.HomeWork(nums);


            void VariablesTest()
            {
                string firstName = "Sergio";
                int age = 34;
                decimal total = 99.99m; 
                float f= 13.231f;
                bool found = false;

                System.Console.Writeline("Math Operations");
                System.Console.Writeline(age - 1);
                System.Console.Writeline(age + 1);
                System.Console.Writeline(age * 32);
                System.Console.Writeline(age / 2);
                 System.Console.Writeline(age % 2);
            }

            //for loop
                for (int i = 0; i <10; i++)
                {
                    if (i !=3 && i !=7){
                        System.Console.WriteLine(i);
                    }
                }
                
            
                string[] names = new string[100];
                names[0] = "Kenny";
                names[1] = "Rosalina";
                names[2] = "Saber";
                names[3] = "Roxie";
                names[4] = "Gracie";

                List<string> lastNames = new List<string>();
                lastNames.Add("Something");
                lastNames.Add("Another");
                lastNames.Add("Smith");
                lastNames.Add("Inzunza");
                lastNames.Add("Stuff");

                System.Console.WriteLine(lastNames.Count);

                for(int i = 0; i < lastNames.Count; i++)
                {
                    System.Console.WriteLine(lastNames[i]);
                }

                foreach(var last in lastNames)
                {
                    System.Console.WriteLine(last);
                }

        }
    }
}
    



//
//                                        }
//                                            
            public void HomeWork(List<int> numbers) {
int nums = 1,2,3,4,5,6,7,8,9,123,567,123,78,16,723,10,135,2,46,78;
                                    if (nums/2 == 0)
                                    {
                                       System.Console.WriteLine("it's even");
                                        return "yes";
                                    }
                                     else
                                    {
                                   System.Console.WriteLine("it's NOT even");
                                         return "no";
                                        //}
//
  //                                              Variables();
    //                                            System.Console.WriteLine("This is the solution");
//
  //                                                          //foreach(var n in)
//
                                                            //for(int i=0; i < numbers.count)
///
   ///  //                                           int sum = 0;
    //                                            // 1 - print the sum of all numbers
     //                                           //sole here
       //                                         System.Console.WriteLine("Sum: " + sum); 
//
//
                                                // 2 - print Only even numbers ( % )
  //                                              2
    //                                            4
      //                                          6
        //                                        8
          //                                      78
            //                                    16
                                                // magic happens here to the set sum

                                                        
              //                              }

//
  //                                          void VariablesTest()
                                            {
                                                //declare variables
                                                //type name = val
    //                                            string firstName = "Kenny";
      //                                          int age = 33;
        //                                        decimal total = 99.9m; //for money
          //                                      float f = 13.231f;//anything else
            //                                    bool found = false;

              ///                                  System.Console.WriteLine("Math Operations");
                 ////                               System.Console.WriteLine(age - 1);
                     //                           System.Console.WriteLine(age + 1);
                      //    /                      System.Console.WriteLine(age * 32);
                          //                      System.Console.WriteLine(age / 2);
                       ///                         System.Console.WriteLine(age % 2);// modulus operator

                                                //For Loop
                           //                     for (int i=0; i<10; i++)
                             //                   {
                                                    // skip 3 and 7
                                                    //if i not equal to 3 and i not equal to 7 
                               //                     if(i !=3 && i != 7) 
                                 ///                   {
                               //                         System.Console.WriteLine(i);
                                    //                }
                                      //          }//end of for

                                                //arrays
                                        //        string[] names = new string[9999];
              //                                  names[0] = "Kenny";
           ///  //                                   names[1] = "Rosalina";
      //            //                              names[2] = "Saber";
   ///  /  /             /                            names[3] = "Roxie";
         // //           /                           names[4] = "Gracie";
//
  //                    /                          //list
    //                   /                         var lastNames = new List<string>(); //List <string> changed to var
      //                  /                        lastNames.Add("Something");
        //                 /     /                  lastNames.Add("Another");
          //                /   /                   lastNames.Add("Smith");
            //               ///                     lastNames.Add("Rienecker");
              //                                  lastNames.Add("Stuff");
//
      ///                                          //length
 /// / /// /   ///                                         System.Console.WriteLine(lastNames.Count);
   ///                                             
   // /                                            //iterate over a list
     ///                                           for(int i=0; i< lastNames.Count; i++) 
      ///                                          {
     //  /                                             System.Console.WriteLine(lastNames[i]);
  //                                              }
//
                                                // loop
    //                                            foreach(string last in lastNames)
      //                                          {
        //                                            System.Console.WriteLine(last);
          //                                      }
            //                                }//end of method

              //                          }
                //                    }
