using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSuitInfo : IMessage<FUStSuitInfo>, IMessage, IEquatable<FUStSuitInfo>, IDeepCloneable<FUStSuitInfo>
{
	private static readonly MessageParser<FUStSuitInfo> _parser = new MessageParser<FUStSuitInfo>(() => new FUStSuitInfo());

	private UnknownFieldSet _unknownFields;

	private int triggerNum_;

	private int attrEffectID_;

	private int suitEffectID_;

	private string suitEffectDesc_ = "";

	public static MessageParser<FUStSuitInfo> Parser => _parser;

	public int TriggerNum
	{
		get
		{
			return triggerNum_;
		}
		set
		{
			triggerNum_ = value;
		}
	}

	public int AttrEffectID
	{
		get
		{
			return attrEffectID_;
		}
		set
		{
			attrEffectID_ = value;
		}
	}

	public int SuitEffectID
	{
		get
		{
			return suitEffectID_;
		}
		set
		{
			suitEffectID_ = value;
		}
	}

	public string SuitEffectDesc
	{
		get
		{
			return suitEffectDesc_;
		}
		set
		{
			suitEffectDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStSuitInfo()
	{
	}

	public FUStSuitInfo(FUStSuitInfo other)
		: this()
	{
		triggerNum_ = other.triggerNum_;
		attrEffectID_ = other.attrEffectID_;
		suitEffectID_ = other.suitEffectID_;
		suitEffectDesc_ = other.suitEffectDesc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSuitInfo Clone()
	{
		return new FUStSuitInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSuitInfo);
	}

	public bool Equals(FUStSuitInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TriggerNum != other.TriggerNum)
		{
			return false;
		}
		if (AttrEffectID != other.AttrEffectID)
		{
			return false;
		}
		if (SuitEffectID != other.SuitEffectID)
		{
			return false;
		}
		if (SuitEffectDesc != other.SuitEffectDesc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (TriggerNum != 0)
		{
			num ^= TriggerNum.GetHashCode();
		}
		if (AttrEffectID != 0)
		{
			num ^= AttrEffectID.GetHashCode();
		}
		if (SuitEffectID != 0)
		{
			num ^= SuitEffectID.GetHashCode();
		}
		if (SuitEffectDesc.Length != 0)
		{
			num ^= SuitEffectDesc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (TriggerNum != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(TriggerNum);
		}
		if (AttrEffectID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AttrEffectID);
		}
		if (SuitEffectID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SuitEffectID);
		}
		if (SuitEffectDesc.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(SuitEffectDesc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (TriggerNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TriggerNum);
		}
		if (AttrEffectID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AttrEffectID);
		}
		if (SuitEffectID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SuitEffectID);
		}
		if (SuitEffectDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SuitEffectDesc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSuitInfo other)
	{
		if (other != null)
		{
			if (other.TriggerNum != 0)
			{
				TriggerNum = other.TriggerNum;
			}
			if (other.AttrEffectID != 0)
			{
				AttrEffectID = other.AttrEffectID;
			}
			if (other.SuitEffectID != 0)
			{
				SuitEffectID = other.SuitEffectID;
			}
			if (other.SuitEffectDesc.Length != 0)
			{
				SuitEffectDesc = other.SuitEffectDesc;
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
				TriggerNum = input.ReadInt32();
				break;
			case 16u:
				AttrEffectID = input.ReadInt32();
				break;
			case 24u:
				SuitEffectID = input.ReadInt32();
				break;
			case 34u:
				SuitEffectDesc = input.ReadString();
				break;
			}
		}
	}
}
