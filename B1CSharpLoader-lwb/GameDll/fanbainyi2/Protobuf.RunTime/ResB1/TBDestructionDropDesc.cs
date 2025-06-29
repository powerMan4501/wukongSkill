using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBDestructionDropDesc : IMessage<TBDestructionDropDesc>, IMessage, IEquatable<TBDestructionDropDesc>, IDeepCloneable<TBDestructionDropDesc>
{
	private static readonly MessageParser<TBDestructionDropDesc> _parser = new MessageParser<TBDestructionDropDesc>(() => new TBDestructionDropDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DestructionDropDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, DestructionDropDesc.Parser);

	private readonly RepeatedField<DestructionDropDesc> list_ = new RepeatedField<DestructionDropDesc>();

	public static MessageParser<TBDestructionDropDesc> Parser => _parser;

	public RepeatedField<DestructionDropDesc> List => list_;

	public TBDestructionDropDesc()
	{
	}

	public TBDestructionDropDesc(TBDestructionDropDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBDestructionDropDesc Clone()
	{
		return new TBDestructionDropDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBDestructionDropDesc);
	}

	public bool Equals(TBDestructionDropDesc other)
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

	public void MergeFrom(TBDestructionDropDesc other)
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
