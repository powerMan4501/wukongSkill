using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_GameConfig")]
public class BGWDataAsset_GameConfig : UBGWDataAsset
{
	private static bool RebirthDelayTimeWithAM_IsValid;

	private static int RebirthDelayTimeWithAM_Offset;

	private static bool RebirthDelayTimeWithoutAM_IsValid;

	private static int RebirthDelayTimeWithoutAM_Offset;

	private static bool RebirthDelayTimeSP_IsValid;

	private static int RebirthDelayTimeSP_Offset;

	private static FFieldAddress RebirthDelayTimeSP_PropertyAddress;

	private TMapReadWriteMarshaler<int, float> RebirthDelayTimeSP_Marshaler;

	private static bool PlotDelayTimeWithAM_IsValid;

	private static int PlotDelayTimeWithAM_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("主角死亡延后黑屏时间【带AM】")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeWithAM")]
	public float RebirthDelayTimeWithAM
	{
		get
		{
			CheckDestroyed();
			if (!RebirthDelayTimeWithAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeWithAM");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RebirthDelayTimeWithAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthDelayTimeWithAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeWithAM");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RebirthDelayTimeWithAM_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("主角死亡延后黑屏时间【不带AM】")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeWithoutAM")]
	public float RebirthDelayTimeWithoutAM
	{
		get
		{
			CheckDestroyed();
			if (!RebirthDelayTimeWithoutAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeWithoutAM");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RebirthDelayTimeWithoutAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthDelayTimeWithoutAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeWithoutAM");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RebirthDelayTimeWithoutAM_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("主角死亡延后黑屏时间【特殊】")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeSP")]
	public TMapReadWrite<int, float> RebirthDelayTimeSP
	{
		get
		{
			CheckDestroyed();
			if (!RebirthDelayTimeSP_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:RebirthDelayTimeSP");
				return null;
			}
			if (RebirthDelayTimeSP_Marshaler == null)
			{
				RebirthDelayTimeSP_Marshaler = new TMapReadWriteMarshaler<int, float>(1, RebirthDelayTimeSP_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return RebirthDelayTimeSP_Marshaler.FromNative(IntPtr.Add(base.Address, RebirthDelayTimeSP_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("主角剧情变身死亡延后黑屏时间【雪猴】")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GameConfig:PlotDelayTimeWithAM")]
	public float PlotDelayTimeWithAM
	{
		get
		{
			CheckDestroyed();
			if (!PlotDelayTimeWithAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:PlotDelayTimeWithAM");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PlotDelayTimeWithAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlotDelayTimeWithAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GameConfig:PlotDelayTimeWithAM");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PlotDelayTimeWithAM_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RebirthDelayTimeWithAM = 3f;
		RebirthDelayTimeWithoutAM = 3f;
		PlotDelayTimeWithAM = 4f;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_GameConfig");
		RebirthDelayTimeWithAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthDelayTimeWithAM");
		RebirthDelayTimeWithAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthDelayTimeWithAM", Classes.FFloatProperty);
		RebirthDelayTimeWithoutAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthDelayTimeWithoutAM");
		RebirthDelayTimeWithoutAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthDelayTimeWithoutAM", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref RebirthDelayTimeSP_PropertyAddress, unrealStruct, "RebirthDelayTimeSP");
		RebirthDelayTimeSP_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthDelayTimeSP");
		RebirthDelayTimeSP_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthDelayTimeSP", Classes.FMapProperty);
		PlotDelayTimeWithAM_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlotDelayTimeWithAM");
		PlotDelayTimeWithAM_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlotDelayTimeWithAM", Classes.FFloatProperty);
	}

	static BGWDataAsset_GameConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_GameConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_GameConfig));
	}
}
