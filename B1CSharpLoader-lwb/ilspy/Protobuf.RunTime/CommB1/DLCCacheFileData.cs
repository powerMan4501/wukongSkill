using System;
using Google.Protobuf;

namespace CommB1;

public sealed class DLCCacheFileData : IMessage<DLCCacheFileData>, IMessage, IEquatable<DLCCacheFileData>, IDeepCloneable<DLCCacheFileData>
{
	private static readonly MessageParser<DLCCacheFileData> _parser = new MessageParser<DLCCacheFileData>(() => new DLCCacheFileData());

	private UnknownFieldSet _unknownFields;

	private ByteString cacheData_ = ByteString.Empty;

	private string cacheDataMd5Digest_ = "";

	public static MessageParser<DLCCacheFileData> Parser => _parser;

	public ByteString CacheData
	{
		get
		{
			return cacheData_;
		}
		set
		{
			cacheData_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string CacheDataMd5Digest
	{
		get
		{
			return cacheDataMd5Digest_;
		}
		set
		{
			cacheDataMd5Digest_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public DLCCacheFileData()
	{
	}

	public DLCCacheFileData(DLCCacheFileData other)
		: this()
	{
		cacheData_ = other.cacheData_;
		cacheDataMd5Digest_ = other.cacheDataMd5Digest_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DLCCacheFileData Clone()
	{
		return new DLCCacheFileData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DLCCacheFileData);
	}

	public bool Equals(DLCCacheFileData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CacheData != other.CacheData)
		{
			return false;
		}
		if (CacheDataMd5Digest != other.CacheDataMd5Digest)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CacheData.Length != 0)
		{
			num ^= CacheData.GetHashCode();
		}
		if (CacheDataMd5Digest.Length != 0)
		{
			num ^= CacheDataMd5Digest.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CacheData.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(CacheData);
		}
		if (CacheDataMd5Digest.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(CacheDataMd5Digest);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CacheData.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(CacheData);
		}
		if (CacheDataMd5Digest.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CacheDataMd5Digest);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DLCCacheFileData other)
	{
		if (other != null)
		{
			if (other.CacheData.Length != 0)
			{
				CacheData = other.CacheData;
			}
			if (other.CacheDataMd5Digest.Length != 0)
			{
				CacheDataMd5Digest = other.CacheDataMd5Digest;
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
			case 10u:
				CacheData = input.ReadBytes();
				break;
			case 18u:
				CacheDataMd5Digest = input.ReadString();
				break;
			}
		}
	}
}
