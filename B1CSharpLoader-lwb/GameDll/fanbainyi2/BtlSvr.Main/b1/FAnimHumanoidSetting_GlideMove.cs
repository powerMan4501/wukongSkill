using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove")]
public struct FAnimHumanoidSetting_GlideMove
{
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove:bEnableGlideAnim")]
	public bool bEnableGlideAnim;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove:MoveParamCurve")]
	public UCurveVector MoveParamCurve;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove:Start")]
	public FAnimHumanoidSetting_GlideMove_Start Start;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove:Loop")]
	public FAnimHumanoidSetting_GlideMove_Loop Loop;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_GlideMove:End")]
	public FAnimHumanoidSetting_GlideMove_End End;

	private static int AnimHumanoidSetting_GlideMove_StructSize;

	private static int AnimHumanoidSetting_GlideMove_IsValid;

	private static bool bEnableGlideAnim_IsValid;

	private static int bEnableGlideAnim_Offset;

	private static FFieldAddress bEnableGlideAnim_PropertyAddress;

	private static bool MoveParamCurve_IsValid;

	private static int MoveParamCurve_Offset;

	private static bool Start_IsValid;

	private static int Start_Offset;

	private static bool Loop_IsValid;

	private static int Loop_Offset;

	private static bool End_IsValid;

	private static int End_Offset;

	public FAnimHumanoidSetting_GlideMove Copy()
	{
		return this;
	}

	public static FAnimHumanoidSetting_GlideMove FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_GlideMove(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_GlideMove value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_GlideMove FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_GlideMove(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_GlideMove value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_GlideMove_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableGlideAnim_Offset), 0, bEnableGlideAnim_PropertyAddress.Address, bEnableGlideAnim);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(nativeStruct, MoveParamCurve_Offset), MoveParamCurve);
		FAnimHumanoidSetting_GlideMove_Start.ToNative(IntPtr.Add(nativeStruct, Start_Offset), Start);
		FAnimHumanoidSetting_GlideMove_Loop.ToNative(IntPtr.Add(nativeStruct, Loop_Offset), Loop);
		FAnimHumanoidSetting_GlideMove_End.ToNative(IntPtr.Add(nativeStruct, End_Offset), End);
	}

	public FAnimHumanoidSetting_GlideMove(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_GlideMove_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_GlideMove");
			bEnableGlideAnim = false;
			MoveParamCurve = null;
			Start = default(FAnimHumanoidSetting_GlideMove_Start);
			Loop = default(FAnimHumanoidSetting_GlideMove_Loop);
			End = default(FAnimHumanoidSetting_GlideMove_End);
		}
		else
		{
			bEnableGlideAnim = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableGlideAnim_Offset), 0, bEnableGlideAnim_PropertyAddress.Address);
			MoveParamCurve = UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(nativeStruct, MoveParamCurve_Offset));
			Start = FAnimHumanoidSetting_GlideMove_Start.FromNative(IntPtr.Add(nativeStruct, Start_Offset));
			Loop = FAnimHumanoidSetting_GlideMove_Loop.FromNative(IntPtr.Add(nativeStruct, Loop_Offset));
			End = FAnimHumanoidSetting_GlideMove_End.FromNative(IntPtr.Add(nativeStruct, End_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_GlideMove");
		AnimHumanoidSetting_GlideMove_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bEnableGlideAnim_PropertyAddress, intPtr, "bEnableGlideAnim");
		bEnableGlideAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableGlideAnim");
		bEnableGlideAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableGlideAnim", Classes.FBoolProperty);
		MoveParamCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "MoveParamCurve");
		MoveParamCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MoveParamCurve", Classes.FObjectProperty);
		Start_Offset = NativeReflection.GetPropertyOffset(intPtr, "Start");
		Start_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Start", Classes.FStructProperty);
		Loop_Offset = NativeReflection.GetPropertyOffset(intPtr, "Loop");
		Loop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Loop", Classes.FStructProperty);
		End_Offset = NativeReflection.GetPropertyOffset(intPtr, "End");
		End_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "End", Classes.FStructProperty);
		AnimHumanoidSetting_GlideMove_IsValid = ((intPtr != IntPtr.Zero && bEnableGlideAnim_IsValid && MoveParamCurve_IsValid && Start_IsValid && Loop_IsValid && End_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_GlideMove", (byte)AnimHumanoidSetting_GlideMove_IsValid != 0);
	}

	static FAnimHumanoidSetting_GlideMove()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_GlideMove)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_GlideMove));
	}
}
