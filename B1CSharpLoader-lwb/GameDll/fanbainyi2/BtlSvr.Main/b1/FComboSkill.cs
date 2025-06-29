using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ComboSkill")]
public struct FComboSkill
{
	[Category("AI|Skill")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ComboSkill:SkillID")]
	public List<int> SkillID;

	private static int ComboSkill_StructSize;

	private static int ComboSkill_IsValid;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static FFieldAddress SkillID_PropertyAddress;

	public FComboSkill Copy()
	{
		FComboSkill result = this;
		if (SkillID != null)
		{
			result.SkillID = new List<int>(SkillID);
		}
		return result;
	}

	public static FComboSkill FromNative(IntPtr nativeBuffer)
	{
		return new FComboSkill(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FComboSkill value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FComboSkill FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FComboSkill(IntPtr.Add(nativeBuffer, arrayIndex * ComboSkill_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FComboSkill value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ComboSkill_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ComboSkill_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ComboSkill");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		}
	}

	public FComboSkill(IntPtr nativeStruct)
	{
		if (ComboSkill_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ComboSkill");
			SkillID = null;
		}
		else
		{
			SkillID = new TArrayCopyMarshaler<int>(1, SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ComboSkill");
		ComboSkill_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref SkillID_PropertyAddress, intPtr, "SkillID");
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FArrayProperty);
		ComboSkill_IsValid = ((intPtr != IntPtr.Zero && SkillID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ComboSkill", (byte)ComboSkill_IsValid != 0);
	}

	static FComboSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FComboSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComboSkill));
	}
}
