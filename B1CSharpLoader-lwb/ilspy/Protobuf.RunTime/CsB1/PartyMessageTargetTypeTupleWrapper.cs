using System;
using Google.Protobuf;

namespace CsB1;

public sealed class PartyMessageTargetTypeTupleWrapper : IMessage<PartyMessageTargetTypeTupleWrapper>, IMessage, IEquatable<PartyMessageTargetTypeTupleWrapper>, IDeepCloneable<PartyMessageTargetTypeTupleWrapper>
{
	private static readonly MessageParser<PartyMessageTargetTypeTupleWrapper> _parser = new MessageParser<PartyMessageTargetTypeTupleWrapper>(() => new PartyMessageTargetTypeTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private PartyMessageTargetType item1_;

	private PartyMessageTargetType item2_;

	public static MessageParser<PartyMessageTargetTypeTupleWrapper> Parser => _parser;

	public PartyMessageTargetType Item1
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

	public PartyMessageTargetType Item2
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

	public PartyMessageTargetTypeTupleWrapper()
	{
	}

	public PartyMessageTargetTypeTupleWrapper(PartyMessageTargetTypeTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PartyMessageTargetTypeTupleWrapper Clone()
	{
		return new PartyMessageTargetTypeTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PartyMessageTargetTypeTupleWrapper);
	}

	public bool Equals(PartyMessageTargetTypeTupleWrapper other)
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
		if (Item1 != PartyMessageTargetType.All)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != PartyMessageTargetType.All)
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
		if (Item1 != PartyMessageTargetType.All)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != PartyMessageTargetType.All)
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
		if (Item1 != PartyMessageTargetType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != PartyMessageTargetType.All)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PartyMessageTargetTypeTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != PartyMessageTargetType.All)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != PartyMessageTargetType.All)
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
				Item1 = (PartyMessageTargetType)input.ReadEnum();
				break;
			case 16u:
				Item2 = (PartyMessageTargetType)input.ReadEnum();
				break;
			}
		}
	}
}
