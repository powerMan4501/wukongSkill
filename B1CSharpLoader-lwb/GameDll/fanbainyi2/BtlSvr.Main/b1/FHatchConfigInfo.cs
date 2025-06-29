using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.HatchConfigInfo")]
public struct FHatchConfigInfo
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:TamerClass")]
	public TSubclassOf<BUTamerActor> TamerClass;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:SpawnAMList")]
	public List<UAnimMontage> SpawnAMList;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("没配默认取Owner.GetActorTransform")]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:SpawnSocketName")]
	public FName SpawnSocketName;

	[EditAnywhere]
	[DisplayName("单位出生时面向卵当前的目标")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:bFaceToTarget")]
	public bool bFaceToTarget;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成时产生的DBC")]
	[Tooltip("由生成者来执行")]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:SpawnDBC")]
	public BGWDataAsset_B1DBC SpawnDBC;

	[DisplayName("是否同步目标")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:bSyncCurTarget")]
	public bool bSyncCurTarget;

	[DisplayName("单位出生时携带的Buff列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HatchConfigInfo:BirthBuffIDList")]
	public List<int> BirthBuffIDList;

	private static int HatchConfigInfo_StructSize;

	private static int HatchConfigInfo_IsValid;

	private static bool TamerClass_IsValid;

	private static int TamerClass_Offset;

	private static bool SpawnAMList_IsValid;

	private static int SpawnAMList_Offset;

	private static FFieldAddress SpawnAMList_PropertyAddress;

	private static bool SpawnSocketName_IsValid;

	private static int SpawnSocketName_Offset;

	private static bool bFaceToTarget_IsValid;

	private static int bFaceToTarget_Offset;

	private static FFieldAddress bFaceToTarget_PropertyAddress;

	private static bool SpawnDBC_IsValid;

	private static int SpawnDBC_Offset;

	private static bool bSyncCurTarget_IsValid;

	private static int bSyncCurTarget_Offset;

	private static FFieldAddress bSyncCurTarget_PropertyAddress;

	private static bool BirthBuffIDList_IsValid;

	private static int BirthBuffIDList_Offset;

	private static FFieldAddress BirthBuffIDList_PropertyAddress;

	public bool IsValid()
	{
		return TamerClass != null;
	}

	public FHatchConfigInfo Copy()
	{
		FHatchConfigInfo result = this;
		if (SpawnAMList != null)
		{
			result.SpawnAMList = new List<UAnimMontage>(SpawnAMList);
		}
		if (BirthBuffIDList != null)
		{
			result.BirthBuffIDList = new List<int>(BirthBuffIDList);
		}
		return result;
	}

	public static FHatchConfigInfo FromNative(IntPtr nativeBuffer)
	{
		return new FHatchConfigInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHatchConfigInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHatchConfigInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHatchConfigInfo(IntPtr.Add(nativeBuffer, arrayIndex * HatchConfigInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHatchConfigInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HatchConfigInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HatchConfigInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HatchConfigInfo");
			return;
		}
		TSubclassOfMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, TamerClass_Offset), TamerClass);
		new TArrayCopyMarshaler<UAnimMontage>(1, SpawnAMList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnAMList_Offset), SpawnAMList);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SpawnSocketName_Offset), SpawnSocketName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bFaceToTarget_Offset), 0, bFaceToTarget_PropertyAddress.Address, bFaceToTarget);
		UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(nativeStruct, SpawnDBC_Offset), SpawnDBC);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSyncCurTarget_Offset), 0, bSyncCurTarget_PropertyAddress.Address, bSyncCurTarget);
		new TArrayCopyMarshaler<int>(1, BirthBuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BirthBuffIDList_Offset), BirthBuffIDList);
	}

	public FHatchConfigInfo(IntPtr nativeStruct)
	{
		if (HatchConfigInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HatchConfigInfo");
			TamerClass = default(TSubclassOf<BUTamerActor>);
			SpawnAMList = null;
			SpawnSocketName = default(FName);
			bFaceToTarget = false;
			SpawnDBC = null;
			bSyncCurTarget = false;
			BirthBuffIDList = null;
		}
		else
		{
			TamerClass = TSubclassOfMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, TamerClass_Offset));
			SpawnAMList = new TArrayCopyMarshaler<UAnimMontage>(1, SpawnAMList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnAMList_Offset));
			SpawnSocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SpawnSocketName_Offset));
			bFaceToTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bFaceToTarget_Offset), 0, bFaceToTarget_PropertyAddress.Address);
			SpawnDBC = UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(nativeStruct, SpawnDBC_Offset));
			bSyncCurTarget = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSyncCurTarget_Offset), 0, bSyncCurTarget_PropertyAddress.Address);
			BirthBuffIDList = new TArrayCopyMarshaler<int>(1, BirthBuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BirthBuffIDList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HatchConfigInfo");
		HatchConfigInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		TamerClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerClass");
		TamerClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref SpawnAMList_PropertyAddress, intPtr, "SpawnAMList");
		SpawnAMList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnAMList");
		SpawnAMList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnAMList", Classes.FArrayProperty);
		SpawnSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnSocketName");
		SpawnSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnSocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bFaceToTarget_PropertyAddress, intPtr, "bFaceToTarget");
		bFaceToTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFaceToTarget");
		bFaceToTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFaceToTarget", Classes.FBoolProperty);
		SpawnDBC_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnDBC");
		SpawnDBC_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnDBC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bSyncCurTarget_PropertyAddress, intPtr, "bSyncCurTarget");
		bSyncCurTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSyncCurTarget");
		bSyncCurTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSyncCurTarget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BirthBuffIDList_PropertyAddress, intPtr, "BirthBuffIDList");
		BirthBuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BirthBuffIDList");
		BirthBuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BirthBuffIDList", Classes.FArrayProperty);
		HatchConfigInfo_IsValid = ((intPtr != IntPtr.Zero && TamerClass_IsValid && SpawnAMList_IsValid && SpawnSocketName_IsValid && bFaceToTarget_IsValid && SpawnDBC_IsValid && bSyncCurTarget_IsValid && BirthBuffIDList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HatchConfigInfo", (byte)HatchConfigInfo_IsValid != 0);
	}

	static FHatchConfigInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHatchConfigInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHatchConfigInfo));
	}
}
