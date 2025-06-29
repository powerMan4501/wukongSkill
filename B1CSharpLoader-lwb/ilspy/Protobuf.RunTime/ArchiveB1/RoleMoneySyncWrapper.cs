using System;
using Google.Protobuf;
using ResB1;

namespace ArchiveB1;

public sealed class RoleMoneySyncWrapper : IMessage<RoleMoneySyncWrapper>, IMessage, IEquatable<RoleMoneySyncWrapper>, IDeepCloneable<RoleMoneySyncWrapper>
{
	private static readonly MessageParser<RoleMoneySyncWrapper> _parser = new MessageParser<RoleMoneySyncWrapper>(() => new RoleMoneySyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private MoneyTypeSyncWrapper moneyType_;

	private Int64SyncWrapper moneyValue_;

	public static MessageParser<RoleMoneySyncWrapper> Parser => _parser;

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

	public MoneyTypeSyncWrapper MoneyType
	{
		get
		{
			return moneyType_;
		}
		set
		{
			moneyType_ = value;
		}
	}

	public Int64SyncWrapper MoneyValue
	{
		get
		{
			return moneyValue_;
		}
		set
		{
			moneyValue_ = value;
		}
	}

	public RoleMoneySyncWrapper()
	{
	}

	public RoleMoneySyncWrapper(RoleMoneySyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		moneyType_ = ((other.moneyType_ != null) ? other.moneyType_.Clone() : null);
		moneyValue_ = ((other.moneyValue_ != null) ? other.moneyValue_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleMoneySyncWrapper Clone()
	{
		return new RoleMoneySyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleMoneySyncWrapper);
	}

	public bool Equals(RoleMoneySyncWrapper other)
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
		if (!object.Equals(MoneyType, other.MoneyType))
		{
			return false;
		}
		if (!object.Equals(MoneyValue, other.MoneyValue))
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
		if (moneyType_ != null)
		{
			num ^= MoneyType.GetHashCode();
		}
		if (moneyValue_ != null)
		{
			num ^= MoneyValue.GetHashCode();
		}
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
		if (moneyType_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MoneyType);
		}
		if (moneyValue_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MoneyValue);
		}
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
		if (moneyType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MoneyType);
		}
		if (moneyValue_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MoneyValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleMoneySyncWrapper other)
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
		if (other.moneyType_ != null)
		{
			if (moneyType_ == null)
			{
				MoneyType = new MoneyTypeSyncWrapper();
			}
			MoneyType.MergeFrom(other.MoneyType);
		}
		if (other.moneyValue_ != null)
		{
			if (moneyValue_ == null)
			{
				MoneyValue = new Int64SyncWrapper();
			}
			MoneyValue.MergeFrom(other.MoneyValue);
		}
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
				if (moneyType_ == null)
				{
					MoneyType = new MoneyTypeSyncWrapper();
				}
				input.ReadMessage(MoneyType);
				break;
			case 34u:
				if (moneyValue_ == null)
				{
					MoneyValue = new Int64SyncWrapper();
				}
				input.ReadMessage(MoneyValue);
				break;
			}
		}
	}
}
