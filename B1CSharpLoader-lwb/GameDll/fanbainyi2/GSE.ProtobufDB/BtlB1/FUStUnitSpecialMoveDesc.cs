using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStUnitSpecialMoveDesc : IMessage<FUStUnitSpecialMoveDesc>, IMessage, IEquatable<FUStUnitSpecialMoveDesc>, IDeepCloneable<FUStUnitSpecialMoveDesc>
{
	private static readonly MessageParser<FUStUnitSpecialMoveDesc> _parser = new MessageParser<FUStUnitSpecialMoveDesc>(() => new FUStUnitSpecialMoveDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float hardMoveSpeedNormal_;

	private float hardMoveSpeedFast_;

	public static MessageParser<FUStUnitSpecialMoveDesc> Parser => _parser;

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

	public float HardMoveSpeedNormal
	{
		get
		{
			return hardMoveSpeedNormal_;
		}
		set
		{
			hardMoveSpeedNormal_ = value;
		}
	}

	public float HardMoveSpeedFast
	{
		get
		{
			return hardMoveSpeedFast_;
		}
		set
		{
			hardMoveSpeedFast_ = value;
		}
	}

	public FUStUnitSpecialMoveDesc()
	{
	}

	public FUStUnitSpecialMoveDesc(FUStUnitSpecialMoveDesc other)
		: this()
	{
		iD_ = other.iD_;
		hardMoveSpeedNormal_ = other.hardMoveSpeedNormal_;
		hardMoveSpeedFast_ = other.hardMoveSpeedFast_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitSpecialMoveDesc Clone()
	{
		return new FUStUnitSpecialMoveDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitSpecialMoveDesc);
	}

	public bool Equals(FUStUnitSpecialMoveDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HardMoveSpeedNormal, other.HardMoveSpeedNormal))
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HardMoveSpeedFast, other.HardMoveSpeedFast))
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
		if (HardMoveSpeedNormal != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HardMoveSpeedNormal);
		}
		if (HardMoveSpeedFast != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HardMoveSpeedFast);
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
		if (HardMoveSpeedNormal != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(HardMoveSpeedNormal);
		}
		if (HardMoveSpeedFast != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(HardMoveSpeedFast);
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
		if (HardMoveSpeedNormal != 0f)
		{
			num += 5;
		}
		if (HardMoveSpeedFast != 0f)
		{
			num += 5;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitSpecialMoveDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.HardMoveSpeedNormal != 0f)
			{
				HardMoveSpeedNormal = other.HardMoveSpeedNormal;
			}
			if (other.HardMoveSpeedFast != 0f)
			{
				HardMoveSpeedFast = other.HardMoveSpeedFast;
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
				HardMoveSpeedNormal = input.ReadFloat();
				break;
			case 29u:
				HardMoveSpeedFast = input.ReadFloat();
				break;
			}
		}
	}
}
