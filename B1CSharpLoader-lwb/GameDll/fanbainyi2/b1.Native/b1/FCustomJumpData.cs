using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.CustomJumpData", "b1", UnrealModuleType.Game)]
public struct FCustomJumpData
{
	private static bool CustomJumpVelocityIncrement_Pressed_IsValid;

	private static int CustomJumpVelocityIncrement_Pressed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.CustomJumpData:CustomJumpVelocityIncrement_Pressed")]
	public float CustomJumpVelocityIncrement_Pressed;

	private static bool LastCustomJumpVelocityIncrement_Pressed_IsValid;

	private static int LastCustomJumpVelocityIncrement_Pressed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.CustomJumpData:LastCustomJumpVelocityIncrement_Pressed")]
	public float LastCustomJumpVelocityIncrement_Pressed;

	private static bool Delta_VelocityZIncrement_CustomJump_IsValid;

	private static int Delta_VelocityZIncrement_CustomJump_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.CustomJumpData:Delta_VelocityZIncrement_CustomJump")]
	public float Delta_VelocityZIncrement_CustomJump;

	private static bool LastVelocityZIncrement_CustomJump_IsValid;

	private static int LastVelocityZIncrement_CustomJump_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.CustomJumpData:LastVelocityZIncrement_CustomJump")]
	public float LastVelocityZIncrement_CustomJump;

	private static bool FCustomJumpData_IsValid;

	private static int FCustomJumpData_StructSize;

	public FCustomJumpData Copy()
	{
		return this;
	}

	public static FCustomJumpData FromNative(IntPtr nativeBuffer)
	{
		return new FCustomJumpData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCustomJumpData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCustomJumpData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCustomJumpData(nativeBuffer + arrayIndex * FCustomJumpData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCustomJumpData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCustomJumpData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCustomJumpData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CustomJumpData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CustomJumpVelocityIncrement_Pressed_Offset), CustomJumpVelocityIncrement_Pressed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LastCustomJumpVelocityIncrement_Pressed_Offset), LastCustomJumpVelocityIncrement_Pressed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delta_VelocityZIncrement_CustomJump_Offset), Delta_VelocityZIncrement_CustomJump);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LastVelocityZIncrement_CustomJump_Offset), LastVelocityZIncrement_CustomJump);
	}

	public FCustomJumpData(IntPtr nativeStruct)
	{
		if (!FCustomJumpData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.CustomJumpData");
			CustomJumpVelocityIncrement_Pressed = 0f;
			LastCustomJumpVelocityIncrement_Pressed = 0f;
			Delta_VelocityZIncrement_CustomJump = 0f;
			LastVelocityZIncrement_CustomJump = 0f;
		}
		else
		{
			CustomJumpVelocityIncrement_Pressed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CustomJumpVelocityIncrement_Pressed_Offset));
			LastCustomJumpVelocityIncrement_Pressed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LastCustomJumpVelocityIncrement_Pressed_Offset));
			Delta_VelocityZIncrement_CustomJump = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delta_VelocityZIncrement_CustomJump_Offset));
			LastVelocityZIncrement_CustomJump = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LastVelocityZIncrement_CustomJump_Offset));
		}
	}

	static FCustomJumpData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCustomJumpData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCustomJumpData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.CustomJumpData");
		FCustomJumpData_StructSize = NativeReflection.GetStructSize(intPtr);
		CustomJumpVelocityIncrement_Pressed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomJumpVelocityIncrement_Pressed");
		CustomJumpVelocityIncrement_Pressed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomJumpVelocityIncrement_Pressed", Classes.FFloatProperty);
		LastCustomJumpVelocityIncrement_Pressed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastCustomJumpVelocityIncrement_Pressed");
		LastCustomJumpVelocityIncrement_Pressed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastCustomJumpVelocityIncrement_Pressed", Classes.FFloatProperty);
		Delta_VelocityZIncrement_CustomJump_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Delta_VelocityZIncrement_CustomJump");
		Delta_VelocityZIncrement_CustomJump_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Delta_VelocityZIncrement_CustomJump", Classes.FFloatProperty);
		LastVelocityZIncrement_CustomJump_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastVelocityZIncrement_CustomJump");
		LastVelocityZIncrement_CustomJump_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastVelocityZIncrement_CustomJump", Classes.FFloatProperty);
		FCustomJumpData_IsValid = intPtr != IntPtr.Zero && CustomJumpVelocityIncrement_Pressed_IsValid && LastCustomJumpVelocityIncrement_Pressed_IsValid && Delta_VelocityZIncrement_CustomJump_IsValid && LastVelocityZIncrement_CustomJump_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.CustomJumpData", FCustomJumpData_IsValid);
	}
}
