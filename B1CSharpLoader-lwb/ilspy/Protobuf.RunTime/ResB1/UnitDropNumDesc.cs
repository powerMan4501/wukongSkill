using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class UnitDropNumDesc : IMessage<UnitDropNumDesc>, IMessage, IEquatable<UnitDropNumDesc>, IDeepCloneable<UnitDropNumDesc>
{
	private static readonly MessageParser<UnitDropNumDesc> _parser = new MessageParser<UnitDropNumDesc>(() => new UnitDropNumDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<RandomWeight> _repeated_random_codec = FieldCodec.ForMessage(18u, RandomWeight.Parser);

	private readonly RepeatedField<RandomWeight> random_ = new RepeatedField<RandomWeight>();

	public static MessageParser<UnitDropNumDesc> Parser => _parser;

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

	public RepeatedField<RandomWeight> Random => random_;

	public UnitDropNumDesc()
	{
	}

	public UnitDropNumDesc(UnitDropNumDesc other)
		: this()
	{
		id_ = other.id_;
		random_ = other.random_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitDropNumDesc Clone()
	{
		return new UnitDropNumDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitDropNumDesc);
	}

	public bool Equals(UnitDropNumDesc other)
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
		if (!random_.Equals(other.random_))
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
		num ^= random_.GetHashCode();
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
		random_.WriteTo(output, _repeated_random_codec);
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
		num += random_.CalculateSize(_repeated_random_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitDropNumDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			random_.Add(other.random_);
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
				random_.AddEntriesFrom(input, _repeated_random_codec);
				break;
			}
		}
	}
}
