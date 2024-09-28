

string name = "Mitko";
int times = 10;
PrintTenTimesName(name,times);

void PrintTenTimesName(string name,int times)
{
	//bottom of recursion
	if (times<=0)
	{
		return;
	}
	PrintTenTimesName(name, times - 1);
    Console.WriteLine(times+" "+name);
}