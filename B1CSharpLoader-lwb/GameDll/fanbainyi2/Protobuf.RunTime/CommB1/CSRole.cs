using System;
using ArchiveB1;
using Google.Protobuf;

namespace CommB1;

public sealed class CSRole : IMessage<CSRole>, IMessage, IEquatable<CSRole>, IDeepCloneable<CSRole>
{
	private static readonly MessageParser<CSRole> _parser = new MessageParser<CSRole>(() => new CSRole());

	private UnknownFieldSet _unknownFields;

	private RoleData roleData_;

	public static MessageParser<CSRole> Parser => _parser;

	public RoleData RoleData
	{
		get
		{
			return roleData_;
		}
		set
		{
			roleData_ = value;
		}
	}

	public CSRole()
	{
	}

	public CSRole(CSRole other)
		: this()
	{
		roleData_ = ((other.roleData_ != null) ? other.roleData_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSRole Clone()
	{
		return new CSRole(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSRole);
	}

	public bool Equals(CSRole other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RoleData, other.RoleData))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (roleData_ != null)
		{
			num ^= RoleData.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (roleData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(RoleData);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (roleData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleData);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSRole other)
	{
		if (other == null)
		{
			return;
		}
		if (other.roleData_ != null)
		{
			if (roleData_ == null)
			{
				RoleData = new RoleData();
			}
			RoleData.MergeFrom(other.RoleData);
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
			if (roleData_ == null)
			{
				RoleData = new RoleData();
			}
			input.ReadMessage(RoleData);
		}
	}
}
