using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class LegacyAbilitySyncWrapper : IMessage<LegacyAbilitySyncWrapper>, IMessage, IEquatable<LegacyAbilitySyncWrapper>, IDeepCloneable<LegacyAbilitySyncWrapper>
{
	private static readonly MessageParser<LegacyAbilitySyncWrapper> _parser = new MessageParser<LegacyAbilitySyncWrapper>(() => new LegacyAbilitySyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Int32SyncWrapper legacyId_;

	private Int32SyncWrapper talentPoint_;

	private static readonly FieldCodec<LegacyTalentSyncWrapper> _repeated_talentList_codec = FieldCodec.ForMessage(50u, LegacyTalentSyncWrapper.Parser);

	private readonly RepeatedField<LegacyTalentSyncWrapper> talentList_ = new RepeatedField<LegacyTalentSyncWrapper>();

	public static MessageParser<LegacyAbilitySyncWrapper> Parser => _parser;

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

	public Int32SyncWrapper LegacyId
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

	public Int32SyncWrapper TalentPoint
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

	public RepeatedField<LegacyTalentSyncWrapper> TalentList => talentList_;

	public LegacyAbilitySyncWrapper()
	{
	}

	public LegacyAbilitySyncWrapper(LegacyAbilitySyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		legacyId_ = ((other.legacyId_ != null) ? other.legacyId_.Clone() : null);
		talentPoint_ = ((other.talentPoint_ != null) ? other.talentPoint_.Clone() : null);
		talentList_ = other.talentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LegacyAbilitySyncWrapper Clone()
	{
		return new LegacyAbilitySyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LegacyAbilitySyncWrapper);
	}

	public bool Equals(LegacyAbilitySyncWrapper other)
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
		if (!object.Equals(LegacyId, other.LegacyId))
		{
			return false;
		}
		if (!object.Equals(TalentPoint, other.TalentPoint))
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
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (legacyId_ != null)
		{
			num ^= LegacyId.GetHashCode();
		}
		if (talentPoint_ != null)
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
		if (legacyId_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(LegacyId);
		}
		if (talentPoint_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(TalentPoint);
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
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (legacyId_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LegacyId);
		}
		if (talentPoint_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TalentPoint);
		}
		num += talentList_.CalculateSize(_repeated_talentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LegacyAbilitySyncWrapper other)
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
		if (other.legacyId_ != null)
		{
			if (legacyId_ == null)
			{
				LegacyId = new Int32SyncWrapper();
			}
			LegacyId.MergeFrom(other.LegacyId);
		}
		if (other.talentPoint_ != null)
		{
			if (talentPoint_ == null)
			{
				TalentPoint = new Int32SyncWrapper();
			}
			TalentPoint.MergeFrom(other.TalentPoint);
		}
		talentList_.Add(other.talentList_);
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
				if (legacyId_ == null)
				{
					LegacyId = new Int32SyncWrapper();
				}
				input.ReadMessage(LegacyId);
				break;
			case 42u:
				if (talentPoint_ == null)
				{
					TalentPoint = new Int32SyncWrapper();
				}
				input.ReadMessage(TalentPoint);
				break;
			case 50u:
				talentList_.AddEntriesFrom(input, _repeated_talentList_codec);
				break;
			}
		}
	}
}
