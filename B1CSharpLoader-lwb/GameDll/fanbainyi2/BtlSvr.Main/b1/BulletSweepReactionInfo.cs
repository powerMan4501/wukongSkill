using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BulletSweepReactionInfo")]
public struct BulletSweepReactionInfo
{
	[DisplayName("触发条件ID")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BulletSweepReactionInfo:CheckID")]
	public int CheckID;

	[UProperty]
	[DisplayName("子弹触发EffectID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BulletSweepReactionInfo:TriggerEffectID")]
	public List<int> TriggerEffectID;

	private static int BulletSweepReactionInfo_StructSize;

	private static int BulletSweepReactionInfo_IsValid;

	private static bool CheckID_IsValid;

	private static int CheckID_Offset;

	private static bool TriggerEffectID_IsValid;

	private static int TriggerEffectID_Offset;

	private static FFieldAddress TriggerEffectID_PropertyAddress;

	public BulletSweepReactionInfo Copy()
	{
		BulletSweepReactionInfo result = this;
		if (TriggerEffectID != null)
		{
			result.TriggerEffectID = new List<int>(TriggerEffectID);
		}
		return result;
	}

	public static BulletSweepReactionInfo FromNative(IntPtr nativeBuffer)
	{
		return new BulletSweepReactionInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BulletSweepReactionInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BulletSweepReactionInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BulletSweepReactionInfo(IntPtr.Add(nativeBuffer, arrayIndex * BulletSweepReactionInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BulletSweepReactionInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BulletSweepReactionInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BulletSweepReactionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletSweepReactionInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CheckID_Offset), CheckID);
		new TArrayCopyMarshaler<int>(1, TriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, TriggerEffectID_Offset), TriggerEffectID);
	}

	public BulletSweepReactionInfo(IntPtr nativeStruct)
	{
		if (BulletSweepReactionInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletSweepReactionInfo");
			CheckID = 0;
			TriggerEffectID = null;
		}
		else
		{
			CheckID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CheckID_Offset));
			TriggerEffectID = new TArrayCopyMarshaler<int>(1, TriggerEffectID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, TriggerEffectID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BulletSweepReactionInfo");
		BulletSweepReactionInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		CheckID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckID");
		CheckID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TriggerEffectID_PropertyAddress, intPtr, "TriggerEffectID");
		TriggerEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerEffectID");
		TriggerEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerEffectID", Classes.FArrayProperty);
		BulletSweepReactionInfo_IsValid = ((intPtr != IntPtr.Zero && CheckID_IsValid && TriggerEffectID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BulletSweepReactionInfo", (byte)BulletSweepReactionInfo_IsValid != 0);
	}

	static BulletSweepReactionInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BulletSweepReactionInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BulletSweepReactionInfo));
	}
}
