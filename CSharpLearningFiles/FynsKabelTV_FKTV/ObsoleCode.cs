using System;
using FKTV;

public class ObsoleCode
{
    //public ObsoleCode()
    //{
    //class PluklisteProgram
    //{
    //    //applying "Don't repeat yourself" (DRY), also known as "duplication is evil".

    //    public static int _index = -1;
    //    public static char _readKey = 'S';

    //    static void Main()
    //    {

    //        Console.WriteLine("Welcome to FynsKabelTV_FKTV");

    //        List<string> files;
    //        Directory.CreateDirectory("import");

    //        string filesPath = @"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\export\\";
    //        files = PluklisteProgram.loadData(filesPath);

    //        dashboard(files);
    //        _readKey = PluklisteProgram.userInput();

    //    }

    //    static void dashboard(List<string> files)
    //    {
    //        ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();

    //        if (_index == -1) _index = 0;
    //        Console.WriteLine($"Plukliste {_index + 1} af {files.Count}");
    //        Console.WriteLine($"\nfile: {files[_index]}");

    //        //ACT
    //        //read file
    //        FileStream file = File.OpenRead(files[_index]);
    //        System.Xml.Serialization.XmlSerializer xmlSerializer =
    //            new System.Xml.Serialization.XmlSerializer(typeof(Pluklist));
    //        var plukliste = (Pluklist?)xmlSerializer.Deserialize(file);


    //        //print plukliste
    //        if (plukliste != null && plukliste.Lines != null)
    //        {
    //            Console.WriteLine("\n{0, -13}{1}", "Name:", plukliste.Name);
    //            Console.WriteLine("{0, -13}{1}", "Forsendelse:", plukliste.Forsendelse);
    //            //TODO: Add adresse to screen print

    //            Console.WriteLine("\n{0,-7}{1,-9}{2,-20}{3}", "Antal", "Type", "Produktnr.", "Navn");
    //            foreach (var item in plukliste.Lines)
    //            {
    //                Console.WriteLine("{0,-7}{1,-9}{2,-20}{3}", item.Amount, item.Type, item.ProductID, item.Title);
    //            }
    //        }
    //        file.Close();

    //        //Print options -- Inut
    //        Console.WriteLine("\n\nOptions:");
    //        consoleLog.LogLineShift();

    //        consoleLog.LogSameLineGreen("Q");
    //        consoleLog.LogNewLineDefault("uit");

    //        consoleLog.LogSameLineGreen("A");
    //        consoleLog.LogNewLineDefault("fslut plukseddel");

    //        consoleLog.LogSameLineGreen("G");
    //        consoleLog.LogNewLineDefault("enindlæs pluksedler");

    //        switch (_readKey)
    //        {
    //            case 'Q':
    //                return;
    //            case 'G':
    //                files = Directory.EnumerateFiles("export").ToList();
    //                _index = -1;
    //                consoleLog.LogNewLineRed("Pluklister genindlæst");
    //                break;
    //            case 'F':
    //                if (_index > 0) _index--;
    //                consoleLog.LogSameLineGreen("F");
    //                consoleLog.LogNewLineDefault("orrige plukseddel");
    //                break;
    //            case 'N':
    //                if (_index < files.Count - 1) _index++;
    //                consoleLog.LogSameLineGreen("N");
    //                consoleLog.LogNewLineDefault("æste plukseddel");
    //                consoleLog.LogSameLineGreen("F");
    //                consoleLog.LogNewLineDefault("orrige plukseddel");
    //                break;
    //            case 'A':
    //                //Move files to import directory
    //                if (_index >= 0)
    //                {
    //                    var filewithoutPath = files[_index].Substring(files[_index].LastIndexOf('\\'));
    //                    File.Move(files[_index], string.Format(@"import\\{0}", filewithoutPath));
    //                    consoleLog.LogNewLineRed($"Plukseddel {files[_index]} afsluttet.");
    //                    files.Remove(files[_index]);
    //                }
    //                else
    //                {
    //                    consoleLog.LogNewLineYellow("Error. You cannot  move files import");
    //                }
    //                if (_index > 0)
    //                {
    //                    consoleLog.LogSameLineGreen("F");
    //                    consoleLog.LogNewLineDefault("orrige plukseddel");
    //                }
    //                if (_index == files.Count) _index--;
    //                break;
    //        }
    //        Console.Clear();
    //    }

    //    //public static void statusMessages(List<string> files)
    //    //{
    //    //    ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
    //    //}

    //    public static char userInput()
    //    {
    //        _readKey = Console.ReadKey().KeyChar;
    //        if (_readKey >= 'a') _readKey -= (char)('a' - 'A'); //HACK: To upper

    //        return _readKey;
    //    }

    //    public static List<string> loadData(string filesPath)
    //    {
    //        if (Directory.Exists(filesPath))
    //        {
    //            Console.WriteLine("Directory found");
    //            try
    //            {
    //                List<string> loadData = Directory.EnumerateFiles(filesPath).ToList();
    //                if (loadData.Count == 0)
    //                {
    //                    Console.WriteLine("Data not found");
    //                    return null;
    //                }
    //                return loadData;
    //            }

    //            catch (Exception ex)
    //            {
    //                Console.WriteLine("Error or something: " + ex.Message);
    //                Console.ReadLine();
    //            }
    //        }
    //        else
    //        {
    //            Console.WriteLine("Error, no file exist");
    //            Console.ReadLine();
    //        }
    //        return null;
    //    }

    //    public static void UserChoiceIndicatorUI(string inputString)
    //    {
    //        ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
    //        consoleLog.LogSameLineGreen(inputString);
    //    }

    //    public static string readUserInput()
    //    {
    //        string _userinput = Console.ReadLine();
    //        return _userinput;
    //    }


    //       //public static List<string> loadData(string filesPath)
    //       //{

    //var projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
    //Console.WriteLine("projectDirectory:");

    //       //string filesPath = @"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\export\\";
    //       //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
    //       //Console.WriteLine("projectDirectory:", projectDirectory);

    //       //    if (Directory.Exists(filesPath))
    //       //    {
    //       //        Console.WriteLine("File found");
    //       //        try
    //       //        {
    //       //            List<string> loadData = Directory.EnumerateFiles(filesPath).ToList();
    //       //            return loadData;
    //       //        }

    //       //        catch (Exception ex)
    //       //        {
    //       //            Console.WriteLine("Error or something: " + ex.Message);
    //       //            Console.ReadLine();
    //       //        }
    //       //    }
    //       //    else
    //       //    {
    //       //        Console.WriteLine("Error, no file exist");
    //       //        Console.ReadLine();
    //       //    }
    //       //    return null;
    //       //}

    //       // ------------------

    //       //string[] loadDataArray = PluklisteProgram.loadData(projectDirectory + "\\");

    //       //if (!Directory.Exists("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\export\\"))
    //       //{
    //       //    Console.WriteLine("Directory \"export\" not found");
    //       //    Console.ReadLine();
    //       //    return;
    //       //}
    //       //loadData = Directory.EnumerateFiles("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\export\\").ToList();

    //       //        < Project Sdk = "Microsoft.NET.Sdk" >

    //       //  < PropertyGroup >
    //       //    < OutputType > Exe </ OutputType >
    //       //    < TargetFramework > net7.0 </ TargetFramework >
    //       //    < ImplicitUsings > enable </ ImplicitUsings >
    //       //    < Nullable > enable </ Nullable >
    //       //  </ PropertyGroup >

    //       //</ Project >

    //       //    Console.WriteLine("Welcome to FynsKabelTV_FKTV");
    //       //    string filesPath = @"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\export\\";

    //       //    //Arrange
    //       //    char readKey = ' ';
    //       //    //List<string> loadData;
    //       //    List<string> loadData = PluklisteProgram.loadData(filesPath);
    //       //    var index = -1;
    //       //    var standardColor = Console.ForegroundColor;
    //       //    Directory.CreateDirectory("import");


    //       //    //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
    //       //    //Console.WriteLine("projectDirectory:", projectDirectory);
    //       //    //List<string> loadData = PluklisteProgram.loadData(filesPath);


    //       //    //ACT
    //       //    while (readKey != 'Q')
    //       //    {
    //       //        if (loadData.Count == 0)
    //       //        {
    //       //            Console.WriteLine("There are no files found.");

    //       //        }
    //       //        else
    //       //        {
    //       //            if (index == -1) index = 0;

    //       //            Console.WriteLine($"Plukliste {index + 1} af {loadData.Count}");
    //       //            Console.WriteLine($"\nfile: {loadData[index]}");

    //       //            //read file
    //       //            FileStream file = File.OpenRead(loadData[index]);
    //       //            System.Xml.Serialization.XmlSerializer xmlSerializer =
    //       //                new System.Xml.Serialization.XmlSerializer(typeof(Pluklist));
    //       //            var plukliste = (Pluklist?)xmlSerializer.Deserialize(file);

    //       //            //print plukliste
    //       //            if (plukliste != null && plukliste.Lines != null)
    //       //            {
    //       //                Console.WriteLine("\n{0, -13}{1}", "Name:", plukliste.Name);
    //       //                Console.WriteLine("{0, -13}{1}", "Forsendelse:", plukliste.Forsendelse);
    //       //                //TODO: Add adresse to screen print

    //       //                Console.WriteLine("\n{0,-7}{1,-9}{2,-20}{3}", "Antal", "Type", "Produktnr.", "Navn");
    //       //                foreach (var item in plukliste.Lines)
    //       //                {
    //       //                    Console.WriteLine("{0,-7}{1,-9}{2,-20}{3}", item.Amount, item.Type, item.ProductID, item.Title);
    //       //                }
    //       //            }
    //       //            file.Close();
    //       //        }

    //       //        //Print options
    //       //        Console.WriteLine("\n\nOptions:");
    //       //        Console.ForegroundColor = ConsoleColor.Green;
    //       //        Console.Write("Q");
    //       //        Console.ForegroundColor = standardColor;
    //       //        Console.WriteLine("uit");
    //       //        if (index >= 0)
    //       //        {
    //       //            Console.ForegroundColor = ConsoleColor.Green;
    //       //            Console.Write("A");
    //       //            Console.ForegroundColor = standardColor;
    //       //            Console.WriteLine("fslut plukseddel");
    //       //        }
    //       //        if (index > 0)
    //       //        {
    //       //            Console.ForegroundColor = ConsoleColor.Green;
    //       //            Console.Write("F");
    //       //            Console.ForegroundColor = standardColor;
    //       //            Console.WriteLine("orrige plukseddel");
    //       //        }
    //       //        if (index < loadData.Count - 1)
    //       //        {
    //       //            Console.ForegroundColor = ConsoleColor.Green;
    //       //            Console.Write("N");
    //       //            Console.ForegroundColor = standardColor;
    //       //            Console.WriteLine("æste plukseddel");
    //       //        }
    //       //        Console.ForegroundColor = ConsoleColor.Green;
    //       //        Console.Write("G");
    //       //        Console.ForegroundColor = standardColor;
    //       //        Console.WriteLine("enindlæs pluksedler");

    //       //        readKey = Console.ReadKey().KeyChar;
    //       //        if (readKey >= 'a') readKey -= (char)('a' - 'A'); //HACK: To upper
    //       //        Console.Clear();

    //       //        Console.ForegroundColor = ConsoleColor.Red; //status in red
    //       //        switch (readKey)
    //       //        {
    //       //            case 'G':
    //       //                loadData = Directory.EnumerateFiles("export").ToList();
    //       //                index = -1;
    //       //                Console.WriteLine("Pluklister genindlæst");
    //       //                break;
    //       //            case 'F':
    //       //                if (index > 0) index--;
    //       //                break;
    //       //            case 'N':
    //       //                if (index < loadData.Count - 1) index++;
    //       //                break;
    //       //            case 'A':
    //       //                //Move files to import directory
    //       //                var filewithoutPath = loadData[index].Substring(loadData[index].LastIndexOf('\\'));
    //       //                File.Move(loadData[index], string.Format(@"import\\{0}", filewithoutPath));
    //       //                Console.WriteLine($"Plukseddel {loadData[index]} afsluttet.");
    //       //                loadData.Remove(loadData[index]);
    //       //                if (index == loadData.Count) index--;
    //       //                break;
    //       //        }
    //       //        Console.ForegroundColor = standardColor; //reset color

    //       //    }
    //       //}

    //       //public static List<string> loadData(string filesPath)
    //       //{
    //       //    if (File.Exists(filesPath))
    //       //    {
    //       //        Console.WriteLine("File found");
    //       //        try
    //       //        {
    //       //            List<string> loadData = Directory.EnumerateFiles(filesPath).ToList();
    //       //            return loadData;
    //       //        }

    //       //        catch (Exception ex)
    //       //        {
    //       //            Console.WriteLine("Error or something: " + ex.Message);
    //       //            Console.ReadLine();
    //       //        }
    //       //    }
    //       //    else
    //       //    {
    //       //        Console.WriteLine("Error, no file exist");
    //       //        Console.ReadLine();
    //       //    }
    //       //    return null;
    //       //}


    //   }
}
