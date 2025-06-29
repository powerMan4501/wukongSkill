using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class BossRushRoleBaseTupleWrapper : IMessage<BossRushRoleBaseTupleWrapper>, IMessage, IEquatable<BossRushRoleBaseTupleWrapper>, IDeepCloneable<BossRushRoleBaseTupleWrapper>
{
	private static readonly MessageParser<BossRushRoleBaseTupleWrapper> _parser = new MessageParser<BossRushRoleBaseTupleWrapper>(() => new BossRushRoleBaseTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private BossRushRoleBase item1_;

	private BossRushRoleBase item2_;

	public static MessageParser<BossRushRoleBaseTupleWrapper> Parser => _parser;

	public BossRushRoleBase Item1
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

	public BossRushRoleBase Item2
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

	public BossRushRoleBaseTupleWrapper()
	{
	}

	public BossRushRoleBaseTupleWrapper(BossRushRoleBaseTupleWrapper other)
		: this()
	{
		item1_ = ((other.item1_ != null) ? other.item1_.Clone() : null);
		item2_ = ((other.item2_ != null) ? other.item2_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRoleBaseTupleWrapper Clone()
	{
		return new BossRushRoleBaseTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRoleBaseTupleWrapper);
	}

	public bool Equals(BossRushRoleBaseTupleWrapper other)
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

	public void MergeFrom(BossRushRoleBaseTupleWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.item1_ != null)
		{
			if (item1_ == null)
			{
				Item1 = new BossRushRoleBase();
			}
			Item1.MergeFrom(other.Item1);
		}
		if (other.item2_ != null)
		{
			if (item2_ == null)
			{
				Item2 = new BossRushRoleBase();
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
					Item1 = new BossRushRoleBase();
				}
				input.ReadMessage(Item1);
				break;
			case 18u:
				if (item2_ == null)
				{
					Item2 = new BossRushRoleBase();
				}
				input.ReadMessage(Item2);
				break;
			}
		}
	}
}
