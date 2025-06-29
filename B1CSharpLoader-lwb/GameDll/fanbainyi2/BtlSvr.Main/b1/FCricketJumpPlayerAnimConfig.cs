using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CricketJumpPlayerAnimConfig")]
public struct FCricketJumpPlayerAnimConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CricketJumpPlayerAnimConfig:AMPlayerJump")]
	public UAnimMontage AMPlayerJump;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.CricketJumpPlayerAnimConfig:AnimDummyMeshJump")]
	public UAnimationAsset AnimDummyMeshJump;

	private static int CricketJumpPlayerAnimConfig_StructSize;

	private static int CricketJumpPlayerAnimConfig_IsValid;

	private static bool AMPlayerJump_IsValid;

	private static int AMPlayerJump_Offset;

	private static bool AnimDummyMeshJump_IsValid;

	private static int AnimDummyMeshJump_Offset;

	public FCricketJumpPlayerAnimConfig Copy()
	{
		return this;
	}

	public static FCricketJumpPlayerAnimConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCricketJumpPlayerAnimConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCricketJumpPlayerAnimConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCricketJumpPlayerAnimConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCricketJumpPlayerAnimConfig(IntPtr.Add(nativeBuffer, arrayIndex * CricketJumpPlayerAnimConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCricketJumpPlayerAnimConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CricketJumpPlayerAnimConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CricketJumpPlayerAnimConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CricketJumpPlayerAnimConfig");
			return;
		}
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, AMPlayerJump_Offset), AMPlayerJump);
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(nativeStruct, AnimDummyMeshJump_Offset), AnimDummyMeshJump);
	}

	public FCricketJumpPlayerAnimConfig(IntPtr nativeStruct)
	{
		if (CricketJumpPlayerAnimConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CricketJumpPlayerAnimConfig");
			AMPlayerJump = null;
			AnimDummyMeshJump = null;
		}
		else
		{
			AMPlayerJump = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, AMPlayerJump_Offset));
			AnimDummyMeshJump = UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(nativeStruct, AnimDummyMeshJump_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CricketJumpPlayerAnimConfig");
		CricketJumpPlayerAnimConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		AMPlayerJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "AMPlayerJump");
		AMPlayerJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AMPlayerJump", Classes.FObjectProperty);
		AnimDummyMeshJump_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimDummyMeshJump");
		AnimDummyMeshJump_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimDummyMeshJump", Classes.FObjectProperty);
		CricketJumpPlayerAnimConfig_IsValid = ((intPtr != IntPtr.Zero && AMPlayerJump_IsValid && AnimDummyMeshJump_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CricketJumpPlayerAnimConfig", (byte)CricketJumpPlayerAnimConfig_IsValid != 0);
	}

	static FCricketJumpPlayerAnimConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCricketJumpPlayerAnimConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCricketJumpPlayerAnimConfig));
	}
}
