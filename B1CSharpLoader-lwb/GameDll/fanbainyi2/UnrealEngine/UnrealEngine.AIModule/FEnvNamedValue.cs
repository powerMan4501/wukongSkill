using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.EnvNamedValue", "AIModule", UnrealModuleType.Engine)]
public struct FEnvNamedValue
{
	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.EnvNamedValue:ParamName")]
	public FName ParamName;

	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.EnvNamedValue:ParamType")]
	public EAIParamType ParamType;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.EnvNamedValue:Value")]
	public float Value;

	private static bool FEnvNamedValue_IsValid;

	private static int FEnvNamedValue_StructSize;

	public FEnvNamedValue Copy()
	{
		return this;
	}

	public static FEnvNamedValue FromNative(IntPtr nativeBuffer)
	{
		return new FEnvNamedValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEnvNamedValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEnvNamedValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEnvNamedValue(nativeBuffer + arrayIndex * FEnvNamedValue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEnvNamedValue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEnvNamedValue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEnvNamedValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.EnvNamedValue");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		EnumMarshaler<EAIParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
	}

	public FEnvNamedValue(IntPtr nativeStruct)
	{
		if (!FEnvNamedValue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.EnvNamedValue");
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

	static FEnvNamedValue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEnvNamedValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEnvNamedValue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.EnvNamedValue");
		FEnvNamedValue_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		FEnvNamedValue_IsValid = intPtr != IntPtr.Zero && ParamName_IsValid && ParamType_IsValid && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.EnvNamedValue", FEnvNamedValue_IsValid);
	}
}
