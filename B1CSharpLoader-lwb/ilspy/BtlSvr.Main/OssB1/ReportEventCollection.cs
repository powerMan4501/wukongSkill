using System;
using Google.Protobuf;

namespace OssB1;

public sealed class ReportEventCollection : IMessage<ReportEventCollection>, IMessage, IEquatable<ReportEventCollection>, IDeepCloneable<ReportEventCollection>
{
	private static readonly MessageParser<ReportEventCollection> _parser = new MessageParser<ReportEventCollection>(() => new ReportEventCollection());

	private UnknownFieldSet _unknownFields;

	private CollectionType type_;

	private CollectionStage stage_;

	private int id_;

	private ulong roleId_;

	public static MessageParser<ReportEventCollection> Parser => _parser;

	public CollectionType Type
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

	public CollectionStage Stage
	{
		get
		{
			return stage_;
		}
		set
		{
			stage_ = value;
		}
	}

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

	public ulong RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	public ReportEventCollection()
	{
	}

	public ReportEventCollection(ReportEventCollection other)
		: this()
	{
		type_ = other.type_;
		stage_ = other.stage_;
		id_ = other.id_;
		roleId_ = other.roleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public ReportEventCollection Clone()
	{
		return new ReportEventCollection(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as ReportEventCollection);
	}

	public bool Equals(ReportEventCollection other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (Stage != other.Stage)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Type != CollectionType.MonsterCollection)
		{
			num ^= Type.GetHashCode();
		}
		if (Stage != CollectionStage._0)
		{
			num ^= Stage.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (RoleId != 0L)
		{
			num ^= RoleId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Type != CollectionType.MonsterCollection)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		if (Stage != CollectionStage._0)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Stage);
		}
		if (Id != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(Id);
		}
		if (RoleId != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(RoleId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Type != CollectionType.MonsterCollection)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (Stage != CollectionStage._0)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Stage);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (RoleId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(ReportEventCollection other)
	{
		if (other != null)
		{
			if (other.Type != CollectionType.MonsterCollection)
			{
				Type = other.Type;
			}
			if (other.Stage != CollectionStage._0)
			{
				Stage = other.Stage;
			}
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.RoleId != 0L)
			{
				RoleId = other.RoleId;
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
				Type = (CollectionType)input.ReadEnum();
				break;
			case 16u:
				Stage = (CollectionStage)input.ReadEnum();
				break;
			case 24u:
				Id = input.ReadInt32();
				break;
			case 32u:
				RoleId = input.ReadUInt64();
				break;
			}
		}
	}
}
