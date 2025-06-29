using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.SocketName", "b1", UnrealModuleType.Game)]
public struct FSocketName
{
	private static bool FirstSocketName_IsValid;

	private static int FirstSocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.SocketName:FirstSocketName")]
	public FName FirstSocketName;

	private static bool SecondSocketName_IsValid;

	private static int SecondSocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.SocketName:SecondSocketName")]
	public FName SecondSocketName;

	private static bool FSocketName_IsValid;

	private static int FSocketName_StructSize;

	public FSocketName Copy()
	{
		return this;
	}

	public static FSocketName FromNative(IntPtr nativeBuffer)
	{
		return new FSocketName(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSocketName value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSocketName FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSocketName(nativeBuffer + arrayIndex * FSocketName_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSocketName value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSocketName_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSocketName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.SocketName");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, FirstSocketName_Offset), FirstSocketName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SecondSocketName_Offset), SecondSocketName);
	}

	public FSocketName(IntPtr nativeStruct)
	{
		if (!FSocketName_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.SocketName");
			FirstSocketName = default(FName);
			SecondSocketName = default(FName);
		}
		else
		{
			FirstSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, FirstSocketName_Offset));
			SecondSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SecondSocketName_Offset));
		}
	}

	static FSocketName()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSocketName)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSocketName));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.SocketName");
		FSocketName_StructSize = NativeReflection.GetStructSize(intPtr);
		FirstSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FirstSocketName");
		FirstSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FirstSocketName", Classes.FNameProperty);
		SecondSocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SecondSocketName");
		SecondSocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SecondSocketName", Classes.FNameProperty);
		FSocketName_IsValid = intPtr != IntPtr.Zero && FirstSocketName_IsValid && SecondSocketName_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.SocketName", FSocketName_IsValid);
	}
}
