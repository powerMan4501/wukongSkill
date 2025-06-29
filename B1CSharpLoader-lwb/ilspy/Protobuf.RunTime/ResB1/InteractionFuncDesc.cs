using System;
using Google.Protobuf;

namespace ResB1;

public sealed class InteractionFuncDesc : IMessage<InteractionFuncDesc>, IMessage, IEquatable<InteractionFuncDesc>, IDeepCloneable<InteractionFuncDesc>
{
	private static readonly MessageParser<InteractionFuncDesc> _parser = new MessageParser<InteractionFuncDesc>(() => new InteractionFuncDesc());

	private UnknownFieldSet _unknownFields;

	private int id_;

	private EMenuBtnActionType menuBtnActionType_;

	private int parentId_;

	private int sortId_;

	private string name_ = "";

	private string tips_ = "";

	private int localizationTag_;

	private YesNoType newGamePlusClear_;

	public static MessageParser<InteractionFuncDesc> Parser => _parser;

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

	public EMenuBtnActionType MenuBtnActionType
	{
		get
		{
			return menuBtnActionType_;
		}
		set
		{
			menuBtnActionType_ = value;
		}
	}

	public int ParentId
	{
		get
		{
			return parentId_;
		}
		set
		{
			parentId_ = value;
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

	public string Name
	{
		get
		{
			return name_;
		}
		set
		{
			name_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	public string Tips
	{
		get
		{
			return tips_;
		}
		set
		{
			tips_ = ProtoPreconditions.CheckNotNull(value, "value");
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

	public YesNoType NewGamePlusClear
	{
		get
		{
			return newGamePlusClear_;
		}
		set
		{
			newGamePlusClear_ = value;
		}
	}

	public InteractionFuncDesc()
	{
	}

	public InteractionFuncDesc(InteractionFuncDesc other)
		: this()
	{
		id_ = other.id_;
		menuBtnActionType_ = other.menuBtnActionType_;
		parentId_ = other.parentId_;
		sortId_ = other.sortId_;
		name_ = other.name_;
		tips_ = other.tips_;
		localizationTag_ = other.localizationTag_;
		newGamePlusClear_ = other.newGamePlusClear_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	public InteractionFuncDesc Clone()
	{
		return new InteractionFuncDesc(this);
	}

	public override bool Equals(object other)
	{
		return Equals(other as InteractionFuncDesc);
	}

	public bool Equals(InteractionFuncDesc other)
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
		if (MenuBtnActionType != other.MenuBtnActionType)
		{
			return false;
		}
		if (ParentId != other.ParentId)
		{
			return false;
		}
		if (SortId != other.SortId)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (Tips != other.Tips)
		{
			return false;
		}
		if (LocalizationTag != other.LocalizationTag)
		{
			return false;
		}
		if (NewGamePlusClear != other.NewGamePlusClear)
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
		if (MenuBtnActionType != EMenuBtnActionType.None)
		{
			num ^= MenuBtnActionType.GetHashCode();
		}
		if (ParentId != 0)
		{
			num ^= ParentId.GetHashCode();
		}
		if (SortId != 0)
		{
			num ^= SortId.GetHashCode();
		}
		if (Name.Length != 0)
		{
			num ^= Name.GetHashCode();
		}
		if (Tips.Length != 0)
		{
			num ^= Tips.GetHashCode();
		}
		if (LocalizationTag != 0)
		{
			num ^= LocalizationTag.GetHashCode();
		}
		if (NewGamePlusClear != YesNoType.No)
		{
			num ^= NewGamePlusClear.GetHashCode();
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
		if (MenuBtnActionType != EMenuBtnActionType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)MenuBtnActionType);
		}
		if (ParentId != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(ParentId);
		}
		if (SortId != 0)
		{
			output.WriteRawTag(32);
			output.WriteInt32(SortId);
		}
		if (Name.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(Name);
		}
		if (Tips.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Tips);
		}
		if (LocalizationTag != 0)
		{
			output.WriteRawTag(56);
			output.WriteInt32(LocalizationTag);
		}
		if (NewGamePlusClear != YesNoType.No)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)NewGamePlusClear);
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
		if (MenuBtnActionType != EMenuBtnActionType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MenuBtnActionType);
		}
		if (ParentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(ParentId);
		}
		if (SortId != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(SortId);
		}
		if (Name.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (Tips.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Tips);
		}
		if (LocalizationTag != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(LocalizationTag);
		}
		if (NewGamePlusClear != YesNoType.No)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NewGamePlusClear);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	public void MergeFrom(InteractionFuncDesc other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.MenuBtnActionType != EMenuBtnActionType.None)
			{
				MenuBtnActionType = other.MenuBtnActionType;
			}
			if (other.ParentId != 0)
			{
				ParentId = other.ParentId;
			}
			if (other.SortId != 0)
			{
				SortId = other.SortId;
			}
			if (other.Name.Length != 0)
			{
				Name = other.Name;
			}
			if (other.Tips.Length != 0)
			{
				Tips = other.Tips;
			}
			if (other.LocalizationTag != 0)
			{
				LocalizationTag = other.LocalizationTag;
			}
			if (other.NewGamePlusClear != YesNoType.No)
			{
				NewGamePlusClear = other.NewGamePlusClear;
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
				MenuBtnActionType = (EMenuBtnActionType)input.ReadEnum();
				break;
			case 24u:
				ParentId = input.ReadInt32();
				break;
			case 32u:
				SortId = input.ReadInt32();
				break;
			case 42u:
				Name = input.ReadString();
				break;
			case 50u:
				Tips = input.ReadString();
				break;
			case 56u:
				LocalizationTag = input.ReadInt32();
				break;
			case 64u:
				NewGamePlusClear = (YesNoType)input.ReadEnum();
				break;
			}
		}
	}
}
