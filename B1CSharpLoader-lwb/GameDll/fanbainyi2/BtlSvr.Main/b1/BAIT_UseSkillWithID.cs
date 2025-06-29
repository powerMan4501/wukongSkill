using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_UseSkillWithID")]
public class BAIT_UseSkillWithID : BAIT_Base
{
	private bool IsBeingAbort;

	private int FinalSkillID;

	private static bool SkillIDSource_IsValid;

	private static int SkillIDSource_Offset;

	private static FFieldAddress SkillIDSource_PropertyAddress;

	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	private static bool IsEndSkill_IsValid;

	private static int IsEndSkill_Offset;

	private static FFieldAddress IsEndSkill_PropertyAddress;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_UseSkillWithID:SkillIDSource")]
	public ESkillIDSource SkillIDSource
	{
		get
		{
			CheckDestroyed();
			if (!SkillIDSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:SkillIDSource");
				return ESkillIDSource.Custom;
			}
			return EnumMarshaler<ESkillIDSource>.FromNative(IntPtr.Add(base.Address, SkillIDSource_Offset), 0, SkillIDSource_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SkillIDSource_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:SkillIDSource");
			}
			else
			{
				EnumMarshaler<ESkillIDSource>.ToNative(IntPtr.Add(base.Address, SkillIDSource_Offset), 0, SkillIDSource_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_UseSkillWithID:SkillID")]
	public int SkillID
	{
		get
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:SkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:SkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillID_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("若不勾选，则执行技能后，离开AttackingState或进入ComboWindow时，会离开本节点；若勾选，则单位仅在离开AttackingState后才离开本节点。")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_UseSkillWithID:IsEndSkill")]
	public bool IsEndSkill
	{
		get
		{
			CheckDestroyed();
			if (!IsEndSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:IsEndSkill");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEndSkill_Offset), 0, IsEndSkill_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEndSkill_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:IsEndSkill");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEndSkill_Offset), 0, IsEndSkill_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_UseSkillWithID:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_UseSkillWithID:EnableDebug");
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
		FinalSkillID = SkillID;
		ESkillIDSource skillIDSource = SkillIDSource;
		if (skillIDSource == ESkillIDSource.Custom || skillIDSource != ESkillIDSource.FromSceneItem)
		{
			return;
		}
		BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(Cha);
		if (readOnlyData != null)
		{
			BUC_SceneItemCommData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(readOnlyData.SceneItemCatch);
			if (readOnlyData2 != null)
			{
				FinalSkillID = readOnlyData2.SkillID;
			}
		}
	}

	private bool CastWithSkillID(ABGUCharacter Unit)
	{
		if (BGUFuncLibAICS.BGURequestAIUseSkillWithSkillID_CSharp(Unit, FinalSkillID, ECastSkillSourceType.BT) > 0)
		{
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
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_UseSkillWithID");
		NativeReflection.GetPropertyRef(ref SkillIDSource_PropertyAddress, unrealStruct, "SkillIDSource");
		SkillIDSource_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillIDSource");
		SkillIDSource_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillIDSource", Classes.FEnumProperty);
		SkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsEndSkill_PropertyAddress, unrealStruct, "IsEndSkill");
		IsEndSkill_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsEndSkill");
		IsEndSkill_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsEndSkill", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, unrealStruct, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableDebug", Classes.FBoolProperty);
	}

	static BAIT_UseSkillWithID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_UseSkillWithID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_UseSkillWithID));
	}
}
