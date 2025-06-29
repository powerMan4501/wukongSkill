using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class BossRushRefightRecordTupleWrapper : IMessage<BossRushRefightRecordTupleWrapper>, IMessage, IEquatable<BossRushRefightRecordTupleWrapper>, IDeepCloneable<BossRushRefightRecordTupleWrapper>
{
	private static readonly MessageParser<BossRushRefightRecordTupleWrapper> _parser = new MessageParser<BossRushRefightRecordTupleWrapper>(() => new BossRushRefightRecordTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BossRushRefightRecord item1_;

	private BossRushRefightRecord item2_;

	public static MessageParser<BossRushRefightRecordTupleWrapper> Parser => _parser;

	public BossRushRefightRecord Item1
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

	public BossRushRefightRecord Item2
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

	public BossRushRefightRecordTupleWrapper()
	{
	}

	public BossRushRefightRecordTupleWrapper(BossRushRefightRecordTupleWrapper other)
		: this()
	{
		item1_ = ((other.item1_ != null) ? other.item1_.Clone() : null);
		item2_ = ((other.item2_ != null) ? other.item2_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRefightRecordTupleWrapper Clone()
	{
		return new BossRushRefightRecordTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRefightRecordTupleWrapper);
	}

	public bool Equals(BossRushRefightRecordTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Item1, other.Item1))
		{
			return false;
		}
		if (!object.Equals(Item2, other.Item2))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (item1_ != null)
		{
			num ^= Item1.GetHashCode();
		}
		if (item2_ != null)
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
		if (item1_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Item1);
		}
		if (item2_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (item1_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Item1);
		}
		if (item2_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRefightRecordTupleWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.item1_ != null)
		{
			if (item1_ == null)
			{
				Item1 = new BossRushRefightRecord();
			}
			Item1.MergeFrom(other.Item1);
		}
		if (other.item2_ != null)
		{
			if (item2_ == null)
			{
				Item2 = new BossRushRefightRecord();
			}
			Item2.MergeFrom(other.Item2);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (item1_ == null)
				{
					Item1 = new BossRushRefightRecord();
				}
				input.ReadMessage(Item1);
				break;
			case 18u:
				if (item2_ == null)
				{
					Item2 = new BossRushRefightRecord();
				}
				input.ReadMessage(Item2);
				break;
			}
		}
	}
}
