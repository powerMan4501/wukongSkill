using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStThinkElem : IMessage<FUStThinkElem>, IMessage, IEquatable<FUStThinkElem>, IDeepCloneable<FUStThinkElem>
{
	private static readonly MessageParser<FUStThinkElem> _parser = new MessageParser<FUStThinkElem>(() => new FUStThinkElem());

	private UnknownFieldSet _unknownFields;

	private EAIElemType elemType_;

	private int elemID_;

	public static MessageParser<FUStThinkElem> Parser => _parser;

	public EAIElemType ElemType
	{
		get
		{
			return elemType_;
		}
		set
		{
			elemType_ = value;
		}
	}

	public int ElemID
	{
		get
		{
			return elemID_;
		}
		set
		{
			elemID_ = value;
		}
	}

	public FUStThinkElem()
	{
	}

	public FUStThinkElem(FUStThinkElem other)
		: this()
	{
		elemType_ = other.elemType_;
		elemID_ = other.elemID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStThinkElem Clone()
	{
		return new FUStThinkElem(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStThinkElem);
	}

	public bool Equals(FUStThinkElem other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ElemType != other.ElemType)
		{
			return false;
		}
		if (ElemID != other.ElemID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ElemType != EAIElemType.Think)
		{
			num ^= ElemType.GetHashCode();
		}
		if (ElemID != 0)
		{
			num ^= ElemID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ElemType != EAIElemType.Think)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ElemType);
		}
		if (ElemID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ElemID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ElemType != EAIElemType.Think)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ElemType);
		}
		if (ElemID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ElemID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStThinkElem other)
	{
		if (other != null)
		{
			if (other.ElemType != EAIElemType.Think)
			{
				ElemType = other.ElemType;
			}
			if (other.ElemID != 0)
			{
				ElemID = other.ElemID;
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
				ElemType = (EAIElemType)input.ReadEnum();
				break;
			case 16u:
				ElemID = input.ReadInt32();
				break;
			}
		}
	}
}
