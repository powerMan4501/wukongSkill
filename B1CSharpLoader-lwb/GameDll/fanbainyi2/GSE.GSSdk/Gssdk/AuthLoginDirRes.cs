using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class AuthLoginDirRes : IMessage<AuthLoginDirRes>, IMessage, IEquatable<AuthLoginDirRes>, IDeepCloneable<AuthLoginDirRes>
{
	private static readonly MessageParser<AuthLoginDirRes> _parser = new MessageParser<AuthLoginDirRes>(() => new AuthLoginDirRes());

	private UnknownFieldSet _unknownFields;

	private GssdkRet ret_;

	private AuthLoginRes login_;

	private DirListRes dir_;

	public static MessageParser<AuthLoginDirRes> Parser => _parser;

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

	public AuthLoginRes Login
	{
		get
		{
			return login_;
		}
		set
		{
			login_ = value;
		}
	}

	public DirListRes Dir
	{
		get
		{
			return dir_;
		}
		set
		{
			dir_ = value;
		}
	}

	public AuthLoginDirRes()
	{
	}

	public AuthLoginDirRes(AuthLoginDirRes other)
		: this()
	{
		ret_ = ((other.ret_ != null) ? other.ret_.Clone() : null);
		login_ = ((other.login_ != null) ? other.login_.Clone() : null);
		dir_ = ((other.dir_ != null) ? other.dir_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AuthLoginDirRes Clone()
	{
		return new AuthLoginDirRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AuthLoginDirRes);
	}

	public bool Equals(AuthLoginDirRes other)
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
		if (!object.Equals(Login, other.Login))
		{
			return false;
		}
		if (!object.Equals(Dir, other.Dir))
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
		if (login_ != null)
		{
			num ^= Login.GetHashCode();
		}
		if (dir_ != null)
		{
			num ^= Dir.GetHashCode();
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
		if (login_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Login);
		}
		if (dir_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Dir);
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
		if (login_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Login);
		}
		if (dir_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Dir);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AuthLoginDirRes other)
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
		if (other.login_ != null)
		{
			if (login_ == null)
			{
				Login = new AuthLoginRes();
			}
			Login.MergeFrom(other.Login);
		}
		if (other.dir_ != null)
		{
			if (dir_ == null)
			{
				Dir = new DirListRes();
			}
			Dir.MergeFrom(other.Dir);
		}
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
				if (login_ == null)
				{
					Login = new AuthLoginRes();
				}
				input.ReadMessage(Login);
				break;
			case 26u:
				if (dir_ == null)
				{
					Dir = new DirListRes();
				}
				input.ReadMessage(Dir);
				break;
			}
		}
	}
}
