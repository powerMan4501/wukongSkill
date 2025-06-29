using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.TriangleID", "MeshDescription", UnrealModuleType.Engine)]
public struct FTriangleID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FTriangleID_IsValid;

	private static int FTriangleID_StructSize;

	public FTriangleID Copy()
	{
		return this;
	}

	public static FTriangleID FromNative(IntPtr nativeBuffer)
	{
		return new FTriangleID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTriangleID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTriangleID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTriangleID(nativeBuffer + arrayIndex * FTriangleID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTriangleID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTriangleID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTriangleID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.TriangleID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FTriangleID(IntPtr nativeStruct)
	{
		if (!FTriangleID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.TriangleID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FTriangleID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTriangleID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTriangleID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.TriangleID");
		FTriangleID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FTriangleID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.TriangleID", FTriangleID_IsValid);
	}
}
