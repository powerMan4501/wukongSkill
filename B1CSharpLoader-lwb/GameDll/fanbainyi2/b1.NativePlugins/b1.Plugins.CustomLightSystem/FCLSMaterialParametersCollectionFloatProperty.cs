using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSMaterialParametersCollectionFloatProperty
{
	private static bool MaterialParameter_IsValid;

	private static int MaterialParameter_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty:MaterialParameter")]
	public string MaterialParameter;

	private static bool FValue_IsValid;

	private static int FValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty:FValue")]
	public float FValue;

	private static bool FCLSMaterialParametersCollectionFloatProperty_IsValid;

	private static int FCLSMaterialParametersCollectionFloatProperty_StructSize;

	public FCLSMaterialParametersCollectionFloatProperty Copy()
	{
		return this;
	}

	public static FCLSMaterialParametersCollectionFloatProperty FromNative(IntPtr nativeBuffer)
	{
		return new FCLSMaterialParametersCollectionFloatProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSMaterialParametersCollectionFloatProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSMaterialParametersCollectionFloatProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSMaterialParametersCollectionFloatProperty(nativeBuffer + arrayIndex * FCLSMaterialParametersCollectionFloatProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSMaterialParametersCollectionFloatProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSMaterialParametersCollectionFloatProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSMaterialParametersCollectionFloatProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MaterialParameter_Offset), MaterialParameter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FValue_Offset), FValue);
	}

	public FCLSMaterialParametersCollectionFloatProperty(IntPtr nativeStruct)
	{
		if (!FCLSMaterialParametersCollectionFloatProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty");
			MaterialParameter = FStringMarshaler.DefaultString;
			FValue = 0f;
		}
		else
		{
			MaterialParameter = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MaterialParameter_Offset));
			FValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FValue_Offset));
		}
	}

	static FCLSMaterialParametersCollectionFloatProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSMaterialParametersCollectionFloatProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSMaterialParametersCollectionFloatProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty");
		FCLSMaterialParametersCollectionFloatProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		MaterialParameter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialParameter");
		MaterialParameter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialParameter", Classes.FStrProperty);
		FValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FValue");
		FValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FValue", Classes.FFloatProperty);
		FCLSMaterialParametersCollectionFloatProperty_IsValid = intPtr != IntPtr.Zero && MaterialParameter_IsValid && FValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSMaterialParametersCollectionFloatProperty", FCLSMaterialParametersCollectionFloatProperty_IsValid);
	}
}
