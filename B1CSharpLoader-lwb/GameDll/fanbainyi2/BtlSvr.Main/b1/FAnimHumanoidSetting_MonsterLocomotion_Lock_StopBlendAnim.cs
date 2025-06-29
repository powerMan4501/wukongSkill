using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim")]
public struct FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim:ASStopBlendAnim")]
	public UAnimSequence ASStopBlendAnim;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim:BlendInTime")]
	public float BlendInTime;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim:BlendOutTime")]
	public float BlendOutTime;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim:PlayRate")]
	public float PlayRate;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim:StartPosition")]
	public float StartPosition;

	private static int AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_StructSize;

	private static int AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_IsValid;

	private static bool ASStopBlendAnim_IsValid;

	private static int ASStopBlendAnim_Offset;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	private static bool PlayRate_IsValid;

	private static int PlayRate_Offset;

	private static bool StartPosition_IsValid;

	private static int StartPosition_Offset;

	public FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASStopBlendAnim_Offset), ASStopBlendAnim);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendInTime_Offset), BlendInTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendOutTime_Offset), BlendOutTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayRate_Offset), PlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StartPosition_Offset), StartPosition);
	}

	public FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim");
			ASStopBlendAnim = null;
			BlendInTime = 0f;
			BlendOutTime = 0f;
			PlayRate = 0f;
			StartPosition = 0f;
		}
		else
		{
			ASStopBlendAnim = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASStopBlendAnim_Offset));
			BlendInTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendInTime_Offset));
			BlendOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendOutTime_Offset));
			PlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayRate_Offset));
			StartPosition = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StartPosition_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim");
		AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_StructSize = NativeReflection.GetStructSize(intPtr);
		ASStopBlendAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASStopBlendAnim");
		ASStopBlendAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASStopBlendAnim", Classes.FObjectProperty);
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		PlayRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayRate");
		PlayRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayRate", Classes.FFloatProperty);
		StartPosition_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartPosition");
		StartPosition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartPosition", Classes.FFloatProperty);
		AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_IsValid = ((intPtr != IntPtr.Zero && ASStopBlendAnim_IsValid && BlendInTime_IsValid && BlendOutTime_IsValid && PlayRate_IsValid && StartPosition_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim", (byte)AnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim_IsValid != 0);
	}

	static FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim));
	}
}
