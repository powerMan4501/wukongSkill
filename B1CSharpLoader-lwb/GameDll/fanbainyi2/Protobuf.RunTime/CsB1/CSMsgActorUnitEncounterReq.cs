using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorUnitEncounterReq : IMessage<CSMsgActorUnitEncounterReq>, IMessage, IEquatable<CSMsgActorUnitEncounterReq>, IDeepCloneable<CSMsgActorUnitEncounterReq>
{
	private static readonly MessageParser<CSMsgActorUnitEncounterReq> _parser = new MessageParser<CSMsgActorUnitEncounterReq>(() => new CSMsgActorUnitEncounterReq());

	private UnknownFieldSet _unknownFields;

	private int unitId_;

	private int overrideId_;

	public static MessageParser<CSMsgActorUnitEncounterReq> Parser => _parser;

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

	public CSMsgActorUnitEncounterReq()
	{
	}

	public CSMsgActorUnitEncounterReq(CSMsgActorUnitEncounterReq other)
		: this()
	{
		unitId_ = other.unitId_;
		overrideId_ = other.overrideId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorUnitEncounterReq Clone()
	{
		return new CSMsgActorUnitEncounterReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorUnitEncounterReq);
	}

	public bool Equals(CSMsgActorUnitEncounterReq other)
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
		if (OverrideId != other.OverrideId)
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
		if (OverrideId != 0)
		{
			num ^= OverrideId.GetHashCode();
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
		if (OverrideId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(OverrideId);
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
		if (OverrideId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OverrideId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorUnitEncounterReq other)
	{
		if (other != null)
		{
			if (other.UnitId != 0)
			{
				UnitId = other.UnitId;
			}
			if (other.OverrideId != 0)
			{
				OverrideId = other.OverrideId;
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
				OverrideId = input.ReadInt32();
				break;
			}
		}
	}
}
