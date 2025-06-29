using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land")]
public struct FAnimHumanoidSetting_Jump_Land
{
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("着陆动画")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land:AnimSeq_Land")]
	public UAnimSequence AnimSeq_Land;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("慢走不能移动的时间")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land:WalkAnimLand_MoveTime")]
	public float WalkAnimLand_MoveTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("不能移动的时间")]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land:AnimLand_MoveTime")]
	public float AnimLand_MoveTime;

	[UProperty]
	[EditAnywhere]
	[DisplayName("不能跳跃的时间")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land:AnimLand_JumpTime")]
	public float AnimLand_JumpTime;

	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("不能攻击的时间")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land:AnimLand_AttackTime")]
	public float AnimLand_AttackTime;

	[UProperty]
	[EditAnywhere]
	[DisplayName("不能翻滚的时间")]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land:AnimLand_DodgeTime")]
	public float AnimLand_DodgeTime;

	private static int AnimHumanoidSetting_Jump_Land_StructSize;

	private static int AnimHumanoidSetting_Jump_Land_IsValid;

	private static bool AnimSeq_Land_IsValid;

	private static int AnimSeq_Land_Offset;

	private static bool WalkAnimLand_MoveTime_IsValid;

	private static int WalkAnimLand_MoveTime_Offset;

	private static bool AnimLand_MoveTime_IsValid;

	private static int AnimLand_MoveTime_Offset;

	private static bool AnimLand_JumpTime_IsValid;

	private static int AnimLand_JumpTime_Offset;

	private static bool AnimLand_AttackTime_IsValid;

	private static int AnimLand_AttackTime_Offset;

	private static bool AnimLand_DodgeTime_IsValid;

	private static int AnimLand_DodgeTime_Offset;

	public FAnimHumanoidSetting_Jump_Land Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_Jump_Land FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Jump_Land(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Jump_Land value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Jump_Land FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Jump_Land(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Jump_Land_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Jump_Land value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Jump_Land_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Jump_Land_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeq_Land_Offset), AnimSeq_Land);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WalkAnimLand_MoveTime_Offset), WalkAnimLand_MoveTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimLand_MoveTime_Offset), AnimLand_MoveTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimLand_JumpTime_Offset), AnimLand_JumpTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimLand_AttackTime_Offset), AnimLand_AttackTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimLand_DodgeTime_Offset), AnimLand_DodgeTime);
	}

	public FAnimHumanoidSetting_Jump_Land(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Jump_Land_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land");
			AnimSeq_Land = null;
			WalkAnimLand_MoveTime = 0f;
			AnimLand_MoveTime = 0f;
			AnimLand_JumpTime = 0f;
			AnimLand_AttackTime = 0f;
			AnimLand_DodgeTime = 0f;
		}
		else
		{
			AnimSeq_Land = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeq_Land_Offset));
			WalkAnimLand_MoveTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WalkAnimLand_MoveTime_Offset));
			AnimLand_MoveTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimLand_MoveTime_Offset));
			AnimLand_JumpTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimLand_JumpTime_Offset));
			AnimLand_AttackTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimLand_AttackTime_Offset));
			AnimLand_DodgeTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimLand_DodgeTime_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land");
		AnimHumanoidSetting_Jump_Land_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimSeq_Land_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSeq_Land");
		AnimSeq_Land_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSeq_Land", Classes.FObjectProperty);
		WalkAnimLand_MoveTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "WalkAnimLand_MoveTime");
		WalkAnimLand_MoveTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WalkAnimLand_MoveTime", Classes.FFloatProperty);
		AnimLand_MoveTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_MoveTime");
		AnimLand_MoveTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_MoveTime", Classes.FFloatProperty);
		AnimLand_JumpTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_JumpTime");
		AnimLand_JumpTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_JumpTime", Classes.FFloatProperty);
		AnimLand_AttackTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_AttackTime");
		AnimLand_AttackTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_AttackTime", Classes.FFloatProperty);
		AnimLand_DodgeTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimLand_DodgeTime");
		AnimLand_DodgeTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimLand_DodgeTime", Classes.FFloatProperty);
		AnimHumanoidSetting_Jump_Land_IsValid = ((intPtr != IntPtr.Zero && AnimSeq_Land_IsValid && WalkAnimLand_MoveTime_IsValid && AnimLand_MoveTime_IsValid && AnimLand_JumpTime_IsValid && AnimLand_AttackTime_IsValid && AnimLand_DodgeTime_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Jump_Land", (byte)AnimHumanoidSetting_Jump_Land_IsValid != 0);
	}

	static FAnimHumanoidSetting_Jump_Land()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Jump_Land)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Jump_Land));
	}
}
