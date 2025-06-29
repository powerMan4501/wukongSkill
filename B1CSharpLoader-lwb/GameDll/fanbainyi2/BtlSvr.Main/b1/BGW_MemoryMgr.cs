using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_MemoryMgr")]
public class BGW_MemoryMgr : GameInstanceSystemBaseUObj
{
	private readonly int ArgGCFrameNum = 10;

	private bool IsInit;

	private float AvailablePhysical;

	private float LowMemoryThreshold;

	private float ExitLowMemoryThreshold;

	private bool IsLowState;

	private bool NeedOnceGC;

	private ulong LastGCFrame;

	private List<ulong> GCFrames = new List<ulong>();

	private List<long> GCTimes = new List<long>();

	public override bool bTickEnabled => true;

	public static BGW_MemoryMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_MemoryMgr>(WorldContext);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickAvailablePhysical();
		TickGC();
	}

	private void TickAvailablePhysical()
	{
		AvailablePhysical = UGSE_EngineFuncLib.GetAvailablePhysical();
		LowMemoryThreshold = GSGameplayCVar.CVar_LowMemoryThreshold.GetValueInGameThread();
		ExitLowMemoryThreshold = GSGameplayCVar.CVar_ExitLowMemoryThreshold.GetValueInGameThread();
		bool isLowState = IsLowState;
		if (AvailablePhysical < LowMemoryThreshold)
		{
			if (!IsLowState)
			{
				IsLowState = true;
			}
		}
		else if (IsLowState && AvailablePhysical >= ExitLowMemoryThreshold)
		{
			IsLowState = false;
		}
		if (isLowState != IsLowState && IsInit)
		{
			BGW_EventCollection.Get(this).Evt_TriggerLowMemory?.Invoke(IsLowState);
		}
		if (!IsInit)
		{
			IsInit = true;
		}
	}

	private void TickGC()
	{
		if (NeedOnceGC)
		{
			NeedOnceGC = false;
			BGW_GCMgr.ManualGC();
		}
		ulong lastGCFrame = FGlobals.LastGCFrame;
		if (LastGCFrame != lastGCFrame)
		{
			if (GCFrames.Count > ArgGCFrameNum)
			{
				GCFrames.RemoveAt(0);
			}
			if (GCTimes.Count > ArgGCFrameNum)
			{
				GCTimes.RemoveAt(0);
			}
			long item = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
			GCTimes.Add(item);
			GCFrames.Add(lastGCFrame);
			LastGCFrame = lastGCFrame;
		}
	}

	public void CheckNeedGC()
	{
		if (IsLowState)
		{
			NeedOnceGC = true;
		}
	}

	public float GetAvailablePhysical()
	{
		return AvailablePhysical;
	}

	public float GetLowMemoryThreshold()
	{
		return LowMemoryThreshold;
	}

	public float GetExitLowMemoryThreshold()
	{
		return ExitLowMemoryThreshold;
	}

	public bool GetIsLowState()
	{
		return IsLowState;
	}

	public ulong GetAvgGCIntervalFrame()
	{
		int num = GCFrames.Count();
		if (num < 1)
		{
			return 0uL;
		}
		return (GCFrames[num - 1] - GCFrames[0]) / (ulong)num;
	}

	public long GetAvgGCIntervalTime()
	{
		int num = GCTimes.Count();
		if (num < 1)
		{
			return 0L;
		}
		return (GCTimes[num - 1] - GCTimes[0]) / num;
	}

	public ulong GeLastGCFrame()
	{
		return LastGCFrame;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_MemoryMgr");
	}

	static BGW_MemoryMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_MemoryMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_MemoryMgr));
	}
}
