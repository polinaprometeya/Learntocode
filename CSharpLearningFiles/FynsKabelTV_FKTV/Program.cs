
using Aspose.Html;
using Aspose.Html.Saving.ResourceHandlers;

//Eksempel på funktionel kodning hvor der kun bliver brugt et model lag
namespace FKTV;

class PluklisteProgram
{
    //applying "Don't repeat yourself" (DRY), also known as "duplication is evil".
    //This should be only a utility class. So... 

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

        string inputPathOpgrade = @"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\templates\\PRINT - OPGRADE.html";
        //string inputPathOpsigelse = Path.Combine("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\templates\\PRINT - OPSIGELSE.html");
        //string inputPathWelcome = Path.Combine("C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FynsKabelTV_FKTV\\templates\\PRINT-WELCOME.html");


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
                statusOnTopOfPage.StatusOnDashboardConsidional(files, index, _readKey);
                PrintInstructions printPlukliste = new PrintInstructions(files, index);

                //outputPrintFiles(inputPathOpgrade, printPlukliste.plukliste.Name, printPlukliste.plukliste.Adress);
            }

            //Print options

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
                ////string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                ////Console.WriteLine("projectDirectory:", projectDirectory);
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

    public static void outputPrintFiles(string inputPath, string pluklisteName, string pluklisteAdress)
    {
        DataFormatting formattingHTML = new DataFormatting();
        // Prepare a full path to an output directory 
        string customOutDir = Path.Combine(Directory.GetCurrentDirectory(), "../print/");

        HTMLDocument? outputHTMLDocument = formattingHTML.DataFormattingHTML(inputPath, pluklisteName, pluklisteAdress);
        // Save HTML with resources

        outputHTMLDocument.Save(new FileSystemResourceHandler(customOutDir));
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

