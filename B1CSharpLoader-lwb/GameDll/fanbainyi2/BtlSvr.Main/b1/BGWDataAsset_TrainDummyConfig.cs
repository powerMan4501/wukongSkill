using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig")]
public class BGWDataAsset_TrainDummyConfig : UBGWDataAsset
{
	private static bool TrainDummyHPType_IsValid;

	private static int TrainDummyHPType_Offset;

	private static FFieldAddress TrainDummyHPType_PropertyAddress;

	private static bool TrainDummyHPValue_IsValid;

	private static int TrainDummyHPValue_Offset;

	private static bool NeedCloseTrainDummyAI_IsValid;

	private static int NeedCloseTrainDummyAI_Offset;

	private static FFieldAddress NeedCloseTrainDummyAI_PropertyAddress;

	private static bool DPSCalTimeType_IsValid;

	private static int DPSCalTimeType_Offset;

	private static FFieldAddress DPSCalTimeType_PropertyAddress;

	private static bool DPSCalTime_IsValid;

	private static int DPSCalTime_Offset;

	private static bool SpecialDamageTypeConfigList_IsValid;

	private static int SpecialDamageTypeConfigList_Offset;

	private static FFieldAddress SpecialDamageTypeConfigList_PropertyAddress;

	private TArrayReadWriteMarshaler<FTrainDummySpecialDamageTypeConfig> SpecialDamageTypeConfigList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[DisplayName("目标血量")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:TrainDummyHPType")]
	public EGSTrainDummyHPType TrainDummyHPType
	{
		get
		{
			CheckDestroyed();
			if (!TrainDummyHPType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:TrainDummyHPType");
				return EGSTrainDummyHPType.Default;
			}
			return EnumMarshaler<EGSTrainDummyHPType>.FromNative(IntPtr.Add(base.Address, TrainDummyHPType_Offset), 0, TrainDummyHPType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TrainDummyHPType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:TrainDummyHPType");
			}
			else
			{
				EnumMarshaler<EGSTrainDummyHPType>.ToNative(IntPtr.Add(base.Address, TrainDummyHPType_Offset), 0, TrainDummyHPType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "TrainDummyHPType == EGSTrainDummyHPType::Value")]
	[DisplayName("指定血量值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:TrainDummyHPValue")]
	public int TrainDummyHPValue
	{
		get
		{
			CheckDestroyed();
			if (!TrainDummyHPValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:TrainDummyHPValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TrainDummyHPValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TrainDummyHPValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:TrainDummyHPValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TrainDummyHPValue_Offset), value);
			}
		}
	}

	[DisplayName("需要关闭木桩单位AI")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:NeedCloseTrainDummyAI")]
	public bool NeedCloseTrainDummyAI
	{
		get
		{
			CheckDestroyed();
			if (!NeedCloseTrainDummyAI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:NeedCloseTrainDummyAI");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedCloseTrainDummyAI_Offset), 0, NeedCloseTrainDummyAI_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedCloseTrainDummyAI_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:NeedCloseTrainDummyAI");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedCloseTrainDummyAI_Offset), 0, NeedCloseTrainDummyAI_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("DPS统计时间类型")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:DPSCalTimeType")]
	public EDPSCalTimeType DPSCalTimeType
	{
		get
		{
			CheckDestroyed();
			if (!DPSCalTimeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:DPSCalTimeType");
				return EDPSCalTimeType.Total;
			}
			return EnumMarshaler<EDPSCalTimeType>.FromNative(IntPtr.Add(base.Address, DPSCalTimeType_Offset), 0, DPSCalTimeType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DPSCalTimeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:DPSCalTimeType");
			}
			else
			{
				EnumMarshaler<EDPSCalTimeType>.ToNative(IntPtr.Add(base.Address, DPSCalTimeType_Offset), 0, DPSCalTimeType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("DPS统计时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:DPSCalTime")]
	public float DPSCalTime
	{
		get
		{
			CheckDestroyed();
			if (!DPSCalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:DPSCalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DPSCalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DPSCalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:DPSCalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DPSCalTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("特殊伤害统计类型")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:SpecialDamageTypeConfigList")]
	public TArrayReadWrite<FTrainDummySpecialDamageTypeConfig> SpecialDamageTypeConfigList
	{
		get
		{
			CheckDestroyed();
			if (!SpecialDamageTypeConfigList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig:SpecialDamageTypeConfigList");
				return null;
			}
			if (SpecialDamageTypeConfigList_Marshaler == null)
			{
				SpecialDamageTypeConfigList_Marshaler = new TArrayReadWriteMarshaler<FTrainDummySpecialDamageTypeConfig>(1, SpecialDamageTypeConfigList_PropertyAddress, CachedMarshalingDelegates<FTrainDummySpecialDamageTypeConfig, FTrainDummySpecialDamageTypeConfig>.FromNative, CachedMarshalingDelegates<FTrainDummySpecialDamageTypeConfig, FTrainDummySpecialDamageTypeConfig>.ToNative);
			}
			return SpecialDamageTypeConfigList_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialDamageTypeConfigList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TrainDummyConfig");
		NativeReflection.GetPropertyRef(ref TrainDummyHPType_PropertyAddress, unrealStruct, "TrainDummyHPType");
		TrainDummyHPType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TrainDummyHPType");
		TrainDummyHPType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TrainDummyHPType", Classes.FEnumProperty);
		TrainDummyHPValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TrainDummyHPValue");
		TrainDummyHPValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TrainDummyHPValue", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedCloseTrainDummyAI_PropertyAddress, unrealStruct, "NeedCloseTrainDummyAI");
		NeedCloseTrainDummyAI_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedCloseTrainDummyAI");
		NeedCloseTrainDummyAI_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedCloseTrainDummyAI", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DPSCalTimeType_PropertyAddress, unrealStruct, "DPSCalTimeType");
		DPSCalTimeType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DPSCalTimeType");
		DPSCalTimeType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DPSCalTimeType", Classes.FEnumProperty);
		DPSCalTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DPSCalTime");
		DPSCalTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DPSCalTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpecialDamageTypeConfigList_PropertyAddress, unrealStruct, "SpecialDamageTypeConfigList");
		SpecialDamageTypeConfigList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialDamageTypeConfigList");
		SpecialDamageTypeConfigList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialDamageTypeConfigList", Classes.FArrayProperty);
	}

	static BGWDataAsset_TrainDummyConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TrainDummyConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TrainDummyConfig));
	}
}
