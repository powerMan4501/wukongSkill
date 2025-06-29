using System;
using Google.Protobuf;

namespace CommB1;

public sealed class ManagedNPCUnitParam : IMessage<ManagedNPCUnitParam>, IMessage, IEquatable<ManagedNPCUnitParam>, IDeepCloneable<ManagedNPCUnitParam>
{
	private static readonly MessageParser<ManagedNPCUnitParam> _parser = new MessageParser<ManagedNPCUnitParam>(() => new ManagedNPCUnitParam());

	private UnknownFieldSet _unknownFields;

	private int defaultValue_;

	private int managedValue_;

	public static MessageParser<ManagedNPCUnitParam> Parser => _parser;

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

	public ManagedNPCUnitParam()
	{
	}

	public ManagedNPCUnitParam(ManagedNPCUnitParam other)
		: this()
	{
		defaultValue_ = other.defaultValue_;
		managedValue_ = other.managedValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ManagedNPCUnitParam Clone()
	{
		return new ManagedNPCUnitParam(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ManagedNPCUnitParam);
	}

	public bool Equals(ManagedNPCUnitParam other)
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
		if (DefaultValue != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DefaultValue);
		}
		if (ManagedValue != 0)
		{
			output.WriteRawTag(16);
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

	public void MergeFrom(ManagedNPCUnitParam other)
	{
		if (other != null)
		{
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
			case 8u:
				DefaultValue = input.ReadInt32();
				break;
			case 16u:
				ManagedValue = input.ReadInt32();
				break;
			}
		}
	}
}
