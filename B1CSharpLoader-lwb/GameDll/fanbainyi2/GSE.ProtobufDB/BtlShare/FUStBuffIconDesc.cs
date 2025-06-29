using System;
using Google.Protobuf;

namespace BtlShare;

public sealed class FUStBuffIconDesc : IMessage<FUStBuffIconDesc>, IMessage, IEquatable<FUStBuffIconDesc>, IDeepCloneable<FUStBuffIconDesc>
{
	private static readonly MessageParser<FUStBuffIconDesc> _parser = new MessageParser<FUStBuffIconDesc>(() => new FUStBuffIconDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int iconID_;

	private string guard_ = "";

	public static MessageParser<FUStBuffIconDesc> Parser => _parser;

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

	public int IconID
	{
		get
		{
			return iconID_;
		}
		set
		{
			iconID_ = value;
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

	public FUStBuffIconDesc()
	{
	}

	public FUStBuffIconDesc(FUStBuffIconDesc other)
		: this()
	{
		iD_ = other.iD_;
		iconID_ = other.iconID_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBuffIconDesc Clone()
	{
		return new FUStBuffIconDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBuffIconDesc);
	}

	public bool Equals(FUStBuffIconDesc other)
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
		if (IconID != other.IconID)
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
		if (IconID != 0)
		{
			num ^= IconID.GetHashCode();
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
		if (IconID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(IconID);
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
		if (IconID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IconID);
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

	public void MergeFrom(FUStBuffIconDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IconID != 0)
			{
				IconID = other.IconID;
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
			case 16u:
				IconID = input.ReadInt32();
				break;
			case 26u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
