using System;
using Google.Protobuf;

namespace ResB1;

public sealed class SceneMonsterNameplateDesc : IMessage<SceneMonsterNameplateDesc>, IMessage, IEquatable<SceneMonsterNameplateDesc>, IDeepCloneable<SceneMonsterNameplateDesc>
{
	private static readonly MessageParser<SceneMonsterNameplateDesc> _parser = new MessageParser<SceneMonsterNameplateDesc>(() => new SceneMonsterNameplateDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private NameplateType type_;

	private int levelId_;

	private string name_ = "";

	private int localizationTag_;

	public static MessageParser<SceneMonsterNameplateDesc> Parser => _parser;

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

	public NameplateType Type
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

	public SceneMonsterNameplateDesc()
	{
	}

	public SceneMonsterNameplateDesc(SceneMonsterNameplateDesc other)
		: this()
	{
		id_ = other.id_;
		type_ = other.type_;
		levelId_ = other.levelId_;
		name_ = other.name_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public SceneMonsterNameplateDesc Clone()
	{
		return new SceneMonsterNameplateDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as SceneMonsterNameplateDesc);
	}

	public bool Equals(SceneMonsterNameplateDesc other)
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
		if (Type != other.Type)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (Name != other.Name)
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
		if (Type != NameplateType.Min)
		{
			num ^= Type.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
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
		if (Type != NameplateType.Min)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Type);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LevelId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Name);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(40);
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
		if (Type != NameplateType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
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

	public void MergeFrom(SceneMonsterNameplateDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Type != NameplateType.Min)
			{
				Type = other.Type;
			}
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
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
				Type = (NameplateType)input.ReadEnum();
				break;
			case 24u:
				LevelId = input.ReadInt32();
				break;
			case 34u:
				Name = input.ReadString();
				break;
			case 40u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
