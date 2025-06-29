using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FilePath", "CoreUObject", UnrealModuleType.Engine)]
public struct FFilePath
{
	private static bool FilePath_IsValid;

	private static int FilePath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CoreUObject.FilePath:FilePath")]
	public string FilePath;

	private static bool FFilePath_IsValid;

	private static int FFilePath_StructSize;

	public FFilePath Copy()
	{
		return this;
	}

	public static FFilePath FromNative(IntPtr nativeBuffer)
	{
		return new FFilePath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFilePath value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFilePath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFilePath(nativeBuffer + arrayIndex * FFilePath_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFilePath value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFilePath_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFilePath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FilePath");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, FilePath_Offset), FilePath);
		}
	}

	public FFilePath(IntPtr nativeStruct)
	{
		if (!FFilePath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.FilePath");
			FilePath = FStringMarshaler.DefaultString;
		}
		else
		{
			FilePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, FilePath_Offset));
		}
	}

	static FFilePath()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFilePath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFilePath));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.FilePath");
		FFilePath_StructSize = NativeReflection.GetStructSize(intPtr);
		FilePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilePath");
		FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilePath", Classes.FStrProperty);
		FFilePath_IsValid = intPtr != IntPtr.Zero && FilePath_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.FilePath", FFilePath_IsValid);
	}
}
