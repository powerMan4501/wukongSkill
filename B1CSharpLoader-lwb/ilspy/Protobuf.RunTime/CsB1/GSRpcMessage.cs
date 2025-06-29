using System;
using Google.Protobuf;

namespace CsB1;

public sealed class GSRpcMessage : IMessage<GSRpcMessage>, IMessage, IEquatable<GSRpcMessage>, IDeepCloneable<GSRpcMessage>
{
	private static readonly MessageParser<GSRpcMessage> _parser = new MessageParser<GSRpcMessage>(() => new GSRpcMessage());

	private UnknownFieldSet _unknownFields;

	private ulong pkgTxnid_;

	private bool fromServer_;

	private uint pkgNum_;

	private uint pkgSeq_;

	private ByteString data_ = ByteString.Empty;

	public static MessageParser<GSRpcMessage> Parser => _parser;

	public ulong PkgTxnid
	{
		get
		{
			return pkgTxnid_;
		}
		set
		{
			pkgTxnid_ = value;
		}
	}

	public bool FromServer
	{
		get
		{
			return fromServer_;
		}
		set
		{
			fromServer_ = value;
		}
	}

	public uint PkgNum
	{
		get
		{
			return pkgNum_;
		}
		set
		{
			pkgNum_ = value;
		}
	}

	public uint PkgSeq
	{
		get
		{
			return pkgSeq_;
		}
		set
		{
			pkgSeq_ = value;
		}
	}

	public ByteString Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GSRpcMessage()
	{
	}

	public GSRpcMessage(GSRpcMessage other)
		: this()
	{
		pkgTxnid_ = other.pkgTxnid_;
		fromServer_ = other.fromServer_;
		pkgNum_ = other.pkgNum_;
		pkgSeq_ = other.pkgSeq_;
		data_ = other.data_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GSRpcMessage Clone()
	{
		return new GSRpcMessage(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GSRpcMessage);
	}

	public bool Equals(GSRpcMessage other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PkgTxnid != other.PkgTxnid)
		{
			return false;
		}
		if (FromServer != other.FromServer)
		{
			return false;
		}
		if (PkgNum != other.PkgNum)
		{
			return false;
		}
		if (PkgSeq != other.PkgSeq)
		{
			return false;
		}
		if (Data != other.Data)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (PkgTxnid != 0L)
		{
			num ^= PkgTxnid.GetHashCode();
		}
		if (FromServer)
		{
			num ^= FromServer.GetHashCode();
		}
		if (PkgNum != 0)
		{
			num ^= PkgNum.GetHashCode();
		}
		if (PkgSeq != 0)
		{
			num ^= PkgSeq.GetHashCode();
		}
		if (Data.Length != 0)
		{
			num ^= Data.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (PkgTxnid != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(PkgTxnid);
		}
		if (FromServer)
		{
			output.WriteRawTag(16);
			output.WriteBool(FromServer);
		}
		if (PkgNum != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PkgNum);
		}
		if (PkgSeq != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PkgSeq);
		}
		if (Data.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteBytes(Data);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (PkgTxnid != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PkgTxnid);
		}
		if (FromServer)
		{
			num += 2;
		}
		if (PkgNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PkgNum);
		}
		if (PkgSeq != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PkgSeq);
		}
		if (Data.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GSRpcMessage other)
	{
		if (other != null)
		{
			if (other.PkgTxnid != 0L)
			{
				PkgTxnid = other.PkgTxnid;
			}
			if (other.FromServer)
			{
				FromServer = other.FromServer;
			}
			if (other.PkgNum != 0)
			{
				PkgNum = other.PkgNum;
			}
			if (other.PkgSeq != 0)
			{
				PkgSeq = other.PkgSeq;
			}
			if (other.Data.Length != 0)
			{
				Data = other.Data;
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
				PkgTxnid = input.ReadUInt64();
				break;
			case 16u:
				FromServer = input.ReadBool();
				break;
			case 24u:
				PkgNum = input.ReadUInt32();
				break;
			case 32u:
				PkgSeq = input.ReadUInt32();
				break;
			case 42u:
				Data = input.ReadBytes();
				break;
			}
		}
	}
}
