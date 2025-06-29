using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Reflection;

[ComVisible(true)]
public class MethodBody
{
	private byte[] m_IL;

	private ExceptionHandlingClause[] m_exceptionHandlingClauses;

	private LocalVariableInfo[] m_localVariables;

	internal MethodBase m_methodBase;

	private int m_localSignatureMetadataToken;

	private int m_maxStackSize;

	private bool m_initLocals;

	public virtual int LocalSignatureMetadataToken => m_localSignatureMetadataToken;

	public virtual IList<LocalVariableInfo> LocalVariables => Array.AsReadOnly(m_localVariables);

	public virtual int MaxStackSize => m_maxStackSize;

	public virtual bool InitLocals => m_initLocals;

	public virtual IList<ExceptionHandlingClause> ExceptionHandlingClauses => Array.AsReadOnly(m_exceptionHandlingClauses);

	protected MethodBody()
	{
	}

	public virtual byte[] GetILAsByteArray()
	{
		return m_IL;
	}
}
