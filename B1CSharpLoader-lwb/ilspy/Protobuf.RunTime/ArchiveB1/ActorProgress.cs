using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class ActorProgress : IMessage<ActorProgress>, IMessage, IEquatable<ActorProgress>, IDeepCloneable<ActorProgress>
{
	private static readonly MessageParser<ActorProgress> _parser = new MessageParser<ActorProgress>(() => new ActorProgress());

	private UnknownFieldSet _unknownFields;

	private int xp_;

	private int talenPoint_;

	private static readonly FieldCodec<int> _repeated_spellList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> spellList_ = new RepeatedField<int>();

	private static readonly FieldCodec<TalentOne> _repeated_talenList_codec = FieldCodec.ForMessage(34u, TalentOne.Parser);

	private readonly RepeatedField<TalentOne> talenList_ = new RepeatedField<TalentOne>();

	private int xpTotal_;

	private static readonly FieldCodec<LegacyAbility> _repeated_legacyList_codec = FieldCodec.ForMessage(66u, LegacyAbility.Parser);

	private readonly RepeatedField<LegacyAbility> legacyList_ = new RepeatedField<LegacyAbility>();

	private static readonly FieldCodec<int> _repeated_awardMeditationList_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> awardMeditationList_ = new RepeatedField<int>();

	private static readonly FieldCodec<MeditationOne> _repeated_meditationsList_codec = FieldCodec.ForMessage(90u, MeditationOne.Parser);

	private readonly RepeatedField<MeditationOne> meditationsList_ = new RepeatedField<MeditationOne>();

	private static readonly FieldCodec<int> _repeated_awardTalentPointMeditationList_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> awardTalentPointMeditationList_ = new RepeatedField<int>();

	public static MessageParser<ActorProgress> Parser => _parser;

	public int Xp
	{
		get
		{
			return xp_;
		}
		set
		{
			xp_ = value;
		}
	}

	public int TalenPoint
	{
		get
		{
			return talenPoint_;
		}
		set
		{
			talenPoint_ = value;
		}
	}

	public RepeatedField<int> SpellList => spellList_;

	public RepeatedField<TalentOne> TalenList => talenList_;

	public int XpTotal
	{
		get
		{
			return xpTotal_;
		}
		set
		{
			xpTotal_ = value;
		}
	}

	public RepeatedField<LegacyAbility> LegacyList => legacyList_;

	public RepeatedField<int> AwardMeditationList => awardMeditationList_;

	public RepeatedField<MeditationOne> MeditationsList => meditationsList_;

	public RepeatedField<int> AwardTalentPointMeditationList => awardTalentPointMeditationList_;

	public ActorProgress()
	{
	}

	public ActorProgress(ActorProgress other)
		: this()
	{
		xp_ = other.xp_;
		talenPoint_ = other.talenPoint_;
		spellList_ = other.spellList_.Clone();
		talenList_ = other.talenList_.Clone();
		xpTotal_ = other.xpTotal_;
		legacyList_ = other.legacyList_.Clone();
		awardMeditationList_ = other.awardMeditationList_.Clone();
		meditationsList_ = other.meditationsList_.Clone();
		awardTalentPointMeditationList_ = other.awardTalentPointMeditationList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ActorProgress Clone()
	{
		return new ActorProgress(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ActorProgress);
	}

	public bool Equals(ActorProgress other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Xp != other.Xp)
		{
			return false;
		}
		if (TalenPoint != other.TalenPoint)
		{
			return false;
		}
		if (!spellList_.Equals(other.spellList_))
		{
			return false;
		}
		if (!talenList_.Equals(other.talenList_))
		{
			return false;
		}
		if (XpTotal != other.XpTotal)
		{
			return false;
		}
		if (!legacyList_.Equals(other.legacyList_))
		{
			return false;
		}
		if (!awardMeditationList_.Equals(other.awardMeditationList_))
		{
			return false;
		}
		if (!meditationsList_.Equals(other.meditationsList_))
		{
			return false;
		}
		if (!awardTalentPointMeditationList_.Equals(other.awardTalentPointMeditationList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Xp != 0)
		{
			num ^= Xp.GetHashCode();
		}
		if (TalenPoint != 0)
		{
			num ^= TalenPoint.GetHashCode();
		}
		num ^= spellList_.GetHashCode();
		num ^= talenList_.GetHashCode();
		if (XpTotal != 0)
		{
			num ^= XpTotal.GetHashCode();
		}
		num ^= legacyList_.GetHashCode();
		num ^= awardMeditationList_.GetHashCode();
		num ^= meditationsList_.GetHashCode();
		num ^= awardTalentPointMeditationList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Xp != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Xp);
		}
		if (TalenPoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TalenPoint);
		}
		spellList_.WriteTo(output, _repeated_spellList_codec);
		talenList_.WriteTo(output, _repeated_talenList_codec);
		if (XpTotal != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(XpTotal);
		}
		legacyList_.WriteTo(output, _repeated_legacyList_codec);
		awardMeditationList_.WriteTo(output, _repeated_awardMeditationList_codec);
		meditationsList_.WriteTo(output, _repeated_meditationsList_codec);
		awardTalentPointMeditationList_.WriteTo(output, _repeated_awardTalentPointMeditationList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Xp != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Xp);
		}
		if (TalenPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TalenPoint);
		}
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		num += talenList_.CalculateSize(_repeated_talenList_codec);
		if (XpTotal != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(XpTotal);
		}
		num += legacyList_.CalculateSize(_repeated_legacyList_codec);
		num += awardMeditationList_.CalculateSize(_repeated_awardMeditationList_codec);
		num += meditationsList_.CalculateSize(_repeated_meditationsList_codec);
		num += awardTalentPointMeditationList_.CalculateSize(_repeated_awardTalentPointMeditationList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ActorProgress other)
	{
		if (other != null)
		{
			if (other.Xp != 0)
			{
				Xp = other.Xp;
			}
			if (other.TalenPoint != 0)
			{
				TalenPoint = other.TalenPoint;
			}
			spellList_.Add(other.spellList_);
			talenList_.Add(other.talenList_);
			if (other.XpTotal != 0)
			{
				XpTotal = other.XpTotal;
			}
			legacyList_.Add(other.legacyList_);
			awardMeditationList_.Add(other.awardMeditationList_);
			meditationsList_.Add(other.meditationsList_);
			awardTalentPointMeditationList_.Add(other.awardTalentPointMeditationList_);
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
				Xp = input.ReadInt32();
				break;
			case 16u:
				TalenPoint = input.ReadInt32();
				break;
			case 24u:
			case 26u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 34u:
				talenList_.AddEntriesFrom(input, _repeated_talenList_codec);
				break;
			case 56u:
				XpTotal = input.ReadInt32();
				break;
			case 66u:
				legacyList_.AddEntriesFrom(input, _repeated_legacyList_codec);
				break;
			case 72u:
			case 74u:
				awardMeditationList_.AddEntriesFrom(input, _repeated_awardMeditationList_codec);
				break;
			case 90u:
				meditationsList_.AddEntriesFrom(input, _repeated_meditationsList_codec);
				break;
			case 96u:
			case 98u:
				awardTalentPointMeditationList_.AddEntriesFrom(input, _repeated_awardTalentPointMeditationList_codec);
				break;
			}
		}
	}
}
