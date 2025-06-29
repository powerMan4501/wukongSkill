using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.CapturedInfoSequencePerPoint", "UnrealExtent", UnrealModuleType.Game)]
public struct FCapturedInfoSequencePerPoint
{
	private static bool CapturedInfoSequencePerPoint_IsValid;

	private static FFieldAddress CapturedInfoSequencePerPoint_PropertyAddress;

	private static int CapturedInfoSequencePerPoint_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.CapturedInfoSequencePerPoint:CapturedInfoSequencePerPoint")]
	public List<float> CapturedInfoSequencePerPoint;

	private static bool StatType_IsValid;

	private static FFieldAddress StatType_PropertyAddress;

	private static int StatType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.CapturedInfoSequencePerPoint:StatType")]
	public EGSCapturedStatType StatType;

	private static bool FCapturedInfoSequencePerPoint_IsValid;

	private static int FCapturedInfoSequencePerPoint_StructSize;

	public FCapturedInfoSequencePerPoint Copy()
	{
		FCapturedInfoSequencePerPoint result = this;
		if (CapturedInfoSequencePerPoint != null)
		{
			result.CapturedInfoSequencePerPoint = new List<float>(CapturedInfoSequencePerPoint);
		}
		return result;
	}

	public static FCapturedInfoSequencePerPoint FromNative(IntPtr nativeBuffer)
	{
		return new FCapturedInfoSequencePerPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCapturedInfoSequencePerPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCapturedInfoSequencePerPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCapturedInfoSequencePerPoint(nativeBuffer + arrayIndex * FCapturedInfoSequencePerPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCapturedInfoSequencePerPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCapturedInfoSequencePerPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCapturedInfoSequencePerPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.CapturedInfoSequencePerPoint");
			return;
		}
		new TArrayCopyMarshaler<float>(1, CapturedInfoSequencePerPoint_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CapturedInfoSequencePerPoint_Offset), CapturedInfoSequencePerPoint);
		EnumMarshaler<EGSCapturedStatType>.ToNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address, StatType);
	}

	public FCapturedInfoSequencePerPoint(IntPtr nativeStruct)
	{
		if (!FCapturedInfoSequencePerPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.CapturedInfoSequencePerPoint");
			CapturedInfoSequencePerPoint = null;
			StatType = EGSCapturedStatType.NONE;
		}
		else
		{
			CapturedInfoSequencePerPoint = new TArrayCopyMarshaler<float>(1, CapturedInfoSequencePerPoint_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CapturedInfoSequencePerPoint_Offset));
			StatType = EnumMarshaler<EGSCapturedStatType>.FromNative(IntPtr.Add(nativeStruct, StatType_Offset), 0, StatType_PropertyAddress.Address);
		}
	}

	static FCapturedInfoSequencePerPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCapturedInfoSequencePerPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCapturedInfoSequencePerPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.CapturedInfoSequencePerPoint");
		FCapturedInfoSequencePerPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CapturedInfoSequencePerPoint_PropertyAddress, intPtr, "CapturedInfoSequencePerPoint");
		CapturedInfoSequencePerPoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CapturedInfoSequencePerPoint");
		CapturedInfoSequencePerPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CapturedInfoSequencePerPoint", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StatType_PropertyAddress, intPtr, "StatType");
		StatType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatType");
		StatType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatType", Classes.FEnumProperty);
		FCapturedInfoSequencePerPoint_IsValid = intPtr != IntPtr.Zero && CapturedInfoSequencePerPoint_IsValid && StatType_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.CapturedInfoSequencePerPoint", FCapturedInfoSequencePerPoint_IsValid);
	}
}
