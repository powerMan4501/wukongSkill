using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AvoidObstacleSection")]
public struct FAvoidObstacleSection
{
	[DisplayName("起始角度")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AvoidObstacleSection:StartAngle")]
	public float StartAngle;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("终止角度")]
	[USharpPath("/Script/b1-Managed.AvoidObstacleSection:EndAngle")]
	public float EndAngle;

	[UProperty]
	[EditAnywhere]
	[DisplayName("技能列表")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.AvoidObstacleSection:SkillList")]
	public List<int> SkillList;

	private static int AvoidObstacleSection_StructSize;

	private static int AvoidObstacleSection_IsValid;

	private static bool StartAngle_IsValid;

	private static int StartAngle_Offset;

	private static bool EndAngle_IsValid;

	private static int EndAngle_Offset;

	private static bool SkillList_IsValid;

	private static int SkillList_Offset;

	private static FFieldAddress SkillList_PropertyAddress;

	public FAvoidObstacleSection Copy()
	{
		FAvoidObstacleSection result = this;
		if (SkillList != null)
		{
			result.SkillList = new List<int>(SkillList);
		}
		return result;
	}

	public static FAvoidObstacleSection FromNative(IntPtr nativeBuffer)
	{
		return new FAvoidObstacleSection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAvoidObstacleSection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAvoidObstacleSection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAvoidObstacleSection(IntPtr.Add(nativeBuffer, arrayIndex * AvoidObstacleSection_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAvoidObstacleSection value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AvoidObstacleSection_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AvoidObstacleSection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AvoidObstacleSection");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StartAngle_Offset), StartAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EndAngle_Offset), EndAngle);
		new TArrayCopyMarshaler<int>(1, SkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillList_Offset), SkillList);
	}

	public FAvoidObstacleSection(IntPtr nativeStruct)
	{
		if (AvoidObstacleSection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AvoidObstacleSection");
			StartAngle = 0f;
			EndAngle = 0f;
			SkillList = null;
		}
		else
		{
			StartAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StartAngle_Offset));
			EndAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EndAngle_Offset));
			SkillList = new TArrayCopyMarshaler<int>(1, SkillList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AvoidObstacleSection");
		AvoidObstacleSection_StructSize = NativeReflection.GetStructSize(intPtr);
		StartAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartAngle");
		StartAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartAngle", Classes.FFloatProperty);
		EndAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndAngle");
		EndAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SkillList_PropertyAddress, intPtr, "SkillList");
		SkillList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillList");
		SkillList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillList", Classes.FArrayProperty);
		AvoidObstacleSection_IsValid = ((intPtr != IntPtr.Zero && StartAngle_IsValid && EndAngle_IsValid && SkillList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AvoidObstacleSection", (byte)AvoidObstacleSection_IsValid != 0);
	}

	static FAvoidObstacleSection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAvoidObstacleSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAvoidObstacleSection));
	}
}
