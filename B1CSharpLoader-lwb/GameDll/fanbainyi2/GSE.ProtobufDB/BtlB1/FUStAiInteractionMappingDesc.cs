using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStAiInteractionMappingDesc : IMessage<FUStAiInteractionMappingDesc>, IMessage, IEquatable<FUStAiInteractionMappingDesc>, IDeepCloneable<FUStAiInteractionMappingDesc>
{
	private static readonly MessageParser<FUStAiInteractionMappingDesc> _parser = new MessageParser<FUStAiInteractionMappingDesc>(() => new FUStAiInteractionMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int originID_;

	private int groupID_;

	private string waitingPointCompTag_ = "";

	private string linerMatchingPointSpeedRateDistanceCurvePath_ = "";

	private int linerMatchingPointTeleportDistance_;

	private int linerMatchingPointTeleportSkillID_;

	private EGSYesNo enableCheckDistanceAfterTeleport_;

	private int linerMatchingPointTeleportFinishCheckDistance_;

	public static MessageParser<FUStAiInteractionMappingDesc> Parser => _parser;

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

	public string WaitingPointCompTag
	{
		get
		{
			return waitingPointCompTag_;
		}
		set
		{
			waitingPointCompTag_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string LinerMatchingPointSpeedRateDistanceCurvePath
	{
		get
		{
			return linerMatchingPointSpeedRateDistanceCurvePath_;
		}
		set
		{
			linerMatchingPointSpeedRateDistanceCurvePath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LinerMatchingPointTeleportDistance
	{
		get
		{
			return linerMatchingPointTeleportDistance_;
		}
		set
		{
			linerMatchingPointTeleportDistance_ = value;
		}
	}

	public int LinerMatchingPointTeleportSkillID
	{
		get
		{
			return linerMatchingPointTeleportSkillID_;
		}
		set
		{
			linerMatchingPointTeleportSkillID_ = value;
		}
	}

	public EGSYesNo EnableCheckDistanceAfterTeleport
	{
		get
		{
			return enableCheckDistanceAfterTeleport_;
		}
		set
		{
			enableCheckDistanceAfterTeleport_ = value;
		}
	}

	public int LinerMatchingPointTeleportFinishCheckDistance
	{
		get
		{
			return linerMatchingPointTeleportFinishCheckDistance_;
		}
		set
		{
			linerMatchingPointTeleportFinishCheckDistance_ = value;
		}
	}

	public FUStAiInteractionMappingDesc()
	{
	}

	public FUStAiInteractionMappingDesc(FUStAiInteractionMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		originID_ = other.originID_;
		groupID_ = other.groupID_;
		waitingPointCompTag_ = other.waitingPointCompTag_;
		linerMatchingPointSpeedRateDistanceCurvePath_ = other.linerMatchingPointSpeedRateDistanceCurvePath_;
		linerMatchingPointTeleportDistance_ = other.linerMatchingPointTeleportDistance_;
		linerMatchingPointTeleportSkillID_ = other.linerMatchingPointTeleportSkillID_;
		enableCheckDistanceAfterTeleport_ = other.enableCheckDistanceAfterTeleport_;
		linerMatchingPointTeleportFinishCheckDistance_ = other.linerMatchingPointTeleportFinishCheckDistance_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAiInteractionMappingDesc Clone()
	{
		return new FUStAiInteractionMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAiInteractionMappingDesc);
	}

	public bool Equals(FUStAiInteractionMappingDesc other)
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
		if (WaitingPointCompTag != other.WaitingPointCompTag)
		{
			return false;
		}
		if (LinerMatchingPointSpeedRateDistanceCurvePath != other.LinerMatchingPointSpeedRateDistanceCurvePath)
		{
			return false;
		}
		if (LinerMatchingPointTeleportDistance != other.LinerMatchingPointTeleportDistance)
		{
			return false;
		}
		if (LinerMatchingPointTeleportSkillID != other.LinerMatchingPointTeleportSkillID)
		{
			return false;
		}
		if (EnableCheckDistanceAfterTeleport != other.EnableCheckDistanceAfterTeleport)
		{
			return false;
		}
		if (LinerMatchingPointTeleportFinishCheckDistance != other.LinerMatchingPointTeleportFinishCheckDistance)
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
		if (WaitingPointCompTag.Length != 0)
		{
			num ^= WaitingPointCompTag.GetHashCode();
		}
		if (LinerMatchingPointSpeedRateDistanceCurvePath.Length != 0)
		{
			num ^= LinerMatchingPointSpeedRateDistanceCurvePath.GetHashCode();
		}
		if (LinerMatchingPointTeleportDistance != 0)
		{
			num ^= LinerMatchingPointTeleportDistance.GetHashCode();
		}
		if (LinerMatchingPointTeleportSkillID != 0)
		{
			num ^= LinerMatchingPointTeleportSkillID.GetHashCode();
		}
		if (EnableCheckDistanceAfterTeleport != EGSYesNo.No)
		{
			num ^= EnableCheckDistanceAfterTeleport.GetHashCode();
		}
		if (LinerMatchingPointTeleportFinishCheckDistance != 0)
		{
			num ^= LinerMatchingPointTeleportFinishCheckDistance.GetHashCode();
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
		if (WaitingPointCompTag.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(WaitingPointCompTag);
		}
		if (LinerMatchingPointSpeedRateDistanceCurvePath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(LinerMatchingPointSpeedRateDistanceCurvePath);
		}
		if (LinerMatchingPointTeleportDistance != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LinerMatchingPointTeleportDistance);
		}
		if (LinerMatchingPointTeleportSkillID != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LinerMatchingPointTeleportSkillID);
		}
		if (EnableCheckDistanceAfterTeleport != EGSYesNo.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)EnableCheckDistanceAfterTeleport);
		}
		if (LinerMatchingPointTeleportFinishCheckDistance != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LinerMatchingPointTeleportFinishCheckDistance);
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
		if (WaitingPointCompTag.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(WaitingPointCompTag);
		}
		if (LinerMatchingPointSpeedRateDistanceCurvePath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LinerMatchingPointSpeedRateDistanceCurvePath);
		}
		if (LinerMatchingPointTeleportDistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LinerMatchingPointTeleportDistance);
		}
		if (LinerMatchingPointTeleportSkillID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LinerMatchingPointTeleportSkillID);
		}
		if (EnableCheckDistanceAfterTeleport != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EnableCheckDistanceAfterTeleport);
		}
		if (LinerMatchingPointTeleportFinishCheckDistance != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LinerMatchingPointTeleportFinishCheckDistance);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAiInteractionMappingDesc other)
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
			if (other.WaitingPointCompTag.Length != 0)
			{
				WaitingPointCompTag = other.WaitingPointCompTag;
			}
			if (other.LinerMatchingPointSpeedRateDistanceCurvePath.Length != 0)
			{
				LinerMatchingPointSpeedRateDistanceCurvePath = other.LinerMatchingPointSpeedRateDistanceCurvePath;
			}
			if (other.LinerMatchingPointTeleportDistance != 0)
			{
				LinerMatchingPointTeleportDistance = other.LinerMatchingPointTeleportDistance;
			}
			if (other.LinerMatchingPointTeleportSkillID != 0)
			{
				LinerMatchingPointTeleportSkillID = other.LinerMatchingPointTeleportSkillID;
			}
			if (other.EnableCheckDistanceAfterTeleport != EGSYesNo.No)
			{
				EnableCheckDistanceAfterTeleport = other.EnableCheckDistanceAfterTeleport;
			}
			if (other.LinerMatchingPointTeleportFinishCheckDistance != 0)
			{
				LinerMatchingPointTeleportFinishCheckDistance = other.LinerMatchingPointTeleportFinishCheckDistance;
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
			case 34u:
				WaitingPointCompTag = input.ReadString();
				break;
			case 42u:
				LinerMatchingPointSpeedRateDistanceCurvePath = input.ReadString();
				break;
			case 48u:
				LinerMatchingPointTeleportDistance = input.ReadInt32();
				break;
			case 56u:
				LinerMatchingPointTeleportSkillID = input.ReadInt32();
				break;
			case 64u:
				EnableCheckDistanceAfterTeleport = (EGSYesNo)input.ReadEnum();
				break;
			case 72u:
				LinerMatchingPointTeleportFinishCheckDistance = input.ReadInt32();
				break;
			}
		}
	}
}
