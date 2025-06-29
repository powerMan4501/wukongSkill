using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class LevelArchiveDetailData : IMessage<LevelArchiveDetailData>, IMessage, IEquatable<LevelArchiveDetailData>, IDeepCloneable<LevelArchiveDetailData>
{
	private static readonly MessageParser<LevelArchiveDetailData> _parser = new MessageParser<LevelArchiveDetailData>(() => new LevelArchiveDetailData());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	private LevelArchiveQuestData questData_;

	private ByteString data_ = ByteString.Empty;

	public static MessageParser<LevelArchiveDetailData> Parser => _parser;

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

	public LevelArchiveQuestData QuestData
	{
		get
		{
			return questData_;
		}
		set
		{
			questData_ = value;
		}
	}

	public ByteString Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public LevelArchiveDetailData()
	{
	}

	public LevelArchiveDetailData(LevelArchiveDetailData other)
		: this()
	{
		levelId_ = other.levelId_;
		questData_ = ((other.questData_ != null) ? other.questData_.Clone() : null);
		data_ = other.data_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public LevelArchiveDetailData Clone()
	{
		return new LevelArchiveDetailData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as LevelArchiveDetailData);
	}

	public bool Equals(LevelArchiveDetailData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (!object.Equals(QuestData, other.QuestData))
		{
			return false;
		}
		if (Data != other.Data)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (questData_ != null)
		{
			num ^= QuestData.GetHashCode();
		}
		if (Data.Length != 0)
		{
			num ^= Data.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (LevelId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(LevelId);
		}
		if (questData_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(QuestData);
		}
		if (Data.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteBytes(Data);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LevelId);
		}
		if (questData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(QuestData);
		}
		if (Data.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(Data);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(LevelArchiveDetailData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		if (other.questData_ != null)
		{
			if (questData_ == null)
			{
				QuestData = new LevelArchiveQuestData();
			}
			QuestData.MergeFrom(other.QuestData);
		}
		if (other.Data.Length != 0)
		{
			Data = other.Data;
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
				LevelId = input.ReadInt32();
				break;
			case 18u:
				if (questData_ == null)
				{
					QuestData = new LevelArchiveQuestData();
				}
				input.ReadMessage(QuestData);
				break;
			case 26u:
				Data = input.ReadBytes();
				break;
			}
		}
	}
}
