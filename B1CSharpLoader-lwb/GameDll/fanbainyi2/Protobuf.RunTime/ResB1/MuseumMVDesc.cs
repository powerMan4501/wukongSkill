using System;
using Google.Protobuf;

namespace ResB1;

public sealed class MuseumMVDesc : IMessage<MuseumMVDesc>, IMessage, IEquatable<MuseumMVDesc>, IDeepCloneable<MuseumMVDesc>
{
	private static readonly MessageParser<MuseumMVDesc> _parser = new MessageParser<MuseumMVDesc>(() => new MuseumMVDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private int sortId_;

	private string mvName_ = "";

	private int chapterId_;

	private string desc_ = "";

	private ResUnlockType unlockCondition_;

	private int localizationTag_;

	public static MessageParser<MuseumMVDesc> Parser => _parser;

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

	public string MvName
	{
		get
		{
			return mvName_;
		}
		set
		{
			mvName_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public ResUnlockType UnlockCondition
	{
		get
		{
			return unlockCondition_;
		}
		set
		{
			unlockCondition_ = value;
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

	public MuseumMVDesc()
	{
	}

	public MuseumMVDesc(MuseumMVDesc other)
		: this()
	{
		id_ = other.id_;
		sortId_ = other.sortId_;
		mvName_ = other.mvName_;
		chapterId_ = other.chapterId_;
		desc_ = other.desc_;
		unlockCondition_ = other.unlockCondition_;
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MuseumMVDesc Clone()
	{
		return new MuseumMVDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MuseumMVDesc);
	}

	public bool Equals(MuseumMVDesc other)
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
		if (MvName != other.MvName)
		{
			return false;
		}
		if (ChapterId != other.ChapterId)
		{
			return false;
		}
		if (Desc != other.Desc)
		{
			return false;
		}
		if (UnlockCondition != other.UnlockCondition)
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
		if (MvName.Length != 0)
		{
			num ^= MvName.GetHashCode();
		}
		if (ChapterId != 0)
		{
			num ^= ChapterId.GetHashCode();
		}
		if (Desc.Length != 0)
		{
			num ^= Desc.GetHashCode();
		}
		if (UnlockCondition != ResUnlockType.None)
		{
			num ^= UnlockCondition.GetHashCode();
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
		if (MvName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(MvName);
		}
		if (ChapterId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(ChapterId);
		}
		if (Desc.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Desc);
		}
		if (UnlockCondition != ResUnlockType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)UnlockCondition);
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
		if (MvName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MvName);
		}
		if (ChapterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ChapterId);
		}
		if (Desc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Desc);
		}
		if (UnlockCondition != ResUnlockType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnlockCondition);
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

	public void MergeFrom(MuseumMVDesc other)
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
			if (other.MvName.Length != 0)
			{
				MvName = other.MvName;
			}
			if (other.ChapterId != 0)
			{
				ChapterId = other.ChapterId;
			}
			if (other.Desc.Length != 0)
			{
				Desc = other.Desc;
			}
			if (other.UnlockCondition != ResUnlockType.None)
			{
				UnlockCondition = other.UnlockCondition;
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
				MvName = input.ReadString();
				break;
			case 32u:
				ChapterId = input.ReadInt32();
				break;
			case 42u:
				Desc = input.ReadString();
				break;
			case 48u:
				UnlockCondition = (ResUnlockType)input.ReadEnum();
				break;
			case 56u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
