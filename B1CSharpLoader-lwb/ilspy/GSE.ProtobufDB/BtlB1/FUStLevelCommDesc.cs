using System;
using Google.Protobuf;

namespace BtlB1;

public sealed class FUStLevelCommDesc : IMessage<FUStLevelCommDesc>, IMessage, IEquatable<FUStLevelCommDesc>, IDeepCloneable<FUStLevelCommDesc>
{
	private static readonly MessageParser<FUStLevelCommDesc> _parser = new MessageParser<FUStLevelCommDesc>(() => new FUStLevelCommDesc());

	private UnknownFieldSet _unknownFields;

	private int iD_;

	private int isVersionLevel_;

	private string mapShowName_ = "";

	private string mapPath_ = "";

	private string rootQuestGraphPath_ = "";

	public static MessageParser<FUStLevelCommDesc> Parser => _parser;

	public int ID
	{
		get
		{
			return iD_;
		}
		set
		{
			iD_ = value;
		}
	}

	public int IsVersionLevel
	{
		get
		{
			return isVersionLevel_;
		}
		set
		{
			isVersionLevel_ = value;
		}
	}

	public string MapShowName
	{
		get
		{
			return mapShowName_;
		}
		set
		{
			mapShowName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string MapPath
	{
		get
		{
			return mapPath_;
		}
		set
		{
			mapPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string RootQuestGraphPath
	{
		get
		{
			return rootQuestGraphPath_;
		}
		set
		{
			rootQuestGraphPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public FUStLevelCommDesc()
	{
	}

	public FUStLevelCommDesc(FUStLevelCommDesc other)
		: this()
	{
		iD_ = other.iD_;
		isVersionLevel_ = other.isVersionLevel_;
		mapShowName_ = other.mapShowName_;
		mapPath_ = other.mapPath_;
		rootQuestGraphPath_ = other.rootQuestGraphPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FUStLevelCommDesc Clone()
	{
		return new FUStLevelCommDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as FUStLevelCommDesc);
	}

	public bool Equals(FUStLevelCommDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ID != other.ID)
		{
			return false;
		}
		if (IsVersionLevel != other.IsVersionLevel)
		{
			return false;
		}
		if (MapShowName != other.MapShowName)
		{
			return false;
		}
		if (MapPath != other.MapPath)
		{
			return false;
		}
		if (RootQuestGraphPath != other.RootQuestGraphPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ID != 0)
		{
			num ^= ID.GetHashCode();
		}
		if (IsVersionLevel != 0)
		{
			num ^= IsVersionLevel.GetHashCode();
		}
		if (MapShowName.Length != 0)
		{
			num ^= MapShowName.GetHashCode();
		}
		if (MapPath.Length != 0)
		{
			num ^= MapPath.GetHashCode();
		}
		if (RootQuestGraphPath.Length != 0)
		{
			num ^= RootQuestGraphPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ID != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ID);
		}
		if (IsVersionLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(IsVersionLevel);
		}
		if (MapShowName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(MapShowName);
		}
		if (MapPath.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(MapPath);
		}
		if (RootQuestGraphPath.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(RootQuestGraphPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ID != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ID);
		}
		if (IsVersionLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(IsVersionLevel);
		}
		if (MapShowName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapShowName);
		}
		if (MapPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MapPath);
		}
		if (RootQuestGraphPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RootQuestGraphPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FUStLevelCommDesc other)
	{
		if (other != null)
		{
			if (other.ID != 0)
			{
				ID = other.ID;
			}
			if (other.IsVersionLevel != 0)
			{
				IsVersionLevel = other.IsVersionLevel;
			}
			if (other.MapShowName.Length != 0)
			{
				MapShowName = other.MapShowName;
			}
			if (other.MapPath.Length != 0)
			{
				MapPath = other.MapPath;
			}
			if (other.RootQuestGraphPath.Length != 0)
			{
				RootQuestGraphPath = other.RootQuestGraphPath;
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
			case 8u:
				ID = input.ReadInt32();
				break;
			case 16u:
				IsVersionLevel = input.ReadInt32();
				break;
			case 26u:
				MapShowName = input.ReadString();
				break;
			case 34u:
				MapPath = input.ReadString();
				break;
			case 42u:
				RootQuestGraphPath = input.ReadString();
				break;
			}
		}
	}
}
