using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class BossRushDamageInfoTupleWrapper : IMessage<BossRushDamageInfoTupleWrapper>, IMessage, IEquatable<BossRushDamageInfoTupleWrapper>, IDeepCloneable<BossRushDamageInfoTupleWrapper>
{
	private static readonly MessageParser<BossRushDamageInfoTupleWrapper> _parser = new MessageParser<BossRushDamageInfoTupleWrapper>(() => new BossRushDamageInfoTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BossRushDamageInfo item1_;

	private BossRushDamageInfo item2_;

	public static MessageParser<BossRushDamageInfoTupleWrapper> Parser => _parser;

	public BossRushDamageInfo Item1
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

	public BossRushDamageInfo Item2
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

	public BossRushDamageInfoTupleWrapper()
	{
	}

	public BossRushDamageInfoTupleWrapper(BossRushDamageInfoTupleWrapper other)
		: this()
	{
		item1_ = ((other.item1_ != null) ? other.item1_.Clone() : null);
		item2_ = ((other.item2_ != null) ? other.item2_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushDamageInfoTupleWrapper Clone()
	{
		return new BossRushDamageInfoTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushDamageInfoTupleWrapper);
	}

	public bool Equals(BossRushDamageInfoTupleWrapper other)
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

	public void MergeFrom(BossRushDamageInfoTupleWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.item1_ != null)
		{
			if (item1_ == null)
			{
				Item1 = new BossRushDamageInfo();
			}
			Item1.MergeFrom(other.Item1);
		}
		if (other.item2_ != null)
		{
			if (item2_ == null)
			{
				Item2 = new BossRushDamageInfo();
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
					Item1 = new BossRushDamageInfo();
				}
				input.ReadMessage(Item1);
				break;
			case 18u:
				if (item2_ == null)
				{
					Item2 = new BossRushDamageInfo();
				}
				input.ReadMessage(Item2);
				break;
			}
		}
	}
}
