// SEE ALSO: https://en.wikipedia.org/wiki/Generator_(computer_programming)

Console.WriteLine("------------Get 2 times---------------");
Console.WriteLine(string.Join(", ", Get())); 
Console.WriteLine(string.Join(", ", Get()));

Console.WriteLine("------------Get one time---------------");
var e = Get();
Console.WriteLine(string.Join(", ", e));
Console.WriteLine(string.Join(", ", e));

Console.WriteLine("------------foreach over IEnumerable---------------");
var enumerable = Get();
foreach (var item in enumerable)
    Console.WriteLine(item);

Console.WriteLine("------------Count on IEnumerable---------------");
var e2 = Get();
Console.WriteLine(e2.Count());

Console.WriteLine("------------foreach over IEnumerable.ToList---------------");
var list = Get().ToList();
foreach (var item in list)
    Console.WriteLine(item);


Console.WriteLine("------------Some Linq over IEnumerable---------------");
var count = Get()
        .Where(x => { Console.WriteLine("Where " + x); return x < 10; })
        .Select(x => { Console.WriteLine("Select " + x); return x; })
        .Count();
Console.WriteLine(count);

Console.WriteLine("------------Some Linq over IEnumerable.ToList---------------");
var count2 = Get().ToList()
        .Where(x => { Console.WriteLine("Where " + x); return x < 10; }).ToList()
        .Select(x => { Console.WriteLine("Select " + x); return x; }).ToList()
        .Count();
Console.WriteLine(count2);


static IEnumerable<int> Get()
{
    Console.WriteLine("Get step 1");
    yield return 1;
    Console.WriteLine("Get step 2");
    yield return 2;
    Console.WriteLine("Get step 3");
    yield return 3;
    Console.WriteLine("Get step 4");
}
