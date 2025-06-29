using System;
using BtlShare;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class DeadUnitData : IMessage<DeadUnitData>, IMessage, IEquatable<DeadUnitData>, IDeepCloneable<DeadUnitData>
{
	private static readonly MessageParser<DeadUnitData> _parser = new MessageParser<DeadUnitData>(() => new DeadUnitData());

	private UnknownFieldSet _unknownFields;

	private string uid_ = "";

	private EBGUResetType resetType_;

	public static MessageParser<DeadUnitData> Parser => _parser;

	public string Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EBGUResetType ResetType
	{
		get
		{
			return resetType_;
		}
		set
		{
			resetType_ = value;
		}
	}

	public DeadUnitData()
	{
	}

	public DeadUnitData(DeadUnitData other)
		: this()
	{
		uid_ = other.uid_;
		resetType_ = other.resetType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DeadUnitData Clone()
	{
		return new DeadUnitData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DeadUnitData);
	}

	public bool Equals(DeadUnitData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (ResetType != other.ResetType)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Uid.Length != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (ResetType != EBGUResetType.No)
		{
			num ^= ResetType.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Uid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Uid);
		}
		if (ResetType != EBGUResetType.No)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ResetType);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Uid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Uid);
		}
		if (ResetType != EBGUResetType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResetType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DeadUnitData other)
	{
		if (other != null)
		{
			if (other.Uid.Length != 0)
			{
				Uid = other.Uid;
			}
			if (other.ResetType != EBGUResetType.No)
			{
				ResetType = other.ResetType;
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
				Uid = input.ReadString();
				break;
			case 16u:
				ResetType = (EBGUResetType)input.ReadEnum();
				break;
			}
		}
	}
}
