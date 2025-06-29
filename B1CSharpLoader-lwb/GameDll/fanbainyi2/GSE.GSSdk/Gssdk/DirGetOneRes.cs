using System;
using Google.Protobuf;

namespace Gssdk;

public sealed class DirGetOneRes : IMessage<DirGetOneRes>, IMessage, IEquatable<DirGetOneRes>, IDeepCloneable<DirGetOneRes>
{
	private static readonly MessageParser<DirGetOneRes> _parser = new MessageParser<DirGetOneRes>(() => new DirGetOneRes());

	private UnknownFieldSet _unknownFields;

	private ServerInfo server_;

	public static MessageParser<DirGetOneRes> Parser => _parser;

	public ServerInfo Server
	{
		get
		{
			return server_;
		}
		set
		{
			server_ = value;
		}
	}

	public DirGetOneRes()
	{
	}

	public DirGetOneRes(DirGetOneRes other)
		: this()
	{
		server_ = ((other.server_ != null) ? other.server_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DirGetOneRes Clone()
	{
		return new DirGetOneRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DirGetOneRes);
	}

	public bool Equals(DirGetOneRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Server, other.Server))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (server_ != null)
		{
			num ^= Server.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (server_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Server);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (server_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Server);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DirGetOneRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.server_ != null)
		{
			if (server_ == null)
			{
				Server = new ServerInfo();
			}
			Server.MergeFrom(other.Server);
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
			if (server_ == null)
			{
				Server = new ServerInfo();
			}
			input.ReadMessage(Server);
		}
	}
}
