using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace CommB1;

public sealed class UISettingArchiveData : IMessage<UISettingArchiveData>, IMessage, IEquatable<UISettingArchiveData>, IDeepCloneable<UISettingArchiveData>
{
	private static readonly MessageParser<UISettingArchiveData> _parser = new MessageParser<UISettingArchiveData>(() => new UISettingArchiveData());

	private UnknownFieldSet _unknownFields;

	private static readonly FieldCodec<SettingArchiveData> _repeated_archiveData_codec = FieldCodec.ForMessage(10u, SettingArchiveData.Parser);

	private readonly RepeatedField<SettingArchiveData> archiveData_ = new RepeatedField<SettingArchiveData>();

	private InputSettingData input_;

	private EnhancedInputSettingData enhancedInput_;

	private SettingpbTag settingpbTag_;

	private TakePhotoSystemSettingData takePhotoData_;

	private bool firstSettingFinish_;

	private bool agreementReaded_;

	public static MessageParser<UISettingArchiveData> Parser => _parser;

	public RepeatedField<SettingArchiveData> ArchiveData => archiveData_;

	public InputSettingData Input
	{
		get
		{
			return input_;
		}
		set
		{
			input_ = value;
		}
	}

	public EnhancedInputSettingData EnhancedInput
	{
		get
		{
			return enhancedInput_;
		}
		set
		{
			enhancedInput_ = value;
		}
	}

	public SettingpbTag SettingpbTag
	{
		get
		{
			return settingpbTag_;
		}
		set
		{
			settingpbTag_ = value;
		}
	}

	public TakePhotoSystemSettingData TakePhotoData
	{
		get
		{
			return takePhotoData_;
		}
		set
		{
			takePhotoData_ = value;
		}
	}

	public bool FirstSettingFinish
	{
		get
		{
			return firstSettingFinish_;
		}
		set
		{
			firstSettingFinish_ = value;
		}
	}

	public bool AgreementReaded
	{
		get
		{
			return agreementReaded_;
		}
		set
		{
			agreementReaded_ = value;
		}
	}

	public UISettingArchiveData()
	{
	}

	public UISettingArchiveData(UISettingArchiveData other)
		: this()
	{
		archiveData_ = other.archiveData_.Clone();
		input_ = ((other.input_ != null) ? other.input_.Clone() : null);
		enhancedInput_ = ((other.enhancedInput_ != null) ? other.enhancedInput_.Clone() : null);
		settingpbTag_ = other.settingpbTag_;
		takePhotoData_ = ((other.takePhotoData_ != null) ? other.takePhotoData_.Clone() : null);
		firstSettingFinish_ = other.firstSettingFinish_;
		agreementReaded_ = other.agreementReaded_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UISettingArchiveData Clone()
	{
		return new UISettingArchiveData(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UISettingArchiveData);
	}

	public bool Equals(UISettingArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!archiveData_.Equals(other.archiveData_))
		{
			return false;
		}
		if (!object.Equals(Input, other.Input))
		{
			return false;
		}
		if (!object.Equals(EnhancedInput, other.EnhancedInput))
		{
			return false;
		}
		if (SettingpbTag != other.SettingpbTag)
		{
			return false;
		}
		if (!object.Equals(TakePhotoData, other.TakePhotoData))
		{
			return false;
		}
		if (FirstSettingFinish != other.FirstSettingFinish)
		{
			return false;
		}
		if (AgreementReaded != other.AgreementReaded)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		num ^= archiveData_.GetHashCode();
		if (input_ != null)
		{
			num ^= Input.GetHashCode();
		}
		if (enhancedInput_ != null)
		{
			num ^= EnhancedInput.GetHashCode();
		}
		if (SettingpbTag != SettingpbTag.Default)
		{
			num ^= SettingpbTag.GetHashCode();
		}
		if (takePhotoData_ != null)
		{
			num ^= TakePhotoData.GetHashCode();
		}
		if (FirstSettingFinish)
		{
			num ^= FirstSettingFinish.GetHashCode();
		}
		if (AgreementReaded)
		{
			num ^= AgreementReaded.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		archiveData_.WriteTo(output, _repeated_archiveData_codec);
		if (input_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Input);
		}
		if (enhancedInput_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EnhancedInput);
		}
		if (SettingpbTag != SettingpbTag.Default)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)SettingpbTag);
		}
		if (takePhotoData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(TakePhotoData);
		}
		if (FirstSettingFinish)
		{
			output.WriteRawTag(48);
			output.WriteBool(FirstSettingFinish);
		}
		if (AgreementReaded)
		{
			output.WriteRawTag(56);
			output.WriteBool(AgreementReaded);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		num += archiveData_.CalculateSize(_repeated_archiveData_codec);
		if (input_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Input);
		}
		if (enhancedInput_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EnhancedInput);
		}
		if (SettingpbTag != SettingpbTag.Default)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SettingpbTag);
		}
		if (takePhotoData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TakePhotoData);
		}
		if (FirstSettingFinish)
		{
			num += 2;
		}
		if (AgreementReaded)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UISettingArchiveData other)
	{
		if (other == null)
		{
			return;
		}
		archiveData_.Add(other.archiveData_);
		if (other.input_ != null)
		{
			if (input_ == null)
			{
				Input = new InputSettingData();
			}
			Input.MergeFrom(other.Input);
		}
		if (other.enhancedInput_ != null)
		{
			if (enhancedInput_ == null)
			{
				EnhancedInput = new EnhancedInputSettingData();
			}
			EnhancedInput.MergeFrom(other.EnhancedInput);
		}
		if (other.SettingpbTag != SettingpbTag.Default)
		{
			SettingpbTag = other.SettingpbTag;
		}
		if (other.takePhotoData_ != null)
		{
			if (takePhotoData_ == null)
			{
				TakePhotoData = new TakePhotoSystemSettingData();
			}
			TakePhotoData.MergeFrom(other.TakePhotoData);
		}
		if (other.FirstSettingFinish)
		{
			FirstSettingFinish = other.FirstSettingFinish;
		}
		if (other.AgreementReaded)
		{
			AgreementReaded = other.AgreementReaded;
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
				archiveData_.AddEntriesFrom(input, _repeated_archiveData_codec);
				break;
			case 18u:
				if (input_ == null)
				{
					Input = new InputSettingData();
				}
				input.ReadMessage(Input);
				break;
			case 26u:
				if (enhancedInput_ == null)
				{
					EnhancedInput = new EnhancedInputSettingData();
				}
				input.ReadMessage(EnhancedInput);
				break;
			case 32u:
				SettingpbTag = (SettingpbTag)input.ReadEnum();
				break;
			case 42u:
				if (takePhotoData_ == null)
				{
					TakePhotoData = new TakePhotoSystemSettingData();
				}
				input.ReadMessage(TakePhotoData);
				break;
			case 48u:
				FirstSettingFinish = input.ReadBool();
				break;
			case 56u:
				AgreementReaded = input.ReadBool();
				break;
			}
		}
	}
}
