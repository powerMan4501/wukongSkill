using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsPersistent;

public sealed class BGC_CollectionGroupData : IMessage<BGC_CollectionGroupData>, IMessage, IEquatable<BGC_CollectionGroupData>, IDeepCloneable<BGC_CollectionGroupData>
{
	private static readonly MessageParser<BGC_CollectionGroupData> _parser = new MessageParser<BGC_CollectionGroupData>(() => new BGC_CollectionGroupData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<DictDeltaMsgInt_CollectionGroupDataInfo> _repeated_collectionGroupDataInfo_codec = FieldCodec.ForMessage(10u, DictDeltaMsgInt_CollectionGroupDataInfo.Parser);

	private readonly RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> collectionGroupDataInfo_ = new RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo>();

	public static MessageParser<BGC_CollectionGroupData> Parser => _parser;

	public RepeatedField<DictDeltaMsgInt_CollectionGroupDataInfo> CollectionGroupDataInfo => collectionGroupDataInfo_;

	public BGC_CollectionGroupData()
	{
	}

	public BGC_CollectionGroupData(BGC_CollectionGroupData other)
		: this()
	{
		collectionGroupDataInfo_ = other.collectionGroupDataInfo_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BGC_CollectionGroupData Clone()
	{
		return new BGC_CollectionGroupData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BGC_CollectionGroupData);
	}

	public bool Equals(BGC_CollectionGroupData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!collectionGroupDataInfo_.Equals(other.collectionGroupDataInfo_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= collectionGroupDataInfo_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		collectionGroupDataInfo_.WriteTo(output, _repeated_collectionGroupDataInfo_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += collectionGroupDataInfo_.CalculateSize(_repeated_collectionGroupDataInfo_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BGC_CollectionGroupData other)
	{
		if (other != null)
		{
			collectionGroupDataInfo_.Add(other.collectionGroupDataInfo_);
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
				collectionGroupDataInfo_.AddEntriesFrom(input, _repeated_collectionGroupDataInfo_codec);
			}
		}
	}
}
