using System;
using Google.Protobuf;

namespace CommB1;

public sealed class AwolMsgPlayerCommandSyncWrapper : IMessage<AwolMsgPlayerCommandSyncWrapper>, IMessage, IEquatable<AwolMsgPlayerCommandSyncWrapper>, IDeepCloneable<AwolMsgPlayerCommandSyncWrapper>
{
	private static readonly MessageParser<AwolMsgPlayerCommandSyncWrapper> _parser = new MessageParser<AwolMsgPlayerCommandSyncWrapper>(() => new AwolMsgPlayerCommandSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private PlayerCommandTypeSyncWrapper cmdType_;

	private PlayerCommandParamSyncWrapper param_;

	public static MessageParser<AwolMsgPlayerCommandSyncWrapper> Parser => _parser;

	public int SyncFlag
	{
		get
		{
			return syncFlag_;
		}
		set
		{
			syncFlag_ = value;
		}
	}

	public int SyncIdx
	{
		get
		{
			return syncIdx_;
		}
		set
		{
			syncIdx_ = value;
		}
	}

	public PlayerCommandTypeSyncWrapper CmdType
	{
		get
		{
			return cmdType_;
		}
		set
		{
			cmdType_ = value;
		}
	}

	public PlayerCommandParamSyncWrapper Param
	{
		get
		{
			return param_;
		}
		set
		{
			param_ = value;
		}
	}

	public AwolMsgPlayerCommandSyncWrapper()
	{
	}

	public AwolMsgPlayerCommandSyncWrapper(AwolMsgPlayerCommandSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		cmdType_ = ((other.cmdType_ != null) ? other.cmdType_.Clone() : null);
		param_ = ((other.param_ != null) ? other.param_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AwolMsgPlayerCommandSyncWrapper Clone()
	{
		return new AwolMsgPlayerCommandSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AwolMsgPlayerCommandSyncWrapper);
	}

	public bool Equals(AwolMsgPlayerCommandSyncWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SyncFlag != other.SyncFlag)
		{
			return false;
		}
		if (SyncIdx != other.SyncIdx)
		{
			return false;
		}
		if (!object.Equals(CmdType, other.CmdType))
		{
			return false;
		}
		if (!object.Equals(Param, other.Param))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
		if (cmdType_ != null)
		{
			num ^= CmdType.GetHashCode();
		}
		if (param_ != null)
		{
			num ^= Param.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (SyncFlag != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SyncIdx);
		}
		if (cmdType_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CmdType);
		}
		if (param_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Param);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
		if (cmdType_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CmdType);
		}
		if (param_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Param);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AwolMsgPlayerCommandSyncWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SyncFlag != 0)
		{
			SyncFlag = other.SyncFlag;
		}
		if (other.SyncIdx != 0)
		{
			SyncIdx = other.SyncIdx;
		}
		if (other.cmdType_ != null)
		{
			if (cmdType_ == null)
			{
				CmdType = new PlayerCommandTypeSyncWrapper();
			}
			CmdType.MergeFrom(other.CmdType);
		}
		if (other.param_ != null)
		{
			if (param_ == null)
			{
				Param = new PlayerCommandParamSyncWrapper();
			}
			Param.MergeFrom(other.Param);
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (cmdType_ == null)
				{
					CmdType = new PlayerCommandTypeSyncWrapper();
				}
				input.ReadMessage(CmdType);
				break;
			case 34u:
				if (param_ == null)
				{
					Param = new PlayerCommandParamSyncWrapper();
				}
				input.ReadMessage(Param);
				break;
			}
		}
	}
}
