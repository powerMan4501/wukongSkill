using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirUpdateOneReq : IMessage<DirUpdateOneReq>, IMessage, IEquatable<DirUpdateOneReq>, IDeepCloneable<DirUpdateOneReq>
{
	private static readonly MessageParser<DirUpdateOneReq> _parser = new MessageParser<DirUpdateOneReq>(() => new DirUpdateOneReq());

	private UnknownFieldSet _unknownFields;

	private ServerInfo info_;

	public static MessageParser<DirUpdateOneReq> Parser => _parser;

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

	public DirUpdateOneReq()
	{
	}

	public DirUpdateOneReq(DirUpdateOneReq other)
		: this()
	{
		info_ = ((other.info_ != null) ? other.info_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirUpdateOneReq Clone()
	{
		return new DirUpdateOneReq(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirUpdateOneReq);
	}

	public bool Equals(DirUpdateOneReq other)
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

	public void MergeFrom(DirUpdateOneReq other)
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
