using b1.Prediction;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAUseSkillByType : BUInputActionTemplate
{
	public BUIAUseSkillByType()
	{
		InputActionType = EInputActionType.UseSkillByType;
	}

	protected override bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return false;
		}
		if (!BGUFuncLibInput.BGUIsCanReceiveBattleInput(owner) || !BGUFuncLibInput.BGUIsCanReceiveBattleInputByActionType(owner, InputActionType))
		{
			return false;
		}
		IBUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(owner);
		IBUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(owner);
		if (readOnlyData == null || readOnlyData2 == null)
		{
			return false;
		}
		FUStEnhancedInputActionDesc enhancedInputActionDesc = BGW_GameDB.GetEnhancedInputActionDesc(InputActionID);
		if (enhancedInputActionDesc == null)
		{
			return false;
		}
		if (enhancedInputActionDesc.InputActionParamsInt.Count == 0)
		{
			return false;
		}
		SpellType spellType = (SpellType)enhancedInputActionDesc.InputActionParamsInt[0];
		int skillID = 0;
		APawn aPawn = owner as APawn;
		SpellEffectType spellEffectType = SpellEffectType.CastSkill;
		if (aPawn != null)
		{
			IBPC_TransData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBPC_TransData, BPC_TransData>(aPawn.PlayerState);
			IBPC_PlayerTagData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(aPawn.PlayerState);
			BUC_PlayerSpellConfData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<BUC_PlayerSpellConfData>(owner);
			BPC_PlayerInteractData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>(aPawn.PlayerState);
			BUC_AttrContainer readOnlyData7 = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(owner);
			if (readOnlyData3 == null || readOnlyData5.MagicConfInfo == null || readOnlyData4 == null)
			{
				return false;
			}
			if (spellType == SpellType.Min)
			{
				spellType = readOnlyData3.DefaultSpellType;
			}
			BGS_EventCollectionCS.Get(owner).Evt_BGS_TriggerShortcut.Invoke(B1: true, (int)spellType);
			if (!readOnlyData4.HasTag(EBGPPlayerTag.Transforming) && (spellType == SpellType.BianShen || spellType == SpellType.Ride))
			{
				BGUCharacterCS bGUCharacterCS = owner as BGUCharacterCS;
				if (!bGUCharacterCS.IsNullOrDestroyed() && bGUCharacterCS.CharacterMovement != null && bGUCharacterCS.CharacterMovement.IsFalling())
				{
					return false;
				}
				if (spellType == SpellType.BianShen && readOnlyData7.GetFloatValue(EBGUAttrFloat.TransEnergyMax) > readOnlyData7.GetFloatValue(EBGUAttrFloat.CurEnergy))
				{
					return false;
				}
				if (readOnlyData6 != null && readOnlyData6.IsInInteraction())
				{
					return false;
				}
			}
			foreach (FUStMagicConfInfo item in readOnlyData5.MagicConfInfo)
			{
				if (item.Type == spellType)
				{
					SpellDesc spellDesc = GameDBRuntime.GetSpellDesc(item.SpellID);
					if (spellDesc != null)
					{
						if (spellDesc.IsPassive == YesNoType.Yes)
						{
							return false;
						}
						skillID = spellDesc.SkillId;
						spellEffectType = spellDesc.EffectType;
						break;
					}
					break;
				}
			}
			if (spellEffectType != SpellEffectType.PhantomRush && readOnlyData.HasState(EBGUUnitState.JumpMoving))
			{
				return false;
			}
			if (spellType == SpellType.Ride)
			{
				if (!readOnlyData4.HasTag(EBGPPlayerTag.Transforming))
				{
					BPS_GSEventCollection.Get(aPawn.PlayerState).Evt_TriggerPlayerTransBegin.Invoke(EPlayerTransBeginType.Ride, default(PlayerTransParam));
				}
				else
				{
					BPS_GSEventCollection.Get(aPawn.PlayerState).Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.ManualEndRide, default(PlayerTransParam));
				}
				return true;
			}
			if (spellEffectType == SpellEffectType.PhantomRush)
			{
				if (readOnlyData2.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && !readOnlyData.HasState(EBGUUnitState.InMagicWindow))
				{
					return false;
				}
				if ((readOnlyData.HasState(EBGUUnitState.Beatback) && readOnlyData.HasState(EBGUUnitState.InMagicWindow)) || !readOnlyData.HasState(EBGUUnitState.Beatback))
				{
					IBPC_InputData playerControlReadonlyData = BGU_DataUtil.GetPlayerControlReadonlyData<IBPC_InputData, BPC_InputData>(owner.GetInstigatorController() as APlayerController);
					if (playerControlReadonlyData == null)
					{
						return false;
					}
					IBUC_PlayerInputConfigData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PlayerInputConfigData, BUC_PlayerInputConfigData>(owner);
					if (unPersistentReadOnlyData == null)
					{
						return false;
					}
					float inputValue = playerControlReadonlyData.GetInputValue(GSBattleActionEn.MoveSideways);
					float inputValue2 = playerControlReadonlyData.GetInputValue(GSBattleActionEn.MoveForward);
					ESkillDirection phantomRushDir = BGUFuncLibInput.CalcInputDir(inputValue, inputValue2, unPersistentReadOnlyData.DodgeInputFixLine);
					BUS_EventCollectionCS.Get(owner).Evt_TriggerPhantomRush.Invoke(phantomRushDir);
					return true;
				}
				return false;
			}
			if (BGW_GameDB.GetSkillSDesc(skillID, owner) != null)
			{
				if (TriggerEvent == ETriggerEvent.None)
				{
					TriggerEvent = ETriggerEvent.Started;
				}
				BUS_EventCollectionCS.Get(owner)?.Evt_InputCastSkill.Invoke(InputActionType, TriggerEvent != ETriggerEvent.Started, skillID, InputActionID);
				return true;
			}
		}
		return false;
	}
}
