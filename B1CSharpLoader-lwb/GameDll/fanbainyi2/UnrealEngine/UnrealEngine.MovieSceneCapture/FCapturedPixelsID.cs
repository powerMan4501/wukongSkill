using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.CapturedPixelsID", "MovieSceneCapture", UnrealModuleType.Engine)]
public struct FCapturedPixelsID
{
	private static bool Identifiers_IsValid;

	private static FFieldAddress Identifiers_PropertyAddress;

	private static int Identifiers_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/MovieSceneCapture.CapturedPixelsID:Identifiers")]
	public Dictionary<FName, FName> Identifiers;

	private static bool FCapturedPixelsID_IsValid;

	private static int FCapturedPixelsID_StructSize;

	public FCapturedPixelsID Copy()
	{
		FCapturedPixelsID result = this;
		if (Identifiers != null)
		{
			result.Identifiers = new Dictionary<FName, FName>(Identifiers);
		}
		return result;
	}

	public static FCapturedPixelsID FromNative(IntPtr nativeBuffer)
	{
		return new FCapturedPixelsID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCapturedPixelsID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCapturedPixelsID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCapturedPixelsID(nativeBuffer + arrayIndex * FCapturedPixelsID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCapturedPixelsID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCapturedPixelsID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCapturedPixelsID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CapturedPixelsID");
		}
		else
		{
			new TMapCopyMarshaler<FName, FName>(1, Identifiers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Identifiers_Offset), Identifiers);
		}
	}

	public FCapturedPixelsID(IntPtr nativeStruct)
	{
		if (!FCapturedPixelsID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CapturedPixelsID");
			Identifiers = null;
		}
		else
		{
			Identifiers = new TMapCopyMarshaler<FName, FName>(1, Identifiers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Identifiers_Offset));
		}
	}

	static FCapturedPixelsID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCapturedPixelsID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCapturedPixelsID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneCapture.CapturedPixelsID");
		FCapturedPixelsID_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Identifiers_PropertyAddress, intPtr, "Identifiers");
		Identifiers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifiers");
		Identifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifiers", Classes.FMapProperty);
		FCapturedPixelsID_IsValid = intPtr != IntPtr.Zero && Identifiers_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneCapture.CapturedPixelsID", FCapturedPixelsID_IsValid);
	}
}
