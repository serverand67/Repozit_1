// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int count = 0;
int distance = 10000;
int firstFrand_speed = 1;
int secondFrand_speed = 2;
int dogspeed = 5;
int friend = 2;
int time = 0;
while ( distance > 10 )
{
   if (friend == 1)
   { 
    time= distance/(firstFrand_speed + dogspeed);
    friend = 2;
   }

else
{ 
   time= distance/(secondFrand_speed + dogspeed);
   friend = 1;
}
distance = distance - (firstFrand_speed + secondFrand_speed) * time;
count = count + 1;
}
Console.WriteLine( count );