using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class VersionSetServerJsonConfigRes : IMessage<VersionSetServerJsonConfigRes>, IMessage, IEquatable<VersionSetServerJsonConfigRes>, IDeepCloneable<VersionSetServerJsonConfigRes>
{
	private static readonly MessageParser<VersionSetServerJsonConfigRes> _parser = new MessageParser<VersionSetServerJsonConfigRes>(() => new VersionSetServerJsonConfigRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	public static MessageParser<VersionSetServerJsonConfigRes> Parser => _parser;

	public GssdkRet Ret
	{
		get
		{
			return ret_;
		}
		set
		{
			ret_ = value;
		}
	}

	public VersionSetServerJsonConfigRes()
	{
	}

	public VersionSetServerJsonConfigRes(VersionSetServerJsonConfigRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public VersionSetServerJsonConfigRes Clone()
	{
		return new VersionSetServerJsonConfigRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as VersionSetServerJsonConfigRes);
	}

	public bool Equals(VersionSetServerJsonConfigRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Ret, other.Ret))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ret_ != null)
		{
			num ^= Ret.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ret_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Ret);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ret_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Ret);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(VersionSetServerJsonConfigRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.ret_ != null)
		{
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			Ret.MergeFrom(other.Ret);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
				continue;
			}
			if (ret_ == null)
			{
				Ret = new GssdkRet();
			}
			input.ReadMessage(Ret);
		}
	}
}
