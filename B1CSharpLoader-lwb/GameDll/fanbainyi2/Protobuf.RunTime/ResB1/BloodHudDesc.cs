using System;
using Google.Protobuf;

namespace ResB1;

public sealed class BloodHudDesc : IMessage<BloodHudDesc>, IMessage, IEquatable<BloodHudDesc>, IDeepCloneable<BloodHudDesc>
{
	private static readonly MessageParser<BloodHudDesc> _parser = new MessageParser<BloodHudDesc>(() => new BloodHudDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int priority_;

	public static MessageParser<BloodHudDesc> Parser => _parser;

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

	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	public BloodHudDesc()
	{
	}

	public BloodHudDesc(BloodHudDesc other)
		: this()
	{
		id_ = other.id_;
		priority_ = other.priority_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public BloodHudDesc Clone()
	{
		return new BloodHudDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as BloodHudDesc);
	}

	public bool Equals(BloodHudDesc other)
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
		if (Priority != other.Priority)
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
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
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
		if (Priority != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Priority);
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
		if (Priority != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(BloodHudDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Priority != 0)
			{
				Priority = other.Priority;
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
				Priority = input.ReadInt32();
				break;
			}
		}
	}
}
