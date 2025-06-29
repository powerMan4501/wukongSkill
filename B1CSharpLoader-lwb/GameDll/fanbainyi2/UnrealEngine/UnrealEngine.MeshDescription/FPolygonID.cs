using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.PolygonID", "MeshDescription", UnrealModuleType.Engine)]
public struct FPolygonID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FPolygonID_IsValid;

	private static int FPolygonID_StructSize;

	public FPolygonID Copy()
	{
		return this;
	}

	public static FPolygonID FromNative(IntPtr nativeBuffer)
	{
		return new FPolygonID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPolygonID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPolygonID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPolygonID(nativeBuffer + arrayIndex * FPolygonID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPolygonID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPolygonID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPolygonID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.PolygonID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FPolygonID(IntPtr nativeStruct)
	{
		if (!FPolygonID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.PolygonID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FPolygonID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPolygonID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPolygonID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.PolygonID");
		FPolygonID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FPolygonID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.PolygonID", FPolygonID_IsValid);
	}
}
