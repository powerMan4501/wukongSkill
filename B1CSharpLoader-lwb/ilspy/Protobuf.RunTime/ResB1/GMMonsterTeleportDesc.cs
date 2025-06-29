using System;
using Google.Protobuf;

namespace ResB1;

public sealed class GMMonsterTeleportDesc : IMessage<GMMonsterTeleportDesc>, IMessage, IEquatable<GMMonsterTeleportDesc>, IDeepCloneable<GMMonsterTeleportDesc>
{
	private static readonly MessageParser<GMMonsterTeleportDesc> _parser = new MessageParser<GMMonsterTeleportDesc>(() => new GMMonsterTeleportDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string name_ = "";

	private int levelId_;

	private GMTeleportType type_;

	private GmVector position_;

	private GmVector rotation_;

	private GmVector cameraRotation_;

	private string archiveName_ = "";

	public static MessageParser<GMMonsterTeleportDesc> Parser => _parser;

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

	public GMTeleportType Type
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

	public GmVector Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public GmVector Rotation
	{
		get
		{
			return rotation_;
		}
		set
		{
			rotation_ = value;
		}
	}

	public GmVector CameraRotation
	{
		get
		{
			return cameraRotation_;
		}
		set
		{
			cameraRotation_ = value;
		}
	}

	public string ArchiveName
	{
		get
		{
			return archiveName_;
		}
		set
		{
			archiveName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public GMMonsterTeleportDesc()
	{
	}

	public GMMonsterTeleportDesc(GMMonsterTeleportDesc other)
		: this()
	{
		id_ = other.id_;
		name_ = other.name_;
		levelId_ = other.levelId_;
		type_ = other.type_;
		position_ = ((other.position_ != null) ? other.position_.Clone() : null);
		rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
		cameraRotation_ = ((other.cameraRotation_ != null) ? other.cameraRotation_.Clone() : null);
		archiveName_ = other.archiveName_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GMMonsterTeleportDesc Clone()
	{
		return new GMMonsterTeleportDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GMMonsterTeleportDesc);
	}

	public bool Equals(GMMonsterTeleportDesc other)
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
		if (!object.Equals(Position, other.Position))
		{
			return false;
		}
		if (!object.Equals(Rotation, other.Rotation))
		{
			return false;
		}
		if (!object.Equals(CameraRotation, other.CameraRotation))
		{
			return false;
		}
		if (ArchiveName != other.ArchiveName)
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
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Type != GMTeleportType.Teleport)
		{
			num ^= Type.GetHashCode();
		}
		if (position_ != null)
		{
			num ^= Position.GetHashCode();
		}
		if (rotation_ != null)
		{
			num ^= Rotation.GetHashCode();
		}
		if (cameraRotation_ != null)
		{
			num ^= CameraRotation.GetHashCode();
		}
		if (ArchiveName.Length != 0)
		{
			num ^= ArchiveName.GetHashCode();
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
		if (Name.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(Name);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(LevelId);
		}
		if (Type != GMTeleportType.Teleport)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Type);
		}
		if (position_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Position);
		}
		if (rotation_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(Rotation);
		}
		if (cameraRotation_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(CameraRotation);
		}
		if (ArchiveName.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(ArchiveName);
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
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (Type != GMTeleportType.Teleport)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (position_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Position);
		}
		if (rotation_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Rotation);
		}
		if (cameraRotation_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CameraRotation);
		}
		if (ArchiveName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ArchiveName);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GMMonsterTeleportDesc other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.Name.Length != 0)
		{
			Name = other.Name;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		if (other.Type != GMTeleportType.Teleport)
		{
			Type = other.Type;
		}
		if (other.position_ != null)
		{
			if (position_ == null)
			{
				Position = new GmVector();
			}
			Position.MergeFrom(other.Position);
		}
		if (other.rotation_ != null)
		{
			if (rotation_ == null)
			{
				Rotation = new GmVector();
			}
			Rotation.MergeFrom(other.Rotation);
		}
		if (other.cameraRotation_ != null)
		{
			if (cameraRotation_ == null)
			{
				CameraRotation = new GmVector();
			}
			CameraRotation.MergeFrom(other.CameraRotation);
		}
		if (other.ArchiveName.Length != 0)
		{
			ArchiveName = other.ArchiveName;
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
				Id = input.ReadInt32();
				break;
			case 18u:
				Name = input.ReadString();
				break;
			case 24u:
				LevelId = input.ReadInt32();
				break;
			case 32u:
				Type = (GMTeleportType)input.ReadEnum();
				break;
			case 42u:
				if (position_ == null)
				{
					Position = new GmVector();
				}
				input.ReadMessage(Position);
				break;
			case 50u:
				if (rotation_ == null)
				{
					Rotation = new GmVector();
				}
				input.ReadMessage(Rotation);
				break;
			case 58u:
				if (cameraRotation_ == null)
				{
					CameraRotation = new GmVector();
				}
				input.ReadMessage(CameraRotation);
				break;
			case 66u:
				ArchiveName = input.ReadString();
				break;
			}
		}
	}
}
