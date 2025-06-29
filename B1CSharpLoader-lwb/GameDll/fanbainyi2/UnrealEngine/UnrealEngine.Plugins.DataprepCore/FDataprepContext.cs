using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DataprepCore.DataprepContext", "DataprepCore", UnrealModuleType.EnginePlugin)]
public struct FDataprepContext
{
	private static bool Objects_IsValid;

	private static FFieldAddress Objects_PropertyAddress;

	private static int Objects_Offset;

	[UProperty(Flags = (PropFlags)4503599627371028uL)]
	[UMetaPath("/Script/DataprepCore.DataprepContext:Objects")]
	public List<UObject> Objects;

	private static bool FDataprepContext_IsValid;

	private static int FDataprepContext_StructSize;

	public FDataprepContext Copy()
	{
		FDataprepContext result = this;
		if (Objects != null)
		{
			result.Objects = new List<UObject>(Objects);
		}
		return result;
	}

	public static FDataprepContext FromNative(IntPtr nativeBuffer)
	{
		return new FDataprepContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDataprepContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDataprepContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDataprepContext(nativeBuffer + arrayIndex * FDataprepContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDataprepContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDataprepContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDataprepContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepCore.DataprepContext");
		}
		else
		{
			new TArrayCopyMarshaler<UObject>(1, Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Objects_Offset), Objects);
		}
	}

	public FDataprepContext(IntPtr nativeStruct)
	{
		if (!FDataprepContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DataprepCore.DataprepContext");
			Objects = null;
		}
		else
		{
			Objects = new TArrayCopyMarshaler<UObject>(1, Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Objects_Offset));
		}
	}

	static FDataprepContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDataprepContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDataprepContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DataprepCore.DataprepContext");
		FDataprepContext_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Objects_PropertyAddress, intPtr, "Objects");
		Objects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Objects");
		Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Objects", Classes.FArrayProperty);
		FDataprepContext_IsValid = intPtr != IntPtr.Zero && Objects_IsValid;
		NativeReflection.LogStructIsValid("/Script/DataprepCore.DataprepContext", FDataprepContext_IsValid);
	}
}
