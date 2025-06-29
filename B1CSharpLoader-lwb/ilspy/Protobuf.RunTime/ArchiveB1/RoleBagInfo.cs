using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace ArchiveB1;

public sealed class RoleBagInfo : IMessage<RoleBagInfo>, IMessage, IEquatable<RoleBagInfo>, IDeepCloneable<RoleBagInfo>
{
	private static readonly MessageParser<RoleBagInfo> _parser = new MessageParser<RoleBagInfo>(() => new RoleBagInfo());

	private UnknownFieldSet _unknownFields;

	private ulong equipUidSeq_;

	private ulong soulSkillUidSeq_;

	private static readonly FieldCodec<int> _repeated_activatedWeaponIdList_codec = FieldCodec.ForInt32(26u);

	private readonly RepeatedField<int> activatedWeaponIdList_ = new RepeatedField<int>();

	private AlchemyNpcCommunicationStatus alchemyNpcCommunicationStatus_;

	private ulong wineUidSeq_;

	private static readonly FieldCodec<EditionType> _repeated_editionAwardList_codec = FieldCodec.ForEnum(58u, (EditionType x) => (int)x, (int x) => (EditionType)x);

	private readonly RepeatedField<EditionType> editionAwardList_ = new RepeatedField<EditionType>();

	public static MessageParser<RoleBagInfo> Parser => _parser;

	public ulong EquipUidSeq
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

	public ulong SoulSkillUidSeq
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

	public RepeatedField<int> ActivatedWeaponIdList => activatedWeaponIdList_;

	public AlchemyNpcCommunicationStatus AlchemyNpcCommunicationStatus
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

	public ulong WineUidSeq
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

	public RepeatedField<EditionType> EditionAwardList => editionAwardList_;

	public RoleBagInfo()
	{
	}

	public RoleBagInfo(RoleBagInfo other)
		: this()
	{
		equipUidSeq_ = other.equipUidSeq_;
		soulSkillUidSeq_ = other.soulSkillUidSeq_;
		activatedWeaponIdList_ = other.activatedWeaponIdList_.Clone();
		alchemyNpcCommunicationStatus_ = ((other.alchemyNpcCommunicationStatus_ != null) ? other.alchemyNpcCommunicationStatus_.Clone() : null);
		wineUidSeq_ = other.wineUidSeq_;
		editionAwardList_ = other.editionAwardList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleBagInfo Clone()
	{
		return new RoleBagInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleBagInfo);
	}

	public bool Equals(RoleBagInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EquipUidSeq != other.EquipUidSeq)
		{
			return false;
		}
		if (SoulSkillUidSeq != other.SoulSkillUidSeq)
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
		if (WineUidSeq != other.WineUidSeq)
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
		if (EquipUidSeq != 0L)
		{
			num ^= EquipUidSeq.GetHashCode();
		}
		if (SoulSkillUidSeq != 0L)
		{
			num ^= SoulSkillUidSeq.GetHashCode();
		}
		num ^= activatedWeaponIdList_.GetHashCode();
		if (alchemyNpcCommunicationStatus_ != null)
		{
			num ^= AlchemyNpcCommunicationStatus.GetHashCode();
		}
		if (WineUidSeq != 0L)
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
		if (EquipUidSeq != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(EquipUidSeq);
		}
		if (SoulSkillUidSeq != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(SoulSkillUidSeq);
		}
		activatedWeaponIdList_.WriteTo(output, _repeated_activatedWeaponIdList_codec);
		if (alchemyNpcCommunicationStatus_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(AlchemyNpcCommunicationStatus);
		}
		if (WineUidSeq != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(WineUidSeq);
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
		if (EquipUidSeq != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EquipUidSeq);
		}
		if (SoulSkillUidSeq != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(SoulSkillUidSeq);
		}
		num += activatedWeaponIdList_.CalculateSize(_repeated_activatedWeaponIdList_codec);
		if (alchemyNpcCommunicationStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AlchemyNpcCommunicationStatus);
		}
		if (WineUidSeq != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(WineUidSeq);
		}
		num += editionAwardList_.CalculateSize(_repeated_editionAwardList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleBagInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EquipUidSeq != 0L)
		{
			EquipUidSeq = other.EquipUidSeq;
		}
		if (other.SoulSkillUidSeq != 0L)
		{
			SoulSkillUidSeq = other.SoulSkillUidSeq;
		}
		activatedWeaponIdList_.Add(other.activatedWeaponIdList_);
		if (other.alchemyNpcCommunicationStatus_ != null)
		{
			if (alchemyNpcCommunicationStatus_ == null)
			{
				AlchemyNpcCommunicationStatus = new AlchemyNpcCommunicationStatus();
			}
			AlchemyNpcCommunicationStatus.MergeFrom(other.AlchemyNpcCommunicationStatus);
		}
		if (other.WineUidSeq != 0L)
		{
			WineUidSeq = other.WineUidSeq;
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
				EquipUidSeq = input.ReadUInt64();
				break;
			case 16u:
				SoulSkillUidSeq = input.ReadUInt64();
				break;
			case 24u:
			case 26u:
				activatedWeaponIdList_.AddEntriesFrom(input, _repeated_activatedWeaponIdList_codec);
				break;
			case 34u:
				if (alchemyNpcCommunicationStatus_ == null)
				{
					AlchemyNpcCommunicationStatus = new AlchemyNpcCommunicationStatus();
				}
				input.ReadMessage(AlchemyNpcCommunicationStatus);
				break;
			case 48u:
				WineUidSeq = input.ReadUInt64();
				break;
			case 56u:
			case 58u:
				editionAwardList_.AddEntriesFrom(input, _repeated_editionAwardList_codec);
				break;
			}
		}
	}
}
