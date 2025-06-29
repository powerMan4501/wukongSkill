using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace GurGsStruct;

public sealed class FRepTestClass : IMessage<FRepTestClass>, IMessage, IEquatable<FRepTestClass>, IDeepCloneable<FRepTestClass>
{
	private static readonly MessageParser<FRepTestClass> _parser = new MessageParser<FRepTestClass>(() => new FRepTestClass());

	private UnknownFieldSet _unknownFields;

	private int _hasBits0;

	private bool repTestClassBool_;

	private static readonly FieldCodec<ClassDeltaMsgFRepInnerClass> _repeated_innerClass_codec = FieldCodec.ForMessage(18u, ClassDeltaMsgFRepInnerClass.Parser);

	private readonly RepeatedField<ClassDeltaMsgFRepInnerClass> innerClass_ = new RepeatedField<ClassDeltaMsgFRepInnerClass>();

	private static readonly FieldCodec<ListDeltaMsgFRepInnerClass> _repeated_innerClassList_codec = FieldCodec.ForMessage(26u, ListDeltaMsgFRepInnerClass.Parser);

	private readonly RepeatedField<ListDeltaMsgFRepInnerClass> innerClassList_ = new RepeatedField<ListDeltaMsgFRepInnerClass>();

	public static MessageParser<FRepTestClass> Parser => _parser;

	public bool RepTestClassBool
	{
		get
		{
			if ((_hasBits0 & 1) != 0)
			{
				return repTestClassBool_;
			}
			return false;
		}
		set
		{
			_hasBits0 |= 1;
			repTestClassBool_ = value;
		}
	}

	public bool HasRepTestClassBool => (_hasBits0 & 1) != 0;

	public RepeatedField<ClassDeltaMsgFRepInnerClass> InnerClass => innerClass_;

	public RepeatedField<ListDeltaMsgFRepInnerClass> InnerClassList => innerClassList_;

	public FRepTestClass()
	{
	}

	public FRepTestClass(FRepTestClass other)
		: this()
	{
		_hasBits0 = other._hasBits0;
		repTestClassBool_ = other.repTestClassBool_;
		innerClass_ = other.innerClass_.Clone();
		innerClassList_ = other.innerClassList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public FRepTestClass Clone()
	{
		return new FRepTestClass(this);
	}

	public void ClearRepTestClassBool()
	{
		_hasBits0 &= -2;
	}

	public override bool Equals(object other)
	{
		return Equals(other as FRepTestClass);
	}

	public bool Equals(FRepTestClass other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RepTestClassBool != other.RepTestClassBool)
		{
			return false;
		}
		if (!innerClass_.Equals(other.innerClass_))
		{
			return false;
		}
		if (!innerClassList_.Equals(other.innerClassList_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (HasRepTestClassBool)
		{
			num ^= RepTestClassBool.GetHashCode();
		}
		num ^= innerClass_.GetHashCode();
		num ^= innerClassList_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (HasRepTestClassBool)
		{
			output.WriteRawTag(8);
			output.WriteBool(RepTestClassBool);
		}
		innerClass_.WriteTo(output, _repeated_innerClass_codec);
		innerClassList_.WriteTo(output, _repeated_innerClassList_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (HasRepTestClassBool)
		{
			num += 2;
		}
		num += innerClass_.CalculateSize(_repeated_innerClass_codec);
		num += innerClassList_.CalculateSize(_repeated_innerClassList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(FRepTestClass other)
	{
		if (other != null)
		{
			if (other.HasRepTestClassBool)
			{
				RepTestClassBool = other.RepTestClassBool;
			}
			innerClass_.Add(other.innerClass_);
			innerClassList_.Add(other.innerClassList_);
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
				RepTestClassBool = input.ReadBool();
				break;
			case 18u:
				innerClass_.AddEntriesFrom(input, _repeated_innerClass_codec);
				break;
			case 26u:
				innerClassList_.AddEntriesFrom(input, _repeated_innerClassList_codec);
				break;
			}
		}
	}
}
