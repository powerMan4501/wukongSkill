using System;
using BtlB1;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class PastMemoryDesc : IMessage<PastMemoryDesc>, IMessage, IEquatable<PastMemoryDesc>, IDeepCloneable<PastMemoryDesc>
{
	private static readonly MessageParser<PastMemoryDesc> _parser = new MessageParser<PastMemoryDesc>(() => new PastMemoryDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int sortId_;

	private int levelId_;

	private string title_ = "";

	private string desc_ = "";

	private ResourceType resourceType_;

	private int resourceId_;

	private static readonly FieldCodec<NPCInfo> _repeated_nPCInfoList_codec = FieldCodec.ForMessage(66u, NPCInfo.Parser);

	private readonly RepeatedField<NPCInfo> nPCInfoList_ = new RepeatedField<NPCInfo>();

	public static MessageParser<PastMemoryDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public int LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Desc
	{
		get
		{
			return desc_;
		}
		set
		{
			desc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public ResourceType ResourceType
	{
		get
		{
			return resourceType_;
		}
		set
		{
			resourceType_ = value;
		}
	}

	public int ResourceId
	{
		get
		{
			return resourceId_;
		}
		set
		{
			resourceId_ = value;
		}
	}

	public RepeatedField<NPCInfo> NPCInfoList => nPCInfoList_;

	public PastMemoryDesc()
	{
	}

	public PastMemoryDesc(PastMemoryDesc other)
		: this()
	{
		id_ = other.id_;
		sortId_ = other.sortId_;
		levelId_ = other.levelId_;
		title_ = other.title_;
		desc_ = other.desc_;
		resourceType_ = other.resourceType_;
		resourceId_ = other.resourceId_;
		nPCInfoList_ = other.nPCInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public PastMemoryDesc Clone()
	{
		return new PastMemoryDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as PastMemoryDesc);
	}

	public bool Equals(PastMemoryDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (ResourceType != other.ResourceType)
		{
			return false;
		}
		if (ResourceId != other.ResourceId)
		{
			return false;
		}
		if (!nPCInfoList_.Equals(other.nPCInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (ResourceType != ResourceType.Seq)
		{
			num ^= ResourceType.GetHashCode();
		}
		if (ResourceId != 0)
		{
			num ^= ResourceId.GetHashCode();
		}
		num ^= nPCInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(SortId);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LevelId);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Title);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Desc);
		}
		if (ResourceType != ResourceType.Seq)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)ResourceType);
		}
		if (ResourceId != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(ResourceId);
		}
		nPCInfoList_.WriteTo(output, _repeated_nPCInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (ResourceType != ResourceType.Seq)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ResourceType);
		}
		if (ResourceId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ResourceId);
		}
		num += nPCInfoList_.CalculateSize(_repeated_nPCInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(PastMemoryDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.Title.Length != 0)
			{
				Title = other.Title;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.ResourceType != ResourceType.Seq)
			{
				ResourceType = other.ResourceType;
			}
			if (other.ResourceId != 0)
			{
				ResourceId = other.ResourceId;
			}
			nPCInfoList_.Add(other.nPCInfoList_);
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
				Id = input.ReadInt32();
				break;
			case 16u:
				SortId = input.ReadInt32();
				break;
			case 24u:
				LevelId = input.ReadInt32();
				break;
			case 34u:
				Title = input.ReadString();
				break;
			case 42u:
				Desc = input.ReadString();
				break;
			case 48u:
				ResourceType = (ResourceType)input.ReadEnum();
				break;
			case 56u:
				ResourceId = input.ReadInt32();
				break;
			case 66u:
				nPCInfoList_.AddEntriesFrom(input, _repeated_nPCInfoList_codec);
				break;
			}
		}
	}
}
