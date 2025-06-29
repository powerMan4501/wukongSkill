using System;
using Google.Protobuf;

namespace CsB1;

public sealed class LoginRoleReport : IMessage<LoginRoleReport>, IMessage, IEquatable<LoginRoleReport>, IDeepCloneable<LoginRoleReport>
{
	private static readonly MessageParser<LoginRoleReport> _parser = new MessageParser<LoginRoleReport>(() => new LoginRoleReport());

	private UnknownFieldSet _unknownFields;

	private LoginRoleReportClientBase clientBase_;

	public static MessageParser<LoginRoleReport> Parser => _parser;

	public LoginRoleReportClientBase ClientBase
	{
		get
		{
			return clientBase_;
		}
		set
		{
			clientBase_ = value;
		}
	}

	public LoginRoleReport()
	{
	}

	public LoginRoleReport(LoginRoleReport other)
		: this()
	{
		clientBase_ = ((other.clientBase_ != null) ? other.clientBase_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LoginRoleReport Clone()
	{
		return new LoginRoleReport(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LoginRoleReport);
	}

	public bool Equals(LoginRoleReport other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ClientBase, other.ClientBase))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (clientBase_ != null)
		{
			num ^= ClientBase.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (clientBase_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ClientBase);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (clientBase_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ClientBase);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LoginRoleReport other)
	{
		if (other == null)
		{
			return;
		}
		if (other.clientBase_ != null)
		{
			if (clientBase_ == null)
			{
				ClientBase = new LoginRoleReportClientBase();
			}
			ClientBase.MergeFrom(other.ClientBase);
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
			if (clientBase_ == null)
			{
				ClientBase = new LoginRoleReportClientBase();
			}
			input.ReadMessage(ClientBase);
		}
	}
}
