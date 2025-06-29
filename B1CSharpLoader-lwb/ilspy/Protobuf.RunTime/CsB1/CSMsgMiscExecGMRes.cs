using System;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgMiscExecGMRes : IMessage<CSMsgMiscExecGMRes>, IMessage, IEquatable<CSMsgMiscExecGMRes>, IDeepCloneable<CSMsgMiscExecGMRes>
{
	private static readonly MessageParser<CSMsgMiscExecGMRes> _parser = new MessageParser<CSMsgMiscExecGMRes>(() => new CSMsgMiscExecGMRes());

	private UnknownFieldSet _unknownFields;

	private string gmRes_ = "";

	public static MessageParser<CSMsgMiscExecGMRes> Parser => _parser;

	public string GmRes
	{
		get
		{
			return gmRes_;
		}
		set
		{
			gmRes_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CSMsgMiscExecGMRes()
	{
	}

	public CSMsgMiscExecGMRes(CSMsgMiscExecGMRes other)
		: this()
	{
		gmRes_ = other.gmRes_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgMiscExecGMRes Clone()
	{
		return new CSMsgMiscExecGMRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgMiscExecGMRes);
	}

	public bool Equals(CSMsgMiscExecGMRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GmRes != other.GmRes)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (GmRes.Length != 0)
		{
			num ^= GmRes.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (GmRes.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(GmRes);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (GmRes.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GmRes);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgMiscExecGMRes other)
	{
		if (other != null)
		{
			if (other.GmRes.Length != 0)
			{
				GmRes = other.GmRes;
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
				GmRes = input.ReadString();
			}
		}
	}
}
