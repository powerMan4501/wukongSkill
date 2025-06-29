using System;
using BtlShare;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorKillUnitReq : IMessage<CSMsgActorKillUnitReq>, IMessage, IEquatable<CSMsgActorKillUnitReq>, IDeepCloneable<CSMsgActorKillUnitReq>
{
	private static readonly MessageParser<CSMsgActorKillUnitReq> _parser = new MessageParser<CSMsgActorKillUnitReq>(() => new CSMsgActorKillUnitReq());

	private UnknownFieldSet _unknownFields;

	private int unitId_;

	private EDeadReason unitDeadReason_;

	private int overrideId_;

	private string guid_ = "";

	public static MessageParser<CSMsgActorKillUnitReq> Parser => _parser;

	public int UnitId
	{
		get
		{
			return unitId_;
		}
		set
		{
			unitId_ = value;
		}
	}

	public EDeadReason UnitDeadReason
	{
		get
		{
			return unitDeadReason_;
		}
		set
		{
			unitDeadReason_ = value;
		}
	}

	public int OverrideId
	{
		get
		{
			return overrideId_;
		}
		set
		{
			overrideId_ = value;
		}
	}

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CSMsgActorKillUnitReq()
	{
	}

	public CSMsgActorKillUnitReq(CSMsgActorKillUnitReq other)
		: this()
	{
		unitId_ = other.unitId_;
		unitDeadReason_ = other.unitDeadReason_;
		overrideId_ = other.overrideId_;
		guid_ = other.guid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorKillUnitReq Clone()
	{
		return new CSMsgActorKillUnitReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorKillUnitReq);
	}

	public bool Equals(CSMsgActorKillUnitReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UnitId != other.UnitId)
		{
			return false;
		}
		if (UnitDeadReason != other.UnitDeadReason)
		{
			return false;
		}
		if (OverrideId != other.OverrideId)
		{
			return false;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (UnitId != 0)
		{
			num ^= UnitId.GetHashCode();
		}
		if (UnitDeadReason != EDeadReason.None)
		{
			num ^= UnitDeadReason.GetHashCode();
		}
		if (OverrideId != 0)
		{
			num ^= OverrideId.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (UnitId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(UnitId);
		}
		if (UnitDeadReason != EDeadReason.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)UnitDeadReason);
		}
		if (OverrideId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OverrideId);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Guid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (UnitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitId);
		}
		if (UnitDeadReason != EDeadReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnitDeadReason);
		}
		if (OverrideId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OverrideId);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorKillUnitReq other)
	{
		if (other != null)
		{
			if (other.UnitId != 0)
			{
				UnitId = other.UnitId;
			}
			if (other.UnitDeadReason != EDeadReason.None)
			{
				UnitDeadReason = other.UnitDeadReason;
			}
			if (other.OverrideId != 0)
			{
				OverrideId = other.OverrideId;
			}
			if (other.Guid.Length != 0)
			{
				Guid = other.Guid;
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
				UnitId = input.ReadInt32();
				break;
			case 16u:
				UnitDeadReason = (EDeadReason)input.ReadEnum();
				break;
			case 24u:
				OverrideId = input.ReadInt32();
				break;
			case 34u:
				Guid = input.ReadString();
				break;
			}
		}
	}
}
