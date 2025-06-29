using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ResourceID_PreloadOutlaws")]
public struct FResourceID_PreloadOutlaws
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ResourceID_PreloadOutlaws:Array")]
	public List<FResourceID_PreloadOutlaw> Array;

	private static int ResourceID_PreloadOutlaws_StructSize;

	private static int ResourceID_PreloadOutlaws_IsValid;

	private static bool Array_IsValid;

	private static int Array_Offset;

	private static FFieldAddress Array_PropertyAddress;

	public FResourceID_PreloadOutlaws Copy()
	{
		FResourceID_PreloadOutlaws result = this;
		if (Array != null)
		{
			result.Array = new List<FResourceID_PreloadOutlaw>(Array);
		}
		return result;
	}

	public static FResourceID_PreloadOutlaws FromNative(IntPtr nativeBuffer)
	{
		return new FResourceID_PreloadOutlaws(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FResourceID_PreloadOutlaws value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FResourceID_PreloadOutlaws FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FResourceID_PreloadOutlaws(IntPtr.Add(nativeBuffer, arrayIndex * ResourceID_PreloadOutlaws_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FResourceID_PreloadOutlaws value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ResourceID_PreloadOutlaws_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ResourceID_PreloadOutlaws_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ResourceID_PreloadOutlaws");
		}
		else
		{
			new TArrayCopyMarshaler<FResourceID_PreloadOutlaw>(1, Array_PropertyAddress, CachedMarshalingDelegates<FResourceID_PreloadOutlaw, FResourceID_PreloadOutlaw>.FromNative, CachedMarshalingDelegates<FResourceID_PreloadOutlaw, FResourceID_PreloadOutlaw>.ToNative).ToNative(IntPtr.Add(nativeStruct, Array_Offset), Array);
		}
	}

	public FResourceID_PreloadOutlaws(IntPtr nativeStruct)
	{
		if (ResourceID_PreloadOutlaws_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ResourceID_PreloadOutlaws");
			Array = null;
		}
		else
		{
			Array = new TArrayCopyMarshaler<FResourceID_PreloadOutlaw>(1, Array_PropertyAddress, CachedMarshalingDelegates<FResourceID_PreloadOutlaw, FResourceID_PreloadOutlaw>.FromNative, CachedMarshalingDelegates<FResourceID_PreloadOutlaw, FResourceID_PreloadOutlaw>.ToNative).FromNative(IntPtr.Add(nativeStruct, Array_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ResourceID_PreloadOutlaws");
		ResourceID_PreloadOutlaws_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Array_PropertyAddress, intPtr, "Array");
		Array_Offset = NativeReflection.GetPropertyOffset(intPtr, "Array");
		Array_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Array", Classes.FArrayProperty);
		ResourceID_PreloadOutlaws_IsValid = ((intPtr != IntPtr.Zero && Array_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ResourceID_PreloadOutlaws", (byte)ResourceID_PreloadOutlaws_IsValid != 0);
	}

	static FResourceID_PreloadOutlaws()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FResourceID_PreloadOutlaws)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FResourceID_PreloadOutlaws));
	}
}
