using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class EditionAwardDesc : IMessage<EditionAwardDesc>, IMessage, IEquatable<EditionAwardDesc>, IDeepCloneable<EditionAwardDesc>
{
	private static readonly MessageParser<EditionAwardDesc> _parser = new MessageParser<EditionAwardDesc>(() => new EditionAwardDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EditionType type_;

	private static readonly FieldCodec<ItemOne> _repeated_awardList_codec = FieldCodec.ForMessage(26u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> awardList_ = new RepeatedField<ItemOne>();

	public static MessageParser<EditionAwardDesc> Parser => _parser;

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

	public EditionType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public RepeatedField<ItemOne> AwardList => awardList_;

	public EditionAwardDesc()
	{
	}

	public EditionAwardDesc(EditionAwardDesc other)
		: this()
	{
		id_ = other.id_;
		type_ = other.type_;
		awardList_ = other.awardList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public EditionAwardDesc Clone()
	{
		return new EditionAwardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as EditionAwardDesc);
	}

	public bool Equals(EditionAwardDesc other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (!awardList_.Equals(other.awardList_))
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
		if (Type != EditionType.Standard)
		{
			num ^= Type.GetHashCode();
		}
		num ^= awardList_.GetHashCode();
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
		if (Type != EditionType.Standard)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		awardList_.WriteTo(output, _repeated_awardList_codec);
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
		if (Type != EditionType.Standard)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		num += awardList_.CalculateSize(_repeated_awardList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(EditionAwardDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != EditionType.Standard)
			{
				Type = other.Type;
			}
			awardList_.Add(other.awardList_);
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
				Type = (EditionType)input.ReadEnum();
				break;
			case 26u:
				awardList_.AddEntriesFrom(input, _repeated_awardList_codec);
				break;
			}
		}
	}
}
