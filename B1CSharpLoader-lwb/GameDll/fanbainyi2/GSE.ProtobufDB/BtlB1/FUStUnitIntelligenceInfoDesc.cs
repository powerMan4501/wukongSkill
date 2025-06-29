using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitIntelligenceInfoDesc : IMessage<FUStUnitIntelligenceInfoDesc>, IMessage, IEquatable<FUStUnitIntelligenceInfoDesc>, IDeepCloneable<FUStUnitIntelligenceInfoDesc>
{
	private static readonly MessageParser<FUStUnitIntelligenceInfoDesc> _parser = new MessageParser<FUStUnitIntelligenceInfoDesc>(() => new FUStUnitIntelligenceInfoDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo isDefaultRunBT_;

	private EGSYesNo isDefaultRunCBG_;

	public static MessageParser<FUStUnitIntelligenceInfoDesc> Parser => _parser;

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

	public EGSYesNo IsDefaultRunBT
	{
		get
		{
			return isDefaultRunBT_;
		}
		set
		{
			isDefaultRunBT_ = value;
		}
	}

	public EGSYesNo IsDefaultRunCBG
	{
		get
		{
			return isDefaultRunCBG_;
		}
		set
		{
			isDefaultRunCBG_ = value;
		}
	}

	public FUStUnitIntelligenceInfoDesc()
	{
	}

	public FUStUnitIntelligenceInfoDesc(FUStUnitIntelligenceInfoDesc other)
		: this()
	{
		iD_ = other.iD_;
		isDefaultRunBT_ = other.isDefaultRunBT_;
		isDefaultRunCBG_ = other.isDefaultRunCBG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitIntelligenceInfoDesc Clone()
	{
		return new FUStUnitIntelligenceInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitIntelligenceInfoDesc);
	}

	public bool Equals(FUStUnitIntelligenceInfoDesc other)
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
		if (IsDefaultRunBT != other.IsDefaultRunBT)
		{
			return false;
		}
		if (IsDefaultRunCBG != other.IsDefaultRunCBG)
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
		if (IsDefaultRunBT != EGSYesNo.No)
		{
			num ^= IsDefaultRunBT.GetHashCode();
		}
		if (IsDefaultRunCBG != EGSYesNo.No)
		{
			num ^= IsDefaultRunCBG.GetHashCode();
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
		if (IsDefaultRunBT != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsDefaultRunBT);
		}
		if (IsDefaultRunCBG != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)IsDefaultRunCBG);
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
		if (IsDefaultRunBT != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDefaultRunBT);
		}
		if (IsDefaultRunCBG != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsDefaultRunCBG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUnitIntelligenceInfoDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsDefaultRunBT != EGSYesNo.No)
			{
				IsDefaultRunBT = other.IsDefaultRunBT;
			}
			if (other.IsDefaultRunCBG != EGSYesNo.No)
			{
				IsDefaultRunCBG = other.IsDefaultRunCBG;
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
				IsDefaultRunBT = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				IsDefaultRunCBG = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
