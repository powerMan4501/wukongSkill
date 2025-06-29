using System;
using Google.Protobuf;

namespace BtlX2;

public sealed class FUStB2DSBMapCond : IMessage<FUStB2DSBMapCond>, IMessage, IEquatable<FUStB2DSBMapCond>, IDeepCloneable<FUStB2DSBMapCond>
{
	private static readonly MessageParser<FUStB2DSBMapCond> _parser = new MessageParser<FUStB2DSBMapCond>(() => new FUStB2DSBMapCond());

	private UnknownFieldSet _unknownFields;

	private EB2DSBMapCond cond_;

	private int targetId_;

	private int param1_;

	private int param2_;

	private int param3_;

	public static MessageParser<FUStB2DSBMapCond> Parser => _parser;

	public EB2DSBMapCond Cond
	{
		get
		{
			return cond_;
		}
		set
		{
			cond_ = value;
		}
	}

	public int TargetId
	{
		get
		{
			return targetId_;
		}
		set
		{
			targetId_ = value;
		}
	}

	public int Param1
	{
		get
		{
			return param1_;
		}
		set
		{
			param1_ = value;
		}
	}

	public int Param2
	{
		get
		{
			return param2_;
		}
		set
		{
			param2_ = value;
		}
	}

	public int Param3
	{
		get
		{
			return param3_;
		}
		set
		{
			param3_ = value;
		}
	}

	public FUStB2DSBMapCond()
	{
	}

	public FUStB2DSBMapCond(FUStB2DSBMapCond other)
		: this()
	{
		cond_ = other.cond_;
		targetId_ = other.targetId_;
		param1_ = other.param1_;
		param2_ = other.param2_;
		param3_ = other.param3_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStB2DSBMapCond Clone()
	{
		return new FUStB2DSBMapCond(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStB2DSBMapCond);
	}

	public bool Equals(FUStB2DSBMapCond other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Cond != other.Cond)
		{
			return false;
		}
		if (TargetId != other.TargetId)
		{
			return false;
		}
		if (Param1 != other.Param1)
		{
			return false;
		}
		if (Param2 != other.Param2)
		{
			return false;
		}
		if (Param3 != other.Param3)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Cond != EB2DSBMapCond.None)
		{
			num ^= Cond.GetHashCode();
		}
		if (TargetId != 0)
		{
			num ^= TargetId.GetHashCode();
		}
		if (Param1 != 0)
		{
			num ^= Param1.GetHashCode();
		}
		if (Param2 != 0)
		{
			num ^= Param2.GetHashCode();
		}
		if (Param3 != 0)
		{
			num ^= Param3.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Cond != EB2DSBMapCond.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Cond);
		}
		if (TargetId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(TargetId);
		}
		if (Param1 != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Param1);
		}
		if (Param2 != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(Param2);
		}
		if (Param3 != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Param3);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Cond != EB2DSBMapCond.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Cond);
		}
		if (TargetId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TargetId);
		}
		if (Param1 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param1);
		}
		if (Param2 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param2);
		}
		if (Param3 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param3);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStB2DSBMapCond other)
	{
		if (other != null)
		{
			if (other.Cond != EB2DSBMapCond.None)
			{
				Cond = other.Cond;
			}
			if (other.TargetId != 0)
			{
				TargetId = other.TargetId;
			}
			if (other.Param1 != 0)
			{
				Param1 = other.Param1;
			}
			if (other.Param2 != 0)
			{
				Param2 = other.Param2;
			}
			if (other.Param3 != 0)
			{
				Param3 = other.Param3;
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
				Cond = (EB2DSBMapCond)input.ReadEnum();
				break;
			case 16u:
				TargetId = input.ReadInt32();
				break;
			case 24u:
				Param1 = input.ReadInt32();
				break;
			case 32u:
				Param2 = input.ReadInt32();
				break;
			case 40u:
				Param3 = input.ReadInt32();
				break;
			}
		}
	}
}
