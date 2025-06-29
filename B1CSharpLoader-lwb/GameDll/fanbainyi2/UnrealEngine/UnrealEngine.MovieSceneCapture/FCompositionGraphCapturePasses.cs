using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneCapture;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/MovieSceneCapture.CompositionGraphCapturePasses", "MovieSceneCapture", UnrealModuleType.Engine)]
public struct FCompositionGraphCapturePasses
{
	private static bool Value_IsValid;

	private static FFieldAddress Value_PropertyAddress;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/MovieSceneCapture.CompositionGraphCapturePasses:Value")]
	public List<string> Value;

	private static bool FCompositionGraphCapturePasses_IsValid;

	private static int FCompositionGraphCapturePasses_StructSize;

	public FCompositionGraphCapturePasses Copy()
	{
		FCompositionGraphCapturePasses result = this;
		if (Value != null)
		{
			result.Value = new List<string>(Value);
		}
		return result;
	}

	public static FCompositionGraphCapturePasses FromNative(IntPtr nativeBuffer)
	{
		return new FCompositionGraphCapturePasses(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCompositionGraphCapturePasses value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCompositionGraphCapturePasses FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCompositionGraphCapturePasses(nativeBuffer + arrayIndex * FCompositionGraphCapturePasses_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCompositionGraphCapturePasses value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCompositionGraphCapturePasses_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCompositionGraphCapturePasses_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CompositionGraphCapturePasses");
		}
		else
		{
			new TArrayCopyMarshaler<string>(1, Value_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		}
	}

	public FCompositionGraphCapturePasses(IntPtr nativeStruct)
	{
		if (!FCompositionGraphCapturePasses_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MovieSceneCapture.CompositionGraphCapturePasses");
			Value = null;
		}
		else
		{
			Value = new TArrayCopyMarshaler<string>(1, Value_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, Value_Offset));
		}
	}

	static FCompositionGraphCapturePasses()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCompositionGraphCapturePasses)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCompositionGraphCapturePasses));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MovieSceneCapture.CompositionGraphCapturePasses");
		FCompositionGraphCapturePasses_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Value_PropertyAddress, intPtr, "Value");
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FArrayProperty);
		FCompositionGraphCapturePasses_IsValid = intPtr != IntPtr.Zero && Value_IsValid;
		NativeReflection.LogStructIsValid("/Script/MovieSceneCapture.CompositionGraphCapturePasses", FCompositionGraphCapturePasses_IsValid);
	}
}
