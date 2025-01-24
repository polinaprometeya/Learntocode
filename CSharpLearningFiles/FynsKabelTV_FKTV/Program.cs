//Eksempel på funktionel kodning hvor der kun bliver brugt et model lag
namespace FKTV;

class PluklisteProgram {
    //applying "Don't repeat yourself" (DRY), also known as "duplication is evil".

    public static char _readKey = ' ';

    static void Main()
    {
        Console.WriteLine("Welcome to FynsKabelTV_FKTV");

        //Arrange
       
        List<string> files;
        var index = -1;
        Directory.CreateDirectory("import");

        ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
        string filesPath = @"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\export\\";
        files = PluklisteProgram.loadData(filesPath);


        //ACT
        while (_readKey != 'Q')
        {
            if (files.Count == 0)
            {
                consoleLog.LogNewLineRed("No files found.");
            }
            else
            {
                if (index == -1) index = 0;

                //status
                consoleLog.LogNewLineRed($"Plukliste {index + 1} af {files.Count}");
                consoleLog.LogNewLineRed($"\nfile: {files[index]}");

                //read file
                FileStream file = File.OpenRead(files[index]);
                System.Xml.Serialization.XmlSerializer xmlSerializer =
                    new System.Xml.Serialization.XmlSerializer(typeof(Pluklist));
                var plukliste = (Pluklist?)xmlSerializer.Deserialize(file);

                //print plukliste
                if (plukliste != null && plukliste.Lines != null)
                {
                    Console.WriteLine("\n{0, -13}{1}", "Name:", plukliste.Name);
                    Console.WriteLine("{0, -13}{1}", "Forsendelse:", plukliste.Forsendelse);
                    //TODO: Add adresse to screen print

                    Console.WriteLine("\n{0,-7}{1,-9}{2,-20}{3}", "Antal", "Type", "Produktnr.", "Navn");
                    foreach (var item in plukliste.Lines)
                    {
                        Console.WriteLine("{0,-7}{1,-9}{2,-20}{3}", item.Amount, item.Type, item.ProductID, item.Title);
                    }
                }
                file.Close();
      
            }

            //Print options
            Console.WriteLine("\n\nOptions:");
            consoleLog.LogLineShift();

            consoleLog.LogSameLineGreen("Q");
            consoleLog.LogNewLineDefault("uit");
        

            if (index >= 0)
            {
                consoleLog.LogSameLineGreen("A");
                Console.WriteLine("fslut plukseddel");
            }
            if (index > 0)
            {
                consoleLog.LogSameLineGreen("F");
                Console.WriteLine("orrige plukseddel");
            }
            if (index < files.Count - 1)
            {
                consoleLog.LogSameLineGreen("N");
                Console.WriteLine("æste plukseddel");
            }

            consoleLog.LogSameLineGreen("G");
            Console.WriteLine("enindlæs pluksedler");

            _readKey = readUserInput();
            Console.Clear();

            switch (_readKey)
            {
                case 'G':
                    files = Directory.EnumerateFiles("export").ToList();
                    index = -1;
                    consoleLog.LogNewLineRed("Pluklister genindlæst");
                    break;
                case 'F':
                    if (index > 0) index--;
                    break;
                case 'N':
                    if (index < files.Count - 1) index++;
                    break;
                case 'A':
                    //Move files to import directory
                    var filewithoutPath = files[index].Substring(files[index].LastIndexOf('\\'));
                    File.Move(files[index], string.Format(@"import\\{0}", filewithoutPath));

                    consoleLog.LogNewLineRed($"Plukseddel {files[index]} afsluttet.");
                    files.Remove(files[index]);
                    if (index == files.Count) index--;
                    break;
            }

        }
    }
    public static List<string> loadData(string filesPath)
    {
        if (Directory.Exists(filesPath))
        {
            Console.WriteLine("File found");
            try
            {
                List<string> loadData = Directory.EnumerateFiles(filesPath).ToList();
                return loadData;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error or something: " + ex.Message);
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Error, no file exist");
            Console.ReadLine();
        }
        return null;
    }
    public static void UserChoiceIndicatorUI(string inputString) {
        ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
        consoleLog.LogSameLineGreen(inputString);
    }
    public static char readUserInput()
    {
        _readKey = Console.ReadKey().KeyChar;
        if (_readKey >= 'a') _readKey -= (char)('a' - 'A'); //HACK: To upper
        
        return _readKey;
    }

}

