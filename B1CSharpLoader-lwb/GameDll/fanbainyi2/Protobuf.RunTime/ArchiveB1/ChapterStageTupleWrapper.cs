using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class ChapterStageTupleWrapper : IMessage<ChapterStageTupleWrapper>, IMessage, IEquatable<ChapterStageTupleWrapper>, IDeepCloneable<ChapterStageTupleWrapper>
{
	private static readonly MessageParser<ChapterStageTupleWrapper> _parser = new MessageParser<ChapterStageTupleWrapper>(() => new ChapterStageTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private ChapterStage item1_;

	private ChapterStage item2_;

	public static MessageParser<ChapterStageTupleWrapper> Parser => _parser;

	public ChapterStage Item1
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

	public ChapterStage Item2
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

	public ChapterStageTupleWrapper()
	{
	}

	public ChapterStageTupleWrapper(ChapterStageTupleWrapper other)
		: this()
	{
		item1_ = other.item1_;
		item2_ = other.item2_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ChapterStageTupleWrapper Clone()
	{
		return new ChapterStageTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ChapterStageTupleWrapper);
	}

	public bool Equals(ChapterStageTupleWrapper other)
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
		if (Item1 != ChapterStage.None)
		{
			num ^= Item1.GetHashCode();
		}
		if (Item2 != ChapterStage.None)
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
		if (Item1 != ChapterStage.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Item1);
		}
		if (Item2 != ChapterStage.None)
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
		if (Item1 != ChapterStage.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item1);
		}
		if (Item2 != ChapterStage.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ChapterStageTupleWrapper other)
	{
		if (other != null)
		{
			if (other.Item1 != ChapterStage.None)
			{
				Item1 = other.Item1;
			}
			if (other.Item2 != ChapterStage.None)
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
				Item1 = (ChapterStage)input.ReadEnum();
				break;
			case 16u:
				Item2 = (ChapterStage)input.ReadEnum();
				break;
			}
		}
	}
}
