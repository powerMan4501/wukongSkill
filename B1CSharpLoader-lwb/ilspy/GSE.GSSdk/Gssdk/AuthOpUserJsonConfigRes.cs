using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class AuthOpUserJsonConfigRes : IMessage<AuthOpUserJsonConfigRes>, IMessage, IEquatable<AuthOpUserJsonConfigRes>, IDeepCloneable<AuthOpUserJsonConfigRes>
{
	private static readonly MessageParser<AuthOpUserJsonConfigRes> _parser = new MessageParser<AuthOpUserJsonConfigRes>(() => new AuthOpUserJsonConfigRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private static readonly FieldCodec<GssdkCustomJsonConfig> _repeated_data_codec = FieldCodec.ForMessage(18u, GssdkCustomJsonConfig.Parser);

	private readonly RepeatedField<GssdkCustomJsonConfig> data_ = new RepeatedField<GssdkCustomJsonConfig>();

	public static MessageParser<AuthOpUserJsonConfigRes> Parser => _parser;

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

	public RepeatedField<GssdkCustomJsonConfig> Data => data_;

	public AuthOpUserJsonConfigRes()
	{
	}

	public AuthOpUserJsonConfigRes(AuthOpUserJsonConfigRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		data_ = other.data_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthOpUserJsonConfigRes Clone()
	{
		return new AuthOpUserJsonConfigRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthOpUserJsonConfigRes);
	}

	public bool Equals(AuthOpUserJsonConfigRes other)
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
		if (!data_.Equals(other.data_))
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
		num ^= data_.GetHashCode();
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
		data_.WriteTo(output, _repeated_data_codec);
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
		num += data_.CalculateSize(_repeated_data_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthOpUserJsonConfigRes other)
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
		data_.Add(other.data_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (ret_ == null)
				{
					Ret = new GssdkRet();
				}
				input.ReadMessage(Ret);
				break;
			case 18u:
				data_.AddEntriesFrom(input, _repeated_data_codec);
				break;
			}
		}
	}
}
