using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FSingleAbnormalDispModifyInfo : IMessage<FSingleAbnormalDispModifyInfo>, IMessage, IEquatable<FSingleAbnormalDispModifyInfo>, IDeepCloneable<FSingleAbnormalDispModifyInfo>
{
	private static readonly MessageParser<FSingleAbnormalDispModifyInfo> _parser = new MessageParser<FSingleAbnormalDispModifyInfo>(() => new FSingleAbnormalDispModifyInfo());

	private UnknownFieldSet _unknownFields;

	private EAbnormalDispModifyType modifyType_;

	private string dBCPath_ = "";

	public static MessageParser<FSingleAbnormalDispModifyInfo> Parser => _parser;

	public EAbnormalDispModifyType ModifyType
	{
		get
		{
			return modifyType_;
		}
		set
		{
			modifyType_ = value;
		}
	}

	public string DBCPath
	{
		get
		{
			return dBCPath_;
		}
		set
		{
			dBCPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FSingleAbnormalDispModifyInfo()
	{
	}

	public FSingleAbnormalDispModifyInfo(FSingleAbnormalDispModifyInfo other)
		: this()
	{
		modifyType_ = other.modifyType_;
		dBCPath_ = other.dBCPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FSingleAbnormalDispModifyInfo Clone()
	{
		return new FSingleAbnormalDispModifyInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FSingleAbnormalDispModifyInfo);
	}

	public bool Equals(FSingleAbnormalDispModifyInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ModifyType != other.ModifyType)
		{
			return false;
		}
		if (DBCPath != other.DBCPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ModifyType != EAbnormalDispModifyType.None)
		{
			num ^= ModifyType.GetHashCode();
		}
		if (DBCPath.Length != 0)
		{
			num ^= DBCPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ModifyType != EAbnormalDispModifyType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)ModifyType);
		}
		if (DBCPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DBCPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ModifyType != EAbnormalDispModifyType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ModifyType);
		}
		if (DBCPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DBCPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FSingleAbnormalDispModifyInfo other)
	{
		if (other != null)
		{
			if (other.ModifyType != EAbnormalDispModifyType.None)
			{
				ModifyType = other.ModifyType;
			}
			if (other.DBCPath.Length != 0)
			{
				DBCPath = other.DBCPath;
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
				ModifyType = (EAbnormalDispModifyType)input.ReadEnum();
				break;
			case 18u:
				DBCPath = input.ReadString();
				break;
			}
		}
	}
}
