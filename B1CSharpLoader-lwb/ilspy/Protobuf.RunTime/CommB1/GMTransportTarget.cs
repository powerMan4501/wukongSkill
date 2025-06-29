using System;
using Google.Protobuf;
using ResB1;

namespace CommB1;

public sealed class GMTransportTarget : IMessage<GMTransportTarget>, IMessage, IEquatable<GMTransportTarget>, IDeepCloneable<GMTransportTarget>
{
	private static readonly MessageParser<GMTransportTarget> _parser = new MessageParser<GMTransportTarget>(() => new GMTransportTarget());

	private UnknownFieldSet _unknownFields;

	private int levelId_;

	private GmVector position_;

	private GmVector rotation_;

	private GmVector cameraRotation_;

	public static MessageParser<GMTransportTarget> Parser => _parser;

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

	public GmVector Position
	{
		get
		{
			return position_;
		}
		set
		{
			position_ = value;
		}
	}

	public GmVector Rotation
	{
		get
		{
			return rotation_;
		}
		set
		{
			rotation_ = value;
		}
	}

	public GmVector CameraRotation
	{
		get
		{
			return cameraRotation_;
		}
		set
		{
			cameraRotation_ = value;
		}
	}

	public GMTransportTarget()
	{
	}

	public GMTransportTarget(GMTransportTarget other)
		: this()
	{
		levelId_ = other.levelId_;
		position_ = ((other.position_ != null) ? other.position_.Clone() : null);
		rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
		cameraRotation_ = ((other.cameraRotation_ != null) ? other.cameraRotation_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public GMTransportTarget Clone()
	{
		return new GMTransportTarget(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as GMTransportTarget);
	}

	public bool Equals(GMTransportTarget other)
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
		if (!object.Equals(Position, other.Position))
		{
			return false;
		}
		if (!object.Equals(Rotation, other.Rotation))
		{
			return false;
		}
		if (!object.Equals(CameraRotation, other.CameraRotation))
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
		if (position_ != null)
		{
			num ^= Position.GetHashCode();
		}
		if (rotation_ != null)
		{
			num ^= Rotation.GetHashCode();
		}
		if (cameraRotation_ != null)
		{
			num ^= CameraRotation.GetHashCode();
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
		if (position_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Position);
		}
		if (rotation_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Rotation);
		}
		if (cameraRotation_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(CameraRotation);
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
		if (position_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Position);
		}
		if (rotation_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Rotation);
		}
		if (cameraRotation_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CameraRotation);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(GMTransportTarget other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		if (other.position_ != null)
		{
			if (position_ == null)
			{
				Position = new GmVector();
			}
			Position.MergeFrom(other.Position);
		}
		if (other.rotation_ != null)
		{
			if (rotation_ == null)
			{
				Rotation = new GmVector();
			}
			Rotation.MergeFrom(other.Rotation);
		}
		if (other.cameraRotation_ != null)
		{
			if (cameraRotation_ == null)
			{
				CameraRotation = new GmVector();
			}
			CameraRotation.MergeFrom(other.CameraRotation);
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
				if (position_ == null)
				{
					Position = new GmVector();
				}
				input.ReadMessage(Position);
				break;
			case 26u:
				if (rotation_ == null)
				{
					Rotation = new GmVector();
				}
				input.ReadMessage(Rotation);
				break;
			case 34u:
				if (cameraRotation_ == null)
				{
					CameraRotation = new GmVector();
				}
				input.ReadMessage(CameraRotation);
				break;
			}
		}
	}
}
