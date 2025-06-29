using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FPlayFXByResID : IMessage<FPlayFXByResID>, IMessage, IEquatable<FPlayFXByResID>, IDeepCloneable<FPlayFXByResID>
{
	private static readonly MessageParser<FPlayFXByResID> _parser = new MessageParser<FPlayFXByResID>(() => new FPlayFXByResID());

	private UnknownFieldSet _unknownFields;

	private int resID_;

	private string fXPathByDBC_ = "";

	public static MessageParser<FPlayFXByResID> Parser => _parser;

	public int ResID
	{
		get
		{
			return resID_;
		}
		set
		{
			resID_ = value;
		}
	}

	public string FXPathByDBC
	{
		get
		{
			return fXPathByDBC_;
		}
		set
		{
			fXPathByDBC_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FPlayFXByResID()
	{
	}

	public FPlayFXByResID(FPlayFXByResID other)
		: this()
	{
		resID_ = other.resID_;
		fXPathByDBC_ = other.fXPathByDBC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FPlayFXByResID Clone()
	{
		return new FPlayFXByResID(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FPlayFXByResID);
	}

	public bool Equals(FPlayFXByResID other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ResID != other.ResID)
		{
			return false;
		}
		if (FXPathByDBC != other.FXPathByDBC)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ResID != 0)
		{
			num ^= ResID.GetHashCode();
		}
		if (FXPathByDBC.Length != 0)
		{
			num ^= FXPathByDBC.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ResID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ResID);
		}
		if (FXPathByDBC.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(FXPathByDBC);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ResID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResID);
		}
		if (FXPathByDBC.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(FXPathByDBC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FPlayFXByResID other)
	{
		if (other != null)
		{
			if (other.ResID != 0)
			{
				ResID = other.ResID;
			}
			if (other.FXPathByDBC.Length != 0)
			{
				FXPathByDBC = other.FXPathByDBC;
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
				ResID = input.ReadInt32();
				break;
			case 18u:
				FXPathByDBC = input.ReadString();
				break;
			}
		}
	}
}
