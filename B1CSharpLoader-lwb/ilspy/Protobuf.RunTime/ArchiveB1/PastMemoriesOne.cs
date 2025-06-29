using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class PastMemoriesOne : IMessage<PastMemoriesOne>, IMessage, IEquatable<PastMemoriesOne>, IDeepCloneable<PastMemoriesOne>
{
	private static readonly MessageParser<PastMemoriesOne> _parser = new MessageParser<PastMemoriesOne>(() => new PastMemoriesOne());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<int> _repeated_wearEquip_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> wearEquip_ = new RepeatedField<int>();

	public static MessageParser<PastMemoriesOne> Parser => _parser;

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

	public RepeatedField<int> WearEquip => wearEquip_;

	public PastMemoriesOne()
	{
	}

	public PastMemoriesOne(PastMemoriesOne other)
		: this()
	{
		id_ = other.id_;
		wearEquip_ = other.wearEquip_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PastMemoriesOne Clone()
	{
		return new PastMemoriesOne(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PastMemoriesOne);
	}

	public bool Equals(PastMemoriesOne other)
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
		if (!wearEquip_.Equals(other.wearEquip_))
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
		num ^= wearEquip_.GetHashCode();
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
		wearEquip_.WriteTo(output, _repeated_wearEquip_codec);
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
		num += wearEquip_.CalculateSize(_repeated_wearEquip_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PastMemoriesOne other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			wearEquip_.Add(other.wearEquip_);
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
			case 18u:
				wearEquip_.AddEntriesFrom(input, _repeated_wearEquip_codec);
				break;
			}
		}
	}
}
