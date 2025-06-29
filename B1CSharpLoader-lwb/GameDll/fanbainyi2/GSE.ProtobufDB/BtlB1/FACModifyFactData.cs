using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FACModifyFactData : IMessage<FACModifyFactData>, IMessage, IEquatable<FACModifyFactData>, IDeepCloneable<FACModifyFactData>
{
	private static readonly MessageParser<FACModifyFactData> _parser = new MessageParser<FACModifyFactData>(() => new FACModifyFactData());

	private UnknownFieldSet _unknownFields;

	private string keyName_ = "";

	private EACFactDataOperateType operateType_;

	private string modifyValue_ = "";

	public static MessageParser<FACModifyFactData> Parser => _parser;

	public string KeyName
	{
		get
		{
			return keyName_;
		}
		set
		{
			keyName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public EACFactDataOperateType OperateType
	{
		get
		{
			return operateType_;
		}
		set
		{
			operateType_ = value;
		}
	}

	public string ModifyValue
	{
		get
		{
			return modifyValue_;
		}
		set
		{
			modifyValue_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FACModifyFactData()
	{
	}

	public FACModifyFactData(FACModifyFactData other)
		: this()
	{
		keyName_ = other.keyName_;
		operateType_ = other.operateType_;
		modifyValue_ = other.modifyValue_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FACModifyFactData Clone()
	{
		return new FACModifyFactData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FACModifyFactData);
	}

	public bool Equals(FACModifyFactData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KeyName != other.KeyName)
		{
			return false;
		}
		if (OperateType != other.OperateType)
		{
			return false;
		}
		if (ModifyValue != other.ModifyValue)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (KeyName.Length != 0)
		{
			num ^= KeyName.GetHashCode();
		}
		if (OperateType != EACFactDataOperateType.None)
		{
			num ^= OperateType.GetHashCode();
		}
		if (ModifyValue.Length != 0)
		{
			num ^= ModifyValue.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (KeyName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(KeyName);
		}
		if (OperateType != EACFactDataOperateType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)OperateType);
		}
		if (ModifyValue.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ModifyValue);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (KeyName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(KeyName);
		}
		if (OperateType != EACFactDataOperateType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OperateType);
		}
		if (ModifyValue.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ModifyValue);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FACModifyFactData other)
	{
		if (other != null)
		{
			if (other.KeyName.Length != 0)
			{
				KeyName = other.KeyName;
			}
			if (other.OperateType != EACFactDataOperateType.None)
			{
				OperateType = other.OperateType;
			}
			if (other.ModifyValue.Length != 0)
			{
				ModifyValue = other.ModifyValue;
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
				KeyName = input.ReadString();
				break;
			case 16u:
				OperateType = (EACFactDataOperateType)input.ReadEnum();
				break;
			case 26u:
				ModifyValue = input.ReadString();
				break;
			}
		}
	}
}
