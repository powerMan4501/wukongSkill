using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitAudioBankMapDesc : IMessage<FUStUnitAudioBankMapDesc>, IMessage, IEquatable<FUStUnitAudioBankMapDesc>, IDeepCloneable<FUStUnitAudioBankMapDesc>
{
	private static readonly MessageParser<FUStUnitAudioBankMapDesc> _parser = new MessageParser<FUStUnitAudioBankMapDesc>(() => new FUStUnitAudioBankMapDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int unitResID_;

	private string baseAudioBankName_ = "";

	private string baseAudioBankPath_ = "";

	public static MessageParser<FUStUnitAudioBankMapDesc> Parser => _parser;

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

	public int UnitResID
	{
		get
		{
			return unitResID_;
		}
		set
		{
			unitResID_ = value;
		}
	}

	public string BaseAudioBankName
	{
		get
		{
			return baseAudioBankName_;
		}
		set
		{
			baseAudioBankName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string BaseAudioBankPath
	{
		get
		{
			return baseAudioBankPath_;
		}
		set
		{
			baseAudioBankPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStUnitAudioBankMapDesc()
	{
	}

	public FUStUnitAudioBankMapDesc(FUStUnitAudioBankMapDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitResID_ = other.unitResID_;
		baseAudioBankName_ = other.baseAudioBankName_;
		baseAudioBankPath_ = other.baseAudioBankPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitAudioBankMapDesc Clone()
	{
		return new FUStUnitAudioBankMapDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitAudioBankMapDesc);
	}

	public bool Equals(FUStUnitAudioBankMapDesc other)
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
		if (UnitResID != other.UnitResID)
		{
			return false;
		}
		if (BaseAudioBankName != other.BaseAudioBankName)
		{
			return false;
		}
		if (BaseAudioBankPath != other.BaseAudioBankPath)
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
		if (UnitResID != 0)
		{
			num ^= UnitResID.GetHashCode();
		}
		if (BaseAudioBankName.Length != 0)
		{
			num ^= BaseAudioBankName.GetHashCode();
		}
		if (BaseAudioBankPath.Length != 0)
		{
			num ^= BaseAudioBankPath.GetHashCode();
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
		if (UnitResID != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(UnitResID);
		}
		if (BaseAudioBankName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(BaseAudioBankName);
		}
		if (BaseAudioBankPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(BaseAudioBankPath);
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
		if (UnitResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(UnitResID);
		}
		if (BaseAudioBankName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BaseAudioBankName);
		}
		if (BaseAudioBankPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BaseAudioBankPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitAudioBankMapDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitResID != 0)
			{
				UnitResID = other.UnitResID;
			}
			if (other.BaseAudioBankName.Length != 0)
			{
				BaseAudioBankName = other.BaseAudioBankName;
			}
			if (other.BaseAudioBankPath.Length != 0)
			{
				BaseAudioBankPath = other.BaseAudioBankPath;
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
				UnitResID = input.ReadInt32();
				break;
			case 26u:
				BaseAudioBankName = input.ReadString();
				break;
			case 34u:
				BaseAudioBankPath = input.ReadString();
				break;
			}
		}
	}
}
