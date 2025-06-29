using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStOverlyingSkillSDesc : IMessage<FUStOverlyingSkillSDesc>, IMessage, IEquatable<FUStOverlyingSkillSDesc>, IDeepCloneable<FUStOverlyingSkillSDesc>
{
	private static readonly MessageParser<FUStOverlyingSkillSDesc> _parser = new MessageParser<FUStOverlyingSkillSDesc>(() => new FUStOverlyingSkillSDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int maxPoint_;

	private int needPoint_;

	private float needTime_;

	public static MessageParser<FUStOverlyingSkillSDesc> Parser => _parser;

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

	public int MaxPoint
	{
		get
		{
			return maxPoint_;
		}
		set
		{
			maxPoint_ = value;
		}
	}

	public int NeedPoint
	{
		get
		{
			return needPoint_;
		}
		set
		{
			needPoint_ = value;
		}
	}

	public float NeedTime
	{
		get
		{
			return needTime_;
		}
		set
		{
			needTime_ = value;
		}
	}

	public FUStOverlyingSkillSDesc()
	{
	}

	public FUStOverlyingSkillSDesc(FUStOverlyingSkillSDesc other)
		: this()
	{
		iD_ = other.iD_;
		maxPoint_ = other.maxPoint_;
		needPoint_ = other.needPoint_;
		needTime_ = other.needTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStOverlyingSkillSDesc Clone()
	{
		return new FUStOverlyingSkillSDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStOverlyingSkillSDesc);
	}

	public bool Equals(FUStOverlyingSkillSDesc other)
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
		if (MaxPoint != other.MaxPoint)
		{
			return false;
		}
		if (NeedPoint != other.NeedPoint)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(NeedTime, other.NeedTime))
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
		if (MaxPoint != 0)
		{
			num ^= MaxPoint.GetHashCode();
		}
		if (NeedPoint != 0)
		{
			num ^= NeedPoint.GetHashCode();
		}
		if (NeedTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(NeedTime);
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
		if (MaxPoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MaxPoint);
		}
		if (NeedPoint != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NeedPoint);
		}
		if (NeedTime != 0f)
		{
			output.WriteRawTag(37);
			output.WriteFloat(NeedTime);
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
		if (MaxPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MaxPoint);
		}
		if (NeedPoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NeedPoint);
		}
		if (NeedTime != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStOverlyingSkillSDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.MaxPoint != 0)
			{
				MaxPoint = other.MaxPoint;
			}
			if (other.NeedPoint != 0)
			{
				NeedPoint = other.NeedPoint;
			}
			if (other.NeedTime != 0f)
			{
				NeedTime = other.NeedTime;
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
				MaxPoint = input.ReadInt32();
				break;
			case 24u:
				NeedPoint = input.ReadInt32();
				break;
			case 37u:
				NeedTime = input.ReadFloat();
				break;
			}
		}
	}
}
