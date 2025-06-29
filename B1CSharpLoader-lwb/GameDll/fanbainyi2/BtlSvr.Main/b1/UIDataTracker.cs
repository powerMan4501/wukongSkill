using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;
using UnrealEngine.Runtime;

namespace b1;

public class UIDataTracker : DataTrackerBase
{
	public struct TraceStatData
	{
		public string StatName;

		public string DisplayName;

		public float AvgInterval;

		public float AvgIgnore;

		public TraceStatData(string InStatName, string InDisplayName, float InAvgInterval, float InAvgIgnore)
		{
			StatName = InStatName;
			DisplayName = InDisplayName;
			AvgInterval = InAvgInterval;
			AvgIgnore = InAvgIgnore;
		}
	}

	private struct CheckDataList
	{
		public List<CheckDataJson> List;
	}

	private struct CheckDataJson
	{
		public string Name;

		public float TotalValue;

		public float AvgValue;

		public float AvgPercent;

		public float MaxValue;

		public int FrameCount;

		public int AbnormalCount;

		public float AbnormalPercent;

		public CheckDataJson(string InName, float InTotalValue, float InAvgValue, float InMaxValue, int InFrameCount, int InAbnormalCount)
		{
			Name = InName;
			TotalValue = InTotalValue;
			AvgValue = InAvgValue;
			AvgPercent = ((TotalValue > 0f) ? (AvgValue / TotalValue) : 0f);
			MaxValue = InMaxValue;
			FrameCount = InFrameCount;
			AbnormalCount = InAbnormalCount;
			AbnormalPercent = ((FrameCount != 0) ? ((float)AbnormalCount / (float)FrameCount) : 0f);
		}
	}

	private class TraceCheckData
	{
		private readonly DataTrackerBase Tracker;

		private readonly TraceStatData StateData;

		private readonly EGSCapturedStatType StatType;

		private int AvgReqId;

		private int MaxReqId;

		private int FrameCount;

		private int AbnormalCount;

		private float AvgValue;

		private float MaxValue;

		private float TotalValue;

		public TraceCheckData(DataTrackerBase InTracker, TraceStatData InStateData, FGSCapturedStatResult InTotalResult, FGSCapturedStatResult InResult)
		{
			Tracker = InTracker;
			StateData = InStateData;
			StatType = InResult.StatType;
			ResetData(InTotalResult, InResult);
		}

		public CheckDataJson ToCheckDataJson()
		{
			return new CheckDataJson(StateData.DisplayName, TotalValue, AvgValue, MaxValue, FrameCount, AbnormalCount);
		}

		public void ShowData()
		{
			ShowData(ref AvgReqId, GetAvgName(), GetAvgValue());
			ShowData(ref MaxReqId, GetMaxName(), GetMaxValue());
		}

		public void ClearData()
		{
			FrameCount = 0;
			AbnormalCount = 0;
			AvgValue = 0f;
			MaxValue = 0f;
			TotalValue = 0f;
		}

		private void ShowData(ref int ReqId, string Name, string Value)
		{
			DebugDrawTable debugData = new DebugDrawTable(-1f, Name, Value);
			if (ReqId <= 0)
			{
				int num = Tracker.Request(debugData);
				ReqId = num;
			}
			else
			{
				Tracker.Reuse(ReqId, debugData);
			}
		}

		public void ResetData(FGSCapturedStatResult InTotalResult, FGSCapturedStatResult Result)
		{
			if (Result.Value > MaxValue)
			{
				MaxValue = Result.Value;
			}
			if (!(AvgValue > 0f) || !(Result.Value > AvgValue * StateData.AvgIgnore))
			{
				AvgValue = (AvgValue * (float)FrameCount + Result.Value) / (float)(FrameCount + 1);
				FrameCount++;
				if (Result.Value > StateData.AvgInterval)
				{
					AbnormalCount++;
				}
				TotalValue = InTotalResult.Value;
			}
		}

		private string GetAvgName()
		{
			return StateData.DisplayName;
		}

		private string GetAvgValue()
		{
			return GetValueStr(AvgValue);
		}

		private string GetMaxName()
		{
			return StateData.DisplayName + "峰值";
		}

		private string GetMaxValue()
		{
			return GetValueStr(MaxValue);
		}

		private string GetValueStr(float InValue)
		{
			return StatType switch
			{
				EGSCapturedStatType.CYCLE => $"{InValue:0.00} ms", 
				EGSCapturedStatType.NUM => InValue.ToString(), 
				EGSCapturedStatType.MEMORY => $"{InValue:0.00} MB", 
				_ => InValue.ToString(), 
			};
		}
	}

	private static List<TraceStatData> TraceStateDatas = new List<TraceStatData>();

	private static List<string> TraceStateNames = new List<string>();

	private static Dictionary<string, TraceStatData> TraceStateDisplayDic = new Dictionary<string, TraceStatData>();

	private Dictionary<string, TraceCheckData> TraceCheckDataDic = new Dictionary<string, TraceCheckData>();

	public static readonly string ProfilingDir = "/Temp/Profiling";

	public static readonly string DTTDir = "/Download/DTT";

	public static readonly string SaveDataDirPath = "/Temp/UIDataTracker";

	public static readonly string SaveDataPath = SaveDataDirPath + "/UIData.Json";

	public UIDataTracker(UObject InWorldContext)
		: base(InWorldContext)
	{
		List<TraceStatData> list = new List<TraceStatData>
		{
			new TraceStatData("STAT_UnitGame", "UnitGameTick", 1000f, 5f),
			new TraceStatData("STAT_SlateTickTime", "SlateTick", 1f, 5f)
		};
		if (DebugConfig.IsOpenStatGSCustom)
		{
			list.Add(new TraceStatData("GS_BGW_UIMgr.OnTick", "UIMgrTick", 1f, 5f));
		}
		SetTraceStatDataList(list);
		TraceCheckDataDic.Clear();
	}

	public static void SetTraceStatDataList(List<TraceStatData> TraceStatDataList)
	{
		TraceStateDatas.Clear();
		TraceStateDatas.AddRange(TraceStatDataList);
		TraceStateNames = TraceStateDatas.Select((TraceStatData t) => t.StatName).ToList();
		TraceStateDisplayDic = TraceStateDatas.ToDictionary((TraceStatData t) => t.StatName);
	}

	public override void Start()
	{
		base.Start();
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(WorldContext);
		bGW_UIEventCollection.Evt_UI_UITrackerClearData = (BGW_UIEventCollection.Del_UI_Void)Delegate.Combine(bGW_UIEventCollection.Evt_UI_UITrackerClearData, new BGW_UIEventCollection.Del_UI_Void(OnUITrackerClearData));
		BGW_UIEventCollection bGW_UIEventCollection2 = BGW_UIEventCollection.Get(WorldContext);
		bGW_UIEventCollection2.Evt_UI_UITrackerCheckReport = (BGW_UIEventCollection.Del_UI_Void)Delegate.Combine(bGW_UIEventCollection2.Evt_UI_UITrackerCheckReport, new BGW_UIEventCollection.Del_UI_Void(OnUITrackerCheckReport));
	}

	public override void Stop()
	{
		base.Stop();
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(WorldContext);
		bGW_UIEventCollection.Evt_UI_UITrackerClearData = (BGW_UIEventCollection.Del_UI_Void)Delegate.Remove(bGW_UIEventCollection.Evt_UI_UITrackerClearData, new BGW_UIEventCollection.Del_UI_Void(OnUITrackerClearData));
		BGW_UIEventCollection bGW_UIEventCollection2 = BGW_UIEventCollection.Get(WorldContext);
		bGW_UIEventCollection2.Evt_UI_UITrackerCheckReport = (BGW_UIEventCollection.Del_UI_Void)Delegate.Remove(bGW_UIEventCollection2.Evt_UI_UITrackerCheckReport, new BGW_UIEventCollection.Del_UI_Void(OnUITrackerCheckReport));
	}

	private void OnUITrackerClearData()
	{
		foreach (TraceCheckData value in TraceCheckDataDic.Values)
		{
			value.ClearData();
		}
	}

	private void OnUITrackerCheckReport()
	{
		List<CheckDataJson> list = new List<CheckDataJson>();
		foreach (TraceCheckData value in TraceCheckDataDic.Values)
		{
			list.Add(value.ToCheckDataJson());
		}
		CheckDataList obj = new CheckDataList
		{
			List = list
		};
		JsonWriter jsonWriter = new JsonWriter();
		JsonMapper.ToJson(obj, jsonWriter);
		if (!UGSFileHelper.DirectoryExists(SaveDataDirPath))
		{
			UGSFileHelper.CreateDirectory(SaveDataDirPath);
		}
		UGSFileHelper.WriteFile(SaveDataPath, Encoding.UTF8.GetBytes(jsonWriter.ToString()).ToList());
	}

	public override ETrackerType GetTrackerType()
	{
		return ETrackerType.UI;
	}

	public override void OnTick(float InDeltaTime)
	{
		base.OnTick(InDeltaTime);
		List<FGSCapturedStatResult> list = UGSE_ProfilerFuncLib.CaptureSpecificStatsInfo(TraceStateNames);
		if (list != null && list.Count > 1)
		{
			FGSCapturedStatResult inTotalResult = list[0];
			for (int i = 0; i < list.Count; i++)
			{
				FGSCapturedStatResult fGSCapturedStatResult = list[i];
				TraceStatData value2;
				if (TraceCheckDataDic.TryGetValue(fGSCapturedStatResult.StatName, out var value))
				{
					value.ResetData(inTotalResult, fGSCapturedStatResult);
				}
				else if (TraceStateDisplayDic.TryGetValue(fGSCapturedStatResult.StatName, out value2))
				{
					TraceCheckDataDic.Add(fGSCapturedStatResult.StatName, new TraceCheckData(this, value2, inTotalResult, fGSCapturedStatResult));
				}
			}
		}
		foreach (TraceCheckData value3 in TraceCheckDataDic.Values)
		{
			value3.ShowData();
		}
	}
}
