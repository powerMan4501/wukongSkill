using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStTaskStageDesc : IMessage<FUStTaskStageDesc>, IMessage, IEquatable<FUStTaskStageDesc>, IDeepCloneable<FUStTaskStageDesc>
{
	private static readonly MessageParser<FUStTaskStageDesc> _parser = new MessageParser<FUStTaskStageDesc>(() => new FUStTaskStageDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string describe_ = "";

	private int belongsToLineID_;

	private static readonly FieldCodec<int> _repeated_activatedShopRefreshIDList_codec = FieldCodec.ForInt32(34u);

	private readonly RepeatedField<int> activatedShopRefreshIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_finishedShopRefreshIDList_codec = FieldCodec.ForInt32(42u);

	private readonly RepeatedField<int> finishedShopRefreshIDList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_activatedDropItemList_codec = FieldCodec.ForInt32(50u);

	private readonly RepeatedField<int> activatedDropItemList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_finishedDropItemList_codec = FieldCodec.ForInt32(58u);

	private readonly RepeatedField<int> finishedDropItemList_ = new RepeatedField<int>();

	private string filterSkillID_ = "";

	private static readonly FieldCodec<int> _repeated_activatedInteractionFuncList_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> activatedInteractionFuncList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_finishedInteractionFuncList_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> finishedInteractionFuncList_ = new RepeatedField<int>();

	private static readonly FieldCodec<NPCInfo> _repeated_activatedNPCInfoList_codec = FieldCodec.ForMessage(90u, NPCInfo.Parser);

	private readonly RepeatedField<NPCInfo> activatedNPCInfoList_ = new RepeatedField<NPCInfo>();

	private static readonly FieldCodec<NPCInfo> _repeated_finishedNPCInfoList_codec = FieldCodec.ForMessage(98u, NPCInfo.Parser);

	private readonly RepeatedField<NPCInfo> finishedNPCInfoList_ = new RepeatedField<NPCInfo>();

	private static readonly FieldCodec<int> _repeated_activatedAchievementIdList_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> activatedAchievementIdList_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_finishedAchievementIdList_codec = FieldCodec.ForInt32(114u);

	private readonly RepeatedField<int> finishedAchievementIdList_ = new RepeatedField<int>();

	private int playerRest_;

	private string guard_ = "";

	public static MessageParser<FUStTaskStageDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public string Describe
	{
		get
		{
			return describe_;
		}
		set
		{
			describe_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BelongsToLineID
	{
		get
		{
			return belongsToLineID_;
		}
		set
		{
			belongsToLineID_ = value;
		}
	}

	public RepeatedField<int> ActivatedShopRefreshIDList => activatedShopRefreshIDList_;

	public RepeatedField<int> FinishedShopRefreshIDList => finishedShopRefreshIDList_;

	public RepeatedField<int> ActivatedDropItemList => activatedDropItemList_;

	public RepeatedField<int> FinishedDropItemList => finishedDropItemList_;

	public string FilterSkillID
	{
		get
		{
			return filterSkillID_;
		}
		set
		{
			filterSkillID_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<int> ActivatedInteractionFuncList => activatedInteractionFuncList_;

	public RepeatedField<int> FinishedInteractionFuncList => finishedInteractionFuncList_;

	public RepeatedField<NPCInfo> ActivatedNPCInfoList => activatedNPCInfoList_;

	public RepeatedField<NPCInfo> FinishedNPCInfoList => finishedNPCInfoList_;

	public RepeatedField<int> ActivatedAchievementIdList => activatedAchievementIdList_;

	public RepeatedField<int> FinishedAchievementIdList => finishedAchievementIdList_;

	public int PlayerRest
	{
		get
		{
			return playerRest_;
		}
		set
		{
			playerRest_ = value;
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStTaskStageDesc()
	{
	}

	public FUStTaskStageDesc(FUStTaskStageDesc other)
		: this()
	{
		iD_ = other.iD_;
		describe_ = other.describe_;
		belongsToLineID_ = other.belongsToLineID_;
		activatedShopRefreshIDList_ = other.activatedShopRefreshIDList_.Clone();
		finishedShopRefreshIDList_ = other.finishedShopRefreshIDList_.Clone();
		activatedDropItemList_ = other.activatedDropItemList_.Clone();
		finishedDropItemList_ = other.finishedDropItemList_.Clone();
		filterSkillID_ = other.filterSkillID_;
		activatedInteractionFuncList_ = other.activatedInteractionFuncList_.Clone();
		finishedInteractionFuncList_ = other.finishedInteractionFuncList_.Clone();
		activatedNPCInfoList_ = other.activatedNPCInfoList_.Clone();
		finishedNPCInfoList_ = other.finishedNPCInfoList_.Clone();
		activatedAchievementIdList_ = other.activatedAchievementIdList_.Clone();
		finishedAchievementIdList_ = other.finishedAchievementIdList_.Clone();
		playerRest_ = other.playerRest_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTaskStageDesc Clone()
	{
		return new FUStTaskStageDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTaskStageDesc);
	}

	public bool Equals(FUStTaskStageDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (Describe != other.Describe)
		{
			return false;
		}
		if (BelongsToLineID != other.BelongsToLineID)
		{
			return false;
		}
		if (!activatedShopRefreshIDList_.Equals(other.activatedShopRefreshIDList_))
		{
			return false;
		}
		if (!finishedShopRefreshIDList_.Equals(other.finishedShopRefreshIDList_))
		{
			return false;
		}
		if (!activatedDropItemList_.Equals(other.activatedDropItemList_))
		{
			return false;
		}
		if (!finishedDropItemList_.Equals(other.finishedDropItemList_))
		{
			return false;
		}
		if (FilterSkillID != other.FilterSkillID)
		{
			return false;
		}
		if (!activatedInteractionFuncList_.Equals(other.activatedInteractionFuncList_))
		{
			return false;
		}
		if (!finishedInteractionFuncList_.Equals(other.finishedInteractionFuncList_))
		{
			return false;
		}
		if (!activatedNPCInfoList_.Equals(other.activatedNPCInfoList_))
		{
			return false;
		}
		if (!finishedNPCInfoList_.Equals(other.finishedNPCInfoList_))
		{
			return false;
		}
		if (!activatedAchievementIdList_.Equals(other.activatedAchievementIdList_))
		{
			return false;
		}
		if (!finishedAchievementIdList_.Equals(other.finishedAchievementIdList_))
		{
			return false;
		}
		if (PlayerRest != other.PlayerRest)
		{
			return false;
		}
		if (Guard != other.Guard)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (Describe.Length != 0)
		{
			num ^= Describe.GetHashCode();
		}
		if (BelongsToLineID != 0)
		{
			num ^= BelongsToLineID.GetHashCode();
		}
		num ^= activatedShopRefreshIDList_.GetHashCode();
		num ^= finishedShopRefreshIDList_.GetHashCode();
		num ^= activatedDropItemList_.GetHashCode();
		num ^= finishedDropItemList_.GetHashCode();
		if (FilterSkillID.Length != 0)
		{
			num ^= FilterSkillID.GetHashCode();
		}
		num ^= activatedInteractionFuncList_.GetHashCode();
		num ^= finishedInteractionFuncList_.GetHashCode();
		num ^= activatedNPCInfoList_.GetHashCode();
		num ^= finishedNPCInfoList_.GetHashCode();
		num ^= activatedAchievementIdList_.GetHashCode();
		num ^= finishedAchievementIdList_.GetHashCode();
		if (PlayerRest != 0)
		{
			num ^= PlayerRest.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (Describe.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Describe);
		}
		if (BelongsToLineID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(BelongsToLineID);
		}
		activatedShopRefreshIDList_.WriteTo(output, _repeated_activatedShopRefreshIDList_codec);
		finishedShopRefreshIDList_.WriteTo(output, _repeated_finishedShopRefreshIDList_codec);
		activatedDropItemList_.WriteTo(output, _repeated_activatedDropItemList_codec);
		finishedDropItemList_.WriteTo(output, _repeated_finishedDropItemList_codec);
		if (FilterSkillID.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(FilterSkillID);
		}
		activatedInteractionFuncList_.WriteTo(output, _repeated_activatedInteractionFuncList_codec);
		finishedInteractionFuncList_.WriteTo(output, _repeated_finishedInteractionFuncList_codec);
		activatedNPCInfoList_.WriteTo(output, _repeated_activatedNPCInfoList_codec);
		finishedNPCInfoList_.WriteTo(output, _repeated_finishedNPCInfoList_codec);
		activatedAchievementIdList_.WriteTo(output, _repeated_activatedAchievementIdList_codec);
		finishedAchievementIdList_.WriteTo(output, _repeated_finishedAchievementIdList_codec);
		if (PlayerRest != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(PlayerRest);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(130, 1);
			output.WriteString(Guard);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (Describe.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Describe);
		}
		if (BelongsToLineID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BelongsToLineID);
		}
		num += activatedShopRefreshIDList_.CalculateSize(_repeated_activatedShopRefreshIDList_codec);
		num += finishedShopRefreshIDList_.CalculateSize(_repeated_finishedShopRefreshIDList_codec);
		num += activatedDropItemList_.CalculateSize(_repeated_activatedDropItemList_codec);
		num += finishedDropItemList_.CalculateSize(_repeated_finishedDropItemList_codec);
		if (FilterSkillID.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FilterSkillID);
		}
		num += activatedInteractionFuncList_.CalculateSize(_repeated_activatedInteractionFuncList_codec);
		num += finishedInteractionFuncList_.CalculateSize(_repeated_finishedInteractionFuncList_codec);
		num += activatedNPCInfoList_.CalculateSize(_repeated_activatedNPCInfoList_codec);
		num += finishedNPCInfoList_.CalculateSize(_repeated_finishedNPCInfoList_codec);
		num += activatedAchievementIdList_.CalculateSize(_repeated_activatedAchievementIdList_codec);
		num += finishedAchievementIdList_.CalculateSize(_repeated_finishedAchievementIdList_codec);
		if (PlayerRest != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlayerRest);
		}
		if (Guard.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTaskStageDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Describe.Length != 0)
			{
				Describe = other.Describe;
			}
			if (other.BelongsToLineID != 0)
			{
				BelongsToLineID = other.BelongsToLineID;
			}
			activatedShopRefreshIDList_.Add(other.activatedShopRefreshIDList_);
			finishedShopRefreshIDList_.Add(other.finishedShopRefreshIDList_);
			activatedDropItemList_.Add(other.activatedDropItemList_);
			finishedDropItemList_.Add(other.finishedDropItemList_);
			if (other.FilterSkillID.Length != 0)
			{
				FilterSkillID = other.FilterSkillID;
			}
			activatedInteractionFuncList_.Add(other.activatedInteractionFuncList_);
			finishedInteractionFuncList_.Add(other.finishedInteractionFuncList_);
			activatedNPCInfoList_.Add(other.activatedNPCInfoList_);
			finishedNPCInfoList_.Add(other.finishedNPCInfoList_);
			activatedAchievementIdList_.Add(other.activatedAchievementIdList_);
			finishedAchievementIdList_.Add(other.finishedAchievementIdList_);
			if (other.PlayerRest != 0)
			{
				PlayerRest = other.PlayerRest;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
				ID = input.ReadInt32();
				break;
			case 18u:
				Describe = input.ReadString();
				break;
			case 24u:
				BelongsToLineID = input.ReadInt32();
				break;
			case 32u:
			case 34u:
				activatedShopRefreshIDList_.AddEntriesFrom(input, _repeated_activatedShopRefreshIDList_codec);
				break;
			case 40u:
			case 42u:
				finishedShopRefreshIDList_.AddEntriesFrom(input, _repeated_finishedShopRefreshIDList_codec);
				break;
			case 48u:
			case 50u:
				activatedDropItemList_.AddEntriesFrom(input, _repeated_activatedDropItemList_codec);
				break;
			case 56u:
			case 58u:
				finishedDropItemList_.AddEntriesFrom(input, _repeated_finishedDropItemList_codec);
				break;
			case 66u:
				FilterSkillID = input.ReadString();
				break;
			case 72u:
			case 74u:
				activatedInteractionFuncList_.AddEntriesFrom(input, _repeated_activatedInteractionFuncList_codec);
				break;
			case 80u:
			case 82u:
				finishedInteractionFuncList_.AddEntriesFrom(input, _repeated_finishedInteractionFuncList_codec);
				break;
			case 90u:
				activatedNPCInfoList_.AddEntriesFrom(input, _repeated_activatedNPCInfoList_codec);
				break;
			case 98u:
				finishedNPCInfoList_.AddEntriesFrom(input, _repeated_finishedNPCInfoList_codec);
				break;
			case 104u:
			case 106u:
				activatedAchievementIdList_.AddEntriesFrom(input, _repeated_activatedAchievementIdList_codec);
				break;
			case 112u:
			case 114u:
				finishedAchievementIdList_.AddEntriesFrom(input, _repeated_finishedAchievementIdList_codec);
				break;
			case 120u:
				PlayerRest = input.ReadInt32();
				break;
			case 130u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
