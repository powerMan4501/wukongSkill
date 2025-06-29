using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.EdgeID", "MeshDescription", UnrealModuleType.Engine)]
public struct FEdgeID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FEdgeID_IsValid;

	private static int FEdgeID_StructSize;

	public FEdgeID Copy()
	{
		return this;
	}

	public static FEdgeID FromNative(IntPtr nativeBuffer)
	{
		return new FEdgeID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEdgeID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEdgeID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEdgeID(nativeBuffer + arrayIndex * FEdgeID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEdgeID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEdgeID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEdgeID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.EdgeID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FEdgeID(IntPtr nativeStruct)
	{
		if (!FEdgeID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.EdgeID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FEdgeID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEdgeID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEdgeID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.EdgeID");
		FEdgeID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FEdgeID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.EdgeID", FEdgeID_IsValid);
	}
}
