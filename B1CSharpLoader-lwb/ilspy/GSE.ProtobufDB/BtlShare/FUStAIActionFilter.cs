using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAIActionFilter : IMessage<FUStAIActionFilter>, IMessage, IEquatable<FUStAIActionFilter>, IDeepCloneable<FUStAIActionFilter>
{
	private static readonly MessageParser<FUStAIActionFilter> _parser = new MessageParser<FUStAIActionFilter>(() => new FUStAIActionFilter());

	private UnknownFieldSet _unknownFields;

	private int nONE_;

	private static readonly FieldCodec<EActionTagType> _repeated_tags_codec = FieldCodec.ForEnum(18u, (EActionTagType x) => (int)x, (int x) => (EActionTagType)x);

	private readonly RepeatedField<EActionTagType> tags_ = new RepeatedField<EActionTagType>();

	public static MessageParser<FUStAIActionFilter> Parser => _parser;

	public int NONE
	{
		get
		{
			return nONE_;
		}
		set
		{
			nONE_ = value;
		}
	}

	public RepeatedField<EActionTagType> Tags => tags_;

	public FUStAIActionFilter()
	{
	}

	public FUStAIActionFilter(FUStAIActionFilter other)
		: this()
	{
		nONE_ = other.nONE_;
		tags_ = other.tags_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAIActionFilter Clone()
	{
		return new FUStAIActionFilter(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAIActionFilter);
	}

	public bool Equals(FUStAIActionFilter other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NONE != other.NONE)
		{
			return false;
		}
		if (!tags_.Equals(other.tags_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (NONE != 0)
		{
			num ^= NONE.GetHashCode();
		}
		num ^= tags_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (NONE != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(NONE);
		}
		tags_.WriteTo(output, _repeated_tags_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (NONE != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NONE);
		}
		num += tags_.CalculateSize(_repeated_tags_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAIActionFilter other)
	{
		if (other != null)
		{
			if (other.NONE != 0)
			{
				NONE = other.NONE;
			}
			tags_.Add(other.tags_);
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
				NONE = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				tags_.AddEntriesFrom(input, _repeated_tags_codec);
				break;
			}
		}
	}
}
