
//Task1 


// List<int> num = new List<int>(){1,2,3,4,5,5,7,8};
// List<int> num2 = new List<int>(){1,2,3,4,5,6,15,9};
// var a = MergingList(num, num2);
// foreach (var item in a)
// {
//     System.Console.Write(item + " ");
// }
// List<int> MergingList (List<int> arr1, List <int> arr2)
// {
//     return arr1.Concat(arr2).Distinct().ToList();
// }





//Task2






// Task3

// List<int> number = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// Random random = new Random();

// for(int i = 0; i < number.Count; i++)
// {
//     var ran = random.Next(0, number.Count);
//     var a = number[i];
//     number[i] = number[ran];
//     number[ran] = a ;


//     System.Console.WriteLine(number[ran]);
// }


// Task4 xatohay

// ////List<string> n = new List<string>(){"hello", "hi", "sss", "fff"};
// ////List<string> n2 = new List<string>(){"fgh", "asd", "www", "hello", "salom", "hhh" };
// ////var a = (n, n2);
// ////foreach (var item in a)
// ////{
// ////    System.Console.Write(item + " ");
// ////}
// ////List<string> MergingList (List<string> ar1, List <string> ar2)
// ////{
// ////    return ar1.Concat(ar2).Distinct().ToList();
// ////}




//Task 4 rohi yakumi hal

// var names = new List<string>() { "Ali", "Ali", "Vali", "asad" , "asad" , "sami" };

// var dict = CountElements(names);

// foreach (var item in dict)
// {
//     System.Console.WriteLine($"Name: {item.Key} Count: {item.Value}");
// }

// Dictionary<string, int> CountElements(List<string> names)
// {
//     var dict = new Dictionary<string, int>();

//     List<string> uniqueNames = names.Distinct().ToList();

//     foreach (var item in uniqueNames)
//     {
//         var count = names.Count(name => name == item);
//         dict.Add(item, count);
//     }

//     return dict;
// }



// Task 4 rohi duyumi hal


// var names = new List<string>() { "Ali", "Ali", "Vali" };

// var dict = CountElements(names);

// foreach (var item in dict)
// {
//     System.Console.WriteLine($"Name: {item.Key} Count: {item.Value}");
// }


// Dictionary<string, int> CountElements(List<string> names)
// {
//     var dict = new Dictionary<string, int>();

//     foreach (var item in names)
//     {
//         if (!dict.ContainsKey(item))
//         {
//             var count = names.Count(name => name == item);
//             dict.Add(item, count);
//         }
//     }

//     return dict;
// }



// Task5

