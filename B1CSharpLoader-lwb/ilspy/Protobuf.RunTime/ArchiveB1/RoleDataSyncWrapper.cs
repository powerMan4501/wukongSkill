using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleDataSyncWrapper : IMessage<RoleDataSyncWrapper>, IMessage, IEquatable<RoleDataSyncWrapper>, IDeepCloneable<RoleDataSyncWrapper>
{
	private static readonly MessageParser<RoleDataSyncWrapper> _parser = new MessageParser<RoleDataSyncWrapper>(() => new RoleDataSyncWrapper());

	private UnknownFieldSet _unknownFields;

	private int syncFlag_;

	private int syncIdx_;

	private RoleDataCSSyncWrapper roleCs_;

	private RoleDataClientSyncWrapper roleClient_;

	public static MessageParser<RoleDataSyncWrapper> Parser => _parser;

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

	public RoleDataCSSyncWrapper RoleCs
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

	public RoleDataClientSyncWrapper RoleClient
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

	public RoleDataSyncWrapper()
	{
	}

	public RoleDataSyncWrapper(RoleDataSyncWrapper other)
		: this()
	{
		syncFlag_ = other.syncFlag_;
		syncIdx_ = other.syncIdx_;
		roleCs_ = ((other.roleCs_ != null) ? other.roleCs_.Clone() : null);
		roleClient_ = ((other.roleClient_ != null) ? other.roleClient_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleDataSyncWrapper Clone()
	{
		return new RoleDataSyncWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleDataSyncWrapper);
	}

	public bool Equals(RoleDataSyncWrapper other)
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
		if (SyncFlag != 0)
		{
			num ^= SyncFlag.GetHashCode();
		}
		if (SyncIdx != 0)
		{
			num ^= SyncIdx.GetHashCode();
		}
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
		if (roleCs_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RoleCs);
		}
		if (roleClient_ != null)
		{
			output.WriteRawTag(34);
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
		if (SyncFlag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncFlag);
		}
		if (SyncIdx != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SyncIdx);
		}
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

	public void MergeFrom(RoleDataSyncWrapper other)
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
		if (other.roleCs_ != null)
		{
			if (roleCs_ == null)
			{
				RoleCs = new RoleDataCSSyncWrapper();
			}
			RoleCs.MergeFrom(other.RoleCs);
		}
		if (other.roleClient_ != null)
		{
			if (roleClient_ == null)
			{
				RoleClient = new RoleDataClientSyncWrapper();
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
			case 8u:
				SyncFlag = input.ReadInt32();
				break;
			case 16u:
				SyncIdx = input.ReadInt32();
				break;
			case 26u:
				if (roleCs_ == null)
				{
					RoleCs = new RoleDataCSSyncWrapper();
				}
				input.ReadMessage(RoleCs);
				break;
			case 34u:
				if (roleClient_ == null)
				{
					RoleClient = new RoleDataClientSyncWrapper();
				}
				input.ReadMessage(RoleClient);
				break;
			}
		}
	}
}
