using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common")]
public struct FAnimHumanoidSetting_Common
{
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:bDisableABPMove")]
	public bool bDisableABPMove;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:ABPMoveMode")]
	public EABPMoveMode ABPMoveMode;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:AnimSeqIdle")]
	public UAnimSequence AnimSeqIdle;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:RetargetAnimSeqIdle")]
	public UAnimSequence RetargetAnimSeqIdle;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:bLockUseFreeMode")]
	public bool bLockUseFreeMode;

	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:AnimTurnMinAngle")]
	public float AnimTurnMinAngle;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:AnimTurnLeft90")]
	public UAnimSequence AnimTurnLeft90;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:AnimTurnRight90")]
	public UAnimSequence AnimTurnRight90;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:AnimTurnLeft180")]
	public UAnimSequence AnimTurnLeft180;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Common:AnimTurnRight180")]
	public UAnimSequence AnimTurnRight180;

	private static int AnimHumanoidSetting_Common_StructSize;

	private static int AnimHumanoidSetting_Common_IsValid;

	private static bool bDisableABPMove_IsValid;

	private static int bDisableABPMove_Offset;

	private static FFieldAddress bDisableABPMove_PropertyAddress;

	private static bool ABPMoveMode_IsValid;

	private static int ABPMoveMode_Offset;

	private static FFieldAddress ABPMoveMode_PropertyAddress;

	private static bool AnimSeqIdle_IsValid;

	private static int AnimSeqIdle_Offset;

	private static bool RetargetAnimSeqIdle_IsValid;

	private static int RetargetAnimSeqIdle_Offset;

	private static bool bLockUseFreeMode_IsValid;

	private static int bLockUseFreeMode_Offset;

	private static FFieldAddress bLockUseFreeMode_PropertyAddress;

	private static bool AnimTurnMinAngle_IsValid;

	private static int AnimTurnMinAngle_Offset;

	private static bool AnimTurnLeft90_IsValid;

	private static int AnimTurnLeft90_Offset;

	private static bool AnimTurnRight90_IsValid;

	private static int AnimTurnRight90_Offset;

	private static bool AnimTurnLeft180_IsValid;

	private static int AnimTurnLeft180_Offset;

	private static bool AnimTurnRight180_IsValid;

	private static int AnimTurnRight180_Offset;

	public FAnimHumanoidSetting_Common Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_Common FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Common(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Common value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Common FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Common(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Common_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Common value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Common_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Common_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Common");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bDisableABPMove_Offset), 0, bDisableABPMove_PropertyAddress.Address, bDisableABPMove);
		EnumMarshaler<EABPMoveMode>.ToNative(IntPtr.Add(nativeStruct, ABPMoveMode_Offset), 0, ABPMoveMode_PropertyAddress.Address, ABPMoveMode);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqIdle_Offset), AnimSeqIdle);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, RetargetAnimSeqIdle_Offset), RetargetAnimSeqIdle);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bLockUseFreeMode_Offset), 0, bLockUseFreeMode_PropertyAddress.Address, bLockUseFreeMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnimTurnMinAngle_Offset), AnimTurnMinAngle);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimTurnLeft90_Offset), AnimTurnLeft90);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimTurnRight90_Offset), AnimTurnRight90);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimTurnLeft180_Offset), AnimTurnLeft180);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimTurnRight180_Offset), AnimTurnRight180);
	}

	public FAnimHumanoidSetting_Common(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Common_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Common");
			bDisableABPMove = false;
			ABPMoveMode = EABPMoveMode.None;
			AnimSeqIdle = null;
			RetargetAnimSeqIdle = null;
			bLockUseFreeMode = false;
			AnimTurnMinAngle = 0f;
			AnimTurnLeft90 = null;
			AnimTurnRight90 = null;
			AnimTurnLeft180 = null;
			AnimTurnRight180 = null;
		}
		else
		{
			bDisableABPMove = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bDisableABPMove_Offset), 0, bDisableABPMove_PropertyAddress.Address);
			ABPMoveMode = EnumMarshaler<EABPMoveMode>.FromNative(IntPtr.Add(nativeStruct, ABPMoveMode_Offset), 0, ABPMoveMode_PropertyAddress.Address);
			AnimSeqIdle = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqIdle_Offset));
			RetargetAnimSeqIdle = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, RetargetAnimSeqIdle_Offset));
			bLockUseFreeMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bLockUseFreeMode_Offset), 0, bLockUseFreeMode_PropertyAddress.Address);
			AnimTurnMinAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnimTurnMinAngle_Offset));
			AnimTurnLeft90 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimTurnLeft90_Offset));
			AnimTurnRight90 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimTurnRight90_Offset));
			AnimTurnLeft180 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimTurnLeft180_Offset));
			AnimTurnRight180 = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimTurnRight180_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Common");
		AnimHumanoidSetting_Common_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bDisableABPMove_PropertyAddress, intPtr, "bDisableABPMove");
		bDisableABPMove_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableABPMove");
		bDisableABPMove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableABPMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ABPMoveMode_PropertyAddress, intPtr, "ABPMoveMode");
		ABPMoveMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPMoveMode");
		ABPMoveMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPMoveMode", Classes.FEnumProperty);
		AnimSeqIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSeqIdle");
		AnimSeqIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSeqIdle", Classes.FObjectProperty);
		RetargetAnimSeqIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RetargetAnimSeqIdle");
		RetargetAnimSeqIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RetargetAnimSeqIdle", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bLockUseFreeMode_PropertyAddress, intPtr, "bLockUseFreeMode");
		bLockUseFreeMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLockUseFreeMode");
		bLockUseFreeMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLockUseFreeMode", Classes.FBoolProperty);
		AnimTurnMinAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimTurnMinAngle");
		AnimTurnMinAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimTurnMinAngle", Classes.FFloatProperty);
		AnimTurnLeft90_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimTurnLeft90");
		AnimTurnLeft90_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimTurnLeft90", Classes.FObjectProperty);
		AnimTurnRight90_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimTurnRight90");
		AnimTurnRight90_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimTurnRight90", Classes.FObjectProperty);
		AnimTurnLeft180_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimTurnLeft180");
		AnimTurnLeft180_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimTurnLeft180", Classes.FObjectProperty);
		AnimTurnRight180_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimTurnRight180");
		AnimTurnRight180_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimTurnRight180", Classes.FObjectProperty);
		AnimHumanoidSetting_Common_IsValid = ((intPtr != IntPtr.Zero && bDisableABPMove_IsValid && ABPMoveMode_IsValid && AnimSeqIdle_IsValid && RetargetAnimSeqIdle_IsValid && bLockUseFreeMode_IsValid && AnimTurnMinAngle_IsValid && AnimTurnLeft90_IsValid && AnimTurnRight90_IsValid && AnimTurnLeft180_IsValid && AnimTurnRight180_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Common", (byte)AnimHumanoidSetting_Common_IsValid != 0);
	}

	static FAnimHumanoidSetting_Common()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Common)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Common));
	}
}
