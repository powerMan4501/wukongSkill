using System;
using Google.Protobuf;

namespace ResB1;

public sealed class BossReChallengeDesc : IMessage<BossReChallengeDesc>, IMessage, IEquatable<BossReChallengeDesc>, IDeepCloneable<BossReChallengeDesc>
{
	private static readonly MessageParser<BossReChallengeDesc> _parser = new MessageParser<BossReChallengeDesc>(() => new BossReChallengeDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int configId_;

	private EBossUnlockCondition unlockCondition_;

	private int unlockId_;

	private int unlockSuccessiveId_;

	private int mapGroupId_;

	private int sortId_;

	private int portraitId_;

	private int allowAssociationUnitConfigId_;

	public static MessageParser<BossReChallengeDesc> Parser => _parser;

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

	public int ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	public EBossUnlockCondition UnlockCondition
	{
		get
		{
			return unlockCondition_;
		}
		set
		{
			unlockCondition_ = value;
		}
	}

	public int UnlockId
	{
		get
		{
			return unlockId_;
		}
		set
		{
			unlockId_ = value;
		}
	}

	public int UnlockSuccessiveId
	{
		get
		{
			return unlockSuccessiveId_;
		}
		set
		{
			unlockSuccessiveId_ = value;
		}
	}

	public int MapGroupId
	{
		get
		{
			return mapGroupId_;
		}
		set
		{
			mapGroupId_ = value;
		}
	}

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

	public int PortraitId
	{
		get
		{
			return portraitId_;
		}
		set
		{
			portraitId_ = value;
		}
	}

	public int AllowAssociationUnitConfigId
	{
		get
		{
			return allowAssociationUnitConfigId_;
		}
		set
		{
			allowAssociationUnitConfigId_ = value;
		}
	}

	public BossReChallengeDesc()
	{
	}

	public BossReChallengeDesc(BossReChallengeDesc other)
		: this()
	{
		id_ = other.id_;
		configId_ = other.configId_;
		unlockCondition_ = other.unlockCondition_;
		unlockId_ = other.unlockId_;
		unlockSuccessiveId_ = other.unlockSuccessiveId_;
		mapGroupId_ = other.mapGroupId_;
		sortId_ = other.sortId_;
		portraitId_ = other.portraitId_;
		allowAssociationUnitConfigId_ = other.allowAssociationUnitConfigId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BossReChallengeDesc Clone()
	{
		return new BossReChallengeDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BossReChallengeDesc);
	}

	public bool Equals(BossReChallengeDesc other)
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
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (UnlockCondition != other.UnlockCondition)
		{
			return false;
		}
		if (UnlockId != other.UnlockId)
		{
			return false;
		}
		if (UnlockSuccessiveId != other.UnlockSuccessiveId)
		{
			return false;
		}
		if (MapGroupId != other.MapGroupId)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (PortraitId != other.PortraitId)
		{
			return false;
		}
		if (AllowAssociationUnitConfigId != other.AllowAssociationUnitConfigId)
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
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (UnlockCondition != EBossUnlockCondition.None)
		{
			num ^= UnlockCondition.GetHashCode();
		}
		if (UnlockId != 0)
		{
			num ^= UnlockId.GetHashCode();
		}
		if (UnlockSuccessiveId != 0)
		{
			num ^= UnlockSuccessiveId.GetHashCode();
		}
		if (MapGroupId != 0)
		{
			num ^= MapGroupId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (PortraitId != 0)
		{
			num ^= PortraitId.GetHashCode();
		}
		if (AllowAssociationUnitConfigId != 0)
		{
			num ^= AllowAssociationUnitConfigId.GetHashCode();
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
		if (ConfigId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ConfigId);
		}
		if (UnlockCondition != EBossUnlockCondition.None)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)UnlockCondition);
		}
		if (UnlockId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(UnlockId);
		}
		if (UnlockSuccessiveId != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(UnlockSuccessiveId);
		}
		if (MapGroupId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MapGroupId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(SortId);
		}
		if (PortraitId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(PortraitId);
		}
		if (AllowAssociationUnitConfigId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(AllowAssociationUnitConfigId);
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
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConfigId);
		}
		if (UnlockCondition != EBossUnlockCondition.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnlockCondition);
		}
		if (UnlockId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockId);
		}
		if (UnlockSuccessiveId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnlockSuccessiveId);
		}
		if (MapGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapGroupId);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (PortraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PortraitId);
		}
		if (AllowAssociationUnitConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AllowAssociationUnitConfigId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BossReChallengeDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.UnlockCondition != EBossUnlockCondition.None)
			{
				UnlockCondition = other.UnlockCondition;
			}
			if (other.UnlockId != 0)
			{
				UnlockId = other.UnlockId;
			}
			if (other.UnlockSuccessiveId != 0)
			{
				UnlockSuccessiveId = other.UnlockSuccessiveId;
			}
			if (other.MapGroupId != 0)
			{
				MapGroupId = other.MapGroupId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.PortraitId != 0)
			{
				PortraitId = other.PortraitId;
			}
			if (other.AllowAssociationUnitConfigId != 0)
			{
				AllowAssociationUnitConfigId = other.AllowAssociationUnitConfigId;
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
			case 16u:
				ConfigId = input.ReadInt32();
				break;
			case 24u:
				UnlockCondition = (EBossUnlockCondition)input.ReadEnum();
				break;
			case 32u:
				UnlockId = input.ReadInt32();
				break;
			case 40u:
				UnlockSuccessiveId = input.ReadInt32();
				break;
			case 48u:
				MapGroupId = input.ReadInt32();
				break;
			case 56u:
				SortId = input.ReadInt32();
				break;
			case 64u:
				PortraitId = input.ReadInt32();
				break;
			case 72u:
				AllowAssociationUnitConfigId = input.ReadInt32();
				break;
			}
		}
	}
}
