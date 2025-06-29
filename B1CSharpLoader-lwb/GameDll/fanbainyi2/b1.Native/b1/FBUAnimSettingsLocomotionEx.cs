using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx", "b1", UnrealModuleType.Game)]
public struct FBUAnimSettingsLocomotionEx
{
	private static bool UpperBodyOnly_IsValid;

	private static FFieldAddress UpperBodyOnly_PropertyAddress;

	private static int UpperBodyOnly_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:bUpperBodyOnly")]
	public bool UpperBodyOnly;

	private static bool UseExAnim_IsValid;

	private static FFieldAddress UseExAnim_PropertyAddress;

	private static int UseExAnim_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:bUseExAnim")]
	public bool UseExAnim;

	private static bool AnimSeqIdle_IsValid;

	private static int AnimSeqIdle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqIdle")]
	public UAnimSequence AnimSeqIdle;

	private static bool AnimSeqEnter_IsValid;

	private static int AnimSeqEnter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqEnter")]
	public UAnimSequence AnimSeqEnter;

	private static bool AnimSeqExit_IsValid;

	private static int AnimSeqExit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqExit")]
	public UAnimSequence AnimSeqExit;

	private static bool AnimSeqMoveFwd_IsValid;

	private static int AnimSeqMoveFwd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqMoveFwd")]
	public UAnimSequence AnimSeqMoveFwd;

	private static bool AnimSeqMoveBwd_IsValid;

	private static int AnimSeqMoveBwd_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqMoveBwd")]
	public UAnimSequence AnimSeqMoveBwd;

	private static bool AnimSeqMoveLeft_IsValid;

	private static int AnimSeqMoveLeft_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqMoveLeft")]
	public UAnimSequence AnimSeqMoveLeft;

	private static bool AnimSeqMoveRight_IsValid;

	private static int AnimSeqMoveRight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BUAnimSettingsLocomotionEx:AnimSeqMoveRight")]
	public UAnimSequence AnimSeqMoveRight;

	private static bool FBUAnimSettingsLocomotionEx_IsValid;

	private static int FBUAnimSettingsLocomotionEx_StructSize;

	public FBUAnimSettingsLocomotionEx Copy()
	{
		return this;
	}

	public static FBUAnimSettingsLocomotionEx FromNative(IntPtr nativeBuffer)
	{
		return new FBUAnimSettingsLocomotionEx(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBUAnimSettingsLocomotionEx value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBUAnimSettingsLocomotionEx FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBUAnimSettingsLocomotionEx(nativeBuffer + arrayIndex * FBUAnimSettingsLocomotionEx_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBUAnimSettingsLocomotionEx value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBUAnimSettingsLocomotionEx_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBUAnimSettingsLocomotionEx_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BUAnimSettingsLocomotionEx");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UpperBodyOnly_Offset), 0, UpperBodyOnly_PropertyAddress.Address, UpperBodyOnly);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseExAnim_Offset), 0, UseExAnim_PropertyAddress.Address, UseExAnim);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqIdle_Offset), AnimSeqIdle);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqEnter_Offset), AnimSeqEnter);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqExit_Offset), AnimSeqExit);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqMoveFwd_Offset), AnimSeqMoveFwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqMoveBwd_Offset), AnimSeqMoveBwd);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqMoveLeft_Offset), AnimSeqMoveLeft);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqMoveRight_Offset), AnimSeqMoveRight);
	}

	public FBUAnimSettingsLocomotionEx(IntPtr nativeStruct)
	{
		if (!FBUAnimSettingsLocomotionEx_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BUAnimSettingsLocomotionEx");
			UpperBodyOnly = false;
			UseExAnim = false;
			AnimSeqIdle = null;
			AnimSeqEnter = null;
			AnimSeqExit = null;
			AnimSeqMoveFwd = null;
			AnimSeqMoveBwd = null;
			AnimSeqMoveLeft = null;
			AnimSeqMoveRight = null;
		}
		else
		{
			UpperBodyOnly = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UpperBodyOnly_Offset), 0, UpperBodyOnly_PropertyAddress.Address);
			UseExAnim = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseExAnim_Offset), 0, UseExAnim_PropertyAddress.Address);
			AnimSeqIdle = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqIdle_Offset));
			AnimSeqEnter = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqEnter_Offset));
			AnimSeqExit = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqExit_Offset));
			AnimSeqMoveFwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqMoveFwd_Offset));
			AnimSeqMoveBwd = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqMoveBwd_Offset));
			AnimSeqMoveLeft = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqMoveLeft_Offset));
			AnimSeqMoveRight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqMoveRight_Offset));
		}
	}

	static FBUAnimSettingsLocomotionEx()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBUAnimSettingsLocomotionEx)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBUAnimSettingsLocomotionEx));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BUAnimSettingsLocomotionEx");
		FBUAnimSettingsLocomotionEx_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UpperBodyOnly_PropertyAddress, intPtr, "bUpperBodyOnly");
		UpperBodyOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUpperBodyOnly");
		UpperBodyOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUpperBodyOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseExAnim_PropertyAddress, intPtr, "bUseExAnim");
		UseExAnim_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseExAnim");
		UseExAnim_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseExAnim", Classes.FBoolProperty);
		AnimSeqIdle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqIdle");
		AnimSeqIdle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqIdle", Classes.FObjectProperty);
		AnimSeqEnter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqEnter");
		AnimSeqEnter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqEnter", Classes.FObjectProperty);
		AnimSeqExit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqExit");
		AnimSeqExit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqExit", Classes.FObjectProperty);
		AnimSeqMoveFwd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqMoveFwd");
		AnimSeqMoveFwd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqMoveFwd", Classes.FObjectProperty);
		AnimSeqMoveBwd_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqMoveBwd");
		AnimSeqMoveBwd_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqMoveBwd", Classes.FObjectProperty);
		AnimSeqMoveLeft_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqMoveLeft");
		AnimSeqMoveLeft_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqMoveLeft", Classes.FObjectProperty);
		AnimSeqMoveRight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimSeqMoveRight");
		AnimSeqMoveRight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimSeqMoveRight", Classes.FObjectProperty);
		FBUAnimSettingsLocomotionEx_IsValid = intPtr != IntPtr.Zero && UpperBodyOnly_IsValid && UseExAnim_IsValid && AnimSeqIdle_IsValid && AnimSeqEnter_IsValid && AnimSeqExit_IsValid && AnimSeqMoveFwd_IsValid && AnimSeqMoveBwd_IsValid && AnimSeqMoveLeft_IsValid && AnimSeqMoveRight_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BUAnimSettingsLocomotionEx", FBUAnimSettingsLocomotionEx_IsValid);
	}
}
