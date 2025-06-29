using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper")]
public struct FLevelSkeletalMeshCheckInfoHelper
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper:LevelPath")]
	public string LevelPath;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper:ActorWithoutPerfInfos")]
	public List<FLevelSkeletalMeshCheckActorInfoHelper> ActorWithoutPerfInfos;

	private static int LevelSkeletalMeshCheckInfoHelper_StructSize;

	private static int LevelSkeletalMeshCheckInfoHelper_IsValid;

	private static bool LevelPath_IsValid;

	private static int LevelPath_Offset;

	private static bool ActorWithoutPerfInfos_IsValid;

	private static int ActorWithoutPerfInfos_Offset;

	private static FFieldAddress ActorWithoutPerfInfos_PropertyAddress;

	public FLevelSkeletalMeshCheckInfoHelper Copy()
	{
		FLevelSkeletalMeshCheckInfoHelper result = this;
		if (ActorWithoutPerfInfos != null)
		{
			result.ActorWithoutPerfInfos = new List<FLevelSkeletalMeshCheckActorInfoHelper>(ActorWithoutPerfInfos);
		}
		return result;
	}

	public static FLevelSkeletalMeshCheckInfoHelper FromNative(IntPtr nativeBuffer)
	{
		return new FLevelSkeletalMeshCheckInfoHelper(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelSkeletalMeshCheckInfoHelper value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelSkeletalMeshCheckInfoHelper FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelSkeletalMeshCheckInfoHelper(IntPtr.Add(nativeBuffer, arrayIndex * LevelSkeletalMeshCheckInfoHelper_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelSkeletalMeshCheckInfoHelper value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LevelSkeletalMeshCheckInfoHelper_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LevelSkeletalMeshCheckInfoHelper_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, LevelPath_Offset), LevelPath);
		new TArrayCopyMarshaler<FLevelSkeletalMeshCheckActorInfoHelper>(1, ActorWithoutPerfInfos_PropertyAddress, CachedMarshalingDelegates<FLevelSkeletalMeshCheckActorInfoHelper, FLevelSkeletalMeshCheckActorInfoHelper>.FromNative, CachedMarshalingDelegates<FLevelSkeletalMeshCheckActorInfoHelper, FLevelSkeletalMeshCheckActorInfoHelper>.ToNative).ToNative(IntPtr.Add(nativeStruct, ActorWithoutPerfInfos_Offset), ActorWithoutPerfInfos);
	}

	public FLevelSkeletalMeshCheckInfoHelper(IntPtr nativeStruct)
	{
		if (LevelSkeletalMeshCheckInfoHelper_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper");
			LevelPath = null;
			ActorWithoutPerfInfos = null;
		}
		else
		{
			LevelPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, LevelPath_Offset));
			ActorWithoutPerfInfos = new TArrayCopyMarshaler<FLevelSkeletalMeshCheckActorInfoHelper>(1, ActorWithoutPerfInfos_PropertyAddress, CachedMarshalingDelegates<FLevelSkeletalMeshCheckActorInfoHelper, FLevelSkeletalMeshCheckActorInfoHelper>.FromNative, CachedMarshalingDelegates<FLevelSkeletalMeshCheckActorInfoHelper, FLevelSkeletalMeshCheckActorInfoHelper>.ToNative).FromNative(IntPtr.Add(nativeStruct, ActorWithoutPerfInfos_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper");
		LevelSkeletalMeshCheckInfoHelper_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelPath_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelPath");
		LevelPath_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ActorWithoutPerfInfos_PropertyAddress, intPtr, "ActorWithoutPerfInfos");
		ActorWithoutPerfInfos_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorWithoutPerfInfos");
		ActorWithoutPerfInfos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorWithoutPerfInfos", Classes.FArrayProperty);
		LevelSkeletalMeshCheckInfoHelper_IsValid = ((intPtr != IntPtr.Zero && LevelPath_IsValid && ActorWithoutPerfInfos_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LevelSkeletalMeshCheckInfoHelper", (byte)LevelSkeletalMeshCheckInfoHelper_IsValid != 0);
	}

	static FLevelSkeletalMeshCheckInfoHelper()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FLevelSkeletalMeshCheckInfoHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelSkeletalMeshCheckInfoHelper));
	}
}
