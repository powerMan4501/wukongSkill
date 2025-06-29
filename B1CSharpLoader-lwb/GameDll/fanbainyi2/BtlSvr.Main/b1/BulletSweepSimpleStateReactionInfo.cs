using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo")]
public struct BulletSweepSimpleStateReactionInfo
{
	[DisplayName("Sweep单位的SimpleState")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo:ConditionSimpleState")]
	public EBGUSimpleState ConditionSimpleState;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("子弹触发EffectID")]
	[USharpPath("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo:TriggerEffectID")]
	public List<int> TriggerEffectID;

	private static int BulletSweepSimpleStateReactionInfo_StructSize;

	private static int BulletSweepSimpleStateReactionInfo_IsValid;

	private static bool ConditionSimpleState_IsValid;

	private static int ConditionSimpleState_Offset;

	private static FFieldAddress ConditionSimpleState_PropertyAddress;

	private static bool TriggerEffectID_IsValid;

	private static int TriggerEffectID_Offset;

	private static FFieldAddress TriggerEffectID_PropertyAddress;

	public BulletSweepSimpleStateReactionInfo Copy()
	{
		BulletSweepSimpleStateReactionInfo result = this;
		if (TriggerEffectID != null)
		{
			result.TriggerEffectID = new List<int>(TriggerEffectID);
		}
		return result;
	}

	public static BulletSweepSimpleStateReactionInfo FromNative(IntPtr nativeBuffer)
	{
		return new BulletSweepSimpleStateReactionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BulletSweepSimpleStateReactionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BulletSweepSimpleStateReactionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BulletSweepSimpleStateReactionInfo(IntPtr.Add(nativeBuffer, arrayIndex * BulletSweepSimpleStateReactionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BulletSweepSimpleStateReactionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BulletSweepSimpleStateReactionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BulletSweepSimpleStateReactionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo");
			return;
		}
		EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(nativeStruct, ConditionSimpleState_Offset), 0, ConditionSimpleState_PropertyAddress.Address, ConditionSimpleState);
		new TArrayCopyMarshaler<int>(1, TriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerEffectID_Offset), TriggerEffectID);
	}

	public BulletSweepSimpleStateReactionInfo(IntPtr nativeStruct)
	{
		if (BulletSweepSimpleStateReactionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo");
			ConditionSimpleState = EBGUSimpleState.Normal;
			TriggerEffectID = null;
		}
		else
		{
			ConditionSimpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(nativeStruct, ConditionSimpleState_Offset), 0, ConditionSimpleState_PropertyAddress.Address);
			TriggerEffectID = new TArrayCopyMarshaler<int>(1, TriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerEffectID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo");
		BulletSweepSimpleStateReactionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref ConditionSimpleState_PropertyAddress, intPtr, "ConditionSimpleState");
		ConditionSimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConditionSimpleState");
		ConditionSimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConditionSimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TriggerEffectID_PropertyAddress, intPtr, "TriggerEffectID");
		TriggerEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEffectID");
		TriggerEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEffectID", Classes.FArrayProperty);
		BulletSweepSimpleStateReactionInfo_IsValid = ((intPtr != IntPtr.Zero && ConditionSimpleState_IsValid && TriggerEffectID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BulletSweepSimpleStateReactionInfo", (byte)BulletSweepSimpleStateReactionInfo_IsValid != 0);
	}

	static BulletSweepSimpleStateReactionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BulletSweepSimpleStateReactionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BulletSweepSimpleStateReactionInfo));
	}
}
