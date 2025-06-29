using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleData : IMessage<RoleData>, IMessage, IEquatable<RoleData>, IDeepCloneable<RoleData>
{
	private static readonly MessageParser<RoleData> _parser = new MessageParser<RoleData>(() => new RoleData());

	private UnknownFieldSet _unknownFields;

	private RoleDataCS roleCs_;

	private RoleDataClient roleClient_;

	public static MessageParser<RoleData> Parser => _parser;

	public RoleDataCS RoleCs
	{
		get
		{
			return roleCs_;
		}
		set
		{
			roleCs_ = value;
		}
	}

	public RoleDataClient RoleClient
	{
		get
		{
			return roleClient_;
		}
		set
		{
			roleClient_ = value;
		}
	}

	public RoleData()
	{
	}

	public RoleData(RoleData other)
		: this()
	{
		roleCs_ = ((other.roleCs_ != null) ? other.roleCs_.Clone() : null);
		roleClient_ = ((other.roleClient_ != null) ? other.roleClient_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleData Clone()
	{
		return new RoleData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleData);
	}

	public bool Equals(RoleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RoleCs, other.RoleCs))
		{
			return false;
		}
		if (!object.Equals(RoleClient, other.RoleClient))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (roleCs_ != null)
		{
			num ^= RoleCs.GetHashCode();
		}
		if (roleClient_ != null)
		{
			num ^= RoleClient.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (roleCs_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RoleCs);
		}
		if (roleClient_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(RoleClient);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (roleCs_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleCs);
		}
		if (roleClient_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleClient);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.roleCs_ != null)
		{
			if (roleCs_ == null)
			{
				RoleCs = new RoleDataCS();
			}
			RoleCs.MergeFrom(other.RoleCs);
		}
		if (other.roleClient_ != null)
		{
			if (roleClient_ == null)
			{
				RoleClient = new RoleDataClient();
			}
			RoleClient.MergeFrom(other.RoleClient);
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
				if (roleCs_ == null)
				{
					RoleCs = new RoleDataCS();
				}
				input.ReadMessage(RoleCs);
				break;
			case 18u:
				if (roleClient_ == null)
				{
					RoleClient = new RoleDataClient();
				}
				input.ReadMessage(RoleClient);
				break;
			}
		}
	}
}
