using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBarConfig")]
public class BGWDataAsset_UnitBarConfig : UBGWDataAsset
{
	private static bool LockDelayTime_IsValid;

	private static int LockDelayTime_Offset;

	private static bool LastDmgDelayTime_IsValid;

	private static int LastDmgDelayTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("锁定延迟消失时间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBarConfig:LockDelayTime")]
	public float LockDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!LockDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBarConfig:LockDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LockDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBarConfig:LockDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LockDelayTime_Offset), value);
			}
		}
	}

	[DisplayName("受击延迟消失时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitBarConfig:LastDmgDelayTime")]
	public float LastDmgDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!LastDmgDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBarConfig:LastDmgDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LastDmgDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastDmgDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitBarConfig:LastDmgDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LastDmgDelayTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_UnitBarConfig");
		LockDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockDelayTime");
		LockDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockDelayTime", Classes.FFloatProperty);
		LastDmgDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LastDmgDelayTime");
		LastDmgDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LastDmgDelayTime", Classes.FFloatProperty);
	}

	static BGWDataAsset_UnitBarConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_UnitBarConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_UnitBarConfig));
	}
}
