using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class MonsterCollection : IMessage<MonsterCollection>, IMessage, IEquatable<MonsterCollection>, IDeepCloneable<MonsterCollection>
{
	private static readonly MessageParser<MonsterCollection> _parser = new MessageParser<MonsterCollection>(() => new MonsterCollection());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private CardStoryStatus storyStatus_;

	private CardPortraitStatus portraitStatus_;

	public static MessageParser<MonsterCollection> Parser => _parser;

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

	public CardStoryStatus StoryStatus
	{
		get
		{
			return storyStatus_;
		}
		set
		{
			storyStatus_ = value;
		}
	}

	public CardPortraitStatus PortraitStatus
	{
		get
		{
			return portraitStatus_;
		}
		set
		{
			portraitStatus_ = value;
		}
	}

	public MonsterCollection()
	{
	}

	public MonsterCollection(MonsterCollection other)
		: this()
	{
		id_ = other.id_;
		storyStatus_ = ((other.storyStatus_ != null) ? other.storyStatus_.Clone() : null);
		portraitStatus_ = ((other.portraitStatus_ != null) ? other.portraitStatus_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MonsterCollection Clone()
	{
		return new MonsterCollection(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MonsterCollection);
	}

	public bool Equals(MonsterCollection other)
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
		if (!object.Equals(StoryStatus, other.StoryStatus))
		{
			return false;
		}
		if (!object.Equals(PortraitStatus, other.PortraitStatus))
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
		if (storyStatus_ != null)
		{
			num ^= StoryStatus.GetHashCode();
		}
		if (portraitStatus_ != null)
		{
			num ^= PortraitStatus.GetHashCode();
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
		if (storyStatus_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(StoryStatus);
		}
		if (portraitStatus_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PortraitStatus);
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
		if (storyStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StoryStatus);
		}
		if (portraitStatus_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PortraitStatus);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MonsterCollection other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.storyStatus_ != null)
		{
			if (storyStatus_ == null)
			{
				StoryStatus = new CardStoryStatus();
			}
			StoryStatus.MergeFrom(other.StoryStatus);
		}
		if (other.portraitStatus_ != null)
		{
			if (portraitStatus_ == null)
			{
				PortraitStatus = new CardPortraitStatus();
			}
			PortraitStatus.MergeFrom(other.PortraitStatus);
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
			case 34u:
				if (storyStatus_ == null)
				{
					StoryStatus = new CardStoryStatus();
				}
				input.ReadMessage(StoryStatus);
				break;
			case 42u:
				if (portraitStatus_ == null)
				{
					PortraitStatus = new CardPortraitStatus();
				}
				input.ReadMessage(PortraitStatus);
				break;
			}
		}
	}
}
