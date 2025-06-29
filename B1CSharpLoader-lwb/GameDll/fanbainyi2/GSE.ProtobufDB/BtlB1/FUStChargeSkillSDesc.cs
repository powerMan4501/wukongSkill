using System;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStChargeSkillSDesc : IMessage<FUStChargeSkillSDesc>, IMessage, IEquatable<FUStChargeSkillSDesc>, IDeepCloneable<FUStChargeSkillSDesc>
{
	private static readonly MessageParser<FUStChargeSkillSDesc> _parser = new MessageParser<FUStChargeSkillSDesc>(() => new FUStChargeSkillSDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string loopTemplatePath_ = "";

	private EGSYesNo loopCanMove_;

	private EGSYesNo loopCanRotate_;

	private EMoveSpeedType chargeMoveSpeedRate_;

	private float maxChargeTime_;

	private EGSYesNo triggerNextStageWhenOnLand_;

	private EGSYesNo triggerNextStageUseFSM_;

	private int nextStageSkillID_;

	private int endSkillID_;

	private EGSYesNo autoEndWhenLockTarget_;

	private static readonly FieldCodec<FUStChargeSkillBuffInfo> _repeated_chargeSkillBuffInfoList_codec = FieldCodec.ForMessage(98u, FUStChargeSkillBuffInfo.Parser);

	private readonly RepeatedField<FUStChargeSkillBuffInfo> chargeSkillBuffInfoList_ = new RepeatedField<FUStChargeSkillBuffInfo>();

	private FUStChargeSkillSuperArmorInfo chargeSkillSuperArmorInfo_;

	private string chargeLevelConfigPath_ = "";

	private int chargeLevelConfigIndex_;

	public static MessageParser<FUStChargeSkillSDesc> Parser => _parser;

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

	public string LoopTemplatePath
	{
		get
		{
			return loopTemplatePath_;
		}
		set
		{
			loopTemplatePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EGSYesNo LoopCanMove
	{
		get
		{
			return loopCanMove_;
		}
		set
		{
			loopCanMove_ = value;
		}
	}

	public EGSYesNo LoopCanRotate
	{
		get
		{
			return loopCanRotate_;
		}
		set
		{
			loopCanRotate_ = value;
		}
	}

	public EMoveSpeedType ChargeMoveSpeedRate
	{
		get
		{
			return chargeMoveSpeedRate_;
		}
		set
		{
			chargeMoveSpeedRate_ = value;
		}
	}

	public float MaxChargeTime
	{
		get
		{
			return maxChargeTime_;
		}
		set
		{
			maxChargeTime_ = value;
		}
	}

	public EGSYesNo TriggerNextStageWhenOnLand
	{
		get
		{
			return triggerNextStageWhenOnLand_;
		}
		set
		{
			triggerNextStageWhenOnLand_ = value;
		}
	}

	public EGSYesNo TriggerNextStageUseFSM
	{
		get
		{
			return triggerNextStageUseFSM_;
		}
		set
		{
			triggerNextStageUseFSM_ = value;
		}
	}

	public int NextStageSkillID
	{
		get
		{
			return nextStageSkillID_;
		}
		set
		{
			nextStageSkillID_ = value;
		}
	}

	public int EndSkillID
	{
		get
		{
			return endSkillID_;
		}
		set
		{
			endSkillID_ = value;
		}
	}

	public EGSYesNo AutoEndWhenLockTarget
	{
		get
		{
			return autoEndWhenLockTarget_;
		}
		set
		{
			autoEndWhenLockTarget_ = value;
		}
	}

	public RepeatedField<FUStChargeSkillBuffInfo> ChargeSkillBuffInfoList => chargeSkillBuffInfoList_;

	public FUStChargeSkillSuperArmorInfo ChargeSkillSuperArmorInfo
	{
		get
		{
			return chargeSkillSuperArmorInfo_;
		}
		set
		{
			chargeSkillSuperArmorInfo_ = value;
		}
	}

	public string ChargeLevelConfigPath
	{
		get
		{
			return chargeLevelConfigPath_;
		}
		set
		{
			chargeLevelConfigPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ChargeLevelConfigIndex
	{
		get
		{
			return chargeLevelConfigIndex_;
		}
		set
		{
			chargeLevelConfigIndex_ = value;
		}
	}

	public FUStChargeSkillSDesc()
	{
	}

	public FUStChargeSkillSDesc(FUStChargeSkillSDesc other)
		: this()
	{
		iD_ = other.iD_;
		loopTemplatePath_ = other.loopTemplatePath_;
		loopCanMove_ = other.loopCanMove_;
		loopCanRotate_ = other.loopCanRotate_;
		chargeMoveSpeedRate_ = other.chargeMoveSpeedRate_;
		maxChargeTime_ = other.maxChargeTime_;
		triggerNextStageWhenOnLand_ = other.triggerNextStageWhenOnLand_;
		triggerNextStageUseFSM_ = other.triggerNextStageUseFSM_;
		nextStageSkillID_ = other.nextStageSkillID_;
		endSkillID_ = other.endSkillID_;
		autoEndWhenLockTarget_ = other.autoEndWhenLockTarget_;
		chargeSkillBuffInfoList_ = other.chargeSkillBuffInfoList_.Clone();
		chargeSkillSuperArmorInfo_ = ((other.chargeSkillSuperArmorInfo_ != null) ? other.chargeSkillSuperArmorInfo_.Clone() : null);
		chargeLevelConfigPath_ = other.chargeLevelConfigPath_;
		chargeLevelConfigIndex_ = other.chargeLevelConfigIndex_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStChargeSkillSDesc Clone()
	{
		return new FUStChargeSkillSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStChargeSkillSDesc);
	}

	public bool Equals(FUStChargeSkillSDesc other)
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
		if (LoopTemplatePath != other.LoopTemplatePath)
		{
			return false;
		}
		if (LoopCanMove != other.LoopCanMove)
		{
			return false;
		}
		if (LoopCanRotate != other.LoopCanRotate)
		{
			return false;
		}
		if (ChargeMoveSpeedRate != other.ChargeMoveSpeedRate)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxChargeTime, other.MaxChargeTime))
		{
			return false;
		}
		if (TriggerNextStageWhenOnLand != other.TriggerNextStageWhenOnLand)
		{
			return false;
		}
		if (TriggerNextStageUseFSM != other.TriggerNextStageUseFSM)
		{
			return false;
		}
		if (NextStageSkillID != other.NextStageSkillID)
		{
			return false;
		}
		if (EndSkillID != other.EndSkillID)
		{
			return false;
		}
		if (AutoEndWhenLockTarget != other.AutoEndWhenLockTarget)
		{
			return false;
		}
		if (!chargeSkillBuffInfoList_.Equals(other.chargeSkillBuffInfoList_))
		{
			return false;
		}
		if (!object.Equals(ChargeSkillSuperArmorInfo, other.ChargeSkillSuperArmorInfo))
		{
			return false;
		}
		if (ChargeLevelConfigPath != other.ChargeLevelConfigPath)
		{
			return false;
		}
		if (ChargeLevelConfigIndex != other.ChargeLevelConfigIndex)
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
		if (LoopTemplatePath.Length != 0)
		{
			num ^= LoopTemplatePath.GetHashCode();
		}
		if (LoopCanMove != EGSYesNo.No)
		{
			num ^= LoopCanMove.GetHashCode();
		}
		if (LoopCanRotate != EGSYesNo.No)
		{
			num ^= LoopCanRotate.GetHashCode();
		}
		if (ChargeMoveSpeedRate != EMoveSpeedType.Walk)
		{
			num ^= ChargeMoveSpeedRate.GetHashCode();
		}
		if (MaxChargeTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxChargeTime);
		}
		if (TriggerNextStageWhenOnLand != EGSYesNo.No)
		{
			num ^= TriggerNextStageWhenOnLand.GetHashCode();
		}
		if (TriggerNextStageUseFSM != EGSYesNo.No)
		{
			num ^= TriggerNextStageUseFSM.GetHashCode();
		}
		if (NextStageSkillID != 0)
		{
			num ^= NextStageSkillID.GetHashCode();
		}
		if (EndSkillID != 0)
		{
			num ^= EndSkillID.GetHashCode();
		}
		if (AutoEndWhenLockTarget != EGSYesNo.No)
		{
			num ^= AutoEndWhenLockTarget.GetHashCode();
		}
		num ^= chargeSkillBuffInfoList_.GetHashCode();
		if (chargeSkillSuperArmorInfo_ != null)
		{
			num ^= ChargeSkillSuperArmorInfo.GetHashCode();
		}
		if (ChargeLevelConfigPath.Length != 0)
		{
			num ^= ChargeLevelConfigPath.GetHashCode();
		}
		if (ChargeLevelConfigIndex != 0)
		{
			num ^= ChargeLevelConfigIndex.GetHashCode();
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
		if (LoopTemplatePath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(LoopTemplatePath);
		}
		if (LoopCanMove != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LoopCanMove);
		}
		if (LoopCanRotate != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)LoopCanRotate);
		}
		if (ChargeMoveSpeedRate != EMoveSpeedType.Walk)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)ChargeMoveSpeedRate);
		}
		if (MaxChargeTime != 0f)
		{
			output.WriteRawTag(53);
			output.WriteFloat(MaxChargeTime);
		}
		if (TriggerNextStageWhenOnLand != EGSYesNo.No)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)TriggerNextStageWhenOnLand);
		}
		if (TriggerNextStageUseFSM != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)TriggerNextStageUseFSM);
		}
		if (NextStageSkillID != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(NextStageSkillID);
		}
		if (EndSkillID != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(EndSkillID);
		}
		if (AutoEndWhenLockTarget != EGSYesNo.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)AutoEndWhenLockTarget);
		}
		chargeSkillBuffInfoList_.WriteTo(output, _repeated_chargeSkillBuffInfoList_codec);
		if (chargeSkillSuperArmorInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(ChargeSkillSuperArmorInfo);
		}
		if (ChargeLevelConfigPath.Length != 0)
		{
			output.WriteRawTag(114);
			output.WriteString(ChargeLevelConfigPath);
		}
		if (ChargeLevelConfigIndex != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(ChargeLevelConfigIndex);
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
		if (LoopTemplatePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LoopTemplatePath);
		}
		if (LoopCanMove != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LoopCanMove);
		}
		if (LoopCanRotate != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LoopCanRotate);
		}
		if (ChargeMoveSpeedRate != EMoveSpeedType.Walk)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ChargeMoveSpeedRate);
		}
		if (MaxChargeTime != 0f)
		{
			num += 5;
		}
		if (TriggerNextStageWhenOnLand != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TriggerNextStageWhenOnLand);
		}
		if (TriggerNextStageUseFSM != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TriggerNextStageUseFSM);
		}
		if (NextStageSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NextStageSkillID);
		}
		if (EndSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EndSkillID);
		}
		if (AutoEndWhenLockTarget != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AutoEndWhenLockTarget);
		}
		num += chargeSkillBuffInfoList_.CalculateSize(_repeated_chargeSkillBuffInfoList_codec);
		if (chargeSkillSuperArmorInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChargeSkillSuperArmorInfo);
		}
		if (ChargeLevelConfigPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ChargeLevelConfigPath);
		}
		if (ChargeLevelConfigIndex != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChargeLevelConfigIndex);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStChargeSkillSDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.LoopTemplatePath.Length != 0)
		{
			LoopTemplatePath = other.LoopTemplatePath;
		}
		if (other.LoopCanMove != EGSYesNo.No)
		{
			LoopCanMove = other.LoopCanMove;
		}
		if (other.LoopCanRotate != EGSYesNo.No)
		{
			LoopCanRotate = other.LoopCanRotate;
		}
		if (other.ChargeMoveSpeedRate != EMoveSpeedType.Walk)
		{
			ChargeMoveSpeedRate = other.ChargeMoveSpeedRate;
		}
		if (other.MaxChargeTime != 0f)
		{
			MaxChargeTime = other.MaxChargeTime;
		}
		if (other.TriggerNextStageWhenOnLand != EGSYesNo.No)
		{
			TriggerNextStageWhenOnLand = other.TriggerNextStageWhenOnLand;
		}
		if (other.TriggerNextStageUseFSM != EGSYesNo.No)
		{
			TriggerNextStageUseFSM = other.TriggerNextStageUseFSM;
		}
		if (other.NextStageSkillID != 0)
		{
			NextStageSkillID = other.NextStageSkillID;
		}
		if (other.EndSkillID != 0)
		{
			EndSkillID = other.EndSkillID;
		}
		if (other.AutoEndWhenLockTarget != EGSYesNo.No)
		{
			AutoEndWhenLockTarget = other.AutoEndWhenLockTarget;
		}
		chargeSkillBuffInfoList_.Add(other.chargeSkillBuffInfoList_);
		if (other.chargeSkillSuperArmorInfo_ != null)
		{
			if (chargeSkillSuperArmorInfo_ == null)
			{
				ChargeSkillSuperArmorInfo = new FUStChargeSkillSuperArmorInfo();
			}
			ChargeSkillSuperArmorInfo.MergeFrom(other.ChargeSkillSuperArmorInfo);
		}
		if (other.ChargeLevelConfigPath.Length != 0)
		{
			ChargeLevelConfigPath = other.ChargeLevelConfigPath;
		}
		if (other.ChargeLevelConfigIndex != 0)
		{
			ChargeLevelConfigIndex = other.ChargeLevelConfigIndex;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				LoopTemplatePath = input.ReadString();
				break;
			case 24u:
				LoopCanMove = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
				LoopCanRotate = (EGSYesNo)input.ReadEnum();
				break;
			case 40u:
				ChargeMoveSpeedRate = (EMoveSpeedType)input.ReadEnum();
				break;
			case 53u:
				MaxChargeTime = input.ReadFloat();
				break;
			case 56u:
				TriggerNextStageWhenOnLand = (EGSYesNo)input.ReadEnum();
				break;
			case 64u:
				TriggerNextStageUseFSM = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				NextStageSkillID = input.ReadInt32();
				break;
			case 80u:
				EndSkillID = input.ReadInt32();
				break;
			case 88u:
				AutoEndWhenLockTarget = (EGSYesNo)input.ReadEnum();
				break;
			case 98u:
				chargeSkillBuffInfoList_.AddEntriesFrom(input, _repeated_chargeSkillBuffInfoList_codec);
				break;
			case 106u:
				if (chargeSkillSuperArmorInfo_ == null)
				{
					ChargeSkillSuperArmorInfo = new FUStChargeSkillSuperArmorInfo();
				}
				input.ReadMessage(ChargeSkillSuperArmorInfo);
				break;
			case 114u:
				ChargeLevelConfigPath = input.ReadString();
				break;
			case 120u:
				ChargeLevelConfigIndex = input.ReadInt32();
				break;
			}
		}
	}
}
