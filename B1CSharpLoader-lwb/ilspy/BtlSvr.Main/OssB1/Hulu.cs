using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace OssB1;

public sealed class Hulu : IMessage<Hulu>, IMessage, IEquatable<Hulu>, IDeepCloneable<Hulu>
{
	private static readonly MessageParser<Hulu> _parser = new MessageParser<Hulu>(() => new Hulu());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int wine_;

	private static readonly FieldCodec<int> _repeated_winePartner_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> winePartner_ = new RepeatedField<int>();

	public static MessageParser<Hulu> Parser => _parser;

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

	public int Wine
	{
		get
		{
			return wine_;
		}
		set
		{
			wine_ = value;
		}
	}

	public RepeatedField<int> WinePartner => winePartner_;

	public Hulu()
	{
	}

	public Hulu(Hulu other)
		: this()
	{
		id_ = other.id_;
		wine_ = other.wine_;
		winePartner_ = other.winePartner_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public Hulu Clone()
	{
		return new Hulu(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as Hulu);
	}

	public bool Equals(Hulu other)
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
		if (Wine != other.Wine)
		{
			return false;
		}
		if (!winePartner_.Equals(other.winePartner_))
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
		if (Wine != 0)
		{
			num ^= Wine.GetHashCode();
		}
		num ^= winePartner_.GetHashCode();
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
		if (Wine != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Wine);
		}
		winePartner_.WriteTo(output, _repeated_winePartner_codec);
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
		if (Wine != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Wine);
		}
		num += winePartner_.CalculateSize(_repeated_winePartner_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(Hulu other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Wine != 0)
			{
				Wine = other.Wine;
			}
			winePartner_.Add(other.winePartner_);
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
				Wine = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				winePartner_.AddEntriesFrom(input, _repeated_winePartner_codec);
				break;
			}
		}
	}
}
