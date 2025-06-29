namespace System.Reflection.Emit;

internal sealed class __ExceptionInfo
{
	internal const int None = 0;

	internal const int Filter = 1;

	internal const int Finally = 2;

	internal const int Fault = 4;

	internal const int PreserveStack = 4;

	internal const int State_Try = 0;

	internal const int State_Filter = 1;

	internal const int State_Catch = 2;

	internal const int State_Finally = 3;

	internal const int State_Fault = 4;

	internal const int State_Done = 5;

	internal int m_startAddr;

	internal int[] m_filterAddr;

	internal int[] m_catchAddr;

	internal int[] m_catchEndAddr;

	internal int[] m_type;

	internal Type[] m_catchClass;

	internal Label m_endLabel;

	internal Label m_finallyEndLabel;

	internal int m_endAddr;

	internal int m_endFinally;

	internal int m_currentCatch;

	private int m_currentState;

	private __ExceptionInfo()
	{
		m_startAddr = 0;
		m_filterAddr = null;
		m_catchAddr = null;
		m_catchEndAddr = null;
		m_endAddr = 0;
		m_currentCatch = 0;
		m_type = null;
		m_endFinally = -1;
		m_currentState = 0;
	}

	internal __ExceptionInfo(int startAddr, Label endLabel)
	{
		m_startAddr = startAddr;
		m_endAddr = -1;
		m_filterAddr = new int[4];
		m_catchAddr = new int[4];
		m_catchEndAddr = new int[4];
		m_catchClass = new Type[4];
		m_currentCatch = 0;
		m_endLabel = endLabel;
		m_type = new int[4];
		m_endFinally = -1;
		m_currentState = 0;
	}

	private static Type[] EnlargeArray(Type[] incoming)
	{
		Type[] array = new Type[incoming.Length * 2];
		Array.Copy(incoming, array, incoming.Length);
		return array;
	}

	private void MarkHelper(int catchorfilterAddr, int catchEndAddr, Type catchClass, int type)
	{
		if (m_currentCatch >= m_catchAddr.Length)
		{
			m_filterAddr = ILGenerator.EnlargeArray(m_filterAddr);
			m_catchAddr = ILGenerator.EnlargeArray(m_catchAddr);
			m_catchEndAddr = ILGenerator.EnlargeArray(m_catchEndAddr);
			m_catchClass = EnlargeArray(m_catchClass);
			m_type = ILGenerator.EnlargeArray(m_type);
		}
		if (type == 1)
		{
			m_type[m_currentCatch] = type;
			m_filterAddr[m_currentCatch] = catchorfilterAddr;
			m_catchAddr[m_currentCatch] = -1;
			if (m_currentCatch > 0)
			{
				m_catchEndAddr[m_currentCatch - 1] = catchorfilterAddr;
			}
		}
		else
		{
			m_catchClass[m_currentCatch] = catchClass;
			if (m_type[m_currentCatch] != 1)
			{
				m_type[m_currentCatch] = type;
			}
			m_catchAddr[m_currentCatch] = catchorfilterAddr;
			if (m_currentCatch > 0 && m_type[m_currentCatch] != 1)
			{
				m_catchEndAddr[m_currentCatch - 1] = catchEndAddr;
			}
			m_catchEndAddr[m_currentCatch] = -1;
			m_currentCatch++;
		}
		if (m_endAddr == -1)
		{
			m_endAddr = catchorfilterAddr;
		}
	}

	internal void MarkFilterAddr(int filterAddr)
	{
		m_currentState = 1;
		MarkHelper(filterAddr, filterAddr, null, 1);
	}

	internal void MarkFaultAddr(int faultAddr)
	{
		m_currentState = 4;
		MarkHelper(faultAddr, faultAddr, null, 4);
	}

	internal void MarkCatchAddr(int catchAddr, Type catchException)
	{
		m_currentState = 2;
		MarkHelper(catchAddr, catchAddr, catchException, 0);
	}

	internal void MarkFinallyAddr(int finallyAddr, int endCatchAddr)
	{
		if (m_endFinally != -1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TooManyFinallyClause"));
		}
		m_currentState = 3;
		m_endFinally = finallyAddr;
		MarkHelper(finallyAddr, endCatchAddr, null, 2);
	}

	internal void Done(int endAddr)
	{
		m_catchEndAddr[m_currentCatch - 1] = endAddr;
		m_currentState = 5;
	}

	internal int GetStartAddress()
	{
		return m_startAddr;
	}

	internal int GetEndAddress()
	{
		return m_endAddr;
	}

	internal int GetFinallyEndAddress()
	{
		return m_endFinally;
	}

	internal Label GetEndLabel()
	{
		return m_endLabel;
	}

	internal int[] GetFilterAddresses()
	{
		return m_filterAddr;
	}

	internal int[] GetCatchAddresses()
	{
		return m_catchAddr;
	}

	internal int[] GetCatchEndAddresses()
	{
		return m_catchEndAddr;
	}

	internal Type[] GetCatchClass()
	{
		return m_catchClass;
	}

	internal int GetNumberOfCatches()
	{
		return m_currentCatch;
	}

	internal int[] GetExceptionTypes()
	{
		return m_type;
	}

	internal void SetFinallyEndLabel(Label lbl)
	{
		m_finallyEndLabel = lbl;
	}

	internal Label GetFinallyEndLabel()
	{
		return m_finallyEndLabel;
	}

	internal bool IsInner(__ExceptionInfo exc)
	{
		int num = exc.m_currentCatch - 1;
		int num2 = m_currentCatch - 1;
		if (exc.m_catchEndAddr[num] < m_catchEndAddr[num2])
		{
			return true;
		}
		if (exc.m_catchEndAddr[num] == m_catchEndAddr[num2] && exc.GetEndAddress() > GetEndAddress())
		{
			return true;
		}
		return false;
	}

	internal int GetCurrentState()
	{
		return m_currentState;
	}
}
