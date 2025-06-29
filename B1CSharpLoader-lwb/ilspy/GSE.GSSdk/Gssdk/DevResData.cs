using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DevResData : IMessage<DevResData>, IMessage, IEquatable<DevResData>, IDeepCloneable<DevResData>
{
	private static readonly MessageParser<DevResData> _parser = new MessageParser<DevResData>(() => new DevResData());

	private UnknownFieldSet _unknownFields;

	private string resId_ = "";

	private string name_ = "";

	private string loc_ = "";

	public static MessageParser<DevResData> Parser => _parser;

	public string ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string Loc
	{
		get
		{
			return loc_;
		}
		set
		{
			loc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public DevResData()
	{
	}

	public DevResData(DevResData other)
		: this()
	{
		resId_ = other.resId_;
		name_ = other.name_;
		loc_ = other.loc_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DevResData Clone()
	{
		return new DevResData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DevResData);
	}

	public bool Equals(DevResData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Loc != other.Loc)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ResId.Length != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Loc.Length != 0)
		{
			num ^= Loc.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ResId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ResId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (Loc.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Loc);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ResId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ResId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Loc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Loc);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DevResData other)
	{
		if (other != null)
		{
			if (other.ResId.Length != 0)
			{
				ResId = other.ResId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Loc.Length != 0)
			{
				Loc = other.Loc;
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
				ResId = input.ReadString();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 26u:
				Loc = input.ReadString();
				break;
			}
		}
	}
}
