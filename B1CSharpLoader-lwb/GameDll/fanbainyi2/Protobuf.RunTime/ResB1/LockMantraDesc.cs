using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class LockMantraDesc : IMessage<LockMantraDesc>, IMessage, IEquatable<LockMantraDesc>, IDeepCloneable<LockMantraDesc>
{
	private static readonly MessageParser<LockMantraDesc> _parser = new MessageParser<LockMantraDesc>(() => new LockMantraDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int lockNum_;

	private static readonly FieldCodec<ItemOne> _repeated_costItemList_codec = FieldCodec.ForMessage(26u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> costItemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<LockMantraDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int LockNum
	{
		get
		{
			return lockNum_;
		}
		set
		{
			lockNum_ = value;
		}
	}

	public RepeatedField<ItemOne> CostItemList => costItemList_;

	public LockMantraDesc()
	{
	}

	public LockMantraDesc(LockMantraDesc other)
		: this()
	{
		id_ = other.id_;
		lockNum_ = other.lockNum_;
		costItemList_ = other.costItemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LockMantraDesc Clone()
	{
		return new LockMantraDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LockMantraDesc);
	}

	public bool Equals(LockMantraDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (LockNum != other.LockNum)
		{
			return false;
		}
		if (!costItemList_.Equals(other.costItemList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (LockNum != 0)
		{
			num ^= LockNum.GetHashCode();
		}
		num ^= costItemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (LockNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LockNum);
		}
		costItemList_.WriteTo(output, _repeated_costItemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (LockNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LockNum);
		}
		num += costItemList_.CalculateSize(_repeated_costItemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LockMantraDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LockNum != 0)
			{
				LockNum = other.LockNum;
			}
			costItemList_.Add(other.costItemList_);
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
				Id = input.ReadInt32();
				break;
			case 16u:
				LockNum = input.ReadInt32();
				break;
			case 26u:
				costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
				break;
			}
		}
	}
}
