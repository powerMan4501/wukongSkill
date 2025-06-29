using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DropLibConfig : IMessage<DropLibConfig>, IMessage, IEquatable<DropLibConfig>, IDeepCloneable<DropLibConfig>
{
	private static readonly MessageParser<DropLibConfig> _parser = new MessageParser<DropLibConfig>(() => new DropLibConfig());

	private UnknownFieldSet _unknownFields;

	private int dropId_;

	private int weight_;

	public static MessageParser<DropLibConfig> Parser => _parser;

	public int DropId
	{
		get
		{
			return dropId_;
		}
		set
		{
			dropId_ = value;
		}
	}

	public int Weight
	{
		get
		{
			return weight_;
		}
		set
		{
			weight_ = value;
		}
	}

	public DropLibConfig()
	{
	}

	public DropLibConfig(DropLibConfig other)
		: this()
	{
		dropId_ = other.dropId_;
		weight_ = other.weight_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DropLibConfig Clone()
	{
		return new DropLibConfig(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DropLibConfig);
	}

	public bool Equals(DropLibConfig other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DropId != other.DropId)
		{
			return false;
		}
		if (Weight != other.Weight)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (DropId != 0)
		{
			num ^= DropId.GetHashCode();
		}
		if (Weight != 0)
		{
			num ^= Weight.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (DropId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(DropId);
		}
		if (Weight != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Weight);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (DropId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropId);
		}
		if (Weight != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Weight);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DropLibConfig other)
	{
		if (other != null)
		{
			if (other.DropId != 0)
			{
				DropId = other.DropId;
			}
			if (other.Weight != 0)
			{
				Weight = other.Weight;
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
				DropId = input.ReadInt32();
				break;
			case 16u:
				Weight = input.ReadInt32();
				break;
			}
		}
	}
}
