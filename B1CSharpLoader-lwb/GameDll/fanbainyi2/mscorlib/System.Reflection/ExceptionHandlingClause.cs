using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection;

[ComVisible(true)]
public class ExceptionHandlingClause
{
	private MethodBody m_methodBody;

	private ExceptionHandlingClauseOptions m_flags;

	private int m_tryOffset;

	private int m_tryLength;

	private int m_handlerOffset;

	private int m_handlerLength;

	private int m_catchMetadataToken;

	private int m_filterOffset;

	public virtual ExceptionHandlingClauseOptions Flags => m_flags;

	public virtual int TryOffset => m_tryOffset;

	public virtual int TryLength => m_tryLength;

	public virtual int HandlerOffset => m_handlerOffset;

	public virtual int HandlerLength => m_handlerLength;

	public virtual int FilterOffset
	{
		get
		{
			if (m_flags != ExceptionHandlingClauseOptions.Filter)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_EHClauseNotFilter"));
			}
			return m_filterOffset;
		}
	}

	public virtual Type CatchType
	{
		get
		{
			if (m_flags != ExceptionHandlingClauseOptions.Clause)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Arg_EHClauseNotClause"));
			}
			Type result = null;
			if (!MetadataToken.IsNullToken(m_catchMetadataToken))
			{
				Type declaringType = m_methodBody.m_methodBase.DeclaringType;
				Module module = ((declaringType == null) ? m_methodBody.m_methodBase.Module : declaringType.Module);
				result = module.ResolveType(m_catchMetadataToken, (declaringType == null) ? null : declaringType.GetGenericArguments(), (m_methodBody.m_methodBase is MethodInfo) ? m_methodBody.m_methodBase.GetGenericArguments() : null);
			}
			return result;
		}
	}

	protected ExceptionHandlingClause()
	{
	}

	public override string ToString()
	{
		if (Flags == ExceptionHandlingClauseOptions.Clause)
		{
			return string.Format(CultureInfo.CurrentUICulture, "Flags={0}, TryOffset={1}, TryLength={2}, HandlerOffset={3}, HandlerLength={4}, CatchType={5}", Flags, TryOffset, TryLength, HandlerOffset, HandlerLength, CatchType);
		}
		if (Flags == ExceptionHandlingClauseOptions.Filter)
		{
			return string.Format(CultureInfo.CurrentUICulture, "Flags={0}, TryOffset={1}, TryLength={2}, HandlerOffset={3}, HandlerLength={4}, FilterOffset={5}", Flags, TryOffset, TryLength, HandlerOffset, HandlerLength, FilterOffset);
		}
		return string.Format(CultureInfo.CurrentUICulture, "Flags={0}, TryOffset={1}, TryLength={2}, HandlerOffset={3}, HandlerLength={4}", Flags, TryOffset, TryLength, HandlerOffset, HandlerLength);
	}
}
