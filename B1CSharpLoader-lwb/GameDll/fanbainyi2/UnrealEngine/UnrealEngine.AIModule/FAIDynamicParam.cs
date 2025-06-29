using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.AIDynamicParam", "AIModule", UnrealModuleType.Engine)]
public struct FAIDynamicParam
{
	private static bool ParamName_IsValid;

	private static int ParamName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/AIModule.AIDynamicParam:ParamName")]
	public FName ParamName;

	private static bool ParamType_IsValid;

	private static FFieldAddress ParamType_PropertyAddress;

	private static int ParamType_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/AIModule.AIDynamicParam:ParamType")]
	public EAIParamType ParamType;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AIDynamicParam:Value")]
	public float Value;

	private static bool BBKey_IsValid;

	private static int BBKey_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AIModule.AIDynamicParam:BBKey")]
	public FBlackboardKeySelector BBKey;

	private static bool FAIDynamicParam_IsValid;

	private static int FAIDynamicParam_StructSize;

	public FAIDynamicParam Copy()
	{
		return this;
	}

	public static FAIDynamicParam FromNative(IntPtr nativeBuffer)
	{
		return new FAIDynamicParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAIDynamicParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAIDynamicParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAIDynamicParam(nativeBuffer + arrayIndex * FAIDynamicParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAIDynamicParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAIDynamicParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAIDynamicParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIDynamicParam");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, ParamName_Offset), ParamName);
		EnumMarshaler<EAIParamType>.ToNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address, ParamType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		FBlackboardKeySelector.ToNative(IntPtr.Add(nativeStruct, BBKey_Offset), BBKey);
	}

	public FAIDynamicParam(IntPtr nativeStruct)
	{
		if (!FAIDynamicParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIDynamicParam");
			ParamName = default(FName);
			ParamType = EAIParamType.Float;
			Value = 0f;
			BBKey = default(FBlackboardKeySelector);
		}
		else
		{
			ParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, ParamName_Offset));
			ParamType = EnumMarshaler<EAIParamType>.FromNative(IntPtr.Add(nativeStruct, ParamType_Offset), 0, ParamType_PropertyAddress.Address);
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			BBKey = FBlackboardKeySelector.FromNative(IntPtr.Add(nativeStruct, BBKey_Offset));
		}
	}

	static FAIDynamicParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAIDynamicParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAIDynamicParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.AIDynamicParam");
		FAIDynamicParam_StructSize = NativeReflection.GetStructSize(intPtr);
		ParamName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamName");
		ParamName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ParamType_PropertyAddress, intPtr, "ParamType");
		ParamType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ParamType");
		ParamType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ParamType", Classes.FEnumProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		BBKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BBKey");
		BBKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BBKey", Classes.FStructProperty);
		FAIDynamicParam_IsValid = intPtr != IntPtr.Zero && ParamName_IsValid && ParamType_IsValid && Value_IsValid && BBKey_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.AIDynamicParam", FAIDynamicParam_IsValid);
	}
}
