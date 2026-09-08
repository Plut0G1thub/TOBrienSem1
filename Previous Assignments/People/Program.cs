var p1 = new Person("Charlie",31);
var p2 = new Person("Bob",12);
var p3 = new Person("Carl",101);
var p4 = new Person("Lucy", 22);
var p5 = new Person("Oli", 41);

p1.Introduce();
p2.Introduce();
p3.Introduce();
p4.Introduce();
p5.Introduce();

Console.WriteLine();
p5.HappyBirthday();

Console.WriteLine();
var personList = new List<Person> {p1,p2,p3,p4,p5};

Person.GreetAll(personList);

Console.WriteLine();

p2.ToString();

Console.WriteLine(p5.isOlderThan(p5));