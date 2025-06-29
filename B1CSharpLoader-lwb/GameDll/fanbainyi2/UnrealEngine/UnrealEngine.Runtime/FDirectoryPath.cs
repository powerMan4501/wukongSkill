using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 32776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.DirectoryPath", "CoreUObject", UnrealModuleType.Engine)]
public struct FDirectoryPath
{
	private static bool Path_IsValid;

	private static int Path_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/CoreUObject.DirectoryPath:Path")]
	public string Path;

	private static bool FDirectoryPath_IsValid;

	private static int FDirectoryPath_StructSize;

	public FDirectoryPath Copy()
	{
		return this;
	}

	public static FDirectoryPath FromNative(IntPtr nativeBuffer)
	{
		return new FDirectoryPath(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDirectoryPath value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDirectoryPath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDirectoryPath(nativeBuffer + arrayIndex * FDirectoryPath_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDirectoryPath value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDirectoryPath_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDirectoryPath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.DirectoryPath");
		}
		else
		{
			FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Path_Offset), Path);
		}
	}

	public FDirectoryPath(IntPtr nativeStruct)
	{
		if (!FDirectoryPath_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.DirectoryPath");
			Path = FStringMarshaler.DefaultString;
		}
		else
		{
			Path = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Path_Offset));
		}
	}

	static FDirectoryPath()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDirectoryPath)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDirectoryPath));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.DirectoryPath");
		FDirectoryPath_StructSize = NativeReflection.GetStructSize(intPtr);
		Path_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Path");
		Path_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Path", Classes.FStrProperty);
		FDirectoryPath_IsValid = intPtr != IntPtr.Zero && Path_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.DirectoryPath", FDirectoryPath_IsValid);
	}
}
