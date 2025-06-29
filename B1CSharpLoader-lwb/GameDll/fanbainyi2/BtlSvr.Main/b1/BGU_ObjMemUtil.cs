using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_ObjMemUtil
{
	private static readonly string ObjDiffFile = "ObjDiff.txt";

	private static readonly string ObjStackFile = "ObjStack.csv";

	private static readonly string ObjMemDiffDir = "ObjectMemDiff";

	private static readonly string ReportExportDir = Path.Combine(FPaths.ProjectSavedDir ?? "", ObjMemDiffDir ?? "");

	private static readonly string MemreportsDir = FPaths.ProjectSavedDir + "/Profiling/MemReports";

	public static void ResolveMemreportObjReference(string InFileName1, string InFileName2)
	{
		if (Directory.Exists(ReportExportDir))
		{
			Directory.Delete(ReportExportDir, recursive: true);
		}
		Directory.CreateDirectory(ReportExportDir);
		if (!GetMemreportFilePathInLatestDirectory(InFileName1, out var OutFilePath))
		{
			BGW_LogUtil.LogError(InFileName1 + " not exist!");
			return;
		}
		if (!GetMemreportFilePathInLatestDirectory(InFileName2, out var OutFilePath2))
		{
			BGW_LogUtil.LogError(InFileName2 + " not exist!");
			return;
		}
		Dictionary<string, List<MemreportObj>> map = ExtractObjListFromMemreport(OutFilePath);
		Dictionary<string, List<MemreportObj>> map2 = ExtractObjListFromMemreport(OutFilePath2);
		RunCompareAndExport(map, map2);
	}

	private static void ProcessObjRefStack(string ObjType, List<string> InObjPathList)
	{
		string path = ReportExportDir + "/" + ObjType + "_MemRefStack.txt";
		List<string> list = new List<string>();
		foreach (string InObjPath in InObjPathList)
		{
			FSoftObjectPath fSoftObjectPath = default(FSoftObjectPath);
			fSoftObjectPath.SetPath(InObjPath);
			UObject obj = fSoftObjectPath.ResolveObject();
			if (!obj.IsNullOrDestroyed())
			{
				string item = UGSE_EngineFuncLib.FindAndPrintStaleReferencesToObject(obj);
				list.Add(item);
			}
		}
		File.WriteAllLines(path, list);
	}

	private static bool TryGetRefStack(string InObjPath, out string OutRefStack)
	{
		OutRefStack = string.Empty;
		FSoftObjectPath fSoftObjectPath = default(FSoftObjectPath);
		fSoftObjectPath.SetPath(InObjPath);
		UObject obj = fSoftObjectPath.ResolveObject();
		if (!obj.IsNullOrDestroyed())
		{
			OutRefStack = UGSE_EngineFuncLib.FindAndPrintStaleReferencesToObject(obj);
		}
		return OutRefStack != string.Empty;
	}

	private static void ExportObjectMemInfoByType(string Type, List<MemreportObj> InObjList)
	{
		IOrderedEnumerable<MemreportObj> orderedEnumerable = InObjList.OrderByDescending((MemreportObj Obj) => Obj.NumKB);
		string path = ReportExportDir + "/" + Type + ".csv";
		List<string> list = new List<string> { "Object,NumKB,MaxKB,ResExcKB,ResExcDedSysKB,ResExcDedVidKB,ResExcUnkKB,ReferenceStack" };
		foreach (MemreportObj item in orderedEnumerable)
		{
			TryGetRefStack(item.ObjectSoftPath, out var OutRefStack);
			list.Add($"{item.ObjectSoftPath}, {item.NumKB},{item.MaxKB},{item.ResExecKB},{item.ResExecDedSysKB},{item.ResExecDedVidKB},{item.ResExecUNKKB},\"{OutRefStack}\"");
		}
		File.WriteAllLines(path, list);
	}

	private static void RunCompareAndExport(Dictionary<string, List<MemreportObj>> Map1, Dictionary<string, List<MemreportObj>> Map2)
	{
		foreach (string key in Map2.Keys)
		{
			List<MemreportObj> list = new List<MemreportObj>();
			if (!Map1.ContainsKey(key))
			{
				list = Map2[key];
			}
			else
			{
				List<MemreportObj> second = Map1[key];
				list = Map2[key].Except(second).ToList();
			}
			if (list.Count > 0)
			{
				ExportObjectMemInfoByType(key, list);
			}
		}
	}

	private static bool GetMemreportFilePathInLatestDirectory(string InFileName, out string OutFilePath)
	{
		OutFilePath = "";
		if (!Directory.Exists(MemreportsDir))
		{
			return false;
		}
		string[] directories = Directory.GetDirectories(MemreportsDir);
		string text = null;
		DateTime dateTime = DateTime.MinValue;
		string[] array = directories;
		foreach (string text2 in array)
		{
			DateTime creationTime = Directory.GetCreationTime(text2);
			if (creationTime > dateTime)
			{
				dateTime = creationTime;
				text = text2;
			}
		}
		OutFilePath = text + "/" + InFileName + ".memreport";
		return File.Exists(OutFilePath);
	}

	private static Dictionary<string, List<MemreportObj>> ExtractObjListFromMemreport(string InMemReportFile)
	{
		string input = File.ReadAllText(InMemReportFile);
		string pattern = "\\s?(.+?[^,])\\s\\/Game\\/(.+?)\\n";
		MatchCollection matchCollection = Regex.Matches(input, pattern);
		Dictionary<string, List<MemreportObj>> dictionary = new Dictionary<string, List<MemreportObj>>();
		foreach (Match item2 in matchCollection)
		{
			string key = item2.Groups[1].Value.Replace("\n", "").Replace("\r", "").Replace(" ", "");
			string[] array = item2.Groups[2].Value.Split(' ');
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				if (!string.IsNullOrEmpty(array[i]))
				{
					list.Add(array[i]);
				}
			}
			if (list.Count != 7)
			{
				continue;
			}
			MemreportObj item = default(MemreportObj);
			item.ObjectSoftPath = "/Game/" + list[0];
			if ((1u & (float.TryParse(list[1], out item.NumKB) ? 1u : 0u) & (float.TryParse(list[2], out item.MaxKB) ? 1u : 0u) & (float.TryParse(list[3], out item.ResExecKB) ? 1u : 0u) & (float.TryParse(list[4], out item.ResExecDedSysKB) ? 1u : 0u) & (float.TryParse(list[5], out item.ResExecDedVidKB) ? 1u : 0u) & (float.TryParse(list[6], out item.ResExecUNKKB) ? 1u : 0u)) != 0)
			{
				if (!dictionary.ContainsKey(key))
				{
					dictionary.Add(key, new List<MemreportObj>());
				}
				dictionary[key].Add(item);
			}
		}
		return dictionary;
	}
}
