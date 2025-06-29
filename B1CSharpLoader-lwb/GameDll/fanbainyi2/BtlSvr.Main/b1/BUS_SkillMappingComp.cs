using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SkillMappingComp : UActorCompBaseCS
{
	private struct MappingSkillInfo
	{
		public int SkillID;

		public string MontagePath;

		public string SectionName;

		public MappingSkillInfo(int _SkillID, string _MontagePath, string _SectionName)
		{
			SkillID = _SkillID;
			MontagePath = _MontagePath;
			SectionName = _SectionName;
		}
	}

	private BUC_SkillMappingData SkillMappingData;

	private IBUC_TalentData TalentData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_EnvironmentInteractionMgrData EnvironmentInteractionMgrData;

	private IBUC_PreciseDodgeData PreciseDodgeData;

	private IBUC_BuffData BuffData;

	private List<int> MarkedHasMappedSkillIDList = new List<int>();

	private List<MappingSkillInfo> MappedSkillInfoList = new List<MappingSkillInfo>();

	public override void OnAttach()
	{
		SkillMappingData = RequireWritableData<BUC_SkillMappingData>();
		TalentData = RequireReadOnlyData<IBUC_TalentData, BUC_TalentData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		EnvironmentInteractionMgrData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		PreciseDodgeData = RequireReadOnlyData<IBUC_PreciseDodgeData, BUC_PreciseDodgeData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		base.BUSEventCollection.Evt_OnSkillMappingStart += new Del_OnSkillMappingStart(OnSkillMappingStart);
		base.BUSEventCollection.Evt_SetIgnoredMappingTypeMap += new Del_SetIgnoredMappingTypeMap(OnSetIgnoredMappingTypeMap);
	}

	private void OnSetIgnoredMappingTypeMap(in Dictionary<ESkillMappingConditionType, bool> IgnorESkillMappingConditionTypeMap)
	{
		foreach (KeyValuePair<ESkillMappingConditionType, bool> item in IgnorESkillMappingConditionTypeMap)
		{
			SkillMappingData.IgnoredMappingTypeMap[item.Key] = item.Value;
		}
	}

	private bool CheckIgnoredSkillMappingType(ESkillMappingConditionType SkillMappingType)
	{
		if (SkillMappingData.IgnoredMappingTypeMap.TryGetValue(SkillMappingType, out var value))
		{
			return !value;
		}
		return true;
	}

	private void OnSkillMappingStart(int OriginSkillID, ESkillDirection SkillDirection = ESkillDirection.None)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		int skillID = OriginSkillID;
		SkillMappingData.UpdateInstsList(OriginSkillID);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, "<character>" + Owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>==================================技能映射开始==================================</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>原始的技能ID是：</><effect>{OriginSkillID}</>");
		}
		MarkedHasMappedSkillIDList.Clear();
		for (int i = 1; i <= 3; i++)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>开始第</><effect>{i}</><action>轮映射，清空筛选池</>");
			}
			bool flag = false;
			int num = -1;
			string text = "";
			FUStSkillSMappingDesc skillSMappingDesc = BGW_GameDB.GetSkillSMappingDesc(skillID);
			if (skillSMappingDesc != null)
			{
				flag = skillSMappingDesc.CanCyclicMapping == EGSYesNo.Yes;
				MarkedHasMappedSkillIDList.Add(OriginSkillID);
				MappedSkillInfoList.Clear();
				foreach (SkillMappingConfig mappingConfig in skillSMappingDesc.MappingConfigList)
				{
					SkillMappingConfig MappingConfig = mappingConfig;
					if (!CheckIgnoredSkillMappingType(MappingConfig.SkillMappingConditionType))
					{
						continue;
					}
					switch (MappingConfig.SkillMappingConditionType)
					{
					case ESkillMappingConditionType.Any:
						AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, 0, in MappingConfig, "");
						break;
					case ESkillMappingConditionType.Buff:
						if (FilterByBuff(MappingConfig))
						{
							AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, 0, in MappingConfig, "<action>，拥有BuffID：</><effect>" + string.Join(",", MappingConfig.IntParams.ToList()) + "</>");
						}
						break;
					case ESkillMappingConditionType.SurfaceType:
						if (MappingConfig.IntParams.Count >= 1 && MappingConfig.FloatParams.Count >= 1 && FilterBySurfaceType(MappingConfig))
						{
							AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, 0, in MappingConfig, $"<action>，处于SurfaceType：</><effect>{(ESceneItemSurfaceType)MappingConfig.IntParams[0]}</>");
						}
						break;
					case ESkillMappingConditionType.InAttackWarning:
						if (PreciseDodgeData.InPreciseDodgeWindow())
						{
							AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, 0, in MappingConfig, "<action>，处于AttackWarning中</>");
						}
						break;
					case ESkillMappingConditionType.SkillDirection:
					{
						int num5 = (int)(SkillDirection - 1);
						if (SkillDirection == ESkillDirection.None)
						{
							num5 = 2;
						}
						AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, num5, in MappingConfig, $"<action>，SkillDirection为：</><effect>{SkillDirection}</><action>，选择SkillInfo的Index为：</><effect>{num5}</>");
						break;
					}
					case ESkillMappingConditionType.Attr:
						if (MappingConfig.FloatParams.Count >= 1 && MappingConfig.IntParams.Count >= 3)
						{
							bool num9 = MappingConfig.IntParams[1] == 1;
							int num10 = MappingConfig.IntParams[2];
							float num11 = MappingConfig.FloatParams[0];
							float num12 = BGUFunctionLibraryCS.BGUGetFloatAttr(owner, (EBGUAttrFloat)num10);
							bool num13 = (num9 ? (num12 < num11) : (num12 >= num11));
							int chooseIdx2 = 1;
							if (num13)
							{
								chooseIdx2 = 0;
							}
							AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, chooseIdx2, in MappingConfig, "");
						}
						break;
					case ESkillMappingConditionType.Talent:
						if (MappingConfig.IntParams.Count >= 1)
						{
							int talentID = MappingConfig.IntParams[0];
							int talentLevel = TalentData.GetTalentLevel(talentID);
							int chooseIdx3 = ((MappingConfig.SkillIDs.Count > talentLevel || MappingConfig.MontagePaths.Count > talentLevel) ? talentLevel : 0);
							AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, chooseIdx3, in MappingConfig, "");
						}
						break;
					case ESkillMappingConditionType.AttrInterval:
					{
						if (MappingConfig.FloatParams.Count < 3 || MappingConfig.IntParams.Count < 1)
						{
							break;
						}
						int num6 = MappingConfig.IntParams[0];
						float num7 = BGUFunctionLibraryCS.BGUGetFloatAttr(owner, (EBGUAttrFloat)num6);
						int chooseIdx = 0;
						for (int j = 0; j < 3; j++)
						{
							if (num7 < MappingConfig.FloatParams[0])
							{
								chooseIdx = 0;
								break;
							}
							if (num7 >= MappingConfig.FloatParams[j])
							{
								chooseIdx = j + 1;
							}
						}
						AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, chooseIdx, in MappingConfig, "");
						break;
					}
					case ESkillMappingConditionType.TargetDistanceFar:
					{
						if (MappingConfig.IntParams.Count < 1)
						{
							break;
						}
						int num8 = MappingConfig.IntParams[0];
						UnitLockTargetInfo TargetInfo = TargetInfoData.GetTargetInfo();
						if (!TargetInfo.IsValidManualTargetInfo())
						{
							break;
						}
						BGUCharacterCS bGUCharacterCS = TargetInfo.LockTargetActor as BGUCharacterCS;
						FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
						switch (TargetInfo.LockTargetType)
						{
						case ELockTargetType.SceneComp:
						{
							v = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, new List<string> { TargetInfo.LockTargetSceneCompName }, out var _);
							break;
						}
						case ELockTargetType.SkeletonSocket:
							if (bGUCharacterCS != null && bGUCharacterCS.Mesh != null)
							{
								v = bGUCharacterCS.Mesh.GetSocketLocation(new FName(TargetInfo.LockTargetSkeletonSocketName));
							}
							break;
						}
						if (FVector.Dist2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner), v) >= (float)num8)
						{
							AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, 0, in MappingConfig, "");
						}
						break;
					}
					case ESkillMappingConditionType.CeilingHeight:
						if (MappingConfig.FloatParams.Count >= 1 && MappingConfig.IntParams.Count >= 1)
						{
							bool num2 = MappingConfig.IntParams[0] == 1;
							float num3 = MappingConfig.FloatParams[0];
							float num4 = BGUFunctionLibraryCS.CheckCurCeilingHeight(OwnerAsCharacterCS);
							if (num2 ? (num4 < num3) : (num4 >= num3))
							{
								AddMappedSkillInfo(MappingConfig.SkillMappingConditionType, 0, in MappingConfig, "");
							}
						}
						break;
					}
				}
				if (MappedSkillInfoList.Count > 0)
				{
					switch (skillSMappingDesc.ResultRull)
					{
					case ESkillMappingResultRull.First:
						num = MappedSkillInfoList[0].SkillID;
						text = MappedSkillInfoList[0].MontagePath;
						SkillMappingData.SetResultSkillIDAndMontagePath(OriginSkillID, num, text);
						break;
					case ESkillMappingResultRull.Latest:
					{
						int index = MappedSkillInfoList.Count - 1;
						num = MappedSkillInfoList[index].SkillID;
						text = MappedSkillInfoList[index].MontagePath;
						SkillMappingData.SetResultSkillIDAndMontagePath(OriginSkillID, num, text);
						break;
					}
					case ESkillMappingResultRull.PseudoRandom:
					{
						int randomNumberInt = UB1Util.GetRandomNumberInt(0, MappedSkillInfoList.Count - 1);
						num = MappedSkillInfoList[randomNumberInt].SkillID;
						text = MappedSkillInfoList[randomNumberInt].MontagePath;
						SkillMappingData.SetResultSkillIDAndMontagePath(OriginSkillID, num, text);
						break;
					}
					}
				}
			}
			if (num <= 0)
			{
				num = OriginSkillID;
				SkillMappingData.SetResultSkillIDAndMontagePath(OriginSkillID, num, text);
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>本轮映射结束，最终映射的技能ID：</><effect>{num}</><action>，最终映射的MontagePath：</><effect>{text}</>");
			}
			if (!flag || MarkedHasMappedSkillIDList.Contains(num))
			{
				break;
			}
			skillID = num;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			int curResultSkillID = SkillMappingData.GetCurResultSkillID(OriginSkillID);
			string curResultMontagePath = SkillMappingData.GetCurResultMontagePath(OriginSkillID);
			curResultSkillID = ((curResultSkillID > 0) ? curResultSkillID : OriginSkillID);
			curResultMontagePath = ((!curResultMontagePath.Equals("")) ? curResultMontagePath : $"{curResultSkillID} 技能Montage路径");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>最后映射结果，映射成技能ID：</><effect>{curResultSkillID}</><action>，映射成Montage路径：</><effect>{curResultMontagePath}</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, "<character>" + Owner.GetName().ConvertLongGuid2DisplayGuid() + "</><action>==================================技能映射结束==================================</>");
		}
	}

	private void AddMappedSkillInfo(ESkillMappingConditionType SkillMappingConditionType, int ChooseIdx, in SkillMappingConfig MappingConfig, in string BattleInfoLog = "")
	{
		int validSkillID = GetValidSkillID(ChooseIdx, in MappingConfig);
		string validMontagePath = GetValidMontagePath(ChooseIdx, in MappingConfig);
		string validSectionName = GetValidSectionName(ChooseIdx, in MappingConfig);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>条件满足：</><effect>{SkillMappingConditionType}</>{BattleInfoLog}");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.SkillMapping, $"<character>{Owner.GetName().ConvertLongGuid2DisplayGuid()}</><action>技能ID：</><effect>{validSkillID}</><action>，MontagePath：</><effect>{validMontagePath}</><action>，SectionName：</><effect>{validSectionName}</><action>进入筛选池</>");
		}
		MappedSkillInfoList.Add(new MappingSkillInfo(validSkillID, validMontagePath, validSectionName));
	}

	private int GetValidSkillID(int ChooseIdx, in SkillMappingConfig MappingConfig)
	{
		if (MappingConfig != null && MappingConfig.SkillIDs.Count > ChooseIdx)
		{
			return MappingConfig.SkillIDs[ChooseIdx];
		}
		return 0;
	}

	private string GetValidMontagePath(int ChooseIdx, in SkillMappingConfig MappingConfig)
	{
		if (MappingConfig != null && MappingConfig.MontagePaths.Count > ChooseIdx)
		{
			return MappingConfig.MontagePaths[ChooseIdx];
		}
		return "";
	}

	private string GetValidSectionName(int ChooseIdx, in SkillMappingConfig MappingConfig)
	{
		if (MappingConfig != null && MappingConfig.SectionNameList.Count > ChooseIdx)
		{
			return MappingConfig.SectionNameList[ChooseIdx];
		}
		return "";
	}

	private bool FilterByBuff(SkillMappingConfig MappedSkill)
	{
		foreach (int intParam in MappedSkill.IntParams)
		{
			if (!BuffData.HasBuff(intParam))
			{
				return false;
			}
		}
		return true;
	}

	private bool FilterBySurfaceType(SkillMappingConfig MappedSkill)
	{
		if (MappedSkill.IntParams.Count >= 1)
		{
			bool p = MappedSkill.IntParams[0] == 0;
			float p2 = MappedSkill.FloatParams[0];
			base.BUSEventCollection.Evt_SamplePointSurfaceType.Invoke(p2, p);
			return (uint)EnvironmentInteractionMgrData.SamplePointResultSurfaceType == (byte)MappedSkill.IntParams[0];
		}
		return false;
	}
}
