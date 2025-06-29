using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckSummonAmount")]
internal class BAID_CheckSummonAmount : BAID_Base
{
	private static bool SummonResIDFilter_IsValid;

	private static int SummonResIDFilter_Offset;

	private static FFieldAddress SummonResIDFilter_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SummonResIDFilter_Marshaler;

	private static bool OperationType_IsValid;

	private static int OperationType_Offset;

	private static FFieldAddress OperationType_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	[EditAnywhere]
	[UProperty]
	[DisplayName("SummonResIDFilter")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckSummonAmount:SummonResIDFilter")]
	public TArrayReadWrite<int> SummonResIDFilter
	{
		get
		{
			CheckDestroyed();
			if (!SummonResIDFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSummonAmount:SummonResIDFilter");
				return null;
			}
			if (SummonResIDFilter_Marshaler == null)
			{
				SummonResIDFilter_Marshaler = new TArrayReadWriteMarshaler<int>(1, SummonResIDFilter_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SummonResIDFilter_Marshaler.FromNative(IntPtr.Add(base.Address, SummonResIDFilter_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckSummonAmount:OperationType")]
	public EValueCompareOperationType OperationType
	{
		get
		{
			CheckDestroyed();
			if (!OperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSummonAmount:OperationType");
				return EValueCompareOperationType.EqualTo;
			}
			return EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(base.Address, OperationType_Offset), 0, OperationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OperationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSummonAmount:OperationType");
			}
			else
			{
				EnumMarshaler<EValueCompareOperationType>.ToNative(IntPtr.Add(base.Address, OperationType_Offset), 0, OperationType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckSummonAmount:CompareValue")]
	public int CompareValue
	{
		get
		{
			CheckDestroyed();
			if (!CompareValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSummonAmount:CompareValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CompareValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompareValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSummonAmount:CompareValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CompareValue_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			return false;
		}
		IBGC_SummonData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SummonData, BGC_SummonData>(aBGUCharacter);
		if (gameStateReadonlyData != null)
		{
			int summonerAllServantCount = gameStateReadonlyData.GetSummonerAllServantCount(aBGUCharacter, SummonResIDFilter.ToList());
			return OperationType switch
			{
				EValueCompareOperationType.EqualTo => summonerAllServantCount == CompareValue, 
				EValueCompareOperationType.NotEqualTo => summonerAllServantCount != CompareValue, 
				EValueCompareOperationType.LessThan => summonerAllServantCount < CompareValue, 
				EValueCompareOperationType.LessThanOrEqualTo => summonerAllServantCount <= CompareValue, 
				EValueCompareOperationType.GreaterThan => summonerAllServantCount > CompareValue, 
				EValueCompareOperationType.GreaterThanOrEqualTo => summonerAllServantCount >= CompareValue, 
				_ => false, 
			};
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckSummonAmount");
		NativeReflection.GetPropertyRef(ref SummonResIDFilter_PropertyAddress, unrealStruct, "SummonResIDFilter");
		SummonResIDFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SummonResIDFilter");
		SummonResIDFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SummonResIDFilter", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OperationType_PropertyAddress, unrealStruct, "OperationType");
		OperationType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OperationType");
		OperationType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OperationType", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CompareValue", Classes.FIntProperty);
	}

	static BAID_CheckSummonAmount()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckSummonAmount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckSummonAmount));
	}
}
