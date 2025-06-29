using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.PolygonGroupID", "MeshDescription", UnrealModuleType.Engine)]
public struct FPolygonGroupID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FPolygonGroupID_IsValid;

	private static int FPolygonGroupID_StructSize;

	public FPolygonGroupID Copy()
	{
		return this;
	}

	public static FPolygonGroupID FromNative(IntPtr nativeBuffer)
	{
		return new FPolygonGroupID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPolygonGroupID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPolygonGroupID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPolygonGroupID(nativeBuffer + arrayIndex * FPolygonGroupID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPolygonGroupID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPolygonGroupID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPolygonGroupID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.PolygonGroupID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FPolygonGroupID(IntPtr nativeStruct)
	{
		if (!FPolygonGroupID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.PolygonGroupID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FPolygonGroupID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPolygonGroupID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPolygonGroupID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.PolygonGroupID");
		FPolygonGroupID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FPolygonGroupID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.PolygonGroupID", FPolygonGroupID_IsValid);
	}
}
