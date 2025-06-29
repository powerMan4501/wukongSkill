using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class BossIterationsDesc : IMessage<BossIterationsDesc>, IMessage, IEquatable<BossIterationsDesc>, IDeepCloneable<BossIterationsDesc>
{
	private static readonly MessageParser<BossIterationsDesc> _parser = new MessageParser<BossIterationsDesc>(() => new BossIterationsDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string groupName_ = "";

	private static readonly FieldCodec<int> _repeated_bossSuccessiveInfo_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> bossSuccessiveInfo_ = new RepeatedField<int>();

	private static readonly FieldCodec<BossUnlockConfig> _repeated_unlockInfo_codec = FieldCodec.ForMessage(34u, BossUnlockConfig.Parser);

	private readonly RepeatedField<BossUnlockConfig> unlockInfo_ = new RepeatedField<BossUnlockConfig>();

	private static readonly FieldCodec<ItemOne> _repeated_iterationsAward_codec = FieldCodec.ForMessage(42u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> iterationsAward_ = new RepeatedField<ItemOne>();

	private int limitTime_;

	private static readonly FieldCodec<int> _repeated_limitTimeList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> limitTimeList_ = new RepeatedField<int>();

	private int sortId_;

	private int localizationTag_;

	private int pictureId_;

	private int battleEndBuff_;

	public static MessageParser<BossIterationsDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public string GroupName
	{
		get
		{
			return groupName_;
		}
		set
		{
			groupName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> BossSuccessiveInfo => bossSuccessiveInfo_;

	public RepeatedField<BossUnlockConfig> UnlockInfo => unlockInfo_;

	public RepeatedField<ItemOne> IterationsAward => iterationsAward_;

	public int LimitTime
	{
		get
		{
			return limitTime_;
		}
		set
		{
			limitTime_ = value;
		}
	}

	public RepeatedField<int> LimitTimeList => limitTimeList_;

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public int PictureId
	{
		get
		{
			return pictureId_;
		}
		set
		{
			pictureId_ = value;
		}
	}

	public int BattleEndBuff
	{
		get
		{
			return battleEndBuff_;
		}
		set
		{
			battleEndBuff_ = value;
		}
	}

	public BossIterationsDesc()
	{
	}

	public BossIterationsDesc(BossIterationsDesc other)
		: this()
	{
		id_ = other.id_;
		groupName_ = other.groupName_;
		bossSuccessiveInfo_ = other.bossSuccessiveInfo_.Clone();
		unlockInfo_ = other.unlockInfo_.Clone();
		iterationsAward_ = other.iterationsAward_.Clone();
		limitTime_ = other.limitTime_;
		limitTimeList_ = other.limitTimeList_.Clone();
		sortId_ = other.sortId_;
		localizationTag_ = other.localizationTag_;
		pictureId_ = other.pictureId_;
		battleEndBuff_ = other.battleEndBuff_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossIterationsDesc Clone()
	{
		return new BossIterationsDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossIterationsDesc);
	}

	public bool Equals(BossIterationsDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (GroupName != other.GroupName)
		{
			return false;
		}
		if (!bossSuccessiveInfo_.Equals(other.bossSuccessiveInfo_))
		{
			return false;
		}
		if (!unlockInfo_.Equals(other.unlockInfo_))
		{
			return false;
		}
		if (!iterationsAward_.Equals(other.iterationsAward_))
		{
			return false;
		}
		if (LimitTime != other.LimitTime)
		{
			return false;
		}
		if (!limitTimeList_.Equals(other.limitTimeList_))
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (PictureId != other.PictureId)
		{
			return false;
		}
		if (BattleEndBuff != other.BattleEndBuff)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (GroupName.Length != 0)
		{
			num ^= GroupName.GetHashCode();
		}
		num ^= bossSuccessiveInfo_.GetHashCode();
		num ^= unlockInfo_.GetHashCode();
		num ^= iterationsAward_.GetHashCode();
		if (LimitTime != 0)
		{
			num ^= LimitTime.GetHashCode();
		}
		num ^= limitTimeList_.GetHashCode();
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (PictureId != 0)
		{
			num ^= PictureId.GetHashCode();
		}
		if (BattleEndBuff != 0)
		{
			num ^= BattleEndBuff.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (GroupName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GroupName);
		}
		bossSuccessiveInfo_.WriteTo(output, _repeated_bossSuccessiveInfo_codec);
		unlockInfo_.WriteTo(output, _repeated_unlockInfo_codec);
		iterationsAward_.WriteTo(output, _repeated_iterationsAward_codec);
		if (LimitTime != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(LimitTime);
		}
		limitTimeList_.WriteTo(output, _repeated_limitTimeList_codec);
		if (SortId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(SortId);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(LocalizationTag);
		}
		if (PictureId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(PictureId);
		}
		if (BattleEndBuff != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(BattleEndBuff);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (GroupName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GroupName);
		}
		num += bossSuccessiveInfo_.CalculateSize(_repeated_bossSuccessiveInfo_codec);
		num += unlockInfo_.CalculateSize(_repeated_unlockInfo_codec);
		num += iterationsAward_.CalculateSize(_repeated_iterationsAward_codec);
		if (LimitTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitTime);
		}
		num += limitTimeList_.CalculateSize(_repeated_limitTimeList_codec);
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (PictureId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PictureId);
		}
		if (BattleEndBuff != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BattleEndBuff);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossIterationsDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.GroupName.Length != 0)
			{
				GroupName = other.GroupName;
			}
			bossSuccessiveInfo_.Add(other.bossSuccessiveInfo_);
			unlockInfo_.Add(other.unlockInfo_);
			iterationsAward_.Add(other.iterationsAward_);
			if (other.LimitTime != 0)
			{
				LimitTime = other.LimitTime;
			}
			limitTimeList_.Add(other.limitTimeList_);
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.PictureId != 0)
			{
				PictureId = other.PictureId;
			}
			if (other.BattleEndBuff != 0)
			{
				BattleEndBuff = other.BattleEndBuff;
			}
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
				Id = input.ReadInt32();
				break;
			case 18u:
				GroupName = input.ReadString();
				break;
			case 24u:
			case 26u:
				bossSuccessiveInfo_.AddEntriesFrom(input, _repeated_bossSuccessiveInfo_codec);
				break;
			case 34u:
				unlockInfo_.AddEntriesFrom(input, _repeated_unlockInfo_codec);
				break;
			case 42u:
				iterationsAward_.AddEntriesFrom(input, _repeated_iterationsAward_codec);
				break;
			case 48u:
				LimitTime = input.ReadInt32();
				break;
			case 56u:
			case 58u:
				limitTimeList_.AddEntriesFrom(input, _repeated_limitTimeList_codec);
				break;
			case 64u:
				SortId = input.ReadInt32();
				break;
			case 72u:
				LocalizationTag = input.ReadInt32();
				break;
			case 80u:
				PictureId = input.ReadInt32();
				break;
			case 88u:
				BattleEndBuff = input.ReadInt32();
				break;
			}
		}
	}
}
