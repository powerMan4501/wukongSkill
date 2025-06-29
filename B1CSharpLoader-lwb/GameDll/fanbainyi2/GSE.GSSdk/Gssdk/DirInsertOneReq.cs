using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirInsertOneReq : IMessage<DirInsertOneReq>, IMessage, IEquatable<DirInsertOneReq>, IDeepCloneable<DirInsertOneReq>
{
	private static readonly MessageParser<DirInsertOneReq> _parser = new MessageParser<DirInsertOneReq>(() => new DirInsertOneReq());

	private UnknownFieldSet _unknownFields;

	private ServerInfo info_;

	public static MessageParser<DirInsertOneReq> Parser => _parser;

	public ServerInfo Info
	{
		get
		{
			return info_;
		}
		set
		{
			info_ = value;
		}
	}

	public DirInsertOneReq()
	{
	}

	public DirInsertOneReq(DirInsertOneReq other)
		: this()
	{
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirInsertOneReq Clone()
	{
		return new DirInsertOneReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirInsertOneReq);
	}

	public bool Equals(DirInsertOneReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Info, other.Info))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (info_ != null)
		{
			num ^= Info.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (info_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Info);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (info_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Info);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirInsertOneReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.info_ != null)
		{
			if (info_ == null)
			{
				Info = new ServerInfo();
			}
			Info.MergeFrom(other.Info);
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
			if (info_ == null)
			{
				Info = new ServerInfo();
			}
			input.ReadMessage(Info);
		}
	}
}
