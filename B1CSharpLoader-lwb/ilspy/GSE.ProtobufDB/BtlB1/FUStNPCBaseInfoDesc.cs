using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStNPCBaseInfoDesc : IMessage<FUStNPCBaseInfoDesc>, IMessage, IEquatable<FUStNPCBaseInfoDesc>, IDeepCloneable<FUStNPCBaseInfoDesc>
{
	private static readonly MessageParser<FUStNPCBaseInfoDesc> _parser = new MessageParser<FUStNPCBaseInfoDesc>(() => new FUStNPCBaseInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string animInfoDAPath_ = "";

	private string guard_ = "";

	public static MessageParser<FUStNPCBaseInfoDesc> Parser => _parser;

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

	public string AnimInfoDAPath
	{
		get
		{
			return animInfoDAPath_;
		}
		set
		{
			animInfoDAPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Guard
	{
		get
		{
			return guard_;
		}
		set
		{
			guard_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStNPCBaseInfoDesc()
	{
	}

	public FUStNPCBaseInfoDesc(FUStNPCBaseInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		animInfoDAPath_ = other.animInfoDAPath_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStNPCBaseInfoDesc Clone()
	{
		return new FUStNPCBaseInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStNPCBaseInfoDesc);
	}

	public bool Equals(FUStNPCBaseInfoDesc other)
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
		if (AnimInfoDAPath != other.AnimInfoDAPath)
		{
			return false;
		}
		if (Guard != other.Guard)
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
		if (AnimInfoDAPath.Length != 0)
		{
			num ^= AnimInfoDAPath.GetHashCode();
		}
		if (Guard.Length != 0)
		{
			num ^= Guard.GetHashCode();
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
		if (AnimInfoDAPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(AnimInfoDAPath);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Guard);
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
		if (AnimInfoDAPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AnimInfoDAPath);
		}
		if (Guard.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guard);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStNPCBaseInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.AnimInfoDAPath.Length != 0)
			{
				AnimInfoDAPath = other.AnimInfoDAPath;
			}
			if (other.Guard.Length != 0)
			{
				Guard = other.Guard;
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
			case 18u:
				AnimInfoDAPath = input.ReadString();
				break;
			case 26u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
