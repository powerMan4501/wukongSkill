using System;
using Google.Protobuf;

namespace GsOnline;

public sealed class MemberUpdateTypeTupleWrapper : IMessage<MemberUpdateTypeTupleWrapper>, IMessage, IEquatable<MemberUpdateTypeTupleWrapper>, IDeepCloneable<MemberUpdateTypeTupleWrapper>
{
	private static readonly MessageParser<MemberUpdateTypeTupleWrapper> _parser = new MessageParser<MemberUpdateTypeTupleWrapper>(() => new MemberUpdateTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private MemberUpdateType item1_;

	private MemberUpdateType item2_;

	public static MessageParser<MemberUpdateTypeTupleWrapper> Parser => _parser;

	public MemberUpdateType Item1
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

	public MemberUpdateType Item2
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

	public MemberUpdateTypeTupleWrapper()
	{
	}

	public MemberUpdateTypeTupleWrapper(MemberUpdateTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MemberUpdateTypeTupleWrapper Clone()
	{
		return new MemberUpdateTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MemberUpdateTypeTupleWrapper);
	}

	public bool Equals(MemberUpdateTypeTupleWrapper other)
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
		if (Item1 != MemberUpdateType.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != MemberUpdateType.None)
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
		if (Item1 != MemberUpdateType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != MemberUpdateType.None)
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
		if (Item1 != MemberUpdateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != MemberUpdateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MemberUpdateTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != MemberUpdateType.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != MemberUpdateType.None)
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
				Item1 = (MemberUpdateType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (MemberUpdateType)input.ReadEnum();
				break;
			}
		}
	}
}
