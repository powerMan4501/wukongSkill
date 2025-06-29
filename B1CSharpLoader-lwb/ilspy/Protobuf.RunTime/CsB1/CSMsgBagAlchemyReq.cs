using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgBagAlchemyReq : IMessage<CSMsgBagAlchemyReq>, IMessage, IEquatable<CSMsgBagAlchemyReq>, IDeepCloneable<CSMsgBagAlchemyReq>
{
	private static readonly MessageParser<CSMsgBagAlchemyReq> _parser = new MessageParser<CSMsgBagAlchemyReq>(() => new CSMsgBagAlchemyReq());

	private UnknownFieldSet _unknownFields;

	private int batchRecipeId_;

	private int batchNum_;

	private static readonly FieldCodec<ItemOne> _repeated_itemList_codec = FieldCodec.ForMessage(26u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> itemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<CSMsgBagAlchemyReq> Parser => _parser;

	public int BatchRecipeId
	{
		get
		{
			return batchRecipeId_;
		}
		set
		{
			batchRecipeId_ = value;
		}
	}

	public int BatchNum
	{
		get
		{
			return batchNum_;
		}
		set
		{
			batchNum_ = value;
		}
	}

	public RepeatedField<ItemOne> ItemList => itemList_;

	public CSMsgBagAlchemyReq()
	{
	}

	public CSMsgBagAlchemyReq(CSMsgBagAlchemyReq other)
		: this()
	{
		batchRecipeId_ = other.batchRecipeId_;
		batchNum_ = other.batchNum_;
		itemList_ = other.itemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgBagAlchemyReq Clone()
	{
		return new CSMsgBagAlchemyReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgBagAlchemyReq);
	}

	public bool Equals(CSMsgBagAlchemyReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BatchRecipeId != other.BatchRecipeId)
		{
			return false;
		}
		if (BatchNum != other.BatchNum)
		{
			return false;
		}
		if (!itemList_.Equals(other.itemList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BatchRecipeId != 0)
		{
			num ^= BatchRecipeId.GetHashCode();
		}
		if (BatchNum != 0)
		{
			num ^= BatchNum.GetHashCode();
		}
		num ^= itemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BatchRecipeId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BatchRecipeId);
		}
		if (BatchNum != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(BatchNum);
		}
		itemList_.WriteTo(output, _repeated_itemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BatchRecipeId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BatchRecipeId);
		}
		if (BatchNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BatchNum);
		}
		num += itemList_.CalculateSize(_repeated_itemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgBagAlchemyReq other)
	{
		if (other != null)
		{
			if (other.BatchRecipeId != 0)
			{
				BatchRecipeId = other.BatchRecipeId;
			}
			if (other.BatchNum != 0)
			{
				BatchNum = other.BatchNum;
			}
			itemList_.Add(other.itemList_);
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
				BatchRecipeId = input.ReadInt32();
				break;
			case 16u:
				BatchNum = input.ReadInt32();
				break;
			case 26u:
				itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
				break;
			}
		}
	}
}
