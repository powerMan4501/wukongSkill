using System;
using Google.Protobuf;

namespace ResB1;

public sealed class DestructionDropDesc : IMessage<DestructionDropDesc>, IMessage, IEquatable<DestructionDropDesc>, IDeepCloneable<DestructionDropDesc>
{
	private static readonly MessageParser<DestructionDropDesc> _parser = new MessageParser<DestructionDropDesc>(() => new DestructionDropDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int dropGroupId_;

	private YesNoType canRepeatDrop_;

	private YesNoType canRepeatGenerate_;

	private int dropDistanceLimit_;

	public static MessageParser<DestructionDropDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int DropGroupId
	{
		get
		{
			return dropGroupId_;
		}
		set
		{
			dropGroupId_ = value;
		}
	}

	public YesNoType CanRepeatDrop
	{
		get
		{
			return canRepeatDrop_;
		}
		set
		{
			canRepeatDrop_ = value;
		}
	}

	public YesNoType CanRepeatGenerate
	{
		get
		{
			return canRepeatGenerate_;
		}
		set
		{
			canRepeatGenerate_ = value;
		}
	}

	public int DropDistanceLimit
	{
		get
		{
			return dropDistanceLimit_;
		}
		set
		{
			dropDistanceLimit_ = value;
		}
	}

	public DestructionDropDesc()
	{
	}

	public DestructionDropDesc(DestructionDropDesc other)
		: this()
	{
		id_ = other.id_;
		dropGroupId_ = other.dropGroupId_;
		canRepeatDrop_ = other.canRepeatDrop_;
		canRepeatGenerate_ = other.canRepeatGenerate_;
		dropDistanceLimit_ = other.dropDistanceLimit_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DestructionDropDesc Clone()
	{
		return new DestructionDropDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DestructionDropDesc);
	}

	public bool Equals(DestructionDropDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (DropGroupId != other.DropGroupId)
		{
			return false;
		}
		if (CanRepeatDrop != other.CanRepeatDrop)
		{
			return false;
		}
		if (CanRepeatGenerate != other.CanRepeatGenerate)
		{
			return false;
		}
		if (DropDistanceLimit != other.DropDistanceLimit)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (DropGroupId != 0)
		{
			num ^= DropGroupId.GetHashCode();
		}
		if (CanRepeatDrop != YesNoType.No)
		{
			num ^= CanRepeatDrop.GetHashCode();
		}
		if (CanRepeatGenerate != YesNoType.No)
		{
			num ^= CanRepeatGenerate.GetHashCode();
		}
		if (DropDistanceLimit != 0)
		{
			num ^= DropDistanceLimit.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (DropGroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(DropGroupId);
		}
		if (CanRepeatDrop != YesNoType.No)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)CanRepeatDrop);
		}
		if (CanRepeatGenerate != YesNoType.No)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)CanRepeatGenerate);
		}
		if (DropDistanceLimit != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(DropDistanceLimit);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (DropGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropGroupId);
		}
		if (CanRepeatDrop != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanRepeatDrop);
		}
		if (CanRepeatGenerate != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CanRepeatGenerate);
		}
		if (DropDistanceLimit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DropDistanceLimit);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DestructionDropDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.DropGroupId != 0)
			{
				DropGroupId = other.DropGroupId;
			}
			if (other.CanRepeatDrop != YesNoType.No)
			{
				CanRepeatDrop = other.CanRepeatDrop;
			}
			if (other.CanRepeatGenerate != YesNoType.No)
			{
				CanRepeatGenerate = other.CanRepeatGenerate;
			}
			if (other.DropDistanceLimit != 0)
			{
				DropDistanceLimit = other.DropDistanceLimit;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				DropGroupId = input.ReadInt32();
				break;
			case 24u:
				CanRepeatDrop = (YesNoType)input.ReadEnum();
				break;
			case 32u:
				CanRepeatGenerate = (YesNoType)input.ReadEnum();
				break;
			case 40u:
				DropDistanceLimit = input.ReadInt32();
				break;
			}
		}
	}
}
