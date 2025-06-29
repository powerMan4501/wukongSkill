using System;
using Google.Protobuf;
using Google.Protobuf.Collections;
using ResB1;

namespace CsB1;

public sealed class GSChangeReason : IMessage<GSChangeReason>, IMessage, IEquatable<GSChangeReason>, IDeepCloneable<GSChangeReason>
{
	private static readonly MessageParser<GSChangeReason> _parser = new MessageParser<GSChangeReason>(() => new GSChangeReason());

	private UnknownFieldSet _unknownFields;

	private OPReason reason_;

	private static readonly FieldCodec<long> _repeated_intParam_codec = FieldCodec.ForInt64(18u);

	private readonly RepeatedField<long> intParam_ = new RepeatedField<long>();

	private ulong rpcTxnId_;

	private OPReason exReason_;

	public static MessageParser<GSChangeReason> Parser => _parser;

	public OPReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	public RepeatedField<long> IntParam => intParam_;

	public ulong RpcTxnId
	{
		get
		{
			return rpcTxnId_;
		}
		set
		{
			rpcTxnId_ = value;
		}
	}

	public OPReason ExReason
	{
		get
		{
			return exReason_;
		}
		set
		{
			exReason_ = value;
		}
	}

	public GSChangeReason()
	{
	}

	public GSChangeReason(GSChangeReason other)
		: this()
	{
		reason_ = other.reason_;
		intParam_ = other.intParam_.Clone();
		rpcTxnId_ = other.rpcTxnId_;
		exReason_ = other.exReason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GSChangeReason Clone()
	{
		return new GSChangeReason(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GSChangeReason);
	}

	public bool Equals(GSChangeReason other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (!intParam_.Equals(other.intParam_))
		{
			return false;
		}
		if (RpcTxnId != other.RpcTxnId)
		{
			return false;
		}
		if (ExReason != other.ExReason)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Reason != OPReason.None)
		{
			num ^= Reason.GetHashCode();
		}
		num ^= intParam_.GetHashCode();
		if (RpcTxnId != 0L)
		{
			num ^= RpcTxnId.GetHashCode();
		}
		if (ExReason != OPReason.None)
		{
			num ^= ExReason.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Reason != OPReason.None)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Reason);
		}
		intParam_.WriteTo(output, _repeated_intParam_codec);
		if (RpcTxnId != 0L)
		{
			output.WriteRawTag(24);
			output.WriteUInt64(RpcTxnId);
		}
		if (ExReason != OPReason.None)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ExReason);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Reason != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		num += intParam_.CalculateSize(_repeated_intParam_codec);
		if (RpcTxnId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RpcTxnId);
		}
		if (ExReason != OPReason.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ExReason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GSChangeReason other)
	{
		if (other != null)
		{
			if (other.Reason != OPReason.None)
			{
				Reason = other.Reason;
			}
			intParam_.Add(other.intParam_);
			if (other.RpcTxnId != 0L)
			{
				RpcTxnId = other.RpcTxnId;
			}
			if (other.ExReason != OPReason.None)
			{
				ExReason = other.ExReason;
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
				Reason = (OPReason)input.ReadEnum();
				break;
			case 16u:
			case 18u:
				intParam_.AddEntriesFrom(input, _repeated_intParam_codec);
				break;
			case 24u:
				RpcTxnId = input.ReadUInt64();
				break;
			case 32u:
				ExReason = (OPReason)input.ReadEnum();
				break;
			}
		}
	}
}
