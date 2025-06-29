using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_LocalBuilder))]
[ComVisible(true)]
public sealed class LocalBuilder : LocalVariableInfo, _LocalBuilder
{
	private int m_localIndex;

	private Type m_localType;

	private MethodInfo m_methodBuilder;

	private bool m_isPinned;

	public override bool IsPinned => m_isPinned;

	public override Type LocalType => m_localType;

	public override int LocalIndex => m_localIndex;

	private LocalBuilder()
	{
	}

	internal LocalBuilder(int localIndex, Type localType, MethodInfo methodBuilder)
		: this(localIndex, localType, methodBuilder, isPinned: false)
	{
	}

	internal LocalBuilder(int localIndex, Type localType, MethodInfo methodBuilder, bool isPinned)
	{
		m_isPinned = isPinned;
		m_localIndex = localIndex;
		m_localType = localType;
		m_methodBuilder = methodBuilder;
	}

	internal int GetLocalIndex()
	{
		return m_localIndex;
	}

	internal MethodInfo GetMethodBuilder()
	{
		return m_methodBuilder;
	}

	public void SetLocalSymInfo(string name)
	{
		SetLocalSymInfo(name, 0, 0);
	}

	public void SetLocalSymInfo(string name, int startOffset, int endOffset)
	{
		MethodBuilder methodBuilder = m_methodBuilder as MethodBuilder;
		if (methodBuilder == null)
		{
			throw new NotSupportedException();
		}
		ModuleBuilder moduleBuilder = (ModuleBuilder)methodBuilder.Module;
		if (methodBuilder.IsTypeCreated())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_TypeHasBeenCreated"));
		}
		if (moduleBuilder.GetSymWriter() == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotADebugModule"));
		}
		SignatureHelper fieldSigHelper = SignatureHelper.GetFieldSigHelper(moduleBuilder);
		fieldSigHelper.AddArgument(m_localType);
		int length;
		byte[] sourceArray = fieldSigHelper.InternalGetSignature(out length);
		byte[] array = new byte[length - 1];
		Array.Copy(sourceArray, 1, array, 0, length - 1);
		int currentActiveScopeIndex = methodBuilder.GetILGenerator().m_ScopeTree.GetCurrentActiveScopeIndex();
		if (currentActiveScopeIndex == -1)
		{
			methodBuilder.m_localSymInfo.AddLocalSymInfo(name, array, m_localIndex, startOffset, endOffset);
		}
		else
		{
			methodBuilder.GetILGenerator().m_ScopeTree.AddLocalSymInfoToCurrentScope(name, array, m_localIndex, startOffset, endOffset);
		}
	}

	void _LocalBuilder.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _LocalBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _LocalBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _LocalBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}
}
