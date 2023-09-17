int count = 0;
int distance = 10000;
int friend1 = 1;
int friend2 = 2;
int dog = 5;
int friend = 2;
int time = 0;

while (distance > 10)
{
    friend = new Random().Next(1, 3); //1, 2.
    if (friend == 1)
    {
        time = distance/(friend1 + dog);
        friend = 2;
    }
    else
    {
        time = distance/(friend2 + dog);
        friend = 1;
    }
    distance = distance - (friend1 + friend2) * time;
    count++;
}
Console.Write("Вот сколько раз собака бегала между друзьями: ");
Console.WriteLine(count);