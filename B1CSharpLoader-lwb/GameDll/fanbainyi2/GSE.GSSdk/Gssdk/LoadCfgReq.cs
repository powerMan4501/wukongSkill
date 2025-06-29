using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class LoadCfgReq : IMessage<LoadCfgReq>, IMessage, IEquatable<LoadCfgReq>, IDeepCloneable<LoadCfgReq>
{
	private static readonly MessageParser<LoadCfgReq> _parser = new MessageParser<LoadCfgReq>(() => new LoadCfgReq());

	private UnknownFieldSet _unknownFields;

	private string resv_ = "";

	public static MessageParser<LoadCfgReq> Parser => _parser;

	public string Resv
	{
		get
		{
			return resv_;
		}
		set
		{
			resv_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LoadCfgReq()
	{
	}

	public LoadCfgReq(LoadCfgReq other)
		: this()
	{
		resv_ = other.resv_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoadCfgReq Clone()
	{
		return new LoadCfgReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoadCfgReq);
	}

	public bool Equals(LoadCfgReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Resv != other.Resv)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Resv.Length != 0)
		{
			num ^= Resv.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Resv.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Resv);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Resv.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Resv);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoadCfgReq other)
	{
		if (other != null)
		{
			if (other.Resv.Length != 0)
			{
				Resv = other.Resv;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				Resv = input.ReadString();
			}
		}
	}
}
