using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class BossRushContinuousFight : IMessage<BossRushContinuousFight>, IMessage, IEquatable<BossRushContinuousFight>, IDeepCloneable<BossRushContinuousFight>
{
	private static readonly MessageParser<BossRushContinuousFight> _parser = new MessageParser<BossRushContinuousFight>(() => new BossRushContinuousFight());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<BossRushContinuousFightGroup> _repeated_bossGroups_codec = FieldCodec.ForMessage(10u, BossRushContinuousFightGroup.Parser);

	private readonly RepeatedField<BossRushContinuousFightGroup> bossGroups_ = new RepeatedField<BossRushContinuousFightGroup>();

	public static MessageParser<BossRushContinuousFight> Parser => _parser;

	public RepeatedField<BossRushContinuousFightGroup> BossGroups => bossGroups_;

	public BossRushContinuousFight()
	{
	}

	public BossRushContinuousFight(BossRushContinuousFight other)
		: this()
	{
		bossGroups_ = other.bossGroups_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossRushContinuousFight Clone()
	{
		return new BossRushContinuousFight(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossRushContinuousFight);
	}

	public bool Equals(BossRushContinuousFight other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bossGroups_.Equals(other.bossGroups_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= bossGroups_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		bossGroups_.WriteTo(output, _repeated_bossGroups_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += bossGroups_.CalculateSize(_repeated_bossGroups_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossRushContinuousFight other)
	{
		if (other != null)
		{
			bossGroups_.Add(other.bossGroups_);
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
				bossGroups_.AddEntriesFrom(input, _repeated_bossGroups_codec);
			}
		}
	}
}
