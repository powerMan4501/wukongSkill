using System;
using Google.Protobuf;

namespace CommB1;

public sealed class MovieCustom_PlayerSetCloudMoveEnabled : IMessage<MovieCustom_PlayerSetCloudMoveEnabled>, IMessage, IEquatable<MovieCustom_PlayerSetCloudMoveEnabled>, IDeepCloneable<MovieCustom_PlayerSetCloudMoveEnabled>
{
	private static readonly MessageParser<MovieCustom_PlayerSetCloudMoveEnabled> _parser = new MessageParser<MovieCustom_PlayerSetCloudMoveEnabled>(() => new MovieCustom_PlayerSetCloudMoveEnabled());

	private UnknownFieldSet _unknownFields;

	private bool isEnabled_;

	public static MessageParser<MovieCustom_PlayerSetCloudMoveEnabled> Parser => _parser;

	public bool IsEnabled
	{
		get
		{
			return isEnabled_;
		}
		set
		{
			isEnabled_ = value;
		}
	}

	public MovieCustom_PlayerSetCloudMoveEnabled()
	{
	}

	public MovieCustom_PlayerSetCloudMoveEnabled(MovieCustom_PlayerSetCloudMoveEnabled other)
		: this()
	{
		isEnabled_ = other.isEnabled_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public MovieCustom_PlayerSetCloudMoveEnabled Clone()
	{
		return new MovieCustom_PlayerSetCloudMoveEnabled(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as MovieCustom_PlayerSetCloudMoveEnabled);
	}

	public bool Equals(MovieCustom_PlayerSetCloudMoveEnabled other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsEnabled != other.IsEnabled)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (IsEnabled)
		{
			num ^= IsEnabled.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (IsEnabled)
		{
			output.WriteRawTag(8);
			output.WriteBool(IsEnabled);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (IsEnabled)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(MovieCustom_PlayerSetCloudMoveEnabled other)
	{
		if (other != null)
		{
			if (other.IsEnabled)
			{
				IsEnabled = other.IsEnabled;
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
				IsEnabled = input.ReadBool();
			}
		}
	}
}
