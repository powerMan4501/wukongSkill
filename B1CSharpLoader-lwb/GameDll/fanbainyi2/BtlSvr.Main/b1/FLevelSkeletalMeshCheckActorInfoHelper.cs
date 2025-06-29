using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper")]
public struct FLevelSkeletalMeshCheckActorInfoHelper
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper:ActorLabel")]
	public string ActorLabel;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper:Path")]
	public string Path;

	private static int LevelSkeletalMeshCheckActorInfoHelper_StructSize;

	private static int LevelSkeletalMeshCheckActorInfoHelper_IsValid;

	private static bool ActorLabel_IsValid;

	private static int ActorLabel_Offset;

	private static bool Path_IsValid;

	private static int Path_Offset;

	public FLevelSkeletalMeshCheckActorInfoHelper Copy()
	{
		return this;
	}

	public static FLevelSkeletalMeshCheckActorInfoHelper FromNative(IntPtr nativeBuffer)
	{
		return new FLevelSkeletalMeshCheckActorInfoHelper(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelSkeletalMeshCheckActorInfoHelper value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelSkeletalMeshCheckActorInfoHelper FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelSkeletalMeshCheckActorInfoHelper(IntPtr.Add(nativeBuffer, arrayIndex * LevelSkeletalMeshCheckActorInfoHelper_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelSkeletalMeshCheckActorInfoHelper value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LevelSkeletalMeshCheckActorInfoHelper_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LevelSkeletalMeshCheckActorInfoHelper_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ActorLabel_Offset), ActorLabel);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Path_Offset), Path);
	}

	public FLevelSkeletalMeshCheckActorInfoHelper(IntPtr nativeStruct)
	{
		if (LevelSkeletalMeshCheckActorInfoHelper_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper");
			ActorLabel = null;
			Path = null;
		}
		else
		{
			ActorLabel = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ActorLabel_Offset));
			Path = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Path_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper");
		LevelSkeletalMeshCheckActorInfoHelper_StructSize = NativeReflection.GetStructSize(intPtr);
		ActorLabel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorLabel");
		ActorLabel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorLabel", Classes.FStrProperty);
		Path_Offset = NativeReflection.GetPropertyOffset(intPtr, "Path");
		Path_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Path", Classes.FStrProperty);
		LevelSkeletalMeshCheckActorInfoHelper_IsValid = ((intPtr != IntPtr.Zero && ActorLabel_IsValid && Path_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LevelSkeletalMeshCheckActorInfoHelper", (byte)LevelSkeletalMeshCheckActorInfoHelper_IsValid != 0);
	}

	static FLevelSkeletalMeshCheckActorInfoHelper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLevelSkeletalMeshCheckActorInfoHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelSkeletalMeshCheckActorInfoHelper));
	}
}
