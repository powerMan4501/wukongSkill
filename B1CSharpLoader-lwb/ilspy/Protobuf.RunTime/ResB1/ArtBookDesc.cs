using System;
using Google.Protobuf;

namespace ResB1;

public sealed class ArtBookDesc : IMessage<ArtBookDesc>, IMessage, IEquatable<ArtBookDesc>, IDeepCloneable<ArtBookDesc>
{
	private static readonly MessageParser<ArtBookDesc> _parser = new MessageParser<ArtBookDesc>(() => new ArtBookDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int sortId_;

	private string name_ = "";

	private int levelId_;

	private ArtbookType type_;

	private int chapterId_;

	private int localizationTag_;

	public static MessageParser<ArtBookDesc> Parser => _parser;

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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public ArtbookType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	public int ChapterId
	{
		get
		{
			return chapterId_;
		}
		set
		{
			chapterId_ = value;
		}
	}

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public ArtBookDesc()
	{
	}

	public ArtBookDesc(ArtBookDesc other)
		: this()
	{
		id_ = other.id_;
		sortId_ = other.sortId_;
		name_ = other.name_;
		levelId_ = other.levelId_;
		type_ = other.type_;
		chapterId_ = other.chapterId_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ArtBookDesc Clone()
	{
		return new ArtBookDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ArtBookDesc);
	}

	public bool Equals(ArtBookDesc other)
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
		if (Name != other.Name)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Type != ArtbookType.None)
		{
			num ^= Type.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Name);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(LevelId);
		}
		if (Type != ArtbookType.None)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Type);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(ChapterId);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LocalizationTag);
		}
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (Type != ArtbookType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ArtBookDesc other)
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
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.Type != ArtbookType.None)
			{
				Type = other.Type;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
				Id = input.ReadInt32();
				break;
			case 16u:
				SortId = input.ReadInt32();
				break;
			case 26u:
				Name = input.ReadString();
				break;
			case 32u:
				LevelId = input.ReadInt32();
				break;
			case 40u:
				Type = (ArtbookType)input.ReadEnum();
				break;
			case 48u:
				ChapterId = input.ReadInt32();
				break;
			case 56u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
