using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStSettingClassNameDesc : IMessage<FUStSettingClassNameDesc>, IMessage, IEquatable<FUStSettingClassNameDesc>, IDeepCloneable<FUStSettingClassNameDesc>
{
	private static readonly MessageParser<FUStSettingClassNameDesc> _parser = new MessageParser<FUStSettingClassNameDesc>(() => new FUStSettingClassNameDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string gName_ = "";

	public static MessageParser<FUStSettingClassNameDesc> Parser => _parser;

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

	public string GName
	{
		get
		{
			return gName_;
		}
		set
		{
			gName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStSettingClassNameDesc()
	{
	}

	public FUStSettingClassNameDesc(FUStSettingClassNameDesc other)
		: this()
	{
		iD_ = other.iD_;
		gName_ = other.gName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStSettingClassNameDesc Clone()
	{
		return new FUStSettingClassNameDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStSettingClassNameDesc);
	}

	public bool Equals(FUStSettingClassNameDesc other)
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
		if (GName != other.GName)
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
		if (GName.Length != 0)
		{
			num ^= GName.GetHashCode();
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
		if (GName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GName);
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
		if (GName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStSettingClassNameDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.GName.Length != 0)
			{
				GName = other.GName;
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
				GName = input.ReadString();
				break;
			}
		}
	}
}
