using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.VertexInstanceID", "MeshDescription", UnrealModuleType.Engine)]
public struct FVertexInstanceID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FVertexInstanceID_IsValid;

	private static int FVertexInstanceID_StructSize;

	public FVertexInstanceID Copy()
	{
		return this;
	}

	public static FVertexInstanceID FromNative(IntPtr nativeBuffer)
	{
		return new FVertexInstanceID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FVertexInstanceID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FVertexInstanceID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FVertexInstanceID(nativeBuffer + arrayIndex * FVertexInstanceID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FVertexInstanceID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FVertexInstanceID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FVertexInstanceID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.VertexInstanceID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FVertexInstanceID(IntPtr nativeStruct)
	{
		if (!FVertexInstanceID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.VertexInstanceID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FVertexInstanceID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FVertexInstanceID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FVertexInstanceID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.VertexInstanceID");
		FVertexInstanceID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FVertexInstanceID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.VertexInstanceID", FVertexInstanceID_IsValid);
	}
}
