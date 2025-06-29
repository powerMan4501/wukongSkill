using System;
using Google.Protobuf;

namespace OssB1;

public sealed class CommValueChange : IMessage<CommValueChange>, IMessage, IEquatable<CommValueChange>, IDeepCloneable<CommValueChange>
{
	private static readonly MessageParser<CommValueChange> _parser = new MessageParser<CommValueChange>(() => new CommValueChange());

	private UnknownFieldSet _unknownFields;

	private CommValueChangeType type_;

	private int id_;

	private long changeValue_;

	private long currentValue_;

	public static MessageParser<CommValueChange> Parser => _parser;

	public CommValueChangeType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

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

	public long ChangeValue
	{
		get
		{
			return changeValue_;
		}
		set
		{
			changeValue_ = value;
		}
	}

	public long CurrentValue
	{
		get
		{
			return currentValue_;
		}
		set
		{
			currentValue_ = value;
		}
	}

	public CommValueChange()
	{
	}

	public CommValueChange(CommValueChange other)
		: this()
	{
		type_ = other.type_;
		id_ = other.id_;
		changeValue_ = other.changeValue_;
		currentValue_ = other.currentValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CommValueChange Clone()
	{
		return new CommValueChange(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CommValueChange);
	}

	public bool Equals(CommValueChange other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ChangeValue != other.ChangeValue)
		{
			return false;
		}
		if (CurrentValue != other.CurrentValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != CommValueChangeType.None)
		{
			num ^= Type.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ChangeValue != 0L)
		{
			num ^= ChangeValue.GetHashCode();
		}
		if (CurrentValue != 0L)
		{
			num ^= CurrentValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != CommValueChangeType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Id);
		}
		if (ChangeValue != 0L)
		{
			output.WriteRawTag(24);
			output.WriteInt64(ChangeValue);
		}
		if (CurrentValue != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(CurrentValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != CommValueChangeType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ChangeValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ChangeValue);
		}
		if (CurrentValue != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(CurrentValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CommValueChange other)
	{
		if (other != null)
		{
			if (other.Type != CommValueChangeType.None)
			{
				Type = other.Type;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ChangeValue != 0L)
			{
				ChangeValue = other.ChangeValue;
			}
			if (other.CurrentValue != 0L)
			{
				CurrentValue = other.CurrentValue;
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
				Type = (CommValueChangeType)input.ReadEnum();
				break;
			case 16u:
				Id = input.ReadInt32();
				break;
			case 24u:
				ChangeValue = input.ReadInt64();
				break;
			case 32u:
				CurrentValue = input.ReadInt64();
				break;
			}
		}
	}
}
