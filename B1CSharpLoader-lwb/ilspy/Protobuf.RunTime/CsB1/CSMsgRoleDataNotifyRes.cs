using System;
using ArchiveB1;
using Google.Protobuf;

namespace CsB1;

public sealed class CSMsgRoleDataNotifyRes : IMessage<CSMsgRoleDataNotifyRes>, IMessage, IEquatable<CSMsgRoleDataNotifyRes>, IDeepCloneable<CSMsgRoleDataNotifyRes>
{
	private static readonly MessageParser<CSMsgRoleDataNotifyRes> _parser = new MessageParser<CSMsgRoleDataNotifyRes>(() => new CSMsgRoleDataNotifyRes());

	private UnknownFieldSet _unknownFields;

	private GSChangeReason changeReason_;

	private RoleDataSyncWrapper update_;

	public static MessageParser<CSMsgRoleDataNotifyRes> Parser => _parser;

	public GSChangeReason ChangeReason
	{
		get
		{
			return changeReason_;
		}
		set
		{
			changeReason_ = value;
		}
	}

	public RoleDataSyncWrapper Update
	{
		get
		{
			return update_;
		}
		set
		{
			update_ = value;
		}
	}

	public CSMsgRoleDataNotifyRes()
	{
	}

	public CSMsgRoleDataNotifyRes(CSMsgRoleDataNotifyRes other)
		: this()
	{
		changeReason_ = ((other.changeReason_ != null) ? other.changeReason_.Clone() : null);
		update_ = ((other.update_ != null) ? other.update_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CSMsgRoleDataNotifyRes Clone()
	{
		return new CSMsgRoleDataNotifyRes(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CSMsgRoleDataNotifyRes);
	}

	public bool Equals(CSMsgRoleDataNotifyRes other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(ChangeReason, other.ChangeReason))
		{
			return false;
		}
		if (!object.Equals(Update, other.Update))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (changeReason_ != null)
		{
			num ^= ChangeReason.GetHashCode();
		}
		if (update_ != null)
		{
			num ^= Update.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (changeReason_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(ChangeReason);
		}
		if (update_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Update);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (changeReason_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ChangeReason);
		}
		if (update_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Update);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(CSMsgRoleDataNotifyRes other)
	{
		if (other == null)
		{
			return;
		}
		if (other.changeReason_ != null)
		{
			if (changeReason_ == null)
			{
				ChangeReason = new GSChangeReason();
			}
			ChangeReason.MergeFrom(other.ChangeReason);
		}
		if (other.update_ != null)
		{
			if (update_ == null)
			{
				Update = new RoleDataSyncWrapper();
			}
			Update.MergeFrom(other.Update);
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
				if (changeReason_ == null)
				{
					ChangeReason = new GSChangeReason();
				}
				input.ReadMessage(ChangeReason);
				break;
			case 18u:
				if (update_ == null)
				{
					Update = new RoleDataSyncWrapper();
				}
				input.ReadMessage(Update);
				break;
			}
		}
	}
}
