//Eksempel på funktionel kodning hvor der kun bliver brugt et model lag
namespace FKTV;

//orginize things before moving to seperate functions.
//move xml reader into seperate class
//seperate the index stuff into seperate class
//add adress under name and post type
//make a folder called print
//load template -- chnage to the current case and save it as a copy in folder print.
class PluklisteProgram
{
    //applying "Don't repeat yourself" (DRY), also known as "duplication is evil".
    //This should be only a utility class. So... the logic has to be slit up.

    public static char _readKey = ' ';
    static void Main()
    {
        ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
        StatusOnDashboard statusOnTopOfPage = new StatusOnDashboard();

        //Arrange
        List<string> files;
        var index = -1;
        Directory.CreateDirectory("import");
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
                statusOnTopOfPage.StatusOnDashboardPermenent(files, index);
                statusOnTopOfPage.StatusOnDashboardConsidional(files, index);
                PrintInstructions printPlukliste = new PrintInstructions(files, index); 
            }

            //Print options
            //status

  

            Console.WriteLine("\n\nOptions:");

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

            //UI logic bit - index chnage when writing the choice. 
            switch (_readKey)
            {
                case 'G':
                    files = Directory.EnumerateFiles("export").ToList();
                    index = -1;
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
    public static void UserChoiceIndicatorUI(string inputString)
    {
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

