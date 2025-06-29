using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class EStoryStageRemoveTupleWrapper : IMessage<EStoryStageRemoveTupleWrapper>, IMessage, IEquatable<EStoryStageRemoveTupleWrapper>, IDeepCloneable<EStoryStageRemoveTupleWrapper>
{
	private static readonly MessageParser<EStoryStageRemoveTupleWrapper> _parser = new MessageParser<EStoryStageRemoveTupleWrapper>(() => new EStoryStageRemoveTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private EStoryStageRemove item1_;

	private EStoryStageRemove item2_;

	public static MessageParser<EStoryStageRemoveTupleWrapper> Parser => _parser;

	public EStoryStageRemove Item1
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

	public EStoryStageRemove Item2
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

	public EStoryStageRemoveTupleWrapper()
	{
	}

	public EStoryStageRemoveTupleWrapper(EStoryStageRemoveTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EStoryStageRemoveTupleWrapper Clone()
	{
		return new EStoryStageRemoveTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EStoryStageRemoveTupleWrapper);
	}

	public bool Equals(EStoryStageRemoveTupleWrapper other)
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
		if (Item1 != EStoryStageRemove.Default)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != EStoryStageRemove.Default)
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
		if (Item1 != EStoryStageRemove.Default)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != EStoryStageRemove.Default)
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
		if (Item1 != EStoryStageRemove.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != EStoryStageRemove.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EStoryStageRemoveTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != EStoryStageRemove.Default)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != EStoryStageRemove.Default)
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
				Item1 = (EStoryStageRemove)input.ReadEnum();
				break;
			case 16u:
				Item2 = (EStoryStageRemove)input.ReadEnum();
				break;
			}
		}
	}
}
