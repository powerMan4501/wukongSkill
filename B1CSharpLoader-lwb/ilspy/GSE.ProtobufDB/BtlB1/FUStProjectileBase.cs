using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStProjectileBase : IMessage<FUStProjectileBase>, IMessage, IEquatable<FUStProjectileBase>, IDeepCloneable<FUStProjectileBase>
{
	private static readonly MessageParser<FUStProjectileBase> _parser = new MessageParser<FUStProjectileBase>(() => new FUStProjectileBase());

	private UnknownFieldSet _unknownFields;

	private int baseType_;

	private bool useSocket_;

	private string socketName_ = "";

	private int pointSetCachedReqID_;

	public static MessageParser<FUStProjectileBase> Parser => _parser;

	public int BaseType
	{
		get
		{
			return baseType_;
		}
		set
		{
			baseType_ = value;
		}
	}

	public bool UseSocket
	{
		get
		{
			return useSocket_;
		}
		set
		{
			useSocket_ = value;
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

	public int PointSetCachedReqID
	{
		get
		{
			return pointSetCachedReqID_;
		}
		set
		{
			pointSetCachedReqID_ = value;
		}
	}

	public FUStProjectileBase()
	{
	}

	public FUStProjectileBase(FUStProjectileBase other)
		: this()
	{
		baseType_ = other.baseType_;
		useSocket_ = other.useSocket_;
		socketName_ = other.socketName_;
		pointSetCachedReqID_ = other.pointSetCachedReqID_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStProjectileBase Clone()
	{
		return new FUStProjectileBase(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStProjectileBase);
	}

	public bool Equals(FUStProjectileBase other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BaseType != other.BaseType)
		{
			return false;
		}
		if (UseSocket != other.UseSocket)
		{
			return false;
		}
		if (SocketName != other.SocketName)
		{
			return false;
		}
		if (PointSetCachedReqID != other.PointSetCachedReqID)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BaseType != 0)
		{
			num ^= BaseType.GetHashCode();
		}
		if (UseSocket)
		{
			num ^= UseSocket.GetHashCode();
		}
		if (SocketName.Length != 0)
		{
			num ^= SocketName.GetHashCode();
		}
		if (PointSetCachedReqID != 0)
		{
			num ^= PointSetCachedReqID.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BaseType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(BaseType);
		}
		if (UseSocket)
		{
			output.WriteRawTag(16);
			output.WriteBool(UseSocket);
		}
		if (SocketName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SocketName);
		}
		if (PointSetCachedReqID != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(PointSetCachedReqID);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BaseType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BaseType);
		}
		if (UseSocket)
		{
			num += 2;
		}
		if (SocketName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SocketName);
		}
		if (PointSetCachedReqID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PointSetCachedReqID);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStProjectileBase other)
	{
		if (other != null)
		{
			if (other.BaseType != 0)
			{
				BaseType = other.BaseType;
			}
			if (other.UseSocket)
			{
				UseSocket = other.UseSocket;
			}
			if (other.SocketName.Length != 0)
			{
				SocketName = other.SocketName;
			}
			if (other.PointSetCachedReqID != 0)
			{
				PointSetCachedReqID = other.PointSetCachedReqID;
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
				BaseType = input.ReadInt32();
				break;
			case 16u:
				UseSocket = input.ReadBool();
				break;
			case 26u:
				SocketName = input.ReadString();
				break;
			case 32u:
				PointSetCachedReqID = input.ReadInt32();
				break;
			}
		}
	}
}
