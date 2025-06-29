using System;
using Google.Protobuf;
using ResB1;

namespace CsB1;

public sealed class CSMsgHead : IMessage<CSMsgHead>, IMessage, IEquatable<CSMsgHead>, IDeepCloneable<CSMsgHead>
{
	private static readonly MessageParser<CSMsgHead> _parser = new MessageParser<CSMsgHead>(() => new CSMsgHead());

	private UnknownFieldSet _unknownFields;

	private CSMsgCmd cmd_;

	private ByteString ud_ = ByteString.Empty;

	private uint reqTime_;

	private uint reqExpiredTime_;

	private MsgErrCode ret_;

	private ulong resTimeMs_;

	private uint srcId_;

	private uint dstId_;

	private ulong txnid_;

	private uint flags_;

	private ByteString career_ = ByteString.Empty;

	private uint version_;

	private uint time_;

	private uint protoVersion_;

	public static MessageParser<CSMsgHead> Parser => _parser;

	public CSMsgCmd Cmd
	{
		get
		{
			return cmd_;
		}
		set
		{
			cmd_ = value;
		}
	}

	public ByteString Ud
	{
		get
		{
			return ud_;
		}
		set
		{
			ud_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint ReqTime
	{
		get
		{
			return reqTime_;
		}
		set
		{
			reqTime_ = value;
		}
	}

	public uint ReqExpiredTime
	{
		get
		{
			return reqExpiredTime_;
		}
		set
		{
			reqExpiredTime_ = value;
		}
	}

	public MsgErrCode Ret
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

	public ulong ResTimeMs
	{
		get
		{
			return resTimeMs_;
		}
		set
		{
			resTimeMs_ = value;
		}
	}

	public uint SrcId
	{
		get
		{
			return srcId_;
		}
		set
		{
			srcId_ = value;
		}
	}

	public uint DstId
	{
		get
		{
			return dstId_;
		}
		set
		{
			dstId_ = value;
		}
	}

	public ulong Txnid
	{
		get
		{
			return txnid_;
		}
		set
		{
			txnid_ = value;
		}
	}

	public uint Flags
	{
		get
		{
			return flags_;
		}
		set
		{
			flags_ = value;
		}
	}

	public ByteString Career
	{
		get
		{
			return career_;
		}
		set
		{
			career_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public uint Version
	{
		get
		{
			return version_;
		}
		set
		{
			version_ = value;
		}
	}

	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	public uint ProtoVersion
	{
		get
		{
			return protoVersion_;
		}
		set
		{
			protoVersion_ = value;
		}
	}

	public CSMsgHead()
	{
	}

	public CSMsgHead(CSMsgHead other)
		: this()
	{
		cmd_ = other.cmd_;
		ud_ = other.ud_;
		reqTime_ = other.reqTime_;
		reqExpiredTime_ = other.reqExpiredTime_;
		ret_ = other.ret_;
		resTimeMs_ = other.resTimeMs_;
		srcId_ = other.srcId_;
		dstId_ = other.dstId_;
		txnid_ = other.txnid_;
		flags_ = other.flags_;
		career_ = other.career_;
		version_ = other.version_;
		time_ = other.time_;
		protoVersion_ = other.protoVersion_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgHead Clone()
	{
		return new CSMsgHead(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgHead);
	}

	public bool Equals(CSMsgHead other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Cmd != other.Cmd)
		{
			return false;
		}
		if (Ud != other.Ud)
		{
			return false;
		}
		if (ReqTime != other.ReqTime)
		{
			return false;
		}
		if (ReqExpiredTime != other.ReqExpiredTime)
		{
			return false;
		}
		if (Ret != other.Ret)
		{
			return false;
		}
		if (ResTimeMs != other.ResTimeMs)
		{
			return false;
		}
		if (SrcId != other.SrcId)
		{
			return false;
		}
		if (DstId != other.DstId)
		{
			return false;
		}
		if (Txnid != other.Txnid)
		{
			return false;
		}
		if (Flags != other.Flags)
		{
			return false;
		}
		if (Career != other.Career)
		{
			return false;
		}
		if (Version != other.Version)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (ProtoVersion != other.ProtoVersion)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Cmd != CSMsgCmd.CsCmdDefault)
		{
			num ^= Cmd.GetHashCode();
		}
		if (Ud.Length != 0)
		{
			num ^= Ud.GetHashCode();
		}
		if (ReqTime != 0)
		{
			num ^= ReqTime.GetHashCode();
		}
		if (ReqExpiredTime != 0)
		{
			num ^= ReqExpiredTime.GetHashCode();
		}
		if (Ret != MsgErrCode.ErrSuccess)
		{
			num ^= Ret.GetHashCode();
		}
		if (ResTimeMs != 0L)
		{
			num ^= ResTimeMs.GetHashCode();
		}
		if (SrcId != 0)
		{
			num ^= SrcId.GetHashCode();
		}
		if (DstId != 0)
		{
			num ^= DstId.GetHashCode();
		}
		if (Txnid != 0L)
		{
			num ^= Txnid.GetHashCode();
		}
		if (Flags != 0)
		{
			num ^= Flags.GetHashCode();
		}
		if (Career.Length != 0)
		{
			num ^= Career.GetHashCode();
		}
		if (Version != 0)
		{
			num ^= Version.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (ProtoVersion != 0)
		{
			num ^= ProtoVersion.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Cmd != CSMsgCmd.CsCmdDefault)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Cmd);
		}
		if (Ud.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteBytes(Ud);
		}
		if (ReqTime != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ReqTime);
		}
		if (ReqExpiredTime != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(ReqExpiredTime);
		}
		if (Ret != MsgErrCode.ErrSuccess)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Ret);
		}
		if (ResTimeMs != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(ResTimeMs);
		}
		if (SrcId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SrcId);
		}
		if (DstId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DstId);
		}
		if (Txnid != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(Txnid);
		}
		if (Flags != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Flags);
		}
		if (Career.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteBytes(Career);
		}
		if (Version != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Version);
		}
		if (Time != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Time);
		}
		if (ProtoVersion != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(ProtoVersion);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Cmd != CSMsgCmd.CsCmdDefault)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Cmd);
		}
		if (Ud.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Ud);
		}
		if (ReqTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ReqTime);
		}
		if (ReqExpiredTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ReqExpiredTime);
		}
		if (Ret != MsgErrCode.ErrSuccess)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Ret);
		}
		if (ResTimeMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ResTimeMs);
		}
		if (SrcId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SrcId);
		}
		if (DstId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DstId);
		}
		if (Txnid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Txnid);
		}
		if (Flags != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Flags);
		}
		if (Career.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Career);
		}
		if (Version != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Version);
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (ProtoVersion != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ProtoVersion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgHead other)
	{
		if (other != null)
		{
			if (other.Cmd != CSMsgCmd.CsCmdDefault)
			{
				Cmd = other.Cmd;
			}
			if (other.Ud.Length != 0)
			{
				Ud = other.Ud;
			}
			if (other.ReqTime != 0)
			{
				ReqTime = other.ReqTime;
			}
			if (other.ReqExpiredTime != 0)
			{
				ReqExpiredTime = other.ReqExpiredTime;
			}
			if (other.Ret != MsgErrCode.ErrSuccess)
			{
				Ret = other.Ret;
			}
			if (other.ResTimeMs != 0L)
			{
				ResTimeMs = other.ResTimeMs;
			}
			if (other.SrcId != 0)
			{
				SrcId = other.SrcId;
			}
			if (other.DstId != 0)
			{
				DstId = other.DstId;
			}
			if (other.Txnid != 0L)
			{
				Txnid = other.Txnid;
			}
			if (other.Flags != 0)
			{
				Flags = other.Flags;
			}
			if (other.Career.Length != 0)
			{
				Career = other.Career;
			}
			if (other.Version != 0)
			{
				Version = other.Version;
			}
			if (other.Time != 0)
			{
				Time = other.Time;
			}
			if (other.ProtoVersion != 0)
			{
				ProtoVersion = other.ProtoVersion;
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
				Cmd = (CSMsgCmd)input.ReadEnum();
				break;
			case 18u:
				Ud = input.ReadBytes();
				break;
			case 24u:
				ReqTime = input.ReadUInt32();
				break;
			case 32u:
				ReqExpiredTime = input.ReadUInt32();
				break;
			case 40u:
				Ret = (MsgErrCode)input.ReadEnum();
				break;
			case 48u:
				ResTimeMs = input.ReadUInt64();
				break;
			case 56u:
				SrcId = input.ReadUInt32();
				break;
			case 64u:
				DstId = input.ReadUInt32();
				break;
			case 72u:
				Txnid = input.ReadUInt64();
				break;
			case 80u:
				Flags = input.ReadUInt32();
				break;
			case 90u:
				Career = input.ReadBytes();
				break;
			case 96u:
				Version = input.ReadUInt32();
				break;
			case 104u:
				Time = input.ReadUInt32();
				break;
			case 112u:
				ProtoVersion = input.ReadUInt32();
				break;
			}
		}
	}
}
