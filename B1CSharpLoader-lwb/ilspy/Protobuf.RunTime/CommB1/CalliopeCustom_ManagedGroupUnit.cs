using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_ManagedGroupUnit : IMessage<CalliopeCustom_ManagedGroupUnit>, IMessage, IEquatable<CalliopeCustom_ManagedGroupUnit>, IDeepCloneable<CalliopeCustom_ManagedGroupUnit>
{
	private static readonly MessageParser<CalliopeCustom_ManagedGroupUnit> _parser = new MessageParser<CalliopeCustom_ManagedGroupUnit>(() => new CalliopeCustom_ManagedGroupUnit());

	private UnknownFieldSet _unknownFields;

	private string objGuid_ = "";

	private int defaultState_;

	private int managePolice_;

	public static MessageParser<CalliopeCustom_ManagedGroupUnit> Parser => _parser;

	public string ObjGuid
	{
		get
		{
			return objGuid_;
		}
		set
		{
			objGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DefaultState
	{
		get
		{
			return defaultState_;
		}
		set
		{
			defaultState_ = value;
		}
	}

	public int ManagePolice
	{
		get
		{
			return managePolice_;
		}
		set
		{
			managePolice_ = value;
		}
	}

	public CalliopeCustom_ManagedGroupUnit()
	{
	}

	public CalliopeCustom_ManagedGroupUnit(CalliopeCustom_ManagedGroupUnit other)
		: this()
	{
		objGuid_ = other.objGuid_;
		defaultState_ = other.defaultState_;
		managePolice_ = other.managePolice_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_ManagedGroupUnit Clone()
	{
		return new CalliopeCustom_ManagedGroupUnit(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_ManagedGroupUnit);
	}

	public bool Equals(CalliopeCustom_ManagedGroupUnit other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObjGuid != other.ObjGuid)
		{
			return false;
		}
		if (DefaultState != other.DefaultState)
		{
			return false;
		}
		if (ManagePolice != other.ManagePolice)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObjGuid.Length != 0)
		{
			num ^= ObjGuid.GetHashCode();
		}
		if (DefaultState != 0)
		{
			num ^= DefaultState.GetHashCode();
		}
		if (ManagePolice != 0)
		{
			num ^= ManagePolice.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObjGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ObjGuid);
		}
		if (DefaultState != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DefaultState);
		}
		if (ManagePolice != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ManagePolice);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObjGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObjGuid);
		}
		if (DefaultState != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultState);
		}
		if (ManagePolice != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ManagePolice);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_ManagedGroupUnit other)
	{
		if (other != null)
		{
			if (other.ObjGuid.Length != 0)
			{
				ObjGuid = other.ObjGuid;
			}
			if (other.DefaultState != 0)
			{
				DefaultState = other.DefaultState;
			}
			if (other.ManagePolice != 0)
			{
				ManagePolice = other.ManagePolice;
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
			case 10u:
				ObjGuid = input.ReadString();
				break;
			case 16u:
				DefaultState = input.ReadInt32();
				break;
			case 24u:
				ManagePolice = input.ReadInt32();
				break;
			}
		}
	}
}
