using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using Google.Protobuf;
using GurCalliopeState;
using UnrealEngine.Runtime;

namespace b1;

[Serializable]
[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition")]
public struct FDetectCondition
{
	[EditAnywhere]
	[DisplayName("检测元素类型")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:DetectedElementType")]
	public EDetectedElementType DetectedElementType;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:SimpleState")]
	public EBGUSimpleState SimpleState;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:UnitState")]
	public EBGUUnitState UnitState;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:BuffId")]
	public int BuffId;

	[DisplayName("属性类型")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:AttrFloatType")]
	public EBGUAttrFloat AttrFloatType;

	[EditAnywhere]
	[UProperty]
	[DisplayName("属性比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition:CompareOperation")]
	public EValueCompareOperations CompareOperation;

	[UProperty]
	[EditAnywhere]
	[DisplayName("属性比较值")]
	[USharpPath("/Script/b1-Managed.DetectCondition:CompareValue")]
	public float CompareValue;

	[UProperty]
	[EditAnywhere]
	[DisplayName("异常状态类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DetectCondition:AbnormalStateType")]
	public EAbnormalStateType AbnormalStateType;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition:FsmState")]
	public EBGUFSMStateName FsmState;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:SkillId")]
	public int SkillId;

	[DisplayName("距离比较方式")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:DistanceCompareOperations")]
	public EValueCompareOperations DistanceCompareOperations;

	[DisplayName("距离比较值")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:DistanceCompareValue")]
	public float DistanceCompareValue;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:CustomFsmState")]
	public FGameplayTag CustomFsmState;

	[UProperty]
	[EditAnywhere]
	[DisplayName("属性比较值")]
	[USharpPath("/Script/b1-Managed.DetectCondition:CompareValueInt")]
	public int CompareValueInt;

	[UProperty]
	[EditAnywhere]
	[DisplayName("基准方向")]
	[USharpPath("/Script/b1-Managed.DetectCondition:BaseDirection")]
	public ERotationBaseDirection BaseDirection;

	[EditAnywhere]
	[DisplayName("最小Yaw值")]
	[UMeta(MDProp.ClampMin, -180f)]
	[UMeta(MDProp.ClampMax, 180f)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:MinYawAngle")]
	public float MinYawAngle;

	[UMeta(MDProp.ClampMin, -180f)]
	[UMeta(MDProp.ClampMax, 180f)]
	[UProperty]
	[EditAnywhere]
	[DisplayName("最大Yaw值")]
	[USharpPath("/Script/b1-Managed.DetectCondition:MaxYawAngle")]
	public float MaxYawAngle;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition:SkillIdList")]
	public List<int> SkillIdList;

	[UProperty]
	[DisplayName("匹配规则")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition:MatchInfo")]
	public FTamerFamilyMatchChildInfo MatchInfo;

	[DisplayName("指定ResID")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition:ResId")]
	public int ResId;

	[UProperty]
	[EditAnywhere]
	[DisplayName("成功率")]
	[UMeta(MDProp.ClampMin, 0f)]
	[UMeta(MDProp.ClampMax, 1f)]
	[USharpPath("/Script/b1-Managed.DetectCondition:SuccessRate")]
	public float SuccessRate;

	[UProperty]
	[EditAnywhere]
	[DisplayName("存活单位数量")]
	[USharpPath("/Script/b1-Managed.DetectCondition:AliveUnitNum")]
	public int AliveUnitNum;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition:BuffLayer")]
	public int BuffLayer;

	[UProperty]
	[EditAnywhere]
	[DisplayName("比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition:OperationType")]
	public EValueCompareOperationType OperationType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("比较值")]
	[USharpPath("/Script/b1-Managed.DetectCondition:GamePlusCount")]
	public int GamePlusCount;

	[UProperty]
	[EditAnywhere]
	[DisplayName("地面物理材质")]
	[USharpPath("/Script/b1-Managed.DetectCondition:SurfaceType")]
	public ESceneItemSurfaceType SurfaceType;

	[UProperty]
	[EditAnywhere]
	[DisplayName("怠惰时长")]
	[USharpPath("/Script/b1-Managed.DetectCondition:PlayerLeisureOverTime")]
	public float PlayerLeisureOverTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否反转条件")]
	[USharpPath("/Script/b1-Managed.DetectCondition:bReverseCondition")]
	public bool bReverseCondition;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("注释")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition:Comment")]
	public string Comment;

	private static int DetectCondition_StructSize;

	private static int DetectCondition_IsValid;

	private static bool DetectedElementType_IsValid;

	private static int DetectedElementType_Offset;

	private static FFieldAddress DetectedElementType_PropertyAddress;

	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool UnitState_IsValid;

	private static int UnitState_Offset;

	private static FFieldAddress UnitState_PropertyAddress;

	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool AttrFloatType_IsValid;

	private static int AttrFloatType_Offset;

	private static FFieldAddress AttrFloatType_PropertyAddress;

	private static bool CompareOperation_IsValid;

	private static int CompareOperation_Offset;

	private static FFieldAddress CompareOperation_PropertyAddress;

	private static bool CompareValue_IsValid;

	private static int CompareValue_Offset;

	private static bool AbnormalStateType_IsValid;

	private static int AbnormalStateType_Offset;

	private static FFieldAddress AbnormalStateType_PropertyAddress;

	private static bool FsmState_IsValid;

	private static int FsmState_Offset;

	private static FFieldAddress FsmState_PropertyAddress;

	private static bool SkillId_IsValid;

	private static int SkillId_Offset;

	private static bool DistanceCompareOperations_IsValid;

	private static int DistanceCompareOperations_Offset;

	private static FFieldAddress DistanceCompareOperations_PropertyAddress;

	private static bool DistanceCompareValue_IsValid;

	private static int DistanceCompareValue_Offset;

	private static bool CustomFsmState_IsValid;

	private static int CustomFsmState_Offset;

	private static bool CompareValueInt_IsValid;

	private static int CompareValueInt_Offset;

	private static bool BaseDirection_IsValid;

	private static int BaseDirection_Offset;

	private static FFieldAddress BaseDirection_PropertyAddress;

	private static bool MinYawAngle_IsValid;

	private static int MinYawAngle_Offset;

	private static bool MaxYawAngle_IsValid;

	private static int MaxYawAngle_Offset;

	private static bool SkillIdList_IsValid;

	private static int SkillIdList_Offset;

	private static FFieldAddress SkillIdList_PropertyAddress;

	private static bool MatchInfo_IsValid;

	private static int MatchInfo_Offset;

	private static bool ResId_IsValid;

	private static int ResId_Offset;

	private static bool SuccessRate_IsValid;

	private static int SuccessRate_Offset;

	private static bool AliveUnitNum_IsValid;

	private static int AliveUnitNum_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool OperationType_IsValid;

	private static int OperationType_Offset;

	private static FFieldAddress OperationType_PropertyAddress;

	private static bool GamePlusCount_IsValid;

	private static int GamePlusCount_Offset;

	private static bool SurfaceType_IsValid;

	private static int SurfaceType_Offset;

	private static FFieldAddress SurfaceType_PropertyAddress;

	private static bool PlayerLeisureOverTime_IsValid;

	private static int PlayerLeisureOverTime_Offset;

	private static bool bReverseCondition_IsValid;

	private static int bReverseCondition_Offset;

	private static FFieldAddress bReverseCondition_PropertyAddress;

	private static bool Comment_IsValid;

	private static int Comment_Offset;

	public CalliopeCustom_DetectCondition GetSerializableObject()
	{
		CalliopeCustom_DetectCondition calliopeCustom_DetectCondition = new CalliopeCustom_DetectCondition();
		calliopeCustom_DetectCondition.DetectedElementType = (int)DetectedElementType;
		switch (DetectedElementType)
		{
		case EDetectedElementType.SimpleState:
			calliopeCustom_DetectCondition.SimpleState = new CalliopeCustom_DetectCondition_SimpleState();
			calliopeCustom_DetectCondition.SimpleState.SimpleState = (int)SimpleState;
			break;
		case EDetectedElementType.UnitState:
			calliopeCustom_DetectCondition.UnitState = new CalliopeCustom_DetectCondition_UnitState();
			calliopeCustom_DetectCondition.UnitState.UnitState = (int)UnitState;
			break;
		case EDetectedElementType.HasBuff:
			calliopeCustom_DetectCondition.HasBuff = new CalliopeCustom_DetectCondition_HasBuff();
			calliopeCustom_DetectCondition.HasBuff.BuffId = BuffId;
			break;
		case EDetectedElementType.UnitAttr:
			calliopeCustom_DetectCondition.UnitAttr = new CalliopeCustom_DetectCondition_UnitAttr();
			calliopeCustom_DetectCondition.UnitAttr.AttrFloatType = (int)AttrFloatType;
			calliopeCustom_DetectCondition.UnitAttr.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.UnitAttr.CompareValue = CompareValue;
			break;
		case EDetectedElementType.AbnormalState:
			calliopeCustom_DetectCondition.AbnormalState = new CalliopeCustom_DetectCondition_AbnormalState();
			calliopeCustom_DetectCondition.AbnormalState.AbnormalStateType = (int)AbnormalStateType;
			break;
		case EDetectedElementType.FsmState:
			calliopeCustom_DetectCondition.FsmState = new CalliopeCustom_DetectCondition_FsmState();
			calliopeCustom_DetectCondition.FsmState.FsmState = (int)FsmState;
			break;
		case EDetectedElementType.SkillCoolDown:
			calliopeCustom_DetectCondition.SkillCoolDown = new CalliopeCustom_DetectCondition_SkillCoolDown();
			calliopeCustom_DetectCondition.SkillCoolDown.SkillId = SkillId;
			break;
		case EDetectedElementType.DistanceFromTarget:
			calliopeCustom_DetectCondition.DistanceFromTarget = new CalliopeCustom_DetectCondition_DistanceFromTarget();
			calliopeCustom_DetectCondition.DistanceFromTarget.DistanceCompareOperations = (int)DistanceCompareOperations;
			calliopeCustom_DetectCondition.DistanceFromTarget.DistanceCompareValue = DistanceCompareValue;
			break;
		case EDetectedElementType.SkillCanCast:
			calliopeCustom_DetectCondition.SkillCanCast = new CalliopeCustom_DetectCondition_SkillCanCast();
			calliopeCustom_DetectCondition.SkillCanCast.SkillId = SkillId;
			break;
		case EDetectedElementType.CustomFsmState:
			calliopeCustom_DetectCondition.CustomFsmState = new CalliopeCustom_DetectCondition_CustomFsmState();
			calliopeCustom_DetectCondition.CustomFsmState.CustomFsmState = CustomFsmState.TagName.PlainName;
			break;
		case EDetectedElementType.LastBeAttackedStiffLevel:
			calliopeCustom_DetectCondition.LastBeAttackedStiffLevel = new CalliopeCustom_DetectCondition_LastBeAttackedStiffLevel();
			calliopeCustom_DetectCondition.LastBeAttackedStiffLevel.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.LastBeAttackedStiffLevel.CompareValueInt = CompareValueInt;
			break;
		case EDetectedElementType.DistanceFromMaster:
			calliopeCustom_DetectCondition.DistanceFromMaster = new CalliopeCustom_DetectCondition_DistanceFromMaster();
			calliopeCustom_DetectCondition.DistanceFromMaster.DistanceCompareOperations = (int)DistanceCompareOperations;
			calliopeCustom_DetectCondition.DistanceFromMaster.DistanceCompareValue = DistanceCompareValue;
			break;
		case EDetectedElementType.ActorYawRotation:
			calliopeCustom_DetectCondition.ActorYawRotation = new CalliopeCustom_DetectCondition_ActorYawRotation();
			calliopeCustom_DetectCondition.ActorYawRotation.BaseDirection = (int)BaseDirection;
			calliopeCustom_DetectCondition.ActorYawRotation.MinYawAngle = MinYawAngle;
			calliopeCustom_DetectCondition.ActorYawRotation.MaxYawAngle = MaxYawAngle;
			break;
		case EDetectedElementType.GlobalCastSkillCount:
			calliopeCustom_DetectCondition.GlobalCastSkillCount = new CalliopeCustom_DetectCondition_GlobalCastSkillCount();
			calliopeCustom_DetectCondition.GlobalCastSkillCount.SkillId = SkillId;
			calliopeCustom_DetectCondition.GlobalCastSkillCount.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.GlobalCastSkillCount.CompareValueInt = CompareValueInt;
			break;
		case EDetectedElementType.DurCastSkill:
			calliopeCustom_DetectCondition.DurCastSkill = new CalliopeCustom_DetectCondition_DurCastSkill();
			foreach (int skillId in SkillIdList)
			{
				calliopeCustom_DetectCondition.DurCastSkill.SkillIdList.Add(skillId);
			}
			break;
		case EDetectedElementType.CurrentBeAttackedStiffLevel:
			calliopeCustom_DetectCondition.CurrentBeAttackedStiffLevel = new CalliopeCustom_DetectCondition_CurrentBeAttackedStiffLevel();
			calliopeCustom_DetectCondition.CurrentBeAttackedStiffLevel.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.CurrentBeAttackedStiffLevel.CompareValueInt = CompareValueInt;
			break;
		case EDetectedElementType.CurSkillCostDmgNum:
			calliopeCustom_DetectCondition.CurSkillCostDmgNum = new CalliopeCustom_DetectCondition_CurSkillCostDmgNum();
			calliopeCustom_DetectCondition.CurSkillCostDmgNum.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.CurSkillCostDmgNum.CompareValueInt = CompareValueInt;
			break;
		case EDetectedElementType.SocketUnitsDead:
			calliopeCustom_DetectCondition.SocketUnitsDead = new CalliopeCustom_DetectCondition_SocketUnitsDead();
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo.Filter = (int)MatchInfo.Filter;
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo.MatchSocketType = (int)MatchInfo.MatchSocketType;
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo.SocketName = MatchInfo.SocketName.ToString();
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo.ResId = MatchInfo.ResId;
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo.NickName = MatchInfo.NickName.TagName.PlainName;
			calliopeCustom_DetectCondition.SocketUnitsDead.MatchInfo.BuffId = MatchInfo.BuffId;
			break;
		case EDetectedElementType.DistanceFromNearestPlayer:
			calliopeCustom_DetectCondition.DistanceFromNearestPlayer = new CalliopeCustom_DetectCondition_DistanceFromNearestPlayer();
			calliopeCustom_DetectCondition.DistanceFromNearestPlayer.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.DistanceFromNearestPlayer.CompareValueInt = CompareValueInt;
			break;
		case EDetectedElementType.SpecifyResIdUnitsDead:
			calliopeCustom_DetectCondition.SpecifyResIdUnitsDead = new CalliopeCustom_DetectCondition_SpecifyResIdUnitsDead();
			calliopeCustom_DetectCondition.SpecifyResIdUnitsDead.ResId = ResId;
			break;
		case EDetectedElementType.FamilySpecifyUnitAttr:
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr = new CalliopeCustom_DetectCondition_FamilySpecifyUnitAttr();
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo.Filter = (int)MatchInfo.Filter;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo.MatchSocketType = (int)MatchInfo.MatchSocketType;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo.SocketName = MatchInfo.SocketName.ToString();
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo.ResId = MatchInfo.ResId;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo.NickName = MatchInfo.NickName.TagName.PlainName;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.MatchInfo.BuffId = MatchInfo.BuffId;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.AttrFloatType = (int)AttrFloatType;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.FamilySpecifyUnitAttr.CompareValue = CompareValue;
			break;
		case EDetectedElementType.Random:
			calliopeCustom_DetectCondition.Random = new CalliopeCustom_DetectCondition_Random();
			calliopeCustom_DetectCondition.Random.SuccessRate = SuccessRate;
			break;
		case EDetectedElementType.FamilyUnitAliveNum:
			calliopeCustom_DetectCondition.FamilyUnitAliveNum = new CalliopeCustom_DetectCondition_FamilyUnitAliveNum();
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo = new CalliopeCustom_FTamerFamilyMatchChildInfo();
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo.Filter = (int)MatchInfo.Filter;
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo.MatchSocketType = (int)MatchInfo.MatchSocketType;
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo.SocketName = MatchInfo.SocketName.ToString();
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo.ResId = MatchInfo.ResId;
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo.NickName = MatchInfo.NickName.TagName.PlainName;
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.MatchInfo.BuffId = MatchInfo.BuffId;
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.CompareOperation = (int)CompareOperation;
			calliopeCustom_DetectCondition.FamilyUnitAliveNum.AliveUnitNum = AliveUnitNum;
			break;
		case EDetectedElementType.TargetInAngleRange:
			calliopeCustom_DetectCondition.TargetInAngleRange = new CalliopeCustom_DetectCondition_TargetInAngleRange();
			calliopeCustom_DetectCondition.TargetInAngleRange.MinYawAngle = MinYawAngle;
			calliopeCustom_DetectCondition.TargetInAngleRange.MaxYawAngle = MaxYawAngle;
			break;
		case EDetectedElementType.CompareBuffLayer:
			calliopeCustom_DetectCondition.CompareBuffLayer = new CalliopeCustom_DetectCondition_CompareBuffLayer();
			calliopeCustom_DetectCondition.CompareBuffLayer.BuffId = BuffId;
			calliopeCustom_DetectCondition.CompareBuffLayer.BuffLayer = BuffLayer;
			calliopeCustom_DetectCondition.CompareBuffLayer.OperationType = (int)OperationType;
			break;
		case EDetectedElementType.CompareGamePlusCount:
			calliopeCustom_DetectCondition.CompareGamePlusCount = new CalliopeCustom_DetectCondition_CompareGamePlusCount();
			calliopeCustom_DetectCondition.CompareGamePlusCount.OperationType = (int)OperationType;
			calliopeCustom_DetectCondition.CompareGamePlusCount.GamePlusCount = GamePlusCount;
			break;
		case EDetectedElementType.CheckSurfaceType:
			calliopeCustom_DetectCondition.CheckSurfaceType = new CalliopeCustom_DetectCondition_CheckSurfaceType();
			calliopeCustom_DetectCondition.CheckSurfaceType.SurfaceType = (int)SurfaceType;
			break;
		case EDetectedElementType.PlayerLeisureOverTime:
			calliopeCustom_DetectCondition.PlayerLeisureOverTime = new CalliopeCustom_DetectCondition_PlayerLeisureOverTime();
			calliopeCustom_DetectCondition.PlayerLeisureOverTime.PlayerLeisureOverTime = PlayerLeisureOverTime;
			break;
		}
		calliopeCustom_DetectCondition.IsReverseCondition = bReverseCondition;
		calliopeCustom_DetectCondition.Comment = Comment;
		return calliopeCustom_DetectCondition;
	}

	public static void RegisterCustomizeChildren()
	{
		List<FName> properties = new List<FName>
		{
			new FName("SimpleState")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 1, properties);
		List<FName> properties2 = new List<FName>
		{
			new FName("UnitState")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 2, properties2);
		List<FName> properties3 = new List<FName>
		{
			new FName("BuffId")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 3, properties3);
		List<FName> properties4 = new List<FName>
		{
			new FName("AttrFloatType"),
			new FName("CompareOperation"),
			new FName("CompareValue")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 4, properties4);
		List<FName> properties5 = new List<FName>();
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 5, properties5);
		List<FName> properties6 = new List<FName>();
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 6, properties6);
		List<FName> properties7 = new List<FName>
		{
			new FName("AbnormalStateType")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 7, properties7);
		List<FName> properties8 = new List<FName>
		{
			new FName("FsmState")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 8, properties8);
		List<FName> properties9 = new List<FName>
		{
			new FName("SkillId")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 9, properties9);
		List<FName> properties10 = new List<FName>
		{
			new FName("DistanceCompareOperations"),
			new FName("DistanceCompareValue")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 10, properties10);
		List<FName> properties11 = new List<FName>
		{
			new FName("SkillId")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 11, properties11);
		List<FName> properties12 = new List<FName>
		{
			new FName("CustomFsmState")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 12, properties12);
		List<FName> properties13 = new List<FName>
		{
			new FName("CompareOperation"),
			new FName("CompareValueInt")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 13, properties13);
		List<FName> properties14 = new List<FName>
		{
			new FName("DistanceCompareOperations"),
			new FName("DistanceCompareValue")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 14, properties14);
		List<FName> properties15 = new List<FName>
		{
			new FName("BaseDirection"),
			new FName("MinYawAngle"),
			new FName("MaxYawAngle")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 15, properties15);
		List<FName> properties16 = new List<FName>
		{
			new FName("SkillId"),
			new FName("CompareOperation"),
			new FName("CompareValueInt")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 16, properties16);
		List<FName> properties17 = new List<FName>
		{
			new FName("SkillIdList")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 17, properties17);
		List<FName> properties18 = new List<FName>
		{
			new FName("CompareOperation"),
			new FName("CompareValueInt")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 18, properties18);
		List<FName> properties19 = new List<FName>
		{
			new FName("CompareOperation"),
			new FName("CompareValueInt")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 19, properties19);
		List<FName> properties20 = new List<FName>
		{
			new FName("MatchInfo")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 20, properties20);
		List<FName> properties21 = new List<FName>
		{
			new FName("CompareOperation"),
			new FName("CompareValueInt")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 21, properties21);
		List<FName> properties22 = new List<FName>
		{
			new FName("ResId")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 22, properties22);
		List<FName> properties23 = new List<FName>
		{
			new FName("MatchInfo"),
			new FName("AttrFloatType"),
			new FName("CompareOperation"),
			new FName("CompareValue")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 23, properties23);
		List<FName> properties24 = new List<FName>
		{
			new FName("SuccessRate")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 24, properties24);
		List<FName> properties25 = new List<FName>
		{
			new FName("MatchInfo"),
			new FName("CompareOperation"),
			new FName("AliveUnitNum")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 25, properties25);
		List<FName> properties26 = new List<FName>
		{
			new FName("MinYawAngle"),
			new FName("MaxYawAngle")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 26, properties26);
		List<FName> properties27 = new List<FName>
		{
			new FName("BuffId"),
			new FName("BuffLayer"),
			new FName("OperationType")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 27, properties27);
		List<FName> properties28 = new List<FName>
		{
			new FName("OperationType"),
			new FName("GamePlusCount")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 28, properties28);
		List<FName> properties29 = new List<FName>
		{
			new FName("SurfaceType")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 29, properties29);
		List<FName> properties30 = new List<FName>();
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 30, properties30);
		List<FName> properties31 = new List<FName>();
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 31, properties31);
		List<FName> properties32 = new List<FName>
		{
			new FName("PlayerLeisureOverTime")
		};
		UGSFuncLibForEditor.RegisterPropertyTypeCustomizationDetails("FDetectCondition", 32, properties32);
	}

	public ByteString GetSerialize()
	{
		return GetSerializableObject().ToByteString();
	}

	public FDetectCondition Copy()
	{
		FDetectCondition result = this;
		if (SkillIdList != null)
		{
			result.SkillIdList = new List<int>(SkillIdList);
		}
		return result;
	}

	public static FDetectCondition FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition");
			return;
		}
		EnumMarshaler<EDetectedElementType>.ToNative(IntPtr.Add(nativeStruct, DetectedElementType_Offset), 0, DetectedElementType_PropertyAddress.Address, DetectedElementType);
		EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, SimpleState);
		EnumMarshaler<EBGUUnitState>.ToNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address, UnitState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffId_Offset), BuffId);
		EnumMarshaler<EBGUAttrFloat>.ToNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address, AttrFloatType);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address, CompareOperation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompareValue_Offset), CompareValue);
		EnumMarshaler<EAbnormalStateType>.ToNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address, AbnormalStateType);
		EnumMarshaler<EBGUFSMStateName>.ToNative(IntPtr.Add(nativeStruct, FsmState_Offset), 0, FsmState_PropertyAddress.Address, FsmState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkillId_Offset), SkillId);
		EnumMarshaler<EValueCompareOperations>.ToNative(IntPtr.Add(nativeStruct, DistanceCompareOperations_Offset), 0, DistanceCompareOperations_PropertyAddress.Address, DistanceCompareOperations);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceCompareValue_Offset), DistanceCompareValue);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, CustomFsmState_Offset), CustomFsmState);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset), CompareValueInt);
		EnumMarshaler<ERotationBaseDirection>.ToNative(IntPtr.Add(nativeStruct, BaseDirection_Offset), 0, BaseDirection_PropertyAddress.Address, BaseDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinYawAngle_Offset), MinYawAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxYawAngle_Offset), MaxYawAngle);
		new TArrayCopyMarshaler<int>(1, SkillIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SkillIdList_Offset), SkillIdList);
		FTamerFamilyMatchChildInfo.ToNative(IntPtr.Add(nativeStruct, MatchInfo_Offset), MatchInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ResId_Offset), ResId);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SuccessRate_Offset), SuccessRate);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, AliveUnitNum_Offset), AliveUnitNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffLayer_Offset), BuffLayer);
		EnumMarshaler<EValueCompareOperationType>.ToNative(IntPtr.Add(nativeStruct, OperationType_Offset), 0, OperationType_PropertyAddress.Address, OperationType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GamePlusCount_Offset), GamePlusCount);
		EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(nativeStruct, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address, SurfaceType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PlayerLeisureOverTime_Offset), PlayerLeisureOverTime);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address, bReverseCondition);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Comment_Offset), Comment);
	}

	public FDetectCondition(IntPtr nativeStruct)
	{
		if (DetectCondition_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition");
			DetectedElementType = EDetectedElementType.None;
			SimpleState = EBGUSimpleState.Normal;
			UnitState = EBGUUnitState.None;
			BuffId = 0;
			AttrFloatType = EBGUAttrFloat.None;
			CompareOperation = EValueCompareOperations.EqualTo;
			CompareValue = 0f;
			AbnormalStateType = EAbnormalStateType.None;
			FsmState = EBGUFSMStateName.FSM_STATE_LIFE;
			SkillId = 0;
			DistanceCompareOperations = EValueCompareOperations.EqualTo;
			DistanceCompareValue = 0f;
			CustomFsmState = default(FGameplayTag);
			CompareValueInt = 0;
			BaseDirection = ERotationBaseDirection.WorldSpaceXAxis;
			MinYawAngle = 0f;
			MaxYawAngle = 0f;
			SkillIdList = null;
			MatchInfo = default(FTamerFamilyMatchChildInfo);
			ResId = 0;
			SuccessRate = 0f;
			AliveUnitNum = 0;
			BuffLayer = 0;
			OperationType = EValueCompareOperationType.EqualTo;
			GamePlusCount = 0;
			SurfaceType = ESceneItemSurfaceType.DefaultSurface;
			PlayerLeisureOverTime = 0f;
			bReverseCondition = false;
			Comment = null;
		}
		else
		{
			DetectedElementType = EnumMarshaler<EDetectedElementType>.FromNative(IntPtr.Add(nativeStruct, DetectedElementType_Offset), 0, DetectedElementType_PropertyAddress.Address);
			SimpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(nativeStruct, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
			UnitState = EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(nativeStruct, UnitState_Offset), 0, UnitState_PropertyAddress.Address);
			BuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffId_Offset));
			AttrFloatType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(nativeStruct, AttrFloatType_Offset), 0, AttrFloatType_PropertyAddress.Address);
			CompareOperation = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, CompareOperation_Offset), 0, CompareOperation_PropertyAddress.Address);
			CompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompareValue_Offset));
			AbnormalStateType = EnumMarshaler<EAbnormalStateType>.FromNative(IntPtr.Add(nativeStruct, AbnormalStateType_Offset), 0, AbnormalStateType_PropertyAddress.Address);
			FsmState = EnumMarshaler<EBGUFSMStateName>.FromNative(IntPtr.Add(nativeStruct, FsmState_Offset), 0, FsmState_PropertyAddress.Address);
			SkillId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkillId_Offset));
			DistanceCompareOperations = EnumMarshaler<EValueCompareOperations>.FromNative(IntPtr.Add(nativeStruct, DistanceCompareOperations_Offset), 0, DistanceCompareOperations_PropertyAddress.Address);
			DistanceCompareValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceCompareValue_Offset));
			CustomFsmState = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, CustomFsmState_Offset));
			CompareValueInt = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CompareValueInt_Offset));
			BaseDirection = EnumMarshaler<ERotationBaseDirection>.FromNative(IntPtr.Add(nativeStruct, BaseDirection_Offset), 0, BaseDirection_PropertyAddress.Address);
			MinYawAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinYawAngle_Offset));
			MaxYawAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxYawAngle_Offset));
			SkillIdList = new TArrayCopyMarshaler<int>(1, SkillIdList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SkillIdList_Offset));
			MatchInfo = FTamerFamilyMatchChildInfo.FromNative(IntPtr.Add(nativeStruct, MatchInfo_Offset));
			ResId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ResId_Offset));
			SuccessRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SuccessRate_Offset));
			AliveUnitNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, AliveUnitNum_Offset));
			BuffLayer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffLayer_Offset));
			OperationType = EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(nativeStruct, OperationType_Offset), 0, OperationType_PropertyAddress.Address);
			GamePlusCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GamePlusCount_Offset));
			SurfaceType = EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(nativeStruct, SurfaceType_Offset), 0, SurfaceType_PropertyAddress.Address);
			PlayerLeisureOverTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PlayerLeisureOverTime_Offset));
			bReverseCondition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bReverseCondition_Offset), 0, bReverseCondition_PropertyAddress.Address);
			Comment = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Comment_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition");
		DetectCondition_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref DetectedElementType_PropertyAddress, intPtr, "DetectedElementType");
		DetectedElementType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetectedElementType");
		DetectedElementType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetectedElementType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UnitState_PropertyAddress, intPtr, "UnitState");
		UnitState_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitState");
		UnitState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitState", Classes.FEnumProperty);
		BuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AttrFloatType_PropertyAddress, intPtr, "AttrFloatType");
		AttrFloatType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttrFloatType");
		AttrFloatType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttrFloatType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CompareOperation_PropertyAddress, intPtr, "CompareOperation");
		CompareOperation_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareOperation");
		CompareOperation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareOperation", Classes.FEnumProperty);
		CompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValue");
		CompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AbnormalStateType_PropertyAddress, intPtr, "AbnormalStateType");
		AbnormalStateType_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateType");
		AbnormalStateType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref FsmState_PropertyAddress, intPtr, "FsmState");
		FsmState_Offset = NativeReflection.GetPropertyOffset(intPtr, "FsmState");
		FsmState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FsmState", Classes.FEnumProperty);
		SkillId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillId");
		SkillId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DistanceCompareOperations_PropertyAddress, intPtr, "DistanceCompareOperations");
		DistanceCompareOperations_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceCompareOperations");
		DistanceCompareOperations_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceCompareOperations", Classes.FEnumProperty);
		DistanceCompareValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceCompareValue");
		DistanceCompareValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceCompareValue", Classes.FFloatProperty);
		CustomFsmState_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomFsmState");
		CustomFsmState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomFsmState", Classes.FStructProperty);
		CompareValueInt_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompareValueInt");
		CompareValueInt_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompareValueInt", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BaseDirection_PropertyAddress, intPtr, "BaseDirection");
		BaseDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "BaseDirection");
		BaseDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BaseDirection", Classes.FEnumProperty);
		MinYawAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinYawAngle");
		MinYawAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinYawAngle", Classes.FFloatProperty);
		MaxYawAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxYawAngle");
		MaxYawAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxYawAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SkillIdList_PropertyAddress, intPtr, "SkillIdList");
		SkillIdList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillIdList");
		SkillIdList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillIdList", Classes.FArrayProperty);
		MatchInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "MatchInfo");
		MatchInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MatchInfo", Classes.FStructProperty);
		ResId_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResId");
		ResId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResId", Classes.FIntProperty);
		SuccessRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "SuccessRate");
		SuccessRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SuccessRate", Classes.FFloatProperty);
		AliveUnitNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliveUnitNum");
		AliveUnitNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliveUnitNum", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OperationType_PropertyAddress, intPtr, "OperationType");
		OperationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OperationType");
		OperationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OperationType", Classes.FEnumProperty);
		GamePlusCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "GamePlusCount");
		GamePlusCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GamePlusCount", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SurfaceType_PropertyAddress, intPtr, "SurfaceType");
		SurfaceType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SurfaceType");
		SurfaceType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SurfaceType", Classes.FEnumProperty);
		PlayerLeisureOverTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerLeisureOverTime");
		PlayerLeisureOverTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerLeisureOverTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bReverseCondition_PropertyAddress, intPtr, "bReverseCondition");
		bReverseCondition_Offset = NativeReflection.GetPropertyOffset(intPtr, "bReverseCondition");
		bReverseCondition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bReverseCondition", Classes.FBoolProperty);
		Comment_Offset = NativeReflection.GetPropertyOffset(intPtr, "Comment");
		Comment_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Comment", Classes.FStrProperty);
		DetectCondition_IsValid = ((intPtr != IntPtr.Zero && DetectedElementType_IsValid && SimpleState_IsValid && UnitState_IsValid && BuffId_IsValid && AttrFloatType_IsValid && CompareOperation_IsValid && CompareValue_IsValid && AbnormalStateType_IsValid && FsmState_IsValid && SkillId_IsValid && DistanceCompareOperations_IsValid && DistanceCompareValue_IsValid && CustomFsmState_IsValid && CompareValueInt_IsValid && BaseDirection_IsValid && MinYawAngle_IsValid && MaxYawAngle_IsValid && SkillIdList_IsValid && MatchInfo_IsValid && ResId_IsValid && SuccessRate_IsValid && AliveUnitNum_IsValid && BuffLayer_IsValid && OperationType_IsValid && GamePlusCount_IsValid && SurfaceType_IsValid && PlayerLeisureOverTime_IsValid && bReverseCondition_IsValid && Comment_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition", (byte)DetectCondition_IsValid != 0);
	}

	static FDetectCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition));
	}
}
