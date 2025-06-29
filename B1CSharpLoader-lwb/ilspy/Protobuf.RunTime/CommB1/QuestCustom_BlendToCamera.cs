using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class QuestCustom_BlendToCamera : IMessage<QuestCustom_BlendToCamera>, IMessage, IEquatable<QuestCustom_BlendToCamera>, IDeepCloneable<QuestCustom_BlendToCamera>
{
	private static readonly MessageParser<QuestCustom_BlendToCamera> _parser = new MessageParser<QuestCustom_BlendToCamera>(() => new QuestCustom_BlendToCamera());

	private UnknownFieldSet _unknownFields;

	private string viewTargetName_ = "";

	private string viewTargetClass_ = "";

	private float blendTime_;

	private int blendFunc_;

	private float blendExp_;

	private bool lockOutgoing_;

	private bool playerAsViewTarget_;

	public static MessageParser<QuestCustom_BlendToCamera> Parser => _parser;

	public string ViewTargetName
	{
		get
		{
			return viewTargetName_;
		}
		set
		{
			viewTargetName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string ViewTargetClass
	{
		get
		{
			return viewTargetClass_;
		}
		set
		{
			viewTargetClass_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public float BlendTime
	{
		get
		{
			return blendTime_;
		}
		set
		{
			blendTime_ = value;
		}
	}

	public int BlendFunc
	{
		get
		{
			return blendFunc_;
		}
		set
		{
			blendFunc_ = value;
		}
	}

	public float BlendExp
	{
		get
		{
			return blendExp_;
		}
		set
		{
			blendExp_ = value;
		}
	}

	public bool LockOutgoing
	{
		get
		{
			return lockOutgoing_;
		}
		set
		{
			lockOutgoing_ = value;
		}
	}

	public bool PlayerAsViewTarget
	{
		get
		{
			return playerAsViewTarget_;
		}
		set
		{
			playerAsViewTarget_ = value;
		}
	}

	public QuestCustom_BlendToCamera()
	{
	}

	public QuestCustom_BlendToCamera(QuestCustom_BlendToCamera other)
		: this()
	{
		viewTargetName_ = other.viewTargetName_;
		viewTargetClass_ = other.viewTargetClass_;
		blendTime_ = other.blendTime_;
		blendFunc_ = other.blendFunc_;
		blendExp_ = other.blendExp_;
		lockOutgoing_ = other.lockOutgoing_;
		playerAsViewTarget_ = other.playerAsViewTarget_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public QuestCustom_BlendToCamera Clone()
	{
		return new QuestCustom_BlendToCamera(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as QuestCustom_BlendToCamera);
	}

	public bool Equals(QuestCustom_BlendToCamera other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ViewTargetName != other.ViewTargetName)
		{
			return false;
		}
		if (ViewTargetClass != other.ViewTargetClass)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendTime, other.BlendTime))
		{
			return false;
		}
		if (BlendFunc != other.BlendFunc)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendExp, other.BlendExp))
		{
			return false;
		}
		if (LockOutgoing != other.LockOutgoing)
		{
			return false;
		}
		if (PlayerAsViewTarget != other.PlayerAsViewTarget)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ViewTargetName.Length != 0)
		{
			num ^= ViewTargetName.GetHashCode();
		}
		if (ViewTargetClass.Length != 0)
		{
			num ^= ViewTargetClass.GetHashCode();
		}
		if (BlendTime != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendTime);
		}
		if (BlendFunc != 0)
		{
			num ^= BlendFunc.GetHashCode();
		}
		if (BlendExp != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendExp);
		}
		if (LockOutgoing)
		{
			num ^= LockOutgoing.GetHashCode();
		}
		if (PlayerAsViewTarget)
		{
			num ^= PlayerAsViewTarget.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ViewTargetName.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(ViewTargetName);
		}
		if (ViewTargetClass.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(ViewTargetClass);
		}
		if (BlendTime != 0f)
		{
			output.WriteRawTag(29);
			output.WriteFloat(BlendTime);
		}
		if (BlendFunc != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(BlendFunc);
		}
		if (BlendExp != 0f)
		{
			output.WriteRawTag(45);
			output.WriteFloat(BlendExp);
		}
		if (LockOutgoing)
		{
			output.WriteRawTag(48);
			output.WriteBool(LockOutgoing);
		}
		if (PlayerAsViewTarget)
		{
			output.WriteRawTag(56);
			output.WriteBool(PlayerAsViewTarget);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ViewTargetName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ViewTargetName);
		}
		if (ViewTargetClass.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ViewTargetClass);
		}
		if (BlendTime != 0f)
		{
			num += 5;
		}
		if (BlendFunc != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(BlendFunc);
		}
		if (BlendExp != 0f)
		{
			num += 5;
		}
		if (LockOutgoing)
		{
			num += 2;
		}
		if (PlayerAsViewTarget)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(QuestCustom_BlendToCamera other)
	{
		if (other != null)
		{
			if (other.ViewTargetName.Length != 0)
			{
				ViewTargetName = other.ViewTargetName;
			}
			if (other.ViewTargetClass.Length != 0)
			{
				ViewTargetClass = other.ViewTargetClass;
			}
			if (other.BlendTime != 0f)
			{
				BlendTime = other.BlendTime;
			}
			if (other.BlendFunc != 0)
			{
				BlendFunc = other.BlendFunc;
			}
			if (other.BlendExp != 0f)
			{
				BlendExp = other.BlendExp;
			}
			if (other.LockOutgoing)
			{
				LockOutgoing = other.LockOutgoing;
			}
			if (other.PlayerAsViewTarget)
			{
				PlayerAsViewTarget = other.PlayerAsViewTarget;
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
			case 10u:
				ViewTargetName = input.ReadString();
				break;
			case 18u:
				ViewTargetClass = input.ReadString();
				break;
			case 29u:
				BlendTime = input.ReadFloat();
				break;
			case 32u:
				BlendFunc = input.ReadInt32();
				break;
			case 45u:
				BlendExp = input.ReadFloat();
				break;
			case 48u:
				LockOutgoing = input.ReadBool();
				break;
			case 56u:
				PlayerAsViewTarget = input.ReadBool();
				break;
			}
		}
	}
}
