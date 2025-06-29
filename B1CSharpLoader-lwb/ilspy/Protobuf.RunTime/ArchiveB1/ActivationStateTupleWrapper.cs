using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ActivationStateTupleWrapper : IMessage<ActivationStateTupleWrapper>, IMessage, IEquatable<ActivationStateTupleWrapper>, IDeepCloneable<ActivationStateTupleWrapper>
{
	private static readonly MessageParser<ActivationStateTupleWrapper> _parser = new MessageParser<ActivationStateTupleWrapper>(() => new ActivationStateTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ActivationState item1_;

	private ActivationState item2_;

	public static MessageParser<ActivationStateTupleWrapper> Parser => _parser;

	public ActivationState Item1
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

	public ActivationState Item2
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

	public ActivationStateTupleWrapper()
	{
	}

	public ActivationStateTupleWrapper(ActivationStateTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ActivationStateTupleWrapper Clone()
	{
		return new ActivationStateTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ActivationStateTupleWrapper);
	}

	public bool Equals(ActivationStateTupleWrapper other)
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
		if (Item1 != ActivationState.NeverActivated)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ActivationState.NeverActivated)
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
		if (Item1 != ActivationState.NeverActivated)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ActivationState.NeverActivated)
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
		if (Item1 != ActivationState.NeverActivated)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ActivationState.NeverActivated)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ActivationStateTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ActivationState.NeverActivated)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ActivationState.NeverActivated)
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
				Item1 = (ActivationState)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ActivationState)input.ReadEnum();
				break;
			}
		}
	}
}
