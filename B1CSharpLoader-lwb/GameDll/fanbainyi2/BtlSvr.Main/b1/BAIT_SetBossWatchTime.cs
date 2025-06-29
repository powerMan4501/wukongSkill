using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTime")]
internal class BAIT_SetBossWatchTime : BAIT_Base
{
	private static bool WatchTime_IsValid;

	private static int WatchTime_Offset;

	private static bool bEnableDebugLog_IsValid;

	private static int bEnableDebugLog_Offset;

	private static FFieldAddress bEnableDebugLog_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTime:WatchTime")]
	public float WatchTime
	{
		get
		{
			CheckDestroyed();
			if (!WatchTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTime:WatchTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WatchTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WatchTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTime:WatchTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WatchTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTime:bEnableDebugLog")]
	public bool bEnableDebugLog
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTime:bEnableDebugLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebugLog_Offset), 0, bEnableDebugLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTime:bEnableDebugLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebugLog_Offset), 0, bEnableDebugLog_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor)?.Evt_SetWatchTime.Invoke(WatchTime);
		_ = bEnableDebugLog;
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SetBossWatchTime");
		WatchTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WatchTime");
		WatchTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WatchTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebugLog_PropertyAddress, unrealStruct, "bEnableDebugLog");
		bEnableDebugLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebugLog");
		bEnableDebugLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebugLog", Classes.FBoolProperty);
	}

	static BAIT_SetBossWatchTime()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SetBossWatchTime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SetBossWatchTime));
	}
}
