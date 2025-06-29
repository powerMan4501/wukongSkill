using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BPC_PlayerRoleData : IMessage<BPC_PlayerRoleData>, IMessage, IEquatable<BPC_PlayerRoleData>, IDeepCloneable<BPC_PlayerRoleData>
{
	private static readonly MessageParser<BPC_PlayerRoleData> _parser = new MessageParser<BPC_PlayerRoleData>(() => new BPC_PlayerRoleData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int beginAreaStayTime_;

	private int lastRebirthPointTime_;

	private int mapAreaId_;

	private int maxMapAreaId_;

	private int maxMapId_;

	private int mapId_;

	private int archiveIdRemoved_;

	private int demo820MapIdx_;

	private int defaultShortcutsPosition_;

	private static readonly FieldCodec<DictDeltaMsgInt_Int> _repeated_unitBookStateDicRemoved_codec = FieldCodec.ForMessage(82u, DictDeltaMsgInt_Int.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_Int> unitBookStateDicRemoved_ = new RepeatedField<DictDeltaMsgInt_Int>();

	private static readonly FieldCodec<ListDeltaMsgInt> _repeated_surprisePerformedList_codec = FieldCodec.ForMessage(90u, ListDeltaMsgInt.Parser);

	private readonly RepeatedField<ListDeltaMsgInt> surprisePerformedList_ = new RepeatedField<ListDeltaMsgInt>();

	private static readonly FieldCodec<DictDeltaMsgInt_GSUnitBookData> _repeated_unitBookDataDic_codec = FieldCodec.ForMessage(98u, DictDeltaMsgInt_GSUnitBookData.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_GSUnitBookData> unitBookDataDic_ = new RepeatedField<DictDeltaMsgInt_GSUnitBookData>();

	public static MessageParser<BPC_PlayerRoleData> Parser => _parser;

	public int BeginAreaStayTime
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return beginAreaStayTime_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			beginAreaStayTime_ = value;
		}
	}

	public bool HasBeginAreaStayTime => (_hasBits0 & 1) != 0;

	public int LastRebirthPointTime
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return lastRebirthPointTime_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			lastRebirthPointTime_ = value;
		}
	}

	public bool HasLastRebirthPointTime => (_hasBits0 & 2) != 0;

	public int MapAreaId
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return mapAreaId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			mapAreaId_ = value;
		}
	}

	public bool HasMapAreaId => (_hasBits0 & 4) != 0;

	public int MaxMapAreaId
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return maxMapAreaId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			maxMapAreaId_ = value;
		}
	}

	public bool HasMaxMapAreaId => (_hasBits0 & 8) != 0;

	public int MaxMapId
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return maxMapId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			maxMapId_ = value;
		}
	}

	public bool HasMaxMapId => (_hasBits0 & 0x10) != 0;

	public int MapId
	{
		get
		{
			if ((_hasBits0 & 0x20) != 0)
			{
				return mapId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 32;
			mapId_ = value;
		}
	}

	public bool HasMapId => (_hasBits0 & 0x20) != 0;

	public int ArchiveIdRemoved
	{
		get
		{
			if ((_hasBits0 & 0x40) != 0)
			{
				return archiveIdRemoved_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 64;
			archiveIdRemoved_ = value;
		}
	}

	public bool HasArchiveIdRemoved => (_hasBits0 & 0x40) != 0;

	public int Demo820MapIdx
	{
		get
		{
			if ((_hasBits0 & 0x80) != 0)
			{
				return demo820MapIdx_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 128;
			demo820MapIdx_ = value;
		}
	}

	public bool HasDemo820MapIdx => (_hasBits0 & 0x80) != 0;

	public int DefaultShortcutsPosition
	{
		get
		{
			if ((_hasBits0 & 0x100) != 0)
			{
				return defaultShortcutsPosition_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 256;
			defaultShortcutsPosition_ = value;
		}
	}

	public bool HasDefaultShortcutsPosition => (_hasBits0 & 0x100) != 0;

	public RepeatedField<DictDeltaMsgInt_Int> UnitBookStateDicRemoved => unitBookStateDicRemoved_;

	public RepeatedField<ListDeltaMsgInt> SurprisePerformedList => surprisePerformedList_;

	public RepeatedField<DictDeltaMsgInt_GSUnitBookData> UnitBookDataDic => unitBookDataDic_;

	public BPC_PlayerRoleData()
	{
	}

	public BPC_PlayerRoleData(BPC_PlayerRoleData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		beginAreaStayTime_ = other.beginAreaStayTime_;
		lastRebirthPointTime_ = other.lastRebirthPointTime_;
		mapAreaId_ = other.mapAreaId_;
		maxMapAreaId_ = other.maxMapAreaId_;
		maxMapId_ = other.maxMapId_;
		mapId_ = other.mapId_;
		archiveIdRemoved_ = other.archiveIdRemoved_;
		demo820MapIdx_ = other.demo820MapIdx_;
		defaultShortcutsPosition_ = other.defaultShortcutsPosition_;
		unitBookStateDicRemoved_ = other.unitBookStateDicRemoved_.Clone();
		surprisePerformedList_ = other.surprisePerformedList_.Clone();
		unitBookDataDic_ = other.unitBookDataDic_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BPC_PlayerRoleData Clone()
	{
		return new BPC_PlayerRoleData(this);
	}

	public void ClearBeginAreaStayTime()
	{
		_hasBits0 &= -2;
	}

	public void ClearLastRebirthPointTime()
	{
		_hasBits0 &= -3;
	}

	public void ClearMapAreaId()
	{
		_hasBits0 &= -5;
	}

	public void ClearMaxMapAreaId()
	{
		_hasBits0 &= -9;
	}

	public void ClearMaxMapId()
	{
		_hasBits0 &= -17;
	}

	public void ClearMapId()
	{
		_hasBits0 &= -33;
	}

	public void ClearArchiveIdRemoved()
	{
		_hasBits0 &= -65;
	}

	public void ClearDemo820MapIdx()
	{
		_hasBits0 &= -129;
	}

	public void ClearDefaultShortcutsPosition()
	{
		_hasBits0 &= -257;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BPC_PlayerRoleData);
	}

	public bool Equals(BPC_PlayerRoleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BeginAreaStayTime != other.BeginAreaStayTime)
		{
			return false;
		}
		if (LastRebirthPointTime != other.LastRebirthPointTime)
		{
			return false;
		}
		if (MapAreaId != other.MapAreaId)
		{
			return false;
		}
		if (MaxMapAreaId != other.MaxMapAreaId)
		{
			return false;
		}
		if (MaxMapId != other.MaxMapId)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (ArchiveIdRemoved != other.ArchiveIdRemoved)
		{
			return false;
		}
		if (Demo820MapIdx != other.Demo820MapIdx)
		{
			return false;
		}
		if (DefaultShortcutsPosition != other.DefaultShortcutsPosition)
		{
			return false;
		}
		if (!unitBookStateDicRemoved_.Equals(other.unitBookStateDicRemoved_))
		{
			return false;
		}
		if (!surprisePerformedList_.Equals(other.surprisePerformedList_))
		{
			return false;
		}
		if (!unitBookDataDic_.Equals(other.unitBookDataDic_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasBeginAreaStayTime)
		{
			num ^= BeginAreaStayTime.GetHashCode();
		}
		if (HasLastRebirthPointTime)
		{
			num ^= LastRebirthPointTime.GetHashCode();
		}
		if (HasMapAreaId)
		{
			num ^= MapAreaId.GetHashCode();
		}
		if (HasMaxMapAreaId)
		{
			num ^= MaxMapAreaId.GetHashCode();
		}
		if (HasMaxMapId)
		{
			num ^= MaxMapId.GetHashCode();
		}
		if (HasMapId)
		{
			num ^= MapId.GetHashCode();
		}
		if (HasArchiveIdRemoved)
		{
			num ^= ArchiveIdRemoved.GetHashCode();
		}
		if (HasDemo820MapIdx)
		{
			num ^= Demo820MapIdx.GetHashCode();
		}
		if (HasDefaultShortcutsPosition)
		{
			num ^= DefaultShortcutsPosition.GetHashCode();
		}
		num ^= unitBookStateDicRemoved_.GetHashCode();
		num ^= surprisePerformedList_.GetHashCode();
		num ^= unitBookDataDic_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasBeginAreaStayTime)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BeginAreaStayTime);
		}
		if (HasLastRebirthPointTime)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LastRebirthPointTime);
		}
		if (HasMapAreaId)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MapAreaId);
		}
		if (HasMaxMapAreaId)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MaxMapAreaId);
		}
		if (HasMaxMapId)
		{
			output.WriteRawTag(40);
			output.WriteInt32(MaxMapId);
		}
		if (HasMapId)
		{
			output.WriteRawTag(48);
			output.WriteInt32(MapId);
		}
		if (HasArchiveIdRemoved)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ArchiveIdRemoved);
		}
		if (HasDemo820MapIdx)
		{
			output.WriteRawTag(64);
			output.WriteInt32(Demo820MapIdx);
		}
		if (HasDefaultShortcutsPosition)
		{
			output.WriteRawTag(72);
			output.WriteInt32(DefaultShortcutsPosition);
		}
		unitBookStateDicRemoved_.WriteTo(output, _repeated_unitBookStateDicRemoved_codec);
		surprisePerformedList_.WriteTo(output, _repeated_surprisePerformedList_codec);
		unitBookDataDic_.WriteTo(output, _repeated_unitBookDataDic_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasBeginAreaStayTime)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BeginAreaStayTime);
		}
		if (HasLastRebirthPointTime)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastRebirthPointTime);
		}
		if (HasMapAreaId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapAreaId);
		}
		if (HasMaxMapAreaId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxMapAreaId);
		}
		if (HasMaxMapId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxMapId);
		}
		if (HasMapId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (HasArchiveIdRemoved)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ArchiveIdRemoved);
		}
		if (HasDemo820MapIdx)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Demo820MapIdx);
		}
		if (HasDefaultShortcutsPosition)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultShortcutsPosition);
		}
		num += unitBookStateDicRemoved_.CalculateSize(_repeated_unitBookStateDicRemoved_codec);
		num += surprisePerformedList_.CalculateSize(_repeated_surprisePerformedList_codec);
		num += unitBookDataDic_.CalculateSize(_repeated_unitBookDataDic_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BPC_PlayerRoleData other)
	{
		if (other != null)
		{
			if (other.HasBeginAreaStayTime)
			{
				BeginAreaStayTime = other.BeginAreaStayTime;
			}
			if (other.HasLastRebirthPointTime)
			{
				LastRebirthPointTime = other.LastRebirthPointTime;
			}
			if (other.HasMapAreaId)
			{
				MapAreaId = other.MapAreaId;
			}
			if (other.HasMaxMapAreaId)
			{
				MaxMapAreaId = other.MaxMapAreaId;
			}
			if (other.HasMaxMapId)
			{
				MaxMapId = other.MaxMapId;
			}
			if (other.HasMapId)
			{
				MapId = other.MapId;
			}
			if (other.HasArchiveIdRemoved)
			{
				ArchiveIdRemoved = other.ArchiveIdRemoved;
			}
			if (other.HasDemo820MapIdx)
			{
				Demo820MapIdx = other.Demo820MapIdx;
			}
			if (other.HasDefaultShortcutsPosition)
			{
				DefaultShortcutsPosition = other.DefaultShortcutsPosition;
			}
			unitBookStateDicRemoved_.Add(other.unitBookStateDicRemoved_);
			surprisePerformedList_.Add(other.surprisePerformedList_);
			unitBookDataDic_.Add(other.unitBookDataDic_);
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
				BeginAreaStayTime = input.ReadInt32();
				break;
			case 16u:
				LastRebirthPointTime = input.ReadInt32();
				break;
			case 24u:
				MapAreaId = input.ReadInt32();
				break;
			case 32u:
				MaxMapAreaId = input.ReadInt32();
				break;
			case 40u:
				MaxMapId = input.ReadInt32();
				break;
			case 48u:
				MapId = input.ReadInt32();
				break;
			case 56u:
				ArchiveIdRemoved = input.ReadInt32();
				break;
			case 64u:
				Demo820MapIdx = input.ReadInt32();
				break;
			case 72u:
				DefaultShortcutsPosition = input.ReadInt32();
				break;
			case 82u:
				unitBookStateDicRemoved_.AddEntriesFrom(input, _repeated_unitBookStateDicRemoved_codec);
				break;
			case 90u:
				surprisePerformedList_.AddEntriesFrom(input, _repeated_surprisePerformedList_codec);
				break;
			case 98u:
				unitBookDataDic_.AddEntriesFrom(input, _repeated_unitBookDataDic_codec);
				break;
			}
		}
	}
}
