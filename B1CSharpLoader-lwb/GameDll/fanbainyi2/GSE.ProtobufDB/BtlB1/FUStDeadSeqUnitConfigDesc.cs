using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStDeadSeqUnitConfigDesc : IMessage<FUStDeadSeqUnitConfigDesc>, IMessage, IEquatable<FUStDeadSeqUnitConfigDesc>, IDeepCloneable<FUStDeadSeqUnitConfigDesc>
{
	private static readonly MessageParser<FUStDeadSeqUnitConfigDesc> _parser = new MessageParser<FUStDeadSeqUnitConfigDesc>(() => new FUStDeadSeqUnitConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo isEnable_;

	private string unitGuid_ = "";

	public static MessageParser<FUStDeadSeqUnitConfigDesc> Parser => _parser;

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

	public EGSYesNo IsEnable
	{
		get
		{
			return isEnable_;
		}
		set
		{
			isEnable_ = value;
		}
	}

	public string UnitGuid
	{
		get
		{
			return unitGuid_;
		}
		set
		{
			unitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStDeadSeqUnitConfigDesc()
	{
	}

	public FUStDeadSeqUnitConfigDesc(FUStDeadSeqUnitConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		isEnable_ = other.isEnable_;
		unitGuid_ = other.unitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStDeadSeqUnitConfigDesc Clone()
	{
		return new FUStDeadSeqUnitConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStDeadSeqUnitConfigDesc);
	}

	public bool Equals(FUStDeadSeqUnitConfigDesc other)
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
		if (IsEnable != other.IsEnable)
		{
			return false;
		}
		if (UnitGuid != other.UnitGuid)
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
		if (IsEnable != EGSYesNo.No)
		{
			num ^= IsEnable.GetHashCode();
		}
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
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
		if (IsEnable != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IsEnable);
		}
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(UnitGuid);
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
		if (IsEnable != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IsEnable);
		}
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStDeadSeqUnitConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsEnable != EGSYesNo.No)
			{
				IsEnable = other.IsEnable;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
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
				IsEnable = (EGSYesNo)input.ReadEnum();
				break;
			case 26u:
				UnitGuid = input.ReadString();
				break;
			}
		}
	}
}
