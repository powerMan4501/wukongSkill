using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BUC_GamePlusSpawnData : IMessage<BUC_GamePlusSpawnData>, IMessage, IEquatable<BUC_GamePlusSpawnData>, IDeepCloneable<BUC_GamePlusSpawnData>
{
	private static readonly MessageParser<BUC_GamePlusSpawnData> _parser = new MessageParser<BUC_GamePlusSpawnData>(() => new BUC_GamePlusSpawnData());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool destoryForever_;

	private double lastCollectTime_;

	private int curCD_;

	private int lastCollectGamePlayCount_;

	private int collectionCount_;

	public static MessageParser<BUC_GamePlusSpawnData> Parser => _parser;

	public bool DestoryForever
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return destoryForever_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			destoryForever_ = value;
		}
	}

	public bool HasDestoryForever => (_hasBits0 & 1) != 0;

	public double LastCollectTime
	{
		get
		{
			if ((_hasBits0 & 2) != 0)
			{
				return lastCollectTime_;
			}
			return 0.0;
		}
		set
		{
			_hasBits0 |= 2;
			lastCollectTime_ = value;
		}
	}

	public bool HasLastCollectTime => (_hasBits0 & 2) != 0;

	public int CurCD
	{
		get
		{
			if ((_hasBits0 & 4) != 0)
			{
				return curCD_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 4;
			curCD_ = value;
		}
	}

	public bool HasCurCD => (_hasBits0 & 4) != 0;

	public int LastCollectGamePlayCount
	{
		get
		{
			if ((_hasBits0 & 8) != 0)
			{
				return lastCollectGamePlayCount_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 8;
			lastCollectGamePlayCount_ = value;
		}
	}

	public bool HasLastCollectGamePlayCount => (_hasBits0 & 8) != 0;

	public int CollectionCount
	{
		get
		{
			if ((_hasBits0 & 0x10) != 0)
			{
				return collectionCount_;
			}
			return 0;
		}
		set
		{
			_hasBits0 |= 16;
			collectionCount_ = value;
		}
	}

	public bool HasCollectionCount => (_hasBits0 & 0x10) != 0;

	public BUC_GamePlusSpawnData()
	{
	}

	public BUC_GamePlusSpawnData(BUC_GamePlusSpawnData other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		destoryForever_ = other.destoryForever_;
		lastCollectTime_ = other.lastCollectTime_;
		curCD_ = other.curCD_;
		lastCollectGamePlayCount_ = other.lastCollectGamePlayCount_;
		collectionCount_ = other.collectionCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BUC_GamePlusSpawnData Clone()
	{
		return new BUC_GamePlusSpawnData(this);
	}

	public void ClearDestoryForever()
	{
		_hasBits0 &= -2;
	}

	public void ClearLastCollectTime()
	{
		_hasBits0 &= -3;
	}

	public void ClearCurCD()
	{
		_hasBits0 &= -5;
	}

	public void ClearLastCollectGamePlayCount()
	{
		_hasBits0 &= -9;
	}

	public void ClearCollectionCount()
	{
		_hasBits0 &= -17;
	}

	public override bool Equals(object other)
	{
		return Equals(other as BUC_GamePlusSpawnData);
	}

	public bool Equals(BUC_GamePlusSpawnData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DestoryForever != other.DestoryForever)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LastCollectTime, other.LastCollectTime))
		{
			return false;
		}
		if (CurCD != other.CurCD)
		{
			return false;
		}
		if (LastCollectGamePlayCount != other.LastCollectGamePlayCount)
		{
			return false;
		}
		if (CollectionCount != other.CollectionCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasDestoryForever)
		{
			num ^= DestoryForever.GetHashCode();
		}
		if (HasLastCollectTime)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LastCollectTime);
		}
		if (HasCurCD)
		{
			num ^= CurCD.GetHashCode();
		}
		if (HasLastCollectGamePlayCount)
		{
			num ^= LastCollectGamePlayCount.GetHashCode();
		}
		if (HasCollectionCount)
		{
			num ^= CollectionCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasDestoryForever)
		{
			output.WriteRawTag(8);
			output.WriteBool(DestoryForever);
		}
		if (HasLastCollectTime)
		{
			output.WriteRawTag(17);
			output.WriteDouble(LastCollectTime);
		}
		if (HasCurCD)
		{
			output.WriteRawTag(24);
			output.WriteInt32(CurCD);
		}
		if (HasLastCollectGamePlayCount)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LastCollectGamePlayCount);
		}
		if (HasCollectionCount)
		{
			output.WriteRawTag(40);
			output.WriteInt32(CollectionCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasDestoryForever)
		{
			num += 2;
		}
		if (HasLastCollectTime)
		{
			num += 9;
		}
		if (HasCurCD)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurCD);
		}
		if (HasLastCollectGamePlayCount)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LastCollectGamePlayCount);
		}
		if (HasCollectionCount)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BUC_GamePlusSpawnData other)
	{
		if (other != null)
		{
			if (other.HasDestoryForever)
			{
				DestoryForever = other.DestoryForever;
			}
			if (other.HasLastCollectTime)
			{
				LastCollectTime = other.LastCollectTime;
			}
			if (other.HasCurCD)
			{
				CurCD = other.CurCD;
			}
			if (other.HasLastCollectGamePlayCount)
			{
				LastCollectGamePlayCount = other.LastCollectGamePlayCount;
			}
			if (other.HasCollectionCount)
			{
				CollectionCount = other.CollectionCount;
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
				DestoryForever = input.ReadBool();
				break;
			case 17u:
				LastCollectTime = input.ReadDouble();
				break;
			case 24u:
				CurCD = input.ReadInt32();
				break;
			case 32u:
				LastCollectGamePlayCount = input.ReadInt32();
				break;
			case 40u:
				CollectionCount = input.ReadInt32();
				break;
			}
		}
	}
}
