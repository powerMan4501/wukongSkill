using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MeshDescription.UVID", "MeshDescription", UnrealModuleType.Engine)]
public struct FUVID
{
	private static bool IDValue_IsValid;

	private static int IDValue_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/MeshDescription.ElementID:IDValue")]
	public int IDValue;

	private static bool FUVID_IsValid;

	private static int FUVID_StructSize;

	public FUVID Copy()
	{
		return this;
	}

	public static FUVID FromNative(IntPtr nativeBuffer)
	{
		return new FUVID(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUVID value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUVID FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUVID(nativeBuffer + arrayIndex * FUVID_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUVID value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FUVID_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FUVID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.UVID");
		}
		else
		{
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IDValue_Offset), IDValue);
		}
	}

	public FUVID(IntPtr nativeStruct)
	{
		if (!FUVID_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MeshDescription.UVID");
			IDValue = 0;
		}
		else
		{
			IDValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IDValue_Offset));
		}
	}

	static FUVID()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUVID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUVID));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MeshDescription.UVID");
		FUVID_StructSize = NativeReflection.GetStructSize(intPtr);
		IDValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IDValue");
		IDValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IDValue", Classes.FIntProperty);
		FUVID_IsValid = intPtr != IntPtr.Zero && IDValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/MeshDescription.UVID", FUVID_IsValid);
	}
}
