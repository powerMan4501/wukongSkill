using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810627232uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotifyState_GSHeadLock", "b1", UnrealModuleType.Game)]
public class UAnimNotifyState_GSHeadLock : UAnimNotifyState_GSBase
{
	private static bool ReduceHeadLockAlphaScale_IsValid;

	private static int ReduceHeadLockAlphaScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSHeadLock:ReduceHeadLockAlphaScale")]
	public float ReduceHeadLockAlphaScale
	{
		get
		{
			CheckDestroyed();
			if (!ReduceHeadLockAlphaScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSHeadLock:ReduceHeadLockAlphaScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ReduceHeadLockAlphaScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReduceHeadLockAlphaScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSHeadLock:ReduceHeadLockAlphaScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ReduceHeadLockAlphaScale_Offset), value);
			}
		}
	}

	static UAnimNotifyState_GSHeadLock()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_GSHeadLock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_GSHeadLock));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.AnimNotifyState_GSHeadLock");
		ReduceHeadLockAlphaScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ReduceHeadLockAlphaScale");
		ReduceHeadLockAlphaScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ReduceHeadLockAlphaScale", Classes.FFloatProperty);
	}
}
