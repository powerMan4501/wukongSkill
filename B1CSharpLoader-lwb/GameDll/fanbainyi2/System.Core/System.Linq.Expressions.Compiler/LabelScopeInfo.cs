using System.Collections.Generic;

namespace System.Linq.Expressions.Compiler;

internal sealed class LabelScopeInfo
{
	private Dictionary<LabelTarget, LabelInfo> Labels;

	internal readonly LabelScopeKind Kind;

	internal readonly LabelScopeInfo Parent;

	internal bool CanJumpInto
	{
		get
		{
			LabelScopeKind kind = Kind;
			if ((uint)kind <= 3u)
			{
				return true;
			}
			return false;
		}
	}

	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind)
	{
		Parent = parent;
		Kind = kind;
	}

	internal bool ContainsTarget(LabelTarget target)
	{
		if (Labels == null)
		{
			return false;
		}
		return Labels.ContainsKey(target);
	}

	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info)
	{
		if (Labels == null)
		{
			info = null;
			return false;
		}
		return Labels.TryGetValue(target, out info);
	}

	internal void AddLabelInfo(LabelTarget target, LabelInfo info)
	{
		if (Labels == null)
		{
			Labels = new Dictionary<LabelTarget, LabelInfo>();
		}
		Labels.Add(target, info);
	}
}
