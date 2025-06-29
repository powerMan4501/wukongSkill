using System;
using System.Collections.Generic;
using b1.Protobuf.DataAPI;
using BtlB1;

namespace b1;

public class GameDBBtlB1
{
	public static void DumpStringContent(List<Tuple<string, string>> TableContentList)
	{
		foreach (KeyValuePair<int, FUStCBGTemplateDesc> item in BG_ProtobufDataAPI<FUStCBGTemplateDesc>.Get().GetAll())
		{
			FUStCBGTemplateDesc value = item.Value;
			int key = item.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStCBGTemplateDesc[{key}].Path", value.Path));
		}
		foreach (KeyValuePair<int, FUStShiningDesc> item2 in BG_ProtobufDataAPI<FUStShiningDesc>.Get().GetAll())
		{
			_ = item2.Value;
			_ = item2.Key;
		}
		foreach (KeyValuePair<int, FUStFixFunctionDesc> item3 in BG_ProtobufDataAPI<FUStFixFunctionDesc>.Get().GetAll())
		{
			_ = item3.Value;
			_ = item3.Key;
		}
		foreach (KeyValuePair<int, FUStEnvironmentSurfaceEffectDesc> item4 in BG_ProtobufDataAPI<FUStEnvironmentSurfaceEffectDesc>.Get().GetAll())
		{
			FUStEnvironmentSurfaceEffectDesc value2 = item4.Value;
			int key2 = item4.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStEnvironmentSurfaceEffectDesc[{key2}].EnvironmentAbnormalEffectDA", value2.EnvironmentAbnormalEffectDA));
		}
		foreach (KeyValuePair<int, FUStInteractiveUnitCommDesc> item5 in BG_ProtobufDataAPI<FUStInteractiveUnitCommDesc>.Get().GetAll())
		{
			FUStInteractiveUnitCommDesc value3 = item5.Value;
			int key3 = item5.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStInteractiveUnitCommDesc[{key3}].Name", value3.Name));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractiveUnitCommDesc[{key3}].FocusIconPath", value3.FocusIconPath));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractiveUnitCommDesc[{key3}].HighLightFXPath", value3.HighLightFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractiveUnitCommDesc[{key3}].TalentHighLightFXPath", value3.TalentHighLightFXPath));
		}
		foreach (KeyValuePair<int, FUStInteractionMappingDesc> item6 in BG_ProtobufDataAPI<FUStInteractionMappingDesc>.Get().GetAll())
		{
			FUStInteractionMappingDesc value4 = item6.Value;
			int key4 = item6.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].InteractName", value4.InteractName));
			for (int i = 0; i < value4.ParamsString.Count; i++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].ParamsString[{i}]", value4.ParamsString[i]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].CameraCompTag", value4.CameraCompTag));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].CameraBlendTime", value4.CameraBlendTime));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].MathchingPointCompTag", value4.MathchingPointCompTag));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].IdleBefore", value4.IdleBefore));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].IdleAfter", value4.IdleAfter));
			TableContentList.Add(new Tuple<string, string>($"FUStInteractionMappingDesc[{key4}].InitAnim", value4.InitAnim));
		}
		foreach (KeyValuePair<int, FUStAiInteractionMappingDesc> item7 in BG_ProtobufDataAPI<FUStAiInteractionMappingDesc>.Get().GetAll())
		{
			FUStAiInteractionMappingDesc value5 = item7.Value;
			int key5 = item7.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAiInteractionMappingDesc[{key5}].WaitingPointCompTag", value5.WaitingPointCompTag));
			TableContentList.Add(new Tuple<string, string>($"FUStAiInteractionMappingDesc[{key5}].LinerMatchingPointSpeedRateDistanceCurvePath", value5.LinerMatchingPointSpeedRateDistanceCurvePath));
		}
		foreach (KeyValuePair<int, FUStOverlyingSkillSDesc> item8 in BG_ProtobufDataAPI<FUStOverlyingSkillSDesc>.Get().GetAll())
		{
			_ = item8.Value;
			_ = item8.Key;
		}
		foreach (KeyValuePair<int, FUStChargeSkillSDesc> item9 in BG_ProtobufDataAPI<FUStChargeSkillSDesc>.Get().GetAll())
		{
			FUStChargeSkillSDesc value6 = item9.Value;
			int key6 = item9.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStChargeSkillSDesc[{key6}].LoopTemplatePath", value6.LoopTemplatePath));
			if (value6.ChargeSkillSuperArmorInfo != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStChargeSkillSDesc[{key6}].ChargeSkillSuperArmorInfo.SSABreakAssignedAnim", value6.ChargeSkillSuperArmorInfo.SSABreakAssignedAnim));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStChargeSkillSDesc[{key6}].ChargeLevelConfigPath", value6.ChargeLevelConfigPath));
		}
		foreach (KeyValuePair<int, FUStIronBodyConfigDesc> item10 in BG_ProtobufDataAPI<FUStIronBodyConfigDesc>.Get().GetAll())
		{
			_ = item10.Value;
			_ = item10.Key;
		}
		foreach (KeyValuePair<int, FUStDetonateConfigDesc> item11 in BG_ProtobufDataAPI<FUStDetonateConfigDesc>.Get().GetAll())
		{
			FUStDetonateConfigDesc value7 = item11.Value;
			int key7 = item11.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStDetonateConfigDesc[{key7}].ExplosiveDBCPath", value7.ExplosiveDBCPath));
		}
		foreach (KeyValuePair<int, FUStAttachedNiagaraByHitDesc> item12 in BG_ProtobufDataAPI<FUStAttachedNiagaraByHitDesc>.Get().GetAll())
		{
			FUStAttachedNiagaraByHitDesc value8 = item12.Value;
			int key8 = item12.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].DBCPath", value8.DBCPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].NoneDBCpath", value8.NoneDBCpath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].SmallDBCpath", value8.SmallDBCpath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].MediumDBCpath", value8.MediumDBCpath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].MediumBigDBCpath", value8.MediumBigDBCpath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].BigDBCpath", value8.BigDBCpath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttachedNiagaraByHitDesc[{key8}].HugeDBCpath", value8.HugeDBCpath));
		}
		foreach (KeyValuePair<int, FUStGlobalConfigDesc> item13 in BG_ProtobufDataAPI<FUStGlobalConfigDesc>.Get().GetAll())
		{
			FUStGlobalConfigDesc value9 = item13.Value;
			int key9 = item13.Key;
			if (value9.ConfigInfo != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStGlobalConfigDesc[{key9}].ConfigInfo.AliasName", value9.ConfigInfo.AliasName));
			}
			if (value9.ConfigInfo != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStGlobalConfigDesc[{key9}].ConfigInfo.ConfigValue", value9.ConfigInfo.ConfigValue));
			}
		}
		foreach (KeyValuePair<int, FUStSkillAIDesc> item14 in BG_ProtobufDataAPI<FUStSkillAIDesc>.Get().GetAll())
		{
			FUStSkillAIDesc value10 = item14.Value;
			int key10 = item14.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSkillAIDesc[{key10}].TargetResIDList", value10.TargetResIDList));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillAIDesc[{key10}].CanUseInGroupAIBuffConditions", value10.CanUseInGroupAIBuffConditions));
			TableContentList.Add(new Tuple<string, string>($"FUStSkillAIDesc[{key10}].Guard", value10.Guard));
		}
		foreach (KeyValuePair<int, FUStCCGCastSkillMappingRuleDesc> item15 in BG_ProtobufDataAPI<FUStCCGCastSkillMappingRuleDesc>.Get().GetAll())
		{
			FUStCCGCastSkillMappingRuleDesc value11 = item15.Value;
			int key11 = item15.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStCCGCastSkillMappingRuleDesc[{key11}].Guard", value11.Guard));
		}
		foreach (KeyValuePair<int, FUStUnitAIDesc> item16 in BG_ProtobufDataAPI<FUStUnitAIDesc>.Get().GetAll())
		{
			FUStUnitAIDesc value12 = item16.Value;
			int key12 = item16.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitAIDesc[{key12}].GazeAndSurroundEQSPath", value12.GazeAndSurroundEQSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitAIDesc[{key12}].Guard", value12.Guard));
		}
		foreach (KeyValuePair<int, FUStDropItemDesc> item17 in BG_ProtobufDataAPI<FUStDropItemDesc>.Get().GetAll())
		{
			FUStDropItemDesc value13 = item17.Value;
			int key13 = item17.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStDropItemDesc[{key13}].DisplayName", value13.DisplayName));
			TableContentList.Add(new Tuple<string, string>($"FUStDropItemDesc[{key13}].ResPath", value13.ResPath));
		}
		foreach (KeyValuePair<int, FUStHitVEffectDesc> item18 in BG_ProtobufDataAPI<FUStHitVEffectDesc>.Get().GetAll())
		{
			_ = item18.Value;
			_ = item18.Key;
		}
		foreach (KeyValuePair<int, FUStPhysicalHitBoneRuleDesc> item19 in BG_ProtobufDataAPI<FUStPhysicalHitBoneRuleDesc>.Get().GetAll())
		{
			FUStPhysicalHitBoneRuleDesc value14 = item19.Value;
			int key14 = item19.Key;
			for (int j = 0; j < value14.BoneName.Count; j++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStPhysicalHitBoneRuleDesc[{key14}].BoneName[{j}]", value14.BoneName[j]));
			}
		}
		foreach (KeyValuePair<int, FUStScarInfoDesc> item20 in BG_ProtobufDataAPI<FUStScarInfoDesc>.Get().GetAll())
		{
			FUStScarInfoDesc value15 = item20.Value;
			int key15 = item20.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStScarInfoDesc[{key15}].Guard", value15.Guard));
		}
		foreach (KeyValuePair<int, FUStBeAttackedInfoDesc> item21 in BG_ProtobufDataAPI<FUStBeAttackedInfoDesc>.Get().GetAll())
		{
			FUStBeAttackedInfoDesc value16 = item21.Value;
			int key16 = item21.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedInfoDesc[{key16}].BeAttackedPhysAnimAsset", value16.BeAttackedPhysAnimAsset));
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedInfoDesc[{key16}].UnitBeAttackedConfigPath", value16.UnitBeAttackedConfigPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedInfoDesc[{key16}].Guard", value16.Guard));
		}
		foreach (KeyValuePair<int, FUStBeAttackedDispInfoDesc> item22 in BG_ProtobufDataAPI<FUStBeAttackedDispInfoDesc>.Get().GetAll())
		{
			FUStBeAttackedDispInfoDesc value17 = item22.Value;
			int key17 = item22.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedDispInfoDesc[{key17}].Guard", value17.Guard));
		}
		foreach (KeyValuePair<int, FUStBeAttackedStiffLevelMappingDesc> item23 in BG_ProtobufDataAPI<FUStBeAttackedStiffLevelMappingDesc>.Get().GetAll())
		{
			FUStBeAttackedStiffLevelMappingDesc value18 = item23.Value;
			int key18 = item23.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedStiffLevelMappingDesc[{key18}].Guard", value18.Guard));
		}
		foreach (KeyValuePair<int, FUStPartRuleInfoDesc> item24 in BG_ProtobufDataAPI<FUStPartRuleInfoDesc>.Get().GetAll())
		{
			FUStPartRuleInfoDesc value19 = item24.Value;
			int key19 = item24.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPartRuleInfoDesc[{key19}].PartName", value19.PartName));
			TableContentList.Add(new Tuple<string, string>($"FUStPartRuleInfoDesc[{key19}].CanInterruptPartIDs", value19.CanInterruptPartIDs));
			for (int k = 0; k < value19.HitPartRuleParam.Count; k++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStPartRuleInfoDesc[{key19}].HitPartRuleParam[{k}]", value19.HitPartRuleParam[k]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStPartRuleInfoDesc[{key19}].PartHitUnitBeAttackedConfigPath", value19.PartHitUnitBeAttackedConfigPath));
			TableContentList.Add(new Tuple<string, string>($"FUStPartRuleInfoDesc[{key19}].DamagedAMDataAssetPath", value19.DamagedAMDataAssetPath));
			TableContentList.Add(new Tuple<string, string>($"FUStPartRuleInfoDesc[{key19}].Guard", value19.Guard));
		}
		foreach (KeyValuePair<int, FUStPartHitExpandDesc> item25 in BG_ProtobufDataAPI<FUStPartHitExpandDesc>.Get().GetAll())
		{
			FUStPartHitExpandDesc value20 = item25.Value;
			int key20 = item25.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPartHitExpandDesc[{key20}].Guard", value20.Guard));
		}
		foreach (KeyValuePair<int, FUStAttackerHitFXMappingDesc> item26 in BG_ProtobufDataAPI<FUStAttackerHitFXMappingDesc>.Get().GetAll())
		{
			FUStAttackerHitFXMappingDesc value21 = item26.Value;
			int key21 = item26.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAttackerHitFXMappingDesc[{key21}].Guard", value21.Guard));
		}
		foreach (KeyValuePair<int, FUStAttackerHitAudioEventMappingDesc> item27 in BG_ProtobufDataAPI<FUStAttackerHitAudioEventMappingDesc>.Get().GetAll())
		{
			FUStAttackerHitAudioEventMappingDesc value22 = item27.Value;
			int key22 = item27.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAttackerHitAudioEventMappingDesc[{key22}].Guard", value22.Guard));
		}
		foreach (KeyValuePair<int, FUStQTEDesc> item28 in BG_ProtobufDataAPI<FUStQTEDesc>.Get().GetAll())
		{
			FUStQTEDesc value23 = item28.Value;
			int key23 = item28.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStQTEDesc[{key23}].TargetMontage", value23.TargetMontage));
		}
		foreach (KeyValuePair<int, FUStSettingDetailDesc> item29 in BG_ProtobufDataAPI<FUStSettingDetailDesc>.Get().GetAll())
		{
			FUStSettingDetailDesc value24 = item29.Value;
			int key24 = item29.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSettingDetailDesc[{key24}].GName", value24.GName));
			for (int l = 0; l < value24.ValueDesc.Count; l++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSettingDetailDesc[{key24}].ValueDesc[{l}]", value24.ValueDesc[l]));
			}
		}
		foreach (KeyValuePair<int, FUStRebirthPointDesc> item30 in BG_ProtobufDataAPI<FUStRebirthPointDesc>.Get().GetAll())
		{
			FUStRebirthPointDesc value25 = item30.Value;
			int key25 = item30.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].Name", value25.Name));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].SceneComponentName", value25.SceneComponentName));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].ActiveMontage", value25.ActiveMontage));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].ActiveStateMontage", value25.ActiveStateMontage));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].RebirthPointDBCWhenPlayerRebirth", value25.RebirthPointDBCWhenPlayerRebirth));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].MainMenuAudioEvent", value25.MainMenuAudioEvent));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].PlayNavAudioEvent", value25.PlayNavAudioEvent));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].StopNavAudioEvent", value25.StopNavAudioEvent));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].PlayResidentAudioEvent", value25.PlayResidentAudioEvent));
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthPointDesc[{key25}].StopResidentAudioEvent", value25.StopResidentAudioEvent));
		}
		foreach (KeyValuePair<int, FUStRebirthAreaDesc> item31 in BG_ProtobufDataAPI<FUStRebirthAreaDesc>.Get().GetAll())
		{
			FUStRebirthAreaDesc value26 = item31.Value;
			int key26 = item31.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStRebirthAreaDesc[{key26}].Name", value26.Name));
		}
		foreach (KeyValuePair<int, FUStSummonCommDesc> item32 in BG_ProtobufDataAPI<FUStSummonCommDesc>.Get().GetAll())
		{
			FUStSummonCommDesc value27 = item32.Value;
			int key27 = item32.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].SummonTamerTemplatePath", value27.SummonTamerTemplatePath));
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].SummonBPTemplatePath", value27.SummonBPTemplatePath));
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].SummonDataAssetsPath", value27.SummonDataAssetsPath));
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].SummonSpawnEQSPath", value27.SummonSpawnEQSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].SummonSpawnSceneItemTag", value27.SummonSpawnSceneItemTag));
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].BornEffectPath", value27.BornEffectPath));
			for (int m = 0; m < value27.BornMontagePathList.Count; m++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].BornMontagePathList[{m}]", value27.BornMontagePathList[m]));
			}
			for (int n = 0; n < value27.DisappearMontagePathList.Count; n++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSummonCommDesc[{key27}].DisappearMontagePathList[{n}]", value27.DisappearMontagePathList[n]));
			}
		}
		foreach (KeyValuePair<int, FUStSummonCopySkillDesc> item33 in BG_ProtobufDataAPI<FUStSummonCopySkillDesc>.Get().GetAll())
		{
			FUStSummonCopySkillDesc value28 = item33.Value;
			int key28 = item33.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSummonCopySkillDesc[{key28}].SummonUnitMontagePath", value28.SummonUnitMontagePath));
		}
		foreach (KeyValuePair<int, FUStAttrCopyConfigDesc> item34 in BG_ProtobufDataAPI<FUStAttrCopyConfigDesc>.Get().GetAll())
		{
			_ = item34.Value;
			_ = item34.Key;
		}
		foreach (KeyValuePair<int, FUStUnitChangeMaterialByAttrDesc> item35 in BG_ProtobufDataAPI<FUStUnitChangeMaterialByAttrDesc>.Get().GetAll())
		{
			FUStUnitChangeMaterialByAttrDesc value29 = item35.Value;
			int key29 = item35.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitChangeMaterialByAttrDesc[{key29}].ConfigDAPath", value29.ConfigDAPath));
		}
		foreach (KeyValuePair<int, FUStSettingClassNameDesc> item36 in BG_ProtobufDataAPI<FUStSettingClassNameDesc>.Get().GetAll())
		{
			FUStSettingClassNameDesc value30 = item36.Value;
			int key30 = item36.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSettingClassNameDesc[{key30}].GName", value30.GName));
		}
		foreach (KeyValuePair<int, FUStEQSSettingDesc> item37 in BG_ProtobufDataAPI<FUStEQSSettingDesc>.Get().GetAll())
		{
			_ = item37.Value;
			_ = item37.Key;
		}
		foreach (KeyValuePair<int, FUStSweepCheckDesc> item38 in BG_ProtobufDataAPI<FUStSweepCheckDesc>.Get().GetAll())
		{
			FUStSweepCheckDesc value31 = item38.Value;
			int key31 = item38.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSweepCheckDesc[{key31}].SocketName", value31.SocketName));
		}
		foreach (KeyValuePair<int, FUStBulletCommDesc> item39 in BG_ProtobufDataAPI<FUStBulletCommDesc>.Get().GetAll())
		{
			FUStBulletCommDesc value32 = item39.Value;
			int key32 = item39.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletBPTemplatePath", value32.BulletBPTemplatePath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletMergeTag", value32.BulletMergeTag));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletAnimPath", value32.BulletAnimPath));
			for (int num = 0; num < value32.BulletMoveModeStrParam.Count; num++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletMoveModeStrParam[{num}]", value32.BulletMoveModeStrParam[num]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].FXDestroyImmediatelyTag", value32.FXDestroyImmediatelyTag));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BeHitedBulletPostAKPath", value32.BeHitedBulletPostAKPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletSpawnPSPath", value32.BulletSpawnPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletSelfSpawnDBCPath", value32.BulletSelfSpawnDBCPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletHitItemPSPath", value32.BulletHitItemPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletHitUnitPSPath", value32.BulletHitUnitPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BulletLifeOverPSPath", value32.BulletLifeOverPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].BeHitedBulletPlayFXPath", value32.BeHitedBulletPlayFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletCommDesc[{key32}].Guard", value32.Guard));
		}
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item40 in BG_ProtobufDataAPI<FUStProjectileCommDesc>.Get().GetAll())
		{
			FUStProjectileCommDesc value33 = item40.Value;
			int key33 = item40.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileCommDesc[{key33}].ProjectileBPTemplatePath", value33.ProjectileBPTemplatePath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileCommDesc[{key33}].ProjectileAnimPath", value33.ProjectileAnimPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileCommDesc[{key33}].ProjectileSweepReactionDataAssetPath", value33.ProjectileSweepReactionDataAssetPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileCommDesc[{key33}].ProjectileScaleCurvePath", value33.ProjectileScaleCurvePath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileCommDesc[{key33}].ProjectileInnerRadiusCurvePath", value33.ProjectileInnerRadiusCurvePath));
		}
		foreach (KeyValuePair<int, FUStProjectileDispDesc> item41 in BG_ProtobufDataAPI<FUStProjectileDispDesc>.Get().GetAll())
		{
			FUStProjectileDispDesc value34 = item41.Value;
			int key34 = item41.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].ProjectileSpawnPSPath", value34.ProjectileSpawnPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].ProjectileSelfSpawnDBCPath", value34.ProjectileSelfSpawnDBCPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].BulletHitItemPSPath", value34.BulletHitItemPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].BulletHitUnitPSPath", value34.BulletHitUnitPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].BulletLifeOverPSPath", value34.BulletLifeOverPSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].BeHitedProjectilePlayFXPath", value34.BeHitedProjectilePlayFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].BeHitedProjectilePostAKPath", value34.BeHitedProjectilePostAKPath));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].FXDestroyImmediatelyTag", value34.FXDestroyImmediatelyTag));
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileDispDesc[{key34}].Guard", value34.Guard));
		}
		foreach (KeyValuePair<int, FUStProjectileMoveDesc> item42 in BG_ProtobufDataAPI<FUStProjectileMoveDesc>.Get().GetAll())
		{
			FUStProjectileMoveDesc value35 = item42.Value;
			int key35 = item42.Key;
			for (int num2 = 0; num2 < value35.ProjectileMoveModeStrParam.Count; num2++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStProjectileMoveDesc[{key35}].ProjectileMoveModeStrParam[{num2}]", value35.ProjectileMoveModeStrParam[num2]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStProjectileMoveDesc[{key35}].Guard", value35.Guard));
		}
		foreach (KeyValuePair<int, FUStBulletExpandDesc> item43 in BG_ProtobufDataAPI<FUStBulletExpandDesc>.Get().GetAll())
		{
			FUStBulletExpandDesc value36 = item43.Value;
			int key36 = item43.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBulletExpandDesc[{key36}].BulletMergeTag", value36.BulletMergeTag));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletExpandDesc[{key36}].LaserLengthSpeedCurvePath", value36.LaserLengthSpeedCurvePath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletExpandDesc[{key36}].Guard", value36.Guard));
		}
		foreach (KeyValuePair<int, FUStBulletWindFieldExpandDesc> item44 in BG_ProtobufDataAPI<FUStBulletWindFieldExpandDesc>.Get().GetAll())
		{
			FUStBulletWindFieldExpandDesc value37 = item44.Value;
			int key37 = item44.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBulletWindFieldExpandDesc[{key37}].Guard", value37.Guard));
		}
		foreach (KeyValuePair<int, FUStMagicFieldExpandDesc> item45 in BG_ProtobufDataAPI<FUStMagicFieldExpandDesc>.Get().GetAll())
		{
			FUStMagicFieldExpandDesc value38 = item45.Value;
			int key38 = item45.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMagicFieldExpandDesc[{key38}].Guard", value38.Guard));
		}
		foreach (KeyValuePair<int, FUStExAnimDataDesc> item46 in BG_ProtobufDataAPI<FUStExAnimDataDesc>.Get().GetAll())
		{
			FUStExAnimDataDesc value39 = item46.Value;
			int key39 = item46.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStExAnimDataDesc[{key39}].ExAnimDataPath", value39.ExAnimDataPath));
		}
		foreach (KeyValuePair<int, FUStBulletSwitchDesc> item47 in BG_ProtobufDataAPI<FUStBulletSwitchDesc>.Get().GetAll())
		{
			FUStBulletSwitchDesc value40 = item47.Value;
			int key40 = item47.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBulletSwitchDesc[{key40}].TargetSocket", value40.TargetSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletSwitchDesc[{key40}].TargetEQSTemplate", value40.TargetEQSTemplate));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletSwitchDesc[{key40}].BulletMoveModeFlySpdCurvePath", value40.BulletMoveModeFlySpdCurvePath));
			TableContentList.Add(new Tuple<string, string>($"FUStBulletSwitchDesc[{key40}].BulletMoveModeRotSpdCurvePath", value40.BulletMoveModeRotSpdCurvePath));
		}
		foreach (KeyValuePair<int, FUStAttrEffectDesc> item48 in BG_ProtobufDataAPI<FUStAttrEffectDesc>.Get().GetAll())
		{
			_ = item48.Value;
			_ = item48.Key;
		}
		foreach (KeyValuePair<int, FUStSuitDesc> item49 in BG_ProtobufDataAPI<FUStSuitDesc>.Get().GetAll())
		{
			FUStSuitDesc value41 = item49.Value;
			int key41 = item49.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSuitDesc[{key41}].SuitName", value41.SuitName));
			for (int num3 = 0; num3 < value41.SuitInfo.Count; num3++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSuitDesc[{key41}].SuitInfo[{num3}].SuitEffectDesc", value41.SuitInfo[num3].SuitEffectDesc));
			}
			if (value41.RedQualityInfo != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStSuitDesc[{key41}].RedQualityInfo.RedQualityEffectDesc", value41.RedQualityInfo.RedQualityEffectDesc));
			}
		}
		foreach (KeyValuePair<int, FUStEnvironmentSwitchDesc> item50 in BG_ProtobufDataAPI<FUStEnvironmentSwitchDesc>.Get().GetAll())
		{
			FUStEnvironmentSwitchDesc value42 = item50.Value;
			int key42 = item50.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStEnvironmentSwitchDesc[{key42}].EnvDataPath", value42.EnvDataPath));
		}
		foreach (KeyValuePair<int, FUStUnitCollisionHitMoveDesc> item51 in BG_ProtobufDataAPI<FUStUnitCollisionHitMoveDesc>.Get().GetAll())
		{
			FUStUnitCollisionHitMoveDesc value43 = item51.Value;
			int key43 = item51.Key;
			for (int num4 = 0; num4 < value43.OtherCollisions.Count; num4++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStUnitCollisionHitMoveDesc[{key43}].OtherCollisions[{num4}].CollisionName", value43.OtherCollisions[num4].CollisionName));
			}
		}
		foreach (KeyValuePair<int, FUStUnitTransCommDesc> item52 in BG_ProtobufDataAPI<FUStUnitTransCommDesc>.Get().GetAll())
		{
			FUStUnitTransCommDesc value44 = item52.Value;
			int key44 = item52.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitTransCommDesc[{key44}].BPPath", value44.BPPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitTransCommDesc[{key44}].TamerPath", value44.TamerPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitTransCommDesc[{key44}].UnitSpawnLocationOffset", value44.UnitSpawnLocationOffset));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitTransCommDesc[{key44}].NewUnitSpawnLocationOffset", value44.NewUnitSpawnLocationOffset));
		}
		foreach (KeyValuePair<int, FUStRollSkillDesc> item53 in BG_ProtobufDataAPI<FUStRollSkillDesc>.Get().GetAll())
		{
			_ = item53.Value;
			_ = item53.Key;
		}
		foreach (KeyValuePair<int, FUStUnitDropDesc> item54 in BG_ProtobufDataAPI<FUStUnitDropDesc>.Get().GetAll())
		{
			_ = item54.Value;
			_ = item54.Key;
		}
		foreach (KeyValuePair<int, FUStNianhuiNameListDesc> item55 in BG_ProtobufDataAPI<FUStNianhuiNameListDesc>.Get().GetAll())
		{
			FUStNianhuiNameListDesc value45 = item55.Value;
			int key45 = item55.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiNameListDesc[{key45}].NameEn", value45.NameEn));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiNameListDesc[{key45}].NameCn", value45.NameCn));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiNameListDesc[{key45}].Texture", value45.Texture));
		}
		foreach (KeyValuePair<int, FUStNianhuiAwardDesc> item56 in BG_ProtobufDataAPI<FUStNianhuiAwardDesc>.Get().GetAll())
		{
			FUStNianhuiAwardDesc value46 = item56.Value;
			int key46 = item56.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].AwardName", value46.AwardName));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].AwardImage", value46.AwardImage));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].DropItemColor", value46.DropItemColor));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].DropItemNameColor", value46.DropItemNameColor));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].DropItemFixedEffect", value46.DropItemFixedEffect));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].DropItemSpawnEffect", value46.DropItemSpawnEffect));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].DropItemLightEffect", value46.DropItemLightEffect));
			TableContentList.Add(new Tuple<string, string>($"FUStNianhuiAwardDesc[{key46}].DropSound", value46.DropSound));
		}
		foreach (KeyValuePair<int, FUStPlayerSkillCtrlDesc> item57 in BG_ProtobufDataAPI<FUStPlayerSkillCtrlDesc>.Get().GetAll())
		{
			FUStPlayerSkillCtrlDesc value47 = item57.Value;
			int key47 = item57.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerSkillCtrlDesc[{key47}].SmartSelectHelpActorPath", value47.SmartSelectHelpActorPath));
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerSkillCtrlDesc[{key47}].SmartSelectUIName", value47.SmartSelectUIName));
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerSkillCtrlDesc[{key47}].SkillIcon", value47.SkillIcon));
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerSkillCtrlDesc[{key47}].HintDesc", value47.HintDesc));
		}
		foreach (KeyValuePair<int, FUStBuffRuleDesc> item58 in BG_ProtobufDataAPI<FUStBuffRuleDesc>.Get().GetAll())
		{
			_ = item58.Value;
			_ = item58.Key;
		}
		foreach (KeyValuePair<int, FUStBuffGroupDesc> item59 in BG_ProtobufDataAPI<FUStBuffGroupDesc>.Get().GetAll())
		{
			_ = item59.Value;
			_ = item59.Key;
		}
		foreach (KeyValuePair<int, FUStTransActiveStateDesc> item60 in BG_ProtobufDataAPI<FUStTransActiveStateDesc>.Get().GetAll())
		{
			_ = item60.Value;
			_ = item60.Key;
		}
		foreach (KeyValuePair<int, FUStMandatoryAITaskDesc> item61 in BG_ProtobufDataAPI<FUStMandatoryAITaskDesc>.Get().GetAll())
		{
			FUStMandatoryAITaskDesc value48 = item61.Value;
			int key48 = item61.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMandatoryAITaskDesc[{key48}].InstanceGUID", value48.InstanceGUID));
			for (int num5 = 0; num5 < value48.AITaskInfoList.Count; num5++)
			{
				for (int num6 = 0; num6 < value48.AITaskInfoList[num5].TaskStringParams.Count; num6++)
				{
					TableContentList.Add(new Tuple<string, string>($"FUStMandatoryAITaskDesc[{key48}].AITaskInfoList[{num5}].TaskStringParams[{num6}]", value48.AITaskInfoList[num5].TaskStringParams[num6]));
				}
			}
		}
		foreach (KeyValuePair<int, FUStAttackHitAudioInfoDesc> item62 in BG_ProtobufDataAPI<FUStAttackHitAudioInfoDesc>.Get().GetAll())
		{
			FUStAttackHitAudioInfoDesc value49 = item62.Value;
			int key49 = item62.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitAudioInfoDesc[{key49}].AudioFolderPath", value49.AudioFolderPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitAudioInfoDesc[{key49}].PreAkEventName", value49.PreAkEventName));
		}
		foreach (KeyValuePair<int, FUStAudioExtendDesc> item63 in BG_ProtobufDataAPI<FUStAudioExtendDesc>.Get().GetAll())
		{
			FUStAudioExtendDesc value50 = item63.Value;
			int key50 = item63.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAudioExtendDesc[{key50}].AudioPath", value50.AudioPath));
		}
		foreach (KeyValuePair<int, FUStEnemyCameraDesc> item64 in BG_ProtobufDataAPI<FUStEnemyCameraDesc>.Get().GetAll())
		{
			FUStEnemyCameraDesc value51 = item64.Value;
			int key51 = item64.Key;
			for (int num7 = 0; num7 < value51.CameraParamString.Count; num7++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStEnemyCameraDesc[{key51}].CameraParamString[{num7}]", value51.CameraParamString[num7]));
			}
		}
		foreach (KeyValuePair<int, FUStStraightCamDesc> item65 in BG_ProtobufDataAPI<FUStStraightCamDesc>.Get().GetAll())
		{
			FUStStraightCamDesc value52 = item65.Value;
			int key52 = item65.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStStraightCamDesc[{key52}].SlowTraceSpeedCurve", value52.SlowTraceSpeedCurve));
			for (int num8 = 0; num8 < value52.CameraParamString.Count; num8++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStStraightCamDesc[{key52}].CameraParamString[{num8}]", value52.CameraParamString[num8]));
			}
		}
		foreach (KeyValuePair<int, FUStDiagonalCamDesc> item66 in BG_ProtobufDataAPI<FUStDiagonalCamDesc>.Get().GetAll())
		{
			_ = item66.Value;
			_ = item66.Key;
		}
		foreach (KeyValuePair<int, FUStGiantLockCameraDesc> item67 in BG_ProtobufDataAPI<FUStGiantLockCameraDesc>.Get().GetAll())
		{
			FUStGiantLockCameraDesc value53 = item67.Value;
			int key53 = item67.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStGiantLockCameraDesc[{key53}].TargetRefHeightOffsetCurve", value53.TargetRefHeightOffsetCurve));
		}
		foreach (KeyValuePair<int, FUStPlayerCameraDesc> item68 in BG_ProtobufDataAPI<FUStPlayerCameraDesc>.Get().GetAll())
		{
			_ = item68.Value;
			_ = item68.Key;
		}
		foreach (KeyValuePair<int, FUStPlayerTransUnitConfDesc> item69 in BG_ProtobufDataAPI<FUStPlayerTransUnitConfDesc>.Get().GetAll())
		{
			_ = item69.Value;
			_ = item69.Key;
		}
		foreach (KeyValuePair<int, FUStPlayerTransAttrDesc> item70 in BG_ProtobufDataAPI<FUStPlayerTransAttrDesc>.Get().GetAll())
		{
			FUStPlayerTransAttrDesc value54 = item70.Value;
			int key54 = item70.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerTransAttrDesc[{key54}].ActorTag", value54.ActorTag));
		}
		foreach (KeyValuePair<int, FUStBeAttackedFXMapDesc> item71 in BG_ProtobufDataAPI<FUStBeAttackedFXMapDesc>.Get().GetAll())
		{
			FUStBeAttackedFXMapDesc value55 = item71.Value;
			int key55 = item71.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedFXMapDesc[{key55}].BeHitFXPath", value55.BeHitFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBeAttackedFXMapDesc[{key55}].BeHitFXPathAttachVer", value55.BeHitFXPathAttachVer));
		}
		foreach (KeyValuePair<int, FUStAttackHitFXMapDesc> item72 in BG_ProtobufDataAPI<FUStAttackHitFXMapDesc>.Get().GetAll())
		{
			FUStAttackHitFXMapDesc value56 = item72.Value;
			int key56 = item72.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].HitFXPath", value56.HitFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].DirectionalFXPath", value56.DirectionalFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].PromptEffectMPCPath", value56.PromptEffectMPCPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].BlurLocMPCParamName", value56.BlurLocMPCParamName));
			for (int num9 = 0; num9 < value56.MPCParamWithCurve.Count; num9++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].MPCParamWithCurve[{num9}].MPCParamName", value56.MPCParamWithCurve[num9].MPCParamName));
			}
			for (int num10 = 0; num10 < value56.MPCParamWithCurve.Count; num10++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].MPCParamWithCurve[{num10}].MPCFloatCurvePath", value56.MPCParamWithCurve[num10].MPCFloatCurvePath));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStAttackHitFXMapDesc[{key56}].CameraShake", value56.CameraShake));
		}
		foreach (KeyValuePair<int, FUStSkillSMappingDesc> item73 in BG_ProtobufDataAPI<FUStSkillSMappingDesc>.Get().GetAll())
		{
			FUStSkillSMappingDesc value57 = item73.Value;
			int key57 = item73.Key;
			for (int num11 = 0; num11 < value57.MappingConfigList.Count; num11++)
			{
				for (int num12 = 0; num12 < value57.MappingConfigList[num11].MontagePaths.Count; num12++)
				{
					TableContentList.Add(new Tuple<string, string>($"FUStSkillSMappingDesc[{key57}].MappingConfigList[{num11}].MontagePaths[{num12}]", value57.MappingConfigList[num11].MontagePaths[num12]));
				}
			}
			for (int num13 = 0; num13 < value57.MappingConfigList.Count; num13++)
			{
				for (int num14 = 0; num14 < value57.MappingConfigList[num13].SectionNameList.Count; num14++)
				{
					TableContentList.Add(new Tuple<string, string>($"FUStSkillSMappingDesc[{key57}].MappingConfigList[{num13}].SectionNameList[{num14}]", value57.MappingConfigList[num13].SectionNameList[num14]));
				}
			}
		}
		foreach (KeyValuePair<int, FUStPlayerCommDesc> item74 in BG_ProtobufDataAPI<FUStPlayerCommDesc>.Get().GetAll())
		{
			FUStPlayerCommDesc value58 = item74.Value;
			int key58 = item74.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerCommDesc[{key58}].UnFreezeAdditiveAMPath", value58.UnFreezeAdditiveAMPath));
			TableContentList.Add(new Tuple<string, string>($"FUStPlayerCommDesc[{key58}].UnFreezeFXPath", value58.UnFreezeFXPath));
		}
		foreach (KeyValuePair<int, FUStPlayerInputSkillMappingDesc> item75 in BG_ProtobufDataAPI<FUStPlayerInputSkillMappingDesc>.Get().GetAll())
		{
			_ = item75.Value;
			_ = item75.Key;
		}
		foreach (KeyValuePair<int, FUStUnitDeadOldDesc> item76 in BG_ProtobufDataAPI<FUStUnitDeadOldDesc>.Get().GetAll())
		{
			FUStUnitDeadOldDesc value59 = item76.Value;
			int key59 = item76.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DefaultDeadMontagePath", value59.DefaultDeadMontagePath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathLightFront", value59.DeadMontagePathLightFront));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathLightLeft", value59.DeadMontagePathLightLeft));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathLightRight", value59.DeadMontagePathLightRight));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathLightBehind", value59.DeadMontagePathLightBehind));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathHeavyFront", value59.DeadMontagePathHeavyFront));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathHeavyLeft", value59.DeadMontagePathHeavyLeft));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathHeavyRight", value59.DeadMontagePathHeavyRight));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathHeavyBehind", value59.DeadMontagePathHeavyBehind));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathFlyFront", value59.DeadMontagePathFlyFront));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathFlyLeft", value59.DeadMontagePathFlyLeft));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathFlyRight", value59.DeadMontagePathFlyRight));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathFlyBehind", value59.DeadMontagePathFlyBehind));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathCut", value59.DeadMontagePathCut));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].DeadMontagePathSuicide", value59.DeadMontagePathSuicide));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadOldDesc[{key59}].Guard", value59.Guard));
		}
		foreach (KeyValuePair<int, FUStUnitDeadSwitchToPhysicDesc> item77 in BG_ProtobufDataAPI<FUStUnitDeadSwitchToPhysicDesc>.Get().GetAll())
		{
			FUStUnitDeadSwitchToPhysicDesc value60 = item77.Value;
			int key60 = item77.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadSwitchToPhysicDesc[{key60}].Guard", value60.Guard));
		}
		foreach (KeyValuePair<int, FUStUnitDeadDesc> item78 in BG_ProtobufDataAPI<FUStUnitDeadDesc>.Get().GetAll())
		{
			FUStUnitDeadDesc value61 = item78.Value;
			int key61 = item78.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadDesc[{key61}].DeadPAPath", value61.DeadPAPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadDesc[{key61}].DeadUseFrozenFracture", value61.DeadUseFrozenFracture));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadDesc[{key61}].DeathDispConfigPath", value61.DeathDispConfigPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadDesc[{key61}].AbnormalStateDeathDispDBCDAPath", value61.AbnormalStateDeathDispDBCDAPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadDesc[{key61}].ThrowUpCurve", value61.ThrowUpCurve));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitDeadDesc[{key61}].Guard", value61.Guard));
		}
		foreach (KeyValuePair<int, FUStHitSceneItemPerformDesc> item79 in BG_ProtobufDataAPI<FUStHitSceneItemPerformDesc>.Get().GetAll())
		{
			FUStHitSceneItemPerformDesc value62 = item79.Value;
			int key62 = item79.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStHitSceneItemPerformDesc[{key62}].HitWorldItemFXPath", value62.HitWorldItemFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStHitSceneItemPerformDesc[{key62}].HitWorldItemDecalPath", value62.HitWorldItemDecalPath));
			TableContentList.Add(new Tuple<string, string>($"FUStHitSceneItemPerformDesc[{key62}].HitGroundFXPath", value62.HitGroundFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStHitSceneItemPerformDesc[{key62}].HitGroundDirectionFXPath", value62.HitGroundDirectionFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStHitSceneItemPerformDesc[{key62}].HitGroundDecalPath", value62.HitGroundDecalPath));
			TableContentList.Add(new Tuple<string, string>($"FUStHitSceneItemPerformDesc[{key62}].HitWorldItemAKPath", value62.HitWorldItemAKPath));
		}
		foreach (KeyValuePair<int, FUStUnitFootstepDesc> item80 in BG_ProtobufDataAPI<FUStUnitFootstepDesc>.Get().GetAll())
		{
			FUStUnitFootstepDesc value63 = item80.Value;
			int key63 = item80.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].WalkLeftFootFXPath", value63.WalkLeftFootFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].WalkRightFootFXPath", value63.WalkRightFootFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].RunLeftFootFXPath", value63.RunLeftFootFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].RunRightFootFXPath", value63.RunRightFootFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].SprintLeftFootFXPath", value63.SprintLeftFootFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].SprintRightFootFXPath", value63.SprintRightFootFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].LeftFootDecalDBC", value63.LeftFootDecalDBC));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].RightFootDecalDBC", value63.RightFootDecalDBC));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].LittleFallLandFXPath", value63.LittleFallLandFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].MiddleFallLandFXPath", value63.MiddleFallLandFXPath));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitFootstepDesc[{key63}].HighFallLandFXPath", value63.HighFallLandFXPath));
		}
		foreach (KeyValuePair<int, FUStPassiveSkillDesc> item81 in BG_ProtobufDataAPI<FUStPassiveSkillDesc>.Get().GetAll())
		{
			FUStPassiveSkillDesc value64 = item81.Value;
			int key64 = item81.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPassiveSkillDesc[{key64}].MainID", value64.MainID));
		}
		foreach (KeyValuePair<int, FUStUnitAudioBankMapDesc> item82 in BG_ProtobufDataAPI<FUStUnitAudioBankMapDesc>.Get().GetAll())
		{
			FUStUnitAudioBankMapDesc value65 = item82.Value;
			int key65 = item82.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitAudioBankMapDesc[{key65}].BaseAudioBankName", value65.BaseAudioBankName));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitAudioBankMapDesc[{key65}].BaseAudioBankPath", value65.BaseAudioBankPath));
		}
		foreach (KeyValuePair<int, FUStMobLevelMappingDesc> item83 in BG_ProtobufDataAPI<FUStMobLevelMappingDesc>.Get().GetAll())
		{
			FUStMobLevelMappingDesc value66 = item83.Value;
			int key66 = item83.Key;
			for (int num15 = 0; num15 < value66.MobLibAssetPath.Count; num15++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStMobLevelMappingDesc[{key66}].MobLibAssetPath[{num15}]", value66.MobLibAssetPath[num15]));
			}
		}
		foreach (KeyValuePair<int, FUStEliteBuffConfigDesc> item84 in BG_ProtobufDataAPI<FUStEliteBuffConfigDesc>.Get().GetAll())
		{
			_ = item84.Value;
			_ = item84.Key;
		}
		foreach (KeyValuePair<int, FUStMapMobConfigDesc> item85 in BG_ProtobufDataAPI<FUStMapMobConfigDesc>.Get().GetAll())
		{
			_ = item85.Value;
			_ = item85.Key;
		}
		foreach (KeyValuePair<int, FUStUnitSpecialMoveDesc> item86 in BG_ProtobufDataAPI<FUStUnitSpecialMoveDesc>.Get().GetAll())
		{
			_ = item86.Value;
			_ = item86.Key;
		}
		foreach (KeyValuePair<int, FUStUnitTransStageDesc> item87 in BG_ProtobufDataAPI<FUStUnitTransStageDesc>.Get().GetAll())
		{
			_ = item87.Value;
			_ = item87.Key;
		}
		foreach (KeyValuePair<int, FUStSkillsRefCheckWhiteListDesc> item88 in BG_ProtobufDataAPI<FUStSkillsRefCheckWhiteListDesc>.Get().GetAll())
		{
			_ = item88.Value;
			_ = item88.Key;
		}
		foreach (KeyValuePair<int, FUStBuffTickRuleBySimpleStateDesc> item89 in BG_ProtobufDataAPI<FUStBuffTickRuleBySimpleStateDesc>.Get().GetAll())
		{
			_ = item89.Value;
			_ = item89.Key;
		}
		foreach (KeyValuePair<int, FUStUnitPhysicalAnimationDesc> item90 in BG_ProtobufDataAPI<FUStUnitPhysicalAnimationDesc>.Get().GetAll())
		{
			FUStUnitPhysicalAnimationDesc value67 = item90.Value;
			int key67 = item90.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUnitPhysicalAnimationDesc[{key67}].NormalPhysAnimDataAsset", value67.NormalPhysAnimDataAsset));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitPhysicalAnimationDesc[{key67}].BeCatchThrowPhysAnimDataAsset", value67.BeCatchThrowPhysAnimDataAsset));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitPhysicalAnimationDesc[{key67}].PhysMoveAnimDataAsset", value67.PhysMoveAnimDataAsset));
			TableContentList.Add(new Tuple<string, string>($"FUStUnitPhysicalAnimationDesc[{key67}].Guard", value67.Guard));
		}
		foreach (KeyValuePair<int, FUStMovieSequenceDesc> item91 in BG_ProtobufDataAPI<FUStMovieSequenceDesc>.Get().GetAll())
		{
			FUStMovieSequenceDesc value68 = item91.Value;
			int key68 = item91.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMovieSequenceDesc[{key68}].SeqDesc", value68.SeqDesc));
			TableContentList.Add(new Tuple<string, string>($"FUStMovieSequenceDesc[{key68}].MovieGraphPath", value68.MovieGraphPath));
		}
		foreach (KeyValuePair<int, FUStCameraGroupDesc> item92 in BG_ProtobufDataAPI<FUStCameraGroupDesc>.Get().GetAll())
		{
			_ = item92.Value;
			_ = item92.Key;
		}
		foreach (KeyValuePair<int, FUStGroupAISDesc> item93 in BG_ProtobufDataAPI<FUStGroupAISDesc>.Get().GetAll())
		{
			_ = item93.Value;
			_ = item93.Key;
		}
		foreach (KeyValuePair<int, FUStAssociationUnitInfoSDesc> item94 in BG_ProtobufDataAPI<FUStAssociationUnitInfoSDesc>.Get().GetAll())
		{
			FUStAssociationUnitInfoSDesc value69 = item94.Value;
			int key69 = item94.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAssociationUnitInfoSDesc[{key69}].UnitResBPPath", value69.UnitResBPPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAssociationUnitInfoSDesc[{key69}].BTPath", value69.BTPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAssociationUnitInfoSDesc[{key69}].SpawnEQSPath", value69.SpawnEQSPath));
			TableContentList.Add(new Tuple<string, string>($"FUStAssociationUnitInfoSDesc[{key69}].SpawnSceneItemTagName", value69.SpawnSceneItemTagName));
		}
		foreach (KeyValuePair<int, FUStUnitIntelligenceInfoDesc> item95 in BG_ProtobufDataAPI<FUStUnitIntelligenceInfoDesc>.Get().GetAll())
		{
			_ = item95.Value;
			_ = item95.Key;
		}
		foreach (KeyValuePair<int, FUStDialogueIDMappingDesc> item96 in BG_ProtobufDataAPI<FUStDialogueIDMappingDesc>.Get().GetAll())
		{
			_ = item96.Value;
			_ = item96.Key;
		}
		foreach (KeyValuePair<int, FUStDialogueDesc> item97 in BG_ProtobufDataAPI<FUStDialogueDesc>.Get().GetAll())
		{
			FUStDialogueDesc value70 = item97.Value;
			int key70 = item97.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStDialogueDesc[{key70}].Name", value70.Name));
			TableContentList.Add(new Tuple<string, string>($"FUStDialogueDesc[{key70}].Content", value70.Content));
			TableContentList.Add(new Tuple<string, string>($"FUStDialogueDesc[{key70}].FacialAnimPath", value70.FacialAnimPath));
		}
		foreach (KeyValuePair<int, FUStUIWordDesc> item98 in BG_ProtobufDataAPI<FUStUIWordDesc>.Get().GetAll())
		{
			FUStUIWordDesc value71 = item98.Value;
			int key71 = item98.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStUIWordDesc[{key71}].EnumName", value71.EnumName));
			TableContentList.Add(new Tuple<string, string>($"FUStUIWordDesc[{key71}].Content", value71.Content));
		}
		foreach (KeyValuePair<int, FUStTalentLvUpCfgDesc> item99 in BG_ProtobufDataAPI<FUStTalentLvUpCfgDesc>.Get().GetAll())
		{
			_ = item99.Value;
			_ = item99.Key;
		}
		foreach (KeyValuePair<int, FUStTalentDisplayDesc> item100 in BG_ProtobufDataAPI<FUStTalentDisplayDesc>.Get().GetAll())
		{
			FUStTalentDisplayDesc value72 = item100.Value;
			int key72 = item100.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStTalentDisplayDesc[{key72}].InputDesc", value72.InputDesc));
			for (int num16 = 0; num16 < value72.DisplayCfg.Count; num16++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStTalentDisplayDesc[{key72}].DisplayCfg[{num16}].Name", value72.DisplayCfg[num16].Name));
			}
			for (int num17 = 0; num17 < value72.DisplayCfg.Count; num17++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStTalentDisplayDesc[{key72}].DisplayCfg[{num17}].EffectDesc", value72.DisplayCfg[num17].EffectDesc));
			}
			for (int num18 = 0; num18 < value72.DisplayCfg.Count; num18++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStTalentDisplayDesc[{key72}].DisplayCfg[{num18}].NextDesc", value72.DisplayCfg[num18].NextDesc));
			}
		}
		foreach (KeyValuePair<int, FUStAiConversationEventDesc> item101 in BG_ProtobufDataAPI<FUStAiConversationEventDesc>.Get().GetAll())
		{
			_ = item101.Value;
			_ = item101.Key;
		}
		foreach (KeyValuePair<int, FUStAiConversationContentDesc> item102 in BG_ProtobufDataAPI<FUStAiConversationContentDesc>.Get().GetAll())
		{
			FUStAiConversationContentDesc value73 = item102.Value;
			int key73 = item102.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].SpeakerFilterParam", value73.SpeakerFilterParam));
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].ForceListenerGuid", value73.ForceListenerGuid));
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].Subtitle", value73.Subtitle));
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].DialogueIDs", value73.DialogueIDs));
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].SubtitleDurTimeMs", value73.SubtitleDurTimeMs));
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].NextConversationIDList", value73.NextConversationIDList));
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].AkEventPath", value73.AkEventPath));
			for (int num19 = 0; num19 < value73.Conditions.Count; num19++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].Conditions[{num19}].TargetTypeParam", value73.Conditions[num19].TargetTypeParam));
			}
			for (int num20 = 0; num20 < value73.Conditions.Count; num20++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].Conditions[{num20}].ConditionValue", value73.Conditions[num20].ConditionValue));
			}
			for (int num21 = 0; num21 < value73.ModifyFacts.Count; num21++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].ModifyFacts[{num21}].KeyName", value73.ModifyFacts[num21].KeyName));
			}
			for (int num22 = 0; num22 < value73.ModifyFacts.Count; num22++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].ModifyFacts[{num22}].ModifyValue", value73.ModifyFacts[num22].ModifyValue));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStAiConversationContentDesc[{key73}].AMPath", value73.AMPath));
		}
		foreach (KeyValuePair<int, FUStRichTextIconDesc> item103 in BG_ProtobufDataAPI<FUStRichTextIconDesc>.Get().GetAll())
		{
			FUStRichTextIconDesc value74 = item103.Value;
			int key74 = item103.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStRichTextIconDesc[{key74}].Name", value74.Name));
			TableContentList.Add(new Tuple<string, string>($"FUStRichTextIconDesc[{key74}].ResourceObject", value74.ResourceObject));
		}
		foreach (KeyValuePair<int, FUStSubtitleDesc> item104 in BG_ProtobufDataAPI<FUStSubtitleDesc>.Get().GetAll())
		{
			FUStSubtitleDesc value75 = item104.Value;
			int key75 = item104.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSubtitleDesc[{key75}].Content", value75.Content));
		}
		foreach (KeyValuePair<int, FUStAiConversationGroupDesc> item105 in BG_ProtobufDataAPI<FUStAiConversationGroupDesc>.Get().GetAll())
		{
			_ = item105.Value;
			_ = item105.Key;
		}
		foreach (KeyValuePair<int, FUStLevelCommDesc> item106 in BG_ProtobufDataAPI<FUStLevelCommDesc>.Get().GetAll())
		{
			FUStLevelCommDesc value76 = item106.Value;
			int key76 = item106.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStLevelCommDesc[{key76}].MapShowName", value76.MapShowName));
			TableContentList.Add(new Tuple<string, string>($"FUStLevelCommDesc[{key76}].MapPath", value76.MapPath));
			TableContentList.Add(new Tuple<string, string>($"FUStLevelCommDesc[{key76}].RootQuestGraphPath", value76.RootQuestGraphPath));
		}
		foreach (KeyValuePair<int, FUStOnlineScreenMsgConfDesc> item107 in BG_ProtobufDataAPI<FUStOnlineScreenMsgConfDesc>.Get().GetAll())
		{
			FUStOnlineScreenMsgConfDesc value77 = item107.Value;
			int key77 = item107.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStOnlineScreenMsgConfDesc[{key77}].TipsWord", value77.TipsWord));
		}
		foreach (KeyValuePair<int, FUStImmobilizeSkillConfigDesc> item108 in BG_ProtobufDataAPI<FUStImmobilizeSkillConfigDesc>.Get().GetAll())
		{
			FUStImmobilizeSkillConfigDesc value78 = item108.Value;
			int key78 = item108.Key;
			for (int num23 = 0; num23 < value78.BeginFXs.Count; num23++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStImmobilizeSkillConfigDesc[{key78}].BeginFXs[{num23}].FXPathByDBC", value78.BeginFXs[num23].FXPathByDBC));
			}
			for (int num24 = 0; num24 < value78.AlmostEndFXs.Count; num24++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStImmobilizeSkillConfigDesc[{key78}].AlmostEndFXs[{num24}].FXPathByDBC", value78.AlmostEndFXs[num24].FXPathByDBC));
			}
			for (int num25 = 0; num25 < value78.EndFXs.Count; num25++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStImmobilizeSkillConfigDesc[{key78}].EndFXs[{num25}].FXPathByDBC", value78.EndFXs[num25].FXPathByDBC));
			}
			for (int num26 = 0; num26 < value78.QuickEndFXs.Count; num26++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStImmobilizeSkillConfigDesc[{key78}].QuickEndFXs[{num26}].FXPathByDBC", value78.QuickEndFXs[num26].FXPathByDBC));
			}
			for (int num27 = 0; num27 < value78.FailedFXs.Count; num27++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStImmobilizeSkillConfigDesc[{key78}].FailedFXs[{num27}].FXPathByDBC", value78.FailedFXs[num27].FXPathByDBC));
			}
			for (int num28 = 0; num28 < value78.BreakingFXs.Count; num28++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStImmobilizeSkillConfigDesc[{key78}].BreakingFXs[{num28}].FXPathByDBC", value78.BreakingFXs[num28].FXPathByDBC));
			}
		}
		foreach (KeyValuePair<int, FUStSealingSpellSkillConfigDesc> item109 in BG_ProtobufDataAPI<FUStSealingSpellSkillConfigDesc>.Get().GetAll())
		{
			_ = item109.Value;
			_ = item109.Key;
		}
		foreach (KeyValuePair<int, FUStTransQiTianDaShengConfigDesc> item110 in BG_ProtobufDataAPI<FUStTransQiTianDaShengConfigDesc>.Get().GetAll())
		{
			_ = item110.Value;
			_ = item110.Key;
		}
		foreach (KeyValuePair<int, FUStAbnormalCommConfigDesc> item111 in BG_ProtobufDataAPI<FUStAbnormalCommConfigDesc>.Get().GetAll())
		{
			_ = item111.Value;
			_ = item111.Key;
		}
		foreach (KeyValuePair<int, FUStPhantomRushSkillConfigDesc> item112 in BG_ProtobufDataAPI<FUStPhantomRushSkillConfigDesc>.Get().GetAll())
		{
			FUStPhantomRushSkillConfigDesc value79 = item112.Value;
			int key79 = item112.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStPhantomRushSkillConfigDesc[{key79}].PhantomRushRelatedSkillConfigPath", value79.PhantomRushRelatedSkillConfigPath));
		}
		foreach (KeyValuePair<int, FUStTaskStageDesc> item113 in BG_ProtobufDataAPI<FUStTaskStageDesc>.Get().GetAll())
		{
			FUStTaskStageDesc value80 = item113.Value;
			int key80 = item113.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStTaskStageDesc[{key80}].Describe", value80.Describe));
			TableContentList.Add(new Tuple<string, string>($"FUStTaskStageDesc[{key80}].FilterSkillID", value80.FilterSkillID));
			TableContentList.Add(new Tuple<string, string>($"FUStTaskStageDesc[{key80}].Guard", value80.Guard));
		}
		foreach (KeyValuePair<int, FUStTaskLineDesc> item114 in BG_ProtobufDataAPI<FUStTaskLineDesc>.Get().GetAll())
		{
			FUStTaskLineDesc value81 = item114.Value;
			int key81 = item114.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStTaskLineDesc[{key81}].TaskGraphAssetPath", value81.TaskGraphAssetPath));
			TableContentList.Add(new Tuple<string, string>($"FUStTaskLineDesc[{key81}].Guard", value81.Guard));
		}
		foreach (KeyValuePair<int, FUStNPCBaseInfoDesc> item115 in BG_ProtobufDataAPI<FUStNPCBaseInfoDesc>.Get().GetAll())
		{
			FUStNPCBaseInfoDesc value82 = item115.Value;
			int key82 = item115.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStNPCBaseInfoDesc[{key82}].AnimInfoDAPath", value82.AnimInfoDAPath));
			TableContentList.Add(new Tuple<string, string>($"FUStNPCBaseInfoDesc[{key82}].Guard", value82.Guard));
		}
		foreach (KeyValuePair<int, FUStSuperArmorLevelDesc> item116 in BG_ProtobufDataAPI<FUStSuperArmorLevelDesc>.Get().GetAll())
		{
			FUStSuperArmorLevelDesc value83 = item116.Value;
			int key83 = item116.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSuperArmorLevelDesc[{key83}].SuperArmorLevelName", value83.SuperArmorLevelName));
		}
		foreach (KeyValuePair<int, FUStCollectionSpawnInfoDesc> item117 in BG_ProtobufDataAPI<FUStCollectionSpawnInfoDesc>.Get().GetAll())
		{
			FUStCollectionSpawnInfoDesc value84 = item117.Value;
			int key84 = item117.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStCollectionSpawnInfoDesc[{key84}].CollectionName", value84.CollectionName));
			TableContentList.Add(new Tuple<string, string>($"FUStCollectionSpawnInfoDesc[{key84}].MapName", value84.MapName));
			TableContentList.Add(new Tuple<string, string>($"FUStCollectionSpawnInfoDesc[{key84}].Guid", value84.Guid));
			TableContentList.Add(new Tuple<string, string>($"FUStCollectionSpawnInfoDesc[{key84}].SubLevel", value84.SubLevel));
		}
		foreach (KeyValuePair<int, FUStCollectionSpawnGroupDesc> item118 in BG_ProtobufDataAPI<FUStCollectionSpawnGroupDesc>.Get().GetAll())
		{
			FUStCollectionSpawnGroupDesc value85 = item118.Value;
			int key85 = item118.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStCollectionSpawnGroupDesc[{key85}].MapName", value85.MapName));
			TableContentList.Add(new Tuple<string, string>($"FUStCollectionSpawnGroupDesc[{key85}].GroupName", value85.GroupName));
		}
		foreach (KeyValuePair<int, FUStCollectionEventProbabilityDesc> item119 in BG_ProtobufDataAPI<FUStCollectionEventProbabilityDesc>.Get().GetAll())
		{
			_ = item119.Value;
			_ = item119.Key;
		}
		foreach (KeyValuePair<int, FUStCustomStateMachineDesc> item120 in BG_ProtobufDataAPI<FUStCustomStateMachineDesc>.Get().GetAll())
		{
			FUStCustomStateMachineDesc value86 = item120.Value;
			int key86 = item120.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStCustomStateMachineDesc[{key86}].GraphPath", value86.GraphPath));
			TableContentList.Add(new Tuple<string, string>($"FUStCustomStateMachineDesc[{key86}].DataAssetPath", value86.DataAssetPath));
		}
		foreach (KeyValuePair<int, FUStGuideAssetConfigDesc> item121 in BG_ProtobufDataAPI<FUStGuideAssetConfigDesc>.Get().GetAll())
		{
			FUStGuideAssetConfigDesc value87 = item121.Value;
			int key87 = item121.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStGuideAssetConfigDesc[{key87}].AssetPath", value87.AssetPath));
		}
		foreach (KeyValuePair<int, FUStPotentialEnergyConfigDesc> item122 in BG_ProtobufDataAPI<FUStPotentialEnergyConfigDesc>.Get().GetAll())
		{
			FUStPotentialEnergyConfigDesc value88 = item122.Value;
			int key88 = item122.Key;
			if (value88.PELevelConfig != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStPotentialEnergyConfigDesc[{key88}].PELevelConfig.DBCDAPath", value88.PELevelConfig.DBCDAPath));
			}
		}
		foreach (KeyValuePair<int, FUStTeamRelationConfigDesc> item123 in BG_ProtobufDataAPI<FUStTeamRelationConfigDesc>.Get().GetAll())
		{
			FUStTeamRelationConfigDesc value89 = item123.Value;
			int key89 = item123.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStTeamRelationConfigDesc[{key89}].AntiRuleTeamIDs", value89.AntiRuleTeamIDs));
			TableContentList.Add(new Tuple<string, string>($"FUStTeamRelationConfigDesc[{key89}].TeamDamageReductionConfig", value89.TeamDamageReductionConfig));
		}
		foreach (KeyValuePair<int, FUStTamerStrategyConfigDesc> item124 in BG_ProtobufDataAPI<FUStTamerStrategyConfigDesc>.Get().GetAll())
		{
			FUStTamerStrategyConfigDesc value90 = item124.Value;
			int key90 = item124.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStTamerStrategyConfigDesc[{key90}].UnitGuid", value90.UnitGuid));
		}
		foreach (KeyValuePair<int, FUStTROStrategyConfigDesc> item125 in BG_ProtobufDataAPI<FUStTROStrategyConfigDesc>.Get().GetAll())
		{
			FUStTROStrategyConfigDesc value91 = item125.Value;
			int key91 = item125.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStTROStrategyConfigDesc[{key91}].UnitGuid", value91.UnitGuid));
		}
		foreach (KeyValuePair<int, FUStMultiPointLockCameraConfigDesc> item126 in BG_ProtobufDataAPI<FUStMultiPointLockCameraConfigDesc>.Get().GetAll())
		{
			FUStMultiPointLockCameraConfigDesc value92 = item126.Value;
			int key92 = item126.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMultiPointLockCameraConfigDesc[{key92}].LockSocket", value92.LockSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStMultiPointLockCameraConfigDesc[{key92}].PelvisSocket", value92.PelvisSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStMultiPointLockCameraConfigDesc[{key92}].RootSocket", value92.RootSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStMultiPointLockCameraConfigDesc[{key92}].SoulFocusSocket", value92.SoulFocusSocket));
			TableContentList.Add(new Tuple<string, string>($"FUStMultiPointLockCameraConfigDesc[{key92}].SoulFocusZSocket", value92.SoulFocusZSocket));
		}
		foreach (KeyValuePair<int, FUStWeakPerformConfigDesc> item127 in BG_ProtobufDataAPI<FUStWeakPerformConfigDesc>.Get().GetAll())
		{
			FUStWeakPerformConfigDesc value93 = item127.Value;
			int key93 = item127.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStWeakPerformConfigDesc[{key93}].LockTargetTag", value93.LockTargetTag));
		}
		foreach (KeyValuePair<int, FUStFollowPartnerConfigDesc> item128 in BG_ProtobufDataAPI<FUStFollowPartnerConfigDesc>.Get().GetAll())
		{
			FUStFollowPartnerConfigDesc value94 = item128.Value;
			int key94 = item128.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStFollowPartnerConfigDesc[{key94}].OverlapBoxGUID", value94.OverlapBoxGUID));
			TableContentList.Add(new Tuple<string, string>($"FUStFollowPartnerConfigDesc[{key94}].FollowPartnerDispDAPath", value94.FollowPartnerDispDAPath));
			TableContentList.Add(new Tuple<string, string>($"FUStFollowPartnerConfigDesc[{key94}].ConfigDAPath", value94.ConfigDAPath));
		}
		foreach (KeyValuePair<int, FUStBossRoomConfigDesc> item129 in BG_ProtobufDataAPI<FUStBossRoomConfigDesc>.Get().GetAll())
		{
			FUStBossRoomConfigDesc value95 = item129.Value;
			int key95 = item129.Key;
			for (int num29 = 0; num29 < value95.BossGuid.Count; num29++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBossRoomConfigDesc[{key95}].BossGuid[{num29}]", value95.BossGuid[num29]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStBossRoomConfigDesc[{key95}].TeleportSceneItemTagName", value95.TeleportSceneItemTagName));
		}
		foreach (KeyValuePair<int, FUStGlobalCannotDeadExtraConfigDesc> item130 in BG_ProtobufDataAPI<FUStGlobalCannotDeadExtraConfigDesc>.Get().GetAll())
		{
			_ = item130.Value;
			_ = item130.Key;
		}
		foreach (KeyValuePair<int, FUStDeadSeqUnitConfigDesc> item131 in BG_ProtobufDataAPI<FUStDeadSeqUnitConfigDesc>.Get().GetAll())
		{
			FUStDeadSeqUnitConfigDesc value96 = item131.Value;
			int key96 = item131.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStDeadSeqUnitConfigDesc[{key96}].UnitGuid", value96.UnitGuid));
		}
		foreach (KeyValuePair<int, FUStStreamingLevelStateDesc> item132 in BG_ProtobufDataAPI<FUStStreamingLevelStateDesc>.Get().GetAll())
		{
			FUStStreamingLevelStateDesc value97 = item132.Value;
			int key97 = item132.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStStreamingLevelStateDesc[{key97}].DataAssetPath", value97.DataAssetPath));
		}
		foreach (KeyValuePair<int, FUStMapSymbolDesc> item133 in BG_ProtobufDataAPI<FUStMapSymbolDesc>.Get().GetAll())
		{
			FUStMapSymbolDesc value98 = item133.Value;
			int key98 = item133.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMapSymbolDesc[{key98}].Guid", value98.Guid));
			TableContentList.Add(new Tuple<string, string>($"FUStMapSymbolDesc[{key98}].Name", value98.Name));
		}
		foreach (KeyValuePair<int, FUStLifeSavingHairConfigDesc> item134 in BG_ProtobufDataAPI<FUStLifeSavingHairConfigDesc>.Get().GetAll())
		{
			FUStLifeSavingHairConfigDesc value99 = item134.Value;
			int key99 = item134.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStLifeSavingHairConfigDesc[{key99}].AMPath", value99.AMPath));
		}
		foreach (KeyValuePair<int, FUStPigsyStoryLibraryDesc> item135 in BG_ProtobufDataAPI<FUStPigsyStoryLibraryDesc>.Get().GetAll())
		{
			_ = item135.Value;
			_ = item135.Key;
		}
		foreach (KeyValuePair<int, FUStPigsyStoryIAndRLibraryDesc> item136 in BG_ProtobufDataAPI<FUStPigsyStoryIAndRLibraryDesc>.Get().GetAll())
		{
			_ = item136.Value;
			_ = item136.Key;
		}
		foreach (KeyValuePair<int, FUStDynamicObstaclePerformanceDesc> item137 in BG_ProtobufDataAPI<FUStDynamicObstaclePerformanceDesc>.Get().GetAll())
		{
			FUStDynamicObstaclePerformanceDesc value100 = item137.Value;
			int key100 = item137.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStDynamicObstaclePerformanceDesc[{key100}].DAPath", value100.DAPath));
		}
		foreach (KeyValuePair<int, FUStDefeatSlowTimeConfigDesc> item138 in BG_ProtobufDataAPI<FUStDefeatSlowTimeConfigDesc>.Get().GetAll())
		{
			FUStDefeatSlowTimeConfigDesc value101 = item138.Value;
			int key101 = item138.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStDefeatSlowTimeConfigDesc[{key101}].UnitDefeatedType", value101.UnitDefeatedType));
			TableContentList.Add(new Tuple<string, string>($"FUStDefeatSlowTimeConfigDesc[{key101}].TimeDilationCurve", value101.TimeDilationCurve));
			TableContentList.Add(new Tuple<string, string>($"FUStDefeatSlowTimeConfigDesc[{key101}].DefeatedSound", value101.DefeatedSound));
		}
		foreach (KeyValuePair<int, FUStBuffDispGroupDesc> item139 in BG_ProtobufDataAPI<FUStBuffDispGroupDesc>.Get().GetAll())
		{
			_ = item139.Value;
			_ = item139.Key;
		}
		foreach (KeyValuePair<int, FUStSoulSkillMimicryDesc> item140 in BG_ProtobufDataAPI<FUStSoulSkillMimicryDesc>.Get().GetAll())
		{
			FUStSoulSkillMimicryDesc value102 = item140.Value;
			int key102 = item140.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSoulSkillMimicryDesc[{key102}].DAPath", value102.DAPath));
		}
		foreach (KeyValuePair<int, FUStCameraConversionParamConfigDesc> item141 in BG_ProtobufDataAPI<FUStCameraConversionParamConfigDesc>.Get().GetAll())
		{
			_ = item141.Value;
			_ = item141.Key;
		}
		foreach (KeyValuePair<int, FUStEffectiveHitProjectileEffectDesc> item142 in BG_ProtobufDataAPI<FUStEffectiveHitProjectileEffectDesc>.Get().GetAll())
		{
			FUStEffectiveHitProjectileEffectDesc value103 = item142.Value;
			int key103 = item142.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStEffectiveHitProjectileEffectDesc[{key103}].Guard", value103.Guard));
		}
		foreach (KeyValuePair<int, FUStMovementOptStrategyConfigDesc> item143 in BG_ProtobufDataAPI<FUStMovementOptStrategyConfigDesc>.Get().GetAll())
		{
			FUStMovementOptStrategyConfigDesc value104 = item143.Value;
			int key104 = item143.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStMovementOptStrategyConfigDesc[{key104}].UnitGuid", value104.UnitGuid));
		}
		foreach (KeyValuePair<int, FUStLevelSequenceClearBattleItemConfigDesc> item144 in BG_ProtobufDataAPI<FUStLevelSequenceClearBattleItemConfigDesc>.Get().GetAll())
		{
			_ = item144.Value;
			_ = item144.Key;
		}
		foreach (KeyValuePair<int, FUStAbnormalDispVictimMapDesc> item145 in BG_ProtobufDataAPI<FUStAbnormalDispVictimMapDesc>.Get().GetAll())
		{
			FUStAbnormalDispVictimMapDesc value105 = item145.Value;
			int key105 = item145.Key;
			if (value105.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Freeze.DBCAccProcess", value105.Freeze.DBCAccProcess));
			}
			if (value105.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Freeze.DBCFinalBegin", value105.Freeze.DBCFinalBegin));
			}
			if (value105.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Freeze.DBCFinalLoop", value105.Freeze.DBCFinalLoop));
			}
			if (value105.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Freeze.DBCHitExt", value105.Freeze.DBCHitExt));
			}
			if (value105.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Freeze.DBCDeadKeep", value105.Freeze.DBCDeadKeep));
			}
			if (value105.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Freeze.DBCDeadDisappear", value105.Freeze.DBCDeadDisappear));
			}
			if (value105.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Burn.DBCAccProcess", value105.Burn.DBCAccProcess));
			}
			if (value105.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Burn.DBCFinalBegin", value105.Burn.DBCFinalBegin));
			}
			if (value105.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Burn.DBCFinalLoop", value105.Burn.DBCFinalLoop));
			}
			if (value105.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Burn.DBCHitExt", value105.Burn.DBCHitExt));
			}
			if (value105.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Burn.DBCDeadKeep", value105.Burn.DBCDeadKeep));
			}
			if (value105.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Burn.DBCDeadDisappear", value105.Burn.DBCDeadDisappear));
			}
			if (value105.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Poison.DBCAccProcess", value105.Poison.DBCAccProcess));
			}
			if (value105.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Poison.DBCFinalBegin", value105.Poison.DBCFinalBegin));
			}
			if (value105.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Poison.DBCFinalLoop", value105.Poison.DBCFinalLoop));
			}
			if (value105.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Poison.DBCHitExt", value105.Poison.DBCHitExt));
			}
			if (value105.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Poison.DBCDeadKeep", value105.Poison.DBCDeadKeep));
			}
			if (value105.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Poison.DBCDeadDisappear", value105.Poison.DBCDeadDisappear));
			}
			if (value105.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Thunder.DBCAccProcess", value105.Thunder.DBCAccProcess));
			}
			if (value105.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Thunder.DBCFinalBegin", value105.Thunder.DBCFinalBegin));
			}
			if (value105.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Thunder.DBCFinalLoop", value105.Thunder.DBCFinalLoop));
			}
			if (value105.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Thunder.DBCHitExt", value105.Thunder.DBCHitExt));
			}
			if (value105.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Thunder.DBCDeadKeep", value105.Thunder.DBCDeadKeep));
			}
			if (value105.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Thunder.DBCDeadDisappear", value105.Thunder.DBCDeadDisappear));
			}
			if (value105.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yin.DBCAccProcess", value105.Yin.DBCAccProcess));
			}
			if (value105.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yin.DBCFinalBegin", value105.Yin.DBCFinalBegin));
			}
			if (value105.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yin.DBCFinalLoop", value105.Yin.DBCFinalLoop));
			}
			if (value105.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yin.DBCHitExt", value105.Yin.DBCHitExt));
			}
			if (value105.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yin.DBCDeadKeep", value105.Yin.DBCDeadKeep));
			}
			if (value105.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yin.DBCDeadDisappear", value105.Yin.DBCDeadDisappear));
			}
			if (value105.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yang.DBCAccProcess", value105.Yang.DBCAccProcess));
			}
			if (value105.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yang.DBCFinalBegin", value105.Yang.DBCFinalBegin));
			}
			if (value105.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yang.DBCFinalLoop", value105.Yang.DBCFinalLoop));
			}
			if (value105.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yang.DBCHitExt", value105.Yang.DBCHitExt));
			}
			if (value105.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yang.DBCDeadKeep", value105.Yang.DBCDeadKeep));
			}
			if (value105.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].Yang.DBCDeadDisappear", value105.Yang.DBCDeadDisappear));
			}
			if (value105.FreezeExt != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].FreezeExt.DBCBroken", value105.FreezeExt.DBCBroken));
			}
			if (value105.FreezeExt != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].FreezeExt.DBCAutoRelease", value105.FreezeExt.DBCAutoRelease));
			}
			if (value105.FreezeExt != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispVictimMapDesc[{key105}].FreezeExt.DBCShakeFreeze", value105.FreezeExt.DBCShakeFreeze));
			}
		}
		foreach (KeyValuePair<int, FUStAbnormalDispAttackerMapDesc> item146 in BG_ProtobufDataAPI<FUStAbnormalDispAttackerMapDesc>.Get().GetAll())
		{
			FUStAbnormalDispAttackerMapDesc value106 = item146.Value;
			int key106 = item146.Key;
			if (value106.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Freeze.DBCAccProcess", value106.Freeze.DBCAccProcess));
			}
			if (value106.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Freeze.DBCFinalBegin", value106.Freeze.DBCFinalBegin));
			}
			if (value106.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Freeze.DBCFinalLoop", value106.Freeze.DBCFinalLoop));
			}
			if (value106.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Freeze.DBCHitExt", value106.Freeze.DBCHitExt));
			}
			if (value106.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Freeze.DBCDeadKeep", value106.Freeze.DBCDeadKeep));
			}
			if (value106.Freeze != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Freeze.DBCDeadDisappear", value106.Freeze.DBCDeadDisappear));
			}
			if (value106.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Burn.DBCAccProcess", value106.Burn.DBCAccProcess));
			}
			if (value106.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Burn.DBCFinalBegin", value106.Burn.DBCFinalBegin));
			}
			if (value106.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Burn.DBCFinalLoop", value106.Burn.DBCFinalLoop));
			}
			if (value106.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Burn.DBCHitExt", value106.Burn.DBCHitExt));
			}
			if (value106.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Burn.DBCDeadKeep", value106.Burn.DBCDeadKeep));
			}
			if (value106.Burn != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Burn.DBCDeadDisappear", value106.Burn.DBCDeadDisappear));
			}
			if (value106.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Poison.DBCAccProcess", value106.Poison.DBCAccProcess));
			}
			if (value106.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Poison.DBCFinalBegin", value106.Poison.DBCFinalBegin));
			}
			if (value106.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Poison.DBCFinalLoop", value106.Poison.DBCFinalLoop));
			}
			if (value106.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Poison.DBCHitExt", value106.Poison.DBCHitExt));
			}
			if (value106.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Poison.DBCDeadKeep", value106.Poison.DBCDeadKeep));
			}
			if (value106.Poison != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Poison.DBCDeadDisappear", value106.Poison.DBCDeadDisappear));
			}
			if (value106.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Thunder.DBCAccProcess", value106.Thunder.DBCAccProcess));
			}
			if (value106.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Thunder.DBCFinalBegin", value106.Thunder.DBCFinalBegin));
			}
			if (value106.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Thunder.DBCFinalLoop", value106.Thunder.DBCFinalLoop));
			}
			if (value106.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Thunder.DBCHitExt", value106.Thunder.DBCHitExt));
			}
			if (value106.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Thunder.DBCDeadKeep", value106.Thunder.DBCDeadKeep));
			}
			if (value106.Thunder != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Thunder.DBCDeadDisappear", value106.Thunder.DBCDeadDisappear));
			}
			if (value106.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yin.DBCAccProcess", value106.Yin.DBCAccProcess));
			}
			if (value106.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yin.DBCFinalBegin", value106.Yin.DBCFinalBegin));
			}
			if (value106.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yin.DBCFinalLoop", value106.Yin.DBCFinalLoop));
			}
			if (value106.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yin.DBCHitExt", value106.Yin.DBCHitExt));
			}
			if (value106.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yin.DBCDeadKeep", value106.Yin.DBCDeadKeep));
			}
			if (value106.Yin != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yin.DBCDeadDisappear", value106.Yin.DBCDeadDisappear));
			}
			if (value106.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yang.DBCAccProcess", value106.Yang.DBCAccProcess));
			}
			if (value106.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yang.DBCFinalBegin", value106.Yang.DBCFinalBegin));
			}
			if (value106.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yang.DBCFinalLoop", value106.Yang.DBCFinalLoop));
			}
			if (value106.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yang.DBCHitExt", value106.Yang.DBCHitExt));
			}
			if (value106.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yang.DBCDeadKeep", value106.Yang.DBCDeadKeep));
			}
			if (value106.Yang != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].Yang.DBCDeadDisappear", value106.Yang.DBCDeadDisappear));
			}
			if (value106.FreezeExt != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].FreezeExt.DBCBroken", value106.FreezeExt.DBCBroken));
			}
			if (value106.FreezeExt != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].FreezeExt.DBCAutoRelease", value106.FreezeExt.DBCAutoRelease));
			}
			if (value106.FreezeExt != null)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStAbnormalDispAttackerMapDesc[{key106}].FreezeExt.DBCShakeFreeze", value106.FreezeExt.DBCShakeFreeze));
			}
		}
		foreach (KeyValuePair<int, FUStAICrowdDetourLevelConfigDesc> item147 in BG_ProtobufDataAPI<FUStAICrowdDetourLevelConfigDesc>.Get().GetAll())
		{
			_ = item147.Value;
			_ = item147.Key;
		}
		foreach (KeyValuePair<int, FUStSeqAudioJumpLengthDesc> item148 in BG_ProtobufDataAPI<FUStSeqAudioJumpLengthDesc>.Get().GetAll())
		{
			FUStSeqAudioJumpLengthDesc value107 = item148.Value;
			int key107 = item148.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStSeqAudioJumpLengthDesc[{key107}].EventName", value107.EventName));
		}
		foreach (KeyValuePair<int, FUStBossRushConfigDesc> item149 in BG_ProtobufDataAPI<FUStBossRushConfigDesc>.Get().GetAll())
		{
			FUStBossRushConfigDesc value108 = item149.Value;
			int key108 = item149.Key;
			TableContentList.Add(new Tuple<string, string>($"FUStBossRushConfigDesc[{key108}].GraphPath", value108.GraphPath));
			TableContentList.Add(new Tuple<string, string>($"FUStBossRushConfigDesc[{key108}].LevelName", value108.LevelName));
			for (int num30 = 0; num30 < value108.TamerPath.Count; num30++)
			{
				TableContentList.Add(new Tuple<string, string>($"FUStBossRushConfigDesc[{key108}].TamerPath[{num30}]", value108.TamerPath[num30]));
			}
			TableContentList.Add(new Tuple<string, string>($"FUStBossRushConfigDesc[{key108}].UnitDefeatType", value108.UnitDefeatType));
			TableContentList.Add(new Tuple<string, string>($"FUStBossRushConfigDesc[{key108}].DefeatedSound", value108.DefeatedSound));
			TableContentList.Add(new Tuple<string, string>($"FUStBossRushConfigDesc[{key108}].TimeDilationCurve", value108.TimeDilationCurve));
		}
		foreach (KeyValuePair<int, FUStBossRushAbilityLimitDesc> item150 in BG_ProtobufDataAPI<FUStBossRushAbilityLimitDesc>.Get().GetAll())
		{
			_ = item150.Value;
			_ = item150.Key;
		}
	}
}
