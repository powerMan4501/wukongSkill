using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIndexList", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptIndexList
{
	private static bool IndexType_IsValid;

	private static FFieldAddress IndexType_PropertyAddress;

	private static int IndexType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIndexList:IndexType")]
	public EGeometryScriptIndexType IndexType;

	private static bool FGeometryScriptIndexList_IsValid;

	private static int FGeometryScriptIndexList_StructSize;

	public FGeometryScriptIndexList Copy()
	{
		return this;
	}

	public static FGeometryScriptIndexList FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptIndexList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptIndexList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptIndexList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptIndexList(nativeBuffer + arrayIndex * FGeometryScriptIndexList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptIndexList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptIndexList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptIndexList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptIndexList");
		}
		else
		{
			EnumMarshaler<EGeometryScriptIndexType>.ToNative(IntPtr.Add(nativeStruct, IndexType_Offset), 0, IndexType_PropertyAddress.Address, IndexType);
		}
	}

	public FGeometryScriptIndexList(IntPtr nativeStruct)
	{
		if (!FGeometryScriptIndexList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptIndexList");
			IndexType = EGeometryScriptIndexType.Any;
		}
		else
		{
			IndexType = EnumMarshaler<EGeometryScriptIndexType>.FromNative(IntPtr.Add(nativeStruct, IndexType_Offset), 0, IndexType_PropertyAddress.Address);
		}
	}

	static FGeometryScriptIndexList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptIndexList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptIndexList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptIndexList");
		FGeometryScriptIndexList_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IndexType_PropertyAddress, intPtr, "IndexType");
		IndexType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IndexType");
		IndexType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IndexType", Classes.FEnumProperty);
		FGeometryScriptIndexList_IsValid = intPtr != IntPtr.Zero && IndexType_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptIndexList", FGeometryScriptIndexList_IsValid);
	}
}
