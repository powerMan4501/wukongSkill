using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class TaskCustom_ObserveRoleData : IMessage<TaskCustom_ObserveRoleData>, IMessage, IEquatable<TaskCustom_ObserveRoleData>, IDeepCloneable<TaskCustom_ObserveRoleData>
{
	private static readonly MessageParser<TaskCustom_ObserveRoleData> _parser = new MessageParser<TaskCustom_ObserveRoleData>(() => new TaskCustom_ObserveRoleData());

	private UnknownFieldSet _unknownFields;

	private int observeMinSuccessConditionNum_;

	private static readonly FieldCodec<OneObserveRoleDataInfo> _repeated_observeInfoList_codec = FieldCodec.ForMessage(18u, OneObserveRoleDataInfo.Parser);

	private readonly RepeatedField<OneObserveRoleDataInfo> observeInfoList_ = new RepeatedField<OneObserveRoleDataInfo>();

	public static MessageParser<TaskCustom_ObserveRoleData> Parser => _parser;

	public int ObserveMinSuccessConditionNum
	{
		get
		{
			return observeMinSuccessConditionNum_;
		}
		set
		{
			observeMinSuccessConditionNum_ = value;
		}
	}

	public RepeatedField<OneObserveRoleDataInfo> ObserveInfoList => observeInfoList_;

	public TaskCustom_ObserveRoleData()
	{
	}

	public TaskCustom_ObserveRoleData(TaskCustom_ObserveRoleData other)
		: this()
	{
		observeMinSuccessConditionNum_ = other.observeMinSuccessConditionNum_;
		observeInfoList_ = other.observeInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TaskCustom_ObserveRoleData Clone()
	{
		return new TaskCustom_ObserveRoleData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TaskCustom_ObserveRoleData);
	}

	public bool Equals(TaskCustom_ObserveRoleData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ObserveMinSuccessConditionNum != other.ObserveMinSuccessConditionNum)
		{
			return false;
		}
		if (!observeInfoList_.Equals(other.observeInfoList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (ObserveMinSuccessConditionNum != 0)
		{
			num ^= ObserveMinSuccessConditionNum.GetHashCode();
		}
		num ^= observeInfoList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (ObserveMinSuccessConditionNum != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(ObserveMinSuccessConditionNum);
		}
		observeInfoList_.WriteTo(output, _repeated_observeInfoList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (ObserveMinSuccessConditionNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ObserveMinSuccessConditionNum);
		}
		num += observeInfoList_.CalculateSize(_repeated_observeInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TaskCustom_ObserveRoleData other)
	{
		if (other != null)
		{
			if (other.ObserveMinSuccessConditionNum != 0)
			{
				ObserveMinSuccessConditionNum = other.ObserveMinSuccessConditionNum;
			}
			observeInfoList_.Add(other.observeInfoList_);
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
				ObserveMinSuccessConditionNum = input.ReadInt32();
				break;
			case 18u:
				observeInfoList_.AddEntriesFrom(input, _repeated_observeInfoList_codec);
				break;
			}
		}
	}
}
