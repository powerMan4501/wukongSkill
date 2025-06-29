using System.Collections.Generic;
using System.IO;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class MemReportHelper_RunObjRefCmdIterator
{
	private UObject WorldContext;

	private string LogFilePath;

	private MemReportHelper_Comparator Comparator;

	private bool IsIncrease = true;

	private int MaxDataNum;

	private int IterationIndex;

	private string RunCmd = string.Empty;

	public MemReportHelper_RunObjRefCmdIterator(UObject WorldContext, MemReportHelper_Comparator UseComparator, bool InIsIncrease)
	{
		this.WorldContext = WorldContext;
		LogFilePath = TestState_MemReportAnalysis.PathCombine(TestState_MemReportAnalysis.DEVLOG_SAVED_PATH, "Logs", "b1.log");
		InitComparator(UseComparator, InIsIncrease);
	}

	public string GetSectionType()
	{
		if (Comparator == null)
		{
			return "NULL";
		}
		return Comparator.SectionTypeString;
	}

	private void InitComparator(MemReportHelper_Comparator UseComparator, bool InIsIncrease)
	{
		Comparator = UseComparator;
		IsIncrease = InIsIncrease;
		MaxDataNum = UseComparator?.GetDiffDataNum(IsIncrease) ?? 0;
		ResetIterator();
	}

	public void ResetIterator()
	{
		IterationIndex = 0;
		RunCmd = string.Empty;
	}

	public MemReportHelper_Comparator GetCurrentComparator()
	{
		return Comparator;
	}

	public int GeIterationMaxDataNum()
	{
		return MaxDataNum;
	}

	public int IterationRunObjRefCmd(out string ThisCmd, bool NoRun = false)
	{
		ThisCmd = string.Empty;
		if (Comparator == null)
		{
			return -1;
		}
		if (IterationIndex >= MaxDataNum)
		{
			return -1;
		}
		RunCmd = GetObjRefCmd(Comparator.GetDiffDataByIndex(IterationIndex, IsIncrease));
		IterationIndex++;
		if (RunCmd == string.Empty)
		{
			return 1;
		}
		ThisCmd = RunCmd;
		if (!NoRun)
		{
			USystemLibrary.ExecuteConsoleCommand(WorldContext, RunCmd, null);
		}
		return 0;
	}

	public List<string> IterationGetResult(out bool IsSuccess)
	{
		List<string> list = new List<string>();
		if (Comparator == null || RunCmd == string.Empty)
		{
			IsSuccess = true;
			return list;
		}
		IsSuccess = true;
		if (File.Exists(LogFilePath))
		{
			List<string> list2 = TestState_MemReportAnalysis.ReadTextFileLines(LogFilePath);
			bool flag = false;
			IsSuccess = false;
			foreach (string item in list2)
			{
				if (item.Contains("RunStart " + RunCmd))
				{
					flag = true;
				}
				if (flag)
				{
					list.Add("\t" + item);
				}
				if (flag && item.Contains("RunEnd " + RunCmd))
				{
					IsSuccess = true;
					flag = false;
					break;
				}
			}
		}
		return list;
	}

	private string GetObjRefCmd(string DataLine)
	{
		if (string.IsNullOrWhiteSpace(DataLine))
		{
			return string.Empty;
		}
		return "obj refs name=" + DataLine;
	}
}
