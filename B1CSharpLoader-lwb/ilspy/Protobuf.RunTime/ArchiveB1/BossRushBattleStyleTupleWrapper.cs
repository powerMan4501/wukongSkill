using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class BossRushBattleStyleTupleWrapper : IMessage<BossRushBattleStyleTupleWrapper>, IMessage, IEquatable<BossRushBattleStyleTupleWrapper>, IDeepCloneable<BossRushBattleStyleTupleWrapper>
{
	private static readonly MessageParser<BossRushBattleStyleTupleWrapper> _parser = new MessageParser<BossRushBattleStyleTupleWrapper>(() => new BossRushBattleStyleTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BossRushBattleStyle item1_;

	private BossRushBattleStyle item2_;

	public static MessageParser<BossRushBattleStyleTupleWrapper> Parser => _parser;

	public BossRushBattleStyle Item1
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

	public BossRushBattleStyle Item2
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

	public BossRushBattleStyleTupleWrapper()
	{
	}

	public BossRushBattleStyleTupleWrapper(BossRushBattleStyleTupleWrapper other)
		: this()
	{
		item1_ = ((other.item1_ != null) ? other.item1_.Clone() : null);
		item2_ = ((other.item2_ != null) ? other.item2_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushBattleStyleTupleWrapper Clone()
	{
		return new BossRushBattleStyleTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushBattleStyleTupleWrapper);
	}

	public bool Equals(BossRushBattleStyleTupleWrapper other)
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

	public void MergeFrom(BossRushBattleStyleTupleWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.item1_ != null)
		{
			if (item1_ == null)
			{
				Item1 = new BossRushBattleStyle();
			}
			Item1.MergeFrom(other.Item1);
		}
		if (other.item2_ != null)
		{
			if (item2_ == null)
			{
				Item2 = new BossRushBattleStyle();
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
					Item1 = new BossRushBattleStyle();
				}
				input.ReadMessage(Item1);
				break;
			case 18u:
				if (item2_ == null)
				{
					Item2 = new BossRushBattleStyle();
				}
				input.ReadMessage(Item2);
				break;
			}
		}
	}
}
