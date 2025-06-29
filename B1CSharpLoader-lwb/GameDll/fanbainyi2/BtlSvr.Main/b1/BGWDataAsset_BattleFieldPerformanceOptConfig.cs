using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig")]
public class BGWDataAsset_BattleFieldPerformanceOptConfig : UBGWDataAsset
{
	private static bool Enable_IsValid;

	private static int Enable_Offset;

	private static FFieldAddress Enable_PropertyAddress;

	private static bool DrawDebug_IsValid;

	private static int DrawDebug_Offset;

	private static FFieldAddress DrawDebug_PropertyAddress;

	private static bool TickInterval_IsValid;

	private static int TickInterval_Offset;

	private static bool DistThreshold_ToPlayer_IsValid;

	private static int DistThreshold_ToPlayer_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("优化开关")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:Enable")]
	public bool Enable
	{
		get
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:Enable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:Enable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enable_Offset), 0, Enable_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("开启调试信息")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:DrawDebug")]
	public bool DrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:DrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:DrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("监听间隔")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:TickInterval")]
	public float TickInterval
	{
		get
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:TickInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TickInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:TickInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TickInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("距离阈值")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:DistThreshold_ToPlayer")]
	public float DistThreshold_ToPlayer
	{
		get
		{
			CheckDestroyed();
			if (!DistThreshold_ToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:DistThreshold_ToPlayer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistThreshold_ToPlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistThreshold_ToPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig:DistThreshold_ToPlayer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistThreshold_ToPlayer_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BattleFieldPerformanceOptConfig");
		NativeReflection.GetPropertyRef(ref Enable_PropertyAddress, unrealStruct, "Enable");
		Enable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Enable");
		Enable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Enable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DrawDebug_PropertyAddress, unrealStruct, "DrawDebug");
		DrawDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DrawDebug");
		DrawDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DrawDebug", Classes.FBoolProperty);
		TickInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TickInterval");
		TickInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TickInterval", Classes.FFloatProperty);
		DistThreshold_ToPlayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistThreshold_ToPlayer");
		DistThreshold_ToPlayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistThreshold_ToPlayer", Classes.FFloatProperty);
	}

	static BGWDataAsset_BattleFieldPerformanceOptConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BattleFieldPerformanceOptConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BattleFieldPerformanceOptConfig));
	}
}
