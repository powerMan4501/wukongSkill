using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_ConditionQuery : IMessage<MovieCustom_ConditionQuery>, IMessage, IEquatable<MovieCustom_ConditionQuery>, IDeepCloneable<MovieCustom_ConditionQuery>
{
	private static readonly MessageParser<MovieCustom_ConditionQuery> _parser = new MessageParser<MovieCustom_ConditionQuery>(() => new MovieCustom_ConditionQuery());

	private UnknownFieldSet _unknownFields;

	private int conditionQueryType_;

	private string groupUnitGuid_ = "";

	public static MessageParser<MovieCustom_ConditionQuery> Parser => _parser;

	public int ConditionQueryType
	{
		get
		{
			return conditionQueryType_;
		}
		set
		{
			conditionQueryType_ = value;
		}
	}

	public string GroupUnitGuid
	{
		get
		{
			return groupUnitGuid_;
		}
		set
		{
			groupUnitGuid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public MovieCustom_ConditionQuery()
	{
	}

	public MovieCustom_ConditionQuery(MovieCustom_ConditionQuery other)
		: this()
	{
		conditionQueryType_ = other.conditionQueryType_;
		groupUnitGuid_ = other.groupUnitGuid_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_ConditionQuery Clone()
	{
		return new MovieCustom_ConditionQuery(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_ConditionQuery);
	}

	public bool Equals(MovieCustom_ConditionQuery other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ConditionQueryType != other.ConditionQueryType)
		{
			return false;
		}
		if (GroupUnitGuid != other.GroupUnitGuid)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ConditionQueryType != 0)
		{
			num ^= ConditionQueryType.GetHashCode();
		}
		if (GroupUnitGuid.Length != 0)
		{
			num ^= GroupUnitGuid.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ConditionQueryType != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ConditionQueryType);
		}
		if (GroupUnitGuid.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(GroupUnitGuid);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ConditionQueryType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ConditionQueryType);
		}
		if (GroupUnitGuid.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(GroupUnitGuid);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_ConditionQuery other)
	{
		if (other != null)
		{
			if (other.ConditionQueryType != 0)
			{
				ConditionQueryType = other.ConditionQueryType;
			}
			if (other.GroupUnitGuid.Length != 0)
			{
				GroupUnitGuid = other.GroupUnitGuid;
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
				ConditionQueryType = input.ReadInt32();
				break;
			case 18u:
				GroupUnitGuid = input.ReadString();
				break;
			}
		}
	}
}
