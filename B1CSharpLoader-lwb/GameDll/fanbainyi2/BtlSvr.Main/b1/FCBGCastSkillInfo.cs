using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.FCBGCastSkillInfo")]
public struct FCBGCastSkillInfo
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("技能ID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FCBGCastSkillInfo:SkillID")]
	public int SkillID;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("播放起始位置")]
	[USharpPath("/Script/b1-Managed.FCBGCastSkillInfo:MontageStartSectionName")]
	public FName MontageStartSectionName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("不检测能否释放")]
	[USharpPath("/Script/b1-Managed.FCBGCastSkillInfo:DontCheckSkillCanCast")]
	public bool DontCheckSkillCanCast;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("死亡时是否生效")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FCBGCastSkillInfo:CanCastWhenDead")]
	public bool CanCastWhenDead;

	private static int FCBGCastSkillInfo_StructSize;

	private static int FCBGCastSkillInfo_IsValid;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool MontageStartSectionName_IsValid;

	private static int MontageStartSectionName_Offset;

	private static bool DontCheckSkillCanCast_IsValid;

	private static int DontCheckSkillCanCast_Offset;

	private static FFieldAddress DontCheckSkillCanCast_PropertyAddress;

	private static bool CanCastWhenDead_IsValid;

	private static int CanCastWhenDead_Offset;

	private static FFieldAddress CanCastWhenDead_PropertyAddress;

	public FCBGCastSkillInfo Copy()
	{
		return this;
	}

	public static FCBGCastSkillInfo FromNative(IntPtr nativeBuffer)
	{
		return new FCBGCastSkillInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCBGCastSkillInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCBGCastSkillInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCBGCastSkillInfo(IntPtr.Add(nativeBuffer, arrayIndex * FCBGCastSkillInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCBGCastSkillInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FCBGCastSkillInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FCBGCastSkillInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FCBGCastSkillInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MontageStartSectionName_Offset), MontageStartSectionName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DontCheckSkillCanCast_Offset), 0, DontCheckSkillCanCast_PropertyAddress.Address, DontCheckSkillCanCast);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanCastWhenDead_Offset), 0, CanCastWhenDead_PropertyAddress.Address, CanCastWhenDead);
	}

	public FCBGCastSkillInfo(IntPtr nativeStruct)
	{
		if (FCBGCastSkillInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FCBGCastSkillInfo");
			SkillID = 0;
			MontageStartSectionName = default(FName);
			DontCheckSkillCanCast = false;
			CanCastWhenDead = false;
		}
		else
		{
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			MontageStartSectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MontageStartSectionName_Offset));
			DontCheckSkillCanCast = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DontCheckSkillCanCast_Offset), 0, DontCheckSkillCanCast_PropertyAddress.Address);
			CanCastWhenDead = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanCastWhenDead_Offset), 0, CanCastWhenDead_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FCBGCastSkillInfo");
		FCBGCastSkillInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		MontageStartSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontageStartSectionName");
		MontageStartSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontageStartSectionName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref DontCheckSkillCanCast_PropertyAddress, intPtr, "DontCheckSkillCanCast");
		DontCheckSkillCanCast_Offset = NativeReflection.GetPropertyOffset(intPtr, "DontCheckSkillCanCast");
		DontCheckSkillCanCast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DontCheckSkillCanCast", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CanCastWhenDead_PropertyAddress, intPtr, "CanCastWhenDead");
		CanCastWhenDead_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanCastWhenDead");
		CanCastWhenDead_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanCastWhenDead", Classes.FBoolProperty);
		FCBGCastSkillInfo_IsValid = ((intPtr != IntPtr.Zero && SkillID_IsValid && MontageStartSectionName_IsValid && DontCheckSkillCanCast_IsValid && CanCastWhenDead_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FCBGCastSkillInfo", (byte)FCBGCastSkillInfo_IsValid != 0);
	}

	static FCBGCastSkillInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCBGCastSkillInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCBGCastSkillInfo));
	}
}
