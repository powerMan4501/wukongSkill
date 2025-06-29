using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FollowPatrolConfig")]
public struct FFollowPatrolConfig
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FollowPatrolConfig:FollowTarget")]
	public ACharacter FollowTarget;

	private static int FollowPatrolConfig_StructSize;

	private static int FollowPatrolConfig_IsValid;

	private static bool FollowTarget_IsValid;

	private static int FollowTarget_Offset;

	public FFollowPatrolConfig Copy()
	{
		return this;
	}

	public static FFollowPatrolConfig FromNative(IntPtr nativeBuffer)
	{
		return new FFollowPatrolConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFollowPatrolConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFollowPatrolConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFollowPatrolConfig(IntPtr.Add(nativeBuffer, arrayIndex * FollowPatrolConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFollowPatrolConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FollowPatrolConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FollowPatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FollowPatrolConfig");
		}
		else
		{
			UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(nativeStruct, FollowTarget_Offset), FollowTarget);
		}
	}

	public FFollowPatrolConfig(IntPtr nativeStruct)
	{
		if (FollowPatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FollowPatrolConfig");
			FollowTarget = null;
		}
		else
		{
			FollowTarget = UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(nativeStruct, FollowTarget_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FollowPatrolConfig");
		FollowPatrolConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		FollowTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "FollowTarget");
		FollowTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FollowTarget", Classes.FObjectProperty);
		FollowPatrolConfig_IsValid = ((intPtr != IntPtr.Zero && FollowTarget_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FollowPatrolConfig", (byte)FollowPatrolConfig_IsValid != 0);
	}

	static FFollowPatrolConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FFollowPatrolConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFollowPatrolConfig));
	}
}
