using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_TeleportByEQS")]
internal class BAIT_TeleportByEQS : BAIT_Base
{
	private ACharacter OwnerCharacter;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool IsRandom_IsValid;

	private static int IsRandom_Offset;

	private static FFieldAddress IsRandom_PropertyAddress;

	private static bool TurnRotationType_IsValid;

	private static int TurnRotationType_Offset;

	private static FFieldAddress TurnRotationType_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_TeleportByEQS:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TeleportByEQS:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TeleportByEQS:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_TeleportByEQS:IsRandom")]
	public bool IsRandom
	{
		get
		{
			CheckDestroyed();
			if (!IsRandom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TeleportByEQS:IsRandom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRandom_Offset), 0, IsRandom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRandom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TeleportByEQS:IsRandom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRandom_Offset), 0, IsRandom_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TeleportByEQS:TurnRotationType")]
	public EChangeTargetType TurnRotationType
	{
		get
		{
			CheckDestroyed();
			if (!TurnRotationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TeleportByEQS:TurnRotationType");
				return EChangeTargetType.None;
			}
			return EnumMarshaler<EChangeTargetType>.FromNative(IntPtr.Add(base.Address, TurnRotationType_Offset), 0, TurnRotationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TurnRotationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TeleportByEQS:TurnRotationType");
			}
			else
			{
				EnumMarshaler<EChangeTargetType>.ToNative(IntPtr.Add(base.Address, TurnRotationType_Offset), 0, TurnRotationType_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		OwnerCharacter = OwnerActor as ABGUCharacter;
		if (OwnerCharacter != null)
		{
			if (ShouldAbort(OwnerCharacter))
			{
				EndThisNode();
			}
			else
			{
				BGS_EventCollectionCS.Get(this).Evt_BGS_EQSObjRun.Invoke(EQSTemplate, OwnerCharacter, EBGURunEQSObjReason.None, default(FGSEQSExParam), OnEQSFinish);
			}
		}
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (OwnerCharacter.IsNullOrDestroyed() || Result.Count == 0)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		FTransform p = BGUFuncLibActorTransformCS.BGUGetActorTransform(OwnerCharacter);
		if (IsRandom)
		{
			int index = MathLib.RandomIntInRange(0, Result.Count - 1);
			p.SetLocation(Result[index]);
		}
		else
		{
			p.SetLocation(Result[0]);
		}
		AActor aActor = null;
		switch (TurnRotationType)
		{
		case EChangeTargetType.Player:
			aActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(OwnerCharacter);
			break;
		case EChangeTargetType.Master:
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(OwnerCharacter);
			if (readOnlyData != null)
			{
				aActor = readOnlyData.GetMasterActor();
			}
			break;
		}
		case EChangeTargetType.Summon:
		{
			IBGC_SummonData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SummonData, BGC_SummonData>(OwnerCharacter);
			if (gameStateReadonlyData != null)
			{
				AActor summonerFirstServantActor = gameStateReadonlyData.GetSummonerFirstServantActor(OwnerCharacter);
				if (summonerFirstServantActor != null)
				{
					aActor = summonerFirstServantActor;
				}
			}
			break;
		}
		}
		if (aActor != null)
		{
			p.SetRotation((BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - p.GetLocation()).Rotation().Quaternion());
		}
		BUS_EventCollectionCS.Get(OwnerCharacter)?.Evt_TeleportMoveByTrans.Invoke(p);
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_TeleportByEQS");
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsRandom_PropertyAddress, unrealStruct, "IsRandom");
		IsRandom_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsRandom");
		IsRandom_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsRandom", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TurnRotationType_PropertyAddress, unrealStruct, "TurnRotationType");
		TurnRotationType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnRotationType");
		TurnRotationType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnRotationType", Classes.FEnumProperty);
	}

	static BAIT_TeleportByEQS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_TeleportByEQS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_TeleportByEQS));
	}
}
