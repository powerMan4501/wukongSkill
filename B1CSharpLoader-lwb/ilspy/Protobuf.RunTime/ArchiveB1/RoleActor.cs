using System;
using Google.Protobuf;

namespace ArchiveB1;

public sealed class RoleActor : IMessage<RoleActor>, IMessage, IEquatable<RoleActor>, IDeepCloneable<RoleActor>
{
	private static readonly MessageParser<RoleActor> _parser = new MessageParser<RoleActor>(() => new RoleActor());

	private UnknownFieldSet _unknownFields;

	private ActorWear wear_;

	private ActorProgress progress_;

	private int newGamePlusCount_;

	public static MessageParser<RoleActor> Parser => _parser;

	public ActorWear Wear
	{
		get
		{
			return wear_;
		}
		set
		{
			wear_ = value;
		}
	}

	public ActorProgress Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	public int NewGamePlusCount
	{
		get
		{
			return newGamePlusCount_;
		}
		set
		{
			newGamePlusCount_ = value;
		}
	}

	public RoleActor()
	{
	}

	public RoleActor(RoleActor other)
		: this()
	{
		wear_ = ((other.wear_ != null) ? other.wear_.Clone() : null);
		progress_ = ((other.progress_ != null) ? other.progress_.Clone() : null);
		newGamePlusCount_ = other.newGamePlusCount_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleActor Clone()
	{
		return new RoleActor(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleActor);
	}

	public bool Equals(RoleActor other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Wear, other.Wear))
		{
			return false;
		}
		if (!object.Equals(Progress, other.Progress))
		{
			return false;
		}
		if (NewGamePlusCount != other.NewGamePlusCount)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (wear_ != null)
		{
			num ^= Wear.GetHashCode();
		}
		if (progress_ != null)
		{
			num ^= Progress.GetHashCode();
		}
		if (NewGamePlusCount != 0)
		{
			num ^= NewGamePlusCount.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (wear_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Wear);
		}
		if (progress_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Progress);
		}
		if (NewGamePlusCount != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(NewGamePlusCount);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (wear_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Wear);
		}
		if (progress_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Progress);
		}
		if (NewGamePlusCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NewGamePlusCount);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleActor other)
	{
		if (other == null)
		{
			return;
		}
		if (other.wear_ != null)
		{
			if (wear_ == null)
			{
				Wear = new ActorWear();
			}
			Wear.MergeFrom(other.Wear);
		}
		if (other.progress_ != null)
		{
			if (progress_ == null)
			{
				Progress = new ActorProgress();
			}
			Progress.MergeFrom(other.Progress);
		}
		if (other.NewGamePlusCount != 0)
		{
			NewGamePlusCount = other.NewGamePlusCount;
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
				if (wear_ == null)
				{
					Wear = new ActorWear();
				}
				input.ReadMessage(Wear);
				break;
			case 18u:
				if (progress_ == null)
				{
					Progress = new ActorProgress();
				}
				input.ReadMessage(Progress);
				break;
			case 24u:
				NewGamePlusCount = input.ReadInt32();
				break;
			}
		}
	}
}
