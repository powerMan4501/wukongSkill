using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSMaterialParametersCollectionVectorProperty
{
	private static bool MaterialParameter_IsValid;

	private static int MaterialParameter_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty:MaterialParameter")]
	public string MaterialParameter;

	private static bool FValue_IsValid;

	private static int FValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty:FValue")]
	public FLinearColor FValue;

	private static bool FCLSMaterialParametersCollectionVectorProperty_IsValid;

	private static int FCLSMaterialParametersCollectionVectorProperty_StructSize;

	public FCLSMaterialParametersCollectionVectorProperty Copy()
	{
		return this;
	}

	public static FCLSMaterialParametersCollectionVectorProperty FromNative(IntPtr nativeBuffer)
	{
		return new FCLSMaterialParametersCollectionVectorProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSMaterialParametersCollectionVectorProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSMaterialParametersCollectionVectorProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSMaterialParametersCollectionVectorProperty(nativeBuffer + arrayIndex * FCLSMaterialParametersCollectionVectorProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSMaterialParametersCollectionVectorProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSMaterialParametersCollectionVectorProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSMaterialParametersCollectionVectorProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MaterialParameter_Offset), MaterialParameter);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FValue_Offset), FValue);
	}

	public FCLSMaterialParametersCollectionVectorProperty(IntPtr nativeStruct)
	{
		if (!FCLSMaterialParametersCollectionVectorProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty");
			MaterialParameter = FStringMarshaler.DefaultString;
			FValue = default(FLinearColor);
		}
		else
		{
			MaterialParameter = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MaterialParameter_Offset));
			FValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FValue_Offset));
		}
	}

	static FCLSMaterialParametersCollectionVectorProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSMaterialParametersCollectionVectorProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSMaterialParametersCollectionVectorProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty");
		FCLSMaterialParametersCollectionVectorProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		MaterialParameter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialParameter");
		MaterialParameter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialParameter", Classes.FStrProperty);
		FValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FValue");
		FValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FValue", Classes.FStructProperty);
		FCLSMaterialParametersCollectionVectorProperty_IsValid = intPtr != IntPtr.Zero && MaterialParameter_IsValid && FValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSMaterialParametersCollectionVectorProperty", FCLSMaterialParametersCollectionVectorProperty_IsValid);
	}
}
