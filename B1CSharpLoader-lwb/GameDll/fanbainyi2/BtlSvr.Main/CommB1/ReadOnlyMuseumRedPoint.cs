using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyMuseumRedPoint
{
	private MuseumRedPoint mData;

	private ReadOnlyInt32List _MvRedpoint;

	private ReadOnlyInt32List _SoundtrackRedpointList;

	public ReadOnlyInt32List MvRedpoint
	{
		get
		{
			if (_MvRedpoint == null)
			{
				_MvRedpoint = new ReadOnlyInt32List(mData.MvRedpoint);
			}
			return _MvRedpoint;
		}
	}

	public ReadOnlyInt32List SoundtrackRedpointList
	{
		get
		{
			if (_SoundtrackRedpointList == null)
			{
				_SoundtrackRedpointList = new ReadOnlyInt32List(mData.SoundtrackRedpointList);
			}
			return _SoundtrackRedpointList;
		}
	}

	public ReadOnlyMuseumRedPoint(MuseumRedPoint data)
	{
		mData = data;
	}

	public ReadOnlyMuseumRedPoint Clone()
	{
		return new ReadOnlyMuseumRedPoint(mData.Clone());
	}

	public MuseumRedPoint ForceGetRef()
	{
		return mData;
	}

	public MuseumRedPoint CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyMuseumRedPoint>{\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("MvRedpoint=[\n");
		for (int i = 0; i < MvRedpoint.Count; i++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", MvRedpoint[i]);
		}
		builder.Append(' ', cur_indent + indent);
		builder.Append("],\n");
		builder.Append(' ', cur_indent + indent);
		builder.Append("SoundtrackRedpointList=[\n");
		for (int j = 0; j < SoundtrackRedpointList.Count; j++)
		{
			builder.Append(' ', cur_indent + indent + indent);
			builder.AppendFormat("{0},\n", SoundtrackRedpointList[j]);
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
