using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlShare;

public sealed class FUStAIThinkDesc : IMessage<FUStAIThinkDesc>, IMessage, IEquatable<FUStAIThinkDesc>, IDeepCloneable<FUStAIThinkDesc>
{
	private static readonly MessageParser<FUStAIThinkDesc> _parser = new MessageParser<FUStAIThinkDesc>(() => new FUStAIThinkDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EThinkType thinkType_;

	private static readonly FieldCodec<FUStThinkElem> _repeated_thinkElems_codec = FieldCodec.ForMessage(26u, FUStThinkElem.Parser);

	private readonly RepeatedField<FUStThinkElem> thinkElems_ = new RepeatedField<FUStThinkElem>();

	public static MessageParser<FUStAIThinkDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public EThinkType ThinkType
	{
		get
		{
			return thinkType_;
		}
		set
		{
			thinkType_ = value;
		}
	}

	public RepeatedField<FUStThinkElem> ThinkElems => thinkElems_;

	public FUStAIThinkDesc()
	{
	}

	public FUStAIThinkDesc(FUStAIThinkDesc other)
		: this()
	{
		iD_ = other.iD_;
		thinkType_ = other.thinkType_;
		thinkElems_ = other.thinkElems_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStAIThinkDesc Clone()
	{
		return new FUStAIThinkDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStAIThinkDesc);
	}

	public bool Equals(FUStAIThinkDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (ThinkType != other.ThinkType)
		{
			return false;
		}
		if (!thinkElems_.Equals(other.thinkElems_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (ThinkType != EThinkType.CircleThink)
		{
			num ^= ThinkType.GetHashCode();
		}
		num ^= thinkElems_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (ThinkType != EThinkType.CircleThink)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ThinkType);
		}
		thinkElems_.WriteTo(output, _repeated_thinkElems_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (ThinkType != EThinkType.CircleThink)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ThinkType);
		}
		num += thinkElems_.CalculateSize(_repeated_thinkElems_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStAIThinkDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ThinkType != EThinkType.CircleThink)
			{
				ThinkType = other.ThinkType;
			}
			thinkElems_.Add(other.thinkElems_);
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
				ID = input.ReadInt32();
				break;
			case 16u:
				ThinkType = (EThinkType)input.ReadEnum();
				break;
			case 26u:
				thinkElems_.AddEntriesFrom(input, _repeated_thinkElems_codec);
				break;
			}
		}
	}
}
