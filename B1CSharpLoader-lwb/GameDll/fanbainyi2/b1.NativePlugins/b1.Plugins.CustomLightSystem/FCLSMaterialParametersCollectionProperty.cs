using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSMaterialParametersCollectionProperty
{
	private static bool MaterialParametersCollectionFloatProperty_IsValid;

	private static FFieldAddress MaterialParametersCollectionFloatProperty_PropertyAddress;

	private static int MaterialParametersCollectionFloatProperty_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty:MaterialParametersCollectionFloatProperty")]
	public List<FCLSMaterialParametersCollectionFloatProperty> MaterialParametersCollectionFloatProperty;

	private static bool MaterialParametersCollectionVectorProperty_IsValid;

	private static FFieldAddress MaterialParametersCollectionVectorProperty_PropertyAddress;

	private static int MaterialParametersCollectionVectorProperty_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty:MaterialParametersCollectionVectorProperty")]
	public List<FCLSMaterialParametersCollectionVectorProperty> MaterialParametersCollectionVectorProperty;

	private static bool FCLSMaterialParametersCollectionProperty_IsValid;

	private static int FCLSMaterialParametersCollectionProperty_StructSize;

	public FCLSMaterialParametersCollectionProperty Copy()
	{
		FCLSMaterialParametersCollectionProperty result = this;
		if (MaterialParametersCollectionFloatProperty != null)
		{
			result.MaterialParametersCollectionFloatProperty = new List<FCLSMaterialParametersCollectionFloatProperty>(MaterialParametersCollectionFloatProperty);
		}
		if (MaterialParametersCollectionVectorProperty != null)
		{
			result.MaterialParametersCollectionVectorProperty = new List<FCLSMaterialParametersCollectionVectorProperty>(MaterialParametersCollectionVectorProperty);
		}
		return result;
	}

	public static FCLSMaterialParametersCollectionProperty FromNative(IntPtr nativeBuffer)
	{
		return new FCLSMaterialParametersCollectionProperty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSMaterialParametersCollectionProperty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSMaterialParametersCollectionProperty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSMaterialParametersCollectionProperty(nativeBuffer + arrayIndex * FCLSMaterialParametersCollectionProperty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSMaterialParametersCollectionProperty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSMaterialParametersCollectionProperty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSMaterialParametersCollectionProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty");
			return;
		}
		new TArrayCopyMarshaler<FCLSMaterialParametersCollectionFloatProperty>(1, MaterialParametersCollectionFloatProperty_PropertyAddress, CachedMarshalingDelegates<FCLSMaterialParametersCollectionFloatProperty, FCLSMaterialParametersCollectionFloatProperty>.FromNative, CachedMarshalingDelegates<FCLSMaterialParametersCollectionFloatProperty, FCLSMaterialParametersCollectionFloatProperty>.ToNative).ToNative(IntPtr.Add(nativeStruct, MaterialParametersCollectionFloatProperty_Offset), MaterialParametersCollectionFloatProperty);
		new TArrayCopyMarshaler<FCLSMaterialParametersCollectionVectorProperty>(1, MaterialParametersCollectionVectorProperty_PropertyAddress, CachedMarshalingDelegates<FCLSMaterialParametersCollectionVectorProperty, FCLSMaterialParametersCollectionVectorProperty>.FromNative, CachedMarshalingDelegates<FCLSMaterialParametersCollectionVectorProperty, FCLSMaterialParametersCollectionVectorProperty>.ToNative).ToNative(IntPtr.Add(nativeStruct, MaterialParametersCollectionVectorProperty_Offset), MaterialParametersCollectionVectorProperty);
	}

	public FCLSMaterialParametersCollectionProperty(IntPtr nativeStruct)
	{
		if (!FCLSMaterialParametersCollectionProperty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty");
			MaterialParametersCollectionFloatProperty = null;
			MaterialParametersCollectionVectorProperty = null;
		}
		else
		{
			MaterialParametersCollectionFloatProperty = new TArrayCopyMarshaler<FCLSMaterialParametersCollectionFloatProperty>(1, MaterialParametersCollectionFloatProperty_PropertyAddress, CachedMarshalingDelegates<FCLSMaterialParametersCollectionFloatProperty, FCLSMaterialParametersCollectionFloatProperty>.FromNative, CachedMarshalingDelegates<FCLSMaterialParametersCollectionFloatProperty, FCLSMaterialParametersCollectionFloatProperty>.ToNative).FromNative(IntPtr.Add(nativeStruct, MaterialParametersCollectionFloatProperty_Offset));
			MaterialParametersCollectionVectorProperty = new TArrayCopyMarshaler<FCLSMaterialParametersCollectionVectorProperty>(1, MaterialParametersCollectionVectorProperty_PropertyAddress, CachedMarshalingDelegates<FCLSMaterialParametersCollectionVectorProperty, FCLSMaterialParametersCollectionVectorProperty>.FromNative, CachedMarshalingDelegates<FCLSMaterialParametersCollectionVectorProperty, FCLSMaterialParametersCollectionVectorProperty>.ToNative).FromNative(IntPtr.Add(nativeStruct, MaterialParametersCollectionVectorProperty_Offset));
		}
	}

	static FCLSMaterialParametersCollectionProperty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSMaterialParametersCollectionProperty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSMaterialParametersCollectionProperty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty");
		FCLSMaterialParametersCollectionProperty_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MaterialParametersCollectionFloatProperty_PropertyAddress, intPtr, "MaterialParametersCollectionFloatProperty");
		MaterialParametersCollectionFloatProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialParametersCollectionFloatProperty");
		MaterialParametersCollectionFloatProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialParametersCollectionFloatProperty", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialParametersCollectionVectorProperty_PropertyAddress, intPtr, "MaterialParametersCollectionVectorProperty");
		MaterialParametersCollectionVectorProperty_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialParametersCollectionVectorProperty");
		MaterialParametersCollectionVectorProperty_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialParametersCollectionVectorProperty", Classes.FArrayProperty);
		FCLSMaterialParametersCollectionProperty_IsValid = intPtr != IntPtr.Zero && MaterialParametersCollectionFloatProperty_IsValid && MaterialParametersCollectionVectorProperty_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSMaterialParametersCollectionProperty", FCLSMaterialParametersCollectionProperty_IsValid);
	}
}
