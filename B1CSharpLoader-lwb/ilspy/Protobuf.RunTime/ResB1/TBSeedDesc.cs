using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBSeedDesc : IMessage<TBSeedDesc>, IMessage, IEquatable<TBSeedDesc>, IDeepCloneable<TBSeedDesc>
{
	private static readonly MessageParser<TBSeedDesc> _parser = new MessageParser<TBSeedDesc>(() => new TBSeedDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<SeedDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, SeedDesc.Parser);

	private readonly RepeatedField<SeedDesc> list_ = new RepeatedField<SeedDesc>();

	public static MessageParser<TBSeedDesc> Parser => _parser;

	public RepeatedField<SeedDesc> List => list_;

	public TBSeedDesc()
	{
	}

	public TBSeedDesc(TBSeedDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBSeedDesc Clone()
	{
		return new TBSeedDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBSeedDesc);
	}

	public bool Equals(TBSeedDesc other)
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

	public void MergeFrom(TBSeedDesc other)
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
