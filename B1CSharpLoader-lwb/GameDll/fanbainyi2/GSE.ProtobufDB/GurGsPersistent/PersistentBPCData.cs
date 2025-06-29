using System;
using Google.Protobuf;

namespace GurGsPersistent;

public sealed class PersistentBPCData : IMessage<PersistentBPCData>, IMessage, IEquatable<PersistentBPCData>, IDeepCloneable<PersistentBPCData>
{
	private static readonly MessageParser<PersistentBPCData> _parser = new MessageParser<PersistentBPCData>(() => new PersistentBPCData());

	private UnknownFieldSet _unknownFields;

	private BPC_PlayerAttrData bPCPlayerAttrData_;

	private BPC_PlayerRoleData bPCPlayerRoleData_;

	private BPC_RebirthPointData bPCRebirthPointData_;

	private BPC_MapSymbolData bPCMapSymbolData_;

	private BPC_TransData bPCTransData_;

	private BPC_GeoInfoData bPCGeoInfoData_;

	public static MessageParser<PersistentBPCData> Parser => _parser;

	public BPC_PlayerAttrData BPCPlayerAttrData
	{
		get
		{
			return bPCPlayerAttrData_;
		}
		set
		{
			bPCPlayerAttrData_ = value;
		}
	}

	public BPC_PlayerRoleData BPCPlayerRoleData
	{
		get
		{
			return bPCPlayerRoleData_;
		}
		set
		{
			bPCPlayerRoleData_ = value;
		}
	}

	public BPC_RebirthPointData BPCRebirthPointData
	{
		get
		{
			return bPCRebirthPointData_;
		}
		set
		{
			bPCRebirthPointData_ = value;
		}
	}

	public BPC_MapSymbolData BPCMapSymbolData
	{
		get
		{
			return bPCMapSymbolData_;
		}
		set
		{
			bPCMapSymbolData_ = value;
		}
	}

	public BPC_TransData BPCTransData
	{
		get
		{
			return bPCTransData_;
		}
		set
		{
			bPCTransData_ = value;
		}
	}

	public BPC_GeoInfoData BPCGeoInfoData
	{
		get
		{
			return bPCGeoInfoData_;
		}
		set
		{
			bPCGeoInfoData_ = value;
		}
	}

	public PersistentBPCData()
	{
	}

	public PersistentBPCData(PersistentBPCData other)
		: this()
	{
		bPCPlayerAttrData_ = ((other.bPCPlayerAttrData_ != null) ? other.bPCPlayerAttrData_.Clone() : null);
		bPCPlayerRoleData_ = ((other.bPCPlayerRoleData_ != null) ? other.bPCPlayerRoleData_.Clone() : null);
		bPCRebirthPointData_ = ((other.bPCRebirthPointData_ != null) ? other.bPCRebirthPointData_.Clone() : null);
		bPCMapSymbolData_ = ((other.bPCMapSymbolData_ != null) ? other.bPCMapSymbolData_.Clone() : null);
		bPCTransData_ = ((other.bPCTransData_ != null) ? other.bPCTransData_.Clone() : null);
		bPCGeoInfoData_ = ((other.bPCGeoInfoData_ != null) ? other.bPCGeoInfoData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PersistentBPCData Clone()
	{
		return new PersistentBPCData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PersistentBPCData);
	}

	public bool Equals(PersistentBPCData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BPCPlayerAttrData, other.BPCPlayerAttrData))
		{
			return false;
		}
		if (!object.Equals(BPCPlayerRoleData, other.BPCPlayerRoleData))
		{
			return false;
		}
		if (!object.Equals(BPCRebirthPointData, other.BPCRebirthPointData))
		{
			return false;
		}
		if (!object.Equals(BPCMapSymbolData, other.BPCMapSymbolData))
		{
			return false;
		}
		if (!object.Equals(BPCTransData, other.BPCTransData))
		{
			return false;
		}
		if (!object.Equals(BPCGeoInfoData, other.BPCGeoInfoData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (bPCPlayerAttrData_ != null)
		{
			num ^= BPCPlayerAttrData.GetHashCode();
		}
		if (bPCPlayerRoleData_ != null)
		{
			num ^= BPCPlayerRoleData.GetHashCode();
		}
		if (bPCRebirthPointData_ != null)
		{
			num ^= BPCRebirthPointData.GetHashCode();
		}
		if (bPCMapSymbolData_ != null)
		{
			num ^= BPCMapSymbolData.GetHashCode();
		}
		if (bPCTransData_ != null)
		{
			num ^= BPCTransData.GetHashCode();
		}
		if (bPCGeoInfoData_ != null)
		{
			num ^= BPCGeoInfoData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (bPCPlayerAttrData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BPCPlayerAttrData);
		}
		if (bPCPlayerRoleData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(BPCPlayerRoleData);
		}
		if (bPCRebirthPointData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(BPCRebirthPointData);
		}
		if (bPCMapSymbolData_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(BPCMapSymbolData);
		}
		if (bPCTransData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(BPCTransData);
		}
		if (bPCGeoInfoData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BPCGeoInfoData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (bPCPlayerAttrData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCPlayerAttrData);
		}
		if (bPCPlayerRoleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCPlayerRoleData);
		}
		if (bPCRebirthPointData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCRebirthPointData);
		}
		if (bPCMapSymbolData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCMapSymbolData);
		}
		if (bPCTransData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCTransData);
		}
		if (bPCGeoInfoData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BPCGeoInfoData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PersistentBPCData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bPCPlayerAttrData_ != null)
		{
			if (bPCPlayerAttrData_ == null)
			{
				BPCPlayerAttrData = new BPC_PlayerAttrData();
			}
			BPCPlayerAttrData.MergeFrom(other.BPCPlayerAttrData);
		}
		if (other.bPCPlayerRoleData_ != null)
		{
			if (bPCPlayerRoleData_ == null)
			{
				BPCPlayerRoleData = new BPC_PlayerRoleData();
			}
			BPCPlayerRoleData.MergeFrom(other.BPCPlayerRoleData);
		}
		if (other.bPCRebirthPointData_ != null)
		{
			if (bPCRebirthPointData_ == null)
			{
				BPCRebirthPointData = new BPC_RebirthPointData();
			}
			BPCRebirthPointData.MergeFrom(other.BPCRebirthPointData);
		}
		if (other.bPCMapSymbolData_ != null)
		{
			if (bPCMapSymbolData_ == null)
			{
				BPCMapSymbolData = new BPC_MapSymbolData();
			}
			BPCMapSymbolData.MergeFrom(other.BPCMapSymbolData);
		}
		if (other.bPCTransData_ != null)
		{
			if (bPCTransData_ == null)
			{
				BPCTransData = new BPC_TransData();
			}
			BPCTransData.MergeFrom(other.BPCTransData);
		}
		if (other.bPCGeoInfoData_ != null)
		{
			if (bPCGeoInfoData_ == null)
			{
				BPCGeoInfoData = new BPC_GeoInfoData();
			}
			BPCGeoInfoData.MergeFrom(other.BPCGeoInfoData);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (bPCPlayerAttrData_ == null)
				{
					BPCPlayerAttrData = new BPC_PlayerAttrData();
				}
				input.ReadMessage(BPCPlayerAttrData);
				break;
			case 18u:
				if (bPCPlayerRoleData_ == null)
				{
					BPCPlayerRoleData = new BPC_PlayerRoleData();
				}
				input.ReadMessage(BPCPlayerRoleData);
				break;
			case 26u:
				if (bPCRebirthPointData_ == null)
				{
					BPCRebirthPointData = new BPC_RebirthPointData();
				}
				input.ReadMessage(BPCRebirthPointData);
				break;
			case 34u:
				if (bPCMapSymbolData_ == null)
				{
					BPCMapSymbolData = new BPC_MapSymbolData();
				}
				input.ReadMessage(BPCMapSymbolData);
				break;
			case 42u:
				if (bPCTransData_ == null)
				{
					BPCTransData = new BPC_TransData();
				}
				input.ReadMessage(BPCTransData);
				break;
			case 50u:
				if (bPCGeoInfoData_ == null)
				{
					BPCGeoInfoData = new BPC_GeoInfoData();
				}
				input.ReadMessage(BPCGeoInfoData);
				break;
			}
		}
	}
}
