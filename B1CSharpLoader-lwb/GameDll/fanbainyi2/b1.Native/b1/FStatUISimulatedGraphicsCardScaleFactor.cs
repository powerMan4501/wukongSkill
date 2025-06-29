using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor", "UnrealExtent", UnrealModuleType.Game)]
public struct FStatUISimulatedGraphicsCardScaleFactor
{
	private static bool GraphicsCard_IsValid;

	private static FFieldAddress GraphicsCard_PropertyAddress;

	private static int GraphicsCard_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor:GraphicsCard")]
	public EStatUISimulatedGraphicsCard GraphicsCard;

	private static bool PerformanceScaleFactorMap_IsValid;

	private static FFieldAddress PerformanceScaleFactorMap_PropertyAddress;

	private static int PerformanceScaleFactorMap_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor:PerformanceScaleFactorMap")]
	public Dictionary<string, float> PerformanceScaleFactorMap;

	private static bool FStatUISimulatedGraphicsCardScaleFactor_IsValid;

	private static int FStatUISimulatedGraphicsCardScaleFactor_StructSize;

	public FStatUISimulatedGraphicsCardScaleFactor Copy()
	{
		FStatUISimulatedGraphicsCardScaleFactor result = this;
		if (PerformanceScaleFactorMap != null)
		{
			result.PerformanceScaleFactorMap = new Dictionary<string, float>(PerformanceScaleFactorMap);
		}
		return result;
	}

	public static FStatUISimulatedGraphicsCardScaleFactor FromNative(IntPtr nativeBuffer)
	{
		return new FStatUISimulatedGraphicsCardScaleFactor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStatUISimulatedGraphicsCardScaleFactor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStatUISimulatedGraphicsCardScaleFactor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStatUISimulatedGraphicsCardScaleFactor(nativeBuffer + arrayIndex * FStatUISimulatedGraphicsCardScaleFactor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStatUISimulatedGraphicsCardScaleFactor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStatUISimulatedGraphicsCardScaleFactor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStatUISimulatedGraphicsCardScaleFactor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor");
			return;
		}
		EnumMarshaler<EStatUISimulatedGraphicsCard>.ToNative(IntPtr.Add(nativeStruct, GraphicsCard_Offset), 0, GraphicsCard_PropertyAddress.Address, GraphicsCard);
		new TMapCopyMarshaler<string, float>(1, PerformanceScaleFactorMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PerformanceScaleFactorMap_Offset), PerformanceScaleFactorMap);
	}

	public FStatUISimulatedGraphicsCardScaleFactor(IntPtr nativeStruct)
	{
		if (!FStatUISimulatedGraphicsCardScaleFactor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor");
			GraphicsCard = EStatUISimulatedGraphicsCard.GTX_1050Ti;
			PerformanceScaleFactorMap = null;
		}
		else
		{
			GraphicsCard = EnumMarshaler<EStatUISimulatedGraphicsCard>.FromNative(IntPtr.Add(nativeStruct, GraphicsCard_Offset), 0, GraphicsCard_PropertyAddress.Address);
			PerformanceScaleFactorMap = new TMapCopyMarshaler<string, float>(1, PerformanceScaleFactorMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PerformanceScaleFactorMap_Offset));
		}
	}

	static FStatUISimulatedGraphicsCardScaleFactor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStatUISimulatedGraphicsCardScaleFactor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStatUISimulatedGraphicsCardScaleFactor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor");
		FStatUISimulatedGraphicsCardScaleFactor_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref GraphicsCard_PropertyAddress, intPtr, "GraphicsCard");
		GraphicsCard_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GraphicsCard");
		GraphicsCard_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GraphicsCard", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformanceScaleFactorMap_PropertyAddress, intPtr, "PerformanceScaleFactorMap");
		PerformanceScaleFactorMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerformanceScaleFactorMap");
		PerformanceScaleFactorMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerformanceScaleFactorMap", Classes.FMapProperty);
		FStatUISimulatedGraphicsCardScaleFactor_IsValid = intPtr != IntPtr.Zero && GraphicsCard_IsValid && PerformanceScaleFactorMap_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.StatUISimulatedGraphicsCardScaleFactor", FStatUISimulatedGraphicsCardScaleFactor_IsValid);
	}
}
