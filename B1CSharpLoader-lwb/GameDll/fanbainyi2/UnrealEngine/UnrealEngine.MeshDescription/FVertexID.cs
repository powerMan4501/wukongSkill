using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.VertexID", "MeshDescription", UnrealModuleType.Engine)]
public struct FVertexID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FVertexID_IsValid;

	private static int FVertexID_StructSize;

	public FVertexID Copy()
	{
		return this;
	}

	public static FVertexID FromNative(IntPtr nativeBuffer)
	{
		return new FVertexID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVertexID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVertexID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVertexID(nativeBuffer + arrayIndex * FVertexID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVertexID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVertexID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVertexID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.VertexID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FVertexID(IntPtr nativeStruct)
	{
		if (!FVertexID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.VertexID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FVertexID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVertexID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVertexID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.VertexID");
		FVertexID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FVertexID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.VertexID", FVertexID_IsValid);
	}
}
