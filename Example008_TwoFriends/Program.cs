//Console.WriteLine ("Ведите скорость первого друга ");
int FirstFriendSpeed = 5;
//Console.WriteLine ("Введите скорость второго друга ");
int SecondFriendSpeed = 3;
//Console.WriteLine ("Введите скорость Собаки ");
int DogSpeed = 15;
int friend = 2;
double distance = 100000;
double time = 0;
int count = 0;
while (distance > 5)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + DogSpeed);
        friend = 2;
    }
    if (friend == 2)
    {
        time = distance / (SecondFriendSpeed + DogSpeed);
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.Write("собака пробежит ");
Console.WriteLine(count);
