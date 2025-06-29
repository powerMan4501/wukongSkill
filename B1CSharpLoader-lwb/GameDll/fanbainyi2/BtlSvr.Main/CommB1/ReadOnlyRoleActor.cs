using System.Text;
using ArchiveB1;

namespace CommB1;

public class ReadOnlyRoleActor
{
	private RoleActor mData;

	private ReadOnlyActorWear _Wear;

	private ReadOnlyActorProgress _Progress;

	public ReadOnlyActorWear Wear
	{
		get
		{
			if (_Wear == null && mData.Wear != null)
			{
				_Wear = new ReadOnlyActorWear(mData.Wear);
			}
			return _Wear;
		}
	}

	public ReadOnlyActorProgress Progress
	{
		get
		{
			if (_Progress == null && mData.Progress != null)
			{
				_Progress = new ReadOnlyActorProgress(mData.Progress);
			}
			return _Progress;
		}
	}

	public int NewGamePlusCount => mData.NewGamePlusCount;

	public ReadOnlyRoleActor(RoleActor data)
	{
		mData = data;
	}

	public ReadOnlyRoleActor Clone()
	{
		return new ReadOnlyRoleActor(mData.Clone());
	}

	public RoleActor ForceGetRef()
	{
		return mData;
	}

	public RoleActor CloneData()
	{
		return mData.Clone();
	}

	public void DumpAsString(StringBuilder builder, int indent, int cur_indent)
	{
		builder.Append("<ReadOnlyRoleActor>{\n");
		if (Wear != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Wear=");
			Wear.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Wear=null,\n");
		}
		if (Progress != null)
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Progress=");
			Progress.DumpAsString(builder, indent, cur_indent + indent);
		}
		else
		{
			builder.Append(' ', cur_indent + indent);
			builder.Append("Progress=null,\n");
		}
		builder.Append(' ', cur_indent + indent);
		builder.AppendFormat("NewGamePlusCount={0},\n", NewGamePlusCount);
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
