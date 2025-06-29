using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion")]
public struct FAnimHumanoidSetting_MonsterLocomotion
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion:Free")]
	public FAnimHumanoidSetting_MonsterLocomotion_Free Free;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion:Lock")]
	public FAnimHumanoidSetting_MonsterLocomotion_Lock Lock;

	private static int AnimHumanoidSetting_MonsterLocomotion_StructSize;

	private static int AnimHumanoidSetting_MonsterLocomotion_IsValid;

	private static bool Free_IsValid;

	private static int Free_Offset;

	private static bool Lock_IsValid;

	private static int Lock_Offset;

	public FAnimHumanoidSetting_MonsterLocomotion Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_MonsterLocomotion FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_MonsterLocomotion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_MonsterLocomotion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_MonsterLocomotion value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion");
			return;
		}
		FAnimHumanoidSetting_MonsterLocomotion_Free.ToNative(IntPtr.Add(nativeStruct, Free_Offset), Free);
		FAnimHumanoidSetting_MonsterLocomotion_Lock.ToNative(IntPtr.Add(nativeStruct, Lock_Offset), Lock);
	}

	public FAnimHumanoidSetting_MonsterLocomotion(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion");
			Free = default(FAnimHumanoidSetting_MonsterLocomotion_Free);
			Lock = default(FAnimHumanoidSetting_MonsterLocomotion_Lock);
		}
		else
		{
			Free = FAnimHumanoidSetting_MonsterLocomotion_Free.FromNative(IntPtr.Add(nativeStruct, Free_Offset));
			Lock = FAnimHumanoidSetting_MonsterLocomotion_Lock.FromNative(IntPtr.Add(nativeStruct, Lock_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion");
		AnimHumanoidSetting_MonsterLocomotion_StructSize = NativeReflection.GetStructSize(intPtr);
		Free_Offset = NativeReflection.GetPropertyOffset(intPtr, "Free");
		Free_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Free", Classes.FStructProperty);
		Lock_Offset = NativeReflection.GetPropertyOffset(intPtr, "Lock");
		Lock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Lock", Classes.FStructProperty);
		AnimHumanoidSetting_MonsterLocomotion_IsValid = ((intPtr != IntPtr.Zero && Free_IsValid && Lock_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion", (byte)AnimHumanoidSetting_MonsterLocomotion_IsValid != 0);
	}

	static FAnimHumanoidSetting_MonsterLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_MonsterLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_MonsterLocomotion));
	}
}
