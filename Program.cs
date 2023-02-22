using System;

namespace costomname {
     class Program {            
          static void Main(string[] args) {
                    //Change();
                    //Change2();
                    Switchcase();
                    //Switchcase2();
          }

          static void Change(){
                    
                    double change = 0;
                    int thousand = 0;
                    int fivehundred = 0;
                    int hundred = 0;
                    int fifty = 0;
                    int twenty = 0;
                    int ten = 0;
                    int five = 0;
                    int one = 0;
                    int P50 = 0;
                    int P25 = 0;

                    Console.Write("Change = ");
                    change = double.Parse(Console.ReadLine());

                    while(change >= 1000){
                              change = change - 1000;
                              thousand++;
                    }

                    while(change >= 500){
                              change = change - 500;
                              fivehundred++;
                    }

                    while(change >= 100){
                              change = change - 100;
                              hundred++;
                    }

                    while(change >= 50){
                              change = change - 50;
                              fifty++;
                    }
                    while(change >= 20){
                              change = change - 20;
                              twenty++;
                    }
                    while(change >= 10){
                              change = change - 10;
                              ten++;
                    }
                    while(change >= 5){
                              change = change - 5;
                              five++;
                    }
                    while(change >= 1){
                              change = change - 1;
                              one++;
                    }
                    while(change >= 0.5){
                              change = change - 0.5;
                              P50++;
                    }
                    while(change >= 0.25){
                              change = change - 0.25;
                              P25++;
                    }

                    if(thousand>0){Console.WriteLine("1000: {0}", thousand);}
                    if(fivehundred>0){Console.WriteLine("500: {0}", fivehundred);}
                    if(hundred>0){Console.WriteLine("100: {0}", hundred);}
                    if(fifty>0){Console.WriteLine("50: {0}", fifty);}
                    if(twenty>0){Console.WriteLine("20: {0}", twenty);}
                    if(ten>0){Console.WriteLine("10: {0}", ten);}
                    if(five>0){Console.WriteLine("5: {0}", five);}
                    if(one>0){Console.WriteLine("1: {0}", one);}
                    if(P50>0){Console.WriteLine(".50: {0}", P50);}
                    if(P25>0){Console.WriteLine(".25: {0}", P25);}
          }
          
          static void Change2(){
                    Console.Write("Change = ");
                    double change = double.Parse(Console.ReadLine());

                    int thousand = (int)change/1000;
                    change = change - thousand * 1000;
                    int fivehundred = (int)change/500;
                    change = change - fivehundred * 500;
                    int hundred = (int)change/100;
                    change = change - hundred * 100;
                    int fifty = (int)change/50;
                    change = change - fifty * 50;
                    int twenty = (int)change/20;
                    change = change - twenty * 20;
                    int ten = (int)change/10;
                    change = change - ten * 10;
                    int five = (int)change/5;
                    change = change - five * 5;
                    int one = (int)change/1;
                    change = change - one;
                    int P50 = (int)(change/0.50);
                    change = change - P50*0.50;
                    int P25 = (int)(change/0.25);
                    

                    Console.WriteLine("1000: {0}", thousand);
                    Console.WriteLine("500: {0}", fivehundred);
                    Console.WriteLine("100: {0}", hundred);
                    Console.WriteLine("50: {0}", fifty);
                    Console.WriteLine("20: {0}", twenty);
                    Console.WriteLine("10: {0}", ten);
                    Console.WriteLine("5: {0}", five);
                    Console.WriteLine("1: {0}", one);
                    Console.WriteLine(".50: {0}", P50);
                    Console.WriteLine(".25: {0}", P25);
          }

          static void Switchcase(){
                    Console.WriteLine("Please select menu\n--------------------\n1. Login\n2. Register");
                    int input = int.Parse(Console.ReadLine());
                    switch(input){
                              case 1:
                              Console.Clear();
                              Console.WriteLine("Login");
                              break;
                              case > 1 and < 10:
                              Console.Clear();
                              Console.WriteLine("Register");
                              break;
                              default:
                              Console.Clear();
                              Console.WriteLine("Invalid input");
                              break;
                    }
          }
          static void Switchcase2(){
                    Console.Write("num1:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("num2:");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.Write("Operation:");
                    string Operation = Console.ReadLine();

                    switch (Operation){
                              case "+":
                                        Console.WriteLine("{0}", num1+num2);
                                        break;
                              case "-":
                                        Console.WriteLine("{0}", num1-num2);
                                        break;
                              default:
                                        Console.WriteLine("incorrect input");
                                        break;
                    }

          }
     }
}