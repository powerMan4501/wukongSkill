using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class AchievementConfigTupleWrapper : IMessage<AchievementConfigTupleWrapper>, IMessage, IEquatable<AchievementConfigTupleWrapper>, IDeepCloneable<AchievementConfigTupleWrapper>
{
	private static readonly MessageParser<AchievementConfigTupleWrapper> _parser = new MessageParser<AchievementConfigTupleWrapper>(() => new AchievementConfigTupleWrapper());

	private UnknownFieldSet _unknownFields;

	private AchievementConfig item1_;

	private AchievementConfig item2_;

	public static MessageParser<AchievementConfigTupleWrapper> Parser => _parser;

	public AchievementConfig Item1
	{
		get
		{
			return item1_;
		}
		set
		{
			item1_ = value;
		}
	}

	public AchievementConfig Item2
	{
		get
		{
			return item2_;
		}
		set
		{
			item2_ = value;
		}
	}

	public AchievementConfigTupleWrapper()
	{
	}

	public AchievementConfigTupleWrapper(AchievementConfigTupleWrapper other)
		: this()
	{
		item1_ = ((other.item1_ != null) ? other.item1_.Clone() : null);
		item2_ = ((other.item2_ != null) ? other.item2_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public AchievementConfigTupleWrapper Clone()
	{
		return new AchievementConfigTupleWrapper(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as AchievementConfigTupleWrapper);
	}

	public bool Equals(AchievementConfigTupleWrapper other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Item1, other.Item1))
		{
			return false;
		}
		if (!object.Equals(Item2, other.Item2))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (item1_ != null)
		{
			num ^= Item1.GetHashCode();
		}
		if (item2_ != null)
		{
			num ^= Item2.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (item1_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Item1);
		}
		if (item2_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Item2);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (item1_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Item1);
		}
		if (item2_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Item2);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(AchievementConfigTupleWrapper other)
	{
		if (other == null)
		{
			return;
		}
		if (other.item1_ != null)
		{
			if (item1_ == null)
			{
				Item1 = new AchievementConfig();
			}
			Item1.MergeFrom(other.Item1);
		}
		if (other.item2_ != null)
		{
			if (item2_ == null)
			{
				Item2 = new AchievementConfig();
			}
			Item2.MergeFrom(other.Item2);
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
			case 10u:
				if (item1_ == null)
				{
					Item1 = new AchievementConfig();
				}
				input.ReadMessage(Item1);
				break;
			case 18u:
				if (item2_ == null)
				{
					Item2 = new AchievementConfig();
				}
				input.ReadMessage(Item2);
				break;
			}
		}
	}
}
