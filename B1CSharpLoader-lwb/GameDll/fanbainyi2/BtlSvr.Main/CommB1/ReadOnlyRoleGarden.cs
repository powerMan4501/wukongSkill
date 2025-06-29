using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleGarden
{
	private RoleGarden mData;

	private ReadOnlyCropList _CropList;

	public ReadOnlyCropList CropList
	{
		get
		{
			if (_CropList == null)
			{
				_CropList = new ReadOnlyCropList(mData.CropList);
			}
			return _CropList;
		}
	}

	public float LastUpdateTime => mData.LastUpdateTime;

	public float LastCollectTime => mData.LastCollectTime;

	public ReadOnlyRoleGarden(RoleGarden data)
	{
		mData = data;
	}

	public ReadOnlyRoleGarden Clone()
	{
		return new ReadOnlyRoleGarden(mData.Clone());
	}

	public RoleGarden ForceGetRef()
	{
		return mData;
	}

	public RoleGarden CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleGarden>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("CropList=[\n");
		for (int i = 0; i < CropList.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			CropList[i].DumpAsString(builder, indent, cur_indent + indent + indent);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastUpdateTime={0},\n", LastUpdateTime);
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("LastCollectTime={0},\n", LastCollectTime);
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
