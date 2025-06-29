using System;
using Google.Protobuf;

namespace CommB1;

public sealed class CalliopeCustom_ManagedInteractor : IMessage<CalliopeCustom_ManagedInteractor>, IMessage, IEquatable<CalliopeCustom_ManagedInteractor>, IDeepCloneable<CalliopeCustom_ManagedInteractor>
{
	private static readonly MessageParser<CalliopeCustom_ManagedInteractor> _parser = new MessageParser<CalliopeCustom_ManagedInteractor>(() => new CalliopeCustom_ManagedInteractor());

	private UnknownFieldSet _unknownFields;

	private string objGuid_ = "";

	private string groupId_ = "";

	public static MessageParser<CalliopeCustom_ManagedInteractor> Parser => _parser;

	public string ObjGuid
	{
		get
		{
			return objGuid_;
		}
		set
		{
			objGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public CalliopeCustom_ManagedInteractor()
	{
	}

	public CalliopeCustom_ManagedInteractor(CalliopeCustom_ManagedInteractor other)
		: this()
	{
		objGuid_ = other.objGuid_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CalliopeCustom_ManagedInteractor Clone()
	{
		return new CalliopeCustom_ManagedInteractor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CalliopeCustom_ManagedInteractor);
	}

	public bool Equals(CalliopeCustom_ManagedInteractor other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObjGuid != other.ObjGuid)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObjGuid.Length != 0)
		{
			num ^= ObjGuid.GetHashCode();
		}
		if (GroupId.Length != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObjGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ObjGuid);
		}
		if (GroupId.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GroupId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObjGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObjGuid);
		}
		if (GroupId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CalliopeCustom_ManagedInteractor other)
	{
		if (other != null)
		{
			if (other.ObjGuid.Length != 0)
			{
				ObjGuid = other.ObjGuid;
			}
			if (other.GroupId.Length != 0)
			{
				GroupId = other.GroupId;
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
			case 10u:
				ObjGuid = input.ReadString();
				break;
			case 18u:
				GroupId = input.ReadString();
				break;
			}
		}
	}
}
