using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ActivityStatusTupleWrapper : IMessage<ActivityStatusTupleWrapper>, IMessage, IEquatable<ActivityStatusTupleWrapper>, IDeepCloneable<ActivityStatusTupleWrapper>
{
	private static readonly MessageParser<ActivityStatusTupleWrapper> _parser = new MessageParser<ActivityStatusTupleWrapper>(() => new ActivityStatusTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ActivityStatus item1_;

	private ActivityStatus item2_;

	public static MessageParser<ActivityStatusTupleWrapper> Parser => _parser;

	public ActivityStatus Item1
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

	public ActivityStatus Item2
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

	public ActivityStatusTupleWrapper()
	{
	}

	public ActivityStatusTupleWrapper(ActivityStatusTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ActivityStatusTupleWrapper Clone()
	{
		return new ActivityStatusTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ActivityStatusTupleWrapper);
	}

	public bool Equals(ActivityStatusTupleWrapper other)
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
		if (Item1 != ActivityStatus.Notstart)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ActivityStatus.Notstart)
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
		if (Item1 != ActivityStatus.Notstart)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ActivityStatus.Notstart)
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
		if (Item1 != ActivityStatus.Notstart)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ActivityStatus.Notstart)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ActivityStatusTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ActivityStatus.Notstart)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ActivityStatus.Notstart)
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
				Item1 = (ActivityStatus)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ActivityStatus)input.ReadEnum();
				break;
			}
		}
	}
}
