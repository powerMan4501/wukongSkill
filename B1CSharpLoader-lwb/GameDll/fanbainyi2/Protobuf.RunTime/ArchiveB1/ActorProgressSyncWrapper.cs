using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class ActorProgressSyncWrapper : IMessage<ActorProgressSyncWrapper>, IMessage, IEquatable<ActorProgressSyncWrapper>, IDeepCloneable<ActorProgressSyncWrapper>
{
	private static readonly MessageParser<ActorProgressSyncWrapper> _parser = new MessageParser<ActorProgressSyncWrapper>(() => new ActorProgressSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper xp_;

	private Int32SyncWrapper talenPoint_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_spellList_codec = FieldCodec.ForMessage(42u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> spellList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<TalentOneSyncWrapper> _repeated_talenList_codec = FieldCodec.ForMessage(50u, TalentOneSyncWrapper.Parser);

	private readonly RepeatedField<TalentOneSyncWrapper> talenList_ = new RepeatedField<TalentOneSyncWrapper>();

	private Int32SyncWrapper xpTotal_;

	private static readonly FieldCodec<LegacyAbilitySyncWrapper> _repeated_legacyList_codec = FieldCodec.ForMessage(82u, LegacyAbilitySyncWrapper.Parser);

	private readonly RepeatedField<LegacyAbilitySyncWrapper> legacyList_ = new RepeatedField<LegacyAbilitySyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_awardMeditationList_codec = FieldCodec.ForMessage(90u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> awardMeditationList_ = new RepeatedField<Int32SyncWrapper>();

	private static readonly FieldCodec<MeditationOneSyncWrapper> _repeated_meditationsList_codec = FieldCodec.ForMessage(106u, MeditationOneSyncWrapper.Parser);

	private readonly RepeatedField<MeditationOneSyncWrapper> meditationsList_ = new RepeatedField<MeditationOneSyncWrapper>();

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_awardTalentPointMeditationList_codec = FieldCodec.ForMessage(114u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> awardTalentPointMeditationList_ = new RepeatedField<Int32SyncWrapper>();

	public static MessageParser<ActorProgressSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public Int32SyncWrapper Xp
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

	public Int32SyncWrapper TalenPoint
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

	public RepeatedField<Int32SyncWrapper> SpellList => spellList_;

	public RepeatedField<TalentOneSyncWrapper> TalenList => talenList_;

	public Int32SyncWrapper XpTotal
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

	public RepeatedField<LegacyAbilitySyncWrapper> LegacyList => legacyList_;

	public RepeatedField<Int32SyncWrapper> AwardMeditationList => awardMeditationList_;

	public RepeatedField<MeditationOneSyncWrapper> MeditationsList => meditationsList_;

	public RepeatedField<Int32SyncWrapper> AwardTalentPointMeditationList => awardTalentPointMeditationList_;

	public ActorProgressSyncWrapper()
	{
	}

	public ActorProgressSyncWrapper(ActorProgressSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		xp_ = ((other.xp_ != null) ? other.xp_.Clone() : null);
		talenPoint_ = ((other.talenPoint_ != null) ? other.talenPoint_.Clone() : null);
		spellList_ = other.spellList_.Clone();
		talenList_ = other.talenList_.Clone();
		xpTotal_ = ((other.xpTotal_ != null) ? other.xpTotal_.Clone() : null);
		legacyList_ = other.legacyList_.Clone();
		awardMeditationList_ = other.awardMeditationList_.Clone();
		meditationsList_ = other.meditationsList_.Clone();
		awardTalentPointMeditationList_ = other.awardTalentPointMeditationList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ActorProgressSyncWrapper Clone()
	{
		return new ActorProgressSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ActorProgressSyncWrapper);
	}

	public bool Equals(ActorProgressSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(Xp, other.Xp))
		{
			return false;
		}
		if (!object.Equals(TalenPoint, other.TalenPoint))
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
		if (!object.Equals(XpTotal, other.XpTotal))
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
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (xp_ != null)
		{
			num ^= Xp.GetHashCode();
		}
		if (talenPoint_ != null)
		{
			num ^= TalenPoint.GetHashCode();
		}
		num ^= spellList_.GetHashCode();
		num ^= talenList_.GetHashCode();
		if (xpTotal_ != null)
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
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (xp_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Xp);
		}
		if (talenPoint_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(TalenPoint);
		}
		spellList_.WriteTo(output, _repeated_spellList_codec);
		talenList_.WriteTo(output, _repeated_talenList_codec);
		if (xpTotal_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(XpTotal);
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
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (xp_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Xp);
		}
		if (talenPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalenPoint);
		}
		num += spellList_.CalculateSize(_repeated_spellList_codec);
		num += talenList_.CalculateSize(_repeated_talenList_codec);
		if (xpTotal_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(XpTotal);
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

	public void MergeFrom(ActorProgressSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.xp_ != null)
		{
			if (xp_ == null)
			{
				Xp = new Int32SyncWrapper();
			}
			Xp.MergeFrom(other.Xp);
		}
		if (other.talenPoint_ != null)
		{
			if (talenPoint_ == null)
			{
				TalenPoint = new Int32SyncWrapper();
			}
			TalenPoint.MergeFrom(other.TalenPoint);
		}
		spellList_.Add(other.spellList_);
		talenList_.Add(other.talenList_);
		if (other.xpTotal_ != null)
		{
			if (xpTotal_ == null)
			{
				XpTotal = new Int32SyncWrapper();
			}
			XpTotal.MergeFrom(other.XpTotal);
		}
		legacyList_.Add(other.legacyList_);
		awardMeditationList_.Add(other.awardMeditationList_);
		meditationsList_.Add(other.meditationsList_);
		awardTalentPointMeditationList_.Add(other.awardTalentPointMeditationList_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (xp_ == null)
				{
					Xp = new Int32SyncWrapper();
				}
				input.ReadMessage(Xp);
				break;
			case 34u:
				if (talenPoint_ == null)
				{
					TalenPoint = new Int32SyncWrapper();
				}
				input.ReadMessage(TalenPoint);
				break;
			case 42u:
				spellList_.AddEntriesFrom(input, _repeated_spellList_codec);
				break;
			case 50u:
				talenList_.AddEntriesFrom(input, _repeated_talenList_codec);
				break;
			case 74u:
				if (xpTotal_ == null)
				{
					XpTotal = new Int32SyncWrapper();
				}
				input.ReadMessage(XpTotal);
				break;
			case 82u:
				legacyList_.AddEntriesFrom(input, _repeated_legacyList_codec);
				break;
			case 90u:
				awardMeditationList_.AddEntriesFrom(input, _repeated_awardMeditationList_codec);
				break;
			case 106u:
				meditationsList_.AddEntriesFrom(input, _repeated_meditationsList_codec);
				break;
			case 114u:
				awardTalentPointMeditationList_.AddEntriesFrom(input, _repeated_awardTalentPointMeditationList_codec);
				break;
			}
		}
	}
}
