using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.ElementID", "MeshDescription", UnrealModuleType.Engine)]
public struct FElementID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FElementID_IsValid;

	private static int FElementID_StructSize;

	public FElementID Copy()
	{
		return this;
	}

	public static FElementID FromNative(IntPtr nativeBuffer)
	{
		return new FElementID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FElementID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FElementID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FElementID(nativeBuffer + arrayIndex * FElementID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FElementID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FElementID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FElementID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.ElementID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FElementID(IntPtr nativeStruct)
	{
		if (!FElementID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.ElementID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FElementID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FElementID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FElementID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.ElementID");
		FElementID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FElementID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.ElementID", FElementID_IsValid);
	}
}
