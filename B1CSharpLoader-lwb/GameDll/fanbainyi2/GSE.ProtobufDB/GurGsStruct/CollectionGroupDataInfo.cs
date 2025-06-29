using System;
using Google.Protobuf;

namespace GurGsStruct;

public sealed class CollectionGroupDataInfo : IMessage<CollectionGroupDataInfo>, IMessage, IEquatable<CollectionGroupDataInfo>, IDeepCloneable<CollectionGroupDataInfo>
{
	private static readonly MessageParser<CollectionGroupDataInfo> _parser = new MessageParser<CollectionGroupDataInfo>(() => new CollectionGroupDataInfo());

	private UnknownFieldSet _unknownFields;

	public static MessageParser<CollectionGroupDataInfo> Parser => _parser;

	public CollectionGroupDataInfo()
	{
	}

	public CollectionGroupDataInfo(CollectionGroupDataInfo other)
		: this()
	{
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CollectionGroupDataInfo Clone()
	{
		return new CollectionGroupDataInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CollectionGroupDataInfo);
	}

	public bool Equals(CollectionGroupDataInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CollectionGroupDataInfo other)
	{
		if (other != null)
		{
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		while (input.ReadTag() != 0)
		{
			_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
		}
	}
}
