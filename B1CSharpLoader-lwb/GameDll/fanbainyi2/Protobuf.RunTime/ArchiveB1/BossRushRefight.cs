using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushRefight : IMessage<BossRushRefight>, IMessage, IEquatable<BossRushRefight>, IDeepCloneable<BossRushRefight>
{
	private static readonly MessageParser<BossRushRefight> _parser = new MessageParser<BossRushRefight>(() => new BossRushRefight());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<BossRushRefightBoss> _repeated_bossList_codec = FieldCodec.ForMessage(10u, BossRushRefightBoss.Parser);

	private readonly RepeatedField<BossRushRefightBoss> bossList_ = new RepeatedField<BossRushRefightBoss>();

	public static MessageParser<BossRushRefight> Parser => _parser;

	public RepeatedField<BossRushRefightBoss> BossList => bossList_;

	public BossRushRefight()
	{
	}

	public BossRushRefight(BossRushRefight other)
		: this()
	{
		bossList_ = other.bossList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushRefight Clone()
	{
		return new BossRushRefight(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushRefight);
	}

	public bool Equals(BossRushRefight other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bossList_.Equals(other.bossList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= bossList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		bossList_.WriteTo(output, _repeated_bossList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += bossList_.CalculateSize(_repeated_bossList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushRefight other)
	{
		if (other != null)
		{
			bossList_.Add(other.bossList_);
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
				bossList_.AddEntriesFrom(input, _repeated_bossList_codec);
			}
		}
	}
}
