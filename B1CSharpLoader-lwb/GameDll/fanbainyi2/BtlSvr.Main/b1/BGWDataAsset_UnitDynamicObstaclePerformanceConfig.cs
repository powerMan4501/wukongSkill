using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig")]
public class BGWDataAsset_UnitDynamicObstaclePerformanceConfig : UBGWDataAsset
{
	private static bool bDontPlayDBC_IsValid;

	private static int bDontPlayDBC_Offset;

	private static FFieldAddress bDontPlayDBC_PropertyAddress;

	private static bool OverrideDBC_IsValid;

	private static int OverrideDBC_Offset;

	private static bool PerformAMType_IsValid;

	private static int PerformAMType_Offset;

	private static FFieldAddress PerformAMType_PropertyAddress;

	private static bool bNeedRot_IsValid;

	private static int bNeedRot_Offset;

	private static FFieldAddress bNeedRot_PropertyAddress;

	private static bool F_DegLine_FBMode_IsValid;

	private static int F_DegLine_FBMode_Offset;

	private static bool F_DegLine_4DirMode_IsValid;

	private static int F_DegLine_4DirMode_Offset;

	private static bool B_DegLine_4DirMode_IsValid;

	private static int B_DegLine_4DirMode_Offset;

	private static bool AM_F_List_IsValid;

	private static int AM_F_List_Offset;

	private static FFieldAddress AM_F_List_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> AM_F_List_Marshaler;

	private static bool AM_B_List_IsValid;

	private static int AM_B_List_Offset;

	private static FFieldAddress AM_B_List_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> AM_B_List_Marshaler;

	private static bool AM_L_List_IsValid;

	private static int AM_L_List_Offset;

	private static FFieldAddress AM_L_List_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> AM_L_List_Marshaler;

	private static bool AM_R_List_IsValid;

	private static int AM_R_List_Offset;

	private static FFieldAddress AM_R_List_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> AM_R_List_Marshaler;

	[DisplayName("不播放DBC")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:bDontPlayDBC")]
	public bool bDontPlayDBC
	{
		get
		{
			CheckDestroyed();
			if (!bDontPlayDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:bDontPlayDBC");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDontPlayDBC_Offset), 0, bDontPlayDBC_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDontPlayDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:bDontPlayDBC");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDontPlayDBC_Offset), 0, bDontPlayDBC_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:OverrideDBC")]
	public BGWDataAsset_B1DBC OverrideDBC
	{
		get
		{
			CheckDestroyed();
			if (!OverrideDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:OverrideDBC");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, OverrideDBC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideDBC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:OverrideDBC");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, OverrideDBC_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:PerformAMType")]
	public EUnitDynamicObstaclePerformAMType PerformAMType
	{
		get
		{
			CheckDestroyed();
			if (!PerformAMType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:PerformAMType");
				return EUnitDynamicObstaclePerformAMType.OnlyFront;
			}
			return EnumMarshaler<EUnitDynamicObstaclePerformAMType>.FromNative(IntPtr.Add(base.Address, PerformAMType_Offset), 0, PerformAMType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PerformAMType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:PerformAMType");
			}
			else
			{
				EnumMarshaler<EUnitDynamicObstaclePerformAMType>.ToNative(IntPtr.Add(base.Address, PerformAMType_Offset), 0, PerformAMType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否触发瞬转")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:bNeedRot")]
	public bool bNeedRot
	{
		get
		{
			CheckDestroyed();
			if (!bNeedRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:bNeedRot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedRot_Offset), 0, bNeedRot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:bNeedRot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedRot_Offset), 0, bNeedRot_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "PerformAMType == UnitDynamicObstaclePerformAMType::FrontAndBehind")]
	[DisplayName("前向扇区分割角度_正反面")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:F_DegLine_FBMode")]
	public float F_DegLine_FBMode
	{
		get
		{
			CheckDestroyed();
			if (!F_DegLine_FBMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:F_DegLine_FBMode");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, F_DegLine_FBMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!F_DegLine_FBMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:F_DegLine_FBMode");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, F_DegLine_FBMode_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "PerformAMType == UnitDynamicObstaclePerformAMType::FourDir")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("前向扇区分割角度_四方向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:F_DegLine_4DirMode")]
	public float F_DegLine_4DirMode
	{
		get
		{
			CheckDestroyed();
			if (!F_DegLine_4DirMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:F_DegLine_4DirMode");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, F_DegLine_4DirMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!F_DegLine_4DirMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:F_DegLine_4DirMode");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, F_DegLine_4DirMode_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "PerformAMType == UnitDynamicObstaclePerformAMType::FourDir")]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("后向扇区分割角度_四方向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:B_DegLine_4DirMode")]
	public float B_DegLine_4DirMode
	{
		get
		{
			CheckDestroyed();
			if (!B_DegLine_4DirMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:B_DegLine_4DirMode");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, B_DegLine_4DirMode_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!B_DegLine_4DirMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:B_DegLine_4DirMode");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, B_DegLine_4DirMode_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("前向表演动画列表")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_F_List")]
	public TArrayReadWrite<UAnimMontage> AM_F_List
	{
		get
		{
			CheckDestroyed();
			if (!AM_F_List_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_F_List");
				return null;
			}
			if (AM_F_List_Marshaler == null)
			{
				AM_F_List_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, AM_F_List_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return AM_F_List_Marshaler.FromNative(IntPtr.Add(base.Address, AM_F_List_Offset));
		}
	}

	[DisplayName("后向表演动画列表")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_B_List")]
	public TArrayReadWrite<UAnimMontage> AM_B_List
	{
		get
		{
			CheckDestroyed();
			if (!AM_B_List_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_B_List");
				return null;
			}
			if (AM_B_List_Marshaler == null)
			{
				AM_B_List_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, AM_B_List_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return AM_B_List_Marshaler.FromNative(IntPtr.Add(base.Address, AM_B_List_Offset));
		}
	}

	[DisplayName("左向表演动画列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_L_List")]
	public TArrayReadWrite<UAnimMontage> AM_L_List
	{
		get
		{
			CheckDestroyed();
			if (!AM_L_List_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_L_List");
				return null;
			}
			if (AM_L_List_Marshaler == null)
			{
				AM_L_List_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, AM_L_List_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return AM_L_List_Marshaler.FromNative(IntPtr.Add(base.Address, AM_L_List_Offset));
		}
	}

	[EditAnywhere]
	[DisplayName("右向表演动画列表")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_R_List")]
	public TArrayReadWrite<UAnimMontage> AM_R_List
	{
		get
		{
			CheckDestroyed();
			if (!AM_R_List_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig:AM_R_List");
				return null;
			}
			if (AM_R_List_Marshaler == null)
			{
				AM_R_List_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, AM_R_List_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return AM_R_List_Marshaler.FromNative(IntPtr.Add(base.Address, AM_R_List_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_UnitDynamicObstaclePerformanceConfig");
		NativeReflection.GetPropertyRef(ref bDontPlayDBC_PropertyAddress, unrealStruct, "bDontPlayDBC");
		bDontPlayDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDontPlayDBC");
		bDontPlayDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDontPlayDBC", Classes.FBoolProperty);
		OverrideDBC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverrideDBC");
		OverrideDBC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverrideDBC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref PerformAMType_PropertyAddress, unrealStruct, "PerformAMType");
		PerformAMType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformAMType");
		PerformAMType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformAMType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bNeedRot_PropertyAddress, unrealStruct, "bNeedRot");
		bNeedRot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bNeedRot");
		bNeedRot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bNeedRot", Classes.FBoolProperty);
		F_DegLine_FBMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "F_DegLine_FBMode");
		F_DegLine_FBMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "F_DegLine_FBMode", Classes.FFloatProperty);
		F_DegLine_4DirMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "F_DegLine_4DirMode");
		F_DegLine_4DirMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "F_DegLine_4DirMode", Classes.FFloatProperty);
		B_DegLine_4DirMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "B_DegLine_4DirMode");
		B_DegLine_4DirMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "B_DegLine_4DirMode", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AM_F_List_PropertyAddress, unrealStruct, "AM_F_List");
		AM_F_List_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AM_F_List");
		AM_F_List_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AM_F_List", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AM_B_List_PropertyAddress, unrealStruct, "AM_B_List");
		AM_B_List_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AM_B_List");
		AM_B_List_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AM_B_List", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AM_L_List_PropertyAddress, unrealStruct, "AM_L_List");
		AM_L_List_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AM_L_List");
		AM_L_List_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AM_L_List", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AM_R_List_PropertyAddress, unrealStruct, "AM_R_List");
		AM_R_List_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AM_R_List");
		AM_R_List_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AM_R_List", Classes.FArrayProperty);
	}

	static BGWDataAsset_UnitDynamicObstaclePerformanceConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_UnitDynamicObstaclePerformanceConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_UnitDynamicObstaclePerformanceConfig));
	}
}
