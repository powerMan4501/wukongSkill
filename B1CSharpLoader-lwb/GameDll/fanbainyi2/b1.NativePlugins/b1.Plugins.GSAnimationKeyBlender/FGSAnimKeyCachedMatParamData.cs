using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAnimKeyCachedMatParamData
{
	private static bool MatParamBoolMap_IsValid;

	private static FFieldAddress MatParamBoolMap_PropertyAddress;

	private static int MatParamBoolMap_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData:MatParamBoolMap")]
	public Dictionary<string, FGSAKMatParamBool> MatParamBoolMap;

	private static bool MatParamScalarMap_IsValid;

	private static FFieldAddress MatParamScalarMap_PropertyAddress;

	private static int MatParamScalarMap_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData:MatParamScalarMap")]
	public Dictionary<string, FGSAKMatParamScalar> MatParamScalarMap;

	private static bool MatParamVector4Map_IsValid;

	private static FFieldAddress MatParamVector4Map_PropertyAddress;

	private static int MatParamVector4Map_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData:MatParamVector4Map")]
	public Dictionary<string, FGSAKMatParamVector4> MatParamVector4Map;

	private static bool FGSAnimKeyCachedMatParamData_IsValid;

	private static int FGSAnimKeyCachedMatParamData_StructSize;

	public FGSAnimKeyCachedMatParamData Copy()
	{
		FGSAnimKeyCachedMatParamData result = this;
		if (MatParamBoolMap != null)
		{
			result.MatParamBoolMap = new Dictionary<string, FGSAKMatParamBool>(MatParamBoolMap);
		}
		if (MatParamScalarMap != null)
		{
			result.MatParamScalarMap = new Dictionary<string, FGSAKMatParamScalar>(MatParamScalarMap);
		}
		if (MatParamVector4Map != null)
		{
			result.MatParamVector4Map = new Dictionary<string, FGSAKMatParamVector4>(MatParamVector4Map);
		}
		return result;
	}

	public static FGSAnimKeyCachedMatParamData FromNative(IntPtr nativeBuffer)
	{
		return new FGSAnimKeyCachedMatParamData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAnimKeyCachedMatParamData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAnimKeyCachedMatParamData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAnimKeyCachedMatParamData(nativeBuffer + arrayIndex * FGSAnimKeyCachedMatParamData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAnimKeyCachedMatParamData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAnimKeyCachedMatParamData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAnimKeyCachedMatParamData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData");
			return;
		}
		new TMapCopyMarshaler<string, FGSAKMatParamBool>(1, MatParamBoolMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.FromNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatParamBoolMap_Offset), MatParamBoolMap);
		new TMapCopyMarshaler<string, FGSAKMatParamScalar>(1, MatParamScalarMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.FromNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatParamScalarMap_Offset), MatParamScalarMap);
		new TMapCopyMarshaler<string, FGSAKMatParamVector4>(1, MatParamVector4Map_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.FromNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatParamVector4Map_Offset), MatParamVector4Map);
	}

	public FGSAnimKeyCachedMatParamData(IntPtr nativeStruct)
	{
		if (!FGSAnimKeyCachedMatParamData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData");
			MatParamBoolMap = null;
			MatParamScalarMap = null;
			MatParamVector4Map = null;
		}
		else
		{
			MatParamBoolMap = new TMapCopyMarshaler<string, FGSAKMatParamBool>(1, MatParamBoolMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.FromNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatParamBoolMap_Offset));
			MatParamScalarMap = new TMapCopyMarshaler<string, FGSAKMatParamScalar>(1, MatParamScalarMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.FromNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatParamScalarMap_Offset));
			MatParamVector4Map = new TMapCopyMarshaler<string, FGSAKMatParamVector4>(1, MatParamVector4Map_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.FromNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatParamVector4Map_Offset));
		}
	}

	static FGSAnimKeyCachedMatParamData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAnimKeyCachedMatParamData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAnimKeyCachedMatParamData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData");
		FGSAnimKeyCachedMatParamData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MatParamBoolMap_PropertyAddress, intPtr, "MatParamBoolMap");
		MatParamBoolMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatParamBoolMap");
		MatParamBoolMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatParamBoolMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref MatParamScalarMap_PropertyAddress, intPtr, "MatParamScalarMap");
		MatParamScalarMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatParamScalarMap");
		MatParamScalarMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatParamScalarMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref MatParamVector4Map_PropertyAddress, intPtr, "MatParamVector4Map");
		MatParamVector4Map_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatParamVector4Map");
		MatParamVector4Map_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatParamVector4Map", Classes.FMapProperty);
		FGSAnimKeyCachedMatParamData_IsValid = intPtr != IntPtr.Zero && MatParamBoolMap_IsValid && MatParamScalarMap_IsValid && MatParamVector4Map_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyCachedMatParamData", FGSAnimKeyCachedMatParamData_IsValid);
	}
}
