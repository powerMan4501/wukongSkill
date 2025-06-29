using System;
using Google.Protobuf;

namespace CommB1;

public sealed class QuestCustom_SwitchCameraGroup : IMessage<QuestCustom_SwitchCameraGroup>, IMessage, IEquatable<QuestCustom_SwitchCameraGroup>, IDeepCloneable<QuestCustom_SwitchCameraGroup>
{
	private static readonly MessageParser<QuestCustom_SwitchCameraGroup> _parser = new MessageParser<QuestCustom_SwitchCameraGroup>(() => new QuestCustom_SwitchCameraGroup());

	private UnknownFieldSet _unknownFields;

	private int cameraGroupId_;

	public static MessageParser<QuestCustom_SwitchCameraGroup> Parser => _parser;

	public int CameraGroupId
	{
		get
		{
			return cameraGroupId_;
		}
		set
		{
			cameraGroupId_ = value;
		}
	}

	public QuestCustom_SwitchCameraGroup()
	{
	}

	public QuestCustom_SwitchCameraGroup(QuestCustom_SwitchCameraGroup other)
		: this()
	{
		cameraGroupId_ = other.cameraGroupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_SwitchCameraGroup Clone()
	{
		return new QuestCustom_SwitchCameraGroup(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_SwitchCameraGroup);
	}

	public bool Equals(QuestCustom_SwitchCameraGroup other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CameraGroupId != other.CameraGroupId)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (CameraGroupId != 0)
		{
			num ^= CameraGroupId.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (CameraGroupId != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(CameraGroupId);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (CameraGroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CameraGroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_SwitchCameraGroup other)
	{
		if (other != null)
		{
			if (other.CameraGroupId != 0)
			{
				CameraGroupId = other.CameraGroupId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				CameraGroupId = input.ReadInt32();
			}
		}
	}
}
