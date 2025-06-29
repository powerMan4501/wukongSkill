using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MemReportAnalysis : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		Init,
		RunObjRefCmd,
		GetResult,
		GenCompleteResult,
		ExportDotMemoryHasCache,
		Finish
	}

	public static readonly string DEVLOG_SAVED_PATH = Path.GetFullPath(Path.Combine(FPaths.ProjectSavedDir));

	private string PreReportName;

	private string PostReportName;

	private List<string> InitNeedExportClassList;

	private bool IsNeedNotifyFinish;

	private bool IsNeedExportMemReport;

	private int TickCounter;

	private List<string> PreReportContent;

	private List<string> PostReportContent;

	private List<MemReportHelper_RunObjRefCmdIterator> ObjRefCmdIteratorList;

	private MemReportHelper_RunObjRefCmdIterator CurrentIterator;

	private MemReportHelper_ExportDotMemory ExportDotMemoryHelper;

	private int WaitGetResultTime;

	private List<string> CompleteResultList;

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_MemReportAnalysis(UObject WorldContext, string PreReportName, string PostReportName, List<string> NeedExportClassList = null, bool IsNeedNotifyFinish = false, bool IsNeedExportMemReport = false)
	{
		base.WorldContext = WorldContext;
		this.PreReportName = PreReportName;
		this.PostReportName = PostReportName;
		InitNeedExportClassList = NeedExportClassList;
		this.IsNeedNotifyFinish = IsNeedNotifyFinish;
		this.IsNeedExportMemReport = IsNeedExportMemReport;
	}

	public static string PathCombine(string path1, string path2)
	{
		return Path.Combine(path1, path2);
	}

	public static string PathCombine(string path1, string path2, string path3)
	{
		return Path.Combine(path1, path2, path3);
	}

	public static string PathCombine(string path1, string path2, string path3, string path4)
	{
		return Path.Combine(path1, path2, path3, path4);
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = "分析Report中";
		switch (CurrentState)
		{
		case InnerState.Init:
		{
			if (IsNeedExportMemReport)
			{
				USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=2", null);
				BIS_AutoTestManagerV2.Get(WorldContext).NextTickInvoke = QuickestCaptureObj;
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "Init";
			PreReportContent = new List<string>();
			PostReportContent = new List<string>();
			ObjRefCmdIteratorList = new List<MemReportHelper_RunObjRefCmdIterator>();
			CurrentIterator = null;
			ExportDotMemoryHelper = new MemReportHelper_ExportDotMemory();
			WaitGetResultTime = 1;
			CompleteResultList = new List<string>();
			Description = "GetContent";
			string text = PathCombine(DEVLOG_SAVED_PATH, "Profiling", "MemReports");
			if (!Directory.Exists(text))
			{
				Description = "ProfilingPath:" + text + " 不存在";
				TransferState(InnerState.GenCompleteResult);
				return AutoTestNodeLib.NodeState.Running;
			}
			string text2 = FindNewestFile(Directory.GetFiles(text, PreReportName, SearchOption.AllDirectories));
			string text3 = FindNewestFile(Directory.GetFiles(text, PostReportName, SearchOption.AllDirectories));
			if (text2 == string.Empty || text3 == string.Empty || !File.Exists(text2) || !File.Exists(text3))
			{
				Description = "NewestReportFilePath 不存在";
				TransferState(InnerState.GenCompleteResult);
				return AutoTestNodeLib.NodeState.Running;
			}
			PreReportContent = ReadTextFileLines(text2);
			PostReportContent = ReadTextFileLines(text3);
			if (PreReportContent.Count <= 0 || PostReportContent.Count <= 0)
			{
				Description = "ReportContent.Count <= 0";
				TransferState(InnerState.GenCompleteResult);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = "Compare";
			List<string> list = new List<string>
			{
				"StaticMesh", "SkeletalMesh", "Texture2D", "MaterialInstanceConstant", "Material", "BodySetup", "NavCollision", "MaterialInstanceDynamic", "NiagaraComponent", "Class",
				"SkeletalMeshComponent", "AnimMontage", "AnimSequence", "SkeletalMeshSocket", "LevelStreamingCallbackHolder", "BAN_GSAkEvent", "GSMapAreaDetailData", "GSMapAreaBaseData"
			};
			if (InitNeedExportClassList != null)
			{
				list = InitNeedExportClassList;
			}
			foreach (string item2 in GetExtraExportClass())
			{
				if (!list.Contains(item2))
				{
					list.Add(item2);
				}
			}
			foreach (string item3 in list)
			{
				MemReportHelper_Comparator useComparator = new MemReportHelper_Comparator(PreReportContent, PostReportContent, item3, IsOrdered: true);
				MemReportHelper_RunObjRefCmdIterator item = new MemReportHelper_RunObjRefCmdIterator(WorldContext, useComparator, InIsIncrease: true);
				ObjRefCmdIteratorList.Add(item);
			}
			ObjRefCmdIteratorList = ObjRefCmdIteratorList.OrderByDescending((MemReportHelper_RunObjRefCmdIterator Iterator) => Iterator.GetCurrentComparator().GetDiffDataNum(InIsIncrease: true)).ToList();
			Description = "导出DotMemory";
			ExportDotMemoryHelper.RunExportBat("PrueDotMemory.dmw");
			foreach (MemReportHelper_RunObjRefCmdIterator objRefCmdIterator in ObjRefCmdIteratorList)
			{
				ExportDotMemoryHelper.ApplyComparator(objRefCmdIterator.GetCurrentComparator());
			}
			ExportDotMemoryHelper.RunExportBat("QuickCacheDotMemory.dmw");
			TransferState(InnerState.RunObjRefCmd);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.RunObjRefCmd:
		{
			Description = "RunObjRefCmd";
			if (CurrentIterator == null)
			{
				if (ObjRefCmdIteratorList.Count > 0)
				{
					Description = "获取到新的迭代器";
					CurrentIterator = ObjRefCmdIteratorList[0];
					CompleteResultList.Add("[" + CurrentIterator.GetSectionType() + "]");
					CompleteResultList.Add($"增加数量：{CurrentIterator.GeIterationMaxDataNum()}");
					CompleteResultList.Add("\n");
					TransferState(InnerState.RunObjRefCmd);
					return AutoTestNodeLib.NodeState.Running;
				}
				Description = "所有迭代器均执行完毕";
				TransferState(InnerState.GenCompleteResult);
				return AutoTestNodeLib.NodeState.Running;
			}
			string ThisCmd;
			switch (CurrentIterator.IterationRunObjRefCmd(out ThisCmd))
			{
			case 0:
				CompleteResultList.Add("运行：" + ThisCmd);
				Description = "迭代运行ObjRefCmd成功";
				WaitGetResultTime = 1;
				TransferState(InnerState.GetResult);
				return AutoTestNodeLib.NodeState.Running;
			case -1:
				CurrentIterator = null;
				if (ObjRefCmdIteratorList.Count > 0)
				{
					ObjRefCmdIteratorList.RemoveAt(0);
				}
				Description = "切换到下一个迭代器";
				TransferState(InnerState.RunObjRefCmd);
				return AutoTestNodeLib.NodeState.Running;
			default:
				Description = "跳过此次运行";
				TransferState(InnerState.RunObjRefCmd);
				return AutoTestNodeLib.NodeState.Running;
			}
		}
		case InnerState.GetResult:
			Description = "GetResult";
			if (TickCounter >= WaitGetResultTime)
			{
				Description = "尝试读取结果";
				bool IsSuccess;
				List<string> list2 = CurrentIterator.IterationGetResult(out IsSuccess);
				if (IsSuccess)
				{
					Description = "读取结果成功";
					CompleteResultList.AddRange(list2);
					CompleteResultList.Add("\n");
					CompleteResultList.Add("\n");
					CompleteResultList.Add("\n");
					ExportDotMemoryHelper.AnalysisRefChainAfterRunCmd(CurrentIterator.GetSectionType(), list2);
					TransferState(InnerState.RunObjRefCmd);
					return AutoTestNodeLib.NodeState.Running;
				}
				Description = "读取结果失败";
				WaitGetResultTime *= 2;
				if (WaitGetResultTime > 50)
				{
					Description = "无法读取到运行结果";
					CompleteResultList.Add("无法读取到运行结果");
					CompleteResultList.Add("\n");
					CompleteResultList.Add("\n");
					CompleteResultList.Add("\n");
					TransferState(InnerState.RunObjRefCmd);
					return AutoTestNodeLib.NodeState.Running;
				}
				Description = $"重新尝试读取结果，WaitGetResultTime：{WaitGetResultTime}";
				TransferState(InnerState.GetResult);
				return AutoTestNodeLib.NodeState.Running;
			}
			Description = $"WaitGetResult TickCounter:{TickCounter}";
			break;
		case InnerState.GenCompleteResult:
		{
			Description = "GenCompleteResult";
			string path = PathCombine(DEVLOG_SAVED_PATH, "Profiling", "MemReports");
			string path2 = PathCombine(DEVLOG_SAVED_PATH, "Profiling", "MemReports", "MemReportAnalysis.txt");
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists(path2))
			{
				File.Delete(path2);
			}
			using (StreamWriter streamWriter = File.AppendText(path2))
			{
				if (CompleteResultList.Count > 0)
				{
					foreach (string completeResult in CompleteResultList)
					{
						streamWriter.WriteLine(completeResult);
					}
				}
				else
				{
					streamWriter.WriteLine("分析过程发生异常，跳过了一些步骤！！！");
				}
			}
			TransferState(InnerState.ExportDotMemoryHasCache);
			return AutoTestNodeLib.NodeState.Running;
		}
		case InnerState.ExportDotMemoryHasCache:
			Description = "导出带缓存DotMemory";
			ExportDotMemoryHelper.RunExportBat("FullCacheDotMemory.dmw");
			TransferState(InnerState.Finish);
			return AutoTestNodeLib.NodeState.Running;
		case InnerState.Finish:
			if (TickCounter > 5)
			{
				Description = "完成";
				if (IsNeedNotifyFinish)
				{
					FMessage.OpenDialog("执行结束", "Memreport分析");
				}
				return AutoTestNodeLib.NodeState.Succeeded;
			}
			break;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}

	private static string FindNewestFile(string[] TargetFilePathList)
	{
		string result = string.Empty;
		DateTime dateTime = DateTime.MinValue;
		foreach (string text in TargetFilePathList)
		{
			DateTime lastWriteTime = File.GetLastWriteTime(text);
			if (lastWriteTime > dateTime)
			{
				dateTime = lastWriteTime;
				result = text;
			}
		}
		return result;
	}

	public static List<string> ReadTextFileLines(string TargetFilePath)
	{
		List<string> list = new List<string>();
		try
		{
			using FileStream stream = new FileStream(TargetFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			using StreamReader streamReader = new StreamReader(stream);
			string item;
			while ((item = streamReader.ReadLine()) != null)
			{
				list.Add(item);
			}
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("An error occurred while reading the file: " + ex.Message);
		}
		return list;
	}

	private void RunAllObjRefCmdOneFrame()
	{
		if (ObjRefCmdIteratorList == null || ObjRefCmdIteratorList.Count <= 0)
		{
			return;
		}
		foreach (MemReportHelper_RunObjRefCmdIterator objRefCmdIterator in ObjRefCmdIteratorList)
		{
			objRefCmdIterator.ResetIterator();
			string ThisCmd;
			while (objRefCmdIterator.IterationRunObjRefCmd(out ThisCmd) != -1)
			{
			}
		}
	}

	private void GetAllResultOneFrame()
	{
		if (ObjRefCmdIteratorList == null || ObjRefCmdIteratorList.Count <= 0)
		{
			return;
		}
		foreach (MemReportHelper_RunObjRefCmdIterator objRefCmdIterator in ObjRefCmdIteratorList)
		{
			objRefCmdIterator.ResetIterator();
			CompleteResultList.Add("[" + objRefCmdIterator.GetSectionType() + "]");
			CompleteResultList.Add($"增加数量：{objRefCmdIterator.GeIterationMaxDataNum()}");
			CompleteResultList.Add("\n");
			while (true)
			{
				string ThisCmd;
				int num = objRefCmdIterator.IterationRunObjRefCmd(out ThisCmd, NoRun: true);
				if (num == -1)
				{
					break;
				}
				if (num == 0)
				{
					CompleteResultList.Add("运行：" + ThisCmd);
					bool IsSuccess;
					List<string> collection = CurrentIterator.IterationGetResult(out IsSuccess);
					if (IsSuccess)
					{
						CompleteResultList.AddRange(collection);
						CompleteResultList.Add("\n");
						CompleteResultList.Add("\n");
						CompleteResultList.Add("\n");
					}
					else
					{
						CompleteResultList.Add("无法读取到运行结果");
						CompleteResultList.Add("\n");
						CompleteResultList.Add("\n");
						CompleteResultList.Add("\n");
					}
				}
			}
		}
	}

	private List<string> GetExtraExportClass()
	{
		List<string> list = new List<string>();
		string path = PathCombine(DEVLOG_SAVED_PATH, "MemoryAutoTest", "ExtraExportClass.txt");
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			if (array.Length != 0)
			{
				foreach (string item in new List<string>(array[0].Split(',')))
				{
					if (!string.IsNullOrWhiteSpace(item))
					{
						list.Add(item.Trim());
					}
				}
			}
		}
		return list;
	}

	private void QuickestCaptureObj()
	{
		PreReportContent = new List<string>();
		PostReportContent = new List<string>();
		ObjRefCmdIteratorList = new List<MemReportHelper_RunObjRefCmdIterator>();
		CurrentIterator = null;
		ExportDotMemoryHelper = new MemReportHelper_ExportDotMemory();
		WaitGetResultTime = 1;
		CompleteResultList = new List<string>();
		string path = PathCombine(DEVLOG_SAVED_PATH, "Profiling", "MemReports");
		if (!Directory.Exists(path))
		{
			TransferState(InnerState.GenCompleteResult);
			return;
		}
		string text = FindNewestFile(Directory.GetFiles(path, PreReportName, SearchOption.AllDirectories));
		string text2 = FindNewestFile(Directory.GetFiles(path, PostReportName, SearchOption.AllDirectories));
		if (text == string.Empty || text2 == string.Empty || !File.Exists(text) || !File.Exists(text2))
		{
			TransferState(InnerState.GenCompleteResult);
			return;
		}
		PreReportContent = ReadTextFileLines(text);
		PostReportContent = ReadTextFileLines(text2);
		if (PreReportContent.Count <= 0 || PostReportContent.Count <= 0)
		{
			TransferState(InnerState.GenCompleteResult);
			return;
		}
		List<string> list = new List<string>
		{
			"StaticMesh", "SkeletalMesh", "Texture2D", "MaterialInstanceConstant", "Material", "BodySetup", "NavCollision", "MaterialInstanceDynamic", "NiagaraComponent", "Class",
			"SkeletalMeshComponent", "AnimMontage", "AnimSequence", "SkeletalMeshSocket", "LevelStreamingCallbackHolder", "BAN_GSAkEvent", "GSMapAreaDetailData", "GSMapAreaBaseData"
		};
		if (InitNeedExportClassList != null)
		{
			list = InitNeedExportClassList;
		}
		foreach (string item2 in GetExtraExportClass())
		{
			if (!list.Contains(item2))
			{
				list.Add(item2);
			}
		}
		foreach (string item3 in list)
		{
			MemReportHelper_Comparator useComparator = new MemReportHelper_Comparator(PreReportContent, PostReportContent, item3, IsOrdered: true);
			MemReportHelper_RunObjRefCmdIterator item = new MemReportHelper_RunObjRefCmdIterator(WorldContext, useComparator, InIsIncrease: true);
			ObjRefCmdIteratorList.Add(item);
		}
		ObjRefCmdIteratorList = ObjRefCmdIteratorList.OrderByDescending((MemReportHelper_RunObjRefCmdIterator Iterator) => Iterator.GetCurrentComparator().GetDiffDataNum(InIsIncrease: true)).ToList();
		ExportDotMemoryHelper.RunExportBat("PrueDotMemory.dmw");
		foreach (MemReportHelper_RunObjRefCmdIterator objRefCmdIterator in ObjRefCmdIteratorList)
		{
			ExportDotMemoryHelper.ApplyComparator(objRefCmdIterator.GetCurrentComparator());
		}
		ExportDotMemoryHelper.RunExportBat("QuickCacheDotMemory.dmw");
		TransferState(InnerState.RunObjRefCmd);
		Stack<AutoTestNodeLib.TestState_Node> StateStack = new Stack<AutoTestNodeLib.TestState_Node>();
		OnTick(out var Description, ref StateStack, 0f);
		OnTick(out Description, ref StateStack, 0f);
	}

	public static void ExtraCalMemoryData(string ReportFileName)
	{
		ReportFileName += ".memreport";
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			long workingSet = currentProcess.WorkingSet64;
			long privateMemorySize = currentProcess.PrivateMemorySize64;
			string text = FormatMemoryUsage(workingSet);
			string text2 = FormatMemoryUsage(privateMemorySize);
			string path = PathCombine(DEVLOG_SAVED_PATH, "Profiling", "MemReports");
			if (!Directory.Exists(path))
			{
				BGW_LogUtil.LogError("MemReports Folder Not Exists!");
				return;
			}
			string path2 = FindNewestFile(Directory.GetFiles(path, ReportFileName, SearchOption.AllDirectories));
			string[] array = File.ReadAllLines(path2);
			int num = -1;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains("Platform Memory Stats for Windows"))
				{
					num = i + 5;
					break;
				}
			}
			if (num != -1)
			{
				string text3 = "WorkingSet64Usage:" + text + " PrivateMemorySize64Usage:" + text2;
				Array.Resize(ref array, array.Length + 1);
				Array.Copy(array, num, array, num + 1, array.Length - num - 1);
				array[num] = text3;
				File.WriteAllLines(path2, array);
			}
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"ExtraCalMemoryData Error:{arg}");
		}
		static string FormatMemoryUsage(long MemoryUsage)
		{
			return $"{(double)MemoryUsage / 1048576.0:F2} MB";
		}
	}
}
