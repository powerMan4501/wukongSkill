using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCollectionSpawnGroupDesc : IMessage<FUStCollectionSpawnGroupDesc>, IMessage, IEquatable<FUStCollectionSpawnGroupDesc>, IDeepCloneable<FUStCollectionSpawnGroupDesc>
{
	private static readonly MessageParser<FUStCollectionSpawnGroupDesc> _parser = new MessageParser<FUStCollectionSpawnGroupDesc>(() => new FUStCollectionSpawnGroupDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string mapName_ = "";

	private string groupName_ = "";

	private int numMax_;

	private int numMin_;

	private int plusRate_;

	private int chiefRate_;

	private int eventId_;

	private int plusEventId_;

	private int chiefEventId_;

	private int freshDelta_;

	private int freshNumMax_;

	public static MessageParser<FUStCollectionSpawnGroupDesc> Parser => _parser;

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

	public string MapName
	{
		get
		{
			return mapName_;
		}
		set
		{
			mapName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GroupName
	{
		get
		{
			return groupName_;
		}
		set
		{
			groupName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int NumMax
	{
		get
		{
			return numMax_;
		}
		set
		{
			numMax_ = value;
		}
	}

	public int NumMin
	{
		get
		{
			return numMin_;
		}
		set
		{
			numMin_ = value;
		}
	}

	public int PlusRate
	{
		get
		{
			return plusRate_;
		}
		set
		{
			plusRate_ = value;
		}
	}

	public int ChiefRate
	{
		get
		{
			return chiefRate_;
		}
		set
		{
			chiefRate_ = value;
		}
	}

	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	public int PlusEventId
	{
		get
		{
			return plusEventId_;
		}
		set
		{
			plusEventId_ = value;
		}
	}

	public int ChiefEventId
	{
		get
		{
			return chiefEventId_;
		}
		set
		{
			chiefEventId_ = value;
		}
	}

	public int FreshDelta
	{
		get
		{
			return freshDelta_;
		}
		set
		{
			freshDelta_ = value;
		}
	}

	public int FreshNumMax
	{
		get
		{
			return freshNumMax_;
		}
		set
		{
			freshNumMax_ = value;
		}
	}

	public FUStCollectionSpawnGroupDesc()
	{
	}

	public FUStCollectionSpawnGroupDesc(FUStCollectionSpawnGroupDesc other)
		: this()
	{
		iD_ = other.iD_;
		mapName_ = other.mapName_;
		groupName_ = other.groupName_;
		numMax_ = other.numMax_;
		numMin_ = other.numMin_;
		plusRate_ = other.plusRate_;
		chiefRate_ = other.chiefRate_;
		eventId_ = other.eventId_;
		plusEventId_ = other.plusEventId_;
		chiefEventId_ = other.chiefEventId_;
		freshDelta_ = other.freshDelta_;
		freshNumMax_ = other.freshNumMax_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCollectionSpawnGroupDesc Clone()
	{
		return new FUStCollectionSpawnGroupDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCollectionSpawnGroupDesc);
	}

	public bool Equals(FUStCollectionSpawnGroupDesc other)
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
		if (MapName != other.MapName)
		{
			return false;
		}
		if (GroupName != other.GroupName)
		{
			return false;
		}
		if (NumMax != other.NumMax)
		{
			return false;
		}
		if (NumMin != other.NumMin)
		{
			return false;
		}
		if (PlusRate != other.PlusRate)
		{
			return false;
		}
		if (ChiefRate != other.ChiefRate)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (PlusEventId != other.PlusEventId)
		{
			return false;
		}
		if (ChiefEventId != other.ChiefEventId)
		{
			return false;
		}
		if (FreshDelta != other.FreshDelta)
		{
			return false;
		}
		if (FreshNumMax != other.FreshNumMax)
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
		if (MapName.Length != 0)
		{
			num ^= MapName.GetHashCode();
		}
		if (GroupName.Length != 0)
		{
			num ^= GroupName.GetHashCode();
		}
		if (NumMax != 0)
		{
			num ^= NumMax.GetHashCode();
		}
		if (NumMin != 0)
		{
			num ^= NumMin.GetHashCode();
		}
		if (PlusRate != 0)
		{
			num ^= PlusRate.GetHashCode();
		}
		if (ChiefRate != 0)
		{
			num ^= ChiefRate.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (PlusEventId != 0)
		{
			num ^= PlusEventId.GetHashCode();
		}
		if (ChiefEventId != 0)
		{
			num ^= ChiefEventId.GetHashCode();
		}
		if (FreshDelta != 0)
		{
			num ^= FreshDelta.GetHashCode();
		}
		if (FreshNumMax != 0)
		{
			num ^= FreshNumMax.GetHashCode();
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
		if (MapName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MapName);
		}
		if (GroupName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(GroupName);
		}
		if (NumMax != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(NumMax);
		}
		if (NumMin != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(NumMin);
		}
		if (PlusRate != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PlusRate);
		}
		if (ChiefRate != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ChiefRate);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(EventId);
		}
		if (PlusEventId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PlusEventId);
		}
		if (ChiefEventId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ChiefEventId);
		}
		if (FreshDelta != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(FreshDelta);
		}
		if (FreshNumMax != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(FreshNumMax);
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
		if (MapName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapName);
		}
		if (GroupName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GroupName);
		}
		if (NumMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NumMax);
		}
		if (NumMin != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NumMin);
		}
		if (PlusRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlusRate);
		}
		if (ChiefRate != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChiefRate);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (PlusEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlusEventId);
		}
		if (ChiefEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChiefEventId);
		}
		if (FreshDelta != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreshDelta);
		}
		if (FreshNumMax != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FreshNumMax);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCollectionSpawnGroupDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.MapName.Length != 0)
			{
				MapName = other.MapName;
			}
			if (other.GroupName.Length != 0)
			{
				GroupName = other.GroupName;
			}
			if (other.NumMax != 0)
			{
				NumMax = other.NumMax;
			}
			if (other.NumMin != 0)
			{
				NumMin = other.NumMin;
			}
			if (other.PlusRate != 0)
			{
				PlusRate = other.PlusRate;
			}
			if (other.ChiefRate != 0)
			{
				ChiefRate = other.ChiefRate;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.PlusEventId != 0)
			{
				PlusEventId = other.PlusEventId;
			}
			if (other.ChiefEventId != 0)
			{
				ChiefEventId = other.ChiefEventId;
			}
			if (other.FreshDelta != 0)
			{
				FreshDelta = other.FreshDelta;
			}
			if (other.FreshNumMax != 0)
			{
				FreshNumMax = other.FreshNumMax;
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
				MapName = input.ReadString();
				break;
			case 26u:
				GroupName = input.ReadString();
				break;
			case 32u:
				NumMax = input.ReadInt32();
				break;
			case 40u:
				NumMin = input.ReadInt32();
				break;
			case 48u:
				PlusRate = input.ReadInt32();
				break;
			case 56u:
				ChiefRate = input.ReadInt32();
				break;
			case 64u:
				EventId = input.ReadInt32();
				break;
			case 72u:
				PlusEventId = input.ReadInt32();
				break;
			case 80u:
				ChiefEventId = input.ReadInt32();
				break;
			case 88u:
				FreshDelta = input.ReadInt32();
				break;
			case 96u:
				FreshNumMax = input.ReadInt32();
				break;
			}
		}
	}
}
