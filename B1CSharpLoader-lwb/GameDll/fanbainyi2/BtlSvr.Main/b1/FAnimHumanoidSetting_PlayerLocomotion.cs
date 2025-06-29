using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion")]
public struct FAnimHumanoidSetting_PlayerLocomotion
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASIdleList")]
	public List<UAnimSequence> ASIdleList;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASSequenceTransitionMoveFromWalkLFoot")]
	public UAnimSequence ASSequenceTransitionMoveFromWalkLFoot;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASSequenceTransitionMoveFromWalkRFoot")]
	public UAnimSequence ASSequenceTransitionMoveFromWalkRFoot;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASSequenceTransitionMoveFromRunLFoot")]
	public UAnimSequence ASSequenceTransitionMoveFromRunLFoot;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASSequenceTransitionMoveFromRunRFoot")]
	public UAnimSequence ASSequenceTransitionMoveFromRunRFoot;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASSequenceTransitionMoveFromRushLFoot")]
	public UAnimSequence ASSequenceTransitionMoveFromRushLFoot;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:ASSequenceTransitionMoveFromRushRFoot")]
	public UAnimSequence ASSequenceTransitionMoveFromRushRFoot;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:Free")]
	public FAnimHumanoidSetting_PlayerLocomotion_Free Free;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion:Lock")]
	public FAnimHumanoidSetting_PlayerLocomotion_Lock Lock;

	private static int AnimHumanoidSetting_PlayerLocomotion_StructSize;

	private static int AnimHumanoidSetting_PlayerLocomotion_IsValid;

	private static bool ASIdleList_IsValid;

	private static int ASIdleList_Offset;

	private static FFieldAddress ASIdleList_PropertyAddress;

	private static bool ASSequenceTransitionMoveFromWalkLFoot_IsValid;

	private static int ASSequenceTransitionMoveFromWalkLFoot_Offset;

	private static bool ASSequenceTransitionMoveFromWalkRFoot_IsValid;

	private static int ASSequenceTransitionMoveFromWalkRFoot_Offset;

	private static bool ASSequenceTransitionMoveFromRunLFoot_IsValid;

	private static int ASSequenceTransitionMoveFromRunLFoot_Offset;

	private static bool ASSequenceTransitionMoveFromRunRFoot_IsValid;

	private static int ASSequenceTransitionMoveFromRunRFoot_Offset;

	private static bool ASSequenceTransitionMoveFromRushLFoot_IsValid;

	private static int ASSequenceTransitionMoveFromRushLFoot_Offset;

	private static bool ASSequenceTransitionMoveFromRushRFoot_IsValid;

	private static int ASSequenceTransitionMoveFromRushRFoot_Offset;

	private static bool Free_IsValid;

	private static int Free_Offset;

	private static bool Lock_IsValid;

	private static int Lock_Offset;

	public FAnimHumanoidSetting_PlayerLocomotion Copy()
	{
		FAnimHumanoidSetting_PlayerLocomotion result = this;
		if (ASIdleList != null)
		{
			result.ASIdleList = new List<UAnimSequence>(ASIdleList);
		}
		return result;
	}

	public static FAnimHumanoidSetting_PlayerLocomotion FromNative(IntPtr nativeBuffer)
	{
		return new FAnimHumanoidSetting_PlayerLocomotion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimHumanoidSetting_PlayerLocomotion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimHumanoidSetting_PlayerLocomotion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimHumanoidSetting_PlayerLocomotion(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_PlayerLocomotion_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimHumanoidSetting_PlayerLocomotion value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AnimHumanoidSetting_PlayerLocomotion_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_PlayerLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion");
			return;
		}
		new TArrayCopyMarshaler<UAnimSequence>(1, ASIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).ToNative(IntPtr.Add(nativeStruct, ASIdleList_Offset), ASIdleList);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromWalkLFoot_Offset), ASSequenceTransitionMoveFromWalkLFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromWalkRFoot_Offset), ASSequenceTransitionMoveFromWalkRFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRunLFoot_Offset), ASSequenceTransitionMoveFromRunLFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRunRFoot_Offset), ASSequenceTransitionMoveFromRunRFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRushLFoot_Offset), ASSequenceTransitionMoveFromRushLFoot);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRushRFoot_Offset), ASSequenceTransitionMoveFromRushRFoot);
		FAnimHumanoidSetting_PlayerLocomotion_Free.ToNative(IntPtr.Add(nativeStruct, Free_Offset), Free);
		FAnimHumanoidSetting_PlayerLocomotion_Lock.ToNative(IntPtr.Add(nativeStruct, Lock_Offset), Lock);
	}

	public FAnimHumanoidSetting_PlayerLocomotion(IntPtr nativeStruct)
	{
		if (AnimHumanoidSetting_PlayerLocomotion_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion");
			ASIdleList = null;
			ASSequenceTransitionMoveFromWalkLFoot = null;
			ASSequenceTransitionMoveFromWalkRFoot = null;
			ASSequenceTransitionMoveFromRunLFoot = null;
			ASSequenceTransitionMoveFromRunRFoot = null;
			ASSequenceTransitionMoveFromRushLFoot = null;
			ASSequenceTransitionMoveFromRushRFoot = null;
			Free = default(FAnimHumanoidSetting_PlayerLocomotion_Free);
			Lock = default(FAnimHumanoidSetting_PlayerLocomotion_Lock);
		}
		else
		{
			ASIdleList = new TArrayCopyMarshaler<UAnimSequence>(1, ASIdleList_PropertyAddress, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.FromNative, CachedMarshalingDelegates<UAnimSequence, UObjectMarshaler<UAnimSequence>>.ToNative).FromNative(IntPtr.Add(nativeStruct, ASIdleList_Offset));
			ASSequenceTransitionMoveFromWalkLFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromWalkLFoot_Offset));
			ASSequenceTransitionMoveFromWalkRFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromWalkRFoot_Offset));
			ASSequenceTransitionMoveFromRunLFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRunLFoot_Offset));
			ASSequenceTransitionMoveFromRunRFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRunRFoot_Offset));
			ASSequenceTransitionMoveFromRushLFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRushLFoot_Offset));
			ASSequenceTransitionMoveFromRushRFoot = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(nativeStruct, ASSequenceTransitionMoveFromRushRFoot_Offset));
			Free = FAnimHumanoidSetting_PlayerLocomotion_Free.FromNative(IntPtr.Add(nativeStruct, Free_Offset));
			Lock = FAnimHumanoidSetting_PlayerLocomotion_Lock.FromNative(IntPtr.Add(nativeStruct, Lock_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion");
		AnimHumanoidSetting_PlayerLocomotion_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ASIdleList_PropertyAddress, intPtr, "ASIdleList");
		ASIdleList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASIdleList");
		ASIdleList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASIdleList", Classes.FArrayProperty);
		ASSequenceTransitionMoveFromWalkLFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSequenceTransitionMoveFromWalkLFoot");
		ASSequenceTransitionMoveFromWalkLFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSequenceTransitionMoveFromWalkLFoot", Classes.FObjectProperty);
		ASSequenceTransitionMoveFromWalkRFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSequenceTransitionMoveFromWalkRFoot");
		ASSequenceTransitionMoveFromWalkRFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSequenceTransitionMoveFromWalkRFoot", Classes.FObjectProperty);
		ASSequenceTransitionMoveFromRunLFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSequenceTransitionMoveFromRunLFoot");
		ASSequenceTransitionMoveFromRunLFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSequenceTransitionMoveFromRunLFoot", Classes.FObjectProperty);
		ASSequenceTransitionMoveFromRunRFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSequenceTransitionMoveFromRunRFoot");
		ASSequenceTransitionMoveFromRunRFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSequenceTransitionMoveFromRunRFoot", Classes.FObjectProperty);
		ASSequenceTransitionMoveFromRushLFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSequenceTransitionMoveFromRushLFoot");
		ASSequenceTransitionMoveFromRushLFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSequenceTransitionMoveFromRushLFoot", Classes.FObjectProperty);
		ASSequenceTransitionMoveFromRushRFoot_Offset = NativeReflection.GetPropertyOffset(intPtr, "ASSequenceTransitionMoveFromRushRFoot");
		ASSequenceTransitionMoveFromRushRFoot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ASSequenceTransitionMoveFromRushRFoot", Classes.FObjectProperty);
		Free_Offset = NativeReflection.GetPropertyOffset(intPtr, "Free");
		Free_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Free", Classes.FStructProperty);
		Lock_Offset = NativeReflection.GetPropertyOffset(intPtr, "Lock");
		Lock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Lock", Classes.FStructProperty);
		AnimHumanoidSetting_PlayerLocomotion_IsValid = ((intPtr != IntPtr.Zero && ASIdleList_IsValid && ASSequenceTransitionMoveFromWalkLFoot_IsValid && ASSequenceTransitionMoveFromWalkRFoot_IsValid && ASSequenceTransitionMoveFromRunLFoot_IsValid && ASSequenceTransitionMoveFromRunRFoot_IsValid && ASSequenceTransitionMoveFromRushLFoot_IsValid && ASSequenceTransitionMoveFromRushRFoot_IsValid && Free_IsValid && Lock_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AnimHumanoidSetting_PlayerLocomotion", (byte)AnimHumanoidSetting_PlayerLocomotion_IsValid != 0);
	}

	static FAnimHumanoidSetting_PlayerLocomotion()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_PlayerLocomotion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_PlayerLocomotion));
	}
}
