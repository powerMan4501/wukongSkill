using System;
using Google.Protobuf;

namespace GurCalliopeState;

public sealed class CalliopeCustom_FTamerFamilyMatchChildInfo : IMessage<CalliopeCustom_FTamerFamilyMatchChildInfo>, IMessage, IEquatable<CalliopeCustom_FTamerFamilyMatchChildInfo>, IDeepCloneable<CalliopeCustom_FTamerFamilyMatchChildInfo>
{
	private static readonly MessageParser<CalliopeCustom_FTamerFamilyMatchChildInfo> _parser = new MessageParser<CalliopeCustom_FTamerFamilyMatchChildInfo>(() => new CalliopeCustom_FTamerFamilyMatchChildInfo());

	private UnknownFieldSet _unknownFields;

	private int filter_;

	private int matchSocketType_;

	private string socketName_ = "";

	private int resId_;

	private string nickName_ = "";

	private int buffId_;

	public static MessageParser<CalliopeCustom_FTamerFamilyMatchChildInfo> Parser => _parser;

	public int Filter
	{
		get
		{
			return filter_;
		}
		set
		{
			filter_ = value;
		}
	}

	public int MatchSocketType
	{
		get
		{
			return matchSocketType_;
		}
		set
		{
			matchSocketType_ = value;
		}
	}

	public string SocketName
	{
		get
		{
			return socketName_;
		}
		set
		{
			socketName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int ResId
	{
		get
		{
			return resId_;
		}
		set
		{
			resId_ = value;
		}
	}

	public string NickName
	{
		get
		{
			return nickName_;
		}
		set
		{
			nickName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int BuffId
	{
		get
		{
			return buffId_;
		}
		set
		{
			buffId_ = value;
		}
	}

	public CalliopeCustom_FTamerFamilyMatchChildInfo()
	{
	}

	public CalliopeCustom_FTamerFamilyMatchChildInfo(CalliopeCustom_FTamerFamilyMatchChildInfo other)
		: this()
	{
		filter_ = other.filter_;
		matchSocketType_ = other.matchSocketType_;
		socketName_ = other.socketName_;
		resId_ = other.resId_;
		nickName_ = other.nickName_;
		buffId_ = other.buffId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_FTamerFamilyMatchChildInfo Clone()
	{
		return new CalliopeCustom_FTamerFamilyMatchChildInfo(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_FTamerFamilyMatchChildInfo);
	}

	public bool Equals(CalliopeCustom_FTamerFamilyMatchChildInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Filter != other.Filter)
		{
			return false;
		}
		if (MatchSocketType != other.MatchSocketType)
		{
			return false;
		}
		if (SocketName != other.SocketName)
		{
			return false;
		}
		if (ResId != other.ResId)
		{
			return false;
		}
		if (NickName != other.NickName)
		{
			return false;
		}
		if (BuffId != other.BuffId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Filter != 0)
		{
			num ^= Filter.GetHashCode();
		}
		if (MatchSocketType != 0)
		{
			num ^= MatchSocketType.GetHashCode();
		}
		if (SocketName.Length != 0)
		{
			num ^= SocketName.GetHashCode();
		}
		if (ResId != 0)
		{
			num ^= ResId.GetHashCode();
		}
		if (NickName.Length != 0)
		{
			num ^= NickName.GetHashCode();
		}
		if (BuffId != 0)
		{
			num ^= BuffId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Filter != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Filter);
		}
		if (MatchSocketType != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(MatchSocketType);
		}
		if (SocketName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(SocketName);
		}
		if (ResId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ResId);
		}
		if (NickName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(NickName);
		}
		if (BuffId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(BuffId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Filter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Filter);
		}
		if (MatchSocketType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MatchSocketType);
		}
		if (SocketName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SocketName);
		}
		if (ResId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResId);
		}
		if (NickName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(NickName);
		}
		if (BuffId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BuffId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_FTamerFamilyMatchChildInfo other)
	{
		if (other != null)
		{
			if (other.Filter != 0)
			{
				Filter = other.Filter;
			}
			if (other.MatchSocketType != 0)
			{
				MatchSocketType = other.MatchSocketType;
			}
			if (other.SocketName.Length != 0)
			{
				SocketName = other.SocketName;
			}
			if (other.ResId != 0)
			{
				ResId = other.ResId;
			}
			if (other.NickName.Length != 0)
			{
				NickName = other.NickName;
			}
			if (other.BuffId != 0)
			{
				BuffId = other.BuffId;
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
				Filter = input.ReadInt32();
				break;
			case 16u:
				MatchSocketType = input.ReadInt32();
				break;
			case 26u:
				SocketName = input.ReadString();
				break;
			case 32u:
				ResId = input.ReadInt32();
				break;
			case 42u:
				NickName = input.ReadString();
				break;
			case 48u:
				BuffId = input.ReadInt32();
				break;
			}
		}
	}
}
