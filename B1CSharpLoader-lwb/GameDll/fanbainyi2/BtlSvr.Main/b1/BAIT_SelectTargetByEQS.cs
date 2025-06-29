using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SelectTargetByEQS")]
internal class BAIT_SelectTargetByEQS : BAIT_Base
{
	private ABGUCharacter OwnerCharacter;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool IsSetTarget_IsValid;

	private static int IsSetTarget_Offset;

	private static FFieldAddress IsSetTarget_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SelectTargetByEQS:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SelectTargetByEQS:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SelectTargetByEQS:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_SelectTargetByEQS:IsSetTarget")]
	public bool IsSetTarget
	{
		get
		{
			CheckDestroyed();
			if (!IsSetTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SelectTargetByEQS:IsSetTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSetTarget_Offset), 0, IsSetTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSetTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SelectTargetByEQS:IsSetTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSetTarget_Offset), 0, IsSetTarget_PropertyAddress.Address, value);
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
		}
		ABGUCharacter aBGUCharacter = null;
		for (int i = 0; i < Result.Count; i++)
		{
			List<ABGUCharacter> OutArray = new List<ABGUCharacter>();
			OwnerCharacter.World.BoxOverlapBGUCharacters(Result[i], new FVector(0.10000000149011612, 0.10000000149011612, 20.0), out OutArray);
			if (OutArray.Count == 0)
			{
				continue;
			}
			foreach (ABGUCharacter item in OutArray)
			{
				if (!(item == OwnerCharacter) && BGUFunctionLibraryCS.BGUIsEnemyTeam(OwnerCharacter, item))
				{
					aBGUCharacter = item;
					break;
				}
			}
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerCharacter);
		if (!aBGUCharacter.IsNullOrDestroyed())
		{
			UBTFunctionLibrary.SetBlackboardValueAsObject(this, new FBlackboardKeySelector
			{
				SelectedKeyName = B1GlobalFNames.EQS_Target
			}, aBGUCharacter);
			bUS_GSEventCollection.Evt_SetEQSTarget.Invoke(aBGUCharacter);
			if (IsSetTarget)
			{
				bUS_GSEventCollection.Evt_AICatchTarget.Invoke(aBGUCharacter, ETargetSourceType.Target_SelectByEQS, SkipWakeUp: true);
			}
			FinishExecute(bSuccess: true);
		}
		else
		{
			FinishExecute(bSuccess: false);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SelectTargetByEQS");
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref IsSetTarget_PropertyAddress, unrealStruct, "IsSetTarget");
		IsSetTarget_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsSetTarget");
		IsSetTarget_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsSetTarget", Classes.FBoolProperty);
	}

	static BAIT_SelectTargetByEQS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SelectTargetByEQS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SelectTargetByEQS));
	}
}
