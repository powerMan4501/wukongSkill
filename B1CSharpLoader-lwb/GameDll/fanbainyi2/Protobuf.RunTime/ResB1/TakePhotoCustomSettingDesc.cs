using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class TakePhotoCustomSettingDesc : IMessage<TakePhotoCustomSettingDesc>, IMessage, IEquatable<TakePhotoCustomSettingDesc>, IDeepCloneable<TakePhotoCustomSettingDesc>
{
	private static readonly MessageParser<TakePhotoCustomSettingDesc> _parser = new MessageParser<TakePhotoCustomSettingDesc>(() => new TakePhotoCustomSettingDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private TakePhotoConfigTab configTab_;

	private string configName_ = "";

	private TakePhotoFuncType configTemplete_;

	private int preconditions_;

	private YesNoType defaultValueFromTable_;

	private int defaultValue_;

	private TakePhotoUIType uiType_;

	private static readonly FieldCodec<int> _repeated_params_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> params_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_paramsReal_codec = FieldCodec.ForInt32(82u);

	private readonly RepeatedField<int> paramsReal_ = new RepeatedField<int>();

	private YesNoType realParamIsFloat_;

	private static readonly FieldCodec<int> _repeated_keypointUi_codec = FieldCodec.ForInt32(98u);

	private readonly RepeatedField<int> keypointUi_ = new RepeatedField<int>();

	private static readonly FieldCodec<int> _repeated_keypointReal_codec = FieldCodec.ForInt32(106u);

	private readonly RepeatedField<int> keypointReal_ = new RepeatedField<int>();

	private int localizationTag_;

	public static MessageParser<TakePhotoCustomSettingDesc> Parser => _parser;

	public int Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	public TakePhotoConfigTab ConfigTab
	{
		get
		{
			return configTab_;
		}
		set
		{
			configTab_ = value;
		}
	}

	public string ConfigName
	{
		get
		{
			return configName_;
		}
		set
		{
			configName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public TakePhotoFuncType ConfigTemplete
	{
		get
		{
			return configTemplete_;
		}
		set
		{
			configTemplete_ = value;
		}
	}

	public int Preconditions
	{
		get
		{
			return preconditions_;
		}
		set
		{
			preconditions_ = value;
		}
	}

	public YesNoType DefaultValueFromTable
	{
		get
		{
			return defaultValueFromTable_;
		}
		set
		{
			defaultValueFromTable_ = value;
		}
	}

	public int DefaultValue
	{
		get
		{
			return defaultValue_;
		}
		set
		{
			defaultValue_ = value;
		}
	}

	public TakePhotoUIType UiType
	{
		get
		{
			return uiType_;
		}
		set
		{
			uiType_ = value;
		}
	}

	public RepeatedField<int> Params => params_;

	public RepeatedField<int> ParamsReal => paramsReal_;

	public YesNoType RealParamIsFloat
	{
		get
		{
			return realParamIsFloat_;
		}
		set
		{
			realParamIsFloat_ = value;
		}
	}

	public RepeatedField<int> KeypointUi => keypointUi_;

	public RepeatedField<int> KeypointReal => keypointReal_;

	public int LocalizationTag
	{
		get
		{
			return localizationTag_;
		}
		set
		{
			localizationTag_ = value;
		}
	}

	public TakePhotoCustomSettingDesc()
	{
	}

	public TakePhotoCustomSettingDesc(TakePhotoCustomSettingDesc other)
		: this()
	{
		id_ = other.id_;
		configTab_ = other.configTab_;
		configName_ = other.configName_;
		configTemplete_ = other.configTemplete_;
		preconditions_ = other.preconditions_;
		defaultValueFromTable_ = other.defaultValueFromTable_;
		defaultValue_ = other.defaultValue_;
		uiType_ = other.uiType_;
		params_ = other.params_.Clone();
		paramsReal_ = other.paramsReal_.Clone();
		realParamIsFloat_ = other.realParamIsFloat_;
		keypointUi_ = other.keypointUi_.Clone();
		keypointReal_ = other.keypointReal_.Clone();
		localizationTag_ = other.localizationTag_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public TakePhotoCustomSettingDesc Clone()
	{
		return new TakePhotoCustomSettingDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as TakePhotoCustomSettingDesc);
	}

	public bool Equals(TakePhotoCustomSettingDesc other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (ConfigTab != other.ConfigTab)
		{
			return false;
		}
		if (ConfigName != other.ConfigName)
		{
			return false;
		}
		if (ConfigTemplete != other.ConfigTemplete)
		{
			return false;
		}
		if (Preconditions != other.Preconditions)
		{
			return false;
		}
		if (DefaultValueFromTable != other.DefaultValueFromTable)
		{
			return false;
		}
		if (DefaultValue != other.DefaultValue)
		{
			return false;
		}
		if (UiType != other.UiType)
		{
			return false;
		}
		if (!params_.Equals(other.params_))
		{
			return false;
		}
		if (!paramsReal_.Equals(other.paramsReal_))
		{
			return false;
		}
		if (RealParamIsFloat != other.RealParamIsFloat)
		{
			return false;
		}
		if (!keypointUi_.Equals(other.keypointUi_))
		{
			return false;
		}
		if (!keypointReal_.Equals(other.keypointReal_))
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	public override int GetHashCode()
	{
		int num = 1;
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (ConfigTab != TakePhotoConfigTab.Camera)
		{
			num ^= ConfigTab.GetHashCode();
		}
		if (ConfigName.Length != 0)
		{
			num ^= ConfigName.GetHashCode();
		}
		if (ConfigTemplete != TakePhotoFuncType.FocalLength)
		{
			num ^= ConfigTemplete.GetHashCode();
		}
		if (Preconditions != 0)
		{
			num ^= Preconditions.GetHashCode();
		}
		if (DefaultValueFromTable != YesNoType.No)
		{
			num ^= DefaultValueFromTable.GetHashCode();
		}
		if (DefaultValue != 0)
		{
			num ^= DefaultValue.GetHashCode();
		}
		if (UiType != TakePhotoUIType.Fixed)
		{
			num ^= UiType.GetHashCode();
		}
		num ^= params_.GetHashCode();
		num ^= paramsReal_.GetHashCode();
		if (RealParamIsFloat != YesNoType.No)
		{
			num ^= RealParamIsFloat.GetHashCode();
		}
		num ^= keypointUi_.GetHashCode();
		num ^= keypointReal_.GetHashCode();
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	public void WriteTo(CodedOutputStream output)
	{
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteInt32(Id);
		}
		if (ConfigTab != TakePhotoConfigTab.Camera)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ConfigTab);
		}
		if (ConfigName.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(ConfigName);
		}
		if (ConfigTemplete != TakePhotoFuncType.FocalLength)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)ConfigTemplete);
		}
		if (Preconditions != 0)
		{
			output.WriteRawTag(40);
			output.WriteInt32(Preconditions);
		}
		if (DefaultValueFromTable != YesNoType.No)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)DefaultValueFromTable);
		}
		if (DefaultValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DefaultValue);
		}
		if (UiType != TakePhotoUIType.Fixed)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)UiType);
		}
		params_.WriteTo(output, _repeated_params_codec);
		paramsReal_.WriteTo(output, _repeated_paramsReal_codec);
		if (RealParamIsFloat != YesNoType.No)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)RealParamIsFloat);
		}
		keypointUi_.WriteTo(output, _repeated_keypointUi_codec);
		keypointReal_.WriteTo(output, _repeated_keypointReal_codec);
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(output);
		}
	}

	public int CalculateSize()
	{
		int num = 0;
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Id);
		}
		if (ConfigTab != TakePhotoConfigTab.Camera)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConfigTab);
		}
		if (ConfigName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigName);
		}
		if (ConfigTemplete != TakePhotoFuncType.FocalLength)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConfigTemplete);
		}
		if (Preconditions != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(Preconditions);
		}
		if (DefaultValueFromTable != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DefaultValueFromTable);
		}
		if (DefaultValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultValue);
		}
		if (UiType != TakePhotoUIType.Fixed)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UiType);
		}
		num += params_.CalculateSize(_repeated_params_codec);
		num += paramsReal_.CalculateSize(_repeated_paramsReal_codec);
		if (RealParamIsFloat != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RealParamIsFloat);
		}
		num += keypointUi_.CalculateSize(_repeated_keypointUi_codec);
		num += keypointReal_.CalculateSize(_repeated_keypointReal_codec);
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(TakePhotoCustomSettingDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ConfigTab != TakePhotoConfigTab.Camera)
			{
				ConfigTab = other.ConfigTab;
			}
			if (other.ConfigName.Length != 0)
			{
				ConfigName = other.ConfigName;
			}
			if (other.ConfigTemplete != TakePhotoFuncType.FocalLength)
			{
				ConfigTemplete = other.ConfigTemplete;
			}
			if (other.Preconditions != 0)
			{
				Preconditions = other.Preconditions;
			}
			if (other.DefaultValueFromTable != YesNoType.No)
			{
				DefaultValueFromTable = other.DefaultValueFromTable;
			}
			if (other.DefaultValue != 0)
			{
				DefaultValue = other.DefaultValue;
			}
			if (other.UiType != TakePhotoUIType.Fixed)
			{
				UiType = other.UiType;
			}
			params_.Add(other.params_);
			paramsReal_.Add(other.paramsReal_);
			if (other.RealParamIsFloat != YesNoType.No)
			{
				RealParamIsFloat = other.RealParamIsFloat;
			}
			keypointUi_.Add(other.keypointUi_);
			keypointReal_.Add(other.keypointReal_);
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
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
			case 8u:
				Id = input.ReadInt32();
				break;
			case 16u:
				ConfigTab = (TakePhotoConfigTab)input.ReadEnum();
				break;
			case 26u:
				ConfigName = input.ReadString();
				break;
			case 32u:
				ConfigTemplete = (TakePhotoFuncType)input.ReadEnum();
				break;
			case 40u:
				Preconditions = input.ReadInt32();
				break;
			case 48u:
				DefaultValueFromTable = (YesNoType)input.ReadEnum();
				break;
			case 56u:
				DefaultValue = input.ReadInt32();
				break;
			case 64u:
				UiType = (TakePhotoUIType)input.ReadEnum();
				break;
			case 72u:
			case 74u:
				params_.AddEntriesFrom(input, _repeated_params_codec);
				break;
			case 80u:
			case 82u:
				paramsReal_.AddEntriesFrom(input, _repeated_paramsReal_codec);
				break;
			case 88u:
				RealParamIsFloat = (YesNoType)input.ReadEnum();
				break;
			case 96u:
			case 98u:
				keypointUi_.AddEntriesFrom(input, _repeated_keypointUi_codec);
				break;
			case 104u:
			case 106u:
				keypointReal_.AddEntriesFrom(input, _repeated_keypointReal_codec);
				break;
			case 112u:
				LocalizationTag = input.ReadInt32();
				break;
			}
		}
	}
}
