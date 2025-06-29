using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig")]
public class BGWDataAsset_HiAltFXAnimalSpawnConfig : UBGWDataAsset
{
	private static bool bEnableDebug_IsValid;

	private static int bEnableDebug_Offset;

	private static FFieldAddress bEnableDebug_PropertyAddress;

	private static bool HighAltittude_Threshold_IsValid;

	private static int HighAltittude_Threshold_Offset;

	private static bool PresetCoolDown_AfterCloudMove_IsValid;

	private static int PresetCoolDown_AfterCloudMove_Offset;

	private static bool MaxCoutInWorld_IsValid;

	private static int MaxCoutInWorld_Offset;

	private static bool SpawnGap_IsValid;

	private static int SpawnGap_Offset;

	private static bool RandomTemplateList_IsValid;

	private static int RandomTemplateList_Offset;

	private static FFieldAddress RandomTemplateList_PropertyAddress;

	private TArrayReadWriteMarshaler<FHiAltFxAnimalSpawnTemplate> RandomTemplateList_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:bEnableDebug")]
	public bool bEnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:bEnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:bEnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("高度阈值")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:HighAltittude_Threshold")]
	public float HighAltittude_Threshold
	{
		get
		{
			CheckDestroyed();
			if (!HighAltittude_Threshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:HighAltittude_Threshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HighAltittude_Threshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HighAltittude_Threshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:HighAltittude_Threshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HighAltittude_Threshold_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("上云后进入预置CD")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:PresetCoolDown_AfterCloudMove")]
	public float PresetCoolDown_AfterCloudMove
	{
		get
		{
			CheckDestroyed();
			if (!PresetCoolDown_AfterCloudMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:PresetCoolDown_AfterCloudMove");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PresetCoolDown_AfterCloudMove_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresetCoolDown_AfterCloudMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:PresetCoolDown_AfterCloudMove");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PresetCoolDown_AfterCloudMove_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("同时存在的特效数量上限")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:MaxCoutInWorld")]
	public int MaxCoutInWorld
	{
		get
		{
			CheckDestroyed();
			if (!MaxCoutInWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:MaxCoutInWorld");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCoutInWorld_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCoutInWorld_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:MaxCoutInWorld");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCoutInWorld_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("不同种类特效生物的生成间隔")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:SpawnGap")]
	public FFloatRange SpawnGap
	{
		get
		{
			CheckDestroyed();
			if (!SpawnGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:SpawnGap");
				return default(FFloatRange);
			}
			return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(base.Address, SpawnGap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:SpawnGap");
			}
			else
			{
				BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(base.Address, SpawnGap_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:RandomTemplateList")]
	public TArrayReadWrite<FHiAltFxAnimalSpawnTemplate> RandomTemplateList
	{
		get
		{
			CheckDestroyed();
			if (!RandomTemplateList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig:RandomTemplateList");
				return null;
			}
			if (RandomTemplateList_Marshaler == null)
			{
				RandomTemplateList_Marshaler = new TArrayReadWriteMarshaler<FHiAltFxAnimalSpawnTemplate>(1, RandomTemplateList_PropertyAddress, CachedMarshalingDelegates<FHiAltFxAnimalSpawnTemplate, FHiAltFxAnimalSpawnTemplate>.FromNative, CachedMarshalingDelegates<FHiAltFxAnimalSpawnTemplate, FHiAltFxAnimalSpawnTemplate>.ToNative);
			}
			return RandomTemplateList_Marshaler.FromNative(IntPtr.Add(base.Address, RandomTemplateList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_HiAltFXAnimalSpawnConfig");
		NativeReflection.GetPropertyRef(ref bEnableDebug_PropertyAddress, unrealStruct, "bEnableDebug");
		bEnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebug");
		bEnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebug", Classes.FBoolProperty);
		HighAltittude_Threshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HighAltittude_Threshold");
		HighAltittude_Threshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HighAltittude_Threshold", Classes.FFloatProperty);
		PresetCoolDown_AfterCloudMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PresetCoolDown_AfterCloudMove");
		PresetCoolDown_AfterCloudMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PresetCoolDown_AfterCloudMove", Classes.FFloatProperty);
		MaxCoutInWorld_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxCoutInWorld");
		MaxCoutInWorld_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxCoutInWorld", Classes.FIntProperty);
		SpawnGap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnGap");
		SpawnGap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnGap", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref RandomTemplateList_PropertyAddress, unrealStruct, "RandomTemplateList");
		RandomTemplateList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RandomTemplateList");
		RandomTemplateList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RandomTemplateList", Classes.FArrayProperty);
	}

	static BGWDataAsset_HiAltFXAnimalSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_HiAltFXAnimalSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_HiAltFXAnimalSpawnConfig));
	}
}
