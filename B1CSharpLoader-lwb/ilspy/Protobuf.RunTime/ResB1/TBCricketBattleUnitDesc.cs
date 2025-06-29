using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TBCricketBattleUnitDesc : IMessage<TBCricketBattleUnitDesc>, IMessage, IEquatable<TBCricketBattleUnitDesc>, IDeepCloneable<TBCricketBattleUnitDesc>
{
	private static readonly MessageParser<TBCricketBattleUnitDesc> _parser = new MessageParser<TBCricketBattleUnitDesc>(() => new TBCricketBattleUnitDesc());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<CricketBattleUnitDesc> _repeated_list_codec = FieldCodec.ForMessage(10u, CricketBattleUnitDesc.Parser);

	private readonly RepeatedField<CricketBattleUnitDesc> list_ = new RepeatedField<CricketBattleUnitDesc>();

	public static MessageParser<TBCricketBattleUnitDesc> Parser => _parser;

	public RepeatedField<CricketBattleUnitDesc> List => list_;

	public TBCricketBattleUnitDesc()
	{
	}

	public TBCricketBattleUnitDesc(TBCricketBattleUnitDesc other)
		: this()
	{
		list_ = other.list_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TBCricketBattleUnitDesc Clone()
	{
		return new TBCricketBattleUnitDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TBCricketBattleUnitDesc);
	}

	public bool Equals(TBCricketBattleUnitDesc other)
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

	public void MergeFrom(TBCricketBattleUnitDesc other)
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
