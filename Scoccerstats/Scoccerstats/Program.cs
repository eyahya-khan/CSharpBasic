

string path = @"C:\Users\eyahy\Desktop\c#\Scoccerstats\Scoccerstats\data.txt";

//file read
//use "using" to skip reader.Close();
using (FileStream file = new FileStream(path, FileMode.Open,FileAccess.Read))
{
    using (StreamReader reader = new StreamReader(file))
    {
        //only read first line from text file
        //string line = reader.ReadLine();
        //Console.WriteLine(line);

        //reading all text line 
        //string line = "";
        //while ((line = reader.ReadLine()) != null)
        //{
        //    Console.WriteLine(line);
        //}

        //read each character
        //foreach (var item in reader.ReadLine())
        //{
        //    Console.WriteLine(item);
        //}

        //read first 4 line
        //string[] names = new string[4];
        //for (int i = 0; i < names.Length; i++)
        //{
        //    names[i] = reader.ReadLine();
        //    Console.WriteLine(names[i]);
        //}

        //read all line at a time
        //string line = reader.ReadToEnd();
        //Console.WriteLine(line);

        //Peek() methods return if there is chracter in file or not
        //if (reader.Peek() > 0)
        //{
        //    Console.WriteLine(true);
        //}else 
        //{
        //    Console.WriteLine(false); 
        //}

        //convert unicode to UTF-8
        //char lowerH = '\u0068';
        //byte[] unicodeBytes = System.Text.UnicodeEncoding.Unicode.GetBytes(new char[] {lowerH});
        //string unicodeString = System.Text.UnicodeEncoding.Unicode.GetString(unicodeBytes);
        //Console.WriteLine(unicodeString);

        //display degree sign
        //char degree = '\u00B0';
        //Console.WriteLine("The temperature is 10" + degree + "C");


        //take the path of text file automaticaly
        //string path1 = Directory.GetCurrentDirectory();
        //DirectoryInfo dirInfo = new DirectoryInfo(path1);
        //var fileName = Path.Combine(dirInfo.FullName, "data.txt");
        //var file1 = new FileInfo(fileName);

        //using (var reader1 = new StreamReader(file1.FullName))
        //{
        //    Console.WriteLine(reader1.ReadToEnd());
        //}


        //take the path of CSV file automaticaly
        //string path1 = Directory.GetCurrentDirectory();
        //DirectoryInfo dirInfo = new DirectoryInfo(path1);
        //var fileName = Path.Combine(dirInfo.FullName, "SoccerGameResults.csv");
        //var fileContent = ReadFile(fileName);
        //structuring data
        //string[] fileLines = fileContent.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        //foreach (string line in fileLines)
        //{
        //    Console.WriteLine(fileContent);
        //}
        //static string ReadFile(string fileName)
        //{
        //    using (var reader = new StreamReader(fileName))
        //    {
        //        return reader.ReadToEnd();
        //    }
        //}

        //take the path of CSV file automaticaly
        //string path1 = Directory.GetCurrentDirectory();
        //DirectoryInfo dirInfo = new DirectoryInfo(path1);
        //var fileName = Path.Combine(dirInfo.FullName, "SoccerGameResults.csv");
        //var fileContent = ReadSoccerResults(fileName);
        //Console.WriteLine(fileContent);

        //static List<string[]> ReadSoccerResults(string fileName)
        //{
        //    var soccerResults = new List<string[]>();
        //    using(var reader = new StreamReader(fileName))
        //    {
        //        string line = "";
        //        reader.ReadLine();
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            var gameResult = new GameResult();
        //            string[] values = line.Split(',');
                   
        //            DateTime gameDate;
        //            if(DateTime.TryParse(values[0], out gameDate))
        //            {
        //                gameResult.GameDate = gameDate;
        //            }
        //            soccerResults.Add(values);
        //        }
        //    }
        //    return soccerResults;
        //}



    }
}
Console.ReadLine();
