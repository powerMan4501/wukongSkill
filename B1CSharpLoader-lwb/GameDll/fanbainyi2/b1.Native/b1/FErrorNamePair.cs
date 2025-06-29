using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FuncLibEditor.ErrorNamePair", "FuncLibEditor", UnrealModuleType.Game)]
public struct FErrorNamePair
{
	private static bool Name1_IsValid;

	private static int Name1_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.ErrorNamePair:Name1")]
	public FName Name1;

	private static bool Name2_IsValid;

	private static int Name2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FuncLibEditor.ErrorNamePair:Name2")]
	public FName Name2;

	private static bool FErrorNamePair_IsValid;

	private static int FErrorNamePair_StructSize;

	public FErrorNamePair Copy()
	{
		return this;
	}

	public static FErrorNamePair FromNative(IntPtr nativeBuffer)
	{
		return new FErrorNamePair(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FErrorNamePair value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FErrorNamePair FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FErrorNamePair(nativeBuffer + arrayIndex * FErrorNamePair_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FErrorNamePair value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FErrorNamePair_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FErrorNamePair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ErrorNamePair");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name1_Offset), Name1);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name2_Offset), Name2);
	}

	public FErrorNamePair(IntPtr nativeStruct)
	{
		if (!FErrorNamePair_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FuncLibEditor.ErrorNamePair");
			Name1 = default(FName);
			Name2 = default(FName);
		}
		else
		{
			Name1 = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name1_Offset));
			Name2 = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name2_Offset));
		}
	}

	static FErrorNamePair()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FErrorNamePair)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FErrorNamePair));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FuncLibEditor.ErrorNamePair");
		FErrorNamePair_StructSize = NativeReflection.GetStructSize(intPtr);
		Name1_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name1");
		Name1_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name1", Classes.FNameProperty);
		Name2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name2");
		Name2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name2", Classes.FNameProperty);
		FErrorNamePair_IsValid = intPtr != IntPtr.Zero && Name1_IsValid && Name2_IsValid;
		NativeReflection.LogStructIsValid("/Script/FuncLibEditor.ErrorNamePair", FErrorNamePair_IsValid);
	}
}
