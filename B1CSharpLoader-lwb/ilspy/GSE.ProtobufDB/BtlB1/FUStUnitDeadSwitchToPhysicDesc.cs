using System;
using BtlShare;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUnitDeadSwitchToPhysicDesc : IMessage<FUStUnitDeadSwitchToPhysicDesc>, IMessage, IEquatable<FUStUnitDeadSwitchToPhysicDesc>, IDeepCloneable<FUStUnitDeadSwitchToPhysicDesc>
{
	private static readonly MessageParser<FUStUnitDeadSwitchToPhysicDesc> _parser = new MessageParser<FUStUnitDeadSwitchToPhysicDesc>(() => new FUStUnitDeadSwitchToPhysicDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private EGSYesNo defaultEnableAutoSwitch_;

	private EGSYesNo defaultEnableWeaponAutoSwitch_;

	private string guard_ = "";

	public static MessageParser<FUStUnitDeadSwitchToPhysicDesc> Parser => _parser;

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

	public EGSYesNo DefaultEnableAutoSwitch
	{
		get
		{
			return defaultEnableAutoSwitch_;
		}
		set
		{
			defaultEnableAutoSwitch_ = value;
		}
	}

	public EGSYesNo DefaultEnableWeaponAutoSwitch
	{
		get
		{
			return defaultEnableWeaponAutoSwitch_;
		}
		set
		{
			defaultEnableWeaponAutoSwitch_ = value;
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

	public FUStUnitDeadSwitchToPhysicDesc()
	{
	}

	public FUStUnitDeadSwitchToPhysicDesc(FUStUnitDeadSwitchToPhysicDesc other)
		: this()
	{
		iD_ = other.iD_;
		defaultEnableAutoSwitch_ = other.defaultEnableAutoSwitch_;
		defaultEnableWeaponAutoSwitch_ = other.defaultEnableWeaponAutoSwitch_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUnitDeadSwitchToPhysicDesc Clone()
	{
		return new FUStUnitDeadSwitchToPhysicDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUnitDeadSwitchToPhysicDesc);
	}

	public bool Equals(FUStUnitDeadSwitchToPhysicDesc other)
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
		if (DefaultEnableAutoSwitch != other.DefaultEnableAutoSwitch)
		{
			return false;
		}
		if (DefaultEnableWeaponAutoSwitch != other.DefaultEnableWeaponAutoSwitch)
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
		if (DefaultEnableAutoSwitch != EGSYesNo.No)
		{
			num ^= DefaultEnableAutoSwitch.GetHashCode();
		}
		if (DefaultEnableWeaponAutoSwitch != EGSYesNo.No)
		{
			num ^= DefaultEnableWeaponAutoSwitch.GetHashCode();
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
		if (DefaultEnableAutoSwitch != EGSYesNo.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DefaultEnableAutoSwitch);
		}
		if (DefaultEnableWeaponAutoSwitch != EGSYesNo.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)DefaultEnableWeaponAutoSwitch);
		}
		if (Guard.Length != 0)
		{
			output.WriteRawTag(34);
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
		if (DefaultEnableAutoSwitch != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DefaultEnableAutoSwitch);
		}
		if (DefaultEnableWeaponAutoSwitch != EGSYesNo.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DefaultEnableWeaponAutoSwitch);
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

	public void MergeFrom(FUStUnitDeadSwitchToPhysicDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.DefaultEnableAutoSwitch != EGSYesNo.No)
			{
				DefaultEnableAutoSwitch = other.DefaultEnableAutoSwitch;
			}
			if (other.DefaultEnableWeaponAutoSwitch != EGSYesNo.No)
			{
				DefaultEnableWeaponAutoSwitch = other.DefaultEnableWeaponAutoSwitch;
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
				DefaultEnableAutoSwitch = (EGSYesNo)input.ReadEnum();
				break;
			case 24u:
				DefaultEnableWeaponAutoSwitch = (EGSYesNo)input.ReadEnum();
				break;
			case 34u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
