using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStFixFunctionDesc : IMessage<FUStFixFunctionDesc>, IMessage, IEquatable<FUStFixFunctionDesc>, IDeepCloneable<FUStFixFunctionDesc>
{
	private static readonly MessageParser<FUStFixFunctionDesc> _parser = new MessageParser<FUStFixFunctionDesc>(() => new FUStFixFunctionDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EFixFunctionType fixFunctionType_;

	private int param1_;

	private int param2_;

	private int param3_;

	private int param4_;

	private int param5_;

	private float param6_;

	public static MessageParser<FUStFixFunctionDesc> Parser => _parser;

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

	public EFixFunctionType FixFunctionType
	{
		get
		{
			return fixFunctionType_;
		}
		set
		{
			fixFunctionType_ = value;
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

	public int Param4
	{
		get
		{
			return param4_;
		}
		set
		{
			param4_ = value;
		}
	}

	public int Param5
	{
		get
		{
			return param5_;
		}
		set
		{
			param5_ = value;
		}
	}

	public float Param6
	{
		get
		{
			return param6_;
		}
		set
		{
			param6_ = value;
		}
	}

	public FUStFixFunctionDesc()
	{
	}

	public FUStFixFunctionDesc(FUStFixFunctionDesc other)
		: this()
	{
		iD_ = other.iD_;
		fixFunctionType_ = other.fixFunctionType_;
		param1_ = other.param1_;
		param2_ = other.param2_;
		param3_ = other.param3_;
		param4_ = other.param4_;
		param5_ = other.param5_;
		param6_ = other.param6_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStFixFunctionDesc Clone()
	{
		return new FUStFixFunctionDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStFixFunctionDesc);
	}

	public bool Equals(FUStFixFunctionDesc other)
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
		if (FixFunctionType != other.FixFunctionType)
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
		if (Param4 != other.Param4)
		{
			return false;
		}
		if (Param5 != other.Param5)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Param6, other.Param6))
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
		if (FixFunctionType != EFixFunctionType.None)
		{
			num ^= FixFunctionType.GetHashCode();
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
		if (Param4 != 0)
		{
			num ^= Param4.GetHashCode();
		}
		if (Param5 != 0)
		{
			num ^= Param5.GetHashCode();
		}
		if (Param6 != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Param6);
		}
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
		if (FixFunctionType != EFixFunctionType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)FixFunctionType);
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
		if (Param4 != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(Param4);
		}
		if (Param5 != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(Param5);
		}
		if (Param6 != 0f)
		{
			output.WriteRawTag(69);
			output.WriteFloat(Param6);
		}
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
		if (FixFunctionType != EFixFunctionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FixFunctionType);
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
		if (Param4 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param4);
		}
		if (Param5 != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Param5);
		}
		if (Param6 != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStFixFunctionDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.FixFunctionType != EFixFunctionType.None)
			{
				FixFunctionType = other.FixFunctionType;
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
			if (other.Param4 != 0)
			{
				Param4 = other.Param4;
			}
			if (other.Param5 != 0)
			{
				Param5 = other.Param5;
			}
			if (other.Param6 != 0f)
			{
				Param6 = other.Param6;
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
				ID = input.ReadInt32();
				break;
			case 16u:
				FixFunctionType = (EFixFunctionType)input.ReadEnum();
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
			case 48u:
				Param4 = input.ReadInt32();
				break;
			case 56u:
				Param5 = input.ReadInt32();
				break;
			case 69u:
				Param6 = input.ReadFloat();
				break;
			}
		}
	}
}
