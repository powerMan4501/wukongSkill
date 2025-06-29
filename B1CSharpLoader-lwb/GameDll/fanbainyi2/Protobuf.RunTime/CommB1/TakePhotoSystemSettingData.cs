using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class TakePhotoSystemSettingData : IMessage<TakePhotoSystemSettingData>, IMessage, IEquatable<TakePhotoSystemSettingData>, IDeepCloneable<TakePhotoSystemSettingData>
{
	private static readonly MessageParser<TakePhotoSystemSettingData> _parser = new MessageParser<TakePhotoSystemSettingData>(() => new TakePhotoSystemSettingData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<TakePhotoSystemFunction> _repeated_function_codec = FieldCodec.ForMessage(10u, TakePhotoSystemFunction.Parser);

	private readonly RepeatedField<TakePhotoSystemFunction> function_ = new RepeatedField<TakePhotoSystemFunction>();

	public static MessageParser<TakePhotoSystemSettingData> Parser => _parser;

	public RepeatedField<TakePhotoSystemFunction> Function => function_;

	public TakePhotoSystemSettingData()
	{
	}

	public TakePhotoSystemSettingData(TakePhotoSystemSettingData other)
		: this()
	{
		function_ = other.function_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TakePhotoSystemSettingData Clone()
	{
		return new TakePhotoSystemSettingData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TakePhotoSystemSettingData);
	}

	public bool Equals(TakePhotoSystemSettingData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!function_.Equals(other.function_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= function_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		function_.WriteTo(output, _repeated_function_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += function_.CalculateSize(_repeated_function_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TakePhotoSystemSettingData other)
	{
		if (other != null)
		{
			function_.Add(other.function_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	public void MergeFrom(CodedInputStream input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0)
		{
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
			}
			else
			{
				function_.AddEntriesFrom(input, _repeated_function_codec);
			}
		}
	}
}
