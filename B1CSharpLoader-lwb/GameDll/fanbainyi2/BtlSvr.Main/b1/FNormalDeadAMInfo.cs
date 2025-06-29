using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.NormalDeadAMInfo")]
public struct FNormalDeadAMInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("挡位ID")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:StiffLevelID")]
	public int StiffLevelID;

	[EditAnywhere]
	[DisplayName("是否启用受击动画接续功能")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("受击动画中需要加NotifyState:CanBlendToDeadAM示意何时融入死亡动画，死亡动画中可添加Section:Dead_ing示意从何处开始融入死亡动画")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:IsEnableStiffContinue")]
	public bool IsEnableStiffContinue;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("是否启用复用")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:IsEnableReuse")]
	public bool IsEnableReuse;

	[UMeta(MDProp.EditCondition, "IsEnableReuse")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("挡位复用ID")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:StiffLevelReuseID")]
	public int StiffLevelReuseID;

	[UMeta(MDProp.EditCondition, "!IsEnableReuse")]
	[BlueprintReadWrite]
	[DisplayName("动画省略类型")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:DeadEllipsisType")]
	public EDeadEllipsisType DeadEllipsisType;

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse")]
	[DisplayName("是否受击旋转")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:EnableBeAttackedRotate")]
	public bool EnableBeAttackedRotate;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("受击区域划分类型")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:SectorsType")]
	public ENormalStiffSectorsType SectorsType;

	[UProperty]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::ForwardAndBackward")]
	[BlueprintReadWrite]
	[DisplayName("左前分割角度_正反面")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:NormalStiffRotateForwardLeft_FNB")]
	public float NormalStiffRotateForwardLeft_FNB;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右前分割角度_正反面")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::ForwardAndBackward")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:NormalStiffRotateForwardRight_FNB")]
	public float NormalStiffRotateForwardRight_FNB;

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[DisplayName("左前分割角度_四方向")]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "-180")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:NormalStiffRotateForwardLeft_FourDir")]
	public float NormalStiffRotateForwardLeft_FourDir;

	[EditAnywhere]
	[DisplayName("右前分割角度_四方向")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:NormalStiffRotateForwardRight_FourDir")]
	public float NormalStiffRotateForwardRight_FourDir;

	[DisplayName("左后分割角度_四方向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMax, "180")]
	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[UMeta(MDProp.ClampMin, "-180")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:NormalStiffRotateBackwardLeft_FourDir")]
	public float NormalStiffRotateBackwardLeft_FourDir;

	[UMeta(MDProp.EditCondition, "!IsEnableReuse && SectorsType == NormalStiffSectorsType::FourDir")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右后分割角度_四方向")]
	[UMeta(MDProp.ClampMin, "-180")]
	[UProperty]
	[UMeta(MDProp.ClampMax, "180")]
	[USharpPath("/Script/b1-Managed.NormalDeadAMInfo:NormalStiffRotateBackwardRight_FourDir")]
	public float NormalStiffRotateBackwardRight_FourDir;

	private static int NormalDeadAMInfo_StructSize;

	private static int NormalDeadAMInfo_IsValid;

	private static bool StiffLevelID_IsValid;

	private static int StiffLevelID_Offset;

	private static bool IsEnableStiffContinue_IsValid;

	private static int IsEnableStiffContinue_Offset;

	private static FFieldAddress IsEnableStiffContinue_PropertyAddress;

	private static bool IsEnableReuse_IsValid;

	private static int IsEnableReuse_Offset;

	private static FFieldAddress IsEnableReuse_PropertyAddress;

	private static bool StiffLevelReuseID_IsValid;

	private static int StiffLevelReuseID_Offset;

	private static bool DeadEllipsisType_IsValid;

	private static int DeadEllipsisType_Offset;

	private static FFieldAddress DeadEllipsisType_PropertyAddress;

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

	public FNormalDeadAMInfo(int _StiffLevelID, bool _IsEnableStiffContinue, bool _IsEnableReuse, int _StiffLevelReuseID, bool _EnableBeAttackedRotate, EDeadEllipsisType _DeadEllipsisType, ENormalStiffSectorsType _SectorsType, float _NormalStiffRotateForwardLeft_FNB, float _NormalStiffRotateForwardRight_FNB, float _NormalStiffRotateForwardLeft_FourDir, float _NormalStiffRotateForwardRight_FourDir, float _NormalStiffRotateBackwardLeft_FourDir, float _NormalStiffRotateBackwardRight_FourDir)
	{
		StiffLevelID = _StiffLevelID;
		IsEnableStiffContinue = _IsEnableStiffContinue;
		IsEnableReuse = _IsEnableReuse;
		StiffLevelReuseID = _StiffLevelReuseID;
		EnableBeAttackedRotate = _EnableBeAttackedRotate;
		DeadEllipsisType = _DeadEllipsisType;
		SectorsType = _SectorsType;
		NormalStiffRotateForwardLeft_FNB = _NormalStiffRotateForwardLeft_FNB;
		NormalStiffRotateForwardRight_FNB = _NormalStiffRotateForwardRight_FNB;
		NormalStiffRotateForwardLeft_FourDir = _NormalStiffRotateForwardLeft_FourDir;
		NormalStiffRotateForwardRight_FourDir = _NormalStiffRotateForwardRight_FourDir;
		NormalStiffRotateBackwardLeft_FourDir = _NormalStiffRotateBackwardLeft_FourDir;
		NormalStiffRotateBackwardRight_FourDir = _NormalStiffRotateBackwardRight_FourDir;
	}

	public FNormalDeadAMInfo Copy()
	{
		return this;
	}

	public static FNormalDeadAMInfo FromNative(IntPtr nativeBuffer)
	{
		return new FNormalDeadAMInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNormalDeadAMInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNormalDeadAMInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNormalDeadAMInfo(IntPtr.Add(nativeBuffer, arrayIndex * NormalDeadAMInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNormalDeadAMInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * NormalDeadAMInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (NormalDeadAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NormalDeadAMInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StiffLevelID_Offset), StiffLevelID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsEnableStiffContinue_Offset), 0, IsEnableStiffContinue_PropertyAddress.Address, IsEnableStiffContinue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsEnableReuse_Offset), 0, IsEnableReuse_PropertyAddress.Address, IsEnableReuse);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, StiffLevelReuseID_Offset), StiffLevelReuseID);
		EnumMarshaler<EDeadEllipsisType>.ToNative(IntPtr.Add(nativeStruct, DeadEllipsisType_Offset), 0, DeadEllipsisType_PropertyAddress.Address, DeadEllipsisType);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableBeAttackedRotate_Offset), 0, EnableBeAttackedRotate_PropertyAddress.Address, EnableBeAttackedRotate);
		EnumMarshaler<ENormalStiffSectorsType>.ToNative(IntPtr.Add(nativeStruct, SectorsType_Offset), 0, SectorsType_PropertyAddress.Address, SectorsType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardLeft_FNB_Offset), NormalStiffRotateForwardLeft_FNB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardRight_FNB_Offset), NormalStiffRotateForwardRight_FNB);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardLeft_FourDir_Offset), NormalStiffRotateForwardLeft_FourDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateForwardRight_FourDir_Offset), NormalStiffRotateForwardRight_FourDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateBackwardLeft_FourDir_Offset), NormalStiffRotateBackwardLeft_FourDir);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalStiffRotateBackwardRight_FourDir_Offset), NormalStiffRotateBackwardRight_FourDir);
	}

	public FNormalDeadAMInfo(IntPtr nativeStruct)
	{
		if (NormalDeadAMInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NormalDeadAMInfo");
			StiffLevelID = 0;
			IsEnableStiffContinue = false;
			IsEnableReuse = false;
			StiffLevelReuseID = 0;
			DeadEllipsisType = EDeadEllipsisType.None;
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
			IsEnableStiffContinue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsEnableStiffContinue_Offset), 0, IsEnableStiffContinue_PropertyAddress.Address);
			IsEnableReuse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsEnableReuse_Offset), 0, IsEnableReuse_PropertyAddress.Address);
			StiffLevelReuseID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, StiffLevelReuseID_Offset));
			DeadEllipsisType = EnumMarshaler<EDeadEllipsisType>.FromNative(IntPtr.Add(nativeStruct, DeadEllipsisType_Offset), 0, DeadEllipsisType_PropertyAddress.Address);
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
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.NormalDeadAMInfo");
		NormalDeadAMInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		StiffLevelID_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevelID");
		StiffLevelID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevelID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsEnableStiffContinue_PropertyAddress, intPtr, "IsEnableStiffContinue");
		IsEnableStiffContinue_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsEnableStiffContinue");
		IsEnableStiffContinue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsEnableStiffContinue", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsEnableReuse_PropertyAddress, intPtr, "IsEnableReuse");
		IsEnableReuse_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsEnableReuse");
		IsEnableReuse_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsEnableReuse", Classes.FBoolProperty);
		StiffLevelReuseID_Offset = NativeReflection.GetPropertyOffset(intPtr, "StiffLevelReuseID");
		StiffLevelReuseID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StiffLevelReuseID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DeadEllipsisType_PropertyAddress, intPtr, "DeadEllipsisType");
		DeadEllipsisType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeadEllipsisType");
		DeadEllipsisType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeadEllipsisType", Classes.FEnumProperty);
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
		NormalDeadAMInfo_IsValid = ((intPtr != IntPtr.Zero && StiffLevelID_IsValid && IsEnableStiffContinue_IsValid && IsEnableReuse_IsValid && StiffLevelReuseID_IsValid && DeadEllipsisType_IsValid && EnableBeAttackedRotate_IsValid && SectorsType_IsValid && NormalStiffRotateForwardLeft_FNB_IsValid && NormalStiffRotateForwardRight_FNB_IsValid && NormalStiffRotateForwardLeft_FourDir_IsValid && NormalStiffRotateForwardRight_FourDir_IsValid && NormalStiffRotateBackwardLeft_FourDir_IsValid && NormalStiffRotateBackwardRight_FourDir_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.NormalDeadAMInfo", (byte)NormalDeadAMInfo_IsValid != 0);
	}

	static FNormalDeadAMInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNormalDeadAMInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNormalDeadAMInfo));
	}
}
