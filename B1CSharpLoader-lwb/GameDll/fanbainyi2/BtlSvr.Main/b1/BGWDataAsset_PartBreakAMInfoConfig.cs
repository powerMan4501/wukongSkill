using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig")]
public class BGWDataAsset_PartBreakAMInfoConfig : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool EnableExtraAreaSelectType_IsValid;

	private static int EnableExtraAreaSelectType_Offset;

	private static FFieldAddress EnableExtraAreaSelectType_PropertyAddress;

	private static bool SectorsType_IsValid;

	private static int SectorsType_Offset;

	private static FFieldAddress SectorsType_PropertyAddress;

	private static bool PBAS_ForwardLeft_FNB_IsValid;

	private static int PBAS_ForwardLeft_FNB_Offset;

	private static bool PBAS_ForwardRight_FNB_IsValid;

	private static int PBAS_ForwardRight_FNB_Offset;

	private static bool PBAS_ForwardLeft_FourDir_IsValid;

	private static int PBAS_ForwardLeft_FourDir_Offset;

	private static bool PBAS_ForwardRight_FourDir_IsValid;

	private static int PBAS_ForwardRight_FourDir_Offset;

	private static bool PBAS_BackwardLeft_FourDir_IsValid;

	private static int PBAS_BackwardLeft_FourDir_Offset;

	private static bool PBAS_BackwardRight_FourDir_IsValid;

	private static int PBAS_BackwardRight_FourDir_Offset;

	private static bool PartDamagedAMInfoList_IsValid;

	private static int PartDamagedAMInfoList_Offset;

	private static FFieldAddress PartDamagedAMInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FPartDamagedAMInfo> PartDamagedAMInfoList_Marshaler;

	[UMeta(MDProp.EditCondition)]
	[DisplayName("开启指定额外区域")]
	[Category("PartBreakAreaSelect")]
	[BlueprintReadWrite]
	[Tooltip("默认不勾选，使用的是UBAC对应StiffLevel的区域信息")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:EnableExtraAreaSelectType")]
	public bool EnableExtraAreaSelectType
	{
		get
		{
			CheckDestroyed();
			if (!EnableExtraAreaSelectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:EnableExtraAreaSelectType");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableExtraAreaSelectType_Offset), 0, EnableExtraAreaSelectType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableExtraAreaSelectType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:EnableExtraAreaSelectType");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableExtraAreaSelectType_Offset), 0, EnableExtraAreaSelectType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("PartBreakAreaSelect")]
	[UProperty]
	[DisplayName("额外指定区域划分类型")]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:SectorsType")]
	public ENormalStiffSectorsType SectorsType
	{
		get
		{
			CheckDestroyed();
			if (!SectorsType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:SectorsType");
				return ENormalStiffSectorsType.AllForward;
			}
			return EnumMarshaler<ENormalStiffSectorsType>.FromNative(IntPtr.Add(base.Address, SectorsType_Offset), 0, SectorsType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SectorsType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:SectorsType");
			}
			else
			{
				EnumMarshaler<ENormalStiffSectorsType>.ToNative(IntPtr.Add(base.Address, SectorsType_Offset), 0, SectorsType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType && SectorsType == NormalStiffSectorsType::ForwardAndBackward")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.ClampMin, "-180")]
	[DisplayName("左前分割角度_正反面")]
	[Category("PartBreakAreaSelect")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardLeft_FNB")]
	public float PBAS_ForwardLeft_FNB
	{
		get
		{
			CheckDestroyed();
			if (!PBAS_ForwardLeft_FNB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardLeft_FNB");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PBAS_ForwardLeft_FNB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PBAS_ForwardLeft_FNB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardLeft_FNB");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PBAS_ForwardLeft_FNB_Offset), value);
			}
		}
	}

	[Category("PartBreakAreaSelect")]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType && SectorsType == NormalStiffSectorsType::ForwardAndBackward")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.ClampMin, "-180")]
	[DisplayName("右前分割角度_正反面")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardRight_FNB")]
	public float PBAS_ForwardRight_FNB
	{
		get
		{
			CheckDestroyed();
			if (!PBAS_ForwardRight_FNB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardRight_FNB");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PBAS_ForwardRight_FNB_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PBAS_ForwardRight_FNB_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardRight_FNB");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PBAS_ForwardRight_FNB_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("左前分割角度_四方向")]
	[UMeta(MDProp.ClampMin, "-180")]
	[BlueprintReadWrite]
	[Category("PartBreakAreaSelect")]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType && SectorsType == NormalStiffSectorsType::FourDir")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardLeft_FourDir")]
	public float PBAS_ForwardLeft_FourDir
	{
		get
		{
			CheckDestroyed();
			if (!PBAS_ForwardLeft_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardLeft_FourDir");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PBAS_ForwardLeft_FourDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PBAS_ForwardLeft_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardLeft_FourDir");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PBAS_ForwardLeft_FourDir_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右前分割角度_四方向")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType && SectorsType == NormalStiffSectorsType::FourDir")]
	[Category("PartBreakAreaSelect")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardRight_FourDir")]
	public float PBAS_ForwardRight_FourDir
	{
		get
		{
			CheckDestroyed();
			if (!PBAS_ForwardRight_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardRight_FourDir");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PBAS_ForwardRight_FourDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PBAS_ForwardRight_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_ForwardRight_FourDir");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PBAS_ForwardRight_FourDir_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "-180")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType && SectorsType == NormalStiffSectorsType::FourDir")]
	[Category("PartBreakAreaSelect")]
	[DisplayName("左后分割角度_四方向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_BackwardLeft_FourDir")]
	public float PBAS_BackwardLeft_FourDir
	{
		get
		{
			CheckDestroyed();
			if (!PBAS_BackwardLeft_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_BackwardLeft_FourDir");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PBAS_BackwardLeft_FourDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PBAS_BackwardLeft_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_BackwardLeft_FourDir");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PBAS_BackwardLeft_FourDir_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("PartBreakAreaSelect")]
	[DisplayName("右后分割角度_四方向")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "EnableExtraAreaSelectType && SectorsType == NormalStiffSectorsType::FourDir")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_BackwardRight_FourDir")]
	public float PBAS_BackwardRight_FourDir
	{
		get
		{
			CheckDestroyed();
			if (!PBAS_BackwardRight_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_BackwardRight_FourDir");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PBAS_BackwardRight_FourDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PBAS_BackwardRight_FourDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PBAS_BackwardRight_FourDir");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PBAS_BackwardRight_FourDir_Offset), value);
			}
		}
	}

	[Tooltip("需要和表格里破损次数对应")]
	[DisplayName("部位破损动画列表")]
	[Category("PartDamaged")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PartDamagedAMInfoList")]
	public TArrayReadWrite<FPartDamagedAMInfo> PartDamagedAMInfoList
	{
		get
		{
			CheckDestroyed();
			if (!PartDamagedAMInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig:PartDamagedAMInfoList");
				return null;
			}
			if (PartDamagedAMInfoList_Marshaler == null)
			{
				PartDamagedAMInfoList_Marshaler = new TArrayReadWriteMarshaler<FPartDamagedAMInfo>(1, PartDamagedAMInfoList_PropertyAddress, CachedMarshalingDelegates<FPartDamagedAMInfo, FPartDamagedAMInfo>.FromNative, CachedMarshalingDelegates<FPartDamagedAMInfo, FPartDamagedAMInfo>.ToNative);
			}
			return PartDamagedAMInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, PartDamagedAMInfoList_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		foreach (FPartDamagedAMInfo partDamagedAMInfo in PartDamagedAMInfoList)
		{
			if (partDamagedAMInfo.DamagedAMPathForward != null)
			{
				AnimMontages.Add(partDamagedAMInfo.DamagedAMPathForward);
			}
			if (partDamagedAMInfo.DamagedAMPathBackward != null)
			{
				AnimMontages.Add(partDamagedAMInfo.DamagedAMPathBackward);
			}
			if (partDamagedAMInfo.DamagedAMPathLeftSide != null)
			{
				AnimMontages.Add(partDamagedAMInfo.DamagedAMPathLeftSide);
			}
			if (partDamagedAMInfo.DamagedAMPathRightSide != null)
			{
				AnimMontages.Add(partDamagedAMInfo.DamagedAMPathRightSide);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_PartBreakAMInfoConfig");
		NativeReflection.GetPropertyRef(ref EnableExtraAreaSelectType_PropertyAddress, unrealStruct, "EnableExtraAreaSelectType");
		EnableExtraAreaSelectType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableExtraAreaSelectType");
		EnableExtraAreaSelectType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableExtraAreaSelectType", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SectorsType_PropertyAddress, unrealStruct, "SectorsType");
		SectorsType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SectorsType");
		SectorsType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SectorsType", Classes.FEnumProperty);
		PBAS_ForwardLeft_FNB_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PBAS_ForwardLeft_FNB");
		PBAS_ForwardLeft_FNB_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PBAS_ForwardLeft_FNB", Classes.FFloatProperty);
		PBAS_ForwardRight_FNB_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PBAS_ForwardRight_FNB");
		PBAS_ForwardRight_FNB_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PBAS_ForwardRight_FNB", Classes.FFloatProperty);
		PBAS_ForwardLeft_FourDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PBAS_ForwardLeft_FourDir");
		PBAS_ForwardLeft_FourDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PBAS_ForwardLeft_FourDir", Classes.FFloatProperty);
		PBAS_ForwardRight_FourDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PBAS_ForwardRight_FourDir");
		PBAS_ForwardRight_FourDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PBAS_ForwardRight_FourDir", Classes.FFloatProperty);
		PBAS_BackwardLeft_FourDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PBAS_BackwardLeft_FourDir");
		PBAS_BackwardLeft_FourDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PBAS_BackwardLeft_FourDir", Classes.FFloatProperty);
		PBAS_BackwardRight_FourDir_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PBAS_BackwardRight_FourDir");
		PBAS_BackwardRight_FourDir_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PBAS_BackwardRight_FourDir", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PartDamagedAMInfoList_PropertyAddress, unrealStruct, "PartDamagedAMInfoList");
		PartDamagedAMInfoList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PartDamagedAMInfoList");
		PartDamagedAMInfoList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PartDamagedAMInfoList", Classes.FArrayProperty);
	}

	static BGWDataAsset_PartBreakAMInfoConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_PartBreakAMInfoConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_PartBreakAMInfoConfig));
	}
}
