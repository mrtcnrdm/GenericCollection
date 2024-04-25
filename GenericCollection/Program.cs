GenericCollection<int> intCollection = new GenericCollection<int>();

for (int i = 0; i < 5; i++)
{
    intCollection.Add(i);
}

foreach (var item in intCollection)
{
    Console.WriteLine(item);
}

//intCollection.Remove(2);
intCollection.RemoveAt(intCollection.Count() - 1);

foreach (var item in intCollection)
{
    Console.WriteLine(item);
}


GenericCollection<string> stringCollection = new GenericCollection<string>();

stringCollection.Add("Mert");
stringCollection.Add("Can");
stringCollection.Add("Erdem");

foreach (var item in stringCollection)
{
    Console.WriteLine(item);
}

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);


GenericCollection<List<int>> listIntCollection = new GenericCollection<List<int>>();
listIntCollection.Add(list);

GenericCollection<IList<int>> iListIntCollection = new GenericCollection<IList<int>>();
iListIntCollection.Add(list);