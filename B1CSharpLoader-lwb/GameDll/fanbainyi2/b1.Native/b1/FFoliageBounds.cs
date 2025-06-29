using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.FoliageBounds", "FuncLibEditor", UnrealModuleType.Game)]
public struct FFoliageBounds
{
	private static bool Bounds_IsValid;

	private static FFieldAddress Bounds_PropertyAddress;

	private static int Bounds_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.FoliageBounds:Bounds")]
	public List<FBoxSphereBounds> Bounds;

	private static bool FFoliageBounds_IsValid;

	private static int FFoliageBounds_StructSize;

	public FFoliageBounds Copy()
	{
		FFoliageBounds result = this;
		if (Bounds != null)
		{
			result.Bounds = new List<FBoxSphereBounds>(Bounds);
		}
		return result;
	}

	public static FFoliageBounds FromNative(IntPtr nativeBuffer)
	{
		return new FFoliageBounds(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFoliageBounds value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFoliageBounds FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFoliageBounds(nativeBuffer + arrayIndex * FFoliageBounds_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFoliageBounds value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFoliageBounds_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFoliageBounds_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageBounds");
		}
		else
		{
			new TArrayCopyMarshaler<FBoxSphereBounds>(1, Bounds_PropertyAddress, CachedMarshalingDelegates<FBoxSphereBounds, BlittableTypeMarshaler<FBoxSphereBounds>>.FromNative, CachedMarshalingDelegates<FBoxSphereBounds, BlittableTypeMarshaler<FBoxSphereBounds>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Bounds_Offset), Bounds);
		}
	}

	public FFoliageBounds(IntPtr nativeStruct)
	{
		if (!FFoliageBounds_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.FoliageBounds");
			Bounds = null;
		}
		else
		{
			Bounds = new TArrayCopyMarshaler<FBoxSphereBounds>(1, Bounds_PropertyAddress, CachedMarshalingDelegates<FBoxSphereBounds, BlittableTypeMarshaler<FBoxSphereBounds>>.FromNative, CachedMarshalingDelegates<FBoxSphereBounds, BlittableTypeMarshaler<FBoxSphereBounds>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Bounds_Offset));
		}
	}

	static FFoliageBounds()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFoliageBounds)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFoliageBounds));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.FoliageBounds");
		FFoliageBounds_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Bounds_PropertyAddress, intPtr, "Bounds");
		Bounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bounds");
		Bounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bounds", Classes.FArrayProperty);
		FFoliageBounds_IsValid = intPtr != IntPtr.Zero && Bounds_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.FoliageBounds", FFoliageBounds_IsValid);
	}
}
