using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.CachedAnimStateArray", "Engine", UnrealModuleType.Engine)]
public struct FCachedAnimStateArray
{
	private static bool States_IsValid;

	private static FFieldAddress States_PropertyAddress;

	private static int States_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.CachedAnimStateArray:States")]
	public List<FCachedAnimStateData> States;

	private static bool FCachedAnimStateArray_IsValid;

	private static int FCachedAnimStateArray_StructSize;

	public FCachedAnimStateArray Copy()
	{
		FCachedAnimStateArray result = this;
		if (States != null)
		{
			result.States = new List<FCachedAnimStateData>(States);
		}
		return result;
	}

	public static FCachedAnimStateArray FromNative(IntPtr nativeBuffer)
	{
		return new FCachedAnimStateArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCachedAnimStateArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCachedAnimStateArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCachedAnimStateArray(nativeBuffer + arrayIndex * FCachedAnimStateArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCachedAnimStateArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCachedAnimStateArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCachedAnimStateArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimStateArray");
		}
		else
		{
			new TArrayCopyMarshaler<FCachedAnimStateData>(1, States_PropertyAddress, CachedMarshalingDelegates<FCachedAnimStateData, FCachedAnimStateData>.FromNative, CachedMarshalingDelegates<FCachedAnimStateData, FCachedAnimStateData>.ToNative).ToNative(IntPtr.Add(nativeStruct, States_Offset), States);
		}
	}

	public FCachedAnimStateArray(IntPtr nativeStruct)
	{
		if (!FCachedAnimStateArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.CachedAnimStateArray");
			States = null;
		}
		else
		{
			States = new TArrayCopyMarshaler<FCachedAnimStateData>(1, States_PropertyAddress, CachedMarshalingDelegates<FCachedAnimStateData, FCachedAnimStateData>.FromNative, CachedMarshalingDelegates<FCachedAnimStateData, FCachedAnimStateData>.ToNative).FromNative(IntPtr.Add(nativeStruct, States_Offset));
		}
	}

	static FCachedAnimStateArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCachedAnimStateArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCachedAnimStateArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.CachedAnimStateArray");
		FCachedAnimStateArray_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref States_PropertyAddress, intPtr, "States");
		States_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "States");
		States_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "States", Classes.FArrayProperty);
		FCachedAnimStateArray_IsValid = intPtr != IntPtr.Zero && States_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.CachedAnimStateArray", FCachedAnimStateArray_IsValid);
	}
}
