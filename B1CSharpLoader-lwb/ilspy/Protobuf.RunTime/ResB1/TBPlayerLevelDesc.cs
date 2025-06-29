using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBPlayerLevelDesc : IMessage<TBPlayerLevelDesc>, IMessage, IEquatable<TBPlayerLevelDesc>, IDeepCloneable<TBPlayerLevelDesc>
{
	private static readonly MessageParser<TBPlayerLevelDesc> _parser = new MessageParser<TBPlayerLevelDesc>(() => new TBPlayerLevelDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PlayerLevelDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, PlayerLevelDesc.Parser);

	private readonly RepeatedField<PlayerLevelDesc> list_ = new RepeatedField<PlayerLevelDesc>();

	public static MessageParser<TBPlayerLevelDesc> Parser => _parser;

	public RepeatedField<PlayerLevelDesc> List => list_;

	public TBPlayerLevelDesc()
	{
	}

	public TBPlayerLevelDesc(TBPlayerLevelDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBPlayerLevelDesc Clone()
	{
		return new TBPlayerLevelDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBPlayerLevelDesc);
	}

	public bool Equals(TBPlayerLevelDesc other)
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

	public void MergeFrom(TBPlayerLevelDesc other)
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
