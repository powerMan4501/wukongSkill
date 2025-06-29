using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class LegacyAbility : IMessage<LegacyAbility>, IMessage, IEquatable<LegacyAbility>, IDeepCloneable<LegacyAbility>
{
	private static readonly MessageParser<LegacyAbility> _parser = new MessageParser<LegacyAbility>(() => new LegacyAbility());

	private UnknownFieldSet _unknownFields;

	private int legacyId_;

	private int talentPoint_;

	private static readonly FieldCodec<LegacyTalent> _repeated_talentList_codec = FieldCodec.ForMessage(34u, LegacyTalent.Parser);

	private readonly RepeatedField<LegacyTalent> talentList_ = new RepeatedField<LegacyTalent>();

	public static MessageParser<LegacyAbility> Parser => _parser;

	public int LegacyId
	{
		get
		{
			return legacyId_;
		}
		set
		{
			legacyId_ = value;
		}
	}

	public int TalentPoint
	{
		get
		{
			return talentPoint_;
		}
		set
		{
			talentPoint_ = value;
		}
	}

	public RepeatedField<LegacyTalent> TalentList => talentList_;

	public LegacyAbility()
	{
	}

	public LegacyAbility(LegacyAbility other)
		: this()
	{
		legacyId_ = other.legacyId_;
		talentPoint_ = other.talentPoint_;
		talentList_ = other.talentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LegacyAbility Clone()
	{
		return new LegacyAbility(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LegacyAbility);
	}

	public bool Equals(LegacyAbility other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LegacyId != other.LegacyId)
		{
			return false;
		}
		if (TalentPoint != other.TalentPoint)
		{
			return false;
		}
		if (!talentList_.Equals(other.talentList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LegacyId != 0)
		{
			num ^= LegacyId.GetHashCode();
		}
		if (TalentPoint != 0)
		{
			num ^= TalentPoint.GetHashCode();
		}
		num ^= talentList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LegacyId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LegacyId);
		}
		if (TalentPoint != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(TalentPoint);
		}
		talentList_.WriteTo(output, _repeated_talentList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LegacyId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LegacyId);
		}
		if (TalentPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalentPoint);
		}
		num += talentList_.CalculateSize(_repeated_talentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LegacyAbility other)
	{
		if (other != null)
		{
			if (other.LegacyId != 0)
			{
				LegacyId = other.LegacyId;
			}
			if (other.TalentPoint != 0)
			{
				TalentPoint = other.TalentPoint;
			}
			talentList_.Add(other.talentList_);
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
				LegacyId = input.ReadInt32();
				break;
			case 24u:
				TalentPoint = input.ReadInt32();
				break;
			case 34u:
				talentList_.AddEntriesFrom(input, _repeated_talentList_codec);
				break;
			}
		}
	}
}
