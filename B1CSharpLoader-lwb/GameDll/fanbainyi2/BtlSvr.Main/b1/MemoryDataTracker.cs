using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class MemoryDataTracker : DataTrackerBase
{
	private class TraceStateData
	{
		public int ReqId;

		public Func<string> Evt_GetMessage0;

		public Func<string> Evt_GetMessage1;

		public TraceStateData(Func<string> InGetMessage0, Func<string> InGetMessage1)
		{
			Evt_GetMessage0 = InGetMessage0;
			Evt_GetMessage1 = InGetMessage1;
			ReqId = -1;
		}
	}

	private List<TraceStateData> TraceStateDatas = new List<TraceStateData>();

	public MemoryDataTracker(UObject InWorldContext)
		: base(InWorldContext)
	{
		BGW_MemoryMgr MemoryMgr = BGW_MemoryMgr.Get(WorldContext);
		TraceStateDatas.Add(new TraceStateData(delegate
		{
			float availablePhysical = MemoryMgr.GetAvailablePhysical();
			float lowMemoryThreshold = MemoryMgr.GetLowMemoryThreshold();
			string text = "当前可用内存";
			return (availablePhysical > lowMemoryThreshold) ? text : ("<Memory_Red>" + text + "</>");
		}, delegate
		{
			float availablePhysical = MemoryMgr.GetAvailablePhysical();
			float lowMemoryThreshold = MemoryMgr.GetLowMemoryThreshold();
			string text = $"{availablePhysical}MB";
			return (availablePhysical > lowMemoryThreshold) ? text : ("<Memory_Red>" + text + "</>");
		}));
		TraceStateDatas.Add(new TraceStateData(() => "低内存阈值", () => $"{MemoryMgr.GetLowMemoryThreshold()}MB"));
		TraceStateDatas.Add(new TraceStateData(() => "退出低内存阈值", () => $"{MemoryMgr.GetExitLowMemoryThreshold()}MB".ToString()));
		TraceStateDatas.Add(new TraceStateData(() => "FrameCounter", () => $"{FGlobals.FrameCounter}".ToString()));
		TraceStateDatas.Add(new TraceStateData(() => "LastGCFrame", () => $"{MemoryMgr.GeLastGCFrame()}".ToString()));
		TraceStateDatas.Add(new TraceStateData(() => "最近10次GC平均间隔", () => $"{MemoryMgr.GetAvgGCIntervalFrame()}帧"));
		TraceStateDatas.Add(new TraceStateData(() => "最近10次GC平均间隔", () => $"{MemoryMgr.GetAvgGCIntervalTime()}ms"));
	}

	public override ETrackerType GetTrackerType()
	{
		return ETrackerType.Memory;
	}

	public override void OnTick(float InDeltaTime)
	{
		base.OnTick(InDeltaTime);
		foreach (TraceStateData traceStateData in TraceStateDatas)
		{
			string inMessage = traceStateData.Evt_GetMessage0();
			string inMessage2 = traceStateData.Evt_GetMessage1();
			DebugDrawTable debugData = new DebugDrawTable(-1f, inMessage, inMessage2);
			if (traceStateData.ReqId <= 0)
			{
				int reqId = Request(debugData);
				traceStateData.ReqId = reqId;
			}
			else
			{
				Reuse(traceStateData.ReqId, debugData);
			}
		}
	}
}
