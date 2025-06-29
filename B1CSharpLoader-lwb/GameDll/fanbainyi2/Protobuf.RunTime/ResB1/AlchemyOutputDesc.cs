using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class AlchemyOutputDesc : IMessage<AlchemyOutputDesc>, IMessage, IEquatable<AlchemyOutputDesc>, IDeepCloneable<AlchemyOutputDesc>
{
	private static readonly MessageParser<AlchemyOutputDesc> _parser = new MessageParser<AlchemyOutputDesc>(() => new AlchemyOutputDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int qualityLowerLimit_;

	private int qualityUpperLimit_;

	private static readonly FieldCodec<RandomItem> _repeated_randomItem_codec = FieldCodec.ForMessage(34u, ResB1.RandomItem.Parser);

	private readonly RepeatedField<RandomItem> randomItem_ = new RepeatedField<RandomItem>();

	public static MessageParser<AlchemyOutputDesc> Parser => _parser;

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

	public int QualityLowerLimit
	{
		get
		{
			return qualityLowerLimit_;
		}
		set
		{
			qualityLowerLimit_ = value;
		}
	}

	public int QualityUpperLimit
	{
		get
		{
			return qualityUpperLimit_;
		}
		set
		{
			qualityUpperLimit_ = value;
		}
	}

	public RepeatedField<RandomItem> RandomItem => randomItem_;

	public AlchemyOutputDesc()
	{
	}

	public AlchemyOutputDesc(AlchemyOutputDesc other)
		: this()
	{
		id_ = other.id_;
		qualityLowerLimit_ = other.qualityLowerLimit_;
		qualityUpperLimit_ = other.qualityUpperLimit_;
		randomItem_ = other.randomItem_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AlchemyOutputDesc Clone()
	{
		return new AlchemyOutputDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AlchemyOutputDesc);
	}

	public bool Equals(AlchemyOutputDesc other)
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
		if (QualityLowerLimit != other.QualityLowerLimit)
		{
			return false;
		}
		if (QualityUpperLimit != other.QualityUpperLimit)
		{
			return false;
		}
		if (!randomItem_.Equals(other.randomItem_))
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
		if (QualityLowerLimit != 0)
		{
			num ^= QualityLowerLimit.GetHashCode();
		}
		if (QualityUpperLimit != 0)
		{
			num ^= QualityUpperLimit.GetHashCode();
		}
		num ^= randomItem_.GetHashCode();
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
		if (QualityLowerLimit != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(QualityLowerLimit);
		}
		if (QualityUpperLimit != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(QualityUpperLimit);
		}
		randomItem_.WriteTo(output, _repeated_randomItem_codec);
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
		if (QualityLowerLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QualityLowerLimit);
		}
		if (QualityUpperLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(QualityUpperLimit);
		}
		num += randomItem_.CalculateSize(_repeated_randomItem_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AlchemyOutputDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.QualityLowerLimit != 0)
			{
				QualityLowerLimit = other.QualityLowerLimit;
			}
			if (other.QualityUpperLimit != 0)
			{
				QualityUpperLimit = other.QualityUpperLimit;
			}
			randomItem_.Add(other.randomItem_);
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
				QualityLowerLimit = input.ReadInt32();
				break;
			case 24u:
				QualityUpperLimit = input.ReadInt32();
				break;
			case 34u:
				randomItem_.AddEntriesFrom(input, _repeated_randomItem_codec);
				break;
			}
		}
	}
}
