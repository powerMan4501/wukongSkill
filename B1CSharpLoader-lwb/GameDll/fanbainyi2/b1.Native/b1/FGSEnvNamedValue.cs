using System;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSEnvNamedValue", "b1", UnrealModuleType.Game)]
public struct FGSEnvNamedValue
{
	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEnvNamedValue:ParamName")]
	public FName ParamName;

	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEnvNamedValue:ParamType")]
	public EAIParamType ParamType;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEnvNamedValue:Value")]
	public float Value;

	private static bool FGSEnvNamedValue_IsValid;

	private static int FGSEnvNamedValue_StructSize;

	public FGSEnvNamedValue Copy()
	{
		return this;
	}

	public static FGSEnvNamedValue FromNative(IntPtr nativeBuffer)
	{
		return new FGSEnvNamedValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSEnvNamedValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSEnvNamedValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSEnvNamedValue(nativeBuffer + arrayIndex * FGSEnvNamedValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSEnvNamedValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSEnvNamedValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSEnvNamedValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSEnvNamedValue");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		EnumMarshaler<EAIParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FGSEnvNamedValue(IntPtr nativeStruct)
	{
		if (!FGSEnvNamedValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSEnvNamedValue");
			ParamName = default(FName);
			ParamType = EAIParamType.Float;
			Value = 0f;
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ParamType = EnumMarshaler<EAIParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FGSEnvNamedValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSEnvNamedValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSEnvNamedValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSEnvNamedValue");
		FGSEnvNamedValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FGSEnvNamedValue_IsValid = intPtr != IntPtr.Zero && ParamName_IsValid && ParamType_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSEnvNamedValue", FGSEnvNamedValue_IsValid);
	}
}
