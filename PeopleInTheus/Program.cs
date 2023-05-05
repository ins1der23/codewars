int Number(List<int[]> peopleListInOut)
{
    int count = 0;
    foreach (var stop in peopleListInOut)
        count += stop[0] - stop[1];
    return count;

}

int NumberLinq(List<int[]> peopleListInOut)
  {
    return peopleListInOut.Sum(Item => Item[0] - Item[1]);
  }

var passengers = new List<int[]>()

 {
    new []{10,0},
    new []{3,5},
    new []{5,8},
    new []{9,5},
    new []{4,5}
};


Console.WriteLine(Number(passengers));