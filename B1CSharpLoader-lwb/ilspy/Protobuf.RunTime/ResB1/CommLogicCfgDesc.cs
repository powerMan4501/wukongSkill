using System;
using Google.Protobuf;

namespace ResB1;

public sealed class CommLogicCfgDesc : IMessage<CommLogicCfgDesc>, IMessage, IEquatable<CommLogicCfgDesc>, IDeepCloneable<CommLogicCfgDesc>
{
	private static readonly MessageParser<CommLogicCfgDesc> _parser = new MessageParser<CommLogicCfgDesc>(() => new CommLogicCfgDesc());

	private UnknownFieldSet _unknownFields;

	private CommCfgType id_;

	private int value_;

	public static MessageParser<CommLogicCfgDesc> Parser => _parser;

	public CommCfgType Id
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

	public int Value
	{
		get
		{
			return value_;
		}
		set
		{
			value_ = value;
		}
	}

	public CommLogicCfgDesc()
	{
	}

	public CommLogicCfgDesc(CommLogicCfgDesc other)
		: this()
	{
		id_ = other.id_;
		value_ = other.value_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CommLogicCfgDesc Clone()
	{
		return new CommLogicCfgDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CommLogicCfgDesc);
	}

	public bool Equals(CommLogicCfgDesc other)
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
		if (Value != other.Value)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != CommCfgType.None)
		{
			num ^= Id.GetHashCode();
		}
		if (Value != 0)
		{
			num ^= Value.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != CommCfgType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Id);
		}
		if (Value != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(Value);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != CommCfgType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Id);
		}
		if (Value != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Value);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CommLogicCfgDesc other)
	{
		if (other != null)
		{
			if (other.Id != CommCfgType.None)
			{
				Id = other.Id;
			}
			if (other.Value != 0)
			{
				Value = other.Value;
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
				Id = (CommCfgType)input.ReadEnum();
				break;
			case 16u:
				Value = input.ReadInt32();
				break;
			}
		}
	}
}
