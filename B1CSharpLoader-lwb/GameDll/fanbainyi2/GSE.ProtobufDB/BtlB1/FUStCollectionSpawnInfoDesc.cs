using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStCollectionSpawnInfoDesc : IMessage<FUStCollectionSpawnInfoDesc>, IMessage, IEquatable<FUStCollectionSpawnInfoDesc>, IDeepCloneable<FUStCollectionSpawnInfoDesc>
{
	private static readonly MessageParser<FUStCollectionSpawnInfoDesc> _parser = new MessageParser<FUStCollectionSpawnInfoDesc>(() => new FUStCollectionSpawnInfoDesc());

	private UnknownFieldSet _unknownFields;

	private string collectionName_ = "";

	private string mapName_ = "";

	private int mapId_;

	private int groupId_;

	private string guid_ = "";

	private string subLevel_ = "";

	private int taskId_;

	private int eventId_;

	private int plusEventId_;

	private int chiefEventId_;

	public static MessageParser<FUStCollectionSpawnInfoDesc> Parser => _parser;

	public string CollectionName
	{
		get
		{
			return collectionName_;
		}
		set
		{
			collectionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MapName
	{
		get
		{
			return mapName_;
		}
		set
		{
			mapName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	public int GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	public string Guid
	{
		get
		{
			return guid_;
		}
		set
		{
			guid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string SubLevel
	{
		get
		{
			return subLevel_;
		}
		set
		{
			subLevel_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public int TaskId
	{
		get
		{
			return taskId_;
		}
		set
		{
			taskId_ = value;
		}
	}

	public int EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	public int PlusEventId
	{
		get
		{
			return plusEventId_;
		}
		set
		{
			plusEventId_ = value;
		}
	}

	public int ChiefEventId
	{
		get
		{
			return chiefEventId_;
		}
		set
		{
			chiefEventId_ = value;
		}
	}

	public FUStCollectionSpawnInfoDesc()
	{
	}

	public FUStCollectionSpawnInfoDesc(FUStCollectionSpawnInfoDesc other)
		: this()
	{
		collectionName_ = other.collectionName_;
		mapName_ = other.mapName_;
		mapId_ = other.mapId_;
		groupId_ = other.groupId_;
		guid_ = other.guid_;
		subLevel_ = other.subLevel_;
		taskId_ = other.taskId_;
		eventId_ = other.eventId_;
		plusEventId_ = other.plusEventId_;
		chiefEventId_ = other.chiefEventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStCollectionSpawnInfoDesc Clone()
	{
		return new FUStCollectionSpawnInfoDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStCollectionSpawnInfoDesc);
	}

	public bool Equals(FUStCollectionSpawnInfoDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CollectionName != other.CollectionName)
		{
			return false;
		}
		if (MapName != other.MapName)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (Guid != other.Guid)
		{
			return false;
		}
		if (SubLevel != other.SubLevel)
		{
			return false;
		}
		if (TaskId != other.TaskId)
		{
			return false;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (PlusEventId != other.PlusEventId)
		{
			return false;
		}
		if (ChiefEventId != other.ChiefEventId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CollectionName.Length != 0)
		{
			num ^= CollectionName.GetHashCode();
		}
		if (MapName.Length != 0)
		{
			num ^= MapName.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Guid.Length != 0)
		{
			num ^= Guid.GetHashCode();
		}
		if (SubLevel.Length != 0)
		{
			num ^= SubLevel.GetHashCode();
		}
		if (TaskId != 0)
		{
			num ^= TaskId.GetHashCode();
		}
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (PlusEventId != 0)
		{
			num ^= PlusEventId.GetHashCode();
		}
		if (ChiefEventId != 0)
		{
			num ^= ChiefEventId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CollectionName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(CollectionName);
		}
		if (MapName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(MapName);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(MapId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(GroupId);
		}
		if (Guid.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Guid);
		}
		if (SubLevel.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(SubLevel);
		}
		if (TaskId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(TaskId);
		}
		if (EventId != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(EventId);
		}
		if (PlusEventId != 0)
		{
			output.WriteRawTag(72);
			output.WriteInt32(PlusEventId);
		}
		if (ChiefEventId != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ChiefEventId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CollectionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(CollectionName);
		}
		if (MapName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapName);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(MapId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GroupId);
		}
		if (Guid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Guid);
		}
		if (SubLevel.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(SubLevel);
		}
		if (TaskId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(TaskId);
		}
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(EventId);
		}
		if (PlusEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PlusEventId);
		}
		if (ChiefEventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChiefEventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStCollectionSpawnInfoDesc other)
	{
		if (other != null)
		{
			if (other.CollectionName.Length != 0)
			{
				CollectionName = other.CollectionName;
			}
			if (other.MapName.Length != 0)
			{
				MapName = other.MapName;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Guid.Length != 0)
			{
				Guid = other.Guid;
			}
			if (other.SubLevel.Length != 0)
			{
				SubLevel = other.SubLevel;
			}
			if (other.TaskId != 0)
			{
				TaskId = other.TaskId;
			}
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.PlusEventId != 0)
			{
				PlusEventId = other.PlusEventId;
			}
			if (other.ChiefEventId != 0)
			{
				ChiefEventId = other.ChiefEventId;
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
				CollectionName = input.ReadString();
				break;
			case 18u:
				MapName = input.ReadString();
				break;
			case 24u:
				MapId = input.ReadInt32();
				break;
			case 32u:
				GroupId = input.ReadInt32();
				break;
			case 42u:
				Guid = input.ReadString();
				break;
			case 50u:
				SubLevel = input.ReadString();
				break;
			case 56u:
				TaskId = input.ReadInt32();
				break;
			case 64u:
				EventId = input.ReadInt32();
				break;
			case 72u:
				PlusEventId = input.ReadInt32();
				break;
			case 80u:
				ChiefEventId = input.ReadInt32();
				break;
			}
		}
	}
}
