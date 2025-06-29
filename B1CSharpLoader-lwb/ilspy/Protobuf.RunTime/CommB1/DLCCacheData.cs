using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class DLCCacheData : IMessage<DLCCacheData>, IMessage, IEquatable<DLCCacheData>, IDeepCloneable<DLCCacheData>
{
	private static readonly MessageParser<DLCCacheData> _parser = new MessageParser<DLCCacheData>(() => new DLCCacheData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DLCCacheItem> _repeated_addOnCacheList_codec = FieldCodec.ForMessage(10u, DLCCacheItem.Parser);

	private readonly RepeatedField<DLCCacheItem> addOnCacheList_ = new RepeatedField<DLCCacheItem>();

	public static MessageParser<DLCCacheData> Parser => _parser;

	public RepeatedField<DLCCacheItem> AddOnCacheList => addOnCacheList_;

	public DLCCacheData()
	{
	}

	public DLCCacheData(DLCCacheData other)
		: this()
	{
		addOnCacheList_ = other.addOnCacheList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DLCCacheData Clone()
	{
		return new DLCCacheData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DLCCacheData);
	}

	public bool Equals(DLCCacheData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!addOnCacheList_.Equals(other.addOnCacheList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= addOnCacheList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		addOnCacheList_.WriteTo(output, _repeated_addOnCacheList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += addOnCacheList_.CalculateSize(_repeated_addOnCacheList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DLCCacheData other)
	{
		if (other != null)
		{
			addOnCacheList_.Add(other.addOnCacheList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				addOnCacheList_.AddEntriesFrom(input, _repeated_addOnCacheList_codec);
			}
		}
	}
}
