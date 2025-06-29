using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.CapturedInfoArrayPerPoint", "UnrealExtent", UnrealModuleType.Game)]
public struct FCapturedInfoArrayPerPoint
{
	private static bool InfoMap_IsValid;

	private static FFieldAddress InfoMap_PropertyAddress;

	private static int InfoMap_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.CapturedInfoArrayPerPoint:InfoMap")]
	public Dictionary<string, FCapturedInfoSequencePerPoint> InfoMap;

	private static bool FCapturedInfoArrayPerPoint_IsValid;

	private static int FCapturedInfoArrayPerPoint_StructSize;

	public FCapturedInfoArrayPerPoint Copy()
	{
		FCapturedInfoArrayPerPoint result = this;
		if (InfoMap != null)
		{
			result.InfoMap = new Dictionary<string, FCapturedInfoSequencePerPoint>(InfoMap);
		}
		return result;
	}

	public static FCapturedInfoArrayPerPoint FromNative(IntPtr nativeBuffer)
	{
		return new FCapturedInfoArrayPerPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCapturedInfoArrayPerPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCapturedInfoArrayPerPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCapturedInfoArrayPerPoint(nativeBuffer + arrayIndex * FCapturedInfoArrayPerPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCapturedInfoArrayPerPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCapturedInfoArrayPerPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCapturedInfoArrayPerPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.CapturedInfoArrayPerPoint");
		}
		else
		{
			new TMapCopyMarshaler<string, FCapturedInfoSequencePerPoint>(1, InfoMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FCapturedInfoSequencePerPoint, FCapturedInfoSequencePerPoint>.FromNative, CachedMarshalingDelegates<FCapturedInfoSequencePerPoint, FCapturedInfoSequencePerPoint>.ToNative).ToNative(IntPtr.Add(nativeStruct, InfoMap_Offset), InfoMap);
		}
	}

	public FCapturedInfoArrayPerPoint(IntPtr nativeStruct)
	{
		if (!FCapturedInfoArrayPerPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.CapturedInfoArrayPerPoint");
			InfoMap = null;
		}
		else
		{
			InfoMap = new TMapCopyMarshaler<string, FCapturedInfoSequencePerPoint>(1, InfoMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FCapturedInfoSequencePerPoint, FCapturedInfoSequencePerPoint>.FromNative, CachedMarshalingDelegates<FCapturedInfoSequencePerPoint, FCapturedInfoSequencePerPoint>.ToNative).FromNative(IntPtr.Add(nativeStruct, InfoMap_Offset));
		}
	}

	static FCapturedInfoArrayPerPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCapturedInfoArrayPerPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCapturedInfoArrayPerPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.CapturedInfoArrayPerPoint");
		FCapturedInfoArrayPerPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref InfoMap_PropertyAddress, intPtr, "InfoMap");
		InfoMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InfoMap");
		InfoMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InfoMap", Classes.FMapProperty);
		FCapturedInfoArrayPerPoint_IsValid = intPtr != IntPtr.Zero && InfoMap_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.CapturedInfoArrayPerPoint", FCapturedInfoArrayPerPoint_IsValid);
	}
}
