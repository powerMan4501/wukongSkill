using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgCollectionCollectItemReq : IMessage<CSMsgCollectionCollectItemReq>, IMessage, IEquatable<CSMsgCollectionCollectItemReq>, IDeepCloneable<CSMsgCollectionCollectItemReq>
{
	private static readonly MessageParser<CSMsgCollectionCollectItemReq> _parser = new MessageParser<CSMsgCollectionCollectItemReq>(() => new CSMsgCollectionCollectItemReq());

	private UnknownFieldSet _unknownFields;

	private ResourceType resourceType_;

	private int id_;

	public static MessageParser<CSMsgCollectionCollectItemReq> Parser => _parser;

	public ResourceType ResourceType
	{
		get
		{
			return resourceType_;
		}
		set
		{
			resourceType_ = value;
		}
	}

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public CSMsgCollectionCollectItemReq()
	{
	}

	public CSMsgCollectionCollectItemReq(CSMsgCollectionCollectItemReq other)
		: this()
	{
		resourceType_ = other.resourceType_;
		id_ = other.id_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgCollectionCollectItemReq Clone()
	{
		return new CSMsgCollectionCollectItemReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgCollectionCollectItemReq);
	}

	public bool Equals(CSMsgCollectionCollectItemReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResourceType != other.ResourceType)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ResourceType != ResourceType.Seq)
		{
			num ^= ResourceType.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ResourceType != ResourceType.Seq)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ResourceType);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ResourceType != ResourceType.Seq)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResourceType);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgCollectionCollectItemReq other)
	{
		if (other != null)
		{
			if (other.ResourceType != ResourceType.Seq)
			{
				ResourceType = other.ResourceType;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
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
				ResourceType = (ResourceType)input.ReadEnum();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			}
		}
	}
}
