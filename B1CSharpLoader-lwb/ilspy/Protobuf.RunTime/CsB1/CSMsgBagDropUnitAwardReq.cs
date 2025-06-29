using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagDropUnitAwardReq : IMessage<CSMsgBagDropUnitAwardReq>, IMessage, IEquatable<CSMsgBagDropUnitAwardReq>, IDeepCloneable<CSMsgBagDropUnitAwardReq>
{
	private static readonly MessageParser<CSMsgBagDropUnitAwardReq> _parser = new MessageParser<CSMsgBagDropUnitAwardReq>(() => new CSMsgBagDropUnitAwardReq());

	private UnknownFieldSet _unknownFields;

	private int unitId_;

	private int override_;

	private bool canDropVigour_;

	public static MessageParser<CSMsgBagDropUnitAwardReq> Parser => _parser;

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

	public int Override
	{
		get
		{
			return override_;
		}
		set
		{
			override_ = value;
		}
	}

	public bool CanDropVigour
	{
		get
		{
			return canDropVigour_;
		}
		set
		{
			canDropVigour_ = value;
		}
	}

	public CSMsgBagDropUnitAwardReq()
	{
	}

	public CSMsgBagDropUnitAwardReq(CSMsgBagDropUnitAwardReq other)
		: this()
	{
		unitId_ = other.unitId_;
		override_ = other.override_;
		canDropVigour_ = other.canDropVigour_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagDropUnitAwardReq Clone()
	{
		return new CSMsgBagDropUnitAwardReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagDropUnitAwardReq);
	}

	public bool Equals(CSMsgBagDropUnitAwardReq other)
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
		if (Override != other.Override)
		{
			return false;
		}
		if (CanDropVigour != other.CanDropVigour)
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
		if (Override != 0)
		{
			num ^= Override.GetHashCode();
		}
		if (CanDropVigour)
		{
			num ^= CanDropVigour.GetHashCode();
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
		if (Override != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Override);
		}
		if (CanDropVigour)
		{
			output.WriteRawTag(24);
			output.WriteBool(CanDropVigour);
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
		if (Override != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Override);
		}
		if (CanDropVigour)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagDropUnitAwardReq other)
	{
		if (other != null)
		{
			if (other.UnitId != 0)
			{
				UnitId = other.UnitId;
			}
			if (other.Override != 0)
			{
				Override = other.Override;
			}
			if (other.CanDropVigour)
			{
				CanDropVigour = other.CanDropVigour;
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
				Override = input.ReadInt32();
				break;
			case 24u:
				CanDropVigour = input.ReadBool();
				break;
			}
		}
	}
}
