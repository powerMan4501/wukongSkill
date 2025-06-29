using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class BUC_CollectionData : IMessage<BUC_CollectionData>, IMessage, IEquatable<BUC_CollectionData>, IDeepCloneable<BUC_CollectionData>
{
	private static readonly MessageParser<BUC_CollectionData> _parser = new MessageParser<BUC_CollectionData>(() => new BUC_CollectionData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private int groupId_;

	private int collectionQuality_;

	private int collectiontType_;

	private bool isRandomed_;

	private bool beCollected_;

	private bool needReBirthMonster_;

	public static MessageParser<BUC_CollectionData> Parser => _parser;

	public int GroupId
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return groupId_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 1;
			groupId_ = value;
		}
	}

	public bool HasGroupId => (_hasBits0 & 1) != 0;

	public int CollectionQuality
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return collectionQuality_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 2;
			collectionQuality_ = value;
		}
	}

	public bool HasCollectionQuality => (_hasBits0 & 2) != 0;

	public int CollectiontType
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return collectiontType_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			collectiontType_ = value;
		}
	}

	public bool HasCollectiontType => (_hasBits0 & 4) != 0;

	public bool IsRandomed
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return isRandomed_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 8;
			isRandomed_ = value;
		}
	}

	public bool HasIsRandomed => (_hasBits0 & 8) != 0;

	public bool BeCollected
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return beCollected_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 16;
			beCollected_ = value;
		}
	}

	public bool HasBeCollected => (_hasBits0 & 0x10) != 0;

	public bool NeedReBirthMonster
	{
		get
		{
			if ((_hasBits0 & 0x20) != 0)
			{
				return needReBirthMonster_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 32;
			needReBirthMonster_ = value;
		}
	}

	public bool HasNeedReBirthMonster => (_hasBits0 & 0x20) != 0;

	public BUC_CollectionData()
	{
	}

	public BUC_CollectionData(BUC_CollectionData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		groupId_ = other.groupId_;
		collectionQuality_ = other.collectionQuality_;
		collectiontType_ = other.collectiontType_;
		isRandomed_ = other.isRandomed_;
		beCollected_ = other.beCollected_;
		needReBirthMonster_ = other.needReBirthMonster_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_CollectionData Clone()
	{
		return new BUC_CollectionData(this);
	}

	public void ClearGroupId()
	{
		_hasBits0 &= -2;
	}

	public void ClearCollectionQuality()
	{
		_hasBits0 &= -3;
	}

	public void ClearCollectiontType()
	{
		_hasBits0 &= -5;
	}

	public void ClearIsRandomed()
	{
		_hasBits0 &= -9;
	}

	public void ClearBeCollected()
	{
		_hasBits0 &= -17;
	}

	public void ClearNeedReBirthMonster()
	{
		_hasBits0 &= -33;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_CollectionData);
	}

	public bool Equals(BUC_CollectionData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (CollectionQuality != other.CollectionQuality)
		{
			return false;
		}
		if (CollectiontType != other.CollectiontType)
		{
			return false;
		}
		if (IsRandomed != other.IsRandomed)
		{
			return false;
		}
		if (BeCollected != other.BeCollected)
		{
			return false;
		}
		if (NeedReBirthMonster != other.NeedReBirthMonster)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasGroupId)
		{
			num ^= GroupId.GetHashCode();
		}
		if (HasCollectionQuality)
		{
			num ^= CollectionQuality.GetHashCode();
		}
		if (HasCollectiontType)
		{
			num ^= CollectiontType.GetHashCode();
		}
		if (HasIsRandomed)
		{
			num ^= IsRandomed.GetHashCode();
		}
		if (HasBeCollected)
		{
			num ^= BeCollected.GetHashCode();
		}
		if (HasNeedReBirthMonster)
		{
			num ^= NeedReBirthMonster.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasGroupId)
		{
			output.WriteRawTag(8);
			output.WriteInt32(GroupId);
		}
		if (HasCollectionQuality)
		{
			output.WriteRawTag(16);
			output.WriteInt32(CollectionQuality);
		}
		if (HasCollectiontType)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CollectiontType);
		}
		if (HasIsRandomed)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsRandomed);
		}
		if (HasBeCollected)
		{
			output.WriteRawTag(40);
			output.WriteBool(BeCollected);
		}
		if (HasNeedReBirthMonster)
		{
			output.WriteRawTag(48);
			output.WriteBool(NeedReBirthMonster);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasGroupId)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (HasCollectionQuality)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionQuality);
		}
		if (HasCollectiontType)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectiontType);
		}
		if (HasIsRandomed)
		{
			num += 2;
		}
		if (HasBeCollected)
		{
			num += 2;
		}
		if (HasNeedReBirthMonster)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_CollectionData other)
	{
		if (other != null)
		{
			if (other.HasGroupId)
			{
				GroupId = other.GroupId;
			}
			if (other.HasCollectionQuality)
			{
				CollectionQuality = other.CollectionQuality;
			}
			if (other.HasCollectiontType)
			{
				CollectiontType = other.CollectiontType;
			}
			if (other.HasIsRandomed)
			{
				IsRandomed = other.IsRandomed;
			}
			if (other.HasBeCollected)
			{
				BeCollected = other.BeCollected;
			}
			if (other.HasNeedReBirthMonster)
			{
				NeedReBirthMonster = other.NeedReBirthMonster;
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
				GroupId = input.ReadInt32();
				break;
			case 16u:
				CollectionQuality = input.ReadInt32();
				break;
			case 24u:
				CollectiontType = input.ReadInt32();
				break;
			case 32u:
				IsRandomed = input.ReadBool();
				break;
			case 40u:
				BeCollected = input.ReadBool();
				break;
			case 48u:
				NeedReBirthMonster = input.ReadBool();
				break;
			}
		}
	}
}
