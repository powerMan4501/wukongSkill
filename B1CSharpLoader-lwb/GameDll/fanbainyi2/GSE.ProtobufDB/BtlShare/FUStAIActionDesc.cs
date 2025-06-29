using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAIActionDesc : IMessage<FUStAIActionDesc>, IMessage, IEquatable<FUStAIActionDesc>, IDeepCloneable<FUStAIActionDesc>
{
	private static readonly MessageParser<FUStAIActionDesc> _parser = new MessageParser<FUStAIActionDesc>(() => new FUStAIActionDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private static readonly FieldCodec<int> _repeated_preCondition_codec = FieldCodec.ForInt32(18u);

	private readonly RepeatedField<int> preCondition_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_effect_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> effect_ = new RepeatedField<int>();

	private static readonly FieldCodec<FUStAIActionFilter> _repeated_filters_codec = FieldCodec.ForMessage(34u, FUStAIActionFilter.Parser);

	private readonly RepeatedField<FUStAIActionFilter> filters_ = new RepeatedField<FUStAIActionFilter>();

	public static MessageParser<FUStAIActionDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public RepeatedField<int> PreCondition => preCondition_;

	public RepeatedField<int> Effect => effect_;

	public RepeatedField<FUStAIActionFilter> Filters => filters_;

	public FUStAIActionDesc()
	{
	}

	public FUStAIActionDesc(FUStAIActionDesc other)
		: this()
	{
		iD_ = other.iD_;
		preCondition_ = other.preCondition_.Clone();
		effect_ = other.effect_.Clone();
		filters_ = other.filters_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAIActionDesc Clone()
	{
		return new FUStAIActionDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAIActionDesc);
	}

	public bool Equals(FUStAIActionDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (!preCondition_.Equals(other.preCondition_))
		{
			return false;
		}
		if (!effect_.Equals(other.effect_))
		{
			return false;
		}
		if (!filters_.Equals(other.filters_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		num ^= preCondition_.GetHashCode();
		num ^= effect_.GetHashCode();
		num ^= filters_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		preCondition_.WriteTo(output, _repeated_preCondition_codec);
		effect_.WriteTo(output, _repeated_effect_codec);
		filters_.WriteTo(output, _repeated_filters_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		num += preCondition_.CalculateSize(_repeated_preCondition_codec);
		num += effect_.CalculateSize(_repeated_effect_codec);
		num += filters_.CalculateSize(_repeated_filters_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAIActionDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			preCondition_.Add(other.preCondition_);
			effect_.Add(other.effect_);
			filters_.Add(other.filters_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
			case 18u:
				preCondition_.AddEntriesFrom(input, _repeated_preCondition_codec);
				break;
			case 24u:
			case 26u:
				effect_.AddEntriesFrom(input, _repeated_effect_codec);
				break;
			case 34u:
				filters_.AddEntriesFrom(input, _repeated_filters_codec);
				break;
			}
		}
	}
}
