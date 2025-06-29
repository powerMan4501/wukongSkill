using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.NormalStiffInfo")]
public struct FNormalStiffInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("挡位ID")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:StiffLevelID")]
	public int StiffLevelID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否启用复用")]
	[Tooltip("复用是指复用下面的规则，并不是说挡位ID替换")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:IsEnableReuse")]
	public bool IsEnableReuse;

	[UMeta(MDProp.EditCondition, "IsEnableReuse")]
	[DisplayName("挡位复用ID")]
	[Tooltip("复用是指复用下面的规则，并不是说挡位ID替换")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:StiffLevelReuseID")]
	public int StiffLevelReuseID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("动画省略类型")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:EllipsisType")]
	public EEllipsisType EllipsisType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否受击旋转")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:EnableBeAttackedRotate")]
	public bool EnableBeAttackedRotate;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("受击区域划分类型")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:SectorsType")]
	public ENormalStiffSectorsType SectorsType;

	[DisplayName("左前分割角度_正反面")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::ForwardAndBackward")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:NormalStiffRotateForwardLeft_FNB")]
	public float NormalStiffRotateForwardLeft_FNB;

	[DisplayName("右前分割角度_正反面")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::ForwardAndBackward")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:NormalStiffRotateForwardRight_FNB")]
	public float NormalStiffRotateForwardRight_FNB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("左前分割角度_四方向")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:NormalStiffRotateForwardLeft_FourDir")]
	public float NormalStiffRotateForwardLeft_FourDir;

	[UMeta(MDProp.ClampMax, "180")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[DisplayName("右前分割角度_四方向")]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:NormalStiffRotateForwardRight_FourDir")]
	public float NormalStiffRotateForwardRight_FourDir;

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.ClampMin, "-180")]
	[BlueprintReadWrite]
	[DisplayName("左后分割角度_四方向")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:NormalStiffRotateBackwardLeft_FourDir")]
	public float NormalStiffRotateBackwardLeft_FourDir;

	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.ClampMin, "-180")]
	[DisplayName("右后分割角度_四方向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NormalStiffInfo:NormalStiffRotateBackwardRight_FourDir")]
	public float NormalStiffRotateBackwardRight_FourDir;

	private static int NormalStiffInfo_StructSize;

	private static int NormalStiffInfo_IsValid;

	private static bool StiffLevelID_IsValid;

	private static int StiffLevelID_Offset;

	private static bool IsEnableReuse_IsValid;

	private static int IsEnableReuse_Offset;

	private static FFieldAddress IsEnableReuse_PropertyAddress;

	private static bool StiffLevelReuseID_IsValid;

	private static int StiffLevelReuseID_Offset;

	private static bool EllipsisType_IsValid;

	private static int EllipsisType_Offset;

	private static FFieldAddress EllipsisType_PropertyAddress;

	private static bool EnableBeAttackedRotate_IsValid;

	private static int EnableBeAttackedRotate_Offset;

	private static FFieldAddress EnableBeAttackedRotate_PropertyAddress;

	private static bool SectorsType_IsValid;

	private static int SectorsType_Offset;

	private static FFieldAddress SectorsType_PropertyAddress;

	private static bool NormalStiffRotateForwardLeft_FNB_IsValid;

	private static int NormalStiffRotateForwardLeft_FNB_Offset;

	private static bool NormalStiffRotateForwardRight_FNB_IsValid;

	private static int NormalStiffRotateForwardRight_FNB_Offset;

	private static bool NormalStiffRotateForwardLeft_FourDir_IsValid;

	private static int NormalStiffRotateForwardLeft_FourDir_Offset;

	private static bool NormalStiffRotateForwardRight_FourDir_IsValid;

	private static int NormalStiffRotateForwardRight_FourDir_Offset;

	private static bool NormalStiffRotateBackwardLeft_FourDir_IsValid;

	private static int NormalStiffRotateBackwardLeft_FourDir_Offset;

	private static bool NormalStiffRotateBackwardRight_FourDir_IsValid;

	private static int NormalStiffRotateBackwardRight_FourDir_Offset;

	public FNormalStiffInfo(int _StiffLevelID, bool _IsEnableReuse, int _StiffLevelReuseID, bool _EnableBeAttackedRotate, EEllipsisType _EllipsisType, ENormalStiffSectorsType _SectorsType, float _NormalStiffRotateForwardLeft_FNB, float _NormalStiffRotateForwardRight_FNB, float _NormalStiffRotateForwardLeft_FourDir, float _NormalStiffRotateForwardRight_FourDir, float _NormalStiffRotateBackwardLeft_FourDir, float _NormalStiffRotateBackwardRight_FourDir)
	{
		StiffLevelID = _StiffLevelID;
		IsEnableReuse = _IsEnableReuse;
		StiffLevelReuseID = _StiffLevelReuseID;
		EnableBeAttackedRotate = _EnableBeAttackedRotate;
		EllipsisType = _EllipsisType;
		SectorsType = _SectorsType;
		NormalStiffRotateForwardLeft_FNB = _NormalStiffRotateForwardLeft_FNB;
		NormalStiffRotateForwardRight_FNB = _NormalStiffRotateForwardRight_FNB;
		NormalStiffRotateForwardLeft_FourDir = _NormalStiffRotateForwardLeft_FourDir;
		NormalStiffRotateForwardRight_FourDir = _NormalStiffRotateForwardRight_FourDir;
		NormalStiffRotateBackwardLeft_FourDir = _NormalStiffRotateBackwardLeft_FourDir;
		NormalStiffRotateBackwardRight_FourDir = _NormalStiffRotateBackwardRight_FourDir;
	}

	public FNormalStiffInfo Copy()
	{
		return this;
	}

	public static FNormalStiffInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNormalStiffInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNormalStiffInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNormalStiffInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNormalStiffInfo(IntPtr.Add(nativeBuffer, arrayIndex * NormalStiffInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNormalStiffInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * NormalStiffInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (NormalStiffInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NormalStiffInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StiffLevelID_Offset), StiffLevelID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsEnableReuse_Offset), 0, IsEnableReuse_PropertyAddress.Address, IsEnableReuse);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StiffLevelReuseID_Offset), StiffLevelReuseID);
		EnumMarshaler<EEllipsisType>.ToNative(IntPtr.Add(nativeStruct, EllipsisType_Offset), 0, EllipsisType_PropertyAddress.Address, EllipsisType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableBeAttackedRotate_Offset), 0, EnableBeAttackedRotate_PropertyAddress.Address, EnableBeAttackedRotate);
		EnumMarshaler<ENormalStiffSectorsType>.ToNative(IntPtr.Add(nativeStruct, SectorsType_Offset), 0, SectorsType_PropertyAddress.Address, SectorsType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardLeft_FNB_Offset), NormalStiffRotateForwardLeft_FNB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardRight_FNB_Offset), NormalStiffRotateForwardRight_FNB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardLeft_FourDir_Offset), NormalStiffRotateForwardLeft_FourDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardRight_FourDir_Offset), NormalStiffRotateForwardRight_FourDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateBackwardLeft_FourDir_Offset), NormalStiffRotateBackwardLeft_FourDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateBackwardRight_FourDir_Offset), NormalStiffRotateBackwardRight_FourDir);
	}

	public FNormalStiffInfo(IntPtr nativeStruct)
	{
		if (NormalStiffInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NormalStiffInfo");
			StiffLevelID = 0;
			IsEnableReuse = false;
			StiffLevelReuseID = 0;
			EllipsisType = EEllipsisType.None;
			EnableBeAttackedRotate = false;
			SectorsType = ENormalStiffSectorsType.AllForward;
			NormalStiffRotateForwardLeft_FNB = 0f;
			NormalStiffRotateForwardRight_FNB = 0f;
			NormalStiffRotateForwardLeft_FourDir = 0f;
			NormalStiffRotateForwardRight_FourDir = 0f;
			NormalStiffRotateBackwardLeft_FourDir = 0f;
			NormalStiffRotateBackwardRight_FourDir = 0f;
		}
		else
		{
			StiffLevelID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StiffLevelID_Offset));
			IsEnableReuse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsEnableReuse_Offset), 0, IsEnableReuse_PropertyAddress.Address);
			StiffLevelReuseID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StiffLevelReuseID_Offset));
			EllipsisType = EnumMarshaler<EEllipsisType>.FromNative(IntPtr.Add(nativeStruct, EllipsisType_Offset), 0, EllipsisType_PropertyAddress.Address);
			EnableBeAttackedRotate = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableBeAttackedRotate_Offset), 0, EnableBeAttackedRotate_PropertyAddress.Address);
			SectorsType = EnumMarshaler<ENormalStiffSectorsType>.FromNative(IntPtr.Add(nativeStruct, SectorsType_Offset), 0, SectorsType_PropertyAddress.Address);
			NormalStiffRotateForwardLeft_FNB = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardLeft_FNB_Offset));
			NormalStiffRotateForwardRight_FNB = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardRight_FNB_Offset));
			NormalStiffRotateForwardLeft_FourDir = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardLeft_FourDir_Offset));
			NormalStiffRotateForwardRight_FourDir = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardRight_FourDir_Offset));
			NormalStiffRotateBackwardLeft_FourDir = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalStiffRotateBackwardLeft_FourDir_Offset));
			NormalStiffRotateBackwardRight_FourDir = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalStiffRotateBackwardRight_FourDir_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.NormalStiffInfo");
		NormalStiffInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		StiffLevelID_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevelID");
		StiffLevelID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevelID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsEnableReuse_PropertyAddress, intPtr, "IsEnableReuse");
		IsEnableReuse_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsEnableReuse");
		IsEnableReuse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsEnableReuse", Classes.FBoolProperty);
		StiffLevelReuseID_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevelReuseID");
		StiffLevelReuseID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevelReuseID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EllipsisType_PropertyAddress, intPtr, "EllipsisType");
		EllipsisType_Offset = NativeReflection.GetPropertyOffset(intPtr, "EllipsisType");
		EllipsisType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EllipsisType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref EnableBeAttackedRotate_PropertyAddress, intPtr, "EnableBeAttackedRotate");
		EnableBeAttackedRotate_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableBeAttackedRotate");
		EnableBeAttackedRotate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableBeAttackedRotate", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SectorsType_PropertyAddress, intPtr, "SectorsType");
		SectorsType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectorsType");
		SectorsType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectorsType", Classes.FEnumProperty);
		NormalStiffRotateForwardLeft_FNB_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalStiffRotateForwardLeft_FNB");
		NormalStiffRotateForwardLeft_FNB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalStiffRotateForwardLeft_FNB", Classes.FFloatProperty);
		NormalStiffRotateForwardRight_FNB_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalStiffRotateForwardRight_FNB");
		NormalStiffRotateForwardRight_FNB_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalStiffRotateForwardRight_FNB", Classes.FFloatProperty);
		NormalStiffRotateForwardLeft_FourDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalStiffRotateForwardLeft_FourDir");
		NormalStiffRotateForwardLeft_FourDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalStiffRotateForwardLeft_FourDir", Classes.FFloatProperty);
		NormalStiffRotateForwardRight_FourDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalStiffRotateForwardRight_FourDir");
		NormalStiffRotateForwardRight_FourDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalStiffRotateForwardRight_FourDir", Classes.FFloatProperty);
		NormalStiffRotateBackwardLeft_FourDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalStiffRotateBackwardLeft_FourDir");
		NormalStiffRotateBackwardLeft_FourDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalStiffRotateBackwardLeft_FourDir", Classes.FFloatProperty);
		NormalStiffRotateBackwardRight_FourDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalStiffRotateBackwardRight_FourDir");
		NormalStiffRotateBackwardRight_FourDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalStiffRotateBackwardRight_FourDir", Classes.FFloatProperty);
		NormalStiffInfo_IsValid = ((intPtr != IntPtr.Zero && StiffLevelID_IsValid && IsEnableReuse_IsValid && StiffLevelReuseID_IsValid && EllipsisType_IsValid && EnableBeAttackedRotate_IsValid && SectorsType_IsValid && NormalStiffRotateForwardLeft_FNB_IsValid && NormalStiffRotateForwardRight_FNB_IsValid && NormalStiffRotateForwardLeft_FourDir_IsValid && NormalStiffRotateForwardRight_FourDir_IsValid && NormalStiffRotateBackwardLeft_FourDir_IsValid && NormalStiffRotateBackwardRight_FourDir_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.NormalStiffInfo", (byte)NormalStiffInfo_IsValid != 0);
	}

	static FNormalStiffInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNormalStiffInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNormalStiffInfo));
	}
}
