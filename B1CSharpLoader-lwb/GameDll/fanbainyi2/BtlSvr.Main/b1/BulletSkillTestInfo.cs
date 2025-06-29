using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BulletSkillTestInfo")]
public struct BulletSkillTestInfo
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BulletSkillTestInfo:TamerActor")]
	public BUTamerActor TamerActor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BulletSkillTestInfo:SkillIDList")]
	public List<int> SkillIDList;

	private static int BulletSkillTestInfo_StructSize;

	private static int BulletSkillTestInfo_IsValid;

	private static bool TamerActor_IsValid;

	private static int TamerActor_Offset;

	private static bool SkillIDList_IsValid;

	private static int SkillIDList_Offset;

	private static FFieldAddress SkillIDList_PropertyAddress;

	public BulletSkillTestInfo(BUTamerActor TamerActor, List<int> SkillIDList)
	{
		this.TamerActor = TamerActor;
		this.SkillIDList = SkillIDList;
	}

	public BulletSkillTestInfo Copy()
	{
		BulletSkillTestInfo result = this;
		if (SkillIDList != null)
		{
			result.SkillIDList = new List<int>(SkillIDList);
		}
		return result;
	}

	public static BulletSkillTestInfo FromNative(IntPtr nativeBuffer)
	{
		return new BulletSkillTestInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BulletSkillTestInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BulletSkillTestInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BulletSkillTestInfo(IntPtr.Add(nativeBuffer, arrayIndex * BulletSkillTestInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BulletSkillTestInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BulletSkillTestInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BulletSkillTestInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletSkillTestInfo");
			return;
		}
		UObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, TamerActor_Offset), TamerActor);
		new TArrayCopyMarshaler<int>(1, SkillIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillIDList_Offset), SkillIDList);
	}

	public BulletSkillTestInfo(IntPtr nativeStruct)
	{
		if (BulletSkillTestInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BulletSkillTestInfo");
			TamerActor = null;
			SkillIDList = null;
		}
		else
		{
			TamerActor = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, TamerActor_Offset));
			SkillIDList = new TArrayCopyMarshaler<int>(1, SkillIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillIDList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BulletSkillTestInfo");
		BulletSkillTestInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TamerActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerActor");
		TamerActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SkillIDList_PropertyAddress, intPtr, "SkillIDList");
		SkillIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIDList");
		SkillIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIDList", Classes.FArrayProperty);
		BulletSkillTestInfo_IsValid = ((intPtr != IntPtr.Zero && TamerActor_IsValid && SkillIDList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BulletSkillTestInfo", (byte)BulletSkillTestInfo_IsValid != 0);
	}

	static BulletSkillTestInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BulletSkillTestInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BulletSkillTestInfo));
	}
}
