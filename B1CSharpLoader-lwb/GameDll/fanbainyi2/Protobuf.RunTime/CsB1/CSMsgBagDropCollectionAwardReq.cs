using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgBagDropCollectionAwardReq : IMessage<CSMsgBagDropCollectionAwardReq>, IMessage, IEquatable<CSMsgBagDropCollectionAwardReq>, IDeepCloneable<CSMsgBagDropCollectionAwardReq>
{
	private static readonly MessageParser<CSMsgBagDropCollectionAwardReq> _parser = new MessageParser<CSMsgBagDropCollectionAwardReq>(() => new CSMsgBagDropCollectionAwardReq());

	private UnknownFieldSet _unknownFields;

	private int collectionId_;

	private int dropLevel_;

	public static MessageParser<CSMsgBagDropCollectionAwardReq> Parser => _parser;

	public int CollectionId
	{
		get
		{
			return collectionId_;
		}
		set
		{
			collectionId_ = value;
		}
	}

	public int DropLevel
	{
		get
		{
			return dropLevel_;
		}
		set
		{
			dropLevel_ = value;
		}
	}

	public CSMsgBagDropCollectionAwardReq()
	{
	}

	public CSMsgBagDropCollectionAwardReq(CSMsgBagDropCollectionAwardReq other)
		: this()
	{
		collectionId_ = other.collectionId_;
		dropLevel_ = other.dropLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagDropCollectionAwardReq Clone()
	{
		return new CSMsgBagDropCollectionAwardReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagDropCollectionAwardReq);
	}

	public bool Equals(CSMsgBagDropCollectionAwardReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CollectionId != other.CollectionId)
		{
			return false;
		}
		if (DropLevel != other.DropLevel)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CollectionId != 0)
		{
			num ^= CollectionId.GetHashCode();
		}
		if (DropLevel != 0)
		{
			num ^= DropLevel.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CollectionId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CollectionId);
		}
		if (DropLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DropLevel);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CollectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CollectionId);
		}
		if (DropLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagDropCollectionAwardReq other)
	{
		if (other != null)
		{
			if (other.CollectionId != 0)
			{
				CollectionId = other.CollectionId;
			}
			if (other.DropLevel != 0)
			{
				DropLevel = other.DropLevel;
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
				CollectionId = input.ReadInt32();
				break;
			case 16u:
				DropLevel = input.ReadInt32();
				break;
			}
		}
	}
}
