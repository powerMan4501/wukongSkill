using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ArchiveB1;

public sealed class RoleActivity : IMessage<RoleActivity>, IMessage, IEquatable<RoleActivity>, IDeepCloneable<RoleActivity>
{
	private static readonly MessageParser<RoleActivity> _parser = new MessageParser<RoleActivity>(() => new RoleActivity());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<PS5Activity> _repeated_activityList_codec = FieldCodec.ForMessage(26u, PS5Activity.Parser);

	private readonly RepeatedField<PS5Activity> activityList_ = new RepeatedField<PS5Activity>();

	public static MessageParser<RoleActivity> Parser => _parser;

	public RepeatedField<PS5Activity> ActivityList => activityList_;

	public RoleActivity()
	{
	}

	public RoleActivity(RoleActivity other)
		: this()
	{
		activityList_ = other.activityList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public RoleActivity Clone()
	{
		return new RoleActivity(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as RoleActivity);
	}

	public bool Equals(RoleActivity other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!activityList_.Equals(other.activityList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= activityList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		activityList_.WriteTo(output, _repeated_activityList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += activityList_.CalculateSize(_repeated_activityList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(RoleActivity other)
	{
		if (other != null)
		{
			activityList_.Add(other.activityList_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				activityList_.AddEntriesFrom(input, _repeated_activityList_codec);
			}
		}
	}
}
