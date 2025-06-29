using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class MemReportHelper_ExportDotMemory
{
	private readonly List<WrappedRefObjList> FoundObjectInfo = new List<WrappedRefObjList>();

	public void ApplyComparator(MemReportHelper_Comparator TargetComparator)
	{
		if (TargetComparator == null)
		{
			return;
		}
		FoundObjectInfo.Add(new WrappedRefObjList(TargetComparator.SectionTypeString));
		int diffDataNum = TargetComparator.GetDiffDataNum(InIsIncrease: true);
		for (int i = 0; i < diffDataNum; i++)
		{
			string diffDataByIndex = TargetComparator.GetDiffDataByIndex(i, InIsIncrease: true);
			if (!(diffDataByIndex == string.Empty) && !string.IsNullOrWhiteSpace(diffDataByIndex))
			{
				AddUObjectRef(TargetComparator.SectionTypeString, diffDataByIndex);
			}
		}
	}

	public void RunExportBat(string DotMemoryName)
	{
		BGU_LeakLogUtil.RunBat(Path.GetFullPath(FPaths.Combine(FPaths.ProjectDir, "Tools/dotMemory")), "get_ue_snapshot_biu_test.bat", IsCatchExitCode: true);
		string latestFileTimeInfo = GSEUtil.GetLatestFileTimeInfo(BGU_LeakLogUtil.SnapShotDir);
		if (!File.Exists(latestFileTimeInfo))
		{
			BGW_LogUtil.LogError("导出DotMemory失败，DotMemoryName:" + DotMemoryName);
			return;
		}
		string text = TestState_MemReportAnalysis.PathCombine(TestState_MemReportAnalysis.DEVLOG_SAVED_PATH, "Profiling", "MemReports", DotMemoryName);
		File.Copy(latestFileTimeInfo, text, File.Exists(text));
		File.Delete(latestFileTimeInfo);
	}

	private void AddUObjectRef(string ComparatorType, string ObjectPath)
	{
		if (string.IsNullOrWhiteSpace(ObjectPath))
		{
			return;
		}
		UObject uObject = UObject.FindObject<UObject>(UObject.AnyPackage, ObjectPath);
		if (uObject.IsNullOrDestroyed())
		{
			return;
		}
		foreach (WrappedRefObjList item in FoundObjectInfo)
		{
			if (item.ClassType == ComparatorType)
			{
				item.RefObjList.Add(new WrappedRefObj(ObjectPath, uObject));
				break;
			}
		}
	}

	public static string GetObjectPath(string DataLine)
	{
		if (string.IsNullOrWhiteSpace(DataLine))
		{
			return string.Empty;
		}
		string[] source = DataLine.Split();
		source = source.Where((string s) => !string.IsNullOrWhiteSpace(s)).ToArray();
		if (source.Length == 8 && source[1].Contains("/"))
		{
			return source[1].Trim();
		}
		return string.Empty;
	}

	public void AnalysisRefChainAfterRunCmd(string ComparatorType, List<string> RunCmdResult)
	{
		if (RunCmdResult == null || RunCmdResult.Count <= 2)
		{
			return;
		}
		string targetObjNameFromRunCmd = GetTargetObjNameFromRunCmd(RunCmdResult[0]);
		if (targetObjNameFromRunCmd == string.Empty)
		{
			return;
		}
		List<List<string>> list = SplitRunCmdResult(RunCmdResult);
		List<string> list2 = new List<string>();
		foreach (List<string> item in list)
		{
			string parentRefChainObjName = GetParentRefChainObjName(item);
			if (!(parentRefChainObjName == string.Empty) && !list2.Contains(parentRefChainObjName))
			{
				list2.Add(parentRefChainObjName);
			}
		}
		if (list2.Count <= 0)
		{
			return;
		}
		WrappedRefObj targetRefObj = GetTargetRefObj(ComparatorType, targetObjNameFromRunCmd);
		if (targetRefObj == null)
		{
			return;
		}
		foreach (string item2 in list2)
		{
			if (!(item2 == string.Empty) && !string.IsNullOrWhiteSpace(item2))
			{
				UObject uObject = UObject.FindObject<UObject>(UObject.AnyPackage, item2);
				if (!uObject.IsNullOrDestroyed())
				{
					targetRefObj.AddParentRefChainObj(item2, uObject);
				}
			}
		}
	}

	private string GetTargetObjNameFromRunCmd(string RunCmd)
	{
		if (RunCmd == string.Empty)
		{
			return string.Empty;
		}
		string text = "RunStart obj refs name=";
		int num = RunCmd.IndexOf(text);
		if (num != -1)
		{
			return RunCmd.Substring(num + text.Length);
		}
		return string.Empty;
	}

	private List<List<string>> SplitRunCmdResult(List<string> RunCmdResult)
	{
		List<List<string>> list = new List<List<string>>();
		int num = RunCmdResult.Count - 1;
		list.Add(new List<string>());
		for (int i = 1; i < num; i++)
		{
			string text = RunCmdResult[i];
			char value = ']';
			int num2 = text.IndexOf(value);
			if (num2 == -1)
			{
				continue;
			}
			int num3 = text.IndexOf(value, num2 + 1);
			if (num3 != -1)
			{
				string text2 = text.Substring(num3 + 1);
				if (string.IsNullOrWhiteSpace(text2))
				{
					list.Add(new List<string>());
				}
				else if (!text2.Contains("Cmd: obj refs"))
				{
					list[list.Count - 1].Add(text2);
				}
			}
		}
		return list;
	}

	private string GetParentRefChainObjName(List<string> ObjRefSection)
	{
		if (ObjRefSection == null || ObjRefSection.Count <= 0)
		{
			return string.Empty;
		}
		string empty = string.Empty;
		foreach (string item in ObjRefSection)
		{
			if (!item.Contains("/Engine/Transient"))
			{
				string value = "/Game/";
				int num = item.IndexOf(value);
				if (num != -1)
				{
					string text = item.Substring(num);
					int num2 = text.IndexOf("::");
					empty = ((num2 == -1) ? text : text.Substring(0, num2));
					return empty.Trim();
				}
			}
		}
		return empty;
	}

	private WrappedRefObj GetTargetRefObj(string ComparatorType, string TargetObjName)
	{
		foreach (WrappedRefObjList item in FoundObjectInfo)
		{
			if (!(item.ClassType == ComparatorType))
			{
				continue;
			}
			foreach (WrappedRefObj refObj in item.RefObjList)
			{
				if (refObj.ObjName == TargetObjName)
				{
					return refObj;
				}
			}
			break;
		}
		return null;
	}
}
