//3. По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek == 1) Console.WriteLine("понедельник");
if (dayOfWeek == 2) Console.WriteLine("вторник");
if (dayOfWeek == 3) Console.WriteLine("среда");
if (dayOfWeek == 4) Console.WriteLine("четверг");
if (dayOfWeek == 5) Console.WriteLine("пятница");
if (dayOfWeek == 6) Console.WriteLine("суббота");
if (dayOfWeek == 7) Console.WriteLine("воскресенье");