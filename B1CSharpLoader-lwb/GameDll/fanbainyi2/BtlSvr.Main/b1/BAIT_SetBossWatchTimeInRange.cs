using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange")]
internal class BAIT_SetBossWatchTimeInRange : BAIT_Base
{
	private static bool WatchTimeMIN_IsValid;

	private static int WatchTimeMIN_Offset;

	private static bool WatchTimeMAX_IsValid;

	private static int WatchTimeMAX_Offset;

	private static bool bEnableDebugLog_IsValid;

	private static int bEnableDebugLog_Offset;

	private static FFieldAddress bEnableDebugLog_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:WatchTimeMIN")]
	public float WatchTimeMIN
	{
		get
		{
			CheckDestroyed();
			if (!WatchTimeMIN_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:WatchTimeMIN");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WatchTimeMIN_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WatchTimeMIN_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:WatchTimeMIN");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WatchTimeMIN_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:WatchTimeMAX")]
	public float WatchTimeMAX
	{
		get
		{
			CheckDestroyed();
			if (!WatchTimeMAX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:WatchTimeMAX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WatchTimeMAX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WatchTimeMAX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:WatchTimeMAX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WatchTimeMAX_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:bEnableDebugLog")]
	public bool bEnableDebugLog
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:bEnableDebugLog");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebugLog_Offset), 0, bEnableDebugLog_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebugLog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange:bEnableDebugLog");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebugLog_Offset), 0, bEnableDebugLog_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		float p = MathLib.RandomFloatInRange(WatchTimeMIN, WatchTimeMAX);
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(OwnerActor as ABGUCharacter);
		if (unPersistentReadOnlyData.GetIsMoveInValidByNav())
		{
			FinishExecute(bSuccess: true);
		}
		BUS_EventCollectionCS.Get(OwnerActor)?.Evt_SetWatchTime.Invoke(p);
		if (bEnableDebugLog)
		{
			unPersistentReadOnlyData.GetIsMoveInValidByNav();
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SetBossWatchTimeInRange");
		WatchTimeMIN_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WatchTimeMIN");
		WatchTimeMIN_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WatchTimeMIN", Classes.FFloatProperty);
		WatchTimeMAX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WatchTimeMAX");
		WatchTimeMAX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WatchTimeMAX", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebugLog_PropertyAddress, unrealStruct, "bEnableDebugLog");
		bEnableDebugLog_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebugLog");
		bEnableDebugLog_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebugLog", Classes.FBoolProperty);
	}

	static BAIT_SetBossWatchTimeInRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SetBossWatchTimeInRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SetBossWatchTimeInRange));
	}
}
