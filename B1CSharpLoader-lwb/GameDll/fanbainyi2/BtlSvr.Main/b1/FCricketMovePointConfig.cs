using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.CricketMovePointConfig")]
public struct FCricketMovePointConfig
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CricketMovePointConfig:PointTrans")]
	public FTransform PointTrans;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CricketMovePointConfig:IdleTime")]
	public float IdleTime;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CricketMovePointConfig:AnimIdleList")]
	public List<UAnimSequence> AnimIdleList;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CricketMovePointConfig:JumpAnim")]
	public UAnimMontage JumpAnim;

	private static int CricketMovePointConfig_StructSize;

	private static int CricketMovePointConfig_IsValid;

	private static bool PointTrans_IsValid;

	private static int PointTrans_Offset;

	private static bool IdleTime_IsValid;

	private static int IdleTime_Offset;

	private static bool AnimIdleList_IsValid;

	private static int AnimIdleList_Offset;

	private static FFieldAddress AnimIdleList_PropertyAddress;

	private static bool JumpAnim_IsValid;

	private static int JumpAnim_Offset;

	public FCricketMovePointConfig Copy()
	{
		FCricketMovePointConfig result = this;
		if (AnimIdleList != null)
		{
			result.AnimIdleList = new List<UAnimSequence>(AnimIdleList);
		}
		return result;
	}

	public static FCricketMovePointConfig FromNative(IntPtr nativeBuffer)
	{
		return new FCricketMovePointConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCricketMovePointConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCricketMovePointConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCricketMovePointConfig(IntPtr.Add(nativeBuffer, arrayIndex * CricketMovePointConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCricketMovePointConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CricketMovePointConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CricketMovePointConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CricketMovePointConfig");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, PointTrans_Offset), PointTrans);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IdleTime_Offset), IdleTime);
		new TArrayCopyMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AnimIdleList_Offset), AnimIdleList);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, JumpAnim_Offset), JumpAnim);
	}

	public FCricketMovePointConfig(IntPtr nativeStruct)
	{
		if (CricketMovePointConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CricketMovePointConfig");
			PointTrans = default(FTransform);
			IdleTime = 0f;
			AnimIdleList = null;
			JumpAnim = null;
		}
		else
		{
			PointTrans = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, PointTrans_Offset));
			IdleTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IdleTime_Offset));
			AnimIdleList = new TArrayCopyMarshaler<UAnimSequence>(1, AnimIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AnimIdleList_Offset));
			JumpAnim = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, JumpAnim_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CricketMovePointConfig");
		CricketMovePointConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		PointTrans_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointTrans");
		PointTrans_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointTrans", Classes.FStructProperty);
		IdleTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IdleTime");
		IdleTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IdleTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AnimIdleList_PropertyAddress, intPtr, "AnimIdleList");
		AnimIdleList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdleList");
		AnimIdleList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdleList", Classes.FArrayProperty);
		JumpAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpAnim");
		JumpAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpAnim", Classes.FObjectProperty);
		CricketMovePointConfig_IsValid = ((intPtr != IntPtr.Zero && PointTrans_IsValid && IdleTime_IsValid && AnimIdleList_IsValid && JumpAnim_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CricketMovePointConfig", (byte)CricketMovePointConfig_IsValid != 0);
	}

	static FCricketMovePointConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCricketMovePointConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCricketMovePointConfig));
	}
}
