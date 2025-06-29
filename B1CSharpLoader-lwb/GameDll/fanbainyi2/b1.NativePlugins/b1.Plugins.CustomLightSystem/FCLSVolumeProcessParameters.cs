using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSVolumeProcessParameters", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSVolumeProcessParameters
{
	private static bool CommandLines_IsValid;

	private static FFieldAddress CommandLines_PropertyAddress;

	private static int CommandLines_Offset;

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSVolumeProcessParameters:CommandLines")]
	public List<string> CommandLines;

	private static bool FCLSVolumeProcessParameters_IsValid;

	private static int FCLSVolumeProcessParameters_StructSize;

	public FCLSVolumeProcessParameters Copy()
	{
		FCLSVolumeProcessParameters result = this;
		if (CommandLines != null)
		{
			result.CommandLines = new List<string>(CommandLines);
		}
		return result;
	}

	public static FCLSVolumeProcessParameters FromNative(IntPtr nativeBuffer)
	{
		return new FCLSVolumeProcessParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSVolumeProcessParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSVolumeProcessParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSVolumeProcessParameters(nativeBuffer + arrayIndex * FCLSVolumeProcessParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSVolumeProcessParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSVolumeProcessParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSVolumeProcessParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSVolumeProcessParameters");
		}
		else
		{
			new TArrayCopyMarshaler<string>(1, CommandLines_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, CommandLines_Offset), CommandLines);
		}
	}

	public FCLSVolumeProcessParameters(IntPtr nativeStruct)
	{
		if (!FCLSVolumeProcessParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSVolumeProcessParameters");
			CommandLines = null;
		}
		else
		{
			CommandLines = new TArrayCopyMarshaler<string>(1, CommandLines_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, CommandLines_Offset));
		}
	}

	static FCLSVolumeProcessParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSVolumeProcessParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSVolumeProcessParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSVolumeProcessParameters");
		FCLSVolumeProcessParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CommandLines_PropertyAddress, intPtr, "CommandLines");
		CommandLines_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CommandLines");
		CommandLines_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CommandLines", Classes.FArrayProperty);
		FCLSVolumeProcessParameters_IsValid = intPtr != IntPtr.Zero && CommandLines_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSVolumeProcessParameters", FCLSVolumeProcessParameters_IsValid);
	}
}
