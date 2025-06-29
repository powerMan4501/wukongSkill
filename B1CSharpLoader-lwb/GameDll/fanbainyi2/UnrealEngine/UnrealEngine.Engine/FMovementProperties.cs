using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MovementProperties", "Engine", UnrealModuleType.Engine)]
public struct FMovementProperties
{
	private static bool CanCrouch_IsValid;

	private static FFieldAddress CanCrouch_PropertyAddress;

	private static int CanCrouch_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanCrouch")]
	public bool CanCrouch;

	private static bool CanJump_IsValid;

	private static FFieldAddress CanJump_PropertyAddress;

	private static int CanJump_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanJump")]
	public bool CanJump;

	private static bool CanWalk_IsValid;

	private static FFieldAddress CanWalk_PropertyAddress;

	private static int CanWalk_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanWalk")]
	public bool CanWalk;

	private static bool CanSwim_IsValid;

	private static FFieldAddress CanSwim_PropertyAddress;

	private static int CanSwim_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanSwim")]
	public bool CanSwim;

	private static bool CanFly_IsValid;

	private static FFieldAddress CanFly_PropertyAddress;

	private static int CanFly_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementProperties:bCanFly")]
	public bool CanFly;

	private static bool FMovementProperties_IsValid;

	private static int FMovementProperties_StructSize;

	public FMovementProperties Copy()
	{
		return this;
	}

	public static FMovementProperties FromNative(IntPtr nativeBuffer)
	{
		return new FMovementProperties(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMovementProperties value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMovementProperties FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMovementProperties(nativeBuffer + arrayIndex * FMovementProperties_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMovementProperties value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMovementProperties_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMovementProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MovementProperties");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanCrouch_Offset), 0, CanCrouch_PropertyAddress.Address, CanCrouch);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanJump_Offset), 0, CanJump_PropertyAddress.Address, CanJump);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanWalk_Offset), 0, CanWalk_PropertyAddress.Address, CanWalk);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanSwim_Offset), 0, CanSwim_PropertyAddress.Address, CanSwim);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanFly_Offset), 0, CanFly_PropertyAddress.Address, CanFly);
	}

	public FMovementProperties(IntPtr nativeStruct)
	{
		if (!FMovementProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MovementProperties");
			CanCrouch = false;
			CanJump = false;
			CanWalk = false;
			CanSwim = false;
			CanFly = false;
		}
		else
		{
			CanCrouch = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanCrouch_Offset), 0, CanCrouch_PropertyAddress.Address);
			CanJump = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanJump_Offset), 0, CanJump_PropertyAddress.Address);
			CanWalk = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanWalk_Offset), 0, CanWalk_PropertyAddress.Address);
			CanSwim = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanSwim_Offset), 0, CanSwim_PropertyAddress.Address);
			CanFly = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanFly_Offset), 0, CanFly_PropertyAddress.Address);
		}
	}

	static FMovementProperties()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMovementProperties)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMovementProperties));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MovementProperties");
		FMovementProperties_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CanCrouch_PropertyAddress, intPtr, "bCanCrouch");
		CanCrouch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanCrouch");
		CanCrouch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanCrouch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanJump_PropertyAddress, intPtr, "bCanJump");
		CanJump_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanJump");
		CanJump_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanJump", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanWalk_PropertyAddress, intPtr, "bCanWalk");
		CanWalk_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanWalk");
		CanWalk_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanWalk", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanSwim_PropertyAddress, intPtr, "bCanSwim");
		CanSwim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanSwim");
		CanSwim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanSwim", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CanFly_PropertyAddress, intPtr, "bCanFly");
		CanFly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCanFly");
		CanFly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCanFly", Classes.FBoolProperty);
		FMovementProperties_IsValid = intPtr != IntPtr.Zero && CanCrouch_IsValid && CanJump_IsValid && CanWalk_IsValid && CanSwim_IsValid && CanFly_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MovementProperties", FMovementProperties_IsValid);
	}
}
