using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleMuseum
{
	private RoleMuseum mData;

	private ReadOnlyMuseumRedPoint _RedPoint;

	private ReadOnlyGlobalData _GlobalData;

	private ReadOnlyInt32List _MvIdList;

	private ReadOnlyInt32List _SoundtrackIdList;

	public ReadOnlyMuseumRedPoint RedPoint
	{
		get
		{
			if (_RedPoint == null && mData.RedPoint != null)
			{
				_RedPoint = new ReadOnlyMuseumRedPoint(mData.RedPoint);
			}
			return _RedPoint;
		}
	}

	public ReadOnlyGlobalData GlobalData
	{
		get
		{
			if (_GlobalData == null && mData.GlobalData != null)
			{
				_GlobalData = new ReadOnlyGlobalData(mData.GlobalData);
			}
			return _GlobalData;
		}
	}

	public ReadOnlyInt32List MvIdList
	{
		get
		{
			if (_MvIdList == null)
			{
				_MvIdList = new ReadOnlyInt32List(mData.MvIdList);
			}
			return _MvIdList;
		}
	}

	public ReadOnlyInt32List SoundtrackIdList
	{
		get
		{
			if (_SoundtrackIdList == null)
			{
				_SoundtrackIdList = new ReadOnlyInt32List(mData.SoundtrackIdList);
			}
			return _SoundtrackIdList;
		}
	}

	public ReadOnlyRoleMuseum(RoleMuseum data)
	{
		mData = data;
	}

	public ReadOnlyRoleMuseum Clone()
	{
		return new ReadOnlyRoleMuseum(mData.Clone());
	}

	public RoleMuseum ForceGetRef()
	{
		return mData;
	}

	public RoleMuseum CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleMuseum>{\n");
		if (RedPoint != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RedPoint=");
			RedPoint.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("RedPoint=null,\n");
		}
		if (GlobalData != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("GlobalData=");
			GlobalData.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("GlobalData=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("MvIdList=[\n");
		for (int i = 0; i < MvIdList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", MvIdList[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SoundtrackIdList=[\n");
		for (int j = 0; j < SoundtrackIdList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SoundtrackIdList[j]);
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
