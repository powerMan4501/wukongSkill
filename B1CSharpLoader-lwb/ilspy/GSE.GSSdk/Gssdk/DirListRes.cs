using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Gssdk;

public sealed class DirListRes : IMessage<DirListRes>, IMessage, IEquatable<DirListRes>, IDeepCloneable<DirListRes>
{
	private static readonly MessageParser<DirListRes> _parser = new MessageParser<DirListRes>(() => new DirListRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private static readonly FieldCodec<ServerUnit> _repeated_serverList_codec = FieldCodec.ForMessage(18u, ServerUnit.Parser);

	private readonly RepeatedField<ServerUnit> serverList_ = new RepeatedField<ServerUnit>();

	public static MessageParser<DirListRes> Parser => _parser;

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

	public RepeatedField<ServerUnit> ServerList => serverList_;

	public DirListRes()
	{
	}

	public DirListRes(DirListRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		serverList_ = other.serverList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirListRes Clone()
	{
		return new DirListRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirListRes);
	}

	public bool Equals(DirListRes other)
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
		if (!serverList_.Equals(other.serverList_))
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
		num ^= serverList_.GetHashCode();
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
		serverList_.WriteTo(output, _repeated_serverList_codec);
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
		num += serverList_.CalculateSize(_repeated_serverList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirListRes other)
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
		serverList_.Add(other.serverList_);
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
				serverList_.AddEntriesFrom(input, _repeated_serverList_codec);
				break;
			}
		}
	}
}
