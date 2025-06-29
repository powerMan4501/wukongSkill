using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleBagInfoSyncWrapper : IMessage<RoleBagInfoSyncWrapper>, IMessage, IEquatable<RoleBagInfoSyncWrapper>, IDeepCloneable<RoleBagInfoSyncWrapper>
{
	private static readonly MessageParser<RoleBagInfoSyncWrapper> _parser = new MessageParser<RoleBagInfoSyncWrapper>(() => new RoleBagInfoSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private Uint64SyncWrapper equipUidSeq_;

	private Uint64SyncWrapper soulSkillUidSeq_;

	private static readonly FieldCodec<Int32SyncWrapper> _repeated_activatedWeaponIdList_codec = FieldCodec.ForMessage(42u, Int32SyncWrapper.Parser);

	private readonly RepeatedField<Int32SyncWrapper> activatedWeaponIdList_ = new RepeatedField<Int32SyncWrapper>();

	private AlchemyNpcCommunicationStatusSyncWrapper alchemyNpcCommunicationStatus_;

	private Uint64SyncWrapper wineUidSeq_;

	private static readonly FieldCodec<EditionTypeSyncWrapper> _repeated_editionAwardList_codec = FieldCodec.ForMessage(74u, EditionTypeSyncWrapper.Parser);

	private readonly RepeatedField<EditionTypeSyncWrapper> editionAwardList_ = new RepeatedField<EditionTypeSyncWrapper>();

	public static MessageParser<RoleBagInfoSyncWrapper> Parser => _parser;

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

	public Uint64SyncWrapper EquipUidSeq
	{
		get
		{
			return equipUidSeq_;
		}
		set
		{
			equipUidSeq_ = value;
		}
	}

	public Uint64SyncWrapper SoulSkillUidSeq
	{
		get
		{
			return soulSkillUidSeq_;
		}
		set
		{
			soulSkillUidSeq_ = value;
		}
	}

	public RepeatedField<Int32SyncWrapper> ActivatedWeaponIdList => activatedWeaponIdList_;

	public AlchemyNpcCommunicationStatusSyncWrapper AlchemyNpcCommunicationStatus
	{
		get
		{
			return alchemyNpcCommunicationStatus_;
		}
		set
		{
			alchemyNpcCommunicationStatus_ = value;
		}
	}

	public Uint64SyncWrapper WineUidSeq
	{
		get
		{
			return wineUidSeq_;
		}
		set
		{
			wineUidSeq_ = value;
		}
	}

	public RepeatedField<EditionTypeSyncWrapper> EditionAwardList => editionAwardList_;

	public RoleBagInfoSyncWrapper()
	{
	}

	public RoleBagInfoSyncWrapper(RoleBagInfoSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		equipUidSeq_ = ((other.equipUidSeq_ != null) ? other.equipUidSeq_.Clone() : null);
		soulSkillUidSeq_ = ((other.soulSkillUidSeq_ != null) ? other.soulSkillUidSeq_.Clone() : null);
		activatedWeaponIdList_ = other.activatedWeaponIdList_.Clone();
		alchemyNpcCommunicationStatus_ = ((other.alchemyNpcCommunicationStatus_ != null) ? other.alchemyNpcCommunicationStatus_.Clone() : null);
		wineUidSeq_ = ((other.wineUidSeq_ != null) ? other.wineUidSeq_.Clone() : null);
		editionAwardList_ = other.editionAwardList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBagInfoSyncWrapper Clone()
	{
		return new RoleBagInfoSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBagInfoSyncWrapper);
	}

	public bool Equals(RoleBagInfoSyncWrapper other)
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
		if (!object.Equals(EquipUidSeq, other.EquipUidSeq))
		{
			return false;
		}
		if (!object.Equals(SoulSkillUidSeq, other.SoulSkillUidSeq))
		{
			return false;
		}
		if (!activatedWeaponIdList_.Equals(other.activatedWeaponIdList_))
		{
			return false;
		}
		if (!object.Equals(AlchemyNpcCommunicationStatus, other.AlchemyNpcCommunicationStatus))
		{
			return false;
		}
		if (!object.Equals(WineUidSeq, other.WineUidSeq))
		{
			return false;
		}
		if (!editionAwardList_.Equals(other.editionAwardList_))
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
		if (equipUidSeq_ != null)
		{
			num ^= EquipUidSeq.GetHashCode();
		}
		if (soulSkillUidSeq_ != null)
		{
			num ^= SoulSkillUidSeq.GetHashCode();
		}
		num ^= activatedWeaponIdList_.GetHashCode();
		if (alchemyNpcCommunicationStatus_ != null)
		{
			num ^= AlchemyNpcCommunicationStatus.GetHashCode();
		}
		if (wineUidSeq_ != null)
		{
			num ^= WineUidSeq.GetHashCode();
		}
		num ^= editionAwardList_.GetHashCode();
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
		if (equipUidSeq_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EquipUidSeq);
		}
		if (soulSkillUidSeq_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(SoulSkillUidSeq);
		}
		activatedWeaponIdList_.WriteTo(output, _repeated_activatedWeaponIdList_codec);
		if (alchemyNpcCommunicationStatus_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AlchemyNpcCommunicationStatus);
		}
		if (wineUidSeq_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(WineUidSeq);
		}
		editionAwardList_.WriteTo(output, _repeated_editionAwardList_codec);
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
		if (equipUidSeq_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipUidSeq);
		}
		if (soulSkillUidSeq_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SoulSkillUidSeq);
		}
		num += activatedWeaponIdList_.CalculateSize(_repeated_activatedWeaponIdList_codec);
		if (alchemyNpcCommunicationStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AlchemyNpcCommunicationStatus);
		}
		if (wineUidSeq_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(WineUidSeq);
		}
		num += editionAwardList_.CalculateSize(_repeated_editionAwardList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBagInfoSyncWrapper other)
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
		if (other.equipUidSeq_ != null)
		{
			if (equipUidSeq_ == null)
			{
				EquipUidSeq = new Uint64SyncWrapper();
			}
			EquipUidSeq.MergeFrom(other.EquipUidSeq);
		}
		if (other.soulSkillUidSeq_ != null)
		{
			if (soulSkillUidSeq_ == null)
			{
				SoulSkillUidSeq = new Uint64SyncWrapper();
			}
			SoulSkillUidSeq.MergeFrom(other.SoulSkillUidSeq);
		}
		activatedWeaponIdList_.Add(other.activatedWeaponIdList_);
		if (other.alchemyNpcCommunicationStatus_ != null)
		{
			if (alchemyNpcCommunicationStatus_ == null)
			{
				AlchemyNpcCommunicationStatus = new AlchemyNpcCommunicationStatusSyncWrapper();
			}
			AlchemyNpcCommunicationStatus.MergeFrom(other.AlchemyNpcCommunicationStatus);
		}
		if (other.wineUidSeq_ != null)
		{
			if (wineUidSeq_ == null)
			{
				WineUidSeq = new Uint64SyncWrapper();
			}
			WineUidSeq.MergeFrom(other.WineUidSeq);
		}
		editionAwardList_.Add(other.editionAwardList_);
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
				if (equipUidSeq_ == null)
				{
					EquipUidSeq = new Uint64SyncWrapper();
				}
				input.ReadMessage(EquipUidSeq);
				break;
			case 34u:
				if (soulSkillUidSeq_ == null)
				{
					SoulSkillUidSeq = new Uint64SyncWrapper();
				}
				input.ReadMessage(SoulSkillUidSeq);
				break;
			case 42u:
				activatedWeaponIdList_.AddEntriesFrom(input, _repeated_activatedWeaponIdList_codec);
				break;
			case 50u:
				if (alchemyNpcCommunicationStatus_ == null)
				{
					AlchemyNpcCommunicationStatus = new AlchemyNpcCommunicationStatusSyncWrapper();
				}
				input.ReadMessage(AlchemyNpcCommunicationStatus);
				break;
			case 66u:
				if (wineUidSeq_ == null)
				{
					WineUidSeq = new Uint64SyncWrapper();
				}
				input.ReadMessage(WineUidSeq);
				break;
			case 74u:
				editionAwardList_.AddEntriesFrom(input, _repeated_editionAwardList_codec);
				break;
			}
		}
	}
}
