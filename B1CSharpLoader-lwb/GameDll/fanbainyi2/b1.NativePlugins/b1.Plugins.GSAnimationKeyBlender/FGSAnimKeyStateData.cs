using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSAnimationKeyBlender;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateData", "GSAnimationKeyBlender", UnrealModuleType.GamePlugin)]
public struct FGSAnimKeyStateData
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

	private static bool StateName_IsValid;

	private static int StateName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/GSAnimationKeyBlender.GSAnimKeyStateData:StateName")]
	public FName StateName;

	private static bool FGSAnimKeyStateData_IsValid;

	private static int FGSAnimKeyStateData_StructSize;

	public FGSAnimKeyStateData Copy()
	{
		FGSAnimKeyStateData result = this;
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

	public static FGSAnimKeyStateData FromNative(IntPtr nativeBuffer)
	{
		return new FGSAnimKeyStateData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSAnimKeyStateData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSAnimKeyStateData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSAnimKeyStateData(nativeBuffer + arrayIndex * FGSAnimKeyStateData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSAnimKeyStateData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSAnimKeyStateData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSAnimKeyStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StateName_Offset), StateName);
		new TMapCopyMarshaler<string, FGSAKMatParamBool>(1, MatParamBoolMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.FromNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatParamBoolMap_Offset), MatParamBoolMap);
		new TMapCopyMarshaler<string, FGSAKMatParamScalar>(1, MatParamScalarMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.FromNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatParamScalarMap_Offset), MatParamScalarMap);
		new TMapCopyMarshaler<string, FGSAKMatParamVector4>(1, MatParamVector4Map_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.FromNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.ToNative).ToNative(IntPtr.Add(nativeStruct, MatParamVector4Map_Offset), MatParamVector4Map);
	}

	public FGSAnimKeyStateData(IntPtr nativeStruct)
	{
		if (!FGSAnimKeyStateData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSAnimationKeyBlender.GSAnimKeyStateData");
			StateName = default(FName);
			MatParamBoolMap = null;
			MatParamScalarMap = null;
			MatParamVector4Map = null;
		}
		else
		{
			StateName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StateName_Offset));
			MatParamBoolMap = new TMapCopyMarshaler<string, FGSAKMatParamBool>(1, MatParamBoolMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.FromNative, CachedMarshalingDelegates<FGSAKMatParamBool, FGSAKMatParamBool>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatParamBoolMap_Offset));
			MatParamScalarMap = new TMapCopyMarshaler<string, FGSAKMatParamScalar>(1, MatParamScalarMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.FromNative, CachedMarshalingDelegates<FGSAKMatParamScalar, FGSAKMatParamScalar>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatParamScalarMap_Offset));
			MatParamVector4Map = new TMapCopyMarshaler<string, FGSAKMatParamVector4>(1, MatParamVector4Map_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.FromNative, CachedMarshalingDelegates<FGSAKMatParamVector4, FGSAKMatParamVector4>.ToNative).FromNative(IntPtr.Add(nativeStruct, MatParamVector4Map_Offset));
		}
	}

	static FGSAnimKeyStateData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSAnimKeyStateData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSAnimKeyStateData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSAnimationKeyBlender.GSAnimKeyStateData");
		FGSAnimKeyStateData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MatParamBoolMap_PropertyAddress, intPtr, "MatParamBoolMap");
		MatParamBoolMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatParamBoolMap");
		MatParamBoolMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatParamBoolMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref MatParamScalarMap_PropertyAddress, intPtr, "MatParamScalarMap");
		MatParamScalarMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatParamScalarMap");
		MatParamScalarMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatParamScalarMap", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref MatParamVector4Map_PropertyAddress, intPtr, "MatParamVector4Map");
		MatParamVector4Map_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MatParamVector4Map");
		MatParamVector4Map_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MatParamVector4Map", Classes.FMapProperty);
		StateName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StateName");
		StateName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StateName", Classes.FNameProperty);
		FGSAnimKeyStateData_IsValid = intPtr != IntPtr.Zero && StateName_IsValid && MatParamBoolMap_IsValid && MatParamScalarMap_IsValid && MatParamVector4Map_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSAnimationKeyBlender.GSAnimKeyStateData", FGSAnimKeyStateData_IsValid);
	}
}
