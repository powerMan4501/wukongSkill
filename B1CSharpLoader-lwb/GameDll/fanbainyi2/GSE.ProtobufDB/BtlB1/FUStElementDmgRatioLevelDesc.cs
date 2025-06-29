using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStElementDmgRatioLevelDesc : IMessage<FUStElementDmgRatioLevelDesc>, IMessage, IEquatable<FUStElementDmgRatioLevelDesc>, IDeepCloneable<FUStElementDmgRatioLevelDesc>
{
	private static readonly MessageParser<FUStElementDmgRatioLevelDesc> _parser = new MessageParser<FUStElementDmgRatioLevelDesc>(() => new FUStElementDmgRatioLevelDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float ratio_;

	public static MessageParser<FUStElementDmgRatioLevelDesc> Parser => _parser;

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

	public float Ratio
	{
		get
		{
			return ratio_;
		}
		set
		{
			ratio_ = value;
		}
	}

	public FUStElementDmgRatioLevelDesc()
	{
	}

	public FUStElementDmgRatioLevelDesc(FUStElementDmgRatioLevelDesc other)
		: this()
	{
		iD_ = other.iD_;
		ratio_ = other.ratio_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStElementDmgRatioLevelDesc Clone()
	{
		return new FUStElementDmgRatioLevelDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStElementDmgRatioLevelDesc);
	}

	public bool Equals(FUStElementDmgRatioLevelDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Ratio, other.Ratio))
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
		if (Ratio != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Ratio);
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
		if (Ratio != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Ratio);
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
		if (Ratio != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStElementDmgRatioLevelDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Ratio != 0f)
			{
				Ratio = other.Ratio;
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
			case 21u:
				Ratio = input.ReadFloat();
				break;
			}
		}
	}
}
