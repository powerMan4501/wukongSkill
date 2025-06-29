using System;
using Google.Protobuf;

namespace CommB1;

public sealed class RoleKickReasonTupleWrapper : IMessage<RoleKickReasonTupleWrapper>, IMessage, IEquatable<RoleKickReasonTupleWrapper>, IDeepCloneable<RoleKickReasonTupleWrapper>
{
	private static readonly MessageParser<RoleKickReasonTupleWrapper> _parser = new MessageParser<RoleKickReasonTupleWrapper>(() => new RoleKickReasonTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private RoleKickReason item1_;

	private RoleKickReason item2_;

	public static MessageParser<RoleKickReasonTupleWrapper> Parser => _parser;

	public RoleKickReason Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public RoleKickReason Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public RoleKickReasonTupleWrapper()
	{
	}

	public RoleKickReasonTupleWrapper(RoleKickReasonTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleKickReasonTupleWrapper Clone()
	{
		return new RoleKickReasonTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleKickReasonTupleWrapper);
	}

	public bool Equals(RoleKickReasonTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Item1 != other.Item1)
		{
			return false;
		}
		if (Item2 != other.Item2)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Item1 != RoleKickReason.RoleKickLogin)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != RoleKickReason.RoleKickLogin)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Item1 != RoleKickReason.RoleKickLogin)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != RoleKickReason.RoleKickLogin)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Item1 != RoleKickReason.RoleKickLogin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != RoleKickReason.RoleKickLogin)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleKickReasonTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != RoleKickReason.RoleKickLogin)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != RoleKickReason.RoleKickLogin)
			{
				Item2 = other.Item2;
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
				Item1 = (RoleKickReason)input.ReadEnum();
				break;
			case 16u:
				Item2 = (RoleKickReason)input.ReadEnum();
				break;
			}
		}
	}
}
