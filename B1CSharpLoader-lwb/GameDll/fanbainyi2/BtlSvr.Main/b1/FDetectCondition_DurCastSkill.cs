using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_DurCastSkill")]
public struct FDetectCondition_DurCastSkill
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_DurCastSkill:SkillIdList")]
	public List<int> SkillIdList;

	private static int DetectCondition_DurCastSkill_StructSize;

	private static int DetectCondition_DurCastSkill_IsValid;

	private static bool SkillIdList_IsValid;

	private static int SkillIdList_Offset;

	private static FFieldAddress SkillIdList_PropertyAddress;

	public FDetectCondition_DurCastSkill Copy()
	{
		FDetectCondition_DurCastSkill result = this;
		if (SkillIdList != null)
		{
			result.SkillIdList = new List<int>(SkillIdList);
		}
		return result;
	}

	public static FDetectCondition_DurCastSkill FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_DurCastSkill(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_DurCastSkill value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_DurCastSkill FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_DurCastSkill(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_DurCastSkill_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_DurCastSkill value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_DurCastSkill_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_DurCastSkill_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_DurCastSkill");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, SkillIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillIdList_Offset), SkillIdList);
		}
	}

	public FDetectCondition_DurCastSkill(IntPtr nativeStruct)
	{
		if (DetectCondition_DurCastSkill_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_DurCastSkill");
			SkillIdList = null;
		}
		else
		{
			SkillIdList = new TArrayCopyMarshaler<int>(1, SkillIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillIdList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_DurCastSkill");
		DetectCondition_DurCastSkill_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SkillIdList_PropertyAddress, intPtr, "SkillIdList");
		SkillIdList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIdList");
		SkillIdList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIdList", Classes.FArrayProperty);
		DetectCondition_DurCastSkill_IsValid = ((intPtr != IntPtr.Zero && SkillIdList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_DurCastSkill", (byte)DetectCondition_DurCastSkill_IsValid != 0);
	}

	static FDetectCondition_DurCastSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_DurCastSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_DurCastSkill));
	}
}
