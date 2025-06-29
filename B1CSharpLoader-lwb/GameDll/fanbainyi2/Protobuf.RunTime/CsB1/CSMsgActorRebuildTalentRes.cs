using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class CSMsgActorRebuildTalentRes : IMessage<CSMsgActorRebuildTalentRes>, IMessage, IEquatable<CSMsgActorRebuildTalentRes>, IDeepCloneable<CSMsgActorRebuildTalentRes>
{
	private static readonly MessageParser<CSMsgActorRebuildTalentRes> _parser = new MessageParser<CSMsgActorRebuildTalentRes>(() => new CSMsgActorRebuildTalentRes());

	private UnknownFieldSet _unknownFields;

	private int returnTalentPoint_;

	private static readonly FieldCodec<ItemOne> _repeated_returnItemList_codec = FieldCodec.ForMessage(18u, ItemOne.Parser);

	private readonly RepeatedField<ItemOne> returnItemList_ = new RepeatedField<ItemOne>();

	public static MessageParser<CSMsgActorRebuildTalentRes> Parser => _parser;

	public int ReturnTalentPoint
	{
		get
		{
			return returnTalentPoint_;
		}
		set
		{
			returnTalentPoint_ = value;
		}
	}

	public RepeatedField<ItemOne> ReturnItemList => returnItemList_;

	public CSMsgActorRebuildTalentRes()
	{
	}

	public CSMsgActorRebuildTalentRes(CSMsgActorRebuildTalentRes other)
		: this()
	{
		returnTalentPoint_ = other.returnTalentPoint_;
		returnItemList_ = other.returnItemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgActorRebuildTalentRes Clone()
	{
		return new CSMsgActorRebuildTalentRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgActorRebuildTalentRes);
	}

	public bool Equals(CSMsgActorRebuildTalentRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ReturnTalentPoint != other.ReturnTalentPoint)
		{
			return false;
		}
		if (!returnItemList_.Equals(other.returnItemList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ReturnTalentPoint != 0)
		{
			num ^= ReturnTalentPoint.GetHashCode();
		}
		num ^= returnItemList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ReturnTalentPoint != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ReturnTalentPoint);
		}
		returnItemList_.WriteTo(output, _repeated_returnItemList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ReturnTalentPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ReturnTalentPoint);
		}
		num += returnItemList_.CalculateSize(_repeated_returnItemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgActorRebuildTalentRes other)
	{
		if (other != null)
		{
			if (other.ReturnTalentPoint != 0)
			{
				ReturnTalentPoint = other.ReturnTalentPoint;
			}
			returnItemList_.Add(other.returnItemList_);
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
				ReturnTalentPoint = input.ReadInt32();
				break;
			case 18u:
				returnItemList_.AddEntriesFrom(input, _repeated_returnItemList_codec);
				break;
			}
		}
	}
}
