using System;
using Google.Protobuf;

namespace ResB1;

public sealed class RandNameDesc : IMessage<RandNameDesc>, IMessage, IEquatable<RandNameDesc>, IDeepCloneable<RandNameDesc>
{
	private static readonly MessageParser<RandNameDesc> _parser = new MessageParser<RandNameDesc>(() => new RandNameDesc());

	private UnknownFieldSet _unknownFields;

	private RandNameType randtype_;

	private string namea_ = "";

	private string nameb_ = "";

	private string namec_ = "";

	private string named_ = "";

	public static MessageParser<RandNameDesc> Parser => _parser;

	public RandNameType Randtype
	{
		get
		{
			return randtype_;
		}
		set
		{
			randtype_ = value;
		}
	}

	public string Namea
	{
		get
		{
			return namea_;
		}
		set
		{
			namea_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Nameb
	{
		get
		{
			return nameb_;
		}
		set
		{
			nameb_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Namec
	{
		get
		{
			return namec_;
		}
		set
		{
			namec_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Named
	{
		get
		{
			return named_;
		}
		set
		{
			named_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RandNameDesc()
	{
	}

	public RandNameDesc(RandNameDesc other)
		: this()
	{
		randtype_ = other.randtype_;
		namea_ = other.namea_;
		nameb_ = other.nameb_;
		namec_ = other.namec_;
		named_ = other.named_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RandNameDesc Clone()
	{
		return new RandNameDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RandNameDesc);
	}

	public bool Equals(RandNameDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Randtype != other.Randtype)
		{
			return false;
		}
		if (Namea != other.Namea)
		{
			return false;
		}
		if (Nameb != other.Nameb)
		{
			return false;
		}
		if (Namec != other.Namec)
		{
			return false;
		}
		if (Named != other.Named)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Randtype != RandNameType.None)
		{
			num ^= Randtype.GetHashCode();
		}
		if (Namea.Length != 0)
		{
			num ^= Namea.GetHashCode();
		}
		if (Nameb.Length != 0)
		{
			num ^= Nameb.GetHashCode();
		}
		if (Namec.Length != 0)
		{
			num ^= Namec.GetHashCode();
		}
		if (Named.Length != 0)
		{
			num ^= Named.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Randtype != RandNameType.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Randtype);
		}
		if (Namea.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Namea);
		}
		if (Nameb.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Nameb);
		}
		if (Namec.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Namec);
		}
		if (Named.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Named);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Randtype != RandNameType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Randtype);
		}
		if (Namea.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Namea);
		}
		if (Nameb.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Nameb);
		}
		if (Namec.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Namec);
		}
		if (Named.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Named);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RandNameDesc other)
	{
		if (other != null)
		{
			if (other.Randtype != RandNameType.None)
			{
				Randtype = other.Randtype;
			}
			if (other.Namea.Length != 0)
			{
				Namea = other.Namea;
			}
			if (other.Nameb.Length != 0)
			{
				Nameb = other.Nameb;
			}
			if (other.Namec.Length != 0)
			{
				Namec = other.Namec;
			}
			if (other.Named.Length != 0)
			{
				Named = other.Named;
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
				Randtype = (RandNameType)input.ReadEnum();
				break;
			case 18u:
				Namea = input.ReadString();
				break;
			case 26u:
				Nameb = input.ReadString();
				break;
			case 34u:
				Namec = input.ReadString();
				break;
			case 42u:
				Named = input.ReadString();
				break;
			}
		}
	}
}
