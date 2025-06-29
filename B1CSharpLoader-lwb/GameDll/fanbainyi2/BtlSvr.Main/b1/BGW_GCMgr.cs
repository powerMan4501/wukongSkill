using System;
using UnrealEngine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_GCMgr")]
public class BGW_GCMgr : GameInstanceSystemBaseUObj
{
	private struct IL2CPPData
	{
		public bool IsGCStarted;
	}

	private struct EditorOptData
	{
		public IConsoleVariable CvarEvaluateUniformExpression;

		public float Timer;
	}

	private bool PauseUE4GC;

	private bool PauseCSharpGC;

	private const int CSHARP_MEM_MAX_BYTES = 4194304;

	public static float GC_INTERVAL;

	public static float GC_FORCE_INTERVAL;

	private int GCStatID;

	private float TriggerGCTimer = GC_INTERVAL;

	private float AvgDeltaTime = 0.033f;

	private IL2CPPData IL2Cpp;

	private EditorOptData EditorOpt;

	public override bool bTickEnabled => true;

	public override void OnInit()
	{
		GCStatID = ProfilerFuncLib.CreateStatID("GCMgr_FastGC");
		EditorOpt.CvarEvaluateUniformExpression = IConsoleManager.Get().FindConsoleVariable("r.Material.EvaluateUniformExpression");
	}

	public void OnTickIL2CPP(float DeltaTime)
	{
		if (IL2Cpp.IsGCStarted)
		{
			if (Native_USharpClass.USharpIL2CPP_GCStep() == 0)
			{
				TriggerGCTimer = GC_INTERVAL;
				IL2Cpp.IsGCStarted = false;
			}
			return;
		}
		TriggerGCTimer -= DeltaTime;
		if (TriggerGCTimer <= 0f)
		{
			if (DeltaTime < AvgDeltaTime)
			{
				Native_USharpClass.USharpIL2CPP_GCStart();
				IL2Cpp.IsGCStarted = true;
			}
			else if (TriggerGCTimer < GC_INTERVAL - GC_FORCE_INTERVAL)
			{
				Native_USharpClass.USharpIL2CPP_GCStart();
				IL2Cpp.IsGCStarted = true;
			}
		}
	}

	public void OnTickWin64Biu(float DeltaTime)
	{
		if (!DebugConfig.ManualBuiGC)
		{
			return;
		}
		AvgDeltaTime = (DeltaTime + AvgDeltaTime * 9f) * 0.1f;
		TriggerGCTimer -= DeltaTime;
		if (TriggerGCTimer <= 0f)
		{
			if (DeltaTime < AvgDeltaTime)
			{
				TriggerFastGC();
			}
			else if (TriggerGCTimer < GC_INTERVAL - GC_FORCE_INTERVAL)
			{
				TriggerFastGC();
			}
		}
	}

	private void OnTickEditor(float DeltaTime)
	{
	}

	public override int GetTickGroupMask()
	{
		return 2048;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (PauseUE4GC)
		{
			UGSE_EngineFuncLib.DelayGC();
		}
		GS_GCHelper.Instance.Tick(DeltaTime);
		OnTickEditor(DeltaTime);
		if (SharedRuntimeState.GetInitializedRuntimes() == EDotNetRuntime.IL2CPP)
		{
			OnTickIL2CPP(DeltaTime);
		}
		else
		{
			OnTickWin64Biu(DeltaTime);
		}
	}

	private void TriggerFastGC()
	{
		TriggerGCTimer = GC_INTERVAL;
		ProfilerFuncLib.BeginSampleWithStatID(GCStatID);
		GC.Collect(0);
		ProfilerFuncLib.EndSample();
	}

	public void PauseAllGC()
	{
		if (!PauseCSharpGC)
		{
			PauseCSharpGC = true;
		}
		PauseUE4GC = true;
	}

	public void ResumeAllGC()
	{
		if (PauseCSharpGC)
		{
			PauseCSharpGC = false;
		}
		PauseUE4GC = false;
	}

	public void GCFull()
	{
		ResumeAllGC();
		GC.Collect();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
	}

	public static void ManualGC()
	{
		GC.Collect();
		UGSE_EngineFuncLib.EngineGC(bFullPurge: true);
	}

	static BGW_GCMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_GCMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_GCMgr));
		GC_INTERVAL = 10f;
		GC_FORCE_INTERVAL = 15f;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_GCMgr");
	}
}
