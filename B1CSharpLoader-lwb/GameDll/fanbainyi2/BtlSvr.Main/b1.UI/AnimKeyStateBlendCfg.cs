using System;
using b1.Plugins.GSAnimationKeyBlender;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[BlueprintType]
[DisplayName("动画单帧状态融合配置")]
[UStruct]
[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg")]
public struct AnimKeyStateBlendCfg
{
	[DisplayName("动画名")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:AnimationName")]
	public string AnimationName;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("状态切换时间")]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:EasingFullTime")]
	public float EasingFullTime;

	[EditAnywhere]
	[DisplayName("融合方式")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:EasingFunc")]
	public EEasingFunc EasingFunc;

	[DisplayName("融合方式_是否需要自定义参数Exp")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:NeedEasingBlendExp")]
	public bool NeedEasingBlendExp;

	[UProperty]
	[EditAnywhere]
	[DisplayName("融合方式_参数Exp")]
	[UMeta(MDProp.EditCondition, "NeedEasingBlendExp")]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "建议非必要不改这个值,是控制融合曲线的参数,建议修改的话以2.0为基础")]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:EasingBlendExp")]
	public float EasingBlendExp;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("融合方式_是否需要自定义参数Steps")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:NeedEasingSteps")]
	public bool NeedEasingSteps;

	[UProperty]
	[UMeta(MDProp.EditCondition, "NeedEasingSteps")]
	[DisplayName("融合方式_参数Steps")]
	[UMeta(MD.ToolTip, "只有融合方式为Step时,这个参数才生效,建议谨慎修改")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:EasingSteps")]
	public int EasingSteps;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.Category, "Advanced")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("切换表演时间_延后时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:DelayEasingTime")]
	public float DelayEasingTime;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("Enum类型赋值时机")]
	[UMeta(MDProp.Category, "Advanced")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:EnumValEasingType")]
	public EGSAnimKBEnumBoolEasing EnumValEasingType;

	[UMeta(MDProp.Category, "Advanced")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("Bool类型赋值时机")]
	[USharpPath("/Script/b1-Managed.AnimKeyStateBlendCfg:BoolValEasingType")]
	public EGSAnimKBEnumBoolEasing BoolValEasingType;

	private static int AnimKeyStateBlendCfg_StructSize;

	private static int AnimKeyStateBlendCfg_IsValid;

	private static bool AnimationName_IsValid;

	private static int AnimationName_Offset;

	private static bool EasingFullTime_IsValid;

	private static int EasingFullTime_Offset;

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

	public AnimKeyStateBlendCfg Copy()
	{
		return this;
	}

	public static AnimKeyStateBlendCfg FromNative(IntPtr nativeBuffer)
	{
		return new AnimKeyStateBlendCfg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, AnimKeyStateBlendCfg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static AnimKeyStateBlendCfg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new AnimKeyStateBlendCfg(IntPtr.Add(nativeBuffer, arrayIndex * AnimKeyStateBlendCfg_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, AnimKeyStateBlendCfg value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimKeyStateBlendCfg_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimKeyStateBlendCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimKeyStateBlendCfg");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, AnimationName_Offset), AnimationName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EasingFullTime_Offset), EasingFullTime);
		EnumMarshaler<EEasingFunc>.ToNative(IntPtr.Add(nativeStruct, EasingFunc_Offset), 0, EasingFunc_PropertyAddress.Address, EasingFunc);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedEasingBlendExp_Offset), 0, NeedEasingBlendExp_PropertyAddress.Address, NeedEasingBlendExp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EasingBlendExp_Offset), EasingBlendExp);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedEasingSteps_Offset), 0, NeedEasingSteps_PropertyAddress.Address, NeedEasingSteps);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, EasingSteps_Offset), EasingSteps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayEasingTime_Offset), DelayEasingTime);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(nativeStruct, EnumValEasingType_Offset), 0, EnumValEasingType_PropertyAddress.Address, EnumValEasingType);
		EnumMarshaler<EGSAnimKBEnumBoolEasing>.ToNative(IntPtr.Add(nativeStruct, BoolValEasingType_Offset), 0, BoolValEasingType_PropertyAddress.Address, BoolValEasingType);
	}

	public AnimKeyStateBlendCfg(IntPtr nativeStruct)
	{
		if (AnimKeyStateBlendCfg_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimKeyStateBlendCfg");
			AnimationName = null;
			EasingFullTime = 0f;
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
			AnimationName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, AnimationName_Offset));
			EasingFullTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EasingFullTime_Offset));
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
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimKeyStateBlendCfg");
		AnimKeyStateBlendCfg_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimationName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationName");
		AnimationName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationName", Classes.FStrProperty);
		EasingFullTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "EasingFullTime");
		EasingFullTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EasingFullTime", Classes.FFloatProperty);
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
		AnimKeyStateBlendCfg_IsValid = ((intPtr != IntPtr.Zero && AnimationName_IsValid && EasingFullTime_IsValid && EasingFunc_IsValid && NeedEasingBlendExp_IsValid && EasingBlendExp_IsValid && NeedEasingSteps_IsValid && EasingSteps_IsValid && DelayEasingTime_IsValid && EnumValEasingType_IsValid && BoolValEasingType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimKeyStateBlendCfg", (byte)AnimKeyStateBlendCfg_IsValid != 0);
	}

	static AnimKeyStateBlendCfg()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AnimKeyStateBlendCfg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AnimKeyStateBlendCfg));
	}
}
