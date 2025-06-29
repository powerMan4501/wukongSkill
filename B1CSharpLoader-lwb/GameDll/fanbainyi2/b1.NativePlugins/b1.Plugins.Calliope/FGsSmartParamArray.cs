using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.GsSmartParamArray", "Calliope", UnrealModuleType.GamePlugin)]
public struct FGsSmartParamArray
{
	private static bool ConfigGuides_IsValid;

	private static FFieldAddress ConfigGuides_PropertyAddress;

	private static int ConfigGuides_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.GsSmartParamArray:ConfigGuides")]
	public List<Guid> ConfigGuides;

	private static bool FGsSmartParamArray_IsValid;

	private static int FGsSmartParamArray_StructSize;

	public FGsSmartParamArray Copy()
	{
		FGsSmartParamArray result = this;
		if (ConfigGuides != null)
		{
			result.ConfigGuides = new List<Guid>(ConfigGuides);
		}
		return result;
	}

	public static FGsSmartParamArray FromNative(IntPtr nativeBuffer)
	{
		return new FGsSmartParamArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGsSmartParamArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGsSmartParamArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGsSmartParamArray(nativeBuffer + arrayIndex * FGsSmartParamArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGsSmartParamArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGsSmartParamArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGsSmartParamArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSmartParamArray");
		}
		else
		{
			new TArrayCopyMarshaler<Guid>(1, ConfigGuides_PropertyAddress, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.FromNative, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ConfigGuides_Offset), ConfigGuides);
		}
	}

	public FGsSmartParamArray(IntPtr nativeStruct)
	{
		if (!FGsSmartParamArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.GsSmartParamArray");
			ConfigGuides = null;
		}
		else
		{
			ConfigGuides = new TArrayCopyMarshaler<Guid>(1, ConfigGuides_PropertyAddress, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.FromNative, CachedMarshalingDelegates<Guid, BlittableTypeMarshaler<Guid>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ConfigGuides_Offset));
		}
	}

	static FGsSmartParamArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGsSmartParamArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGsSmartParamArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.GsSmartParamArray");
		FGsSmartParamArray_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ConfigGuides_PropertyAddress, intPtr, "ConfigGuides");
		ConfigGuides_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConfigGuides");
		ConfigGuides_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConfigGuides", Classes.FArrayProperty);
		FGsSmartParamArray_IsValid = intPtr != IntPtr.Zero && ConfigGuides_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.GsSmartParamArray", FGsSmartParamArray_IsValid);
	}
}
