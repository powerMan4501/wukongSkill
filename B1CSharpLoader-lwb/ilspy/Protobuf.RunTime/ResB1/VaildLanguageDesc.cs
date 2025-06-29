using System;
using Google.Protobuf;

namespace ResB1;

public sealed class VaildLanguageDesc : IMessage<VaildLanguageDesc>, IMessage, IEquatable<VaildLanguageDesc>, IDeepCloneable<VaildLanguageDesc>
{
	private static readonly MessageParser<VaildLanguageDesc> _parser = new MessageParser<VaildLanguageDesc>(() => new VaildLanguageDesc());

	private UnknownFieldSet _unknownFields;

	private uint id_;

	private string name_ = "";

	private string font_ = "";

	private string string_ = "";

	private uint order_;

	public static MessageParser<VaildLanguageDesc> Parser => _parser;

	public uint Id
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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Font
	{
		get
		{
			return font_;
		}
		set
		{
			font_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string String
	{
		get
		{
			return string_;
		}
		set
		{
			string_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint Order
	{
		get
		{
			return order_;
		}
		set
		{
			order_ = value;
		}
	}

	public VaildLanguageDesc()
	{
	}

	public VaildLanguageDesc(VaildLanguageDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		font_ = other.font_;
		string_ = other.string_;
		order_ = other.order_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VaildLanguageDesc Clone()
	{
		return new VaildLanguageDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VaildLanguageDesc);
	}

	public bool Equals(VaildLanguageDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (Font != other.Font)
		{
			return false;
		}
		if (String != other.String)
		{
			return false;
		}
		if (Order != other.Order)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Font.Length != 0)
		{
			num ^= Font.GetHashCode();
		}
		if (String.Length != 0)
		{
			num ^= String.GetHashCode();
		}
		if (Order != 0)
		{
			num ^= Order.GetHashCode();
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
			output.WriteUInt32(Id);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Font.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Font);
		}
		if (String.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(String);
		}
		if (Order != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Order);
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
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Font.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Font);
		}
		if (String.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(String);
		}
		if (Order != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Order);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VaildLanguageDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Font.Length != 0)
			{
				Font = other.Font;
			}
			if (other.String.Length != 0)
			{
				String = other.String;
			}
			if (other.Order != 0)
			{
				Order = other.Order;
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
				Id = input.ReadUInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				Font = input.ReadString();
				break;
			case 34u:
				String = input.ReadString();
				break;
			case 40u:
				Order = input.ReadUInt32();
				break;
			}
		}
	}
}
