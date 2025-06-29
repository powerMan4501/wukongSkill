using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ManagedNPCUnitBuffParam : IMessage<ManagedNPCUnitBuffParam>, IMessage, IEquatable<ManagedNPCUnitBuffParam>, IDeepCloneable<ManagedNPCUnitBuffParam>
{
	private static readonly MessageParser<ManagedNPCUnitBuffParam> _parser = new MessageParser<ManagedNPCUnitBuffParam>(() => new ManagedNPCUnitBuffParam());

	private UnknownFieldSet _unknownFields;

	private string buffParamId_ = "";

	private int defaultValue_;

	private int managedValue_;

	public static MessageParser<ManagedNPCUnitBuffParam> Parser => _parser;

	public string BuffParamId
	{
		get
		{
			return buffParamId_;
		}
		set
		{
			buffParamId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int DefaultValue
	{
		get
		{
			return defaultValue_;
		}
		set
		{
			defaultValue_ = value;
		}
	}

	public int ManagedValue
	{
		get
		{
			return managedValue_;
		}
		set
		{
			managedValue_ = value;
		}
	}

	public ManagedNPCUnitBuffParam()
	{
	}

	public ManagedNPCUnitBuffParam(ManagedNPCUnitBuffParam other)
		: this()
	{
		buffParamId_ = other.buffParamId_;
		defaultValue_ = other.defaultValue_;
		managedValue_ = other.managedValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ManagedNPCUnitBuffParam Clone()
	{
		return new ManagedNPCUnitBuffParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ManagedNPCUnitBuffParam);
	}

	public bool Equals(ManagedNPCUnitBuffParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BuffParamId != other.BuffParamId)
		{
			return false;
		}
		if (DefaultValue != other.DefaultValue)
		{
			return false;
		}
		if (ManagedValue != other.ManagedValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (BuffParamId.Length != 0)
		{
			num ^= BuffParamId.GetHashCode();
		}
		if (DefaultValue != 0)
		{
			num ^= DefaultValue.GetHashCode();
		}
		if (ManagedValue != 0)
		{
			num ^= ManagedValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (BuffParamId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(BuffParamId);
		}
		if (DefaultValue != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DefaultValue);
		}
		if (ManagedValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ManagedValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (BuffParamId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(BuffParamId);
		}
		if (DefaultValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultValue);
		}
		if (ManagedValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ManagedValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ManagedNPCUnitBuffParam other)
	{
		if (other != null)
		{
			if (other.BuffParamId.Length != 0)
			{
				BuffParamId = other.BuffParamId;
			}
			if (other.DefaultValue != 0)
			{
				DefaultValue = other.DefaultValue;
			}
			if (other.ManagedValue != 0)
			{
				ManagedValue = other.ManagedValue;
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
				BuffParamId = input.ReadString();
				break;
			case 16u:
				DefaultValue = input.ReadInt32();
				break;
			case 24u:
				ManagedValue = input.ReadInt32();
				break;
			}
		}
	}
}
