using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ShopDesc : IMessage<ShopDesc>, IMessage, IEquatable<ShopDesc>, IDeepCloneable<ShopDesc>
{
	private static readonly MessageParser<ShopDesc> _parser = new MessageParser<ShopDesc>(() => new ShopDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string conversationEnter_ = "";

	private string conversationBuy_ = "";

	private string conversationLeave_ = "";

	private string conversationNoConsume_ = "";

	public static MessageParser<ShopDesc> Parser => _parser;

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

	public string ConversationEnter
	{
		get
		{
			return conversationEnter_;
		}
		set
		{
			conversationEnter_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ConversationBuy
	{
		get
		{
			return conversationBuy_;
		}
		set
		{
			conversationBuy_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ConversationLeave
	{
		get
		{
			return conversationLeave_;
		}
		set
		{
			conversationLeave_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ConversationNoConsume
	{
		get
		{
			return conversationNoConsume_;
		}
		set
		{
			conversationNoConsume_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ShopDesc()
	{
	}

	public ShopDesc(ShopDesc other)
		: this()
	{
		id_ = other.id_;
		conversationEnter_ = other.conversationEnter_;
		conversationBuy_ = other.conversationBuy_;
		conversationLeave_ = other.conversationLeave_;
		conversationNoConsume_ = other.conversationNoConsume_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ShopDesc Clone()
	{
		return new ShopDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ShopDesc);
	}

	public bool Equals(ShopDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ConversationEnter != other.ConversationEnter)
		{
			return false;
		}
		if (ConversationBuy != other.ConversationBuy)
		{
			return false;
		}
		if (ConversationLeave != other.ConversationLeave)
		{
			return false;
		}
		if (ConversationNoConsume != other.ConversationNoConsume)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ConversationEnter.Length != 0)
		{
			num ^= ConversationEnter.GetHashCode();
		}
		if (ConversationBuy.Length != 0)
		{
			num ^= ConversationBuy.GetHashCode();
		}
		if (ConversationLeave.Length != 0)
		{
			num ^= ConversationLeave.GetHashCode();
		}
		if (ConversationNoConsume.Length != 0)
		{
			num ^= ConversationNoConsume.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ConversationEnter.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ConversationEnter);
		}
		if (ConversationBuy.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ConversationBuy);
		}
		if (ConversationLeave.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(ConversationLeave);
		}
		if (ConversationNoConsume.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ConversationNoConsume);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ConversationEnter.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConversationEnter);
		}
		if (ConversationBuy.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConversationBuy);
		}
		if (ConversationLeave.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConversationLeave);
		}
		if (ConversationNoConsume.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConversationNoConsume);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ShopDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ConversationEnter.Length != 0)
			{
				ConversationEnter = other.ConversationEnter;
			}
			if (other.ConversationBuy.Length != 0)
			{
				ConversationBuy = other.ConversationBuy;
			}
			if (other.ConversationLeave.Length != 0)
			{
				ConversationLeave = other.ConversationLeave;
			}
			if (other.ConversationNoConsume.Length != 0)
			{
				ConversationNoConsume = other.ConversationNoConsume;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				ConversationEnter = input.ReadString();
				break;
			case 26u:
				ConversationBuy = input.ReadString();
				break;
			case 34u:
				ConversationLeave = input.ReadString();
				break;
			case 42u:
				ConversationNoConsume = input.ReadString();
				break;
			}
		}
	}
}
