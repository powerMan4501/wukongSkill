using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class SeedDesc : IMessage<SeedDesc>, IMessage, IEquatable<SeedDesc>, IDeepCloneable<SeedDesc>
{
	private static readonly MessageParser<SeedDesc> _parser = new MessageParser<SeedDesc>(() => new SeedDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private static readonly FieldCodec<SeedOutputOne> _repeated_outputList_codec = FieldCodec.ForMessage(18u, SeedOutputOne.Parser);

	private readonly RepeatedField<SeedOutputOne> outputList_ = new RepeatedField<SeedOutputOne>();

	public static MessageParser<SeedDesc> Parser => _parser;

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

	public RepeatedField<SeedOutputOne> OutputList => outputList_;

	public SeedDesc()
	{
	}

	public SeedDesc(SeedDesc other)
		: this()
	{
		id_ = other.id_;
		outputList_ = other.outputList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SeedDesc Clone()
	{
		return new SeedDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SeedDesc);
	}

	public bool Equals(SeedDesc other)
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
		if (!outputList_.Equals(other.outputList_))
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
		num ^= outputList_.GetHashCode();
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
		outputList_.WriteTo(output, _repeated_outputList_codec);
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
		num += outputList_.CalculateSize(_repeated_outputList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(SeedDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			outputList_.Add(other.outputList_);
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
				outputList_.AddEntriesFrom(input, _repeated_outputList_codec);
				break;
			}
		}
	}
}
