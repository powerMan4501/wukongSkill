using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStInteractionMappingDesc : IMessage<FUStInteractionMappingDesc>, IMessage, IEquatable<FUStInteractionMappingDesc>, IDeepCloneable<FUStInteractionMappingDesc>
{
	private static readonly MessageParser<FUStInteractionMappingDesc> _parser = new MessageParser<FUStInteractionMappingDesc>(() => new FUStInteractionMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int originID_;

	private int groupID_;

	private EInterActMappingCondition condition_;

	private int param1_;

	private int param2_;

	private EInteractAction interactAction_;

	private EGSYesNo actionCanInteract_;

	private EGSYesNo resetAction_;

	private EGSYesNo canBreak_;

	private EGSYesNo breakAsFinish_;

	private int coolDown_;

	private string interactName_ = "";

	private float interactInputTime_;

	private static readonly FieldCodec<int> _repeated_paramsInt_codec = FieldCodec.ForInt32(122u);

	private readonly RepeatedField<int> paramsInt_ = new RepeatedField<int>();

	private static readonly FieldCodec<string> _repeated_paramsString_codec = FieldCodec.ForString(130u);

	private readonly RepeatedField<string> paramsString_ = new RepeatedField<string>();

	private EGSYesNo paramsBool_;

	private EInteractLockAction lockAction_;

	private string cameraCompTag_ = "";

	private string cameraBlendTime_ = "";

	private EInteractCameraEffect cameraEffect_;

	private int nPCCameraID_;

	private EGSYesNo returnPlayerCamera_;

	private EMatchingPosType matchingPosType_;

	private string mathchingPointCompTag_ = "";

	private EGSYesNo isMatchingPointTraceToPlayer_;

	private EMoveSpeedType matchingPosMoveSpeedType_;

	private EGSYesNo matchingPosFacingTarget_;

	private float acceptableRadius_;

	private float interpMoveTime_;

	private EGSYesNo needBlackOut_;

	private float graphTriggerTime_;

	private string idleBefore_ = "";

	private string idleAfter_ = "";

	private EGSYesNo hideIfCantInteract_;

	private int interactFinishChangeIdleAnimIdx_;

	private string initAnim_ = "";

	private static readonly FieldCodec<FUStInteractCondition> _repeated_interactCondition_codec = FieldCodec.ForMessage(306u, FUStInteractCondition.Parser);

	private readonly RepeatedField<FUStInteractCondition> interactCondition_ = new RepeatedField<FUStInteractCondition>();

	private int localizationTag_;

	private int triggerActionID_;

	public static MessageParser<FUStInteractionMappingDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int OriginID
	{
		get
		{
			return originID_;
		}
		set
		{
			originID_ = value;
		}
	}

	public int GroupID
	{
		get
		{
			return groupID_;
		}
		set
		{
			groupID_ = value;
		}
	}

	public EInterActMappingCondition Condition
	{
		get
		{
			return condition_;
		}
		set
		{
			condition_ = value;
		}
	}

	public int Param1
	{
		get
		{
			return param1_;
		}
		set
		{
			param1_ = value;
		}
	}

	public int Param2
	{
		get
		{
			return param2_;
		}
		set
		{
			param2_ = value;
		}
	}

	public EInteractAction InteractAction
	{
		get
		{
			return interactAction_;
		}
		set
		{
			interactAction_ = value;
		}
	}

	public EGSYesNo ActionCanInteract
	{
		get
		{
			return actionCanInteract_;
		}
		set
		{
			actionCanInteract_ = value;
		}
	}

	public EGSYesNo ResetAction
	{
		get
		{
			return resetAction_;
		}
		set
		{
			resetAction_ = value;
		}
	}

	public EGSYesNo CanBreak
	{
		get
		{
			return canBreak_;
		}
		set
		{
			canBreak_ = value;
		}
	}

	public EGSYesNo BreakAsFinish
	{
		get
		{
			return breakAsFinish_;
		}
		set
		{
			breakAsFinish_ = value;
		}
	}

	public int CoolDown
	{
		get
		{
			return coolDown_;
		}
		set
		{
			coolDown_ = value;
		}
	}

	public string InteractName
	{
		get
		{
			return interactName_;
		}
		set
		{
			interactName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float InteractInputTime
	{
		get
		{
			return interactInputTime_;
		}
		set
		{
			interactInputTime_ = value;
		}
	}

	public RepeatedField<int> ParamsInt => paramsInt_;

	public RepeatedField<string> ParamsString => paramsString_;

	public EGSYesNo ParamsBool
	{
		get
		{
			return paramsBool_;
		}
		set
		{
			paramsBool_ = value;
		}
	}

	public EInteractLockAction LockAction
	{
		get
		{
			return lockAction_;
		}
		set
		{
			lockAction_ = value;
		}
	}

	public string CameraCompTag
	{
		get
		{
			return cameraCompTag_;
		}
		set
		{
			cameraCompTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CameraBlendTime
	{
		get
		{
			return cameraBlendTime_;
		}
		set
		{
			cameraBlendTime_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EInteractCameraEffect CameraEffect
	{
		get
		{
			return cameraEffect_;
		}
		set
		{
			cameraEffect_ = value;
		}
	}

	public int NPCCameraID
	{
		get
		{
			return nPCCameraID_;
		}
		set
		{
			nPCCameraID_ = value;
		}
	}

	public EGSYesNo ReturnPlayerCamera
	{
		get
		{
			return returnPlayerCamera_;
		}
		set
		{
			returnPlayerCamera_ = value;
		}
	}

	public EMatchingPosType MatchingPosType
	{
		get
		{
			return matchingPosType_;
		}
		set
		{
			matchingPosType_ = value;
		}
	}

	public string MathchingPointCompTag
	{
		get
		{
			return mathchingPointCompTag_;
		}
		set
		{
			mathchingPointCompTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo IsMatchingPointTraceToPlayer
	{
		get
		{
			return isMatchingPointTraceToPlayer_;
		}
		set
		{
			isMatchingPointTraceToPlayer_ = value;
		}
	}

	public EMoveSpeedType MatchingPosMoveSpeedType
	{
		get
		{
			return matchingPosMoveSpeedType_;
		}
		set
		{
			matchingPosMoveSpeedType_ = value;
		}
	}

	public EGSYesNo MatchingPosFacingTarget
	{
		get
		{
			return matchingPosFacingTarget_;
		}
		set
		{
			matchingPosFacingTarget_ = value;
		}
	}

	public float AcceptableRadius
	{
		get
		{
			return acceptableRadius_;
		}
		set
		{
			acceptableRadius_ = value;
		}
	}

	public float InterpMoveTime
	{
		get
		{
			return interpMoveTime_;
		}
		set
		{
			interpMoveTime_ = value;
		}
	}

	public EGSYesNo NeedBlackOut
	{
		get
		{
			return needBlackOut_;
		}
		set
		{
			needBlackOut_ = value;
		}
	}

	public float GraphTriggerTime
	{
		get
		{
			return graphTriggerTime_;
		}
		set
		{
			graphTriggerTime_ = value;
		}
	}

	public string IdleBefore
	{
		get
		{
			return idleBefore_;
		}
		set
		{
			idleBefore_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string IdleAfter
	{
		get
		{
			return idleAfter_;
		}
		set
		{
			idleAfter_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo HideIfCantInteract
	{
		get
		{
			return hideIfCantInteract_;
		}
		set
		{
			hideIfCantInteract_ = value;
		}
	}

	public int InteractFinishChangeIdleAnimIdx
	{
		get
		{
			return interactFinishChangeIdleAnimIdx_;
		}
		set
		{
			interactFinishChangeIdleAnimIdx_ = value;
		}
	}

	public string InitAnim
	{
		get
		{
			return initAnim_;
		}
		set
		{
			initAnim_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<FUStInteractCondition> InteractCondition => interactCondition_;

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public int TriggerActionID
	{
		get
		{
			return triggerActionID_;
		}
		set
		{
			triggerActionID_ = value;
		}
	}

	public FUStInteractionMappingDesc()
	{
	}

	public FUStInteractionMappingDesc(FUStInteractionMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		originID_ = other.originID_;
		groupID_ = other.groupID_;
		condition_ = other.condition_;
		param1_ = other.param1_;
		param2_ = other.param2_;
		interactAction_ = other.interactAction_;
		actionCanInteract_ = other.actionCanInteract_;
		resetAction_ = other.resetAction_;
		canBreak_ = other.canBreak_;
		breakAsFinish_ = other.breakAsFinish_;
		coolDown_ = other.coolDown_;
		interactName_ = other.interactName_;
		interactInputTime_ = other.interactInputTime_;
		paramsInt_ = other.paramsInt_.Clone();
		paramsString_ = other.paramsString_.Clone();
		paramsBool_ = other.paramsBool_;
		lockAction_ = other.lockAction_;
		cameraCompTag_ = other.cameraCompTag_;
		cameraBlendTime_ = other.cameraBlendTime_;
		cameraEffect_ = other.cameraEffect_;
		nPCCameraID_ = other.nPCCameraID_;
		returnPlayerCamera_ = other.returnPlayerCamera_;
		matchingPosType_ = other.matchingPosType_;
		mathchingPointCompTag_ = other.mathchingPointCompTag_;
		isMatchingPointTraceToPlayer_ = other.isMatchingPointTraceToPlayer_;
		matchingPosMoveSpeedType_ = other.matchingPosMoveSpeedType_;
		matchingPosFacingTarget_ = other.matchingPosFacingTarget_;
		acceptableRadius_ = other.acceptableRadius_;
		interpMoveTime_ = other.interpMoveTime_;
		needBlackOut_ = other.needBlackOut_;
		graphTriggerTime_ = other.graphTriggerTime_;
		idleBefore_ = other.idleBefore_;
		idleAfter_ = other.idleAfter_;
		hideIfCantInteract_ = other.hideIfCantInteract_;
		interactFinishChangeIdleAnimIdx_ = other.interactFinishChangeIdleAnimIdx_;
		initAnim_ = other.initAnim_;
		interactCondition_ = other.interactCondition_.Clone();
		localizationTag_ = other.localizationTag_;
		triggerActionID_ = other.triggerActionID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStInteractionMappingDesc Clone()
	{
		return new FUStInteractionMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStInteractionMappingDesc);
	}

	public bool Equals(FUStInteractionMappingDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (OriginID != other.OriginID)
		{
			return false;
		}
		if (GroupID != other.GroupID)
		{
			return false;
		}
		if (Condition != other.Condition)
		{
			return false;
		}
		if (Param1 != other.Param1)
		{
			return false;
		}
		if (Param2 != other.Param2)
		{
			return false;
		}
		if (InteractAction != other.InteractAction)
		{
			return false;
		}
		if (ActionCanInteract != other.ActionCanInteract)
		{
			return false;
		}
		if (ResetAction != other.ResetAction)
		{
			return false;
		}
		if (CanBreak != other.CanBreak)
		{
			return false;
		}
		if (BreakAsFinish != other.BreakAsFinish)
		{
			return false;
		}
		if (CoolDown != other.CoolDown)
		{
			return false;
		}
		if (InteractName != other.InteractName)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InteractInputTime, other.InteractInputTime))
		{
			return false;
		}
		if (!paramsInt_.Equals(other.paramsInt_))
		{
			return false;
		}
		if (!paramsString_.Equals(other.paramsString_))
		{
			return false;
		}
		if (ParamsBool != other.ParamsBool)
		{
			return false;
		}
		if (LockAction != other.LockAction)
		{
			return false;
		}
		if (CameraCompTag != other.CameraCompTag)
		{
			return false;
		}
		if (CameraBlendTime != other.CameraBlendTime)
		{
			return false;
		}
		if (CameraEffect != other.CameraEffect)
		{
			return false;
		}
		if (NPCCameraID != other.NPCCameraID)
		{
			return false;
		}
		if (ReturnPlayerCamera != other.ReturnPlayerCamera)
		{
			return false;
		}
		if (MatchingPosType != other.MatchingPosType)
		{
			return false;
		}
		if (MathchingPointCompTag != other.MathchingPointCompTag)
		{
			return false;
		}
		if (IsMatchingPointTraceToPlayer != other.IsMatchingPointTraceToPlayer)
		{
			return false;
		}
		if (MatchingPosMoveSpeedType != other.MatchingPosMoveSpeedType)
		{
			return false;
		}
		if (MatchingPosFacingTarget != other.MatchingPosFacingTarget)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AcceptableRadius, other.AcceptableRadius))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(InterpMoveTime, other.InterpMoveTime))
		{
			return false;
		}
		if (NeedBlackOut != other.NeedBlackOut)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(GraphTriggerTime, other.GraphTriggerTime))
		{
			return false;
		}
		if (IdleBefore != other.IdleBefore)
		{
			return false;
		}
		if (IdleAfter != other.IdleAfter)
		{
			return false;
		}
		if (HideIfCantInteract != other.HideIfCantInteract)
		{
			return false;
		}
		if (InteractFinishChangeIdleAnimIdx != other.InteractFinishChangeIdleAnimIdx)
		{
			return false;
		}
		if (InitAnim != other.InitAnim)
		{
			return false;
		}
		if (!interactCondition_.Equals(other.interactCondition_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (TriggerActionID != other.TriggerActionID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (OriginID != 0)
		{
			num ^= OriginID.GetHashCode();
		}
		if (GroupID != 0)
		{
			num ^= GroupID.GetHashCode();
		}
		if (Condition != EInterActMappingCondition.Default)
		{
			num ^= Condition.GetHashCode();
		}
		if (Param1 != 0)
		{
			num ^= Param1.GetHashCode();
		}
		if (Param2 != 0)
		{
			num ^= Param2.GetHashCode();
		}
		if (InteractAction != EInteractAction.None)
		{
			num ^= InteractAction.GetHashCode();
		}
		if (ActionCanInteract != EGSYesNo.No)
		{
			num ^= ActionCanInteract.GetHashCode();
		}
		if (ResetAction != EGSYesNo.No)
		{
			num ^= ResetAction.GetHashCode();
		}
		if (CanBreak != EGSYesNo.No)
		{
			num ^= CanBreak.GetHashCode();
		}
		if (BreakAsFinish != EGSYesNo.No)
		{
			num ^= BreakAsFinish.GetHashCode();
		}
		if (CoolDown != 0)
		{
			num ^= CoolDown.GetHashCode();
		}
		if (InteractName.Length != 0)
		{
			num ^= InteractName.GetHashCode();
		}
		if (InteractInputTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InteractInputTime);
		}
		num ^= paramsInt_.GetHashCode();
		num ^= paramsString_.GetHashCode();
		if (ParamsBool != EGSYesNo.No)
		{
			num ^= ParamsBool.GetHashCode();
		}
		if (LockAction != EInteractLockAction.None)
		{
			num ^= LockAction.GetHashCode();
		}
		if (CameraCompTag.Length != 0)
		{
			num ^= CameraCompTag.GetHashCode();
		}
		if (CameraBlendTime.Length != 0)
		{
			num ^= CameraBlendTime.GetHashCode();
		}
		if (CameraEffect != EInteractCameraEffect.None)
		{
			num ^= CameraEffect.GetHashCode();
		}
		if (NPCCameraID != 0)
		{
			num ^= NPCCameraID.GetHashCode();
		}
		if (ReturnPlayerCamera != EGSYesNo.No)
		{
			num ^= ReturnPlayerCamera.GetHashCode();
		}
		if (MatchingPosType != EMatchingPosType.None)
		{
			num ^= MatchingPosType.GetHashCode();
		}
		if (MathchingPointCompTag.Length != 0)
		{
			num ^= MathchingPointCompTag.GetHashCode();
		}
		if (IsMatchingPointTraceToPlayer != EGSYesNo.No)
		{
			num ^= IsMatchingPointTraceToPlayer.GetHashCode();
		}
		if (MatchingPosMoveSpeedType != EMoveSpeedType.Walk)
		{
			num ^= MatchingPosMoveSpeedType.GetHashCode();
		}
		if (MatchingPosFacingTarget != EGSYesNo.No)
		{
			num ^= MatchingPosFacingTarget.GetHashCode();
		}
		if (AcceptableRadius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AcceptableRadius);
		}
		if (InterpMoveTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(InterpMoveTime);
		}
		if (NeedBlackOut != EGSYesNo.No)
		{
			num ^= NeedBlackOut.GetHashCode();
		}
		if (GraphTriggerTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(GraphTriggerTime);
		}
		if (IdleBefore.Length != 0)
		{
			num ^= IdleBefore.GetHashCode();
		}
		if (IdleAfter.Length != 0)
		{
			num ^= IdleAfter.GetHashCode();
		}
		if (HideIfCantInteract != EGSYesNo.No)
		{
			num ^= HideIfCantInteract.GetHashCode();
		}
		if (InteractFinishChangeIdleAnimIdx != 0)
		{
			num ^= InteractFinishChangeIdleAnimIdx.GetHashCode();
		}
		if (InitAnim.Length != 0)
		{
			num ^= InitAnim.GetHashCode();
		}
		num ^= interactCondition_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (TriggerActionID != 0)
		{
			num ^= TriggerActionID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (OriginID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OriginID);
		}
		if (GroupID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(GroupID);
		}
		if (Condition != EInterActMappingCondition.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Condition);
		}
		if (Param1 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Param1);
		}
		if (Param2 != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Param2);
		}
		if (InteractAction != EInteractAction.None)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)InteractAction);
		}
		if (ActionCanInteract != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)ActionCanInteract);
		}
		if (ResetAction != EGSYesNo.No)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)ResetAction);
		}
		if (CanBreak != EGSYesNo.No)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)CanBreak);
		}
		if (BreakAsFinish != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)BreakAsFinish);
		}
		if (CoolDown != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(CoolDown);
		}
		if (InteractName.Length != 0)
		{
			output.WriteRawTag(106);
			output.WriteString(InteractName);
		}
		if (InteractInputTime != 0f)
		{
			output.WriteRawTag(117);
			output.WriteFloat(InteractInputTime);
		}
		paramsInt_.WriteTo(output, _repeated_paramsInt_codec);
		paramsString_.WriteTo(output, _repeated_paramsString_codec);
		if (ParamsBool != EGSYesNo.No)
		{
			output.WriteRawTag(136, 1);
			output.WriteEnum((int)ParamsBool);
		}
		if (LockAction != EInteractLockAction.None)
		{
			output.WriteRawTag(144, 1);
			output.WriteEnum((int)LockAction);
		}
		if (CameraCompTag.Length != 0)
		{
			output.WriteRawTag(154, 1);
			output.WriteString(CameraCompTag);
		}
		if (CameraBlendTime.Length != 0)
		{
			output.WriteRawTag(162, 1);
			output.WriteString(CameraBlendTime);
		}
		if (CameraEffect != EInteractCameraEffect.None)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)CameraEffect);
		}
		if (NPCCameraID != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(NPCCameraID);
		}
		if (ReturnPlayerCamera != EGSYesNo.No)
		{
			output.WriteRawTag(184, 1);
			output.WriteEnum((int)ReturnPlayerCamera);
		}
		if (MatchingPosType != EMatchingPosType.None)
		{
			output.WriteRawTag(192, 1);
			output.WriteEnum((int)MatchingPosType);
		}
		if (MathchingPointCompTag.Length != 0)
		{
			output.WriteRawTag(202, 1);
			output.WriteString(MathchingPointCompTag);
		}
		if (IsMatchingPointTraceToPlayer != EGSYesNo.No)
		{
			output.WriteRawTag(208, 1);
			output.WriteEnum((int)IsMatchingPointTraceToPlayer);
		}
		if (MatchingPosMoveSpeedType != EMoveSpeedType.Walk)
		{
			output.WriteRawTag(216, 1);
			output.WriteEnum((int)MatchingPosMoveSpeedType);
		}
		if (MatchingPosFacingTarget != EGSYesNo.No)
		{
			output.WriteRawTag(224, 1);
			output.WriteEnum((int)MatchingPosFacingTarget);
		}
		if (AcceptableRadius != 0f)
		{
			output.WriteRawTag(237, 1);
			output.WriteFloat(AcceptableRadius);
		}
		if (InterpMoveTime != 0f)
		{
			output.WriteRawTag(245, 1);
			output.WriteFloat(InterpMoveTime);
		}
		if (NeedBlackOut != EGSYesNo.No)
		{
			output.WriteRawTag(248, 1);
			output.WriteEnum((int)NeedBlackOut);
		}
		if (GraphTriggerTime != 0f)
		{
			output.WriteRawTag(133, 2);
			output.WriteFloat(GraphTriggerTime);
		}
		if (IdleBefore.Length != 0)
		{
			output.WriteRawTag(138, 2);
			output.WriteString(IdleBefore);
		}
		if (IdleAfter.Length != 0)
		{
			output.WriteRawTag(146, 2);
			output.WriteString(IdleAfter);
		}
		if (HideIfCantInteract != EGSYesNo.No)
		{
			output.WriteRawTag(152, 2);
			output.WriteEnum((int)HideIfCantInteract);
		}
		if (InteractFinishChangeIdleAnimIdx != 0)
		{
			output.WriteRawTag(160, 2);
			output.WriteInt32(InteractFinishChangeIdleAnimIdx);
		}
		if (InitAnim.Length != 0)
		{
			output.WriteRawTag(170, 2);
			output.WriteString(InitAnim);
		}
		interactCondition_.WriteTo(output, _repeated_interactCondition_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(184, 2);
			output.WriteInt32(LocalizationTag);
		}
		if (TriggerActionID != 0)
		{
			output.WriteRawTag(192, 2);
			output.WriteInt32(TriggerActionID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (OriginID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OriginID);
		}
		if (GroupID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupID);
		}
		if (Condition != EInterActMappingCondition.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Condition);
		}
		if (Param1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param1);
		}
		if (Param2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param2);
		}
		if (InteractAction != EInteractAction.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)InteractAction);
		}
		if (ActionCanInteract != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ActionCanInteract);
		}
		if (ResetAction != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResetAction);
		}
		if (CanBreak != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanBreak);
		}
		if (BreakAsFinish != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BreakAsFinish);
		}
		if (CoolDown != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CoolDown);
		}
		if (InteractName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(InteractName);
		}
		if (InteractInputTime != 0f)
		{
			num += 5;
		}
		num += paramsInt_.CalculateSize(_repeated_paramsInt_codec);
		num += paramsString_.CalculateSize(_repeated_paramsString_codec);
		if (ParamsBool != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ParamsBool);
		}
		if (LockAction != EInteractLockAction.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)LockAction);
		}
		if (CameraCompTag.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CameraCompTag);
		}
		if (CameraBlendTime.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(CameraBlendTime);
		}
		if (CameraEffect != EInteractCameraEffect.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)CameraEffect);
		}
		if (NPCCameraID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NPCCameraID);
		}
		if (ReturnPlayerCamera != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)ReturnPlayerCamera);
		}
		if (MatchingPosType != EMatchingPosType.None)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)MatchingPosType);
		}
		if (MathchingPointCompTag.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MathchingPointCompTag);
		}
		if (IsMatchingPointTraceToPlayer != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)IsMatchingPointTraceToPlayer);
		}
		if (MatchingPosMoveSpeedType != EMoveSpeedType.Walk)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)MatchingPosMoveSpeedType);
		}
		if (MatchingPosFacingTarget != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)MatchingPosFacingTarget);
		}
		if (AcceptableRadius != 0f)
		{
			num += 6;
		}
		if (InterpMoveTime != 0f)
		{
			num += 6;
		}
		if (NeedBlackOut != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)NeedBlackOut);
		}
		if (GraphTriggerTime != 0f)
		{
			num += 6;
		}
		if (IdleBefore.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(IdleBefore);
		}
		if (IdleAfter.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(IdleAfter);
		}
		if (HideIfCantInteract != EGSYesNo.No)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)HideIfCantInteract);
		}
		if (InteractFinishChangeIdleAnimIdx != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(InteractFinishChangeIdleAnimIdx);
		}
		if (InitAnim.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(InitAnim);
		}
		num += interactCondition_.CalculateSize(_repeated_interactCondition_codec);
		if (LocalizationTag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (TriggerActionID != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(TriggerActionID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStInteractionMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.OriginID != 0)
			{
				OriginID = other.OriginID;
			}
			if (other.GroupID != 0)
			{
				GroupID = other.GroupID;
			}
			if (other.Condition != EInterActMappingCondition.Default)
			{
				Condition = other.Condition;
			}
			if (other.Param1 != 0)
			{
				Param1 = other.Param1;
			}
			if (other.Param2 != 0)
			{
				Param2 = other.Param2;
			}
			if (other.InteractAction != EInteractAction.None)
			{
				InteractAction = other.InteractAction;
			}
			if (other.ActionCanInteract != EGSYesNo.No)
			{
				ActionCanInteract = other.ActionCanInteract;
			}
			if (other.ResetAction != EGSYesNo.No)
			{
				ResetAction = other.ResetAction;
			}
			if (other.CanBreak != EGSYesNo.No)
			{
				CanBreak = other.CanBreak;
			}
			if (other.BreakAsFinish != EGSYesNo.No)
			{
				BreakAsFinish = other.BreakAsFinish;
			}
			if (other.CoolDown != 0)
			{
				CoolDown = other.CoolDown;
			}
			if (other.InteractName.Length != 0)
			{
				InteractName = other.InteractName;
			}
			if (other.InteractInputTime != 0f)
			{
				InteractInputTime = other.InteractInputTime;
			}
			paramsInt_.Add(other.paramsInt_);
			paramsString_.Add(other.paramsString_);
			if (other.ParamsBool != EGSYesNo.No)
			{
				ParamsBool = other.ParamsBool;
			}
			if (other.LockAction != EInteractLockAction.None)
			{
				LockAction = other.LockAction;
			}
			if (other.CameraCompTag.Length != 0)
			{
				CameraCompTag = other.CameraCompTag;
			}
			if (other.CameraBlendTime.Length != 0)
			{
				CameraBlendTime = other.CameraBlendTime;
			}
			if (other.CameraEffect != EInteractCameraEffect.None)
			{
				CameraEffect = other.CameraEffect;
			}
			if (other.NPCCameraID != 0)
			{
				NPCCameraID = other.NPCCameraID;
			}
			if (other.ReturnPlayerCamera != EGSYesNo.No)
			{
				ReturnPlayerCamera = other.ReturnPlayerCamera;
			}
			if (other.MatchingPosType != EMatchingPosType.None)
			{
				MatchingPosType = other.MatchingPosType;
			}
			if (other.MathchingPointCompTag.Length != 0)
			{
				MathchingPointCompTag = other.MathchingPointCompTag;
			}
			if (other.IsMatchingPointTraceToPlayer != EGSYesNo.No)
			{
				IsMatchingPointTraceToPlayer = other.IsMatchingPointTraceToPlayer;
			}
			if (other.MatchingPosMoveSpeedType != EMoveSpeedType.Walk)
			{
				MatchingPosMoveSpeedType = other.MatchingPosMoveSpeedType;
			}
			if (other.MatchingPosFacingTarget != EGSYesNo.No)
			{
				MatchingPosFacingTarget = other.MatchingPosFacingTarget;
			}
			if (other.AcceptableRadius != 0f)
			{
				AcceptableRadius = other.AcceptableRadius;
			}
			if (other.InterpMoveTime != 0f)
			{
				InterpMoveTime = other.InterpMoveTime;
			}
			if (other.NeedBlackOut != EGSYesNo.No)
			{
				NeedBlackOut = other.NeedBlackOut;
			}
			if (other.GraphTriggerTime != 0f)
			{
				GraphTriggerTime = other.GraphTriggerTime;
			}
			if (other.IdleBefore.Length != 0)
			{
				IdleBefore = other.IdleBefore;
			}
			if (other.IdleAfter.Length != 0)
			{
				IdleAfter = other.IdleAfter;
			}
			if (other.HideIfCantInteract != EGSYesNo.No)
			{
				HideIfCantInteract = other.HideIfCantInteract;
			}
			if (other.InteractFinishChangeIdleAnimIdx != 0)
			{
				InteractFinishChangeIdleAnimIdx = other.InteractFinishChangeIdleAnimIdx;
			}
			if (other.InitAnim.Length != 0)
			{
				InitAnim = other.InitAnim;
			}
			interactCondition_.Add(other.interactCondition_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.TriggerActionID != 0)
			{
				TriggerActionID = other.TriggerActionID;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				break;
			case 8u:
				ID = input.ReadInt32();
				break;
			case 16u:
				OriginID = input.ReadInt32();
				break;
			case 24u:
				GroupID = input.ReadInt32();
				break;
			case 32u:
				Condition = (EInterActMappingCondition)input.ReadEnum();
				break;
			case 40u:
				Param1 = input.ReadInt32();
				break;
			case 48u:
				Param2 = input.ReadInt32();
				break;
			case 56u:
				InteractAction = (EInteractAction)input.ReadEnum();
				break;
			case 64u:
				ActionCanInteract = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				ResetAction = (EGSYesNo)input.ReadEnum();
				break;
			case 80u:
				CanBreak = (EGSYesNo)input.ReadEnum();
				break;
			case 88u:
				BreakAsFinish = (EGSYesNo)input.ReadEnum();
				break;
			case 96u:
				CoolDown = input.ReadInt32();
				break;
			case 106u:
				InteractName = input.ReadString();
				break;
			case 117u:
				InteractInputTime = input.ReadFloat();
				break;
			case 120u:
			case 122u:
				paramsInt_.AddEntriesFrom(input, _repeated_paramsInt_codec);
				break;
			case 130u:
				paramsString_.AddEntriesFrom(input, _repeated_paramsString_codec);
				break;
			case 136u:
				ParamsBool = (EGSYesNo)input.ReadEnum();
				break;
			case 144u:
				LockAction = (EInteractLockAction)input.ReadEnum();
				break;
			case 154u:
				CameraCompTag = input.ReadString();
				break;
			case 162u:
				CameraBlendTime = input.ReadString();
				break;
			case 168u:
				CameraEffect = (EInteractCameraEffect)input.ReadEnum();
				break;
			case 176u:
				NPCCameraID = input.ReadInt32();
				break;
			case 184u:
				ReturnPlayerCamera = (EGSYesNo)input.ReadEnum();
				break;
			case 192u:
				MatchingPosType = (EMatchingPosType)input.ReadEnum();
				break;
			case 202u:
				MathchingPointCompTag = input.ReadString();
				break;
			case 208u:
				IsMatchingPointTraceToPlayer = (EGSYesNo)input.ReadEnum();
				break;
			case 216u:
				MatchingPosMoveSpeedType = (EMoveSpeedType)input.ReadEnum();
				break;
			case 224u:
				MatchingPosFacingTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 237u:
				AcceptableRadius = input.ReadFloat();
				break;
			case 245u:
				InterpMoveTime = input.ReadFloat();
				break;
			case 248u:
				NeedBlackOut = (EGSYesNo)input.ReadEnum();
				break;
			case 261u:
				GraphTriggerTime = input.ReadFloat();
				break;
			case 266u:
				IdleBefore = input.ReadString();
				break;
			case 274u:
				IdleAfter = input.ReadString();
				break;
			case 280u:
				HideIfCantInteract = (EGSYesNo)input.ReadEnum();
				break;
			case 288u:
				InteractFinishChangeIdleAnimIdx = input.ReadInt32();
				break;
			case 298u:
				InitAnim = input.ReadString();
				break;
			case 306u:
				interactCondition_.AddEntriesFrom(input, _repeated_interactCondition_codec);
				break;
			case 312u:
				LocalizationTag = input.ReadInt32();
				break;
			case 320u:
				TriggerActionID = input.ReadInt32();
				break;
			}
		}
	}
}
