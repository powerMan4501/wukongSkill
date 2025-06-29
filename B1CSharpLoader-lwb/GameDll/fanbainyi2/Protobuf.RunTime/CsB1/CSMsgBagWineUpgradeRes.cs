using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagWineUpgradeRes : IMessage<CSMsgBagWineUpgradeRes>, IMessage, IEquatable<CSMsgBagWineUpgradeRes>, IDeepCloneable<CSMsgBagWineUpgradeRes>
{
	private static readonly MessageParser<CSMsgBagWineUpgradeRes> _parser = new MessageParser<CSMsgBagWineUpgradeRes>(() => new CSMsgBagWineUpgradeRes());

	private UnknownFieldSet _unknownFields;

	private int originWineId_;

	private int targetWineId_;

	public static MessageParser<CSMsgBagWineUpgradeRes> Parser => _parser;

	public int OriginWineId
	{
		get
		{
			return originWineId_;
		}
		set
		{
			originWineId_ = value;
		}
	}

	public int TargetWineId
	{
		get
		{
			return targetWineId_;
		}
		set
		{
			targetWineId_ = value;
		}
	}

	public CSMsgBagWineUpgradeRes()
	{
	}

	public CSMsgBagWineUpgradeRes(CSMsgBagWineUpgradeRes other)
		: this()
	{
		originWineId_ = other.originWineId_;
		targetWineId_ = other.targetWineId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagWineUpgradeRes Clone()
	{
		return new CSMsgBagWineUpgradeRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagWineUpgradeRes);
	}

	public bool Equals(CSMsgBagWineUpgradeRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OriginWineId != other.OriginWineId)
		{
			return false;
		}
		if (TargetWineId != other.TargetWineId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (OriginWineId != 0)
		{
			num ^= OriginWineId.GetHashCode();
		}
		if (TargetWineId != 0)
		{
			num ^= TargetWineId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (OriginWineId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(OriginWineId);
		}
		if (TargetWineId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetWineId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (OriginWineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OriginWineId);
		}
		if (TargetWineId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetWineId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagWineUpgradeRes other)
	{
		if (other != null)
		{
			if (other.OriginWineId != 0)
			{
				OriginWineId = other.OriginWineId;
			}
			if (other.TargetWineId != 0)
			{
				TargetWineId = other.TargetWineId;
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
				OriginWineId = input.ReadInt32();
				break;
			case 16u:
				TargetWineId = input.ReadInt32();
				break;
			}
		}
	}
}
