using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class DataChangeLog : IMessage<DataChangeLog>, IMessage, IEquatable<DataChangeLog>, IDeepCloneable<DataChangeLog>
{
	private static readonly MessageParser<DataChangeLog> _parser = new MessageParser<DataChangeLog>(() => new DataChangeLog());

	private UnknownFieldSet _unknownFields;

	private int roleLevelOld_;

	private int roleLevelNew_;

	public static MessageParser<DataChangeLog> Parser => _parser;

	public int RoleLevelOld
	{
		get
		{
			return roleLevelOld_;
		}
		set
		{
			roleLevelOld_ = value;
		}
	}

	public int RoleLevelNew
	{
		get
		{
			return roleLevelNew_;
		}
		set
		{
			roleLevelNew_ = value;
		}
	}

	public DataChangeLog()
	{
	}

	public DataChangeLog(DataChangeLog other)
		: this()
	{
		roleLevelOld_ = other.roleLevelOld_;
		roleLevelNew_ = other.roleLevelNew_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public DataChangeLog Clone()
	{
		return new DataChangeLog(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as DataChangeLog);
	}

	public bool Equals(DataChangeLog other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleLevelOld != other.RoleLevelOld)
		{
			return false;
		}
		if (RoleLevelNew != other.RoleLevelNew)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (RoleLevelOld != 0)
		{
			num ^= RoleLevelOld.GetHashCode();
		}
		if (RoleLevelNew != 0)
		{
			num ^= RoleLevelNew.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (RoleLevelOld != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(RoleLevelOld);
		}
		if (RoleLevelNew != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(RoleLevelNew);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (RoleLevelOld != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoleLevelOld);
		}
		if (RoleLevelNew != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(RoleLevelNew);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(DataChangeLog other)
	{
		if (other != null)
		{
			if (other.RoleLevelOld != 0)
			{
				RoleLevelOld = other.RoleLevelOld;
			}
			if (other.RoleLevelNew != 0)
			{
				RoleLevelNew = other.RoleLevelNew;
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
				RoleLevelOld = input.ReadInt32();
				break;
			case 16u:
				RoleLevelNew = input.ReadInt32();
				break;
			}
		}
	}
}
