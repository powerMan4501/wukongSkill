using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TalentRankDesc : IMessage<TalentRankDesc>, IMessage, IEquatable<TalentRankDesc>, IDeepCloneable<TalentRankDesc>
{
	private static readonly MessageParser<TalentRankDesc> _parser = new MessageParser<TalentRankDesc>(() => new TalentRankDesc());

	private UnknownFieldSet _unknownFields;

	private SpellType spellType_;

	private int rank_;

	private int unlockRankPoint_;

	private static readonly FieldCodec<int> _repeated_unlockTalent_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> unlockTalent_ = new RepeatedField<int>();

	public static MessageParser<TalentRankDesc> Parser => _parser;

	public SpellType SpellType
	{
		get
		{
			return spellType_;
		}
		set
		{
			spellType_ = value;
		}
	}

	public int Rank
	{
		get
		{
			return rank_;
		}
		set
		{
			rank_ = value;
		}
	}

	public int UnlockRankPoint
	{
		get
		{
			return unlockRankPoint_;
		}
		set
		{
			unlockRankPoint_ = value;
		}
	}

	public RepeatedField<int> UnlockTalent => unlockTalent_;

	public TalentRankDesc()
	{
	}

	public TalentRankDesc(TalentRankDesc other)
		: this()
	{
		spellType_ = other.spellType_;
		rank_ = other.rank_;
		unlockRankPoint_ = other.unlockRankPoint_;
		unlockTalent_ = other.unlockTalent_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TalentRankDesc Clone()
	{
		return new TalentRankDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TalentRankDesc);
	}

	public bool Equals(TalentRankDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SpellType != other.SpellType)
		{
			return false;
		}
		if (Rank != other.Rank)
		{
			return false;
		}
		if (UnlockRankPoint != other.UnlockRankPoint)
		{
			return false;
		}
		if (!unlockTalent_.Equals(other.unlockTalent_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SpellType != SpellType.Min)
		{
			num ^= SpellType.GetHashCode();
		}
		if (Rank != 0)
		{
			num ^= Rank.GetHashCode();
		}
		if (UnlockRankPoint != 0)
		{
			num ^= UnlockRankPoint.GetHashCode();
		}
		num ^= unlockTalent_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SpellType != SpellType.Min)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)SpellType);
		}
		if (Rank != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Rank);
		}
		if (UnlockRankPoint != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(UnlockRankPoint);
		}
		unlockTalent_.WriteTo(output, _repeated_unlockTalent_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SpellType != SpellType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SpellType);
		}
		if (Rank != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Rank);
		}
		if (UnlockRankPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockRankPoint);
		}
		num += unlockTalent_.CalculateSize(_repeated_unlockTalent_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TalentRankDesc other)
	{
		if (other != null)
		{
			if (other.SpellType != SpellType.Min)
			{
				SpellType = other.SpellType;
			}
			if (other.Rank != 0)
			{
				Rank = other.Rank;
			}
			if (other.UnlockRankPoint != 0)
			{
				UnlockRankPoint = other.UnlockRankPoint;
			}
			unlockTalent_.Add(other.unlockTalent_);
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
				SpellType = (SpellType)input.ReadEnum();
				break;
			case 16u:
				Rank = input.ReadInt32();
				break;
			case 24u:
				UnlockRankPoint = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				unlockTalent_.AddEntriesFrom(input, _repeated_unlockTalent_codec);
				break;
			}
		}
	}
}
