using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.StalemateInfo")]
public struct FStalemateInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("僵持状态技能ID")]
	[USharpPath("/Script/b1-Managed.StalemateInfo:StalemateSkillID")]
	public List<int> StalemateSkillID;

	[EditAnywhere]
	[DisplayName("脱战回家技能ID")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.StalemateInfo:ReturnHomeSkillID")]
	public int ReturnHomeSkillID;

	[DisplayName("脱战回家Buff")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.StalemateInfo:ReturnHomeBuffID")]
	public int ReturnHomeBuffID;

	private static int StalemateInfo_StructSize;

	private static int StalemateInfo_IsValid;

	private static bool StalemateSkillID_IsValid;

	private static int StalemateSkillID_Offset;

	private static FFieldAddress StalemateSkillID_PropertyAddress;

	private static bool ReturnHomeSkillID_IsValid;

	private static int ReturnHomeSkillID_Offset;

	private static bool ReturnHomeBuffID_IsValid;

	private static int ReturnHomeBuffID_Offset;

	public FStalemateInfo Copy()
	{
		FStalemateInfo result = this;
		if (StalemateSkillID != null)
		{
			result.StalemateSkillID = new List<int>(StalemateSkillID);
		}
		return result;
	}

	public static FStalemateInfo FromNative(IntPtr nativeBuffer)
	{
		return new FStalemateInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStalemateInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStalemateInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStalemateInfo(IntPtr.Add(nativeBuffer, arrayIndex * StalemateInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStalemateInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * StalemateInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (StalemateInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StalemateInfo");
			return;
		}
		new TArrayCopyMarshaler<int>(1, StalemateSkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, StalemateSkillID_Offset), StalemateSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ReturnHomeSkillID_Offset), ReturnHomeSkillID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ReturnHomeBuffID_Offset), ReturnHomeBuffID);
	}

	public FStalemateInfo(IntPtr nativeStruct)
	{
		if (StalemateInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.StalemateInfo");
			StalemateSkillID = null;
			ReturnHomeSkillID = 0;
			ReturnHomeBuffID = 0;
		}
		else
		{
			StalemateSkillID = new TArrayCopyMarshaler<int>(1, StalemateSkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, StalemateSkillID_Offset));
			ReturnHomeSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ReturnHomeSkillID_Offset));
			ReturnHomeBuffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ReturnHomeBuffID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.StalemateInfo");
		StalemateInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref StalemateSkillID_PropertyAddress, intPtr, "StalemateSkillID");
		StalemateSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "StalemateSkillID");
		StalemateSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StalemateSkillID", Classes.FArrayProperty);
		ReturnHomeSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReturnHomeSkillID");
		ReturnHomeSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReturnHomeSkillID", Classes.FIntProperty);
		ReturnHomeBuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReturnHomeBuffID");
		ReturnHomeBuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReturnHomeBuffID", Classes.FIntProperty);
		StalemateInfo_IsValid = ((intPtr != IntPtr.Zero && StalemateSkillID_IsValid && ReturnHomeSkillID_IsValid && ReturnHomeBuffID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.StalemateInfo", (byte)StalemateInfo_IsValid != 0);
	}

	static FStalemateInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FStalemateInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStalemateInfo));
	}
}
