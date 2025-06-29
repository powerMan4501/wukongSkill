using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FBGMVolumeConditionGroup")]
public struct FBGMVolumeConditionGroup
{
	[Tooltip("满足所有条件才视为通过")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("与条件组")]
	[USharpPath("/Script/b1-Managed.FBGMVolumeConditionGroup:Conditions")]
	public List<FBGMVolumeCondition> Conditions;

	private static int FBGMVolumeConditionGroup_StructSize;

	private static int FBGMVolumeConditionGroup_IsValid;

	private static bool Conditions_IsValid;

	private static int Conditions_Offset;

	private static FFieldAddress Conditions_PropertyAddress;

	public FBGMVolumeConditionGroup Copy()
	{
		FBGMVolumeConditionGroup result = this;
		if (Conditions != null)
		{
			result.Conditions = new List<FBGMVolumeCondition>(Conditions);
		}
		return result;
	}

	public static FBGMVolumeConditionGroup FromNative(IntPtr nativeBuffer)
	{
		return new FBGMVolumeConditionGroup(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBGMVolumeConditionGroup value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBGMVolumeConditionGroup FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBGMVolumeConditionGroup(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeConditionGroup_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBGMVolumeConditionGroup value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FBGMVolumeConditionGroup_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FBGMVolumeConditionGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeConditionGroup");
		}
		else
		{
			new TArrayCopyMarshaler<FBGMVolumeCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FBGMVolumeCondition, FBGMVolumeCondition>.FromNative, CachedMarshalingDelegates<FBGMVolumeCondition, FBGMVolumeCondition>.ToNative).ToNative(IntPtr.Add(nativeStruct, Conditions_Offset), Conditions);
		}
	}

	public FBGMVolumeConditionGroup(IntPtr nativeStruct)
	{
		if (FBGMVolumeConditionGroup_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FBGMVolumeConditionGroup");
			Conditions = null;
		}
		else
		{
			Conditions = new TArrayCopyMarshaler<FBGMVolumeCondition>(1, Conditions_PropertyAddress, CachedMarshalingDelegates<FBGMVolumeCondition, FBGMVolumeCondition>.FromNative, CachedMarshalingDelegates<FBGMVolumeCondition, FBGMVolumeCondition>.ToNative).FromNative(IntPtr.Add(nativeStruct, Conditions_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FBGMVolumeConditionGroup");
		FBGMVolumeConditionGroup_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Conditions_PropertyAddress, intPtr, "Conditions");
		Conditions_Offset = NativeReflection.GetPropertyOffset(intPtr, "Conditions");
		Conditions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Conditions", Classes.FArrayProperty);
		FBGMVolumeConditionGroup_IsValid = ((intPtr != IntPtr.Zero && Conditions_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FBGMVolumeConditionGroup", (byte)FBGMVolumeConditionGroup_IsValid != 0);
	}

	static FBGMVolumeConditionGroup()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FBGMVolumeConditionGroup)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBGMVolumeConditionGroup));
	}
}
