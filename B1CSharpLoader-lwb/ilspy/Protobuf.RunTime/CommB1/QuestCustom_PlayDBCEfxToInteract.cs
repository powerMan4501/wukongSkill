using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_PlayDBCEfxToInteract : IMessage<QuestCustom_PlayDBCEfxToInteract>, IMessage, IEquatable<QuestCustom_PlayDBCEfxToInteract>, IDeepCloneable<QuestCustom_PlayDBCEfxToInteract>
{
	private static readonly MessageParser<QuestCustom_PlayDBCEfxToInteract> _parser = new MessageParser<QuestCustom_PlayDBCEfxToInteract>(() => new QuestCustom_PlayDBCEfxToInteract());

	private UnknownFieldSet _unknownFields;

	private string observeActorGuid_ = "";

	private string dbcEfxPath_ = "";

	public static MessageParser<QuestCustom_PlayDBCEfxToInteract> Parser => _parser;

	public string ObserveActorGuid
	{
		get
		{
			return observeActorGuid_;
		}
		set
		{
			observeActorGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string DbcEfxPath
	{
		get
		{
			return dbcEfxPath_;
		}
		set
		{
			dbcEfxPath_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public QuestCustom_PlayDBCEfxToInteract()
	{
	}

	public QuestCustom_PlayDBCEfxToInteract(QuestCustom_PlayDBCEfxToInteract other)
		: this()
	{
		observeActorGuid_ = other.observeActorGuid_;
		dbcEfxPath_ = other.dbcEfxPath_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_PlayDBCEfxToInteract Clone()
	{
		return new QuestCustom_PlayDBCEfxToInteract(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_PlayDBCEfxToInteract);
	}

	public bool Equals(QuestCustom_PlayDBCEfxToInteract other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObserveActorGuid != other.ObserveActorGuid)
		{
			return false;
		}
		if (DbcEfxPath != other.DbcEfxPath)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObserveActorGuid.Length != 0)
		{
			num ^= ObserveActorGuid.GetHashCode();
		}
		if (DbcEfxPath.Length != 0)
		{
			num ^= DbcEfxPath.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObserveActorGuid.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ObserveActorGuid);
		}
		if (DbcEfxPath.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(DbcEfxPath);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObserveActorGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ObserveActorGuid);
		}
		if (DbcEfxPath.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DbcEfxPath);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_PlayDBCEfxToInteract other)
	{
		if (other != null)
		{
			if (other.ObserveActorGuid.Length != 0)
			{
				ObserveActorGuid = other.ObserveActorGuid;
			}
			if (other.DbcEfxPath.Length != 0)
			{
				DbcEfxPath = other.DbcEfxPath;
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
				ObserveActorGuid = input.ReadString();
				break;
			case 18u:
				DbcEfxPath = input.ReadString();
				break;
			}
		}
	}
}
