using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using b1.BGW;
using LitJson;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_MemoryTest_ExportMemReport : AutoTestNodeLib.TestState_Node
{
	private enum InnerState
	{
		WaitForPreload,
		Memreport,
		End
	}

	private int TickCounter;

	private string MemReportName;

	private List<string> AllMemoryStateNames = new List<string>
	{
		"STAT_RenderTargetMemory2D", "STAT_RenderTargetMemory3D", "STAT_RenderTargetMemoryCube", "STAT_TextureMemory2D", "STAT_TextureMemory3D", "STAT_TextureMemoryCube", "STAT_UniformBufferMemory", "STAT_IndexBufferMemory", "STAT_VertexBufferMemory", "STAT_RTAccelerationStructureMemory",
		"STAT_StructuredBufferMemory", "STAT_PixelBufferMemory", "STAT_DLSSVideoMemory", "STAT_PeakUsedPhysical", "STAT_UsedPhysical", "STAT_D3D12UsedVideoMemory", "STAT_D3D12UsedSystemMemory", "STAT_D3D12AvailableVideoMemory", "STAT_D3D12DemotedVideoMemory", "STAT_D3D12TotalVideoMemory",
		"STAT_NavigationMemory", "STAT_WwiseMemoryMedia", "STAT_AsyncFileMemory", "STAT_SkeletalMeshIndexMemory", "STAT_SkeletalMeshVertexMemory", "STAT_StaticMeshTotalMemory2", "STAT_StreamingOverview01_StreamableRenderAssets", "STAT_StreamingOverview05_UnstreamableRenderAssets", "STAT_TEXTUREGROUP_Terrain_Weightmap", "STAT_TEXTUREGROUP_Terrain_Heightmap"
	};

	private InnerState CurrentState;

	private void TransferState(InnerState NextState)
	{
		CurrentState = NextState;
		TickCounter = 0;
	}

	public TestState_MemoryTest_ExportMemReport(UObject WorldContext, string MemReportName)
	{
		base.WorldContext = WorldContext;
		this.MemReportName = MemReportName;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		Description = CurrentState.ToString() + " " + TickCounter;
		switch (CurrentState)
		{
		case InnerState.WaitForPreload:
		{
			Description = "等待Preload完成中";
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(WorldContext);
			if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.PreloadCountLeft() < 10)
			{
				Description = "预加载已经完成，可以开始测试";
				TransferState(InnerState.Memreport);
			}
			break;
		}
		case InnerState.Memreport:
			if (TickCounter == 5)
			{
				Description = "GC两次";
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
				UObject.CollectGarbage();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
			}
			else if (TickCounter >= 10 && TickCounter <= 20)
			{
				if (TickCounter == 10)
				{
					Description = "导出" + MemReportName;
					USystemLibrary.ExecuteConsoleCommand(WorldContext, "memreport -full -name=" + MemReportName, null);
				}
				if (TickCounter % 2 != 0)
				{
					break;
				}
				try
				{
					List<FGSCapturedStatResult> value = UGSE_ProfilerFuncLib.CaptureSpecificStatsInfo(AllMemoryStateNames);
					Dictionary<string, object> dictionary = new Dictionary<string, object>();
					dictionary.Add(MemReportName + "_StatsInfo", value);
					string text = TestState_MemReportAnalysis.PathCombine(TestState_MemReportAnalysis.DEVLOG_SAVED_PATH, "Profiling", "MemReports");
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllText(TestState_MemReportAnalysis.PathCombine(text, MemReportName + "_OtherInfo.txt"), GetJsonStringFromDataInfo(dictionary));
				}
				catch (Exception arg)
				{
					BGW_LogUtil.LogError($"[TestState_MemoryTest_ExportMemReport] CaptureSpecificStatsInfo, Error:{arg}");
				}
			}
			else if (TickCounter > 150)
			{
				TransferState(InnerState.End);
			}
			break;
		case InnerState.End:
			return AutoTestNodeLib.NodeState.Succeeded;
		default:
			Description = "进入了异常测试状态，测试脚本有逻辑问题!";
			return AutoTestNodeLib.NodeState.Failed;
		}
		TickCounter++;
		return AutoTestNodeLib.NodeState.Running;
	}

	private string GetJsonStringFromDataInfo(Dictionary<string, object> TargetInfoDict)
	{
		try
		{
			JsonWriter jsonWriter = new JsonWriter();
			jsonWriter.PrettyPrint = true;
			JsonMapper.ToJson(TargetInfoDict, jsonWriter);
			string input = jsonWriter.TextWriter.ToString();
			return new Regex("(?i)\\\\[uU]([0-9a-f]{4})").Replace(input, (Match m) => ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString());
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"[TestState_MemoryTest_ExportMemReport] GetJsonStringFromDataInfo，Error:{arg}");
			return "";
		}
	}
}
