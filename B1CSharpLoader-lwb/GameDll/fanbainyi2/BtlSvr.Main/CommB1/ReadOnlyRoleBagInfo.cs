using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleBagInfo
{
	private RoleBagInfo mData;

	private ReadOnlyInt32List _ActivatedWeaponIdList;

	private ReadOnlyAlchemyNpcCommunicationStatus _AlchemyNpcCommunicationStatus;

	private ReadOnlyEditionTypeList _EditionAwardList;

	public ulong EquipUidSeq => mData.EquipUidSeq;

	public ulong SoulSkillUidSeq => mData.SoulSkillUidSeq;

	public ReadOnlyInt32List ActivatedWeaponIdList
	{
		get
		{
			if (_ActivatedWeaponIdList == null)
			{
				_ActivatedWeaponIdList = new ReadOnlyInt32List(mData.ActivatedWeaponIdList);
			}
			return _ActivatedWeaponIdList;
		}
	}

	public ReadOnlyAlchemyNpcCommunicationStatus AlchemyNpcCommunicationStatus
	{
		get
		{
			if (_AlchemyNpcCommunicationStatus == null && mData.AlchemyNpcCommunicationStatus != null)
			{
				_AlchemyNpcCommunicationStatus = new ReadOnlyAlchemyNpcCommunicationStatus(mData.AlchemyNpcCommunicationStatus);
			}
			return _AlchemyNpcCommunicationStatus;
		}
	}

	public ulong WineUidSeq => mData.WineUidSeq;

	public ReadOnlyEditionTypeList EditionAwardList
	{
		get
		{
			if (_EditionAwardList == null)
			{
				_EditionAwardList = new ReadOnlyEditionTypeList(mData.EditionAwardList);
			}
			return _EditionAwardList;
		}
	}

	public ReadOnlyRoleBagInfo(RoleBagInfo data)
	{
		mData = data;
	}

	public ReadOnlyRoleBagInfo Clone()
	{
		return new ReadOnlyRoleBagInfo(mData.Clone());
	}

	public RoleBagInfo ForceGetRef()
	{
		return mData;
	}

	public RoleBagInfo CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleBagInfo>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("EquipUidSeq={0},\n", EquipUidSeq);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("SoulSkillUidSeq={0},\n", SoulSkillUidSeq);
		builder.Append(' ', cur_indent + indent);
		builder.Append("ActivatedWeaponIdList=[\n");
		for (int i = 0; i < ActivatedWeaponIdList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", ActivatedWeaponIdList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		if (AlchemyNpcCommunicationStatus != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("AlchemyNpcCommunicationStatus=");
			AlchemyNpcCommunicationStatus.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("AlchemyNpcCommunicationStatus=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("WineUidSeq={0},\n", WineUidSeq);
		builder.Append(' ', cur_indent + indent);
		builder.Append("EditionAwardList=[\n");
		for (int j = 0; j < EditionAwardList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", EditionAwardList[j]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent);
		builder.Append("},\n");
	}

	public string GSToString(int indent = 4)
	{
		StringBuilder stringBuilder = new StringBuilder();
		DumpAsString(stringBuilder, indent, 0);
		stringBuilder.Insert(0, "\n", 1);
		return stringBuilder.ToString();
	}
}
