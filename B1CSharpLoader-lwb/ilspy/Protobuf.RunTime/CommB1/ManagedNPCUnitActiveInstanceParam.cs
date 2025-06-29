using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ManagedNPCUnitActiveInstanceParam : IMessage<ManagedNPCUnitActiveInstanceParam>, IMessage, IEquatable<ManagedNPCUnitActiveInstanceParam>, IDeepCloneable<ManagedNPCUnitActiveInstanceParam>
{
	private static readonly MessageParser<ManagedNPCUnitActiveInstanceParam> _parser = new MessageParser<ManagedNPCUnitActiveInstanceParam>(() => new ManagedNPCUnitActiveInstanceParam());

	private UnknownFieldSet _unknownFields;

	private string defaultValue_ = "";

	private string managedValue_ = "";

	public static MessageParser<ManagedNPCUnitActiveInstanceParam> Parser => _parser;

	public string DefaultValue
	{
		get
		{
			return defaultValue_;
		}
		set
		{
			defaultValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ManagedValue
	{
		get
		{
			return managedValue_;
		}
		set
		{
			managedValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ManagedNPCUnitActiveInstanceParam()
	{
	}

	public ManagedNPCUnitActiveInstanceParam(ManagedNPCUnitActiveInstanceParam other)
		: this()
	{
		defaultValue_ = other.defaultValue_;
		managedValue_ = other.managedValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ManagedNPCUnitActiveInstanceParam Clone()
	{
		return new ManagedNPCUnitActiveInstanceParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ManagedNPCUnitActiveInstanceParam);
	}

	public bool Equals(ManagedNPCUnitActiveInstanceParam other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
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
		if (DefaultValue.Length != 0)
		{
			num ^= DefaultValue.GetHashCode();
		}
		if (ManagedValue.Length != 0)
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
		if (DefaultValue.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(DefaultValue);
		}
		if (ManagedValue.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ManagedValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DefaultValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DefaultValue);
		}
		if (ManagedValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ManagedValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ManagedNPCUnitActiveInstanceParam other)
	{
		if (other != null)
		{
			if (other.DefaultValue.Length != 0)
			{
				DefaultValue = other.DefaultValue;
			}
			if (other.ManagedValue.Length != 0)
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
				DefaultValue = input.ReadString();
				break;
			case 18u:
				ManagedValue = input.ReadString();
				break;
			}
		}
	}
}
