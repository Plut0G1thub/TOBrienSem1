var p1 = new Person("Charlie",31);
var p2 = new Person("Bob",12);
var p3 = new Person("Carl",101);
var s1 = new Student("Alice", 20);
var s2 = new Student("David", 22);
var s3 = new Student("Eve", 19);


s1.AddGrade(95);
s2.AddGrade(87);
s3.AddGrade(78);

p3.Copy();

List<Person> people = new List<Person> { p1, p2, p3, s1, s2, s3 };

Person.GreetAll(people);

p1.Equals(p2);