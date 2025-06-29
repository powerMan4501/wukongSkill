using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class CardDesc : IMessage<CardDesc>, IMessage, IEquatable<CardDesc>, IDeepCloneable<CardDesc>
{
	private static readonly MessageParser<CardDesc> _parser = new MessageParser<CardDesc>(() => new CardDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private string unitName_ = "";

	private int sortId_;

	private MonsterType unitType_;

	private string unitPoetry_ = "";

	private string storyBrief_ = "";

	private static readonly FieldCodec<CardStory> _repeated_cardStory_codec = FieldCodec.ForMessage(58u, ResB1.CardStory.Parser);

	private readonly RepeatedField<CardStory> cardStory_ = new RepeatedField<CardStory>();

	private SignStyle unitSignStyle_;

	private CardUnlockType cardUnlockType_;

	private static readonly FieldCodec<int> _repeated_cardIndexId_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> cardIndexId_ = new RepeatedField<int>();

	private YesNoType skipDropUI_;

	private int displayChapter_;

	private int localizationTag_;

	public static MessageParser<CardDesc> Parser => _parser;

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

	public string UnitName
	{
		get
		{
			return unitName_;
		}
		set
		{
			unitName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public MonsterType UnitType
	{
		get
		{
			return unitType_;
		}
		set
		{
			unitType_ = value;
		}
	}

	public string UnitPoetry
	{
		get
		{
			return unitPoetry_;
		}
		set
		{
			unitPoetry_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string StoryBrief
	{
		get
		{
			return storyBrief_;
		}
		set
		{
			storyBrief_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public RepeatedField<CardStory> CardStory => cardStory_;

	public SignStyle UnitSignStyle
	{
		get
		{
			return unitSignStyle_;
		}
		set
		{
			unitSignStyle_ = value;
		}
	}

	public CardUnlockType CardUnlockType
	{
		get
		{
			return cardUnlockType_;
		}
		set
		{
			cardUnlockType_ = value;
		}
	}

	public RepeatedField<int> CardIndexId => cardIndexId_;

	public YesNoType SkipDropUI
	{
		get
		{
			return skipDropUI_;
		}
		set
		{
			skipDropUI_ = value;
		}
	}

	public int DisplayChapter
	{
		get
		{
			return displayChapter_;
		}
		set
		{
			displayChapter_ = value;
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

	public CardDesc()
	{
	}

	public CardDesc(CardDesc other)
		: this()
	{
		id_ = other.id_;
		unitName_ = other.unitName_;
		sortId_ = other.sortId_;
		unitType_ = other.unitType_;
		unitPoetry_ = other.unitPoetry_;
		storyBrief_ = other.storyBrief_;
		cardStory_ = other.cardStory_.Clone();
		unitSignStyle_ = other.unitSignStyle_;
		cardUnlockType_ = other.cardUnlockType_;
		cardIndexId_ = other.cardIndexId_.Clone();
		skipDropUI_ = other.skipDropUI_;
		displayChapter_ = other.displayChapter_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public CardDesc Clone()
	{
		return new CardDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as CardDesc);
	}

	public bool Equals(CardDesc other)
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
		if (UnitName != other.UnitName)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (UnitType != other.UnitType)
		{
			return false;
		}
		if (UnitPoetry != other.UnitPoetry)
		{
			return false;
		}
		if (StoryBrief != other.StoryBrief)
		{
			return false;
		}
		if (!cardStory_.Equals(other.cardStory_))
		{
			return false;
		}
		if (UnitSignStyle != other.UnitSignStyle)
		{
			return false;
		}
		if (CardUnlockType != other.CardUnlockType)
		{
			return false;
		}
		if (!cardIndexId_.Equals(other.cardIndexId_))
		{
			return false;
		}
		if (SkipDropUI != other.SkipDropUI)
		{
			return false;
		}
		if (DisplayChapter != other.DisplayChapter)
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
		if (UnitName.Length != 0)
		{
			num ^= UnitName.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (UnitType != MonsterType.Boss)
		{
			num ^= UnitType.GetHashCode();
		}
		if (UnitPoetry.Length != 0)
		{
			num ^= UnitPoetry.GetHashCode();
		}
		if (StoryBrief.Length != 0)
		{
			num ^= StoryBrief.GetHashCode();
		}
		num ^= cardStory_.GetHashCode();
		if (UnitSignStyle != SignStyle.Default)
		{
			num ^= UnitSignStyle.GetHashCode();
		}
		if (CardUnlockType != CardUnlockType.Task)
		{
			num ^= CardUnlockType.GetHashCode();
		}
		num ^= cardIndexId_.GetHashCode();
		if (SkipDropUI != YesNoType.No)
		{
			num ^= SkipDropUI.GetHashCode();
		}
		if (DisplayChapter != 0)
		{
			num ^= DisplayChapter.GetHashCode();
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
		if (UnitName.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(UnitName);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(SortId);
		}
		if (UnitType != MonsterType.Boss)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)UnitType);
		}
		if (UnitPoetry.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(UnitPoetry);
		}
		if (StoryBrief.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(StoryBrief);
		}
		cardStory_.WriteTo(output, _repeated_cardStory_codec);
		if (UnitSignStyle != SignStyle.Default)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)UnitSignStyle);
		}
		if (CardUnlockType != CardUnlockType.Task)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)CardUnlockType);
		}
		cardIndexId_.WriteTo(output, _repeated_cardIndexId_codec);
		if (SkipDropUI != YesNoType.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)SkipDropUI);
		}
		if (DisplayChapter != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(DisplayChapter);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(104);
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
		if (UnitName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitName);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (UnitType != MonsterType.Boss)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnitType);
		}
		if (UnitPoetry.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(UnitPoetry);
		}
		if (StoryBrief.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StoryBrief);
		}
		num += cardStory_.CalculateSize(_repeated_cardStory_codec);
		if (UnitSignStyle != SignStyle.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnitSignStyle);
		}
		if (CardUnlockType != CardUnlockType.Task)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CardUnlockType);
		}
		num += cardIndexId_.CalculateSize(_repeated_cardIndexId_codec);
		if (SkipDropUI != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SkipDropUI);
		}
		if (DisplayChapter != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DisplayChapter);
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

	public void MergeFrom(CardDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.UnitName.Length != 0)
			{
				UnitName = other.UnitName;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.UnitType != MonsterType.Boss)
			{
				UnitType = other.UnitType;
			}
			if (other.UnitPoetry.Length != 0)
			{
				UnitPoetry = other.UnitPoetry;
			}
			if (other.StoryBrief.Length != 0)
			{
				StoryBrief = other.StoryBrief;
			}
			cardStory_.Add(other.cardStory_);
			if (other.UnitSignStyle != SignStyle.Default)
			{
				UnitSignStyle = other.UnitSignStyle;
			}
			if (other.CardUnlockType != CardUnlockType.Task)
			{
				CardUnlockType = other.CardUnlockType;
			}
			cardIndexId_.Add(other.cardIndexId_);
			if (other.SkipDropUI != YesNoType.No)
			{
				SkipDropUI = other.SkipDropUI;
			}
			if (other.DisplayChapter != 0)
			{
				DisplayChapter = other.DisplayChapter;
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
			case 18u:
				UnitName = input.ReadString();
				break;
			case 24u:
				SortId = input.ReadInt32();
				break;
			case 32u:
				UnitType = (MonsterType)input.ReadEnum();
				break;
			case 42u:
				UnitPoetry = input.ReadString();
				break;
			case 50u:
				StoryBrief = input.ReadString();
				break;
			case 58u:
				cardStory_.AddEntriesFrom(input, _repeated_cardStory_codec);
				break;
			case 64u:
				UnitSignStyle = (SignStyle)input.ReadEnum();
				break;
			case 72u:
				CardUnlockType = (CardUnlockType)input.ReadEnum();
				break;
			case 80u:
			case 82u:
				cardIndexId_.AddEntriesFrom(input, _repeated_cardIndexId_codec);
				break;
			case 88u:
				SkipDropUI = (YesNoType)input.ReadEnum();
				break;
			case 96u:
				DisplayChapter = input.ReadInt32();
				break;
			case 104u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
