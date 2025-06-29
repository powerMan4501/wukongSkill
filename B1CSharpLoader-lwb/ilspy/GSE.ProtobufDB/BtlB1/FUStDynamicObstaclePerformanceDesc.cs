using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStDynamicObstaclePerformanceDesc : IMessage<FUStDynamicObstaclePerformanceDesc>, IMessage, IEquatable<FUStDynamicObstaclePerformanceDesc>, IDeepCloneable<FUStDynamicObstaclePerformanceDesc>
{
	private static readonly MessageParser<FUStDynamicObstaclePerformanceDesc> _parser = new MessageParser<FUStDynamicObstaclePerformanceDesc>(() => new FUStDynamicObstaclePerformanceDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int performID_;

	private int resID_;

	private string dAPath_ = "";

	public static MessageParser<FUStDynamicObstaclePerformanceDesc> Parser => _parser;

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

	public int PerformID
	{
		get
		{
			return performID_;
		}
		set
		{
			performID_ = value;
		}
	}

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public string DAPath
	{
		get
		{
			return dAPath_;
		}
		set
		{
			dAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStDynamicObstaclePerformanceDesc()
	{
	}

	public FUStDynamicObstaclePerformanceDesc(FUStDynamicObstaclePerformanceDesc other)
		: this()
	{
		iD_ = other.iD_;
		performID_ = other.performID_;
		resID_ = other.resID_;
		dAPath_ = other.dAPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDynamicObstaclePerformanceDesc Clone()
	{
		return new FUStDynamicObstaclePerformanceDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDynamicObstaclePerformanceDesc);
	}

	public bool Equals(FUStDynamicObstaclePerformanceDesc other)
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
		if (PerformID != other.PerformID)
		{
			return false;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (DAPath != other.DAPath)
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
		if (PerformID != 0)
		{
			num ^= PerformID.GetHashCode();
		}
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (DAPath.Length != 0)
		{
			num ^= DAPath.GetHashCode();
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
		if (PerformID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(PerformID);
		}
		if (ResID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ResID);
		}
		if (DAPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DAPath);
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
		if (PerformID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PerformID);
		}
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (DAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DAPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDynamicObstaclePerformanceDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.PerformID != 0)
			{
				PerformID = other.PerformID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.DAPath.Length != 0)
			{
				DAPath = other.DAPath;
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
				PerformID = input.ReadInt32();
				break;
			case 24u:
				ResID = input.ReadInt32();
				break;
			case 34u:
				DAPath = input.ReadString();
				break;
			}
		}
	}
}
