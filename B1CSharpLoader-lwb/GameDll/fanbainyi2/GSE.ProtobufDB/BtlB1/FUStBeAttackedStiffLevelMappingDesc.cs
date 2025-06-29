using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStBeAttackedStiffLevelMappingDesc : IMessage<FUStBeAttackedStiffLevelMappingDesc>, IMessage, IEquatable<FUStBeAttackedStiffLevelMappingDesc>, IDeepCloneable<FUStBeAttackedStiffLevelMappingDesc>
{
	private static readonly MessageParser<FUStBeAttackedStiffLevelMappingDesc> _parser = new MessageParser<FUStBeAttackedStiffLevelMappingDesc>(() => new FUStBeAttackedStiffLevelMappingDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private int originStiffLevel_;

	private int mappingStiffLevel_;

	private string guard_ = "";

	public static MessageParser<FUStBeAttackedStiffLevelMappingDesc> Parser => _parser;

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

	public int OriginStiffLevel
	{
		get
		{
			return originStiffLevel_;
		}
		set
		{
			originStiffLevel_ = value;
		}
	}

	public int MappingStiffLevel
	{
		get
		{
			return mappingStiffLevel_;
		}
		set
		{
			mappingStiffLevel_ = value;
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

	public FUStBeAttackedStiffLevelMappingDesc()
	{
	}

	public FUStBeAttackedStiffLevelMappingDesc(FUStBeAttackedStiffLevelMappingDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		originStiffLevel_ = other.originStiffLevel_;
		mappingStiffLevel_ = other.mappingStiffLevel_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStBeAttackedStiffLevelMappingDesc Clone()
	{
		return new FUStBeAttackedStiffLevelMappingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStBeAttackedStiffLevelMappingDesc);
	}

	public bool Equals(FUStBeAttackedStiffLevelMappingDesc other)
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
		if (ResID != other.ResID)
		{
			return false;
		}
		if (OriginStiffLevel != other.OriginStiffLevel)
		{
			return false;
		}
		if (MappingStiffLevel != other.MappingStiffLevel)
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
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (OriginStiffLevel != 0)
		{
			num ^= OriginStiffLevel.GetHashCode();
		}
		if (MappingStiffLevel != 0)
		{
			num ^= MappingStiffLevel.GetHashCode();
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
		if (ResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(ResID);
		}
		if (OriginStiffLevel != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(OriginStiffLevel);
		}
		if (MappingStiffLevel != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(MappingStiffLevel);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(42);
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
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (OriginStiffLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OriginStiffLevel);
		}
		if (MappingStiffLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MappingStiffLevel);
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

	public void MergeFrom(FUStBeAttackedStiffLevelMappingDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.OriginStiffLevel != 0)
			{
				OriginStiffLevel = other.OriginStiffLevel;
			}
			if (other.MappingStiffLevel != 0)
			{
				MappingStiffLevel = other.MappingStiffLevel;
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
				ResID = input.ReadInt32();
				break;
			case 24u:
				OriginStiffLevel = input.ReadInt32();
				break;
			case 32u:
				MappingStiffLevel = input.ReadInt32();
				break;
			case 42u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
