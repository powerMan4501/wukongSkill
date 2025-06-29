using System;
using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_UseRandomSkillWithID")]
public class BAIT_UseRandomSkillWithID : BAIT_Base
{
	private int LastSkillIdx;

	private bool IsBeingAbort;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static FFieldAddress SkillID_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SkillID_Marshaler;

	private static bool IsEndSkill_IsValid;

	private static int IsEndSkill_Offset;

	private static FFieldAddress IsEndSkill_PropertyAddress;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_UseRandomSkillWithID:SkillID")]
	public TArrayReadWrite<int> SkillID
	{
		get
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseRandomSkillWithID:SkillID");
				return null;
			}
			if (SkillID_Marshaler == null)
			{
				SkillID_Marshaler = new TArrayReadWriteMarshaler<int>(1, SkillID_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SkillID_Marshaler.FromNative(IntPtr.Add(base.Address, SkillID_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_UseRandomSkillWithID:IsEndSkill")]
	public bool IsEndSkill
	{
		get
		{
			CheckDestroyed();
			if (!IsEndSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseRandomSkillWithID:IsEndSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEndSkill_Offset), 0, IsEndSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEndSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseRandomSkillWithID:IsEndSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEndSkill_Offset), 0, IsEndSkill_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_UseRandomSkillWithID:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseRandomSkillWithID:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseRandomSkillWithID:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS bGUCharacterCS)
		{
			Init(bGUCharacterCS);
			if (!CastWithSkillID(bGUCharacterCS))
			{
				FinishExecute(bSuccess: false);
			}
		}
		else
		{
			FinishExecute(bSuccess: false);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (IsBeingAbort)
		{
			if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking))
			{
				FinishAbort();
			}
			return;
		}
		BUC_ChargeSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(aBGUCharacter);
		if (readOnlyData.IsCastingChargeSkill && readOnlyData.ChargeSkillStage != EChargeSkillStage.End)
		{
			return;
		}
		if (BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking))
		{
			if (IsEndSkill)
			{
				if (!BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.Attacking))
				{
					FinishExecute(bSuccess: true);
				}
			}
			else if (BGUFunctionLibraryCS.BGUHasUnitState(aBGUCharacter, EBGUUnitState.InComboWindow))
			{
				FinishExecute(bSuccess: true);
			}
		}
		else
		{
			FinishExecute(bSuccess: true);
		}
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		IsBeingAbort = true;
	}

	private void Init(ABGUCharacter Cha)
	{
		IsBeingAbort = false;
		LastSkillIdx = 0;
	}

	private bool CastWithSkillID(ABGUCharacter Unit)
	{
		int count = SkillID.Count;
		if (count == 0)
		{
			return false;
		}
		List<int> list = SkillID.ToList();
		Random random = new Random();
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			int index = random.Next(0, list.Count);
			num = BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(Unit, list[index], ECastSkillSourceType.BT);
			list.RemoveAt(index);
			if (num > 0)
			{
				break;
			}
		}
		if (num > 0)
		{
			LastSkillIdx = num;
			SetGlobalLastAttackInfo(Unit);
			return true;
		}
		return false;
	}

	private void SetGlobalLastAttackInfo(ABGUCharacter Unit)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (USystemLibrary.IsValid(aActor))
		{
			float timeSeconds = UGameplayStatics.GetTimeSeconds(this);
			BUS_EventCollectionCS.Get(Unit).Evt_SetLastAttackTime.Invoke(timeSeconds);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetBeHitTime.Invoke(timeSeconds);
				bUS_GSEventCollection.Evt_SetLastAttackerID.Invoke(Unit);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_UseRandomSkillWithID");
		NativeReflection.GetPropertyRef(ref SkillID_PropertyAddress, unrealStruct, "SkillID");
		SkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillID", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref IsEndSkill_PropertyAddress, unrealStruct, "IsEndSkill");
		IsEndSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsEndSkill");
		IsEndSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsEndSkill", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, unrealStruct, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableDebug", Classes.FBoolProperty);
	}

	static BAIT_UseRandomSkillWithID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_UseRandomSkillWithID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_UseRandomSkillWithID));
	}
}
