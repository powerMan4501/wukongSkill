using System;
using Google.Protobuf;

namespace CommB1;

public sealed class DLCCacheItem : IMessage<DLCCacheItem>, IMessage, IEquatable<DLCCacheItem>, IDeepCloneable<DLCCacheItem>
{
	private static readonly MessageParser<DLCCacheItem> _parser = new MessageParser<DLCCacheItem>(() => new DLCCacheItem());

	private UnknownFieldSet _unknownFields;

	private int addOnType_;

	private ulong cacheExpireTime_;

	public static MessageParser<DLCCacheItem> Parser => _parser;

	public int AddOnType
	{
		get
		{
			return addOnType_;
		}
		set
		{
			addOnType_ = value;
		}
	}

	public ulong CacheExpireTime
	{
		get
		{
			return cacheExpireTime_;
		}
		set
		{
			cacheExpireTime_ = value;
		}
	}

	public DLCCacheItem()
	{
	}

	public DLCCacheItem(DLCCacheItem other)
		: this()
	{
		addOnType_ = other.addOnType_;
		cacheExpireTime_ = other.cacheExpireTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DLCCacheItem Clone()
	{
		return new DLCCacheItem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DLCCacheItem);
	}

	public bool Equals(DLCCacheItem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AddOnType != other.AddOnType)
		{
			return false;
		}
		if (CacheExpireTime != other.CacheExpireTime)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (AddOnType != 0)
		{
			num ^= AddOnType.GetHashCode();
		}
		if (CacheExpireTime != 0L)
		{
			num ^= CacheExpireTime.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (AddOnType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(AddOnType);
		}
		if (CacheExpireTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(CacheExpireTime);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (AddOnType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AddOnType);
		}
		if (CacheExpireTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(CacheExpireTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DLCCacheItem other)
	{
		if (other != null)
		{
			if (other.AddOnType != 0)
			{
				AddOnType = other.AddOnType;
			}
			if (other.CacheExpireTime != 0L)
			{
				CacheExpireTime = other.CacheExpireTime;
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
				AddOnType = input.ReadInt32();
				break;
			case 16u:
				CacheExpireTime = input.ReadUInt64();
				break;
			}
		}
	}
}
