using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class UnitDropRuleDesc : IMessage<UnitDropRuleDesc>, IMessage, IEquatable<UnitDropRuleDesc>, IDeepCloneable<UnitDropRuleDesc>
{
	private static readonly MessageParser<UnitDropRuleDesc> _parser = new MessageParser<UnitDropRuleDesc>(() => new UnitDropRuleDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int limitQuestId_;

	private QuestStage limitQuestState_;

	private static readonly FieldCodec<DropItem> _repeated_drop_codec = FieldCodec.ForMessage(34u, DropItem.Parser);

	private readonly RepeatedField<DropItem> drop_ = new RepeatedField<DropItem>();

	public static MessageParser<UnitDropRuleDesc> Parser => _parser;

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

	public int LimitQuestId
	{
		get
		{
			return limitQuestId_;
		}
		set
		{
			limitQuestId_ = value;
		}
	}

	public QuestStage LimitQuestState
	{
		get
		{
			return limitQuestState_;
		}
		set
		{
			limitQuestState_ = value;
		}
	}

	public RepeatedField<DropItem> Drop => drop_;

	public UnitDropRuleDesc()
	{
	}

	public UnitDropRuleDesc(UnitDropRuleDesc other)
		: this()
	{
		id_ = other.id_;
		limitQuestId_ = other.limitQuestId_;
		limitQuestState_ = other.limitQuestState_;
		drop_ = other.drop_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UnitDropRuleDesc Clone()
	{
		return new UnitDropRuleDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UnitDropRuleDesc);
	}

	public bool Equals(UnitDropRuleDesc other)
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
		if (LimitQuestId != other.LimitQuestId)
		{
			return false;
		}
		if (LimitQuestState != other.LimitQuestState)
		{
			return false;
		}
		if (!drop_.Equals(other.drop_))
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
		if (LimitQuestId != 0)
		{
			num ^= LimitQuestId.GetHashCode();
		}
		if (LimitQuestState != QuestStage.Default)
		{
			num ^= LimitQuestState.GetHashCode();
		}
		num ^= drop_.GetHashCode();
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
		if (LimitQuestId != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(LimitQuestId);
		}
		if (LimitQuestState != QuestStage.Default)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)LimitQuestState);
		}
		drop_.WriteTo(output, _repeated_drop_codec);
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
		if (LimitQuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LimitQuestId);
		}
		if (LimitQuestState != QuestStage.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LimitQuestState);
		}
		num += drop_.CalculateSize(_repeated_drop_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UnitDropRuleDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.LimitQuestId != 0)
			{
				LimitQuestId = other.LimitQuestId;
			}
			if (other.LimitQuestState != QuestStage.Default)
			{
				LimitQuestState = other.LimitQuestState;
			}
			drop_.Add(other.drop_);
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
				LimitQuestId = input.ReadInt32();
				break;
			case 24u:
				LimitQuestState = (QuestStage)input.ReadEnum();
				break;
			case 34u:
				drop_.AddEntriesFrom(input, _repeated_drop_codec);
				break;
			}
		}
	}
}
