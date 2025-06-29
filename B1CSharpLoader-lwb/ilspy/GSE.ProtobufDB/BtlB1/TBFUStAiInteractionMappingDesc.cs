using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStAiInteractionMappingDesc : IMessage<TBFUStAiInteractionMappingDesc>, IMessage, IEquatable<TBFUStAiInteractionMappingDesc>, IDeepCloneable<TBFUStAiInteractionMappingDesc>
{
	private static readonly MessageParser<TBFUStAiInteractionMappingDesc> _parser = new MessageParser<TBFUStAiInteractionMappingDesc>(() => new TBFUStAiInteractionMappingDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStAiInteractionMappingDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStAiInteractionMappingDesc.Parser);

	private readonly RepeatedField<FUStAiInteractionMappingDesc> list_ = new RepeatedField<FUStAiInteractionMappingDesc>();

	public static MessageParser<TBFUStAiInteractionMappingDesc> Parser => _parser;

	public RepeatedField<FUStAiInteractionMappingDesc> List => list_;

	public TBFUStAiInteractionMappingDesc()
	{
	}

	public TBFUStAiInteractionMappingDesc(TBFUStAiInteractionMappingDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStAiInteractionMappingDesc Clone()
	{
		return new TBFUStAiInteractionMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStAiInteractionMappingDesc);
	}

	public bool Equals(TBFUStAiInteractionMappingDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!list_.Equals(other.list_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= list_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		list_.WriteTo(output, _repeated_list_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += list_.CalculateSize(_repeated_list_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TBFUStAiInteractionMappingDesc other)
	{
		if (other != null)
		{
			list_.Add(other.list_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				list_.AddEntriesFrom(input, _repeated_list_codec);
			}
		}
	}
}
