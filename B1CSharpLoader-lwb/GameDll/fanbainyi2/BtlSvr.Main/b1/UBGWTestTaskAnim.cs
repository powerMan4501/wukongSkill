using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.UBGWTestTaskAnim")]
public class UBGWTestTaskAnim : UBGWDataAsset, b1.IBGWDataAssetHasAnimationReferences
{
	private static bool MontageTestList_IsValid;

	private static int MontageTestList_Offset;

	private static FFieldAddress MontageTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> MontageTestList_Marshaler;

	private static bool MontageTestListWithDesc_IsValid;

	private static int MontageTestListWithDesc_Offset;

	private static FFieldAddress MontageTestListWithDesc_PropertyAddress;

	private TArrayReadWriteMarshaler<FMontageTestUnit> MontageTestListWithDesc_Marshaler;

	private static bool SeqTestList_IsValid;

	private static int SeqTestList_Offset;

	private static FFieldAddress SeqTestList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SeqTestList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("蒙太奇测试列表")]
	[USharpPath("/Script/b1-Managed.UBGWTestTaskAnim:MontageTestList")]
	public TArrayReadWrite<UAnimMontage> MontageTestList
	{
		get
		{
			CheckDestroyed();
			if (!MontageTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWTestTaskAnim:MontageTestList");
				return null;
			}
			if (MontageTestList_Marshaler == null)
			{
				MontageTestList_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, MontageTestList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return MontageTestList_Marshaler.FromNative(IntPtr.Add(base.Address, MontageTestList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("带提示信息的蒙太奇测试列表")]
	[USharpPath("/Script/b1-Managed.UBGWTestTaskAnim:MontageTestListWithDesc")]
	public TArrayReadWrite<FMontageTestUnit> MontageTestListWithDesc
	{
		get
		{
			CheckDestroyed();
			if (!MontageTestListWithDesc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWTestTaskAnim:MontageTestListWithDesc");
				return null;
			}
			if (MontageTestListWithDesc_Marshaler == null)
			{
				MontageTestListWithDesc_Marshaler = new TArrayReadWriteMarshaler<FMontageTestUnit>(1, MontageTestListWithDesc_PropertyAddress, CachedMarshalingDelegates<FMontageTestUnit, FMontageTestUnit>.FromNative, CachedMarshalingDelegates<FMontageTestUnit, FMontageTestUnit>.ToNative);
			}
			return MontageTestListWithDesc_Marshaler.FromNative(IntPtr.Add(base.Address, MontageTestListWithDesc_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Seq测试列表")]
	[USharpPath("/Script/b1-Managed.UBGWTestTaskAnim:SeqTestList")]
	public TArrayReadWrite<int> SeqTestList
	{
		get
		{
			CheckDestroyed();
			if (!SeqTestList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWTestTaskAnim:SeqTestList");
				return null;
			}
			if (SeqTestList_Marshaler == null)
			{
				SeqTestList_Marshaler = new TArrayReadWriteMarshaler<int>(1, SeqTestList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SeqTestList_Marshaler.FromNative(IntPtr.Add(base.Address, SeqTestList_Offset));
		}
	}

	public void GetAnimationReferences(out List<UAnimSequenceBase> AnimMontages)
	{
		AnimMontages = new List<UAnimSequenceBase>();
		foreach (UAnimMontage montageTest in MontageTestList)
		{
			AnimMontages.Add(montageTest);
		}
		foreach (FMontageTestUnit item in MontageTestListWithDesc)
		{
			if (item.Montage != null)
			{
				AnimMontages.Add(item.Montage);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.UBGWTestTaskAnim");
		NativeReflection.GetPropertyRef(ref MontageTestList_PropertyAddress, unrealStruct, "MontageTestList");
		MontageTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MontageTestList");
		MontageTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MontageTestList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MontageTestListWithDesc_PropertyAddress, unrealStruct, "MontageTestListWithDesc");
		MontageTestListWithDesc_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MontageTestListWithDesc");
		MontageTestListWithDesc_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MontageTestListWithDesc", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SeqTestList_PropertyAddress, unrealStruct, "SeqTestList");
		SeqTestList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SeqTestList");
		SeqTestList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SeqTestList", Classes.FArrayProperty);
	}

	static UBGWTestTaskAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UBGWTestTaskAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWTestTaskAnim));
	}
}
