using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStPotentialEnergyConfigDesc : IMessage<FUStPotentialEnergyConfigDesc>, IMessage, IEquatable<FUStPotentialEnergyConfigDesc>, IDeepCloneable<FUStPotentialEnergyConfigDesc>
{
	private static readonly MessageParser<FUStPotentialEnergyConfigDesc> _parser = new MessageParser<FUStPotentialEnergyConfigDesc>(() => new FUStPotentialEnergyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int resID_;

	private int configID_;

	private FUStPotentialEnergyLevelDetailConfig pELevelConfig_;

	public static MessageParser<FUStPotentialEnergyConfigDesc> Parser => _parser;

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

	public int ConfigID
	{
		get
		{
			return configID_;
		}
		set
		{
			configID_ = value;
		}
	}

	public FUStPotentialEnergyLevelDetailConfig PELevelConfig
	{
		get
		{
			return pELevelConfig_;
		}
		set
		{
			pELevelConfig_ = value;
		}
	}

	public FUStPotentialEnergyConfigDesc()
	{
	}

	public FUStPotentialEnergyConfigDesc(FUStPotentialEnergyConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		resID_ = other.resID_;
		configID_ = other.configID_;
		pELevelConfig_ = ((other.pELevelConfig_ != null) ? other.pELevelConfig_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStPotentialEnergyConfigDesc Clone()
	{
		return new FUStPotentialEnergyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStPotentialEnergyConfigDesc);
	}

	public bool Equals(FUStPotentialEnergyConfigDesc other)
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
		if (ConfigID != other.ConfigID)
		{
			return false;
		}
		if (!object.Equals(PELevelConfig, other.PELevelConfig))
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
		if (ConfigID != 0)
		{
			num ^= ConfigID.GetHashCode();
		}
		if (pELevelConfig_ != null)
		{
			num ^= PELevelConfig.GetHashCode();
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
		if (ConfigID != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ConfigID);
		}
		if (pELevelConfig_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PELevelConfig);
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
		if (ConfigID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConfigID);
		}
		if (pELevelConfig_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PELevelConfig);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStPotentialEnergyConfigDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ID != 0)
		{
			ID = other.ID;
		}
		if (other.ResID != 0)
		{
			ResID = other.ResID;
		}
		if (other.ConfigID != 0)
		{
			ConfigID = other.ConfigID;
		}
		if (other.pELevelConfig_ != null)
		{
			if (pELevelConfig_ == null)
			{
				PELevelConfig = new FUStPotentialEnergyLevelDetailConfig();
			}
			PELevelConfig.MergeFrom(other.PELevelConfig);
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
			case 8u:
				ID = input.ReadInt32();
				break;
			case 16u:
				ResID = input.ReadInt32();
				break;
			case 24u:
				ConfigID = input.ReadInt32();
				break;
			case 34u:
				if (pELevelConfig_ == null)
				{
					PELevelConfig = new FUStPotentialEnergyLevelDetailConfig();
				}
				input.ReadMessage(PELevelConfig);
				break;
			}
		}
	}
}
