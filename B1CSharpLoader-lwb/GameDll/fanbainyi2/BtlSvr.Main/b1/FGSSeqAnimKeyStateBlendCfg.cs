using System;
using b1.Plugins.GSAnimationKeyBlender;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[DisplayName("动画单帧状态融合配置")]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg")]
public struct FGSSeqAnimKeyStateBlendCfg
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("当前状态,可以填*,表示匹配全状态")]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:FromStateName")]
	public string FromStateName;

	[DisplayName("目标状态,可以填*,表示匹配全状态")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:ToStateName")]
	public string ToStateName;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("切换表演时间")]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:EasingTime")]
	public float EasingTime;

	[BlueprintReadWrite]
	[DisplayName("融合方式")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:EasingFunc")]
	public EEasingFunc EasingFunc;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("融合方式_是否需要自定义参数Exp")]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:NeedEasingBlendExp")]
	public bool NeedEasingBlendExp;

	[UMeta(MD.ToolTip, "建议非必要不改这个值,是控制融合曲线的参数,建议修改的话以2.0为基础")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("融合方式_参数Exp")]
	[UMeta(MDProp.EditCondition, "NeedEasingBlendExp")]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:EasingBlendExp")]
	public float EasingBlendExp;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("融合方式_是否需要自定义参数Steps")]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:NeedEasingSteps")]
	public bool NeedEasingSteps;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("融合方式_参数Steps")]
	[UMeta(MDProp.EditCondition, "NeedEasingSteps")]
	[UMeta(MD.ToolTip, "只有融合方式为Step时,这个参数才生效,建议谨慎修改")]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:EasingSteps")]
	public int EasingSteps;

	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("切换表演时间_延后时间")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.Category, "Advanced")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:DelayEasingTime")]
	public float DelayEasingTime;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Enum属性赋值时机")]
	[UMeta(MDProp.Category, "Advanced")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:EnumValEasingType")]
	public EGSAnimKBEnumBoolEasing EnumValEasingType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Bool属性赋值时机")]
	[UMeta(MDProp.Category, "Advanced")]
	[UProperty]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg:BoolValEasingType")]
	public EGSAnimKBEnumBoolEasing BoolValEasingType;

	private static int FGSSeqAnimKeyStateBlendCfg_StructSize;

	private static int FGSSeqAnimKeyStateBlendCfg_IsValid;

	private static bool FromStateName_IsValid;

	private static int FromStateName_Offset;

	private static bool ToStateName_IsValid;

	private static int ToStateName_Offset;

	private static bool EasingTime_IsValid;

	private static int EasingTime_Offset;

	private static bool EasingFunc_IsValid;

	private static int EasingFunc_Offset;

	private static FFieldAddress EasingFunc_PropertyAddress;

	private static bool NeedEasingBlendExp_IsValid;

	private static int NeedEasingBlendExp_Offset;

	private static FFieldAddress NeedEasingBlendExp_PropertyAddress;

	private static bool EasingBlendExp_IsValid;

	private static int EasingBlendExp_Offset;

	private static bool NeedEasingSteps_IsValid;

	private static int NeedEasingSteps_Offset;

	private static FFieldAddress NeedEasingSteps_PropertyAddress;

	private static bool EasingSteps_IsValid;

	private static int EasingSteps_Offset;

	private static bool DelayEasingTime_IsValid;

	private static int DelayEasingTime_Offset;

	private static bool EnumValEasingType_IsValid;

	private static int EnumValEasingType_Offset;

	private static FFieldAddress EnumValEasingType_PropertyAddress;

	private static bool BoolValEasingType_IsValid;

	private static int BoolValEasingType_Offset;

	private static FFieldAddress BoolValEasingType_PropertyAddress;

	public FGSSeqAnimKeyStateBlendCfg Copy()
	{
		return this;
	}

	public static FGSSeqAnimKeyStateBlendCfg FromNative(IntPtr nativeBuffer)
	{
		return new FGSSeqAnimKeyStateBlendCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSSeqAnimKeyStateBlendCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSSeqAnimKeyStateBlendCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSSeqAnimKeyStateBlendCfg(IntPtr.Add(nativeBuffer, arrayIndex * FGSSeqAnimKeyStateBlendCfg_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSSeqAnimKeyStateBlendCfg value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSSeqAnimKeyStateBlendCfg_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSSeqAnimKeyStateBlendCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, FromStateName_Offset), FromStateName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ToStateName_Offset), ToStateName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EasingTime_Offset), EasingTime);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(nativeStruct, EasingFunc_Offset), 0, EasingFunc_PropertyAddress.Address, EasingFunc);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedEasingBlendExp_Offset), 0, NeedEasingBlendExp_PropertyAddress.Address, NeedEasingBlendExp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EasingBlendExp_Offset), EasingBlendExp);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedEasingSteps_Offset), 0, NeedEasingSteps_PropertyAddress.Address, NeedEasingSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EasingSteps_Offset), EasingSteps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayEasingTime_Offset), DelayEasingTime);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(nativeStruct, EnumValEasingType_Offset), 0, EnumValEasingType_PropertyAddress.Address, EnumValEasingType);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(nativeStruct, BoolValEasingType_Offset), 0, BoolValEasingType_PropertyAddress.Address, BoolValEasingType);
	}

	public FGSSeqAnimKeyStateBlendCfg(IntPtr nativeStruct)
	{
		if (FGSSeqAnimKeyStateBlendCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg");
			FromStateName = null;
			ToStateName = null;
			EasingTime = 0f;
			EasingFunc = EEasingFunc.Linear;
			NeedEasingBlendExp = false;
			EasingBlendExp = 0f;
			NeedEasingSteps = false;
			EasingSteps = 0;
			DelayEasingTime = 0f;
			EnumValEasingType = EGSAnimKBEnumBoolEasing.GSEnd;
			BoolValEasingType = EGSAnimKBEnumBoolEasing.GSEnd;
		}
		else
		{
			FromStateName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, FromStateName_Offset));
			ToStateName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ToStateName_Offset));
			EasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EasingTime_Offset));
			EasingFunc = EnumMarshaler<EEasingFunc>.FromNative(IntPtr.Add(nativeStruct, EasingFunc_Offset), 0, EasingFunc_PropertyAddress.Address);
			NeedEasingBlendExp = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedEasingBlendExp_Offset), 0, NeedEasingBlendExp_PropertyAddress.Address);
			EasingBlendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EasingBlendExp_Offset));
			NeedEasingSteps = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedEasingSteps_Offset), 0, NeedEasingSteps_PropertyAddress.Address);
			EasingSteps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, EasingSteps_Offset));
			DelayEasingTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayEasingTime_Offset));
			EnumValEasingType = EnumMarshaler<EGSAnimKBEnumBoolEasing>.FromNative(IntPtr.Add(nativeStruct, EnumValEasingType_Offset), 0, EnumValEasingType_PropertyAddress.Address);
			BoolValEasingType = EnumMarshaler<EGSAnimKBEnumBoolEasing>.FromNative(IntPtr.Add(nativeStruct, BoolValEasingType_Offset), 0, BoolValEasingType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg");
		FGSSeqAnimKeyStateBlendCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		FromStateName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FromStateName");
		FromStateName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FromStateName", Classes.FStrProperty);
		ToStateName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ToStateName");
		ToStateName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ToStateName", Classes.FStrProperty);
		EasingTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "EasingTime");
		EasingTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EasingFunc_PropertyAddress, intPtr, "EasingFunc");
		EasingFunc_Offset = NativeReflection.GetPropertyOffset(intPtr, "EasingFunc");
		EasingFunc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EasingFunc", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref NeedEasingBlendExp_PropertyAddress, intPtr, "NeedEasingBlendExp");
		NeedEasingBlendExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedEasingBlendExp");
		NeedEasingBlendExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedEasingBlendExp", Classes.FBoolProperty);
		EasingBlendExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "EasingBlendExp");
		EasingBlendExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EasingBlendExp", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NeedEasingSteps_PropertyAddress, intPtr, "NeedEasingSteps");
		NeedEasingSteps_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedEasingSteps");
		NeedEasingSteps_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedEasingSteps", Classes.FBoolProperty);
		EasingSteps_Offset = NativeReflection.GetPropertyOffset(intPtr, "EasingSteps");
		EasingSteps_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EasingSteps", Classes.FIntProperty);
		DelayEasingTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayEasingTime");
		DelayEasingTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayEasingTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnumValEasingType_PropertyAddress, intPtr, "EnumValEasingType");
		EnumValEasingType_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnumValEasingType");
		EnumValEasingType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnumValEasingType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BoolValEasingType_PropertyAddress, intPtr, "BoolValEasingType");
		BoolValEasingType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoolValEasingType");
		BoolValEasingType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoolValEasingType", Classes.FEnumProperty);
		FGSSeqAnimKeyStateBlendCfg_IsValid = ((intPtr != IntPtr.Zero && FromStateName_IsValid && ToStateName_IsValid && EasingTime_IsValid && EasingFunc_IsValid && NeedEasingBlendExp_IsValid && EasingBlendExp_IsValid && NeedEasingSteps_IsValid && EasingSteps_IsValid && DelayEasingTime_IsValid && EnumValEasingType_IsValid && BoolValEasingType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSSeqAnimKeyStateBlendCfg", (byte)FGSSeqAnimKeyStateBlendCfg_IsValid != 0);
	}

	static FGSSeqAnimKeyStateBlendCfg()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSSeqAnimKeyStateBlendCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSSeqAnimKeyStateBlendCfg));
	}
}
