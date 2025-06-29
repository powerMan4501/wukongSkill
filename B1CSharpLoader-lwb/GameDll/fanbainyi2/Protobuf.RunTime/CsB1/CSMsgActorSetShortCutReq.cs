using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgActorSetShortCutReq : IMessage<CSMsgActorSetShortCutReq>, IMessage, IEquatable<CSMsgActorSetShortCutReq>, IDeepCloneable<CSMsgActorSetShortCutReq>
{
	private static readonly MessageParser<CSMsgActorSetShortCutReq> _parser = new MessageParser<CSMsgActorSetShortCutReq>(() => new CSMsgActorSetShortCutReq());

	private UnknownFieldSet _unknownFields;

	private int position_;

	private int itemId_;

	public static MessageParser<CSMsgActorSetShortCutReq> Parser => _parser;

	public int Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public int ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	public CSMsgActorSetShortCutReq()
	{
	}

	public CSMsgActorSetShortCutReq(CSMsgActorSetShortCutReq other)
		: this()
	{
		position_ = other.position_;
		itemId_ = other.itemId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorSetShortCutReq Clone()
	{
		return new CSMsgActorSetShortCutReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorSetShortCutReq);
	}

	public bool Equals(CSMsgActorSetShortCutReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Position != other.Position)
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Position != 0)
		{
			num ^= Position.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Position != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Position);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ItemId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Position != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Position);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ItemId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorSetShortCutReq other)
	{
		if (other != null)
		{
			if (other.Position != 0)
			{
				Position = other.Position;
			}
			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
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
				Position = input.ReadInt32();
				break;
			case 16u:
				ItemId = input.ReadInt32();
				break;
			}
		}
	}
}
