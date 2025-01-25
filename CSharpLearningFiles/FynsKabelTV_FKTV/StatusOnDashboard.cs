using System;
using System.Reflection;
namespace FKTV;

public class StatusOnDashboard
{
    ConsoleLoggerClass consoleLog = new ConsoleLoggerClass();
    public void StatusOnDashboardPermenent(List<string>files, int index)
	{
        //permenent info
        consoleLog.LogNewLineYellow("Welcome to FynsKabelTV_FKTV");
        consoleLog.LogNewLineRed($"\nPlukliste {index + 1} af {files.Count}");
        consoleLog.LogNewLineRed($"file: {files[index]}");
    }

    public void StatusOnDashboardConsidional(List<string> files, int index)
    {
        //consitional info 
        switch (_readKey)
        {
            case 'G':
                consoleLog.LogNewLineRed("Pluklister genindlæst");
                break;
            case 'F':
                break;
            case 'N':
                break;
            case 'A':
                consoleLog.LogNewLineRed($"Plukseddel {files[index]} afsluttet.");
                break;
        }

    }
}
