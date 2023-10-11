// Как просмотреть содержимое папок
/*
string path = @"D:\БрониДоки\Обучение 1С Разработчик\Введение в программирование C#\Examples\Examples002_HelloUser";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}   
*/

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }
// string path = @"D:\БрониДоки\Обучение 1С Разработчик\Введение в программирование C#\Seminar\HomeWork\HomeWork007";
// CatalogInfo(path);

//--------------------Игра в пирамидки-----------------------------

 