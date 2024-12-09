using Lesson6;

DateTime date = DateTime.Now.AddDays(-3); // thời gian hiện tại
Console.WriteLine(DateTime.Today.ToString());

// convert datetime to string
Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm")); // hh 12h, HH 24h

//Tuple
Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Nguyen Van A", "Ha Noi");
Console.WriteLine(person.Item1);
Console.WriteLine(person.Item2);
Console.WriteLine(person.Item3);
 
var person1 = Tuple.Create(1, "Nguyen Van A", "Ha Noi");

var tu = new TupleEx();
var result = tu.TupleExam();

Console.WriteLine(result.a);
Console.WriteLine(result.b);

//Generic
var dataStore = new DataStore<string>();
dataStore.Data = "Hello";
Console.WriteLine(dataStore.Data);

var dataStore1 = new DataStore<int>();
dataStore1.Data = 1;
Console.WriteLine(dataStore1.Data);

var dt2 = new DataStore2<int>();
dt2.AddOrUpdate(1, 1);
dt2.AddOrUpdate(1, 10);
dt2.AddOrUpdate(3, 30);
Console.WriteLine(dt2.GetData(2));

//===================================List==================================//
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Remove(1); // remove ptu xuat hien dau tien
list.RemoveAt(0); //theo index
list.Add(3);
list.Add(4);

//ve mat performance addrange se nhanh hon add thuong vi addrange se add 1 list vao list hien tai

