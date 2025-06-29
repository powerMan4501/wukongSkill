using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MatParam")]
public struct FMatParam
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatParam:ParamType")]
	public EGSMatParamType ParamType;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatParam:ParameterName")]
	public FName ParameterName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatParam:FloatValue")]
	public float FloatValue;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatParam:VectorValue")]
	public FVector VectorValue;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MatParam:LinearColorValue")]
	public FLinearColor LinearColorValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatParam:FloatCurve")]
	public UCurveFloat FloatCurve;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatParam:VectorCurve")]
	public UCurveVector VectorCurve;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatParam:LinearColorCurve")]
	public UCurveLinearColor LinearColorCurve;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MatParam:SocketName")]
	public FName SocketName;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("角色数据每帧更新")]
	[USharpPath("/Script/b1-Managed.MatParam:CharacterInfoRefresh")]
	public bool CharacterInfoRefresh;

	[BlueprintReadWrite]
	[DisplayName("是否映射到屏幕空间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MatParam:bUseScreenSpace")]
	public bool bUseScreenSpace;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("是否使用上一帧的值")]
	[USharpPath("/Script/b1-Managed.MatParam:bUseLastFrameValue")]
	public bool bUseLastFrameValue;

	private static int MatParam_StructSize;

	private static int MatParam_IsValid;

	private static bool ParamType_IsValid;

	private static int ParamType_Offset;

	private static FFieldAddress ParamType_PropertyAddress;

	private static bool ParameterName_IsValid;

	private static int ParameterName_Offset;

	private static bool FloatValue_IsValid;

	private static int FloatValue_Offset;

	private static bool VectorValue_IsValid;

	private static int VectorValue_Offset;

	private static bool LinearColorValue_IsValid;

	private static int LinearColorValue_Offset;

	private static bool FloatCurve_IsValid;

	private static int FloatCurve_Offset;

	private static bool VectorCurve_IsValid;

	private static int VectorCurve_Offset;

	private static bool LinearColorCurve_IsValid;

	private static int LinearColorCurve_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool CharacterInfoRefresh_IsValid;

	private static int CharacterInfoRefresh_Offset;

	private static FFieldAddress CharacterInfoRefresh_PropertyAddress;

	private static bool bUseScreenSpace_IsValid;

	private static int bUseScreenSpace_Offset;

	private static FFieldAddress bUseScreenSpace_PropertyAddress;

	private static bool bUseLastFrameValue_IsValid;

	private static int bUseLastFrameValue_Offset;

	private static FFieldAddress bUseLastFrameValue_PropertyAddress;

	public FMatParam Copy()
	{
		return this;
	}

	public static FMatParam FromNative(IntPtr nativeBuffer)
	{
		return new FMatParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMatParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMatParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMatParam(IntPtr.Add(nativeBuffer, arrayIndex * MatParam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMatParam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MatParam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MatParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatParam");
			return;
		}
		EnumMarshaler<EGSMatParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParameterName_Offset), ParameterName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FloatValue_Offset), FloatValue);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, VectorValue_Offset), VectorValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, LinearColorValue_Offset), LinearColorValue);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FloatCurve_Offset), FloatCurve);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, VectorCurve_Offset), VectorCurve);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, LinearColorCurve_Offset), LinearColorCurve);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CharacterInfoRefresh_Offset), 0, CharacterInfoRefresh_PropertyAddress.Address, CharacterInfoRefresh);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseScreenSpace_Offset), 0, bUseScreenSpace_PropertyAddress.Address, bUseScreenSpace);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseLastFrameValue_Offset), 0, bUseLastFrameValue_PropertyAddress.Address, bUseLastFrameValue);
	}

	public FMatParam(IntPtr nativeStruct)
	{
		if (MatParam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MatParam");
			ParamType = EGSMatParamType.None;
			ParameterName = default(FName);
			FloatValue = 0f;
			VectorValue = default(FVector);
			LinearColorValue = default(FLinearColor);
			FloatCurve = null;
			VectorCurve = null;
			LinearColorCurve = null;
			SocketName = default(FName);
			CharacterInfoRefresh = false;
			bUseScreenSpace = false;
			bUseLastFrameValue = false;
		}
		else
		{
			ParamType = EnumMarshaler<EGSMatParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			ParameterName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParameterName_Offset));
			FloatValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FloatValue_Offset));
			VectorValue = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, VectorValue_Offset));
			LinearColorValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, LinearColorValue_Offset));
			FloatCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FloatCurve_Offset));
			VectorCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, VectorCurve_Offset));
			LinearColorCurve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, LinearColorCurve_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
			CharacterInfoRefresh = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CharacterInfoRefresh_Offset), 0, CharacterInfoRefresh_PropertyAddress.Address);
			bUseScreenSpace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseScreenSpace_Offset), 0, bUseScreenSpace_PropertyAddress.Address);
			bUseLastFrameValue = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseLastFrameValue_Offset), 0, bUseLastFrameValue_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MatParam");
		MatParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		ParameterName_Offset = NativeReflection.GetPropertyOffset(intPtr, "ParameterName");
		ParameterName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ParameterName", Classes.FNameProperty);
		FloatValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatValue");
		FloatValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatValue", Classes.FFloatProperty);
		VectorValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "VectorValue");
		VectorValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VectorValue", Classes.FStructProperty);
		LinearColorValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "LinearColorValue");
		LinearColorValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LinearColorValue", Classes.FStructProperty);
		FloatCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "FloatCurve");
		FloatCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FloatCurve", Classes.FObjectProperty);
		VectorCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "VectorCurve");
		VectorCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VectorCurve", Classes.FObjectProperty);
		LinearColorCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "LinearColorCurve");
		LinearColorCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LinearColorCurve", Classes.FObjectProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref CharacterInfoRefresh_PropertyAddress, intPtr, "CharacterInfoRefresh");
		CharacterInfoRefresh_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterInfoRefresh");
		CharacterInfoRefresh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterInfoRefresh", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseScreenSpace_PropertyAddress, intPtr, "bUseScreenSpace");
		bUseScreenSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseScreenSpace");
		bUseScreenSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseScreenSpace", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseLastFrameValue_PropertyAddress, intPtr, "bUseLastFrameValue");
		bUseLastFrameValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseLastFrameValue");
		bUseLastFrameValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseLastFrameValue", Classes.FBoolProperty);
		MatParam_IsValid = ((intPtr != IntPtr.Zero && ParamType_IsValid && ParameterName_IsValid && FloatValue_IsValid && VectorValue_IsValid && LinearColorValue_IsValid && FloatCurve_IsValid && VectorCurve_IsValid && LinearColorCurve_IsValid && SocketName_IsValid && CharacterInfoRefresh_IsValid && bUseScreenSpace_IsValid && bUseLastFrameValue_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MatParam", (byte)MatParam_IsValid != 0);
	}

	static FMatParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMatParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMatParam));
	}
}
