using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class TBFUStDialogueDesc : IMessage<TBFUStDialogueDesc>, IMessage, IEquatable<TBFUStDialogueDesc>, IDeepCloneable<TBFUStDialogueDesc>
{
	private static readonly MessageParser<TBFUStDialogueDesc> _parser = new MessageParser<TBFUStDialogueDesc>(() => new TBFUStDialogueDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<FUStDialogueDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, FUStDialogueDesc.Parser);

	private readonly RepeatedField<FUStDialogueDesc> list_ = new RepeatedField<FUStDialogueDesc>();

	public static MessageParser<TBFUStDialogueDesc> Parser => _parser;

	public RepeatedField<FUStDialogueDesc> List => list_;

	public TBFUStDialogueDesc()
	{
	}

	public TBFUStDialogueDesc(TBFUStDialogueDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBFUStDialogueDesc Clone()
	{
		return new TBFUStDialogueDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBFUStDialogueDesc);
	}

	public bool Equals(TBFUStDialogueDesc other)
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

	public void MergeFrom(TBFUStDialogueDesc other)
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
