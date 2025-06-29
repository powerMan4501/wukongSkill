using System;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace ResB1;

public sealed class UISettingConfigDesc : IMessage<UISettingConfigDesc>, IMessage, IEquatable<UISettingConfigDesc>, IDeepCloneable<UISettingConfigDesc>
{
	private static readonly MessageParser<UISettingConfigDesc> _parser = new MessageParser<UISettingConfigDesc>(() => new UISettingConfigDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private UISettingConfigType configType_;

	private SettingFunTempelte funTempelte_;

	private string tempelteParam_ = "";

	private string configName_ = "";

	private string configDesc_ = "";

	private int defaultValue_;

	private UIConfigType uiType_;

	private static readonly FieldCodec<int> _repeated_params_codec = FieldCodec.ForInt32(74u);

	private readonly RepeatedField<int> params_ = new RepeatedField<int>();

	private int showType_;

	private EUIConfigTab configTab_;

	private UIConfigSaveType saveType_;

	private int needInit_;

	private SettingBanConditionType conditionType_;

	private int localizationTag_;

	private int valueScale_;

	private int sortId_;

	private int needRestart_;

	private static readonly FieldCodec<ConfigTabInfoEx> _repeated_configTabInfoEx_codec = FieldCodec.ForMessage(154u, ResB1.ConfigTabInfoEx.Parser);

	private readonly RepeatedField<ConfigTabInfoEx> configTabInfoEx_ = new RepeatedField<ConfigTabInfoEx>();

	private static readonly FieldCodec<SettingLockInfoEx> _repeated_settingLockInfoEx_codec = FieldCodec.ForMessage(162u, ResB1.SettingLockInfoEx.Parser);

	private readonly RepeatedField<SettingLockInfoEx> settingLockInfoEx_ = new RepeatedField<SettingLockInfoEx>();

	private UISettingDetailDisplayType detailDisplayType_;

	private int innerTabId_;

	private int changeFromUiOnly_;

	private int showDefaultFlag_;

	private int notResetFlag_;

	private int priority_;

	public static MessageParser<UISettingConfigDesc> Parser => _parser;

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

	public UISettingConfigType ConfigType
	{
		get
		{
			return configType_;
		}
		set
		{
			configType_ = value;
		}
	}

	public SettingFunTempelte FunTempelte
	{
		get
		{
			return funTempelte_;
		}
		set
		{
			funTempelte_ = value;
		}
	}

	public string TempelteParam
	{
		get
		{
			return tempelteParam_;
		}
		set
		{
			tempelteParam_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public string ConfigDesc
	{
		get
		{
			return configDesc_;
		}
		set
		{
			configDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public UIConfigType UiType
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

	public int ShowType
	{
		get
		{
			return showType_;
		}
		set
		{
			showType_ = value;
		}
	}

	public EUIConfigTab ConfigTab
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

	public UIConfigSaveType SaveType
	{
		get
		{
			return saveType_;
		}
		set
		{
			saveType_ = value;
		}
	}

	public int NeedInit
	{
		get
		{
			return needInit_;
		}
		set
		{
			needInit_ = value;
		}
	}

	public SettingBanConditionType ConditionType
	{
		get
		{
			return conditionType_;
		}
		set
		{
			conditionType_ = value;
		}
	}

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

	public int ValueScale
	{
		get
		{
			return valueScale_;
		}
		set
		{
			valueScale_ = value;
		}
	}

	public int SortId
	{
		get
		{
			return sortId_;
		}
		set
		{
			sortId_ = value;
		}
	}

	public int NeedRestart
	{
		get
		{
			return needRestart_;
		}
		set
		{
			needRestart_ = value;
		}
	}

	public RepeatedField<ConfigTabInfoEx> ConfigTabInfoEx => configTabInfoEx_;

	public RepeatedField<SettingLockInfoEx> SettingLockInfoEx => settingLockInfoEx_;

	public UISettingDetailDisplayType DetailDisplayType
	{
		get
		{
			return detailDisplayType_;
		}
		set
		{
			detailDisplayType_ = value;
		}
	}

	public int InnerTabId
	{
		get
		{
			return innerTabId_;
		}
		set
		{
			innerTabId_ = value;
		}
	}

	public int ChangeFromUiOnly
	{
		get
		{
			return changeFromUiOnly_;
		}
		set
		{
			changeFromUiOnly_ = value;
		}
	}

	public int ShowDefaultFlag
	{
		get
		{
			return showDefaultFlag_;
		}
		set
		{
			showDefaultFlag_ = value;
		}
	}

	public int NotResetFlag
	{
		get
		{
			return notResetFlag_;
		}
		set
		{
			notResetFlag_ = value;
		}
	}

	public int Priority
	{
		get
		{
			return priority_;
		}
		set
		{
			priority_ = value;
		}
	}

	public UISettingConfigDesc()
	{
	}

	public UISettingConfigDesc(UISettingConfigDesc other)
		: this()
	{
		id_ = other.id_;
		configType_ = other.configType_;
		funTempelte_ = other.funTempelte_;
		tempelteParam_ = other.tempelteParam_;
		configName_ = other.configName_;
		configDesc_ = other.configDesc_;
		defaultValue_ = other.defaultValue_;
		uiType_ = other.uiType_;
		params_ = other.params_.Clone();
		showType_ = other.showType_;
		configTab_ = other.configTab_;
		saveType_ = other.saveType_;
		needInit_ = other.needInit_;
		conditionType_ = other.conditionType_;
		localizationTag_ = other.localizationTag_;
		valueScale_ = other.valueScale_;
		sortId_ = other.sortId_;
		needRestart_ = other.needRestart_;
		configTabInfoEx_ = other.configTabInfoEx_.Clone();
		settingLockInfoEx_ = other.settingLockInfoEx_.Clone();
		detailDisplayType_ = other.detailDisplayType_;
		innerTabId_ = other.innerTabId_;
		changeFromUiOnly_ = other.changeFromUiOnly_;
		showDefaultFlag_ = other.showDefaultFlag_;
		notResetFlag_ = other.notResetFlag_;
		priority_ = other.priority_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public UISettingConfigDesc Clone()
	{
		return new UISettingConfigDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as UISettingConfigDesc);
	}

	public bool Equals(UISettingConfigDesc other)
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
		if (ConfigType != other.ConfigType)
		{
			return false;
		}
		if (FunTempelte != other.FunTempelte)
		{
			return false;
		}
		if (TempelteParam != other.TempelteParam)
		{
			return false;
		}
		if (ConfigName != other.ConfigName)
		{
			return false;
		}
		if (ConfigDesc != other.ConfigDesc)
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
		if (ShowType != other.ShowType)
		{
			return false;
		}
		if (ConfigTab != other.ConfigTab)
		{
			return false;
		}
		if (SaveType != other.SaveType)
		{
			return false;
		}
		if (NeedInit != other.NeedInit)
		{
			return false;
		}
		if (ConditionType != other.ConditionType)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (ValueScale != other.ValueScale)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (NeedRestart != other.NeedRestart)
		{
			return false;
		}
		if (!configTabInfoEx_.Equals(other.configTabInfoEx_))
		{
			return false;
		}
		if (!settingLockInfoEx_.Equals(other.settingLockInfoEx_))
		{
			return false;
		}
		if (DetailDisplayType != other.DetailDisplayType)
		{
			return false;
		}
		if (InnerTabId != other.InnerTabId)
		{
			return false;
		}
		if (ChangeFromUiOnly != other.ChangeFromUiOnly)
		{
			return false;
		}
		if (ShowDefaultFlag != other.ShowDefaultFlag)
		{
			return false;
		}
		if (NotResetFlag != other.NotResetFlag)
		{
			return false;
		}
		if (Priority != other.Priority)
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
		if (ConfigType != UISettingConfigType.Min)
		{
			num ^= ConfigType.GetHashCode();
		}
		if (FunTempelte != SettingFunTempelte.ConsoleVariable)
		{
			num ^= FunTempelte.GetHashCode();
		}
		if (TempelteParam.Length != 0)
		{
			num ^= TempelteParam.GetHashCode();
		}
		if (ConfigName.Length != 0)
		{
			num ^= ConfigName.GetHashCode();
		}
		if (ConfigDesc.Length != 0)
		{
			num ^= ConfigDesc.GetHashCode();
		}
		if (DefaultValue != 0)
		{
			num ^= DefaultValue.GetHashCode();
		}
		if (UiType != UIConfigType.FixedItem)
		{
			num ^= UiType.GetHashCode();
		}
		num ^= params_.GetHashCode();
		if (ShowType != 0)
		{
			num ^= ShowType.GetHashCode();
		}
		if (ConfigTab != EUIConfigTab.Gamepad)
		{
			num ^= ConfigTab.GetHashCode();
		}
		if (SaveType != UIConfigSaveType.Local)
		{
			num ^= SaveType.GetHashCode();
		}
		if (NeedInit != 0)
		{
			num ^= NeedInit.GetHashCode();
		}
		if (ConditionType != SettingBanConditionType.Dontban)
		{
			num ^= ConditionType.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (ValueScale != 0)
		{
			num ^= ValueScale.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (NeedRestart != 0)
		{
			num ^= NeedRestart.GetHashCode();
		}
		num ^= configTabInfoEx_.GetHashCode();
		num ^= settingLockInfoEx_.GetHashCode();
		if (DetailDisplayType != UISettingDetailDisplayType.Text)
		{
			num ^= DetailDisplayType.GetHashCode();
		}
		if (InnerTabId != 0)
		{
			num ^= InnerTabId.GetHashCode();
		}
		if (ChangeFromUiOnly != 0)
		{
			num ^= ChangeFromUiOnly.GetHashCode();
		}
		if (ShowDefaultFlag != 0)
		{
			num ^= ShowDefaultFlag.GetHashCode();
		}
		if (NotResetFlag != 0)
		{
			num ^= NotResetFlag.GetHashCode();
		}
		if (Priority != 0)
		{
			num ^= Priority.GetHashCode();
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
		if (ConfigType != UISettingConfigType.Min)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ConfigType);
		}
		if (FunTempelte != SettingFunTempelte.ConsoleVariable)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)FunTempelte);
		}
		if (TempelteParam.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(TempelteParam);
		}
		if (ConfigName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ConfigName);
		}
		if (ConfigDesc.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(ConfigDesc);
		}
		if (DefaultValue != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(DefaultValue);
		}
		if (UiType != UIConfigType.FixedItem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)UiType);
		}
		params_.WriteTo(output, _repeated_params_codec);
		if (ShowType != 0)
		{
			output.WriteRawTag(80);
			output.WriteInt32(ShowType);
		}
		if (ConfigTab != EUIConfigTab.Gamepad)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)ConfigTab);
		}
		if (SaveType != UIConfigSaveType.Local)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)SaveType);
		}
		if (NeedInit != 0)
		{
			output.WriteRawTag(104);
			output.WriteInt32(NeedInit);
		}
		if (ConditionType != SettingBanConditionType.Dontban)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)ConditionType);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(120);
			output.WriteInt32(LocalizationTag);
		}
		if (ValueScale != 0)
		{
			output.WriteRawTag(128, 1);
			output.WriteInt32(ValueScale);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(136, 1);
			output.WriteInt32(SortId);
		}
		if (NeedRestart != 0)
		{
			output.WriteRawTag(144, 1);
			output.WriteInt32(NeedRestart);
		}
		configTabInfoEx_.WriteTo(output, _repeated_configTabInfoEx_codec);
		settingLockInfoEx_.WriteTo(output, _repeated_settingLockInfoEx_codec);
		if (DetailDisplayType != UISettingDetailDisplayType.Text)
		{
			output.WriteRawTag(168, 1);
			output.WriteEnum((int)DetailDisplayType);
		}
		if (InnerTabId != 0)
		{
			output.WriteRawTag(176, 1);
			output.WriteInt32(InnerTabId);
		}
		if (ChangeFromUiOnly != 0)
		{
			output.WriteRawTag(184, 1);
			output.WriteInt32(ChangeFromUiOnly);
		}
		if (ShowDefaultFlag != 0)
		{
			output.WriteRawTag(192, 1);
			output.WriteInt32(ShowDefaultFlag);
		}
		if (NotResetFlag != 0)
		{
			output.WriteRawTag(200, 1);
			output.WriteInt32(NotResetFlag);
		}
		if (Priority != 0)
		{
			output.WriteRawTag(208, 1);
			output.WriteInt32(Priority);
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
		if (ConfigType != UISettingConfigType.Min)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConfigType);
		}
		if (FunTempelte != SettingFunTempelte.ConsoleVariable)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FunTempelte);
		}
		if (TempelteParam.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TempelteParam);
		}
		if (ConfigName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigName);
		}
		if (ConfigDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ConfigDesc);
		}
		if (DefaultValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DefaultValue);
		}
		if (UiType != UIConfigType.FixedItem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UiType);
		}
		num += params_.CalculateSize(_repeated_params_codec);
		if (ShowType != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ShowType);
		}
		if (ConfigTab != EUIConfigTab.Gamepad)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConfigTab);
		}
		if (SaveType != UIConfigSaveType.Local)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)SaveType);
		}
		if (NeedInit != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(NeedInit);
		}
		if (ConditionType != SettingBanConditionType.Dontban)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ConditionType);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (ValueScale != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ValueScale);
		}
		if (SortId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (NeedRestart != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NeedRestart);
		}
		num += configTabInfoEx_.CalculateSize(_repeated_configTabInfoEx_codec);
		num += settingLockInfoEx_.CalculateSize(_repeated_settingLockInfoEx_codec);
		if (DetailDisplayType != UISettingDetailDisplayType.Text)
		{
			num += 2 + CodedOutputStream.ComputeEnumSize((int)DetailDisplayType);
		}
		if (InnerTabId != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(InnerTabId);
		}
		if (ChangeFromUiOnly != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ChangeFromUiOnly);
		}
		if (ShowDefaultFlag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(ShowDefaultFlag);
		}
		if (NotResetFlag != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(NotResetFlag);
		}
		if (Priority != 0)
		{
			num += 2 + CodedOutputStream.ComputeInt32Size(Priority);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(UISettingConfigDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.ConfigType != UISettingConfigType.Min)
			{
				ConfigType = other.ConfigType;
			}
			if (other.FunTempelte != SettingFunTempelte.ConsoleVariable)
			{
				FunTempelte = other.FunTempelte;
			}
			if (other.TempelteParam.Length != 0)
			{
				TempelteParam = other.TempelteParam;
			}
			if (other.ConfigName.Length != 0)
			{
				ConfigName = other.ConfigName;
			}
			if (other.ConfigDesc.Length != 0)
			{
				ConfigDesc = other.ConfigDesc;
			}
			if (other.DefaultValue != 0)
			{
				DefaultValue = other.DefaultValue;
			}
			if (other.UiType != UIConfigType.FixedItem)
			{
				UiType = other.UiType;
			}
			params_.Add(other.params_);
			if (other.ShowType != 0)
			{
				ShowType = other.ShowType;
			}
			if (other.ConfigTab != EUIConfigTab.Gamepad)
			{
				ConfigTab = other.ConfigTab;
			}
			if (other.SaveType != UIConfigSaveType.Local)
			{
				SaveType = other.SaveType;
			}
			if (other.NeedInit != 0)
			{
				NeedInit = other.NeedInit;
			}
			if (other.ConditionType != SettingBanConditionType.Dontban)
			{
				ConditionType = other.ConditionType;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.ValueScale != 0)
			{
				ValueScale = other.ValueScale;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.NeedRestart != 0)
			{
				NeedRestart = other.NeedRestart;
			}
			configTabInfoEx_.Add(other.configTabInfoEx_);
			settingLockInfoEx_.Add(other.settingLockInfoEx_);
			if (other.DetailDisplayType != UISettingDetailDisplayType.Text)
			{
				DetailDisplayType = other.DetailDisplayType;
			}
			if (other.InnerTabId != 0)
			{
				InnerTabId = other.InnerTabId;
			}
			if (other.ChangeFromUiOnly != 0)
			{
				ChangeFromUiOnly = other.ChangeFromUiOnly;
			}
			if (other.ShowDefaultFlag != 0)
			{
				ShowDefaultFlag = other.ShowDefaultFlag;
			}
			if (other.NotResetFlag != 0)
			{
				NotResetFlag = other.NotResetFlag;
			}
			if (other.Priority != 0)
			{
				Priority = other.Priority;
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
				ConfigType = (UISettingConfigType)input.ReadEnum();
				break;
			case 24u:
				FunTempelte = (SettingFunTempelte)input.ReadEnum();
				break;
			case 34u:
				TempelteParam = input.ReadString();
				break;
			case 42u:
				ConfigName = input.ReadString();
				break;
			case 50u:
				ConfigDesc = input.ReadString();
				break;
			case 56u:
				DefaultValue = input.ReadInt32();
				break;
			case 64u:
				UiType = (UIConfigType)input.ReadEnum();
				break;
			case 72u:
			case 74u:
				params_.AddEntriesFrom(input, _repeated_params_codec);
				break;
			case 80u:
				ShowType = input.ReadInt32();
				break;
			case 88u:
				ConfigTab = (EUIConfigTab)input.ReadEnum();
				break;
			case 96u:
				SaveType = (UIConfigSaveType)input.ReadEnum();
				break;
			case 104u:
				NeedInit = input.ReadInt32();
				break;
			case 112u:
				ConditionType = (SettingBanConditionType)input.ReadEnum();
				break;
			case 120u:
				LocalizationTag = input.ReadInt32();
				break;
			case 128u:
				ValueScale = input.ReadInt32();
				break;
			case 136u:
				SortId = input.ReadInt32();
				break;
			case 144u:
				NeedRestart = input.ReadInt32();
				break;
			case 154u:
				configTabInfoEx_.AddEntriesFrom(input, _repeated_configTabInfoEx_codec);
				break;
			case 162u:
				settingLockInfoEx_.AddEntriesFrom(input, _repeated_settingLockInfoEx_codec);
				break;
			case 168u:
				DetailDisplayType = (UISettingDetailDisplayType)input.ReadEnum();
				break;
			case 176u:
				InnerTabId = input.ReadInt32();
				break;
			case 184u:
				ChangeFromUiOnly = input.ReadInt32();
				break;
			case 192u:
				ShowDefaultFlag = input.ReadInt32();
				break;
			case 200u:
				NotResetFlag = input.ReadInt32();
				break;
			case 208u:
				Priority = input.ReadInt32();
				break;
			}
		}
	}
}
