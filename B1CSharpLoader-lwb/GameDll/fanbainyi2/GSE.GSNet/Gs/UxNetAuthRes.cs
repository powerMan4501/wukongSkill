using System;
using Google.Protobuf;

namespace Gs;

public sealed class UxNetAuthRes : IMessage<UxNetAuthRes>, IMessage, IEquatable<UxNetAuthRes>, IDeepCloneable<UxNetAuthRes>
{
	private static readonly MessageParser<UxNetAuthRes> _parser = new MessageParser<UxNetAuthRes>(() => new UxNetAuthRes());

	private UnknownFieldSet _unknownFields;

	private UxNetAuthResultType ret_;

	private int subCode_;

	private UxNetAuthToken token_;

	private ulong roleId_;

	public static MessageParser<UxNetAuthRes> Parser => _parser;

	public UxNetAuthResultType Ret
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

	public int SubCode
	{
		get
		{
			return subCode_;
		}
		set
		{
			subCode_ = value;
		}
	}

	public UxNetAuthToken Token
	{
		get
		{
			return token_;
		}
		set
		{
			token_ = value;
		}
	}

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public UxNetAuthRes()
	{
	}

	public UxNetAuthRes(UxNetAuthRes other)
		: this()
	{
		ret_ = other.ret_;
		subCode_ = other.subCode_;
		token_ = ((other.token_ != null) ? other.token_.Clone() : null);
		roleId_ = other.roleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UxNetAuthRes Clone()
	{
		return new UxNetAuthRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UxNetAuthRes);
	}

	public bool Equals(UxNetAuthRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Ret != other.Ret)
		{
			return false;
		}
		if (SubCode != other.SubCode)
		{
			return false;
		}
		if (!object.Equals(Token, other.Token))
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Ret != UxNetAuthResultType.UxnetAuthRetSuccess)
		{
			num ^= Ret.GetHashCode();
		}
		if (SubCode != 0)
		{
			num ^= SubCode.GetHashCode();
		}
		if (token_ != null)
		{
			num ^= Token.GetHashCode();
		}
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Ret != UxNetAuthResultType.UxnetAuthRetSuccess)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Ret);
		}
		if (SubCode != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SubCode);
		}
		if (token_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Token);
		}
		if (RoleId != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(RoleId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Ret != UxNetAuthResultType.UxnetAuthRetSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Ret);
		}
		if (SubCode != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SubCode);
		}
		if (token_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Token);
		}
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UxNetAuthRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Ret != UxNetAuthResultType.UxnetAuthRetSuccess)
		{
			Ret = other.Ret;
		}
		if (other.SubCode != 0)
		{
			SubCode = other.SubCode;
		}
		if (other.token_ != null)
		{
			if (token_ == null)
			{
				Token = new UxNetAuthToken();
			}
			Token.MergeFrom(other.Token);
		}
		if (other.RoleId != 0L)
		{
			RoleId = other.RoleId;
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
			case 8u:
				Ret = (UxNetAuthResultType)input.ReadEnum();
				break;
			case 16u:
				SubCode = input.ReadInt32();
				break;
			case 26u:
				if (token_ == null)
				{
					Token = new UxNetAuthToken();
				}
				input.ReadMessage(Token);
				break;
			case 32u:
				RoleId = input.ReadUInt64();
				break;
			}
		}
	}
}
