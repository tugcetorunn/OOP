void Yaz()
{
	for (int i = 0; i < 100; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine("Yaz " + i);
    }
        
}

void Say()
{
    for (int i = 0; i < 100; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine(i);
    }
        
}

//Yaz();
//Say(); biri biter diğeri çalışır

ThreadStart start1 = new ThreadStart(Say);
ThreadStart start2 = new ThreadStart(Yaz);

Thread thread1 = new Thread(start1);
Thread thread2 = new Thread(start2);

thread1.Start();
thread2.Start();

//start1();
//start2();

Console.WriteLine();
