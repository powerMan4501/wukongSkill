using System;
using System.Collections.Generic;
using b1.Protobuf.DataAPI;
using BtlShare;

namespace b1;

public class GameDBBtlShare
{
	public static void DumpStringContent(List<Tuple<string, string>> TableContentList)
	{
		foreach (KeyValuePair<int, FUStBuffDesc> item in BG_ProtobufDataAPI<FUStBuffDesc>.Get().GetAll())
		{
			FUStBuffDesc value = item.Value;
			int key = item.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBuffDesc[{key}].BuffTips", value.BuffTips));
			if (value.BuffActiveCondition != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDesc[{key}].BuffActiveCondition.ConditionParams", value.BuffActiveCondition.ConditionParams));
			}
			for (int i = 0; i < value.BuffEffects.Count; i++)
			{
				for (int j = 0; j < value.BuffEffects[i].EffectParamsString.Count; j++)
				{
					TableContentList.Add(new Tuple<string, string>($"FUStBuffDesc[{key}].BuffEffects[{i}].EffectParamsString[{j}]", value.BuffEffects[i].EffectParamsString[j]));
				}
			}
			TableContentList.Add(new Tuple<string, string>($"FUStBuffDesc[{key}].Guard", value.Guard));
		}
		foreach (KeyValuePair<int, FUStBuffIconDesc> item2 in BG_ProtobufDataAPI<FUStBuffIconDesc>.Get().GetAll())
		{
			FUStBuffIconDesc value2 = item2.Value;
			int key2 = item2.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBuffIconDesc[{key2}].Guard", value2.Guard));
		}
		foreach (KeyValuePair<int, FUStSkillSDesc> item3 in BG_ProtobufDataAPI<FUStSkillSDesc>.Get().GetAll())
		{
			FUStSkillSDesc value3 = item3.Value;
			int key3 = item3.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].SkillBaseTargetStringParam", value3.SkillBaseTargetStringParam));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].TemplatePath", value3.TemplatePath));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].AtkReboundingMontage", value3.AtkReboundingMontage));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].LowAtkReboundingMontage", value3.LowAtkReboundingMontage));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].SkillArmorBrokeMontage", value3.SkillArmorBrokeMontage));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].CooldownSkills", value3.CooldownSkills));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillSDesc[{key3}].Guard", value3.Guard));
		}
		foreach (KeyValuePair<int, FUStSkillEffectDesc> item4 in BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().GetAll())
		{
			FUStSkillEffectDesc value4 = item4.Value;
			int key4 = item4.Key;
			if (value4.EffectActiveCondition != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSkillEffectDesc[{key4}].EffectActiveCondition.ConditionParams", value4.EffectActiveCondition.ConditionParams));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStSkillEffectDesc[{key4}].PlayFXSocketName", value4.PlayFXSocketName));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillEffectDesc[{key4}].HitOriBaseCompName", value4.HitOriBaseCompName));
			for (int k = 0; k < value4.EffectParamsStr.Count; k++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSkillEffectDesc[{key4}].EffectParamsStr[{k}]", value4.EffectParamsStr[k]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStSkillEffectDesc[{key4}].Guard", value4.Guard));
		}
		foreach (KeyValuePair<int, FUStSkillDamageExpandDesc> item5 in BG_ProtobufDataAPI<FUStSkillDamageExpandDesc>.Get().GetAll())
		{
			FUStSkillDamageExpandDesc value5 = item5.Value;
			int key5 = item5.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSkillDamageExpandDesc[{key5}].Guard", value5.Guard));
		}
		foreach (KeyValuePair<int, FUStBuffDispDesc> item6 in BG_ProtobufDataAPI<FUStBuffDispDesc>.Get().GetAll())
		{
			FUStBuffDispDesc value6 = item6.Value;
			int key6 = item6.Key;
			for (int l = 0; l < value6.EnterFX.Count; l++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].EnterFX[{l}].PSPath", value6.EnterFX[l].PSPath));
			}
			for (int m = 0; m < value6.EnterFX.Count; m++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].EnterFX[{m}].AttachName", value6.EnterFX[m].AttachName));
			}
			for (int n = 0; n < value6.EnterFX.Count; n++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].EnterFX[{n}].SkelMeshParamName", value6.EnterFX[n].SkelMeshParamName));
			}
			for (int num = 0; num < value6.EnterFX.Count; num++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].EnterFX[{num}].AddTags", value6.EnterFX[num].AddTags));
			}
			for (int num2 = 0; num2 < value6.TickingCurveParam.Count; num2++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].TickingCurveParam[{num2}].FloatCurvePath", value6.TickingCurveParam[num2].FloatCurvePath));
			}
			for (int num3 = 0; num3 < value6.TickingCurveParam.Count; num3++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].TickingCurveParam[{num3}].ParamName", value6.TickingCurveParam[num3].ParamName));
			}
			for (int num4 = 0; num4 < value6.AlmostLeaveFX.Count; num4++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].AlmostLeaveFX[{num4}].PSPath", value6.AlmostLeaveFX[num4].PSPath));
			}
			for (int num5 = 0; num5 < value6.AlmostLeaveFX.Count; num5++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].AlmostLeaveFX[{num5}].AttachName", value6.AlmostLeaveFX[num5].AttachName));
			}
			for (int num6 = 0; num6 < value6.AlmostLeaveFX.Count; num6++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].AlmostLeaveFX[{num6}].SkelMeshParamName", value6.AlmostLeaveFX[num6].SkelMeshParamName));
			}
			for (int num7 = 0; num7 < value6.AlmostLeaveFX.Count; num7++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].AlmostLeaveFX[{num7}].AddTags", value6.AlmostLeaveFX[num7].AddTags));
			}
			for (int num8 = 0; num8 < value6.LeaveFX.Count; num8++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].LeaveFX[{num8}].PSPath", value6.LeaveFX[num8].PSPath));
			}
			for (int num9 = 0; num9 < value6.LeaveFX.Count; num9++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].LeaveFX[{num9}].AttachName", value6.LeaveFX[num9].AttachName));
			}
			for (int num10 = 0; num10 < value6.LeaveFX.Count; num10++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].LeaveFX[{num10}].SkelMeshParamName", value6.LeaveFX[num10].SkelMeshParamName));
			}
			for (int num11 = 0; num11 < value6.LeaveFX.Count; num11++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].LeaveFX[{num11}].AddTags", value6.LeaveFX[num11].AddTags));
			}
			for (int num12 = 0; num12 < value6.DamageFXSetting.Count; num12++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].DamageFXSetting[{num12}].PSPath", value6.DamageFXSetting[num12].PSPath));
			}
			for (int num13 = 0; num13 < value6.DamageFXSetting.Count; num13++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].DamageFXSetting[{num13}].AttachName", value6.DamageFXSetting[num13].AttachName));
			}
			for (int num14 = 0; num14 < value6.DamageFXSetting.Count; num14++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].DamageFXSetting[{num14}].SkelMeshParamName", value6.DamageFXSetting[num14].SkelMeshParamName));
			}
			for (int num15 = 0; num15 < value6.DamageFXSetting.Count; num15++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].DamageFXSetting[{num15}].AddTags", value6.DamageFXSetting[num15].AddTags));
			}
			for (int num16 = 0; num16 < value6.MaterialSetting.Count; num16++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffDispDesc[{key6}].MaterialSetting[{num16}]", value6.MaterialSetting[num16]));
			}
		}
		foreach (KeyValuePair<int, FUStBuffLayerDispDesc> item7 in BG_ProtobufDataAPI<FUStBuffLayerDispDesc>.Get().GetAll())
		{
			FUStBuffLayerDispDesc value7 = item7.Value;
			int key7 = item7.Key;
			for (int num17 = 0; num17 < value7.Config.Count; num17++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBuffLayerDispDesc[{key7}].Config[{num17}].DBCPath", value7.Config[num17].DBCPath));
			}
		}
		foreach (KeyValuePair<int, FUStUnitCommDesc> item8 in BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().GetAll())
		{
			FUStUnitCommDesc value8 = item8.Value;
			int key8 = item8.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].WeaponSharpSkillEffectAssetPath", value8.WeaponSharpSkillEffectAssetPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].WeaponSharpCritSkillEffectAssetPath", value8.WeaponSharpCritSkillEffectAssetPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].LeftFootSpeedRefBone", value8.LeftFootSpeedRefBone));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].RightFootSpeedRefBone", value8.RightFootSpeedRefBone));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].LeftFootBone", value8.LeftFootBone));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].RightFootBone", value8.RightFootBone));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].LeftFootFrontSocket", value8.LeftFootFrontSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].RightFootFrontSocket", value8.RightFootFrontSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].AimOffsetEyeSocketName", value8.AimOffsetEyeSocketName));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].AimOffsetBeWatchedSocketName", value8.AimOffsetBeWatchedSocketName));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitCommDesc[{key8}].Guard", value8.Guard));
		}
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item9 in BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetAll())
		{
			FUStUnitBattleInfoExtendDesc value9 = item9.Value;
			int key9 = item9.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitBattleInfoExtendDesc[{key9}].UnitName", value9.UnitName));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitBattleInfoExtendDesc[{key9}].FoliageFadeScaleCurve", value9.FoliageFadeScaleCurve));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitBattleInfoExtendDesc[{key9}].Guard", value9.Guard));
		}
		foreach (KeyValuePair<int, FUStUnitPassiveSkillInfoExtendDesc> item10 in BG_ProtobufDataAPI<FUStUnitPassiveSkillInfoExtendDesc>.Get().GetAll())
		{
			FUStUnitPassiveSkillInfoExtendDesc value10 = item10.Value;
			int key10 = item10.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitPassiveSkillInfoExtendDesc[{key10}].UnitName", value10.UnitName));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitPassiveSkillInfoExtendDesc[{key10}].Guard", value10.Guard));
		}
		foreach (KeyValuePair<int, FUStUnitEnvMaskConfigDesc> item11 in BG_ProtobufDataAPI<FUStUnitEnvMaskConfigDesc>.Get().GetAll())
		{
			FUStUnitEnvMaskConfigDesc value11 = item11.Value;
			int key11 = item11.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitEnvMaskConfigDesc[{key11}].UnitName", value11.UnitName));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitEnvMaskConfigDesc[{key11}].Guard", value11.Guard));
		}
		foreach (KeyValuePair<int, FUStMagicFieldCommDesc> item12 in BG_ProtobufDataAPI<FUStMagicFieldCommDesc>.Get().GetAll())
		{
			FUStMagicFieldCommDesc value12 = item12.Value;
			int key12 = item12.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMagicFieldCommDesc[{key12}].MagicBPTemplatePath", value12.MagicBPTemplatePath));
		}
		foreach (KeyValuePair<int, FUStAISkillBasicActionDesc> item13 in BG_ProtobufDataAPI<FUStAISkillBasicActionDesc>.Get().GetAll())
		{
			_ = item13.Value;
			_ = item13.Key;
		}
		foreach (KeyValuePair<int, FUStUnitLevelUpDesc> item14 in BG_ProtobufDataAPI<FUStUnitLevelUpDesc>.Get().GetAll())
		{
			FUStUnitLevelUpDesc value13 = item14.Value;
			int key13 = item14.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitLevelUpDesc[{key13}].CommAbnormalAttrConfigPath", value13.CommAbnormalAttrConfigPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitLevelUpDesc[{key13}].Guard", value13.Guard));
		}
		foreach (KeyValuePair<int, FUStAISkillTagsDesc> item15 in BG_ProtobufDataAPI<FUStAISkillTagsDesc>.Get().GetAll())
		{
			_ = item15.Value;
			_ = item15.Key;
		}
		foreach (KeyValuePair<int, FUStAIActionDesc> item16 in BG_ProtobufDataAPI<FUStAIActionDesc>.Get().GetAll())
		{
			_ = item16.Value;
			_ = item16.Key;
		}
		foreach (KeyValuePair<int, FUStAIThinkDesc> item17 in BG_ProtobufDataAPI<FUStAIThinkDesc>.Get().GetAll())
		{
			_ = item17.Value;
			_ = item17.Key;
		}
		foreach (KeyValuePair<int, FUStAIFeatureDesc> item18 in BG_ProtobufDataAPI<FUStAIFeatureDesc>.Get().GetAll())
		{
			_ = item18.Value;
			_ = item18.Key;
		}
		foreach (KeyValuePair<int, FUStEnhancedInputActionDesc> item19 in BG_ProtobufDataAPI<FUStEnhancedInputActionDesc>.Get().GetAll())
		{
			FUStEnhancedInputActionDesc value14 = item19.Value;
			int key14 = item19.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStEnhancedInputActionDesc[{key14}].ActionName", value14.ActionName));
			TableContentList.Add(new Tuple<string, string>($"FUStEnhancedInputActionDesc[{key14}].DebugActionName", value14.DebugActionName));
		}
		foreach (KeyValuePair<int, FUStChallengeDesc> item20 in BG_ProtobufDataAPI<FUStChallengeDesc>.Get().GetAll())
		{
			FUStChallengeDesc value15 = item20.Value;
			int key15 = item20.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].ChallengeName", value15.ChallengeName));
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].ChallengeDesc", value15.ChallengeDesc));
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].InteractGuid", value15.InteractGuid));
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].TeleportName", value15.TeleportName));
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].EasyDesc", value15.EasyDesc));
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].NormalDesc", value15.NormalDesc));
			TableContentList.Add(new Tuple<string, string>($"FUStChallengeDesc[{key15}].HardDesc", value15.HardDesc));
		}
		foreach (KeyValuePair<int, FUStGuideNodeDesc> item21 in BG_ProtobufDataAPI<FUStGuideNodeDesc>.Get().GetAll())
		{
			FUStGuideNodeDesc value16 = item21.Value;
			int key16 = item21.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStGuideNodeDesc[{key16}].GuideTitle", value16.GuideTitle));
			TableContentList.Add(new Tuple<string, string>($"FUStGuideNodeDesc[{key16}].GuideDesc", value16.GuideDesc));
			TableContentList.Add(new Tuple<string, string>($"FUStGuideNodeDesc[{key16}].FinishParam", value16.FinishParam));
			TableContentList.Add(new Tuple<string, string>($"FUStGuideNodeDesc[{key16}].InputAction", value16.InputAction));
			for (int num18 = 0; num18 < value16.InputActionTips.Count; num18++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStGuideNodeDesc[{key16}].InputActionTips[{num18}].Name", value16.InputActionTips[num18].Name));
			}
			for (int num19 = 0; num19 < value16.InputActionTips.Count; num19++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStGuideNodeDesc[{key16}].InputActionTips[{num19}].Desc", value16.InputActionTips[num19].Desc));
			}
		}
		foreach (KeyValuePair<int, FUStGuideGroupDesc> item22 in BG_ProtobufDataAPI<FUStGuideGroupDesc>.Get().GetAll())
		{
			_ = item22.Value;
			_ = item22.Key;
		}
		foreach (KeyValuePair<int, FUStAkEventMarkerDesc> item23 in BG_ProtobufDataAPI<FUStAkEventMarkerDesc>.Get().GetAll())
		{
			FUStAkEventMarkerDesc value17 = item23.Value;
			int key17 = item23.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAkEventMarkerDesc[{key17}].AkEventName", value17.AkEventName));
			TableContentList.Add(new Tuple<string, string>($"FUStAkEventMarkerDesc[{key17}].AkSoundName", value17.AkSoundName));
			for (int num20 = 0; num20 < value17.Culture.Count; num20++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAkEventMarkerDesc[{key17}].Culture[{num20}].Name", value17.Culture[num20].Name));
			}
		}
	}
}
