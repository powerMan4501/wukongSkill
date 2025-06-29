using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.BGU.BUAnim;
using BtlB1;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UClass]
[USharpPath("/Script/b1-Managed.QATamerDescriber")]
public class QATamerDescriber : UBlueprintFunctionLibrary
{
	private static readonly List<string> SolvedNotify;

	private static List<int> SolvedBullet;

	private static List<int> SolvedBuff;

	private static List<string> CBGCombos;

	private static Dictionary<int, int> CBGSkills;

	private static bool QADescribeBT_IsValid;

	private static IntPtr QADescribeBT_FunctionAddress;

	private static int QADescribeBT_ParamsSize;

	private static bool QADescribeBT_BT_IsValid;

	private static int QADescribeBT_BT_Offset;

	private static bool QADescribeBT_ReturnValue_IsValid;

	private static int QADescribeBT_ReturnValue_Offset;

	private static FFieldAddress QADescribeBT_ReturnValue_PropertyAddress;

	private static bool QADescribeISO_IsValid;

	private static IntPtr QADescribeISO_FunctionAddress;

	private static int QADescribeISO_ParamsSize;

	private static bool QADescribeISO_TM_IsValid;

	private static int QADescribeISO_TM_Offset;

	private static bool QADescribeISO_ReturnValue_IsValid;

	private static int QADescribeISO_ReturnValue_Offset;

	private static FFieldAddress QADescribeISO_ReturnValue_PropertyAddress;

	private static bool QADescribeArt_IsValid;

	private static IntPtr QADescribeArt_FunctionAddress;

	private static int QADescribeArt_ParamsSize;

	private static bool QADescribeArt_TM_IsValid;

	private static int QADescribeArt_TM_Offset;

	private static bool QADescribeArt_ReturnValue_IsValid;

	private static int QADescribeArt_ReturnValue_Offset;

	private static FFieldAddress QADescribeArt_ReturnValue_PropertyAddress;

	private static bool QADescribeDeath_IsValid;

	private static IntPtr QADescribeDeath_FunctionAddress;

	private static int QADescribeDeath_ParamsSize;

	private static bool QADescribeDeath_TM_IsValid;

	private static int QADescribeDeath_TM_Offset;

	private static bool QADescribeDeath_ReturnValue_IsValid;

	private static int QADescribeDeath_ReturnValue_Offset;

	private static FFieldAddress QADescribeDeath_ReturnValue_PropertyAddress;

	private static bool QADescribeSkill_IsValid;

	private static IntPtr QADescribeSkill_FunctionAddress;

	private static int QADescribeSkill_ParamsSize;

	private static bool QADescribeSkill_TM_IsValid;

	private static int QADescribeSkill_TM_Offset;

	private static bool QADescribeSkill_ReturnValue_IsValid;

	private static int QADescribeSkill_ReturnValue_Offset;

	private static FFieldAddress QADescribeSkill_ReturnValue_PropertyAddress;

	private static bool QADescribeBattle_IsValid;

	private static IntPtr QADescribeBattle_FunctionAddress;

	private static int QADescribeBattle_ParamsSize;

	private static bool QADescribeBattle_TM_IsValid;

	private static int QADescribeBattle_TM_Offset;

	private static bool QADescribeBattle_ReturnValue_IsValid;

	private static int QADescribeBattle_ReturnValue_Offset;

	private static FFieldAddress QADescribeBattle_ReturnValue_PropertyAddress;

	private static bool QAGetBTTaskNodes_IsValid;

	private static IntPtr QAGetBTTaskNodes_FunctionAddress;

	private static int QAGetBTTaskNodes_ParamsSize;

	private static bool QAGetBTTaskNodes_BT_IsValid;

	private static int QAGetBTTaskNodes_BT_Offset;

	private static bool QAGetBTTaskNodes_ReturnValue_IsValid;

	private static int QAGetBTTaskNodes_ReturnValue_Offset;

	private static FFieldAddress QAGetBTTaskNodes_ReturnValue_PropertyAddress;

	private static bool QADescribeCounter_IsValid;

	private static IntPtr QADescribeCounter_FunctionAddress;

	private static int QADescribeCounter_ParamsSize;

	private static bool QADescribeCounter_TM_IsValid;

	private static int QADescribeCounter_TM_Offset;

	private static bool QADescribeCounter_ReturnValue_IsValid;

	private static int QADescribeCounter_ReturnValue_Offset;

	private static FFieldAddress QADescribeCounter_ReturnValue_PropertyAddress;

	private static bool QADescribeBeAttacked_IsValid;

	private static IntPtr QADescribeBeAttacked_FunctionAddress;

	private static int QADescribeBeAttacked_ParamsSize;

	private static bool QADescribeBeAttacked_TM_IsValid;

	private static int QADescribeBeAttacked_TM_Offset;

	private static bool QADescribeBeAttacked_ReturnValue_IsValid;

	private static int QADescribeBeAttacked_ReturnValue_Offset;

	private static FFieldAddress QADescribeBeAttacked_ReturnValue_PropertyAddress;

	private static bool QADescribeEngagement_IsValid;

	private static IntPtr QADescribeEngagement_FunctionAddress;

	private static int QADescribeEngagement_ParamsSize;

	private static bool QADescribeEngagement_TM_IsValid;

	private static int QADescribeEngagement_TM_Offset;

	private static bool QADescribeEngagement_ReturnValue_IsValid;

	private static int QADescribeEngagement_ReturnValue_Offset;

	private static FFieldAddress QADescribeEngagement_ReturnValue_PropertyAddress;

	private static bool QADescribeBattleArena_IsValid;

	private static IntPtr QADescribeBattleArena_FunctionAddress;

	private static int QADescribeBattleArena_ParamsSize;

	private static bool QADescribeBattleArena_TM_IsValid;

	private static int QADescribeBattleArena_TM_Offset;

	private static bool QADescribeBattleArena_ReturnValue_IsValid;

	private static int QADescribeBattleArena_ReturnValue_Offset;

	private static FFieldAddress QADescribeBattleArena_ReturnValue_PropertyAddress;

	private static bool QADescribeAnimByMontage_IsValid;

	private static IntPtr QADescribeAnimByMontage_FunctionAddress;

	private static int QADescribeAnimByMontage_ParamsSize;

	private static bool QADescribeAnimByMontage_Montage_IsValid;

	private static int QADescribeAnimByMontage_Montage_Offset;

	private static bool QADescribeAnimByMontage_ReturnValue_IsValid;

	private static int QADescribeAnimByMontage_ReturnValue_Offset;

	private static FFieldAddress QADescribeAnimByMontage_ReturnValue_PropertyAddress;

	private static bool QADescribeAnimBySkillID_IsValid;

	private static IntPtr QADescribeAnimBySkillID_FunctionAddress;

	private static int QADescribeAnimBySkillID_ParamsSize;

	private static bool QADescribeAnimBySkillID_SkillID_IsValid;

	private static int QADescribeAnimBySkillID_SkillID_Offset;

	private static bool QADescribeAnimBySkillID_ReturnValue_IsValid;

	private static int QADescribeAnimBySkillID_ReturnValue_Offset;

	private static FFieldAddress QADescribeAnimBySkillID_ReturnValue_PropertyAddress;

	[BlueprintCallable]
	[Category("QA|AutoTest")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QAGetBTTaskNodes")]
	private static FBehaviorTreeNodeData QAGetBTTaskNodes(UBehaviorTree BT)
	{
		FBehaviorTreeNodeData NodeData = new FBehaviorTreeNodeData
		{
			TaskNodeList = new List<UBTTaskNode>()
		};
		UGSE_BehaviorTreeFuncLib.GetBTTaskNodes(BT, out NodeData);
		return NodeData;
	}

	private static T QAGetNodeCustomData<T>(FCalliopeNode Node) where T : IMessage, new()
	{
		T val = new T();
		if (Node.NodeData != null)
		{
			val.MergeFrom(Node.NodeData);
		}
		return val;
	}

	public static string GetEnumDisplayName(Enum value)
	{
		object[] customAttributes = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(UMetaAttribute), inherit: false);
		for (int i = 0; i < customAttributes.Length; i++)
		{
			UMetaAttribute uMetaAttribute = (UMetaAttribute)customAttributes[i];
			if (uMetaAttribute.Key == MD.DisplayName.ToString() || uMetaAttribute.Key == MD.ToolTip.ToString())
			{
				return uMetaAttribute.Value;
			}
		}
		return value.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeArt")]
	public static string QADescribeArt(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【001-美术表现】");
		USkeletalMeshComponent uSkeletalMeshComponent = (TM.GetMonsterClass().GetDefaultObject() as BGUCharacterCS)?.Mesh;
		if (uSkeletalMeshComponent != null)
		{
			BUAnimInstanceBase bUAnimInstanceBase = uSkeletalMeshComponent.AnimClass.GetDefaultObject() as BUAnimInstanceBase;
			int resID = TM.ConfigInfoComp.UnitCDesc.ResID;
			BGW_GameDB.GetUnitBattleInfoExtendDesc((TM.ConfigInfoComp.UnitCDesc.OverrideID == 0) ? BGW_GameDB.GetUnitCommDesc(resID).DefaultBattleInfoExtendID : TM.ConfigInfoComp.UnitCDesc.OverrideID);
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【移动】怪物待机动画能正常循环");
			if (bUAnimInstanceBase != null && bUAnimInstanceBase.GetIdleAnimationAsset() != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "Idle动画：" + bUAnimInstanceBase.GetIdleAnimationAsset().GetName());
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "这大概不是一个人形怪，请手动查看其Idle动画");
			}
			if (TM.ExtendConfigComp.PatrolType == EPatrolType.Leisure)
			{
				if (TM.ExtendConfigComp.LeisureConfig.LeisureAnim != null)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, "休闲动画：" + TM.ExtendConfigComp.LeisureConfig.LeisureAnim.GetName());
				}
				foreach (FGSLeisureRandomConfig item in TM.ExtendConfigComp.LeisureConfig.RandomConfig)
				{
					string name = item.RandomAnim.GetName();
					float weight = item.Weight;
					StringBuilderExtensions.AppendLine(stringBuilder, 2, "随机休闲动画：" + name + "\t随机权重：" + weight);
				}
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "这个怪没有配置休闲动画");
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【移动】怪物AO正常生效，注视玩家");
			if (bUAnimInstanceBase?.ABPSetting?.AimOffsetSetting.DefaultAimOffset != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "配置了默认AO，可以检查AO表现");
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Warning】没有配置默认AO！请确定是否符合设计");
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【移动】怪物游走姿态要平滑顺畅");
			if ((object)bUAnimInstanceBase != null)
			{
				BGWDataAsset_AbpHumanoidSetting aBPSetting = bUAnimInstanceBase.ABPSetting;
				if ((object)aBPSetting != null)
				{
					_ = aBPSetting.CommonSetting;
					if (true)
					{
						if ((object)bUAnimInstanceBase != null && bUAnimInstanceBase.ABPSetting?.CommonSetting.ABPMoveMode == EABPMoveMode.None)
						{
							StringBuilderExtensions.AppendLine(stringBuilder, 2, "纯技能位移怪物，请谨慎检查是否会TPose");
							foreach (string item2 in new List<string>())
							{
								StringBuilderExtensions.AppendLine(stringBuilder, 2, item2);
							}
						}
						else
						{
							StringBuilderExtensions.AppendLine(stringBuilder, 2, "ABP移动模式：" + bUAnimInstanceBase?.ABPSetting?.CommonSetting.ABPMoveMode.ToString() + "，需检查游走情况");
						}
						goto IL_030b;
					}
				}
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "无法读取ABP相关信息，请检查相关配置");
		}
		goto IL_030b;
		IL_030b:
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【模型】怪物被定身时，“定”字特效能播");
		if (!UGSE_SkeletalMeshFuncLib.IsCPUAccess(uSkeletalMeshComponent.SkeletalMesh))
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Error】这个怪没勾选CPUAccess，理论上播不出定字，请检查！");
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "从配置来看可以播");
		}
		return stringBuilder.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeEngagement")]
	public static string QADescribeEngagement(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【002-接战脱战】");
		int resID = TM.ConfigInfoComp.UnitCDesc.ResID;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((TM.ConfigInfoComp.UnitCDesc.OverrideID == 0) ? BGW_GameDB.GetUnitCommDesc(resID).DefaultBattleInfoExtendID : TM.ConfigInfoComp.UnitCDesc.OverrideID);
		int resID2 = resID * 100 + 1;
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【出生信息】");
		if (TM.ConfigInfoComp.UnitCDesc.BirthBuffs.Count > 0 || TM.ExtendConfigComp.BirthAbnormalStateList.Count > 0 || TM.ExtendConfigComp.AbnormalStateImmueList.Count > 0 || TM.ExtendConfigComp.HatchConfigInfo.BirthBuffIDList.Count > 0)
		{
			foreach (int birthBuff in TM.ConfigInfoComp.UnitCDesc.BirthBuffs)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【BirthBuff】" + birthBuff);
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveBuffByID(birthBuff, IsRemove: false, IsNeedProvideTime: true));
			}
			foreach (Birth_AbnomalState birthAbnormalState in TM.ExtendConfigComp.BirthAbnormalStateList)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【出生自带异常状态】" + GetEnumDisplayName(birthAbnormalState.AbnormalStateType));
			}
			foreach (Birth_AbnormalStateImmueType abnormalStateImmue in TM.ExtendConfigComp.AbnormalStateImmueList)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【异常状态免疫】" + GetEnumDisplayName(abnormalStateImmue));
			}
			foreach (int birthBuffID in TM.ExtendConfigComp.HatchConfigInfo.BirthBuffIDList)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【卵生怪出生后携带】" + birthBuffID);
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "蓝图上未特殊配置，请以实例为准");
		}
		if (GameDBRuntime.GetFUStUnitAIDesc(resID2) != null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【常用范围】");
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "视野范围：" + GameDBRuntime.GetFUStUnitAIDesc(resID2).SightRange);
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "听觉范围：" + GameDBRuntime.GetFUStUnitAIDesc(resID2).HearRange);
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "追踪范围：" + GameDBRuntime.GetFUStUnitAIDesc(resID2).PursuitRange);
		}
		if (BGW_GameDB.GetMandatoryAITaskDescListByResID(resID).Count != 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【强制任务】");
			foreach (FUStMandatoryAITaskDesc item in BGW_GameDB.GetMandatoryAITaskDescListByResID(resID))
			{
				List<string> list = new List<string>();
				if (item.IsReverseCondition == EGSYesNo.Yes)
				{
					list.Add("(条件取反！)");
				}
				switch (item.TaskCondition)
				{
				case EAITaskCondition.SelfHpLessThan:
					list.Add("血量低于" + item.ConditionFloatParams[0] + "%");
					break;
				case EAITaskCondition.SelfHasBuff:
					list.Add("有Buff " + item.ConditionIntParams[0]);
					break;
				default:
					list.Add(item.TaskCondition.ToString());
					break;
				}
				list.Add(item.TaskActivationEvent.ToString());
				StringBuilderExtensions.AppendLine(stringBuilder, 2, string.Join("\t", list));
				list.Clear();
				if (item.AITaskInfoList.Count == 0)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 3, "【Warning】在MandatoryAITask表中设置了AITask，但没有填写对应的Action");
				}
				foreach (FUStAITaskInfo aITaskInfo in item.AITaskInfoList)
				{
					list.Add(aITaskInfo.AITaskActionType.ToString());
					switch (aITaskInfo.AITaskActionType)
					{
					case EAITaskActionType.TriggerSequence:
						list.Add(string.Join("\t", aITaskInfo.TaskStringParams));
						StringBuilderExtensions.AppendLine(stringBuilder, 3, string.Join("\t", list));
						break;
					case EAITaskActionType.CastSkill:
						list.Add(string.Join("\t", aITaskInfo.TaskIntParams));
						StringBuilderExtensions.AppendLine(stringBuilder, 3, string.Join("\t", list));
						foreach (int taskIntParam in aITaskInfo.TaskIntParams)
						{
							StringBuilderExtensions.AppendLine(stringBuilder, 4, QADescribeAnimBySkillID(taskIntParam));
						}
						break;
					case EAITaskActionType.TriggerSkillEffect:
						list.Add(string.Join("\t", aITaskInfo.TaskIntParams));
						StringBuilderExtensions.AppendLine(stringBuilder, 3, string.Join("\t", list));
						foreach (int taskIntParam2 in aITaskInfo.TaskIntParams)
						{
							StringBuilderExtensions.AppendLine(stringBuilder, 4, SolveEffectByID(taskIntParam2));
						}
						break;
					}
				}
			}
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【战斗】大怪要能看见隐身单位");
		if ((int)unitBattleInfoExtendDesc.QualityType > 4 && unitBattleInfoExtendDesc.CanFindInvisibleUnit == EGSYesNo.No)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Warning】这是一个" + unitBattleInfoExtendDesc.QualityType.ToString() + "级别的怪物，但不能识别隐身单位，请确认是否符合设计！");
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "这是一个" + unitBattleInfoExtendDesc.QualityType.ToString() + "级别的怪物，" + ((unitBattleInfoExtendDesc.CanFindInvisibleUnit == EGSYesNo.Yes) ? "能" : "不能") + "识别隐身单位");
		}
		if (TM.ExtendConfigComp.PatrolType == EPatrolType.Leisure)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Tamer】从休闲到接战脱战的表现合理");
			if (TM.ExtendConfigComp.LeisureConfig.LeisureAnim != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "休闲动画：" + TM.ExtendConfigComp.LeisureConfig.LeisureAnim.GetName());
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Warning】配置了待机时休闲，但没有配置休闲动画（或配置于实例上了），请结合实例确认！");
			}
		}
		int onFightSkillID = TM.ExtendConfigComp.WakeUpConfig.OnFightSkillID;
		if (onFightSkillID != 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Tamer】观察接战技生效情况");
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "正面接战技：");
			StringBuilderExtensions.AppendLine(stringBuilder, 3, QADescribeAnimBySkillID(onFightSkillID));
			if (TM.ExtendConfigComp.WakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDBack != 0)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "背面接战技：");
				StringBuilderExtensions.AppendLine(stringBuilder, 3, QADescribeAnimBySkillID(TM.ExtendConfigComp.WakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDBack));
			}
			if (TM.ExtendConfigComp.WakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDLeft != 0)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "左侧接战技：");
				StringBuilderExtensions.AppendLine(stringBuilder, 3, QADescribeAnimBySkillID(TM.ExtendConfigComp.WakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDLeft));
			}
			if (TM.ExtendConfigComp.WakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDRight != 0)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "右侧接战技：");
				StringBuilderExtensions.AppendLine(stringBuilder, 3, QADescribeAnimBySkillID(TM.ExtendConfigComp.WakeUpConfig.DirectionOnFightSkillConfig.OnFightSkillIDRight));
			}
			if (TM.ExtendConfigComp.WakeUpConfig.bJustUseOnFightSkillFirstTime)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "仅第一次唤醒使用接战技");
			}
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Tamer】脱战回家表现合理");
		if ((TM.ConfigInfoComp.UnitAIDesc.StalemateInfoMap.Count == 1 && TM.ConfigInfoComp.UnitAIDesc.StalemateInfoMap[0].ReturnHomeSkillID == 0) || TM.ConfigInfoComp.UnitAIDesc.StalemateInfoMap.Count == 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "不具有脱战技");
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "脱战技总览：（Key是BuffID，默认状态是0）");
			foreach (KeyValuePair<int, FStalemateInfo> item2 in TM.ConfigInfoComp.UnitAIDesc.StalemateInfoMap)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 3, "BuffID: " + item2.Key + "\tReturnHomeSkillID: " + item2.Value.ReturnHomeSkillID);
				StringBuilderExtensions.AppendLine(stringBuilder, 3, QADescribeAnimBySkillID(item2.Value.ReturnHomeSkillID));
			}
		}
		BGUCharacterCS bGUCharacterCS = TM.GetMonsterClass().GetDefaultObject() as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.CapsuleComponent.CanCharacterStepUpOn == ECanBeCharacterBase.ECB_Yes)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【注意】");
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Error】此怪物可以被主角站到头顶（Unit.CapsuleComponent.CanCharacterStepUpOn = Yes），请修改！");
		}
		return stringBuilder.ToString();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeSkill")]
	public static string QADescribeSkill(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【003-肉搏技能】【004-远程技能】");
		UBehaviorTree unitBehaviorTree = TM.ConfigInfoComp.UnitBehaviorTree;
		List<UBTTaskNode> taskNodeList = QAGetBTTaskNodes(unitBehaviorTree).TaskNodeList;
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		foreach (UBTTaskNode item in taskNodeList)
		{
			BAIT_Combo bAIT_Combo = item as BAIT_Combo;
			if (bAIT_Combo != null)
			{
				foreach (FComboSkill item2 in bAIT_Combo.SkillArray)
				{
					foreach (int item3 in item2.SkillID)
					{
						ListExtensions.AddUnique(list, item3);
					}
				}
				foreach (string item4 in bAIT_Combo.QACalcTrueComboArray())
				{
					ListExtensions.AddUnique(list2, item4);
				}
			}
			BAIT_UseSkillWithID bAIT_UseSkillWithID = item as BAIT_UseSkillWithID;
			if (bAIT_UseSkillWithID != null)
			{
				ListExtensions.AddUnique(list, bAIT_UseSkillWithID.SkillID);
			}
			BAIT_UseRandomSkillWithID bAIT_UseRandomSkillWithID = item as BAIT_UseRandomSkillWithID;
			if (!(bAIT_UseRandomSkillWithID != null))
			{
				continue;
			}
			foreach (int item5 in bAIT_UseRandomSkillWithID.SkillID)
			{
				ListExtensions.AddUnique(list, item5);
			}
		}
		list.Sort();
		list2.Sort();
		if (unitBehaviorTree == null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "Tamer蓝图上没有配置BT，提取不到BT中的技能信息，请以关卡里的实例为准");
		}
		else if (list.Count > 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "行为树 " + unitBehaviorTree.GetName() + " 中提取到的技能信息：");
			foreach (int item6 in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, QADescribeAnimBySkillID(item6));
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, unitBehaviorTree.GetName() + " 中提取不到任何技能信息");
		}
		int behaviorGraphTemplateID = TM.ExtendConfigComp.BehaviorGraphTemplateID;
		if (behaviorGraphTemplateID != 0)
		{
			FUStCBGTemplateDesc cBGTemplateDesc = BGW_GameDB.GetCBGTemplateDesc(behaviorGraphTemplateID);
			object obj;
			if (cBGTemplateDesc == null)
			{
				obj = null;
			}
			else
			{
				string path = cBGTemplateDesc.Path;
				obj = ((path != null) ? GameplayTagExtension.LoadGraph(path) : null);
			}
			FCalliopeGraph fCalliopeGraph = (FCalliopeGraph)obj;
			if (fCalliopeGraph != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, cBGTemplateDesc.Path.Split('.').Last().Trim('\'') + " 中提取到的，仅能由CBG释放的技能信息：");
				StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveCastSkill(fCalliopeGraph, list));
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Error】填入的CBG ID " + behaviorGraphTemplateID + " 找不到对应的Graph，请检查填表情况！");
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "Tamer蓝图上没有配置CBG，提取不到CBG中的技能信息，请以关卡里的实例为准");
		}
		List<string> list3 = new List<string>();
		foreach (string item7 in list2)
		{
			string[] array = item7.Split(new string[1] { "->" }, StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				if (i + 1 < array.Length)
				{
					ListExtensions.AddUnique(list3, array[i] + "->" + array[i + 1]);
				}
			}
		}
		list3.Sort();
		if (unitBehaviorTree != null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "行为树 " + unitBehaviorTree.GetName() + " 中提取到的连招信息：");
			if (list2.Count > 0)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【真连招表】");
				foreach (string item8 in list2)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 3, item8);
				}
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【接续关系】");
				foreach (string item9 in list3)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 3, item9);
				}
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "行为树 " + unitBehaviorTree.GetName() + " 中没有配置真连招");
			}
		}
		return stringBuilder.ToString();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeBT")]
	public static string QADescribeBT(UBehaviorTree BT)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【003-肉搏技能】【004-远程技能】");
		List<UBTTaskNode> taskNodeList = QAGetBTTaskNodes(BT).TaskNodeList;
		List<int> list = new List<int>();
		List<string> list2 = new List<string>();
		foreach (UBTTaskNode item in taskNodeList)
		{
			BAIT_Combo bAIT_Combo = item as BAIT_Combo;
			if (!(bAIT_Combo != null))
			{
				continue;
			}
			foreach (FComboSkill item2 in bAIT_Combo.SkillArray)
			{
				foreach (int item3 in item2.SkillID)
				{
					if (!list.Contains(item3))
					{
						list.Add(item3);
					}
				}
			}
			foreach (string item4 in bAIT_Combo.QACalcTrueComboArray())
			{
				if (!list2.Contains(item4))
				{
					list2.Add(item4);
				}
			}
		}
		list.Sort();
		list2.Sort();
		if (list.Count > 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "行为树 " + BT.GetName() + " 中提取到的技能信息：");
			foreach (int item5 in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, QADescribeAnimBySkillID(item5));
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, BT.GetName() + " 中提取不到任何技能信息");
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "行为树 " + BT.GetName() + " 中提取到的连招信息：");
		if (list2.Count > 0)
		{
			if (list2.Count > 16)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "能构成真连招的组合过多，基本失去逐条测试意义");
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "可以考虑以多次实战来代替真连招检查");
			}
			foreach (string item6 in list2)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, item6);
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "行为树 " + BT.GetName() + " 中没有配置真连招");
		}
		return stringBuilder.ToString();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeAnimBySkillID")]
	public static string QADescribeAnimBySkillID(int SkillID)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string aMPathBySkillID = BGUFunclibEditorUtility.GetAMPathBySkillID(SkillID);
		UAnimMontage uAnimMontage = UEditorAssetLibrary.LoadAsset(aMPathBySkillID) as UAnimMontage;
		if (GameDBRuntime.GetFUStSkillSDesc(SkillID) == null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "【Error】技能ID " + SkillID + " 在表中查不到，请检查配置！");
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "============================================================");
			return stringBuilder.ToString();
		}
		ESkillType skillType = GameDBRuntime.GetFUStSkillSDesc(SkillID).SkillType;
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SkillID + ":" + aMPathBySkillID.Split('.').Last().Trim('\'') + ((skillType != ESkillType.HurtSkill) ? ("\t" + GetEnumDisplayName(skillType)) : ""));
		if (skillType == ESkillType.ChargeSkillBegin)
		{
			FUStChargeSkillSDesc fUStChargeSkillSDesc = GameDBRuntime.GetFUStChargeSkillSDesc(SkillID);
			if (fUStChargeSkillSDesc == null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Error】此技能未填入蓄力技表FUStChargeSkillSDesc中！");
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "============================================================");
				return stringBuilder.ToString();
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "最大蓄力时间：" + fUStChargeSkillSDesc.MaxChargeTime + "\t循环结束后释放：" + fUStChargeSkillSDesc.NextStageSkillID + "\t主动或受击时放：" + fUStChargeSkillSDesc.EndSkillID);
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "循环动画： " + fUStChargeSkillSDesc.LoopTemplatePath.Split('.').Last().Trim('\''));
			if (fUStChargeSkillSDesc.ChargeSkillSuperArmorInfo.SkillSuperArmorValue > 0f)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "霸体护甲：" + fUStChargeSkillSDesc.ChargeSkillSuperArmorInfo.SkillSuperArmorValue + "\t霸体护甲破碎动画：" + fUStChargeSkillSDesc.ChargeSkillSuperArmorInfo.SSABreakAssignedAnim.Split('.').Last().Trim('\''));
			}
			if (fUStChargeSkillSDesc.ChargeSkillBuffInfoList.Count > 0)
			{
				List<int> list = fUStChargeSkillSDesc.ChargeSkillBuffInfoList.Select((FUStChargeSkillBuffInfo info) => info.BuffID).ToList();
				string text = string.Join(" | ", list);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "蓄力期间Buff：" + text);
				foreach (int item in list)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveBuffByID(item));
				}
			}
		}
		if (uAnimMontage == null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "无法读取动画信息，请关闭正在运行的编辑器后重试");
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "或检查动画路径（ " + aMPathBySkillID + " ）或技能ID（ " + SkillID + " ）是否存在");
		}
		else
		{
			string value = DescribeAnimMontageImpl(uAnimMontage, SkillID);
			StringBuilderExtensions.AppendLine(stringBuilder, 1, value);
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "============================================================");
		if (skillType == ESkillType.ChargeSkillBegin)
		{
			FUStChargeSkillSDesc fUStChargeSkillSDesc2 = GameDBRuntime.GetFUStChargeSkillSDesc(SkillID);
			UAnimMontage montage = UEditorAssetLibrary.LoadAsset(fUStChargeSkillSDesc2.LoopTemplatePath) as UAnimMontage;
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeAnimByMontage(montage));
			UAnimMontage montage2 = UEditorAssetLibrary.LoadAsset(fUStChargeSkillSDesc2.ChargeSkillSuperArmorInfo.SSABreakAssignedAnim) as UAnimMontage;
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeAnimByMontage(montage2));
			List<int> list2 = new List<int>();
			if (!list2.Contains(fUStChargeSkillSDesc2.NextStageSkillID) && fUStChargeSkillSDesc2.NextStageSkillID != 0)
			{
				list2.Add(fUStChargeSkillSDesc2.NextStageSkillID);
			}
			if (!list2.Contains(fUStChargeSkillSDesc2.EndSkillID) && fUStChargeSkillSDesc2.EndSkillID != 0)
			{
				list2.Add(fUStChargeSkillSDesc2.EndSkillID);
			}
			foreach (int item2 in list2)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeAnimBySkillID(item2));
			}
		}
		return stringBuilder.ToString();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeAnimByMontage")]
	public static string QADescribeAnimByMontage(UAnimMontage Montage)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (Montage == null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "无法读取动画信息，请关闭正在运行的编辑器后重试");
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, Montage.GetName());
			StringBuilderExtensions.AppendLine(stringBuilder, 1, DescribeAnimMontageImpl(Montage));
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "============================================================");
		return stringBuilder.ToString();
	}

	private static string DescribeAnimMontageImpl(UAnimMontage AM, int? SkillID = null)
	{
		SolvedBuff.Clear();
		SolvedBullet.Clear();
		if (AM == null)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		UGSE_AnimFuncLib.GetAllNotifyEvent(AM, out var AnimNotifyEventList);
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSkillSuperArmor(AnimNotifyEventList, SkillID));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveHandleBattleMessage(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveNotifyBehaviorGraph(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSweepCheck(AnimNotifyEventList, SkillID));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSpawnBulletByEventList(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveBuffByEventList(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveEffectByEventList(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSummonUnit(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveCameraShake(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveDestroyProjectileByID(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSwitchCollisionProfile(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveCollisionResponseToChannel(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveNotifyType(AnimNotifyEventList));
		StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveMiscNotifyExists(AnimNotifyEventList));
		return stringBuilder.ToString();
	}

	private static string SolveSwitchStateLibTypes(b1.BUS_StateLibComp.StateType StateTypes)
	{
		List<string> list = new List<string>();
		if ((StateTypes & b1.BUS_StateLibComp.StateType.TurnSkill) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("TurnSkill");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.ArmorSetting) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("ArmorSetting");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.Speed) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("Speed");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.ABPSetting) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("ABPSetting");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.BeAttackedInfo) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("BeAttackedInfo");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.DeadInfoID) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("DeadInfoID");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.MovementMode) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("MovementMode");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.PartRule) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("PartRule");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.DodgeSkill) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("DodgeSkill");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.AMScaleMaxRate) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("AMScaleMaxRate");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.SpecialBoneSetting) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("SpecialBoneSetting");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.PortionPACollisionEnable) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("PortionPACollisionEnable");
		}
		if ((StateTypes & b1.BUS_StateLibComp.StateType.DisableHitMoveCollision) > b1.BUS_StateLibComp.StateType.None)
		{
			list.Add("DisableHitMoveCollision");
		}
		return "修改项 " + string.Join(" | ", list);
	}

	private static string SolveCameraShake(List<FAnimNotifyEvent> EventList)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			BANS_GSPlayCameraShake bANS_GSPlayCameraShake = Event.NotifyStateClass as BANS_GSPlayCameraShake;
			if (!(bANS_GSPlayCameraShake != null))
			{
				continue;
			}
			bool flag = false;
			if (bANS_GSPlayCameraShake.CameraShake == null || !bANS_GSPlayCameraShake.CameraShake.Value.PathName.Contains("Design/Blueprints/CameraShake/General"))
			{
				ListExtensions.AddUnique(list, "【Warning】震屏未使用标准的震屏蓝图模板（CameraShake）");
				flag = true;
			}
			if (bANS_GSPlayCameraShake.CameraShake != null && bANS_GSPlayCameraShake.StopWhenNotifyEnded)
			{
				float uMatineeCameraShakeBlendOutTime = UBUS_UtilComm.GetUMatineeCameraShakeBlendOutTime(UObject.LoadObject<UBlueprintGeneratedClass>(null, bANS_GSPlayCameraShake.CameraShake.Value.PathName).ClassDefaultObject.Cast<UMatineeCameraShake>());
				if (uMatineeCameraShakeBlendOutTime > Event.Duration)
				{
					ListExtensions.AddUnique(list, $"【Warning】震屏的融出时间 {uMatineeCameraShakeBlendOutTime} 大于震屏持续时间 {Event.Duration} ，会导致震屏压根不播");
					flag = true;
				}
			}
			if (bANS_GSPlayCameraShake.CamShakeScaleByDistCurve == null)
			{
				ListExtensions.AddUnique(list, "【Warning】震屏未配置距离缩放曲线（CamShakeScaleByDistCurve）");
				flag = true;
			}
			if (!bANS_GSPlayCameraShake.StopWhenNotifyEnded)
			{
				ListExtensions.AddUnique(list, "【Warning】震屏NotifyState被打断时，震屏不会停止（StopWhenNotifyEnded=false）");
				flag = true;
			}
			if (!flag)
			{
				ListExtensions.AddUnique(list, "震屏配置正常，请留意震屏表现");
			}
		}
		if (list.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "PlayCameraShake:");
			foreach (string item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	private static string SolveEffectByID(int EffectID, string DesignerComment = "Default")
	{
		List<string> list = new List<string>();
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, null);
		if (skillEffectDesc == null)
		{
			return "【Error】未在Skill表中找到Effect " + EffectID;
		}
		list.Add(EffectID.ToString());
		List<string> list2 = new List<string>();
		if ((skillEffectDesc.TargetFilter & 1) != 0)
		{
			list2.Add("自己");
		}
		if ((skillEffectDesc.TargetFilter & 2) != 0)
		{
			list2.Add("队友");
		}
		if ((skillEffectDesc.TargetFilter & 4) != 0)
		{
			list2.Add("敌人");
		}
		list.Add("对" + string.Join("、", list2));
		list.Add(skillEffectDesc.EffectType.ToString());
		if (DesignerComment != "Default")
		{
			list.Add((DesignerComment != "None") ? DesignerComment : "策划未注释用途");
		}
		string item = "";
		switch (skillEffectDesc.EffectType)
		{
		case EBuffAndSkillEffectType.SkillDamage:
		{
			if (skillEffectDesc.EffectParamsStr.Count > 0)
			{
				list.Add((skillEffectDesc.EffectParamsStr[0].ToString() == "无") ? "无霸体护甲伤害" : skillEffectDesc.EffectParamsStr[0].ToString());
			}
			else
			{
				list.Add("霸体护甲伤害数值 " + skillEffectDesc.EffectParamsFloat[0]);
				list.Add("【Warning】请尽早把霸体护甲伤害改成文字式描述");
			}
			list.Add("硬直效果ID " + skillEffectDesc.EffectParamsInt[1]);
			FUStSkillDamageExpandDesc originalSkillDamageExpandDesc = BGW_GameDB.GetOriginalSkillDamageExpandDesc(EffectID);
			if (originalSkillDamageExpandDesc != null && originalSkillDamageExpandDesc.HitWeightGearType == EHitWeightGearType.MustDefeatHitWeight)
			{
				list.Add("击破TTTB");
			}
			else
			{
				list.Add("无视TTTB（偏移）");
			}
			if (originalSkillDamageExpandDesc != null && originalSkillDamageExpandDesc.PillarFormTerminatorType != EPillarFormTerminatorType.None)
			{
				list.Add("撑棍终结者:" + GetEnumDisplayName(originalSkillDamageExpandDesc.PillarFormTerminatorType));
			}
			if (skillEffectDesc.EffectParamsInt.Count > 5 && skillEffectDesc.EffectParamsInt[5] > 0)
			{
				list.Add(GetEnumDisplayName((EAbnormalStateType)skillEffectDesc.EffectParamsInt[5]).Substring(0, 1) + "属性");
				list.Add("属性伤害比例：" + skillEffectDesc.EffectParamsInt[4] * 25 + "%");
			}
			else
			{
				list.Add("纯物理伤害");
			}
			break;
		}
		case EBuffAndSkillEffectType.AccumulateAbnormalValue:
			if (skillEffectDesc.EffectParamsInt.Count > 0)
			{
				list.Add(string.Format("附加{0}级{1}，积累量为{2} {3}", skillEffectDesc.EffectParamsInt[1], GetEnumDisplayName((EAbnormalStateType)skillEffectDesc.EffectParamsInt[0]), (skillEffectDesc.EffectParamsInt[2] == 0) ? "绝对值" : "万分比", skillEffectDesc.EffectParamsInt[3]));
			}
			break;
		case EBuffAndSkillEffectType.SwitchStateLib:
		{
			list.Add(((skillEffectDesc.EffectParamsInt[0] > 0) ? "切换到 " : "重置为 ") + skillEffectDesc.EffectParamsStr[0].Split('.').Last().Trim('\''));
			b1.BUS_StateLibComp.StateType stateTypes = (b1.BUS_StateLibComp.StateType)skillEffectDesc.EffectParamsInt[1];
			list.Add(SolveSwitchStateLibTypes(stateTypes));
			break;
		}
		case EBuffAndSkillEffectType.AddAttr:
		case EBuffAndSkillEffectType.RecoverAttr:
			if (skillEffectDesc.EffectParamsInt.Count == 3)
			{
				string text12 = ((skillEffectDesc.EffectType == EBuffAndSkillEffectType.AddAttr) ? "增加" : "恢复");
				string enumDisplayName = GetEnumDisplayName((EBGUAttrFloat)skillEffectDesc.EffectParamsInt[1]);
				string text13 = skillEffectDesc.EffectParamsFloat[0].ToString();
				string text14 = ((skillEffectDesc.EffectParamsInt[2] == 0) ? "绝对值" : "万分比");
				item = $"{text12}属性ID {skillEffectDesc.EffectParamsInt[1].ToString()}({enumDisplayName})的{text14}{text13}";
				list.Add(item);
			}
			else
			{
				list.Add("【Error】Attr相关参数数量不足，int参数数量应为3，请检查填表是否正确！");
			}
			break;
		case EBuffAndSkillEffectType.SummonUnit:
		{
			string text10 = BGW_GameDB.GetOriginalSummonCommDesc(skillEffectDesc.EffectParamsInt[0]).SummonTamerTemplatePath.Split('.').Last().Trim('\'');
			if (text10.EndsWith("_C"))
			{
				text10 = text10.Substring(0, text10.Length - 2);
			}
			string text11 = BGW_GameDB.GetOriginalSummonCommDesc(skillEffectDesc.EffectParamsInt[0]).SummonDataAssetsPath.Split('.').Last().Trim('\'');
			if (text11.EndsWith("_C"))
			{
				text11 = text11.Substring(0, text11.Length - 2);
			}
			list.Add("召唤 " + skillEffectDesc.EffectParamsInt[0] + "\t" + text10 + "\t" + text11);
			break;
		}
		case EBuffAndSkillEffectType.ClearAbnormalState:
			foreach (int item2 in skillEffectDesc.EffectParamsInt)
			{
				list.Add("清除" + GetEnumDisplayName((EAbnormalStateType)item2));
			}
			break;
		case EBuffAndSkillEffectType.Teleport:
		{
			string text3 = ((skillEffectDesc.EffectParamsInt[0] == 1) ? "随机" : "固定");
			int num2 = skillEffectDesc.EffectParamsInt[1];
			string text4 = ((skillEffectDesc.EffectParamsInt.Count >= 3) ? ((skillEffectDesc.EffectParamsInt[2] == 1) ? "朝向当前目标" : "不保持目标朝向") : "不保持目标朝向");
			switch (num2)
			{
			case 0:
			{
				string text9 = skillEffectDesc.EffectParamsStr[0];
				item = $"{text3}按EQS({text9.Split('.').Last().Trim('\'')})的方式传送，{text4}";
				break;
			}
			case 1:
			{
				string text7 = skillEffectDesc.EffectParamsStr[0];
				if (skillEffectDesc.EffectParamsStr.Count == 1)
				{
					item = $"{text3}传至 {text7}, {text4}";
				}
				else if (skillEffectDesc.EffectParamsStr.Count == 2)
				{
					string text8 = skillEffectDesc.EffectParamsStr[1];
					item = $"{text3}传至 {text7} 的Socket {text8}，{text4}";
				}
				else
				{
					item = $"【Error】传送参数数量错误，应有2个String参数，分别指明怪物的GUID和Socket";
				}
				break;
			}
			case 2:
			{
				string text5 = skillEffectDesc.EffectParamsStr[0];
				if (skillEffectDesc.EffectParamsStr.Count == 1)
				{
					item = $"{text3}传至带Tag {text5} 的SceneItem上，{text4}";
				}
				else if (skillEffectDesc.EffectParamsStr.Count == 2)
				{
					string text6 = skillEffectDesc.EffectParamsStr[1];
					item = $"{text3}传至怪 {text5} 的Socket {text6}，{text4}";
				}
				else
				{
					item = $"【Error】传送参数数量错误，应有1-2个参数";
				}
				break;
			}
			case 3:
				item = "传送到所在Family中最近死亡的单位的位置";
				break;
			case 4:
			{
				int num3 = skillEffectDesc.EffectParamsInt[4];
				item = $"{text3}传至点集{num3}，{text4}";
				break;
			}
			}
			list.Add(item);
			break;
		}
		case EBuffAndSkillEffectType.SpawnProjectile:
		{
			string text11 = skillEffectDesc.EffectParamsStr[0];
			list.Add(text11.Split('.').Last().Trim('\''));
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list));
			StringBuilderExtensions.AppendLine(stringBuilder, 1, SolveSpawnProjectile(text11));
			return stringBuilder.ToString();
		}
		case EBuffAndSkillEffectType.SwitchBullet:
		{
			int bulletID = BGW_GameDB.GetBulletSwitchDesc(skillEffectDesc.EffectParamsInt[0]).BulletID;
			int num5 = skillEffectDesc.EffectParamsInt[2];
			int num6 = skillEffectDesc.EffectParamsInt[3];
			switch (num5)
			{
			default:
			{
				item = $"将子弹 {num6} 转化成 {bulletID}";
				list.Add(item);
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list));
				StringBuilderExtensions.AppendLine(stringBuilder, 1, SolveSpawnBulletByBulletID(bulletID));
				return stringBuilder.ToString();
			}
			}
		}
		case EBuffAndSkillEffectType.BulletSwitchSelf:
			if (skillEffectDesc.EffectParamsInt.Count > 0)
			{
				int bulletID = BGW_GameDB.GetBulletSwitchDesc(skillEffectDesc.EffectParamsInt[0]).BulletID;
				list.Add("转为" + bulletID);
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list));
				StringBuilderExtensions.AppendLine(stringBuilder, 1, SolveSpawnBulletByBulletID(bulletID));
				return stringBuilder.ToString();
			}
			list.Add("【Error】子弹转化参数不够！");
			break;
		case EBuffAndSkillEffectType.AddBuff:
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list));
			int count = skillEffectDesc.EffectParamsInt.Count;
			for (int i = 0; i < count; i++)
			{
				int num4 = skillEffectDesc.EffectParamsInt[i];
				StringBuilderExtensions.AppendLine(stringBuilder, 1, string.Concat(str3: (skillEffectDesc.EffectParamsFloat.Count <= i) ? "【Error】AddBuff参数不足，未给出Buff时间相关参数" : ((skillEffectDesc.EffectParamsFloat[i] != 0f) ? ("持续时间为" + skillEffectDesc.EffectParamsFloat[i] / 1000f + "s") : ((GameDBRuntime.GetFUStBuffDesc(num4).Duration != -1) ? ("持续时间为" + (float)GameDBRuntime.GetFUStBuffDesc(num4).Duration / 1000f + "s") : "持续到永久，通过其他方式移除")), str0: "+", str1: num4.ToString(), str2: "\t添加1层\t"));
				StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveBuffByID(num4));
			}
			return stringBuilder.ToString();
		}
		case EBuffAndSkillEffectType.SetPartActive:
		{
			int num = skillEffectDesc.EffectParamsInt[0];
			string text2 = ((skillEffectDesc.EffectParamsInt[1] == 0) ? "不激活" : "激活");
			list.Add("部位" + num + "\t" + text2);
			break;
		}
		case EBuffAndSkillEffectType.SwitchBehaviorTree:
		{
			string text = skillEffectDesc.EffectParamsStr[0].Split('.').Last().Trim('\'');
			list.Add("切换到行为树 " + text);
			break;
		}
		}
		return string.Join("\t", list);
	}

	private static string SolveSweepCheck(List<FAnimNotifyEvent> EventList, int? SkillID = null)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			BANS_GSSweepCheck bANS_GSSweepCheck = Event.NotifyStateClass as BANS_GSSweepCheck;
			if (!(bANS_GSSweepCheck != null))
			{
				continue;
			}
			List<string> list = new List<string>();
			StringBuilder stringBuilder = new StringBuilder();
			if (bANS_GSSweepCheck.SweepCheckGroupID != -1)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "编组ID\t" + bANS_GSSweepCheck.SweepCheckGroupID);
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "未编组");
			}
			if (bANS_GSSweepCheck.EffectIDList.Count == 0)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "此Sweep未配置命中玩家的Effect");
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "命中破碎物时的打击力度：" + GetEnumDisplayName(bANS_GSSweepCheck.HitDestructibleConfig.HitStrengthLevel));
			}
			bool flag = false;
			bool flag2 = false;
			foreach (int effectID2 in bANS_GSSweepCheck.EffectIDList)
			{
				List<string> list2 = new List<string>();
				FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(effectID2, null);
				if (skillEffectDesc == null)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 0, "【Error】配置的Effect " + effectID2 + " 在表中无法查到，请检查！");
					continue;
				}
				list2.Add(effectID2.ToString());
				List<string> list3 = new List<string>();
				if ((skillEffectDesc.TargetFilter & 1) != 0)
				{
					list3.Add("自己");
				}
				if ((skillEffectDesc.TargetFilter & 2) != 0)
				{
					list3.Add("队友");
				}
				if ((skillEffectDesc.TargetFilter & 4) != 0)
				{
					list3.Add("敌人");
				}
				list2.Add("对" + string.Join("、", list3));
				list2.Add(skillEffectDesc.EffectType.ToString());
				if (skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
				{
					if (skillEffectDesc.EffectParamsStr.Count > 0)
					{
						list2.Add((skillEffectDesc.EffectParamsStr[0].ToString() == "无") ? "无霸体护甲伤害" : skillEffectDesc.EffectParamsStr[0].ToString());
					}
					else
					{
						list2.Add("霸体护甲伤害数值 " + skillEffectDesc.EffectParamsFloat[0]);
						list2.Add("【Warning】请尽早把霸体护甲伤害改成文字式描述");
					}
					list2.Add("硬直效果ID " + skillEffectDesc.EffectParamsInt[1]);
					FUStSkillDamageExpandDesc originalSkillDamageExpandDesc = BGW_GameDB.GetOriginalSkillDamageExpandDesc(effectID2);
					if (originalSkillDamageExpandDesc != null && originalSkillDamageExpandDesc.HitWeightGearType == EHitWeightGearType.MustDefeatHitWeight)
					{
						list2.Add("击破TTTB");
					}
					else if (bANS_GSSweepCheck.AtkReboundingAM != null || (SkillID.HasValue && UEditorAssetLibrary.LoadAsset(GameDBRuntime.GetFUStSkillSDesc(SkillID.Value).AtkReboundingMontage) != null))
					{
						list2.Add("可以弹刀");
					}
					else
					{
						list2.Add("无视TTTB（偏移）");
					}
					if (originalSkillDamageExpandDesc != null && originalSkillDamageExpandDesc.PillarFormTerminatorType != EPillarFormTerminatorType.None)
					{
						list2.Add("撑棍终结者:" + GetEnumDisplayName(originalSkillDamageExpandDesc.PillarFormTerminatorType));
					}
					if (skillEffectDesc.EffectParamsInt.Count > 5 && skillEffectDesc.EffectParamsInt[5] > 0)
					{
						list2.Add(GetEnumDisplayName((EAbnormalStateType)skillEffectDesc.EffectParamsInt[5]).Substring(0, 1) + "属性");
						list2.Add("属性伤害比例：" + skillEffectDesc.EffectParamsInt[4] * 25 + "%");
						flag2 = true;
						if (skillEffectDesc.EffectParamsInt[4] < 1 || skillEffectDesc.EffectParamsInt[4] > 4)
						{
							string item = "【Error】属性伤害比例不正常，请检查！";
							ListExtensions.AddUnique(list, item);
						}
					}
					else
					{
						list2.Add("纯物理伤害");
					}
					if (bANS_GSSweepCheck.AbnormalStateEffectList.Count > 0)
					{
						foreach (AbnormalStateAccConfig abnormalStateEffect in bANS_GSSweepCheck.AbnormalStateEffectList)
						{
							int effectID = 920000 + (int)abnormalStateEffect.AccType * 1000 + (int)abnormalStateEffect.AbnormalStateType * 100 + abnormalStateEffect.Level * 10;
							list2.Add(SolveEffectByID(effectID));
						}
						flag = true;
					}
					StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list2));
				}
				else if (skillEffectDesc.EffectType == EBuffAndSkillEffectType.AccumulateAbnormalValue)
				{
					if (skillEffectDesc.EffectParamsInt.Count > 0)
					{
						list2.Add(SolveEffectByID(effectID2));
					}
					if (skillEffectDesc.EffectParamsInt[0] < 5 && skillEffectDesc.EffectParamsInt[0] > 0)
					{
						flag = true;
					}
					StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list2));
				}
				else
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveEffectByID(effectID2));
				}
			}
			if (bANS_GSSweepCheck.EffectsWithCondition_Before.Count > 0)
			{
				ListExtensions.AddUnique(list, "【注意】带条件触发效果_Before（Sweep前特定条件触发Effect）不为空，请通过AM查看具体效果");
			}
			if (bANS_GSSweepCheck.EffectsWithCondition_After.Count > 0)
			{
				ListExtensions.AddUnique(list, "【注意】带条件触发效果_After（Sweep后特定条件触发Effect）不为空，请通过AM查看具体效果");
			}
			if (flag != flag2)
			{
				string item2 = "【Error】异常属性累积" + (flag ? "配了" : "没配") + "但是属性伤害" + (flag2 ? "配了" : "没配") + "！";
				ListExtensions.AddUnique(list, item2);
			}
			foreach (string item3 in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item3);
			}
			if (dictionary.ContainsKey(stringBuilder.ToString()))
			{
				dictionary[stringBuilder.ToString()]++;
			}
			else
			{
				dictionary[stringBuilder.ToString()] = 1;
			}
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		foreach (KeyValuePair<string, int> item4 in dictionary)
		{
			StringBuilderExtensions.AppendLine(stringBuilder2, 0, "[*" + item4.Value + "] " + item4.Key);
		}
		if (stringBuilder2.Length > 0)
		{
			StringBuilder stringBuilder3 = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder3, 0, "SweepCheck:");
			StringBuilderExtensions.AppendLine(stringBuilder3, 1, stringBuilder2.ToString());
			return stringBuilder3.ToString();
		}
		return "";
	}

	private static string SolveSpawnBulletByBulletID(int BulletID)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (SolvedBullet.Contains(BulletID))
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "此Bullet详细信息已经解析过，请搜索上文");
			return stringBuilder.ToString();
		}
		SolvedBullet.Add(BulletID);
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(BulletID, null);
		if (projectileCommDesc == null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "【Error】ProjectileCommDesc中无法查到填写的BulletID：" + BulletID);
			return stringBuilder.ToString();
		}
		List<string> list = new List<string> { BulletID.ToString() };
		string text = projectileCommDesc.ProjectileBPTemplatePath.Split('.').Last();
		string projectileBPTemplatePath = projectileCommDesc.ProjectileBPTemplatePath;
		if (projectileBPTemplatePath != "")
		{
			string path = projectileBPTemplatePath.Substring(0, projectileBPTemplatePath.Length - 2);
			UBlueprint Blueprint;
			BGUBulletBaseCS bGUBulletBaseCS = UGSE_EditorFuncLib.AssetPath_GetCDO(null, path, out Blueprint) as BGUBulletBaseCS;
			list.Add(text.Remove(text.Length - 2));
			if (bGUBulletBaseCS != null)
			{
				list.Add(bGUBulletBaseCS.ProjectileConfigInfoComp.bEnableAttackWarning ? "可以精确闪避" : "不可精确闪避");
			}
			else
			{
				list.Add("这是一个法术场");
			}
		}
		else
		{
			list.Add("这是一个转化子弹");
		}
		bool num = projectileCommDesc.BeHitedTriggerEffectIDs.Contains(9997);
		bool flag = projectileCommDesc.BeHitedProjectileSwitchID != 0;
		if (num)
		{
			list.Add("转棍可以挡");
		}
		else if (flag)
		{
			list.Add("子弹接触转棍后转化");
		}
		else
		{
			list.Add("转棍不能挡");
		}
		list.Add("抛射物生命时间:" + projectileCommDesc.ProjectileLifeTime);
		if (BGW_GameDB.GetBulletExpandDesc(BulletID) != null)
		{
			list.Add("子弹SweepCheck间隔:" + BGW_GameDB.GetBulletExpandDesc(BulletID).BulletSweepCheckGap);
			list.Add("子弹SweepCheck延迟时间:" + BGW_GameDB.GetBulletExpandDesc(BulletID).BulletSweepCheckDelayTime);
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 0, string.Join("\t", list));
		if (BGW_GameDB.GetBulletExpandDesc(BulletID) != null)
		{
			bool flag2 = false;
			bool flag3 = false;
			if (flag)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "子弹被击中时转换为\t" + projectileCommDesc.BeHitedProjectileSwitchID);
			}
			foreach (int item in BGW_GameDB.GetBulletExpandDesc(BulletID).HitItemEffectsforSelf)
			{
				List<string> values = new List<string>
				{
					"命中物体后对自身触发",
					SolveEffectByID(item)
				};
				StringBuilderExtensions.AppendLine(stringBuilder, 1, string.Join("\t", values));
			}
			foreach (int item2 in BGW_GameDB.GetBulletExpandDesc(BulletID).HitEffectsforChr)
			{
				List<string> list2 = new List<string>();
				FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(item2, null);
				if (skillEffectDesc == null)
				{
					return "";
				}
				List<string> list3 = new List<string>();
				if ((skillEffectDesc.TargetFilter & 1) != 0)
				{
					list3.Add("自己");
				}
				if ((skillEffectDesc.TargetFilter & 2) != 0)
				{
					list3.Add("队友");
				}
				if ((skillEffectDesc.TargetFilter & 4) != 0)
				{
					list3.Add("敌人");
				}
				list2.Add("命中" + string.Join("、", list3) + "后对其触发");
				switch (skillEffectDesc.EffectType)
				{
				case EBuffAndSkillEffectType.SkillDamage:
				{
					list2.Add(item2.ToString());
					if (skillEffectDesc.EffectParamsStr.Count > 0)
					{
						list2.Add((skillEffectDesc.EffectParamsStr[0].ToString() == "无") ? "无霸体护甲伤害" : skillEffectDesc.EffectParamsStr[0].ToString());
					}
					else
					{
						list2.Add("霸体护甲伤害数值 " + skillEffectDesc.EffectParamsFloat[0]);
						list2.Add("【Warning】请尽早把霸体护甲伤害改成文字式描述");
					}
					list2.Add("硬直效果ID " + skillEffectDesc.EffectParamsInt[1]);
					FUStSkillDamageExpandDesc originalSkillDamageExpandDesc = BGW_GameDB.GetOriginalSkillDamageExpandDesc(item2);
					if (originalSkillDamageExpandDesc != null && originalSkillDamageExpandDesc.HitWeightGearType == EHitWeightGearType.MustDefeatHitWeight)
					{
						list2.Add("击破TTTB");
					}
					else
					{
						list2.Add("无视TTTB（偏移）");
					}
					if (skillEffectDesc.EffectParamsInt.Count > 5 && skillEffectDesc.EffectParamsInt[5] > 0)
					{
						list2.Add(GetEnumDisplayName((EAbnormalStateType)skillEffectDesc.EffectParamsInt[5]).Substring(0, 1) + "属性");
						list2.Add("属性伤害比例：" + skillEffectDesc.EffectParamsInt[4] * 25 + "%");
						flag3 = true;
					}
					else
					{
						list2.Add("纯物理伤害");
					}
					if (originalSkillDamageExpandDesc != null && originalSkillDamageExpandDesc.PillarFormTerminatorType != EPillarFormTerminatorType.None)
					{
						list.Add("撑棍终结者:" + GetEnumDisplayName(originalSkillDamageExpandDesc.PillarFormTerminatorType));
					}
					break;
				}
				case EBuffAndSkillEffectType.AccumulateAbnormalValue:
					list2.Add(SolveEffectByID(item2));
					if (skillEffectDesc.EffectParamsInt[0] < 5 && skillEffectDesc.EffectParamsInt[0] > 0)
					{
						flag2 = true;
					}
					break;
				default:
					list2.Add(SolveEffectByID(item2));
					break;
				}
				StringBuilderExtensions.AppendLine(stringBuilder, 1, string.Join("\t", list2));
			}
			if (flag2 != flag3)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Error】异常属性累积" + (flag2 ? "配了" : "没配") + "但是属性伤害" + (flag3 ? "配了" : "没配") + "！");
			}
			foreach (int item3 in BGW_GameDB.GetBulletExpandDesc(BulletID).LifeOverEffectID)
			{
				if (item3 != 9999)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 1, "子弹生命结束后\t" + SolveEffectByID(item3));
				}
			}
		}
		return stringBuilder.ToString();
	}

	private static string SolveSpawnBulletByEventList(List<FAnimNotifyEvent> EventList)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			BANS_GSSpawnBullets bANS_GSSpawnBullets = Event.NotifyStateClass as BANS_GSSpawnBullets;
			if (bANS_GSSpawnBullets != null)
			{
				StringBuilder stringBuilder = new StringBuilder();
				StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSpawnBulletByBulletID(bANS_GSSpawnBullets.BulletID));
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "生成基准：" + GetEnumDisplayName(bANS_GSSpawnBullets.SpawnBase.BaseType) + "\t生成偏移：" + GetEnumDisplayName(bANS_GSSpawnBullets.SpawnPosOffsetInfo.PosOffsetType) + "\t生成数量：" + bANS_GSSpawnBullets.BulletWave + "*" + bANS_GSSpawnBullets.BulletNumInOneWave);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "目标基准：" + GetEnumDisplayName(bANS_GSSpawnBullets.TargetBase.BaseType) + "\t目标偏移：" + GetEnumDisplayName(bANS_GSSpawnBullets.TargetPosOffsetInfo.PosOffsetType));
				if (dictionary.ContainsKey(stringBuilder.ToString()))
				{
					dictionary[stringBuilder.ToString()]++;
				}
				else
				{
					dictionary[stringBuilder.ToString()] = 1;
				}
			}
		}
		StringBuilder stringBuilder2 = new StringBuilder();
		foreach (KeyValuePair<string, int> item in dictionary)
		{
			StringBuilderExtensions.AppendLine(stringBuilder2, 0, "[*" + item.Value + "] " + item.Key);
		}
		if (stringBuilder2.Length > 0)
		{
			StringBuilder stringBuilder3 = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder3, 0, "SpawnBullets:");
			StringBuilderExtensions.AppendLine(stringBuilder3, 1, stringBuilder2.ToString());
			return stringBuilder3.ToString();
		}
		return "";
	}

	private static string SolveSpawnProjectile(string DAPath)
	{
		BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = UEditorAssetLibrary.LoadAsset(DAPath) as BGWDataAsset_ProjectileSpawnConfig;
		if (bGWDataAsset_ProjectileSpawnConfig != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, SolveSpawnBulletByBulletID(bGWDataAsset_ProjectileSpawnConfig.ProjectileID));
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "生成基准：" + GetEnumDisplayName(bGWDataAsset_ProjectileSpawnConfig.SpawnBase.BaseType) + "\t生成偏移：" + GetEnumDisplayName(bGWDataAsset_ProjectileSpawnConfig.SpawnPosOffsetInfo.PosOffsetType) + "\t生成数量：" + bGWDataAsset_ProjectileSpawnConfig.ProjectileWave + "*" + bGWDataAsset_ProjectileSpawnConfig.ProjectileNumInOneWave);
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "目标基准：" + GetEnumDisplayName(bGWDataAsset_ProjectileSpawnConfig.TargetBase.BaseType) + "\t目标偏移：" + GetEnumDisplayName(bGWDataAsset_ProjectileSpawnConfig.TargetPosOffsetInfo.PosOffsetType));
			return stringBuilder.ToString();
		}
		return "【Error】DA " + DAPath + " 不存在，请检查配置！";
	}

	private static string SolveDestroyProjectileByID(List<FAnimNotifyEvent> EventList)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			b1.BAN_GSDestroyProjectileByID bAN_GSDestroyProjectileByID = Event.Notify as b1.BAN_GSDestroyProjectileByID;
			if (bAN_GSDestroyProjectileByID != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "DestroyProjectileByID:");
				StringBuilderExtensions.AppendLine(stringBuilder, 1, string.Join(" | ", bAN_GSDestroyProjectileByID.ProjetcileIDList));
			}
		}
		return stringBuilder.ToString();
	}

	private static string SolveSwitchCollisionProfile(List<FAnimNotifyEvent> EventList)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			b1.BANS_GSSwitchCollisionProfile bANS_GSSwitchCollisionProfile = Event.NotifyStateClass as b1.BANS_GSSwitchCollisionProfile;
			if (!(bANS_GSSwitchCollisionProfile != null))
			{
				continue;
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "SwitchCollisionProfile:");
			foreach (CollisionProfileInfo profile in bANS_GSSwitchCollisionProfile.ProfileList)
			{
				ECollisionBodyType type = profile.Type;
				string text = type.ToString();
				FName profileName = profile.ProfileName;
				StringBuilderExtensions.AppendLine(stringBuilder, 1, text + " -> " + profileName.ToString());
			}
		}
		return stringBuilder.ToString();
	}

	private static string SolveCollisionResponseToChannel(List<FAnimNotifyEvent> EventList)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			b1.BANS_GSCollisionResponseToChannel bANS_GSCollisionResponseToChannel = Event.NotifyStateClass as b1.BANS_GSCollisionResponseToChannel;
			if (!(bANS_GSCollisionResponseToChannel != null))
			{
				continue;
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "CollisionResponseToChannel:");
			if (bANS_GSCollisionResponseToChannel.ApplyToCapsule)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "设置胶囊体：");
				foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item in bANS_GSCollisionResponseToChannel.ChannelResponseType)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, item.Key.ToString() + " -> " + item.Value);
				}
			}
			if (bANS_GSCollisionResponseToChannel.ApplyToCapsule)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "设置Mesh：");
				foreach (KeyValuePair<ECollisionChannel, ECollisionResponseType> item2 in bANS_GSCollisionResponseToChannel.MeshChannelResponseType)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, item2.Key.ToString() + " -> " + item2.Value);
				}
			}
			if (bANS_GSCollisionResponseToChannel.bNotReset)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "Notify结束后，这些Channel维持新设置的Response");
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "Notify结束后，这些Channel重置为先前的Response");
			}
		}
		return stringBuilder.ToString();
	}

	private static string SolveNotifyType(List<FAnimNotifyEvent> EventList)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			string item;
			try
			{
				item = ((Event.Notify != null) ? Event.Notify.GetClass().GetName() : Event.NotifyStateClass.GetClass().GetName());
			}
			catch
			{
				item = "【Warning】异常类型" + Event.NotifyName.ToString() + "，请策划确认是否有用";
			}
			if (!SolvedNotify.Contains(item))
			{
				ListExtensions.AddUnique(list, item);
			}
		}
		list.Sort();
		StringBuilder stringBuilder = new StringBuilder();
		if (list.Count > 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "未解析但特殊的Notify类型:");
			StringBuilderExtensions.AppendLine(stringBuilder, 1, string.Join(" | ", list));
		}
		return stringBuilder.ToString();
	}

	private static string SolveSkillSuperArmor(List<FAnimNotifyEvent> EventList, int? SkillID = null)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			b1.BANS_GSSetSkillSuperArmor bANS_GSSetSkillSuperArmor = Event.NotifyStateClass as b1.BANS_GSSetSkillSuperArmor;
			if (!(bANS_GSSetSkillSuperArmor != null))
			{
				continue;
			}
			if (bANS_GSSetSkillSuperArmor.SkillSuperArmorLevel.DescID >= 0)
			{
				FUStSuperArmorLevelDesc superArmorLevelDescByID = BGW_GameDB.GetSuperArmorLevelDescByID(bANS_GSSetSkillSuperArmor.SkillSuperArmorLevel.DescID);
				if (superArmorLevelDescByID != null)
				{
					list.Add(superArmorLevelDescByID.SuperArmorLevelName);
					goto IL_0098;
				}
			}
			list.Add((bANS_GSSetSkillSuperArmor.SkillSuperArmorValue < 0f) ? "【Error】霸体护甲填了负数，未生效，请检查配置！" : ("【Warning】霸体护甲值为 " + bANS_GSSetSkillSuperArmor.SkillSuperArmorValue + " 请改为文字描述式的标准填法！"));
			goto IL_0098;
			IL_0098:
			if (bANS_GSSetSkillSuperArmor.SSABreakAssignedAnim != null)
			{
				string text = bANS_GSSetSkillSuperArmor.SSABreakAssignedAnim.GetPathName().Split('.').Last();
				list.Add("霸体护甲破碎动画\t" + text);
			}
			else if (SkillID.HasValue && GameDBRuntime.GetFUStSkillSDesc(SkillID.Value).SkillArmorBrokeMontage != "")
			{
				list.Add("霸体护甲破碎动画\t" + GameDBRuntime.GetFUStSkillSDesc(SkillID.Value).SkillArmorBrokeMontage.Split('.').Last().Trim('\''));
			}
			else if (SkillID.HasValue)
			{
				_ = GameDBRuntime.GetFUStSkillSDesc(SkillID.Value).SkillArmorBrokeMontage == "";
			}
		}
		if (list.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "SetSkillSuperArmor:");
			foreach (string item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	private static string SolveEffectByEventList(List<FAnimNotifyEvent> EventList)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			BANS_GSTriggerEffect bANS_GSTriggerEffect = Event.NotifyStateClass as BANS_GSTriggerEffect;
			if (bANS_GSTriggerEffect != null)
			{
				list.Add(SolveEffectByID(bANS_GSTriggerEffect.EffectID, bANS_GSTriggerEffect.NotifyStateNameForShow.ToString()));
			}
			BAN_GSTriggerEffect bAN_GSTriggerEffect = Event.Notify as BAN_GSTriggerEffect;
			if (bAN_GSTriggerEffect != null)
			{
				list.Add(SolveEffectByID(bAN_GSTriggerEffect.EffectID, bAN_GSTriggerEffect.NotifyNameForShow.ToString()));
			}
		}
		if (list.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "TriggerEffect:");
			foreach (string item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	private static string SolveHandleBattleMessage(List<FAnimNotifyEvent> EventList)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			b1.BANS_GSHandleBattleMessage bANS_GSHandleBattleMessage = Event.Notify as b1.BANS_GSHandleBattleMessage;
			if (bANS_GSHandleBattleMessage != null)
			{
				_ = bANS_GSHandleBattleMessage.NotifyNameForShow;
				list.Add(bANS_GSHandleBattleMessage.BattleMessage.TagName.ToString() + "\t" + bANS_GSHandleBattleMessage.NotifyNameForShow.ToString());
			}
		}
		if (list.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "HandleBattleMessage:");
			foreach (string item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	private static string SolveSummonUnit(List<FAnimNotifyEvent> EventList)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			if (Event.Notify as BAN_GSSummonUnit != null)
			{
				BAN_GSSummonUnit bAN_GSSummonUnit = Event.Notify as BAN_GSSummonUnit;
				int resID = GameDBRuntime.GetFUStSummonCommDesc(bAN_GSSummonUnit.SummonID).ResID;
				string text = GameDBRuntime.GetFUStSummonCommDesc(bAN_GSSummonUnit.SummonID).SummonTamerTemplatePath.Split('.').Last();
				text = text.Substring(0, text.Length - 2);
				UBlueprint Blueprint;
				BUTamerActor bUTamerActor = UGSE_EditorFuncLib.AssetPath_GetCDO(null, GameDBRuntime.GetFUStSummonCommDesc(bAN_GSSummonUnit.SummonID).SummonTamerTemplatePath.TrimEnd('_', 'C'), out Blueprint) as BUTamerActor;
				FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID == 0) ? BGW_GameDB.GetUnitCommDesc(resID).DefaultBattleInfoExtendID : bUTamerActor.ConfigInfoComp.UnitCDesc.OverrideID);
				List<string> values = new List<string>
				{
					resID.ToString(),
					text,
					(unitBattleInfoExtendDesc.DropRule.Count > 0) ? "【Error】死后产生掉落物！" : "死后无掉落物",
					(unitBattleInfoExtendDesc.NoDropExpAndSprit == EGSYesNo.Yes) ? "死后不掉经验和灵韵" : "【Error】死后掉落经验和灵韵！"
				};
				list.Add(string.Join("\t", values));
			}
		}
		if (list.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "SummonUnit:");
			foreach (string item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	private static string SolveMiscNotifyExists(List<FAnimNotifyEvent> EventList)
	{
		HashSet<string> hashSet = new HashSet<string>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		foreach (FAnimNotifyEvent Event in EventList)
		{
			if (Event.NotifyStateClass as b1.BANS_GSSyncAnimations != null)
			{
				hashSet.Add("这是一个抓投技能，请仔细检查各种异常：如抓投致死，抓出空气墙，抓投镜头切换等");
				flag3 = true;
			}
			if (Event.NotifyStateClass as b1.BANS_GSPreMontageSectionJumpDetection != null && (Event.NotifyStateClass as b1.BANS_GSPreMontageSectionJumpDetection).bForceSuccess)
			{
				hashSet.Add("这个抓投技能是强制命中的，请检查各种边界条件，远处的主角是否会强行被抓回来");
			}
			if (Event.Notify as BAN_GSPlayCameraShake != null)
			{
				hashSet.Add("【Warning】这个技能使用了BAN_GSPlayCameraShake（Notify），建议改为BANS_GSPlayCameraShake（NotifyState！），可以更好地应对打断情况！");
			}
			if (Event.NotifyStateClass as BANS_GSSweepCheck != null)
			{
				flag2 = true;
			}
			if (Event.NotifyStateClass as b1.BANS_GSAttackWarnning != null)
			{
				flag = true;
			}
			if (Event.NotifyStateClass as b1.BANS_GSProcessDeathInASS != null)
			{
				flag4 = true;
			}
		}
		if (flag2 && !flag)
		{
			hashSet.Add("【Warning】这个技能具有SweepCheck，但没有配置精确闪避！");
		}
		if (flag3)
		{
			if (flag4)
			{
				hashSet.Add("抓投中 处理了 主角被直接抓死的情况，请试试看效果");
			}
			else
			{
				hashSet.Add("【Warning】抓投中 未处理 主角被直接抓死的情况，请试试看效果！");
			}
		}
		if (hashSet.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "注意项：");
			foreach (string item in hashSet)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	private static string SolveBuffByEventList(List<FAnimNotifyEvent> EventList)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			BANS_GSAddBuff bANS_GSAddBuff = Event.NotifyStateClass as BANS_GSAddBuff;
			if (bANS_GSAddBuff != null)
			{
				int buffID = (int)bANS_GSAddBuff.BuffID;
				FUStBuffDesc fUStBuffDesc = GameDBRuntime.GetFUStBuffDesc(buffID);
				if (fUStBuffDesc != null)
				{
					string text = ((!bANS_GSAddBuff.UseBuffDescDuration) ? "持续到Notify结束" : ((fUStBuffDesc.Duration != -1) ? ("持续时间为" + fUStBuffDesc.Duration / 1000 + "s") : "持续到永久，通过其他方式移除"));
					StringBuilderExtensions.AppendLine(stringBuilder, 0, "+" + buffID + "\t添加" + bANS_GSAddBuff.BuffLayer + "层\t" + text + "\t" + ((bANS_GSAddBuff.NotifyStateNameForShow.ToString() == "None") ? "策划未注释用途" : bANS_GSAddBuff.NotifyStateNameForShow.ToString()));
					StringBuilderExtensions.AppendLine(stringBuilder, 1, SolveBuffByID(buffID));
				}
				else
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 0, "+" + buffID + "\t" + ((bANS_GSAddBuff.NotifyStateNameForShow.ToString() == "None") ? "策划未注释用途" : bANS_GSAddBuff.NotifyStateNameForShow.ToString()));
					StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Error】此Buff在Buff表中不存在，请检查！");
				}
			}
			BANS_GSAddBuffByID bANS_GSAddBuffByID = Event.NotifyStateClass as BANS_GSAddBuffByID;
			if (bANS_GSAddBuffByID != null)
			{
				int buffID2 = bANS_GSAddBuffByID.BuffID;
				FUStBuffDesc fUStBuffDesc2 = GameDBRuntime.GetFUStBuffDesc(buffID2);
				if (fUStBuffDesc2 != null)
				{
					string text2 = ((!bANS_GSAddBuffByID.UseBuffDescDuration) ? "持续到Notify结束" : ((fUStBuffDesc2.Duration != -1) ? ("持续时间为" + fUStBuffDesc2.Duration / 1000 + "s") : "持续到永久，通过其他方式移除"));
					StringBuilderExtensions.AppendLine(stringBuilder, 0, "+" + buffID2 + "\t添加" + bANS_GSAddBuffByID.BuffLayer + "层\t" + text2 + "\t" + ((bANS_GSAddBuffByID.NotifyStateNameForShow.ToString() == "None") ? "策划未注释用途" : bANS_GSAddBuffByID.NotifyStateNameForShow.ToString()));
					StringBuilderExtensions.AppendLine(stringBuilder, 1, SolveBuffByID(buffID2));
				}
				else
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 0, "+" + buffID2 + "\t" + ((bANS_GSAddBuffByID.NotifyStateNameForShow.ToString() == "None") ? "策划未注释用途" : bANS_GSAddBuffByID.NotifyStateNameForShow.ToString()));
					StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Error】此Buff在Buff表中不存在，请检查！");
				}
			}
			b1.BAN_GSRemoveBuffByID bAN_GSRemoveBuffByID = Event.Notify as b1.BAN_GSRemoveBuffByID;
			if (!(bAN_GSRemoveBuffByID != null))
			{
				continue;
			}
			int buffID3 = bAN_GSRemoveBuffByID.BuffID;
			if (GameDBRuntime.GetFUStBuffDesc(buffID3) != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "-" + buffID3 + "\t移除" + bAN_GSRemoveBuffByID.BuffLayer + "层\t" + ((bAN_GSRemoveBuffByID.NotifyNameForShow.ToString() == "None") ? "策划未注释用途" : bAN_GSRemoveBuffByID.NotifyNameForShow.ToString()));
				if (bAN_GSRemoveBuffByID.WithTriggerRemmoveEffect)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 1, SolveBuffByID(buffID3, IsRemove: true));
				}
				else
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 1, "Buff移除时不触发Remove效果");
				}
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, "-" + buffID3 + "\t移除" + bAN_GSRemoveBuffByID.BuffLayer + "层\t" + ((bAN_GSRemoveBuffByID.NotifyNameForShow.ToString() == "None") ? "策划未注释用途" : bAN_GSRemoveBuffByID.NotifyNameForShow.ToString()));
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Error】此Buff在Buff表中不存在，请检查！");
			}
		}
		if (stringBuilder.Length != 0)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder2, 0, "Buff:");
			StringBuilderExtensions.AppendLine(stringBuilder2, 1, stringBuilder.ToString());
			return stringBuilder2.ToString();
		}
		return "";
	}

	private static string SolveBuffByID(int BuffID, bool IsRemove = false, bool IsNeedProvideTime = false)
	{
		StringBuilder stringBuilder = new StringBuilder();
		FUStBuffDesc fUStBuffDesc = GameDBRuntime.GetFUStBuffDesc(BuffID);
		if (fUStBuffDesc == null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "【Error】Buff " + BuffID + " 在Buff表中不存在，请检查！");
			return stringBuilder.ToString();
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 0, fUStBuffDesc.BuffTips);
		if (SolvedBuff.Contains(BuffID))
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "此Buff详细信息已经解析过，请搜索上文");
			return stringBuilder.ToString();
		}
		SolvedBuff.Add(BuffID);
		List<string> list = new List<string>();
		if ((fUStBuffDesc.TargetFilter & 1) != 0)
		{
			list.Add("自己");
		}
		if ((fUStBuffDesc.TargetFilter & 2) != 0)
		{
			list.Add("队友");
		}
		if ((fUStBuffDesc.TargetFilter & 4) != 0)
		{
			list.Add("敌人");
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "所属Effect目标为" + string.Join("、", list));
		if (IsNeedProvideTime)
		{
			string value = ((fUStBuffDesc.Duration != -1) ? ("持续时间为" + fUStBuffDesc.Duration / 1000 + "s") : "持续到永久，通过其他方式移除");
			StringBuilderExtensions.AppendLine(stringBuilder, 0, value);
		}
		if (fUStBuffDesc.BuffEffects.Count == 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "无Effect，用于标识怪物状态，供其他机制识别");
		}
		foreach (FUStBuffEffectAttr buffEffect in fUStBuffDesc.BuffEffects)
		{
			if (buffEffect.EffectType == EBuffAndSkillEffectType.AddBuff)
			{
				if (buffEffect.EffectTrigger == EBuffEffectTriggerType.Time)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 0, "每隔" + fUStBuffDesc.Interval / 1000 + "s\t" + buffEffect.EffectType);
				}
				else
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 0, buffEffect.EffectTrigger.ToString() + "时\t" + buffEffect.EffectType);
				}
				for (int i = 0; i < buffEffect.EffectParams.Count; i++)
				{
					int num = buffEffect.EffectParams[i];
					FUStBuffDesc fUStBuffDesc2 = GameDBRuntime.GetFUStBuffDesc(num);
					if (fUStBuffDesc2 != null)
					{
						List<string> list2 = new List<string>();
						if ((fUStBuffDesc2.TargetFilter & 1) != 0)
						{
							list2.Add("自己");
						}
						if ((fUStBuffDesc2.TargetFilter & 2) != 0)
						{
							list2.Add("队友");
						}
						if ((fUStBuffDesc2.TargetFilter & 4) != 0)
						{
							list2.Add("敌人");
						}
						StringBuilderExtensions.AppendLine(stringBuilder, 1, string.Concat(str3: (buffEffect.EffectParamsFloat.Count <= i) ? "【Warning】持续时间为0，请检查配置" : ((buffEffect.EffectParamsFloat[i] != 0f) ? ("持续时间为" + buffEffect.EffectParamsFloat[i] / 1000f + "s") : ((fUStBuffDesc2.Duration != -1) ? ("持续时间为" + (float)fUStBuffDesc2.Duration / 1000f + "s") : "持续到永久，通过其他方式移除")), str0: "+", str1: num.ToString(), str2: "\t添加1层\t"));
						StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveBuffByID(num));
					}
					else
					{
						StringBuilderExtensions.AppendLine(stringBuilder, 1, "+" + num + "\t【Error】Buff在表中不存在！");
					}
				}
				continue;
			}
			if (buffEffect.EffectType == EBuffAndSkillEffectType.RemoveBuff)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, buffEffect.EffectTrigger.ToString() + "时\t" + buffEffect.EffectType);
				if (buffEffect.EffectParams.Count != buffEffect.EffectParamsFloat.Count)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 1, "【Error】Buff参数数量和Layer参数数量不相等，不会执行Remove逻辑");
					continue;
				}
				for (int j = 0; j < buffEffect.EffectParams.Count; j++)
				{
					int num2 = buffEffect.EffectParams[j];
					if (GameDBRuntime.GetFUStBuffDesc(num2) != null)
					{
						string text = "移除" + buffEffect.EffectParamsFloat[j] + "层\t" + ((num2 < 0) ? "不触发RemoveEffect" : "正常触发RemoveEffect");
						StringBuilderExtensions.AppendLine(stringBuilder, 1, "-" + FMath.Abs(num2) + "\t" + text);
						StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveBuffByID(num2));
					}
					else
					{
						StringBuilderExtensions.AppendLine(stringBuilder, 1, "-" + num2 + "\t【Error】Buff在表中不存在！");
					}
				}
				continue;
			}
			string text2 = "";
			switch (buffEffect.EffectType)
			{
			case EBuffAndSkillEffectType.SetSimpleState:
			{
				List<string> list4 = new List<string>();
				foreach (int effectParam in buffEffect.EffectParams)
				{
					list4.Add(GetEnumDisplayName((EBGUSimpleState)effectParam));
				}
				text2 = string.Join(" | ", list4);
				if (list4.Count == 0)
				{
					text2 = "策划未填参数，无效果";
				}
				break;
			}
			case EBuffAndSkillEffectType.SwitchCollisionProfile:
			{
				List<string> list6 = new List<string>();
				foreach (string item in buffEffect.EffectParamsString)
				{
					list6.Add(item);
				}
				using (IEnumerator<int> enumerator2 = buffEffect.EffectParams.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						switch (enumerator2.Current)
						{
						case 1:
							list6.Add("胶囊体");
							break;
						case 2:
							list6.Add("SKMesh");
							break;
						default:
							list6.Add("【Error】参数有误，既不是胶囊体也不是SKMesh");
							break;
						}
					}
				}
				text2 = string.Join(" | ", list6);
				if (list6.Count == 0)
				{
					text2 = "策划未填参数，无效果";
				}
				break;
			}
			case EBuffAndSkillEffectType.SwitchCollisionHitMove:
			{
				List<string> list5 = new List<string>();
				using (IEnumerator<int> enumerator2 = buffEffect.EffectParams.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						switch (enumerator2.Current)
						{
						case 0:
							list5.Add("关闭");
							break;
						case 2:
							list5.Add("开启");
							break;
						default:
							list5.Add("【Error】参数有误，既不关闭也不开启");
							break;
						}
					}
				}
				foreach (string item2 in buffEffect.EffectParamsString)
				{
					list5.Add(item2);
				}
				text2 = string.Join(" | ", list5);
				if (list5.Count == 0)
				{
					text2 = "策划未填参数，无效果";
				}
				break;
			}
			case EBuffAndSkillEffectType.EnableCollisionChanel:
			{
				List<string> list3 = new List<string>();
				if (buffEffect.EffectParams.Count > 0)
				{
					switch (buffEffect.EffectParams[0])
					{
					case 0:
						list3.Add("子弹");
						break;
					case 1:
						list3.Add("角色");
						break;
					default:
						list3.Add("【Error】参数有误，既不是子弹也不是角色");
						break;
					}
				}
				if (buffEffect.EffectParams.Count > 1)
				{
					switch (buffEffect.EffectParams[1])
					{
					case 0:
						list3.Add("关闭");
						break;
					case 1:
						list3.Add("开启");
						break;
					default:
						list3.Add("【Error】参数有误，既不关闭也不开启");
						break;
					}
				}
				if (buffEffect.EffectParamsFloat.Count > 0)
				{
					float num4 = buffEffect.EffectParamsFloat[0];
					if (num4 != 0f)
					{
						if (num4 == 1f)
						{
							list3.Add("SKMesh");
						}
						else
						{
							list3.Add("【Error】参数有误，既不是胶囊体也不是SKMesh");
						}
					}
					else
					{
						list3.Add("胶囊体");
					}
				}
				for (int k = 2; k < buffEffect.EffectParams.Count; k++)
				{
					list3.Add(GetEnumDisplayName((ECollisionChannel)buffEffect.EffectParams[k]));
				}
				text2 = string.Join(" | ", list3);
				if (list3.Count == 0)
				{
					text2 = "策划未填参数，无效果";
				}
				break;
			}
			case EBuffAndSkillEffectType.SwitchStateLib:
				if (buffEffect.EffectParams.Count > 0 && buffEffect.EffectParamsString.Count > 0)
				{
					string text5 = "切换到 " + buffEffect.EffectParamsString[0].Split('.').Last().Trim('\'');
					b1.BUS_StateLibComp.StateType stateTypes = (b1.BUS_StateLibComp.StateType)buffEffect.EffectParams[0];
					text2 = text5 + "\t" + SolveSwitchStateLibTypes(stateTypes);
				}
				else
				{
					text2 = "【Error】Effect SwitchStateLib 填表错误，EffectParamsString或EffectParams参数数量为0，无法读取到StateLib信息!";
				}
				break;
			case EBuffAndSkillEffectType.AddAttr:
			case EBuffAndSkillEffectType.RecoverAttr:
				if (buffEffect.EffectParams.Count >= 3)
				{
					string text7 = ((buffEffect.EffectType == EBuffAndSkillEffectType.AddAttr) ? "增加" : "恢复");
					string enumDisplayName = GetEnumDisplayName((EBGUAttrFloat)buffEffect.EffectParams[0]);
					string text8 = buffEffect.EffectParams[1].ToString();
					string text9 = ((buffEffect.EffectParams[2] == 0) ? "绝对值" : "万分比");
					text2 = $"{text7}属性ID {buffEffect.EffectParams[0].ToString()}({enumDisplayName})的{text9}{text8}";
					if (buffEffect.EffectParams.Count >= 4)
					{
						string text10 = buffEffect.EffectParams[3].ToString();
						text2 = text2 + ", FixFuncID（补正函数）为 " + text10.ToString();
					}
				}
				else
				{
					text2 = "【Error】Buff表中填写的参数至少为3，请检查！";
				}
				break;
			case EBuffAndSkillEffectType.SpawnProjectile:
			{
				string text6 = buffEffect.EffectParamsString[0];
				text2 = text6.Split('.').Last().Trim('\'');
				StringBuilder stringBuilder2 = new StringBuilder();
				StringBuilderExtensions.AppendLine(stringBuilder2, 0, buffEffect.EffectTrigger.ToString() + "时\t" + buffEffect.EffectType.ToString() + "\t" + text2);
				StringBuilderExtensions.AppendLine(stringBuilder2, 1, SolveSpawnProjectile(text6));
				StringBuilderExtensions.AppendLine(stringBuilder, 0, stringBuilder2.ToString());
				continue;
			}
			case EBuffAndSkillEffectType.SetPartActive:
			{
				int num3 = buffEffect.EffectParams[0];
				string text4 = ((buffEffect.EffectParams[1] == 0) ? "不激活" : "激活");
				text2 = "部位" + num3 + "\t" + text4;
				break;
			}
			case EBuffAndSkillEffectType.SwitchBehaviorTree:
			{
				string text3 = buffEffect.EffectParamsString[0].Split('.').Last().Trim('\'');
				text2 = "切换到行为树 " + text3;
				break;
			}
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 0, buffEffect.EffectTrigger.ToString() + "时\t" + buffEffect.EffectType.ToString() + "\t" + text2);
		}
		return stringBuilder.ToString();
	}

	private static string SolveNotifyBehaviorGraph(List<FAnimNotifyEvent> EventList)
	{
		List<string> list = new List<string>();
		foreach (FAnimNotifyEvent Event in EventList)
		{
			BAN_GSNotifyBehaviorGraph bAN_GSNotifyBehaviorGraph = Event.Notify as BAN_GSNotifyBehaviorGraph;
			if (bAN_GSNotifyBehaviorGraph != null)
			{
				_ = bAN_GSNotifyBehaviorGraph.NotifyNameForShow;
				list.Add(bAN_GSNotifyBehaviorGraph.NotifyTag.ToString() + "\t" + ((bAN_GSNotifyBehaviorGraph.NotifyNameForShow.ToString() == "None") ? "策划未注释" : bAN_GSNotifyBehaviorGraph.NotifyNameForShow.ToString()));
			}
		}
		if (list.Count != 0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "NotifyBehaviorGraph:");
			foreach (string item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 1, item);
			}
			return stringBuilder.ToString();
		}
		return "";
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeBattle")]
	public static string QADescribeBattle(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【005-战斗流程】");
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【CBG】所有分支流程检查");
		int behaviorGraphTemplateID = TM.ExtendConfigComp.BehaviorGraphTemplateID;
		if (behaviorGraphTemplateID == 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "Tamer上没有配置CBG，请以实例上有无CBG为准");
		}
		else
		{
			FUStCBGTemplateDesc cBGTemplateDesc = BGW_GameDB.GetCBGTemplateDesc(behaviorGraphTemplateID);
			object obj;
			if (cBGTemplateDesc == null)
			{
				obj = null;
			}
			else
			{
				string path = cBGTemplateDesc.Path;
				obj = ((path != null) ? GameplayTagExtension.LoadGraph(path) : null);
			}
			FCalliopeGraph fCalliopeGraph = (FCalliopeGraph)obj;
			if (fCalliopeGraph != null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, cBGTemplateDesc.Path.Split('.').Last().Trim('\'') + " 中提取到的消息：");
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveAMNotify(fCalliopeGraph));
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveFSMEvent(fCalliopeGraph));
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveFSMState(fCalliopeGraph));
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveCBGHandleMessage(fCalliopeGraph));
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveCBGBuff(fCalliopeGraph));
				StringBuilderExtensions.AppendLine(stringBuilder, 3, SolveCBGEffect(fCalliopeGraph));
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Error】填入的CBG ID " + behaviorGraphTemplateID + " 找不到对应的Graph，请检查填表情况！");
			}
		}
		return stringBuilder.ToString();
	}

	private static bool JudgeNodeHasRoot(FCalliopeNode Node)
	{
		if (Node.InputEdges.Count == 0)
		{
			return true;
		}
		foreach (FCalliopeEdge inputEdge in Node.InputEdges)
		{
			if ((inputEdge.From != null) & JudgeNodeHasRoot(inputEdge.From))
			{
				return true;
			}
		}
		return false;
	}

	private static string SolveCastSkill(FCalliopeGraph Graph, List<int> BTSkills)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<int> list = new List<int>();
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if ((node.NodeClass == B1CalliopeDef.BehaviorNode.CastSkill) & JudgeNodeHasRoot(node))
			{
				BehaviorCustom_CastSkill behaviorCustom_CastSkill = QAGetNodeCustomData<BehaviorCustom_CastSkill>(node);
				if (!list.Contains(behaviorCustom_CastSkill.SkillId) && !BTSkills.Contains(behaviorCustom_CastSkill.SkillId))
				{
					list.Add(behaviorCustom_CastSkill.SkillId);
				}
			}
		}
		if (list.Count != 0)
		{
			list.Sort();
			foreach (int item in list)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeAnimBySkillID(item));
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "CBG中不额外释放技能");
		}
		return stringBuilder.ToString();
	}

	private static void SolveCBGAMCombo(FCalliopeNode Node, string PreviousResult)
	{
		if (Node == null)
		{
			ListExtensions.AddUnique(CBGCombos, PreviousResult);
			return;
		}
		if (Node.NodeClass == B1CalliopeDef.BehaviorNode.CastSkill)
		{
			BehaviorCustom_CastSkill behaviorCustom_CastSkill = QAGetNodeCustomData<BehaviorCustom_CastSkill>(Node);
			PreviousResult = PreviousResult + " -> " + behaviorCustom_CastSkill.SkillId;
			if (CBGSkills.ContainsKey(behaviorCustom_CastSkill.SkillId))
			{
				CBGSkills[behaviorCustom_CastSkill.SkillId]++;
			}
			else
			{
				CBGSkills[behaviorCustom_CastSkill.SkillId] = 1;
			}
		}
		if (Node.OutputEdges.Count == 0)
		{
			ListExtensions.AddUnique(CBGCombos, PreviousResult);
			return;
		}
		foreach (KeyValuePair<string, FCalliopeEdge> outputEdge in Node.OutputEdges)
		{
			SolveCBGAMCombo(outputEdge.Value.To, PreviousResult);
		}
	}

	private static string SolveAMNotify(FCalliopeGraph Graph)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【CBG被动监听的动画通知】");
		CBGSkills.Clear();
		bool flag = true;
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if (!(node.NodeClass == B1CalliopeDef.BehaviorNode.AMNotify))
			{
				continue;
			}
			BehaviorCustom_AMNotify behaviorCustom_AMNotify = QAGetNodeCustomData<BehaviorCustom_AMNotify>(node);
			StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_AMNotify.NotifyTag);
			flag = false;
			CBGCombos.Clear();
			SolveCBGAMCombo(node, "");
			foreach (string cBGCombo in CBGCombos)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, cBGCombo);
			}
		}
		if (flag)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "CBG中不监听任何动画通知");
		}
		if (CBGSkills.Count != 0)
		{
			IOrderedEnumerable<KeyValuePair<int, int>> orderedEnumerable = CBGSkills.OrderByDescending((KeyValuePair<int, int> x) => x.Value);
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【CBG技能释放频率排序】");
			bool flag2 = false;
			foreach (KeyValuePair<int, int> item in orderedEnumerable)
			{
				if (item.Value > 1)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, $"{item.Key}\t{item.Value}");
					flag2 = true;
				}
			}
			if (!flag2)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "没有技能在CBG中出现超过1次");
			}
		}
		return stringBuilder.ToString();
	}

	private static string SolveFSMEvent(FCalliopeGraph Graph)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【CBG被动监听的FSMEvent】");
		bool flag = true;
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if (node.NodeClass == B1CalliopeDef.BehaviorNode.OnTrigerFSMEvent)
			{
				BehaviorCustom_OnTrigerFSMEvent behaviorCustom_OnTrigerFSMEvent = QAGetNodeCustomData<BehaviorCustom_OnTrigerFSMEvent>(node);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_OnTrigerFSMEvent.EventName);
				flag = false;
			}
		}
		if (flag)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "CBG不监听任何FSMEvent");
		}
		return stringBuilder.ToString();
	}

	private static string SolveFSMState(FCalliopeGraph Graph)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【CBG被动监听的FSM状态改变】");
		bool flag = true;
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if (node.NodeClass == B1CalliopeDef.BehaviorNode.EnterState)
			{
				BehaviorCustom_EnterState behaviorCustom_EnterState = QAGetNodeCustomData<BehaviorCustom_EnterState>(node);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_EnterState.StateName + "\t监听进入状态");
				flag = false;
			}
		}
		foreach (FCalliopeNode node2 in Graph.Nodes)
		{
			if (node2.NodeClass == B1CalliopeDef.BehaviorNode.ExitState)
			{
				BehaviorCustom_ExitState behaviorCustom_ExitState = QAGetNodeCustomData<BehaviorCustom_ExitState>(node2);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_ExitState.StateName + "\t监听退出状态");
				flag = false;
			}
		}
		if (flag)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "CBG不监听任何FSM状态改变");
		}
		return stringBuilder.ToString();
	}

	private static string SolveCBGHandleMessage(FCalliopeGraph Graph)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【CBG主动发起的BattleMessage】");
		bool flag = true;
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if (node.NodeClass == B1CalliopeDef.BehaviorNode.HandleBattleMessage)
			{
				BehaviorCustom_HandleBattleMessage behaviorCustom_HandleBattleMessage = QAGetNodeCustomData<BehaviorCustom_HandleBattleMessage>(node);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_HandleBattleMessage.MessageContent);
				flag = false;
			}
		}
		if (flag)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "CBG不发起任何BattleMessage");
		}
		return stringBuilder.ToString();
	}

	private static string SolveCBGBuff(FCalliopeGraph Graph)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【CBG中使用到但未解析过的Buff】");
		bool flag = true;
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if (node.NodeClass == B1CalliopeDef.BehaviorNode.AddBuff)
			{
				BehaviorCustom_AddBuff behaviorCustom_AddBuff = QAGetNodeCustomData<BehaviorCustom_AddBuff>(node);
				if (!SolvedBuff.Contains(behaviorCustom_AddBuff.BuffId))
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_AddBuff.BuffId.ToString());
					StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveBuffByID(behaviorCustom_AddBuff.BuffId, IsRemove: false, IsNeedProvideTime: true));
					flag = false;
				}
			}
			if (node.NodeClass == B1CalliopeDef.BehaviorNode.RemoveBuff)
			{
				BehaviorCustom_RemoveBuff behaviorCustom_RemoveBuff = QAGetNodeCustomData<BehaviorCustom_RemoveBuff>(node);
				if (!SolvedBuff.Contains(behaviorCustom_RemoveBuff.BuffId))
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_RemoveBuff.BuffId.ToString());
					StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveBuffByID(behaviorCustom_RemoveBuff.BuffId, IsRemove: false, IsNeedProvideTime: true));
					flag = false;
				}
			}
		}
		if (flag)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "CBG中不存在独有Buff");
		}
		return stringBuilder.ToString();
	}

	private static string SolveCBGEffect(FCalliopeGraph Graph)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【CBG中使用到的Effect】");
		bool flag = true;
		foreach (FCalliopeNode node in Graph.Nodes)
		{
			if (node.NodeClass == B1CalliopeDef.BehaviorNode.TriggerSkillEffect)
			{
				BehaviorCustom_TriggerSkillEffect behaviorCustom_TriggerSkillEffect = QAGetNodeCustomData<BehaviorCustom_TriggerSkillEffect>(node);
				StringBuilderExtensions.AppendLine(stringBuilder, 1, behaviorCustom_TriggerSkillEffect.EffectId.ToString());
				StringBuilderExtensions.AppendLine(stringBuilder, 2, SolveEffectByID(behaviorCustom_TriggerSkillEffect.EffectId));
				flag = false;
			}
		}
		if (flag)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "CBG中不单独使用Effect");
		}
		return stringBuilder.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeCounter")]
	public static string QADescribeCounter(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【006-主角互动】");
		int resID = TM.ConfigInfoComp.UnitCDesc.ResID;
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((TM.ConfigInfoComp.UnitCDesc.OverrideID == 0) ? BGW_GameDB.GetUnitCommDesc(resID).DefaultBattleInfoExtendID : TM.ConfigInfoComp.UnitCDesc.OverrideID);
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【法术对抗】【定身术】定身术初始定身抗性合理");
		StringBuilderExtensions.AppendLine(stringBuilder, 2, "初始抗性（默认为100，越小越难被定住）：" + unitCommDesc.DingShenDef);
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【法术对抗】【定身术】定身破碎血量合理");
		StringBuilderExtensions.AppendLine(stringBuilder, 2, "定身血量占生命万分比：" + unitBattleInfoExtendDesc.ImmobilityHPRadio);
		return stringBuilder.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeBeAttacked")]
	public static string QADescribeBeAttacked(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【007-受击相关】");
		int resID = TM.ConfigInfoComp.UnitCDesc.ResID;
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【受击信息】");
		FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(BGW_GameDB.GetUnitCommDesc(resID).DefaultBeAttackedInfoID);
		BGWDataAsset_UnitBeAttackedConfig bGWDataAsset_UnitBeAttackedConfig = UEditorAssetLibrary.LoadAsset(beAttackedInfoDesc.UnitBeAttackedConfigPath) as BGWDataAsset_UnitBeAttackedConfig;
		if (bGWDataAsset_UnitBeAttackedConfig != null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【默认UBAC】" + beAttackedInfoDesc.UnitBeAttackedConfigPath.Split('.').Last().Trim('\''));
			int unitBeAttackedBlendType = beAttackedInfoDesc.UnitBeAttackedBlendType;
			List<string> list = new List<string>();
			if (beAttackedInfoDesc.UnitBeAttackedBlendType == 0)
			{
				list.Add("无融合受击");
			}
			else
			{
				if ((unitBeAttackedBlendType & 1) != 0)
				{
					list.Add("物理融合受击");
				}
				if ((unitBeAttackedBlendType & 2) != 0)
				{
					list.Add("叠加动画受击");
				}
				if ((unitBeAttackedBlendType & 4) != 0)
				{
					list.Add("材质抖动受击");
				}
				if ((unitBeAttackedBlendType & 8) != 0)
				{
					list.Add("伤痕");
				}
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【受击混合类型】" + string.Join(" | ", list));
			foreach (FNormalStiffInfo normalStiffInfo in bGWDataAsset_UnitBeAttackedConfig.NormalStiffInfoList)
			{
				string text = $"【档位{normalStiffInfo.StiffLevelID}】";
				string text2;
				if (!normalStiffInfo.IsEnableReuse)
				{
					text2 = GetEnumDisplayName(normalStiffInfo.SectorsType) + "\t" + GetEnumDisplayName(normalStiffInfo.EllipsisType) + "\t" + (normalStiffInfo.EnableBeAttackedRotate ? "受击旋转" : "受击不旋转");
				}
				else
				{
					int stiffLevelReuseID = normalStiffInfo.StiffLevelReuseID;
					text2 = "复用档位" + stiffLevelReuseID;
				}
				StringBuilderExtensions.AppendLine(stringBuilder, 2, text + text2);
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "============================================================");
			foreach (UAnimMontage normalStiffAM in bGWDataAsset_UnitBeAttackedConfig.NormalStiffAMList)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, QADescribeAnimByMontage(normalStiffAM));
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【受击】怪物韧性划分合理");
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "怪物韧性为：" + BGW_GameDB.GetUnitCommDesc(resID).DefaultTenacity);
			FGSArmorSettingInBP gSArmorSettingInBP = TM.ExtendConfigComp.GSArmorSettingInBP;
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【受击】怪物具有保底反击技");
			if (gSArmorSettingInBP.Armor_Enable)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "硬直反击计数类型：" + GetEnumDisplayName(gSArmorSettingInBP.BeHitCountType));
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "硬直反击计时：" + gSArmorSettingInBP.Armor_Timer + "\t触发硬直反击的受击数：" + gSArmorSettingInBP.OriBeHitNum_Min + "-" + gSArmorSettingInBP.OriBeHitNum_Max);
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "反击技：");
				foreach (int item in gSArmorSettingInBP.Armor_SkillID)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 3, QADescribeAnimBySkillID(item));
				}
				if (gSArmorSettingInBP.DefaultBlockInfoConfig != null)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, "注意点：" + gSArmorSettingInBP.DefaultBlockInfoConfig.GetName());
					StringBuilderExtensions.AppendLine(stringBuilder, 3, "这个怪有格挡机制，请查阅：" + gSArmorSettingInBP.DefaultBlockInfoConfig.GetName());
				}
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "没有开启硬直反击");
			}
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【受击】检查部位破坏相关情况");
		List<int> partRuleInfoListByResID = BGW_GameDB.GetPartRuleInfoListByResID(resID);
		StringBuilderExtensions.AppendLine(stringBuilder, 2, "默认部位受击规则：" + BGW_GameDB.GetUnitCommDesc(resID).DefaultPartRuleInfoID);
		if (partRuleInfoListByResID.Count == 0)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "此怪没有启用部位特性");
		}
		List<string> list2 = new List<string>();
		foreach (int item2 in partRuleInfoListByResID)
		{
			FUStPartRuleInfoDesc originalPartRuleInfoDesc = BGW_GameDB.GetOriginalPartRuleInfoDesc(item2);
			List<float> list3 = new List<float>();
			for (int i = 0; i < originalPartRuleInfoDesc.PartDamagedInfoList.Count; i++)
			{
				list3.Add(originalPartRuleInfoDesc.PartDamagedInfoList[i].DamagedValueRatio);
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 3, $"{originalPartRuleInfoDesc.PartRuleID}\t{originalPartRuleInfoDesc.PartID}：{originalPartRuleInfoDesc.PartName}");
			StringBuilderExtensions.AppendLine(stringBuilder, 4, (originalPartRuleInfoDesc.DamagedAMDataAssetPath == "") ? "无PBC（无部位破坏动画）" : originalPartRuleInfoDesc.DamagedAMDataAssetPath.Split('.').Last().Trim('\''));
			if (originalPartRuleInfoDesc.ReduceParams.Count > 1)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 4, $"部位被打时，本体额外承伤（万分比）：{originalPartRuleInfoDesc.ReduceParams[1]}");
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 4, $"部位被打时，本体不承伤");
			}
			StringBuilderExtensions.AppendLine(stringBuilder, 4, $"想打出部位破坏，所需硬直等级阈值：{originalPartRuleInfoDesc.PartDamagedStiffLevel} (SL{BGW_GameDB.GetUnitCommDesc(resID).DefaultTenacity + originalPartRuleInfoDesc.PartDamagedStiffLevel})");
			StringBuilderExtensions.AppendLine(stringBuilder, 4, string.Format("部位血量为总血量的（万分比）：{0}", string.Join("\t", list3)));
			if (originalPartRuleInfoDesc.DamagedAMDataAssetPath != "" && !list2.Contains(originalPartRuleInfoDesc.DamagedAMDataAssetPath))
			{
				list2.Add(originalPartRuleInfoDesc.DamagedAMDataAssetPath);
			}
		}
		foreach (string item3 in list2)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 3, item3.Split('.').Last().Trim('\''));
			BGWDataAsset_PartBreakAMInfoConfig bGWDataAsset_PartBreakAMInfoConfig = UEditorAssetLibrary.LoadAsset(item3) as BGWDataAsset_PartBreakAMInfoConfig;
			if (bGWDataAsset_PartBreakAMInfoConfig == null)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 3, "【Error】" + item3 + "\t不存在，请检查PartRule表配置！");
				continue;
			}
			List<UAnimMontage> list4 = new List<UAnimMontage>();
			foreach (FPartDamagedAMInfo partDamagedAMInfo in bGWDataAsset_PartBreakAMInfoConfig.PartDamagedAMInfoList)
			{
				if (partDamagedAMInfo.DamagedAMPathForward != null && !list4.Contains(partDamagedAMInfo.DamagedAMPathForward))
				{
					list4.Add(partDamagedAMInfo.DamagedAMPathForward);
				}
				if (partDamagedAMInfo.DamagedAMPathBackward != null && !list4.Contains(partDamagedAMInfo.DamagedAMPathBackward))
				{
					list4.Add(partDamagedAMInfo.DamagedAMPathBackward);
				}
				if (partDamagedAMInfo.DamagedAMPathLeftSide != null && !list4.Contains(partDamagedAMInfo.DamagedAMPathLeftSide))
				{
					list4.Add(partDamagedAMInfo.DamagedAMPathLeftSide);
				}
				if (partDamagedAMInfo.DamagedAMPathRightSide != null && !list4.Contains(partDamagedAMInfo.DamagedAMPathRightSide))
				{
					list4.Add(partDamagedAMInfo.DamagedAMPathRightSide);
				}
			}
			foreach (UAnimMontage item4 in list4)
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 4, QADescribeAnimByMontage(item4));
			}
		}
		return stringBuilder.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeDeath")]
	public static string QADescribeDeath(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【008-死亡相关】");
		int resID = TM.ConfigInfoComp.UnitCDesc.ResID;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc((TM.ConfigInfoComp.UnitCDesc.OverrideID == 0) ? BGW_GameDB.GetUnitCommDesc(resID).DefaultBattleInfoExtendID : TM.ConfigInfoComp.UnitCDesc.OverrideID);
		FUStUnitDeadDesc unitDeadDesc = BGW_GameDB.GetUnitDeadDesc(resID, BGW_GameDB.GetUnitCommDesc(resID).DeadInfoID);
		if (unitDeadDesc != null)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【死亡信息】");
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【默认UDDC】" + unitDeadDesc.DeathDispConfigPath.Split('.').Last().Trim('\''));
			BGWDataAsset_UnitDeathDispConfig bGWDataAsset_UnitDeathDispConfig = UEditorAssetLibrary.LoadAsset(unitDeadDesc.DeathDispConfigPath) as BGWDataAsset_UnitDeathDispConfig;
			if (bGWDataAsset_UnitDeathDispConfig != null)
			{
				foreach (FNormalDeadAMInfo normalDeadAMInfo in bGWDataAsset_UnitDeathDispConfig.NormalDeadAMInfoList)
				{
					string text = $"【档位{normalDeadAMInfo.StiffLevelID}】";
					string text2;
					if (!normalDeadAMInfo.IsEnableReuse)
					{
						text2 = GetEnumDisplayName(normalDeadAMInfo.SectorsType) + "\t" + GetEnumDisplayName(normalDeadAMInfo.DeadEllipsisType) + "\t" + (normalDeadAMInfo.EnableBeAttackedRotate ? "受击旋转" : "受击不旋转");
					}
					else
					{
						int stiffLevelReuseID = normalDeadAMInfo.StiffLevelReuseID;
						text2 = "复用档位" + stiffLevelReuseID;
					}
					StringBuilderExtensions.AppendLine(stringBuilder, 2, text + text2);
				}
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "============================================================");
				foreach (UAnimMontage normalDeadAM in bGWDataAsset_UnitDeathDispConfig.NormalDeadAMList)
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, QADescribeAnimByMontage(normalDeadAM));
				}
				StringBuilderExtensions.AppendLine(stringBuilder, 1, "【死亡】怪物死亡后表现合乎玩家直觉");
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "死亡后消除盔甲武器时间 " + unitDeadDesc.DelayClearArmorTime);
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "死亡后销毁自身时间 " + unitDeadDesc.DelayDestroyActorTime);
				if (unitDeadDesc.DeadPAPath != "")
				{
					StringBuilderExtensions.AppendLine(stringBuilder, 2, "死亡后切换了PA " + unitDeadDesc.DeadPAPath.Split('.').Last().Trim('\'') + " ，请检查相关效果");
				}
			}
			else
			{
				StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Warning】无法读取UDDC [" + unitDeadDesc.DeathDispConfigPath + "]（方括号内为策划填写的UDDC路径） ，请检查是否有填表错误！");
			}
		}
		else
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 1, "【死亡信息】");
			StringBuilderExtensions.AppendLine(stringBuilder, 2, "【Warning】找不到这个怪物的死亡信息，请检查配表情况！");
		}
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【死亡】死亡后正常产生掉落物");
		StringBuilderExtensions.AppendLine(stringBuilder, 2, (unitBattleInfoExtendDesc.DropRule.Count > 0) ? "死后产生掉落物" : "死后无掉落物");
		StringBuilderExtensions.AppendLine(stringBuilder, 2, (unitBattleInfoExtendDesc.NoDropExpAndSprit == EGSYesNo.Yes) ? "死后不掉经验和灵韵" : "死后正常掉落经验和灵韵");
		return stringBuilder.ToString();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeBattleArena")]
	public static string QADescribeBattleArena(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilderExtensions.AppendLine(stringBuilder, 0, "【009-战斗场地】");
		StringBuilderExtensions.AppendLine(stringBuilder, 1, "【战斗场地】怪能在场地中可互动地表上留下痕迹");
		StringBuilderExtensions.AppendLine(stringBuilder, 2, (TM.ConfigInfoComp.DispInteractBoneMap.Count > 0) ? "行走时可以与地表互动，请按需检查技能和子弹的地表互动情况" : "【Warning】行走时不能与地表互动，请确认其投放区域地表类型，确保不会穿帮");
		return stringBuilder.ToString();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.QATamerDescriber:QADescribeISO")]
	public static string QADescribeISO(BUTamerActor TM)
	{
		StringBuilder stringBuilder = new StringBuilder();
		try
		{
			SolvedBuff.Clear();
			SolvedBullet.Clear();
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "【" + TM.GetOuter().GetPathName().Split('.')
				.Last()
				.Trim('\'')
				.Split('/')
				.Last() + "】");
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeArt(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeEngagement(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeSkill(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeBattle(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeCounter(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeBeAttacked(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeDeath(TM));
			StringBuilderExtensions.AppendLine(stringBuilder, 0, QADescribeBattleArena(TM));
		}
		catch (Exception ex)
		{
			StringBuilderExtensions.AppendLine(stringBuilder, 0, "【Fatal Error】解析过程中出现异常，请将下面的报错信息和Tamer名称发给谭旭处理！");
			StringBuilderExtensions.AppendLine(stringBuilder, 1, ex.ToString());
		}
		return stringBuilder.ToString();
	}

	static QATamerDescriber()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(QATamerDescriber)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(QATamerDescriber));
		SolvedNotify = new List<string>
		{
			"BAN_GSAkEvent", "BANS_GSAttackRotation", "BANS_GSAttackState", "BANS_GSComboWindow", "BANS_GSSpawnBullets", "BANS_GSSetSkillSuperArmor", "BANS_GSHandleBattleMessage", "BAN_GSNotifyBehaviorGraph", "BANS_GSSweepCheck", "BANS_GSAddBuff",
			"BANS_GSAddBuffByID", "BAN_GSRemoveBuffByID", "BANS_GSTriggerEffect", "BAN_GSTriggerEffect", "BAN_GSSummonUnit", "BANS_GSPlayCameraShake", "BANS_GSSyncAnimations", "BAN_GSPlayCameraShake", "BANS_GSProcessDeathInASS", "BANS_GSAttackWarnning",
			"BANS_GSCalcAMScale", "BANS_GSSetAMSpeedRate", "BANS_GSEditorHelper", "GSEditorHelper", "BAN_GSDestroyProjectileByID", "BANS_GSSwitchCollisionProfile", "BANS_GSCollisionResponseToChannel"
		};
		SolvedBullet = new List<int>();
		SolvedBuff = new List<int>();
		CBGCombos = new List<string>();
		CBGSkills = new Dictionary<int, int>();
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeBT")]
	private static void QADescribeBT__Invoker(IntPtr buffer, IntPtr obj)
	{
		UBehaviorTree bT = UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(buffer, QADescribeBT_BT_Offset));
		string value = QADescribeBT(bT);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeBT_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeISO")]
	private static void QADescribeISO__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeISO_TM_Offset));
		string value = QADescribeISO(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeISO_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeArt")]
	private static void QADescribeArt__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeArt_TM_Offset));
		string value = QADescribeArt(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeArt_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeDeath")]
	private static void QADescribeDeath__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeDeath_TM_Offset));
		string value = QADescribeDeath(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeDeath_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeSkill")]
	private static void QADescribeSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeSkill_TM_Offset));
		string value = QADescribeSkill(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeSkill_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeBattle")]
	private static void QADescribeBattle__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeBattle_TM_Offset));
		string value = QADescribeBattle(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeBattle_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QAGetBTTaskNodes")]
	private static void QAGetBTTaskNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		UBehaviorTree bT = UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(buffer, QAGetBTTaskNodes_BT_Offset));
		FBehaviorTreeNodeData value = QAGetBTTaskNodes(bT);
		FBehaviorTreeNodeData.ToNative(IntPtr.Add(buffer, QAGetBTTaskNodes_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeCounter")]
	private static void QADescribeCounter__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeCounter_TM_Offset));
		string value = QADescribeCounter(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeCounter_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeBeAttacked")]
	private static void QADescribeBeAttacked__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeBeAttacked_TM_Offset));
		string value = QADescribeBeAttacked(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeBeAttacked_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeEngagement")]
	private static void QADescribeEngagement__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeEngagement_TM_Offset));
		string value = QADescribeEngagement(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeEngagement_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeBattleArena")]
	private static void QADescribeBattleArena__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, QADescribeBattleArena_TM_Offset));
		string value = QADescribeBattleArena(tM);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeBattleArena_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeAnimByMontage")]
	private static void QADescribeAnimByMontage__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, QADescribeAnimByMontage_Montage_Offset));
		string value = QADescribeAnimByMontage(montage);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeAnimByMontage_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.QATamerDescriber:QADescribeAnimBySkillID")]
	private static void QADescribeAnimBySkillID__Invoker(IntPtr buffer, IntPtr obj)
	{
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, QADescribeAnimBySkillID_SkillID_Offset));
		string value = QADescribeAnimBySkillID(skillID);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, QADescribeAnimBySkillID_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.QATamerDescriber");
		QADescribeBT_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeBT");
		QADescribeBT_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeBT_FunctionAddress);
		QADescribeBT_BT_Offset = NativeReflection.GetPropertyOffset(QADescribeBT_FunctionAddress, "BT");
		QADescribeBT_BT_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBT_FunctionAddress, "BT", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeBT_ReturnValue_PropertyAddress, QADescribeBT_FunctionAddress, "ReturnValue");
		QADescribeBT_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeBT_FunctionAddress, "ReturnValue");
		QADescribeBT_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBT_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeBT_IsValid = QADescribeBT_FunctionAddress != IntPtr.Zero && QADescribeBT_BT_IsValid && QADescribeBT_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeBT", QADescribeBT_IsValid);
		QADescribeISO_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeISO");
		QADescribeISO_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeISO_FunctionAddress);
		QADescribeISO_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeISO_FunctionAddress, "TM");
		QADescribeISO_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeISO_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeISO_ReturnValue_PropertyAddress, QADescribeISO_FunctionAddress, "ReturnValue");
		QADescribeISO_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeISO_FunctionAddress, "ReturnValue");
		QADescribeISO_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeISO_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeISO_IsValid = QADescribeISO_FunctionAddress != IntPtr.Zero && QADescribeISO_TM_IsValid && QADescribeISO_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeISO", QADescribeISO_IsValid);
		QADescribeArt_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeArt");
		QADescribeArt_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeArt_FunctionAddress);
		QADescribeArt_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeArt_FunctionAddress, "TM");
		QADescribeArt_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeArt_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeArt_ReturnValue_PropertyAddress, QADescribeArt_FunctionAddress, "ReturnValue");
		QADescribeArt_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeArt_FunctionAddress, "ReturnValue");
		QADescribeArt_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeArt_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeArt_IsValid = QADescribeArt_FunctionAddress != IntPtr.Zero && QADescribeArt_TM_IsValid && QADescribeArt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeArt", QADescribeArt_IsValid);
		QADescribeDeath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeDeath");
		QADescribeDeath_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeDeath_FunctionAddress);
		QADescribeDeath_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeDeath_FunctionAddress, "TM");
		QADescribeDeath_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeDeath_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeDeath_ReturnValue_PropertyAddress, QADescribeDeath_FunctionAddress, "ReturnValue");
		QADescribeDeath_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeDeath_FunctionAddress, "ReturnValue");
		QADescribeDeath_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeDeath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeDeath_IsValid = QADescribeDeath_FunctionAddress != IntPtr.Zero && QADescribeDeath_TM_IsValid && QADescribeDeath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeDeath", QADescribeDeath_IsValid);
		QADescribeSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeSkill");
		QADescribeSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeSkill_FunctionAddress);
		QADescribeSkill_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeSkill_FunctionAddress, "TM");
		QADescribeSkill_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeSkill_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeSkill_ReturnValue_PropertyAddress, QADescribeSkill_FunctionAddress, "ReturnValue");
		QADescribeSkill_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeSkill_FunctionAddress, "ReturnValue");
		QADescribeSkill_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeSkill_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeSkill_IsValid = QADescribeSkill_FunctionAddress != IntPtr.Zero && QADescribeSkill_TM_IsValid && QADescribeSkill_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeSkill", QADescribeSkill_IsValid);
		QADescribeBattle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeBattle");
		QADescribeBattle_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeBattle_FunctionAddress);
		QADescribeBattle_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeBattle_FunctionAddress, "TM");
		QADescribeBattle_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBattle_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeBattle_ReturnValue_PropertyAddress, QADescribeBattle_FunctionAddress, "ReturnValue");
		QADescribeBattle_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeBattle_FunctionAddress, "ReturnValue");
		QADescribeBattle_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBattle_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeBattle_IsValid = QADescribeBattle_FunctionAddress != IntPtr.Zero && QADescribeBattle_TM_IsValid && QADescribeBattle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeBattle", QADescribeBattle_IsValid);
		QAGetBTTaskNodes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QAGetBTTaskNodes");
		QAGetBTTaskNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(QAGetBTTaskNodes_FunctionAddress);
		QAGetBTTaskNodes_BT_Offset = NativeReflection.GetPropertyOffset(QAGetBTTaskNodes_FunctionAddress, "BT");
		QAGetBTTaskNodes_BT_IsValid = NativeReflection.ValidatePropertyClass(QAGetBTTaskNodes_FunctionAddress, "BT", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QAGetBTTaskNodes_ReturnValue_PropertyAddress, QAGetBTTaskNodes_FunctionAddress, "ReturnValue");
		QAGetBTTaskNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QAGetBTTaskNodes_FunctionAddress, "ReturnValue");
		QAGetBTTaskNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QAGetBTTaskNodes_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		QAGetBTTaskNodes_IsValid = QAGetBTTaskNodes_FunctionAddress != IntPtr.Zero && QAGetBTTaskNodes_BT_IsValid && QAGetBTTaskNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QAGetBTTaskNodes", QAGetBTTaskNodes_IsValid);
		QADescribeCounter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeCounter");
		QADescribeCounter_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeCounter_FunctionAddress);
		QADescribeCounter_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeCounter_FunctionAddress, "TM");
		QADescribeCounter_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeCounter_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeCounter_ReturnValue_PropertyAddress, QADescribeCounter_FunctionAddress, "ReturnValue");
		QADescribeCounter_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeCounter_FunctionAddress, "ReturnValue");
		QADescribeCounter_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeCounter_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeCounter_IsValid = QADescribeCounter_FunctionAddress != IntPtr.Zero && QADescribeCounter_TM_IsValid && QADescribeCounter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeCounter", QADescribeCounter_IsValid);
		QADescribeBeAttacked_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeBeAttacked");
		QADescribeBeAttacked_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeBeAttacked_FunctionAddress);
		QADescribeBeAttacked_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeBeAttacked_FunctionAddress, "TM");
		QADescribeBeAttacked_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBeAttacked_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeBeAttacked_ReturnValue_PropertyAddress, QADescribeBeAttacked_FunctionAddress, "ReturnValue");
		QADescribeBeAttacked_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeBeAttacked_FunctionAddress, "ReturnValue");
		QADescribeBeAttacked_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBeAttacked_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeBeAttacked_IsValid = QADescribeBeAttacked_FunctionAddress != IntPtr.Zero && QADescribeBeAttacked_TM_IsValid && QADescribeBeAttacked_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeBeAttacked", QADescribeBeAttacked_IsValid);
		QADescribeEngagement_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeEngagement");
		QADescribeEngagement_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeEngagement_FunctionAddress);
		QADescribeEngagement_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeEngagement_FunctionAddress, "TM");
		QADescribeEngagement_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeEngagement_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeEngagement_ReturnValue_PropertyAddress, QADescribeEngagement_FunctionAddress, "ReturnValue");
		QADescribeEngagement_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeEngagement_FunctionAddress, "ReturnValue");
		QADescribeEngagement_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeEngagement_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeEngagement_IsValid = QADescribeEngagement_FunctionAddress != IntPtr.Zero && QADescribeEngagement_TM_IsValid && QADescribeEngagement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeEngagement", QADescribeEngagement_IsValid);
		QADescribeBattleArena_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeBattleArena");
		QADescribeBattleArena_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeBattleArena_FunctionAddress);
		QADescribeBattleArena_TM_Offset = NativeReflection.GetPropertyOffset(QADescribeBattleArena_FunctionAddress, "TM");
		QADescribeBattleArena_TM_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBattleArena_FunctionAddress, "TM", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeBattleArena_ReturnValue_PropertyAddress, QADescribeBattleArena_FunctionAddress, "ReturnValue");
		QADescribeBattleArena_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeBattleArena_FunctionAddress, "ReturnValue");
		QADescribeBattleArena_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeBattleArena_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeBattleArena_IsValid = QADescribeBattleArena_FunctionAddress != IntPtr.Zero && QADescribeBattleArena_TM_IsValid && QADescribeBattleArena_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeBattleArena", QADescribeBattleArena_IsValid);
		QADescribeAnimByMontage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeAnimByMontage");
		QADescribeAnimByMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeAnimByMontage_FunctionAddress);
		QADescribeAnimByMontage_Montage_Offset = NativeReflection.GetPropertyOffset(QADescribeAnimByMontage_FunctionAddress, "Montage");
		QADescribeAnimByMontage_Montage_IsValid = NativeReflection.ValidatePropertyClass(QADescribeAnimByMontage_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QADescribeAnimByMontage_ReturnValue_PropertyAddress, QADescribeAnimByMontage_FunctionAddress, "ReturnValue");
		QADescribeAnimByMontage_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeAnimByMontage_FunctionAddress, "ReturnValue");
		QADescribeAnimByMontage_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeAnimByMontage_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeAnimByMontage_IsValid = QADescribeAnimByMontage_FunctionAddress != IntPtr.Zero && QADescribeAnimByMontage_Montage_IsValid && QADescribeAnimByMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeAnimByMontage", QADescribeAnimByMontage_IsValid);
		QADescribeAnimBySkillID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "QADescribeAnimBySkillID");
		QADescribeAnimBySkillID_ParamsSize = NativeReflection.GetFunctionParamsSize(QADescribeAnimBySkillID_FunctionAddress);
		QADescribeAnimBySkillID_SkillID_Offset = NativeReflection.GetPropertyOffset(QADescribeAnimBySkillID_FunctionAddress, "SkillID");
		QADescribeAnimBySkillID_SkillID_IsValid = NativeReflection.ValidatePropertyClass(QADescribeAnimBySkillID_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref QADescribeAnimBySkillID_ReturnValue_PropertyAddress, QADescribeAnimBySkillID_FunctionAddress, "ReturnValue");
		QADescribeAnimBySkillID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(QADescribeAnimBySkillID_FunctionAddress, "ReturnValue");
		QADescribeAnimBySkillID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(QADescribeAnimBySkillID_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		QADescribeAnimBySkillID_IsValid = QADescribeAnimBySkillID_FunctionAddress != IntPtr.Zero && QADescribeAnimBySkillID_SkillID_IsValid && QADescribeAnimBySkillID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.QATamerDescriber:QADescribeAnimBySkillID", QADescribeAnimBySkillID_IsValid);
	}
}
