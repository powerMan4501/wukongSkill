using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStUIWordDesc : IMessage<FUStUIWordDesc>, IMessage, IEquatable<FUStUIWordDesc>, IDeepCloneable<FUStUIWordDesc>
{
	private static readonly MessageParser<FUStUIWordDesc> _parser = new MessageParser<FUStUIWordDesc>(() => new FUStUIWordDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private string enumName_ = "";

	private string content_ = "";

	private int localizationTag_;

	public static MessageParser<FUStUIWordDesc> Parser => _parser;

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

	public string EnumName
	{
		get
		{
			return enumName_;
		}
		set
		{
			enumName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public FUStUIWordDesc()
	{
	}

	public FUStUIWordDesc(FUStUIWordDesc other)
		: this()
	{
		iD_ = other.iD_;
		enumName_ = other.enumName_;
		content_ = other.content_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStUIWordDesc Clone()
	{
		return new FUStUIWordDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStUIWordDesc);
	}

	public bool Equals(FUStUIWordDesc other)
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
		if (EnumName != other.EnumName)
		{
			return false;
		}
		if (Content != other.Content)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (EnumName.Length != 0)
		{
			num ^= EnumName.GetHashCode();
		}
		if (Content.Length != 0)
		{
			num ^= Content.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
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
		if (EnumName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(EnumName);
		}
		if (Content.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Content);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LocalizationTag);
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
		if (EnumName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EnumName);
		}
		if (Content.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Content);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStUIWordDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.EnumName.Length != 0)
			{
				EnumName = other.EnumName;
			}
			if (other.Content.Length != 0)
			{
				Content = other.Content;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				EnumName = input.ReadString();
				break;
			case 26u:
				Content = input.ReadString();
				break;
			case 32u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
