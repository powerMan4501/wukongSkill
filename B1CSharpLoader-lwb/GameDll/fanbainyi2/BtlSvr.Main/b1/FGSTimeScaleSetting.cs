using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting")]
public struct FGSTimeScaleSetting
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("缩放比例")]
	[UMeta(MDProp.ClampMin, "0.1")]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:TimeScale")]
	public float TimeScale;

	[UMeta(MDProp.ClampMin, "0.1")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("渐入融合时间")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:BlendInRealTime")]
	public float BlendInRealTime;

	[UProperty]
	[DisplayName("渐入融合类型")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:BlendInType")]
	public EGSBlendTypeG BlendInType;

	[UMeta(MDProp.ClampMin, "0.1")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("渐入融合指数参数")]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:BlendInExp")]
	public float BlendInExp;

	[UMeta(MDProp.ClampMin, "0.1")]
	[DisplayName("渐出融合时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:BlendOutRealTime")]
	public float BlendOutRealTime;

	[DisplayName("渐出融合类型")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:BlendOutType")]
	public EGSBlendTypeG BlendOutType;

	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0.1")]
	[DisplayName("渐出融合指数参数")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:BlendOutExp")]
	public float BlendOutExp;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("自身不参与时间缩放")]
	[USharpPath("/Script/b1-Managed.FGSTimeScaleSetting:ExceptSelf")]
	public bool ExceptSelf;

	private static int FGSTimeScaleSetting_StructSize;

	private static int FGSTimeScaleSetting_IsValid;

	private static bool TimeScale_IsValid;

	private static int TimeScale_Offset;

	private static bool BlendInRealTime_IsValid;

	private static int BlendInRealTime_Offset;

	private static bool BlendInType_IsValid;

	private static int BlendInType_Offset;

	private static FFieldAddress BlendInType_PropertyAddress;

	private static bool BlendInExp_IsValid;

	private static int BlendInExp_Offset;

	private static bool BlendOutRealTime_IsValid;

	private static int BlendOutRealTime_Offset;

	private static bool BlendOutType_IsValid;

	private static int BlendOutType_Offset;

	private static FFieldAddress BlendOutType_PropertyAddress;

	private static bool BlendOutExp_IsValid;

	private static int BlendOutExp_Offset;

	private static bool ExceptSelf_IsValid;

	private static int ExceptSelf_Offset;

	private static FFieldAddress ExceptSelf_PropertyAddress;

	public void Reset()
	{
		TimeScale = 0f;
		BlendInRealTime = 0f;
		BlendInType = EGSBlendTypeG.GSNone;
		BlendInExp = 0f;
		BlendOutRealTime = 0f;
		BlendOutType = EGSBlendTypeG.GSNone;
		BlendOutExp = 0f;
		ExceptSelf = false;
	}

	public FGSTimeScaleSetting Copy()
	{
		return this;
	}

	public static FGSTimeScaleSetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSTimeScaleSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSTimeScaleSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSTimeScaleSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSTimeScaleSetting(IntPtr.Add(nativeBuffer, arrayIndex * FGSTimeScaleSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSTimeScaleSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSTimeScaleSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSTimeScaleSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSTimeScaleSetting");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TimeScale_Offset), TimeScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendInRealTime_Offset), BlendInRealTime);
		EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(nativeStruct, BlendInType_Offset), 0, BlendInType_PropertyAddress.Address, BlendInType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendInExp_Offset), BlendInExp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendOutRealTime_Offset), BlendOutRealTime);
		EnumMarshaler<EGSBlendTypeG>.ToNative(IntPtr.Add(nativeStruct, BlendOutType_Offset), 0, BlendOutType_PropertyAddress.Address, BlendOutType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendOutExp_Offset), BlendOutExp);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ExceptSelf_Offset), 0, ExceptSelf_PropertyAddress.Address, ExceptSelf);
	}

	public FGSTimeScaleSetting(IntPtr nativeStruct)
	{
		if (FGSTimeScaleSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSTimeScaleSetting");
			TimeScale = 0f;
			BlendInRealTime = 0f;
			BlendInType = EGSBlendTypeG.GSNone;
			BlendInExp = 0f;
			BlendOutRealTime = 0f;
			BlendOutType = EGSBlendTypeG.GSNone;
			BlendOutExp = 0f;
			ExceptSelf = false;
		}
		else
		{
			TimeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TimeScale_Offset));
			BlendInRealTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendInRealTime_Offset));
			BlendInType = EnumMarshaler<EGSBlendTypeG>.FromNative(IntPtr.Add(nativeStruct, BlendInType_Offset), 0, BlendInType_PropertyAddress.Address);
			BlendInExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendInExp_Offset));
			BlendOutRealTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendOutRealTime_Offset));
			BlendOutType = EnumMarshaler<EGSBlendTypeG>.FromNative(IntPtr.Add(nativeStruct, BlendOutType_Offset), 0, BlendOutType_PropertyAddress.Address);
			BlendOutExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendOutExp_Offset));
			ExceptSelf = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ExceptSelf_Offset), 0, ExceptSelf_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSTimeScaleSetting");
		FGSTimeScaleSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		TimeScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeScale");
		TimeScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeScale", Classes.FFloatProperty);
		BlendInRealTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInRealTime");
		BlendInRealTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInRealTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendInType_PropertyAddress, intPtr, "BlendInType");
		BlendInType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInType");
		BlendInType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInType", Classes.FEnumProperty);
		BlendInExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInExp");
		BlendInExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInExp", Classes.FFloatProperty);
		BlendOutRealTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutRealTime");
		BlendOutRealTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutRealTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BlendOutType_PropertyAddress, intPtr, "BlendOutType");
		BlendOutType_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutType");
		BlendOutType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutType", Classes.FEnumProperty);
		BlendOutExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutExp");
		BlendOutExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutExp", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ExceptSelf_PropertyAddress, intPtr, "ExceptSelf");
		ExceptSelf_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExceptSelf");
		ExceptSelf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExceptSelf", Classes.FBoolProperty);
		FGSTimeScaleSetting_IsValid = ((intPtr != IntPtr.Zero && TimeScale_IsValid && BlendInRealTime_IsValid && BlendInType_IsValid && BlendInExp_IsValid && BlendOutRealTime_IsValid && BlendOutType_IsValid && BlendOutExp_IsValid && ExceptSelf_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSTimeScaleSetting", (byte)FGSTimeScaleSetting_IsValid != 0);
	}

	static FGSTimeScaleSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSTimeScaleSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSTimeScaleSetting));
	}
}
