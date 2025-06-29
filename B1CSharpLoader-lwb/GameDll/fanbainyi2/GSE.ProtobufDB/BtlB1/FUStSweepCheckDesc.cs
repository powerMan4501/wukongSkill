using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace BtlB1;

public sealed class FUStSweepCheckDesc : IMessage<FUStSweepCheckDesc>, IMessage, IEquatable<FUStSweepCheckDesc>, IDeepCloneable<FUStSweepCheckDesc>
{
	private static readonly MessageParser<FUStSweepCheckDesc> _parser = new MessageParser<FUStSweepCheckDesc>(() => new FUStSweepCheckDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private float radius_;

	private string socketName_ = "";

	public static MessageParser<FUStSweepCheckDesc> Parser => _parser;

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

	public float Radius
	{
		get
		{
			return radius_;
		}
		set
		{
			radius_ = value;
		}
	}

	public string SocketName
	{
		get
		{
			return socketName_;
		}
		set
		{
			socketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStSweepCheckDesc()
	{
	}

	public FUStSweepCheckDesc(FUStSweepCheckDesc other)
		: this()
	{
		iD_ = other.iD_;
		radius_ = other.radius_;
		socketName_ = other.socketName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSweepCheckDesc Clone()
	{
		return new FUStSweepCheckDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSweepCheckDesc);
	}

	public bool Equals(FUStSweepCheckDesc other)
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
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Radius, other.Radius))
		{
			return false;
		}
		if (SocketName != other.SocketName)
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
		if (Radius != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Radius);
		}
		if (SocketName.Length != 0)
		{
			num ^= SocketName.GetHashCode();
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
		if (Radius != 0f)
		{
			output.WriteRawTag(21);
			output.WriteFloat(Radius);
		}
		if (SocketName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SocketName);
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
		if (Radius != 0f)
		{
			num += 5;
		}
		if (SocketName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SocketName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSweepCheckDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.Radius != 0f)
			{
				Radius = other.Radius;
			}
			if (other.SocketName.Length != 0)
			{
				SocketName = other.SocketName;
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
				Radius = input.ReadFloat();
				break;
			case 26u:
				SocketName = input.ReadString();
				break;
			}
		}
	}
}
