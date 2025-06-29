using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock")]
public struct FAnimHumanoidSetting_MonsterLocomotion_Lock
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ASLockWalkFwd")]
	public UAnimSequence ASLockWalkFwd;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ASLockWalkFR")]
	public UAnimSequence ASLockWalkFR;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ASLockWalkBR")]
	public UAnimSequence ASLockWalkBR;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ASLockWalkFL")]
	public UAnimSequence ASLockWalkFL;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ASLockWalkBL")]
	public UAnimSequence ASLockWalkBL;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ASLockWalkBwd")]
	public UAnimSequence ASLockWalkBwd;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ExplicitTimeForLeftFootStop")]
	public FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop ExplicitTimeForLeftFootStop;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:ExplicitTimeForRightFootStop")]
	public FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop ExplicitTimeForRightFootStop;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:StopLeftBlendAnim")]
	public FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim StopLeftBlendAnim;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock:StopRightBlendAnim")]
	public FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim StopRightBlendAnim;

	private static int AnimHumanoidSetting_MonsterLocomotion_Lock_StructSize;

	private static int AnimHumanoidSetting_MonsterLocomotion_Lock_IsValid;

	private static bool ASLockWalkFwd_IsValid;

	private static int ASLockWalkFwd_Offset;

	private static bool ASLockWalkFR_IsValid;

	private static int ASLockWalkFR_Offset;

	private static bool ASLockWalkBR_IsValid;

	private static int ASLockWalkBR_Offset;

	private static bool ASLockWalkFL_IsValid;

	private static int ASLockWalkFL_Offset;

	private static bool ASLockWalkBL_IsValid;

	private static int ASLockWalkBL_Offset;

	private static bool ASLockWalkBwd_IsValid;

	private static int ASLockWalkBwd_Offset;

	private static bool ExplicitTimeForLeftFootStop_IsValid;

	private static int ExplicitTimeForLeftFootStop_Offset;

	private static bool ExplicitTimeForRightFootStop_IsValid;

	private static int ExplicitTimeForRightFootStop_Offset;

	private static bool StopLeftBlendAnim_IsValid;

	private static int StopLeftBlendAnim_Offset;

	private static bool StopRightBlendAnim_IsValid;

	private static int StopRightBlendAnim_Offset;

	public FAnimHumanoidSetting_MonsterLocomotion_Lock Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_MonsterLocomotion_Lock FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion_Lock(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_MonsterLocomotion_Lock value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_MonsterLocomotion_Lock FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_MonsterLocomotion_Lock(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_Lock_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_MonsterLocomotion_Lock value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_MonsterLocomotion_Lock_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_Lock_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkFwd_Offset), ASLockWalkFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkFR_Offset), ASLockWalkFR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkBR_Offset), ASLockWalkBR);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkFL_Offset), ASLockWalkFL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkBL_Offset), ASLockWalkBL);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASLockWalkBwd_Offset), ASLockWalkBwd);
		BlittableTypeMarshaler<FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop>.ToNative(IntPtr.Add(nativeStruct, ExplicitTimeForLeftFootStop_Offset), ExplicitTimeForLeftFootStop);
		BlittableTypeMarshaler<FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop>.ToNative(IntPtr.Add(nativeStruct, ExplicitTimeForRightFootStop_Offset), ExplicitTimeForRightFootStop);
		FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim.ToNative(IntPtr.Add(nativeStruct, StopLeftBlendAnim_Offset), StopLeftBlendAnim);
		FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim.ToNative(IntPtr.Add(nativeStruct, StopRightBlendAnim_Offset), StopRightBlendAnim);
	}

	public FAnimHumanoidSetting_MonsterLocomotion_Lock(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_MonsterLocomotion_Lock_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock");
			ASLockWalkFwd = null;
			ASLockWalkFR = null;
			ASLockWalkBR = null;
			ASLockWalkFL = null;
			ASLockWalkBL = null;
			ASLockWalkBwd = null;
			ExplicitTimeForLeftFootStop = default(FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop);
			ExplicitTimeForRightFootStop = default(FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop);
			StopLeftBlendAnim = default(FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim);
			StopRightBlendAnim = default(FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim);
		}
		else
		{
			ASLockWalkFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkFwd_Offset));
			ASLockWalkFR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkFR_Offset));
			ASLockWalkBR = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkBR_Offset));
			ASLockWalkFL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkFL_Offset));
			ASLockWalkBL = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkBL_Offset));
			ASLockWalkBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASLockWalkBwd_Offset));
			ExplicitTimeForLeftFootStop = BlittableTypeMarshaler<FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop>.FromNative(IntPtr.Add(nativeStruct, ExplicitTimeForLeftFootStop_Offset));
			ExplicitTimeForRightFootStop = BlittableTypeMarshaler<FAnimHumanoidSetting_MonsterLocomotion_Lock_ExplicitTimeForMoveStop>.FromNative(IntPtr.Add(nativeStruct, ExplicitTimeForRightFootStop_Offset));
			StopLeftBlendAnim = FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim.FromNative(IntPtr.Add(nativeStruct, StopLeftBlendAnim_Offset));
			StopRightBlendAnim = FAnimHumanoidSetting_MonsterLocomotion_Lock_StopBlendAnim.FromNative(IntPtr.Add(nativeStruct, StopRightBlendAnim_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock");
		AnimHumanoidSetting_MonsterLocomotion_Lock_StructSize = NativeReflection.GetStructSize(intPtr);
		ASLockWalkFwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkFwd");
		ASLockWalkFwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkFwd", Classes.FObjectProperty);
		ASLockWalkFR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkFR");
		ASLockWalkFR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkFR", Classes.FObjectProperty);
		ASLockWalkBR_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkBR");
		ASLockWalkBR_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkBR", Classes.FObjectProperty);
		ASLockWalkFL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkFL");
		ASLockWalkFL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkFL", Classes.FObjectProperty);
		ASLockWalkBL_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkBL");
		ASLockWalkBL_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkBL", Classes.FObjectProperty);
		ASLockWalkBwd_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASLockWalkBwd");
		ASLockWalkBwd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASLockWalkBwd", Classes.FObjectProperty);
		ExplicitTimeForLeftFootStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExplicitTimeForLeftFootStop");
		ExplicitTimeForLeftFootStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExplicitTimeForLeftFootStop", Classes.FStructProperty);
		ExplicitTimeForRightFootStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExplicitTimeForRightFootStop");
		ExplicitTimeForRightFootStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExplicitTimeForRightFootStop", Classes.FStructProperty);
		StopLeftBlendAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopLeftBlendAnim");
		StopLeftBlendAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopLeftBlendAnim", Classes.FStructProperty);
		StopRightBlendAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "StopRightBlendAnim");
		StopRightBlendAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StopRightBlendAnim", Classes.FStructProperty);
		AnimHumanoidSetting_MonsterLocomotion_Lock_IsValid = ((intPtr != IntPtr.Zero && ASLockWalkFwd_IsValid && ASLockWalkFR_IsValid && ASLockWalkBR_IsValid && ASLockWalkFL_IsValid && ASLockWalkBL_IsValid && ASLockWalkBwd_IsValid && ExplicitTimeForLeftFootStop_IsValid && ExplicitTimeForRightFootStop_IsValid && StopLeftBlendAnim_IsValid && StopRightBlendAnim_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_MonsterLocomotion_Lock", (byte)AnimHumanoidSetting_MonsterLocomotion_Lock_IsValid != 0);
	}

	static FAnimHumanoidSetting_MonsterLocomotion_Lock()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_MonsterLocomotion_Lock));
	}
}
