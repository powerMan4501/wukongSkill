using System.Reflection;

namespace System.Runtime.Serialization;

[Serializable]
internal class MemberHolder
{
	internal MemberInfo[] members;

	internal Type memberType;

	internal StreamingContext context;

	internal MemberHolder(Type type, StreamingContext ctx)
	{
		memberType = type;
		context = ctx;
	}

	public override int GetHashCode()
	{
		return memberType.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (!(obj is MemberHolder))
		{
			return false;
		}
		MemberHolder memberHolder = (MemberHolder)obj;
		if ((object)memberHolder.memberType == memberType && memberHolder.context.State == context.State)
		{
			return true;
		}
		return false;
	}
}
