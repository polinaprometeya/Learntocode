namespace FKTV;

public class PrintInstructions
{
    public PrintInstructions(List<string> files, int index)
    {
        ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
        DataFormatting formattingXML = new DataFormatting();
        try
        {
            var plukliste = formattingXML.DataFormattingXML(files, index); // Pass the list and the index
            if (plukliste != null && plukliste.Lines != null)
            {
                // Do something with plukliste
                consoleLog.LogNewLineDefault("Currently Chosen Pluklist");
                consoleLog.LogLineShift();
                consoleLog.LogNewLineDefault($"\n{0,-13}{1} Name: {plukliste.Name}");
                consoleLog.LogNewLineDefault($"{0,-13}{1} Courier: {plukliste.Forsendelse}");
                consoleLog.LogNewLineDefault($"{0,-13}{1} Adress: {plukliste.Adresse}");
                consoleLog.LogNewLineDefault($"\n{0,-7}{1,-9}{2,-20}{3}  Antal   Type   Produktnr    Navn");
                foreach (var item in plukliste.Lines)
                {
                    consoleLog.LogNewLineDefault($"{0,-7}{1,-9}{2,-20}{3} {item.Amount}  {item.Type}   {item.ProductID}   {item.Title}");
                }
            }
        }
        catch (Exception ex)
        {
            consoleLog.LogNewLineRed($"An error occurred: {ex.Message}");
        }

    }
}
