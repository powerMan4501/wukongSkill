using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BulletBeAttackedReactionInfo")]
public struct BulletBeAttackedReactionInfo
{
	[DisplayName("触发条件ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BulletBeAttackedReactionInfo:CheckID")]
	public int CheckID;

	[DisplayName("子弹自身触发EffectID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BulletBeAttackedReactionInfo:TriggerEffectID")]
	public List<int> TriggerEffectID;

	[DisplayName("攻击者触发EffectID")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BulletBeAttackedReactionInfo:AttackerTriggerEffectID")]
	public List<int> AttackerTriggerEffectID;

	private static int BulletBeAttackedReactionInfo_StructSize;

	private static int BulletBeAttackedReactionInfo_IsValid;

	private static bool CheckID_IsValid;

	private static int CheckID_Offset;

	private static bool TriggerEffectID_IsValid;

	private static int TriggerEffectID_Offset;

	private static FFieldAddress TriggerEffectID_PropertyAddress;

	private static bool AttackerTriggerEffectID_IsValid;

	private static int AttackerTriggerEffectID_Offset;

	private static FFieldAddress AttackerTriggerEffectID_PropertyAddress;

	public BulletBeAttackedReactionInfo Copy()
	{
		BulletBeAttackedReactionInfo result = this;
		if (TriggerEffectID != null)
		{
			result.TriggerEffectID = new List<int>(TriggerEffectID);
		}
		if (AttackerTriggerEffectID != null)
		{
			result.AttackerTriggerEffectID = new List<int>(AttackerTriggerEffectID);
		}
		return result;
	}

	public static BulletBeAttackedReactionInfo FromNative(IntPtr nativeBuffer)
	{
		return new BulletBeAttackedReactionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BulletBeAttackedReactionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BulletBeAttackedReactionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BulletBeAttackedReactionInfo(IntPtr.Add(nativeBuffer, arrayIndex * BulletBeAttackedReactionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BulletBeAttackedReactionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BulletBeAttackedReactionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BulletBeAttackedReactionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletBeAttackedReactionInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CheckID_Offset), CheckID);
		new TArrayCopyMarshaler<int>(1, TriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerEffectID_Offset), TriggerEffectID);
		new TArrayCopyMarshaler<int>(1, AttackerTriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, AttackerTriggerEffectID_Offset), AttackerTriggerEffectID);
	}

	public BulletBeAttackedReactionInfo(IntPtr nativeStruct)
	{
		if (BulletBeAttackedReactionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletBeAttackedReactionInfo");
			CheckID = 0;
			TriggerEffectID = null;
			AttackerTriggerEffectID = null;
		}
		else
		{
			CheckID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CheckID_Offset));
			TriggerEffectID = new TArrayCopyMarshaler<int>(1, TriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerEffectID_Offset));
			AttackerTriggerEffectID = new TArrayCopyMarshaler<int>(1, AttackerTriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, AttackerTriggerEffectID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BulletBeAttackedReactionInfo");
		BulletBeAttackedReactionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		CheckID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckID");
		CheckID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TriggerEffectID_PropertyAddress, intPtr, "TriggerEffectID");
		TriggerEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEffectID");
		TriggerEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEffectID", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref AttackerTriggerEffectID_PropertyAddress, intPtr, "AttackerTriggerEffectID");
		AttackerTriggerEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackerTriggerEffectID");
		AttackerTriggerEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackerTriggerEffectID", Classes.FArrayProperty);
		BulletBeAttackedReactionInfo_IsValid = ((intPtr != IntPtr.Zero && CheckID_IsValid && TriggerEffectID_IsValid && AttackerTriggerEffectID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BulletBeAttackedReactionInfo", (byte)BulletBeAttackedReactionInfo_IsValid != 0);
	}

	static BulletBeAttackedReactionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BulletBeAttackedReactionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BulletBeAttackedReactionInfo));
	}
}
