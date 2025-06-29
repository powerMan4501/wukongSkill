using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CastSkillInfo")]
public struct FCastSkillInfo
{
	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:SkillID")]
	public int SkillID;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:NeedCheckSkillCanCast")]
	public bool NeedCheckSkillCanCast;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:MontageStartSectionName")]
	public FName MontageStartSectionName;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:SkillMontageBeginPos")]
	public float SkillMontageBeginPos;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:SkillDirection")]
	public ESkillDirection SkillDirection;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:HasSetSkillBaseTarget")]
	public bool HasSetSkillBaseTarget;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:Reason")]
	public EMontageBindReason Reason;

	[UProperty]
	[USharpPath("/Script/b1-Managed.CastSkillInfo:SourceType")]
	public ECastSkillSourceType SourceType;

	private static int CastSkillInfo_StructSize;

	private static int CastSkillInfo_IsValid;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool NeedCheckSkillCanCast_IsValid;

	private static int NeedCheckSkillCanCast_Offset;

	private static FFieldAddress NeedCheckSkillCanCast_PropertyAddress;

	private static bool MontageStartSectionName_IsValid;

	private static int MontageStartSectionName_Offset;

	private static bool SkillMontageBeginPos_IsValid;

	private static int SkillMontageBeginPos_Offset;

	private static bool SkillDirection_IsValid;

	private static int SkillDirection_Offset;

	private static FFieldAddress SkillDirection_PropertyAddress;

	private static bool HasSetSkillBaseTarget_IsValid;

	private static int HasSetSkillBaseTarget_Offset;

	private static FFieldAddress HasSetSkillBaseTarget_PropertyAddress;

	private static bool Reason_IsValid;

	private static int Reason_Offset;

	private static FFieldAddress Reason_PropertyAddress;

	private static bool SourceType_IsValid;

	private static int SourceType_Offset;

	private static FFieldAddress SourceType_PropertyAddress;

	public FCastSkillInfo(int _SkillID, ECastSkillSourceType InSourceType, bool _HasSetSkillBaseTarget = false, ESkillDirection _Direction = ESkillDirection.None, EMontageBindReason _Reason = EMontageBindReason.Default)
	{
		SkillID = _SkillID;
		SourceType = InSourceType;
		NeedCheckSkillCanCast = true;
		MontageStartSectionName = FName.None;
		SkillMontageBeginPos = 0f;
		SkillDirection = _Direction;
		HasSetSkillBaseTarget = _HasSetSkillBaseTarget;
		Reason = _Reason;
	}

	public FCastSkillInfo Copy()
	{
		return this;
	}

	public static FCastSkillInfo FromNative(IntPtr nativeBuffer)
	{
		return new FCastSkillInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCastSkillInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCastSkillInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCastSkillInfo(IntPtr.Add(nativeBuffer, arrayIndex * CastSkillInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCastSkillInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CastSkillInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CastSkillInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CastSkillInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillID_Offset), SkillID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address, NeedCheckSkillCanCast);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MontageStartSectionName_Offset), MontageStartSectionName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SkillMontageBeginPos_Offset), SkillMontageBeginPos);
		EnumMarshaler<ESkillDirection>.ToNative(IntPtr.Add(nativeStruct, SkillDirection_Offset), 0, SkillDirection_PropertyAddress.Address, SkillDirection);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasSetSkillBaseTarget_Offset), 0, HasSetSkillBaseTarget_PropertyAddress.Address, HasSetSkillBaseTarget);
		EnumMarshaler<EMontageBindReason>.ToNative(IntPtr.Add(nativeStruct, Reason_Offset), 0, Reason_PropertyAddress.Address, Reason);
		EnumMarshaler<ECastSkillSourceType>.ToNative(IntPtr.Add(nativeStruct, SourceType_Offset), 0, SourceType_PropertyAddress.Address, SourceType);
	}

	public FCastSkillInfo(IntPtr nativeStruct)
	{
		if (CastSkillInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CastSkillInfo");
			SkillID = 0;
			NeedCheckSkillCanCast = false;
			MontageStartSectionName = default(FName);
			SkillMontageBeginPos = 0f;
			SkillDirection = ESkillDirection.None;
			HasSetSkillBaseTarget = false;
			Reason = EMontageBindReason.Default;
			SourceType = ECastSkillSourceType.Default;
		}
		else
		{
			SkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillID_Offset));
			NeedCheckSkillCanCast = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedCheckSkillCanCast_Offset), 0, NeedCheckSkillCanCast_PropertyAddress.Address);
			MontageStartSectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MontageStartSectionName_Offset));
			SkillMontageBeginPos = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SkillMontageBeginPos_Offset));
			SkillDirection = EnumMarshaler<ESkillDirection>.FromNative(IntPtr.Add(nativeStruct, SkillDirection_Offset), 0, SkillDirection_PropertyAddress.Address);
			HasSetSkillBaseTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasSetSkillBaseTarget_Offset), 0, HasSetSkillBaseTarget_PropertyAddress.Address);
			Reason = EnumMarshaler<EMontageBindReason>.FromNative(IntPtr.Add(nativeStruct, Reason_Offset), 0, Reason_PropertyAddress.Address);
			SourceType = EnumMarshaler<ECastSkillSourceType>.FromNative(IntPtr.Add(nativeStruct, SourceType_Offset), 0, SourceType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CastSkillInfo");
		CastSkillInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref NeedCheckSkillCanCast_PropertyAddress, intPtr, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedCheckSkillCanCast");
		NeedCheckSkillCanCast_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedCheckSkillCanCast", Classes.FBoolProperty);
		MontageStartSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MontageStartSectionName");
		MontageStartSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MontageStartSectionName", Classes.FNameProperty);
		SkillMontageBeginPos_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillMontageBeginPos");
		SkillMontageBeginPos_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillMontageBeginPos", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SkillDirection_PropertyAddress, intPtr, "SkillDirection");
		SkillDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillDirection");
		SkillDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillDirection", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref HasSetSkillBaseTarget_PropertyAddress, intPtr, "HasSetSkillBaseTarget");
		HasSetSkillBaseTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "HasSetSkillBaseTarget");
		HasSetSkillBaseTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HasSetSkillBaseTarget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref Reason_PropertyAddress, intPtr, "Reason");
		Reason_Offset = NativeReflection.GetPropertyOffset(intPtr, "Reason");
		Reason_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Reason", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SourceType_PropertyAddress, intPtr, "SourceType");
		SourceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SourceType");
		SourceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SourceType", Classes.FEnumProperty);
		CastSkillInfo_IsValid = ((intPtr != IntPtr.Zero && SkillID_IsValid && NeedCheckSkillCanCast_IsValid && MontageStartSectionName_IsValid && SkillMontageBeginPos_IsValid && SkillDirection_IsValid && HasSetSkillBaseTarget_IsValid && Reason_IsValid && SourceType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CastSkillInfo", (byte)CastSkillInfo_IsValid != 0);
	}

	static FCastSkillInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCastSkillInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCastSkillInfo));
	}
}
