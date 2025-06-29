using System.Collections.Generic;
using System.IO;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_ExportWarningTaskNameToCSV : AutoTestNodeLib.TestState_Node
{
	public string CheckFolderPath = FPaths.Combine(FPaths.ProjectSavedDir, "GameTrace");

	public string CSVPath = FPaths.Combine(FPaths.Combine(FPaths.ProjectSavedDir, "GameTrace"), "WarningTaskName.csv");

	public TestState_ExportWarningTaskNameToCSV(UObject WorldContext)
	{
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		string[] fileSystemEntries = Directory.GetFileSystemEntries(CheckFolderPath);
		if (fileSystemEntries.Length == 0)
		{
			Description = "输出告警的TaskName";
			return AutoTestNodeLib.NodeState.Succeeded;
		}
		using (StreamWriter streamWriter = new StreamWriter(CSVPath))
		{
			string[] array = fileSystemEntries;
			for (int i = 0; i < array.Length; i++)
			{
				string fileName = Path.GetFileName(array[i]);
				if (fileName.Contains("TraceTickData"))
				{
					streamWriter.WriteLine(fileName);
				}
			}
		}
		Description = "输出告警的TaskName";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
