using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStMagicFieldExpandDesc : IMessage<FUStMagicFieldExpandDesc>, IMessage, IEquatable<FUStMagicFieldExpandDesc>, IDeepCloneable<FUStMagicFieldExpandDesc>
{
	private static readonly MessageParser<FUStMagicFieldExpandDesc> _parser = new MessageParser<FUStMagicFieldExpandDesc>(() => new FUStMagicFieldExpandDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string guard_ = "";

	public static MessageParser<FUStMagicFieldExpandDesc> Parser => _parser;

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

	public FUStMagicFieldExpandDesc()
	{
	}

	public FUStMagicFieldExpandDesc(FUStMagicFieldExpandDesc other)
		: this()
	{
		iD_ = other.iD_;
		guard_ = other.guard_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStMagicFieldExpandDesc Clone()
	{
		return new FUStMagicFieldExpandDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStMagicFieldExpandDesc);
	}

	public bool Equals(FUStMagicFieldExpandDesc other)
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
		if (Guard.Length != 0)
		{
			output.WriteRawTag(18);
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

	public void MergeFrom(FUStMagicFieldExpandDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
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
			case 18u:
				Guard = input.ReadString();
				break;
			}
		}
	}
}
