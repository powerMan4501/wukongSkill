using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider")]
public struct FAnimHumanoidSetting_Spider
{
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:AnimSeqIdle")]
	public UAnimSequence AnimSeqIdle;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:JumpStart")]
	public UAnimSequence JumpStart;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:JumpLoop")]
	public UAnimSequence JumpLoop;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:JumpEndLight")]
	public UAnimSequence JumpEndLight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:JumpEndHeavy")]
	public UAnimSequence JumpEndHeavy;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:FallingHeightThreshold")]
	public float FallingHeightThreshold;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:RelativeScale")]
	public float RelativeScale;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:LegMoveDistance")]
	public List<float> LegMoveDistance;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:LegForwardDistance")]
	public List<float> LegForwardDistance;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider:LegNames")]
	public List<FName> LegNames;

	private static int AnimHumanoidSetting_Spider_StructSize;

	private static int AnimHumanoidSetting_Spider_IsValid;

	private static bool AnimSeqIdle_IsValid;

	private static int AnimSeqIdle_Offset;

	private static bool JumpStart_IsValid;

	private static int JumpStart_Offset;

	private static bool JumpLoop_IsValid;

	private static int JumpLoop_Offset;

	private static bool JumpEndLight_IsValid;

	private static int JumpEndLight_Offset;

	private static bool JumpEndHeavy_IsValid;

	private static int JumpEndHeavy_Offset;

	private static bool FallingHeightThreshold_IsValid;

	private static int FallingHeightThreshold_Offset;

	private static bool RelativeScale_IsValid;

	private static int RelativeScale_Offset;

	private static bool LegMoveDistance_IsValid;

	private static int LegMoveDistance_Offset;

	private static FFieldAddress LegMoveDistance_PropertyAddress;

	private static bool LegForwardDistance_IsValid;

	private static int LegForwardDistance_Offset;

	private static FFieldAddress LegForwardDistance_PropertyAddress;

	private static bool LegNames_IsValid;

	private static int LegNames_Offset;

	private static FFieldAddress LegNames_PropertyAddress;

	public FAnimHumanoidSetting_Spider Copy()
	{
		FAnimHumanoidSetting_Spider result = this;
		if (LegMoveDistance != null)
		{
			result.LegMoveDistance = new List<float>(LegMoveDistance);
		}
		if (LegForwardDistance != null)
		{
			result.LegForwardDistance = new List<float>(LegForwardDistance);
		}
		if (LegNames != null)
		{
			result.LegNames = new List<FName>(LegNames);
		}
		return result;
	}

	public static FAnimHumanoidSetting_Spider FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_Spider(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_Spider value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_Spider FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_Spider(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Spider_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_Spider value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_Spider_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Spider_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Spider");
			return;
		}
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, AnimSeqIdle_Offset), AnimSeqIdle);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, JumpStart_Offset), JumpStart);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, JumpLoop_Offset), JumpLoop);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, JumpEndLight_Offset), JumpEndLight);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, JumpEndHeavy_Offset), JumpEndHeavy);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FallingHeightThreshold_Offset), FallingHeightThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RelativeScale_Offset), RelativeScale);
		new TArrayCopyMarshaler<float>(1, LegMoveDistance_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LegMoveDistance_Offset), LegMoveDistance);
		new TArrayCopyMarshaler<float>(1, LegForwardDistance_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LegForwardDistance_Offset), LegForwardDistance);
		new TArrayCopyMarshaler<FName>(1, LegNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LegNames_Offset), LegNames);
	}

	public FAnimHumanoidSetting_Spider(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_Spider_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_Spider");
			AnimSeqIdle = null;
			JumpStart = null;
			JumpLoop = null;
			JumpEndLight = null;
			JumpEndHeavy = null;
			FallingHeightThreshold = 0f;
			RelativeScale = 0f;
			LegMoveDistance = null;
			LegForwardDistance = null;
			LegNames = null;
		}
		else
		{
			AnimSeqIdle = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, AnimSeqIdle_Offset));
			JumpStart = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, JumpStart_Offset));
			JumpLoop = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, JumpLoop_Offset));
			JumpEndLight = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, JumpEndLight_Offset));
			JumpEndHeavy = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, JumpEndHeavy_Offset));
			FallingHeightThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FallingHeightThreshold_Offset));
			RelativeScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RelativeScale_Offset));
			LegMoveDistance = new TArrayCopyMarshaler<float>(1, LegMoveDistance_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LegMoveDistance_Offset));
			LegForwardDistance = new TArrayCopyMarshaler<float>(1, LegForwardDistance_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LegForwardDistance_Offset));
			LegNames = new TArrayCopyMarshaler<FName>(1, LegNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LegNames_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Spider");
		AnimHumanoidSetting_Spider_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimSeqIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSeqIdle");
		AnimSeqIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSeqIdle", Classes.FObjectProperty);
		JumpStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpStart");
		JumpStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpStart", Classes.FObjectProperty);
		JumpLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpLoop");
		JumpLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpLoop", Classes.FObjectProperty);
		JumpEndLight_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpEndLight");
		JumpEndLight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpEndLight", Classes.FObjectProperty);
		JumpEndHeavy_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpEndHeavy");
		JumpEndHeavy_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpEndHeavy", Classes.FObjectProperty);
		FallingHeightThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "FallingHeightThreshold");
		FallingHeightThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FallingHeightThreshold", Classes.FFloatProperty);
		RelativeScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelativeScale");
		RelativeScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelativeScale", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref LegMoveDistance_PropertyAddress, intPtr, "LegMoveDistance");
		LegMoveDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegMoveDistance");
		LegMoveDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegMoveDistance", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegForwardDistance_PropertyAddress, intPtr, "LegForwardDistance");
		LegForwardDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegForwardDistance");
		LegForwardDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegForwardDistance", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LegNames_PropertyAddress, intPtr, "LegNames");
		LegNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "LegNames");
		LegNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LegNames", Classes.FArrayProperty);
		AnimHumanoidSetting_Spider_IsValid = ((intPtr != IntPtr.Zero && AnimSeqIdle_IsValid && JumpStart_IsValid && JumpLoop_IsValid && JumpEndLight_IsValid && JumpEndHeavy_IsValid && FallingHeightThreshold_IsValid && RelativeScale_IsValid && LegMoveDistance_IsValid && LegForwardDistance_IsValid && LegNames_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_Spider", (byte)AnimHumanoidSetting_Spider_IsValid != 0);
	}

	static FAnimHumanoidSetting_Spider()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Spider)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Spider));
	}
}
