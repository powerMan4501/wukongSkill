using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ContinueBehaviorInfo")]
public struct FContinueBehaviorInfo
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.ContinueBehaviorInfo:CBT")]
	public EContinueBehaviorType CBT;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ContinueBehaviorInfo:MontagePos")]
	public float MontagePos;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ContinueBehaviorInfo:SkillID")]
	public int SkillID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.ContinueBehaviorInfo:BeatbackMontage")]
	public UAnimMontage BeatbackMontage;

	private static int ContinueBehaviorInfo_StructSize;

	private static int ContinueBehaviorInfo_IsValid;

	private static bool CBT_IsValid;

	private static int CBT_Offset;

	private static FFieldAddress CBT_PropertyAddress;

	private static bool MontagePos_IsValid;

	private static int MontagePos_Offset;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool BeatbackMontage_IsValid;

	private static int BeatbackMontage_Offset;

	public FContinueBehaviorInfo Copy()
	{
		return this;
	}

	public static FContinueBehaviorInfo FromNative(IntPtr nativeBuffer)
	{
		return new FContinueBehaviorInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FContinueBehaviorInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FContinueBehaviorInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FContinueBehaviorInfo(IntPtr.Add(nativeBuffer, arrayIndex * ContinueBehaviorInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FContinueBehaviorInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ContinueBehaviorInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ContinueBehaviorInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ContinueBehaviorInfo");
			return;
		}
		EnumMarshaler<EContinueBehaviorType>.ToNative(IntPtr.Add(nativeStruct, CBT_Offset), 0, CBT_PropertyAddress.Address, CBT);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MontagePos_Offset), MontagePos);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(nativeStruct, BeatbackMontage_Offset), BeatbackMontage);
	}

	public FContinueBehaviorInfo(IntPtr nativeStruct)
	{
		if (ContinueBehaviorInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ContinueBehaviorInfo");
			CBT = EContinueBehaviorType.None;
			MontagePos = 0f;
			SkillID = 0;
			BeatbackMontage = null;
		}
		else
		{
			CBT = EnumMarshaler<EContinueBehaviorType>.FromNative(IntPtr.Add(nativeStruct, CBT_Offset), 0, CBT_PropertyAddress.Address);
			MontagePos = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MontagePos_Offset));
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			BeatbackMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(nativeStruct, BeatbackMontage_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ContinueBehaviorInfo");
		ContinueBehaviorInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CBT_PropertyAddress, intPtr, "CBT");
		CBT_Offset = NativeReflection.GetPropertyOffset(intPtr, "CBT");
		CBT_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CBT", Classes.FEnumProperty);
		MontagePos_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontagePos");
		MontagePos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontagePos", Classes.FFloatProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		BeatbackMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeatbackMontage");
		BeatbackMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeatbackMontage", Classes.FObjectProperty);
		ContinueBehaviorInfo_IsValid = ((intPtr != IntPtr.Zero && CBT_IsValid && MontagePos_IsValid && SkillID_IsValid && BeatbackMontage_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ContinueBehaviorInfo", (byte)ContinueBehaviorInfo_IsValid != 0);
	}

	static FContinueBehaviorInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FContinueBehaviorInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FContinueBehaviorInfo));
	}
}
