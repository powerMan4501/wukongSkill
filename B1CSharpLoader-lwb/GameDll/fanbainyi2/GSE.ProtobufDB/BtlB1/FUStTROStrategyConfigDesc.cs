using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStTROStrategyConfigDesc : IMessage<FUStTROStrategyConfigDesc>, IMessage, IEquatable<FUStTROStrategyConfigDesc>, IDeepCloneable<FUStTROStrategyConfigDesc>
{
	private static readonly MessageParser<FUStTROStrategyConfigDesc> _parser = new MessageParser<FUStTROStrategyConfigDesc>(() => new FUStTROStrategyConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string unitGuid_ = "";

	private EGSYesNo disable_;

	private EGSYesNo disableLineTraceOptimization_;

	public static MessageParser<FUStTROStrategyConfigDesc> Parser => _parser;

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

	public EGSYesNo Disable
	{
		get
		{
			return disable_;
		}
		set
		{
			disable_ = value;
		}
	}

	public EGSYesNo DisableLineTraceOptimization
	{
		get
		{
			return disableLineTraceOptimization_;
		}
		set
		{
			disableLineTraceOptimization_ = value;
		}
	}

	public FUStTROStrategyConfigDesc()
	{
	}

	public FUStTROStrategyConfigDesc(FUStTROStrategyConfigDesc other)
		: this()
	{
		iD_ = other.iD_;
		unitGuid_ = other.unitGuid_;
		disable_ = other.disable_;
		disableLineTraceOptimization_ = other.disableLineTraceOptimization_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStTROStrategyConfigDesc Clone()
	{
		return new FUStTROStrategyConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStTROStrategyConfigDesc);
	}

	public bool Equals(FUStTROStrategyConfigDesc other)
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
		if (UnitGuid != other.UnitGuid)
		{
			return false;
		}
		if (Disable != other.Disable)
		{
			return false;
		}
		if (DisableLineTraceOptimization != other.DisableLineTraceOptimization)
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
		if (UnitGuid.Length != 0)
		{
			num ^= UnitGuid.GetHashCode();
		}
		if (Disable != EGSYesNo.No)
		{
			num ^= Disable.GetHashCode();
		}
		if (DisableLineTraceOptimization != EGSYesNo.No)
		{
			num ^= DisableLineTraceOptimization.GetHashCode();
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
		if (UnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitGuid);
		}
		if (Disable != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Disable);
		}
		if (DisableLineTraceOptimization != EGSYesNo.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)DisableLineTraceOptimization);
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
		if (UnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitGuid);
		}
		if (Disable != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Disable);
		}
		if (DisableLineTraceOptimization != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DisableLineTraceOptimization);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStTROStrategyConfigDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.UnitGuid.Length != 0)
			{
				UnitGuid = other.UnitGuid;
			}
			if (other.Disable != EGSYesNo.No)
			{
				Disable = other.Disable;
			}
			if (other.DisableLineTraceOptimization != EGSYesNo.No)
			{
				DisableLineTraceOptimization = other.DisableLineTraceOptimization;
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
				UnitGuid = input.ReadString();
				break;
			case 24u:
				Disable = (EGSYesNo)input.ReadEnum();
				break;
			case 32u:
				DisableLineTraceOptimization = (EGSYesNo)input.ReadEnum();
				break;
			}
		}
	}
}
