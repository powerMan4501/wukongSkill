using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class Wine : IMessage<Wine>, IMessage, IEquatable<Wine>, IDeepCloneable<Wine>
{
	private static readonly MessageParser<Wine> _parser = new MessageParser<Wine>(() => new Wine());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<WinePartnerSlot> _repeated_winePartnerList_codec = FieldCodec.ForMessage(18u, WinePartnerSlot.Parser);

	private readonly RepeatedField<WinePartnerSlot> winePartnerList_ = new RepeatedField<WinePartnerSlot>();

	public static MessageParser<Wine> Parser => _parser;

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

	public RepeatedField<WinePartnerSlot> WinePartnerList => winePartnerList_;

	public Wine()
	{
	}

	public Wine(Wine other)
		: this()
	{
		id_ = other.id_;
		winePartnerList_ = other.winePartnerList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Wine Clone()
	{
		return new Wine(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Wine);
	}

	public bool Equals(Wine other)
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
		if (!winePartnerList_.Equals(other.winePartnerList_))
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
		num ^= winePartnerList_.GetHashCode();
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
		winePartnerList_.WriteTo(output, _repeated_winePartnerList_codec);
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
		num += winePartnerList_.CalculateSize(_repeated_winePartnerList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Wine other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			winePartnerList_.Add(other.winePartnerList_);
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
			case 18u:
				winePartnerList_.AddEntriesFrom(input, _repeated_winePartnerList_codec);
				break;
			}
		}
	}
}
