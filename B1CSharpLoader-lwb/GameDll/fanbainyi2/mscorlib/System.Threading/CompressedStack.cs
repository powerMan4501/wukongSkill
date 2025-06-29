using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Threading;

[Serializable]
public sealed class CompressedStack : ISerializable
{
	internal class CompressedStackRunData
	{
		internal CompressedStack cs;

		internal ContextCallback callBack;

		internal object state;

		internal CompressedStackSwitcher cssw;

		internal CompressedStackRunData(CompressedStack cs, ContextCallback cb, object state)
		{
			this.cs = cs;
			callBack = cb;
			this.state = state;
			cssw = default(CompressedStackSwitcher);
		}
	}

	private volatile PermissionListSet m_pls;

	[SecurityCritical]
	private volatile SafeCompressedStackHandle m_csHandle;

	private bool m_canSkipEvaluation;

	internal static volatile RuntimeHelpers.TryCode tryCode;

	internal static volatile RuntimeHelpers.CleanupCode cleanupCode;

	internal bool CanSkipEvaluation
	{
		get
		{
			return m_canSkipEvaluation;
		}
		private set
		{
			m_canSkipEvaluation = value;
		}
	}

	internal PermissionListSet PLS => m_pls;

	internal SafeCompressedStackHandle CompressedStackHandle
	{
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return m_csHandle;
		}
		[SecurityCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		private set
		{
			m_csHandle = value;
		}
	}

	[SecurityCritical]
	internal CompressedStack(SafeCompressedStackHandle csHandle)
	{
		m_csHandle = csHandle;
	}

	[SecurityCritical]
	private CompressedStack(SafeCompressedStackHandle csHandle, PermissionListSet pls)
	{
		m_csHandle = csHandle;
		m_pls = pls;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		CompleteConstruction(null);
		info.AddValue("PLS", m_pls);
	}

	private CompressedStack(SerializationInfo info, StreamingContext context)
	{
		m_pls = (PermissionListSet)info.GetValue("PLS", typeof(PermissionListSet));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static CompressedStack GetCompressedStack()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return GetCompressedStack(ref stackMark);
	}

	[SecurityCritical]
	internal static CompressedStack GetCompressedStack(ref StackCrawlMark stackMark)
	{
		CompressedStack innerCS = null;
		CompressedStack compressedStack;
		if (CodeAccessSecurityEngine.QuickCheckForAllDemands())
		{
			compressedStack = new CompressedStack(null);
			compressedStack.CanSkipEvaluation = true;
		}
		else if (CodeAccessSecurityEngine.AllDomainsHomogeneousWithNoStackModifiers())
		{
			compressedStack = new CompressedStack(GetDelayedCompressedStack(ref stackMark, walkStack: false));
			compressedStack.m_pls = PermissionListSet.CreateCompressedState_HG();
		}
		else
		{
			compressedStack = new CompressedStack(null);
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				compressedStack.CompressedStackHandle = GetDelayedCompressedStack(ref stackMark, walkStack: true);
				if (compressedStack.CompressedStackHandle != null && IsImmediateCompletionCandidate(compressedStack.CompressedStackHandle, out innerCS))
				{
					try
					{
						compressedStack.CompleteConstruction(innerCS);
					}
					finally
					{
						DestroyDCSList(compressedStack.CompressedStackHandle);
					}
				}
			}
		}
		return compressedStack;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static CompressedStack Capture()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return GetCompressedStack(ref stackMark);
	}

	[SecurityCritical]
	public static void Run(CompressedStack compressedStack, ContextCallback callback, object state)
	{
		if (compressedStack == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_NamedParamNull"), "compressedStack");
		}
		if (cleanupCode == null)
		{
			tryCode = runTryCode;
			cleanupCode = runFinallyCode;
		}
		CompressedStackRunData userData = new CompressedStackRunData(compressedStack, callback, state);
		RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(tryCode, cleanupCode, userData);
	}

	[SecurityCritical]
	internal static void runTryCode(object userData)
	{
		CompressedStackRunData compressedStackRunData = (CompressedStackRunData)userData;
		compressedStackRunData.cssw = SetCompressedStack(compressedStackRunData.cs, GetCompressedStackThread());
		compressedStackRunData.callBack(compressedStackRunData.state);
	}

	[SecurityCritical]
	[PrePrepareMethod]
	internal static void runFinallyCode(object userData, bool exceptionThrown)
	{
		CompressedStackRunData compressedStackRunData = (CompressedStackRunData)userData;
		compressedStackRunData.cssw.Undo();
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static CompressedStackSwitcher SetCompressedStack(CompressedStack cs, CompressedStack prevCS)
	{
		CompressedStackSwitcher result = default(CompressedStackSwitcher);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				SetCompressedStackThread(cs);
				result.prev_CS = prevCS;
				result.curr_CS = cs;
				result.prev_ADStack = SetAppDomainStack(cs);
			}
		}
		catch
		{
			result.UndoNoThrow();
			throw;
		}
		return result;
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	public CompressedStack CreateCopy()
	{
		return new CompressedStack(m_csHandle, m_pls);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static IntPtr SetAppDomainStack(CompressedStack cs)
	{
		return Thread.CurrentThread.SetAppDomainStack(cs?.CompressedStackHandle);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static void RestoreAppDomainStack(IntPtr appDomainStack)
	{
		Thread.CurrentThread.RestoreAppDomainStack(appDomainStack);
	}

	[SecurityCritical]
	internal static CompressedStack GetCompressedStackThread()
	{
		return Thread.CurrentThread.GetExecutionContextReader().SecurityContext.CompressedStack;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static void SetCompressedStackThread(CompressedStack cs)
	{
		Thread currentThread = Thread.CurrentThread;
		if (currentThread.GetExecutionContextReader().SecurityContext.CompressedStack != cs)
		{
			ExecutionContext mutableExecutionContext = currentThread.GetMutableExecutionContext();
			if (mutableExecutionContext.SecurityContext != null)
			{
				mutableExecutionContext.SecurityContext.CompressedStack = cs;
			}
			else if (cs != null)
			{
				SecurityContext securityContext = new SecurityContext();
				securityContext.CompressedStack = cs;
				mutableExecutionContext.SecurityContext = securityContext;
			}
		}
	}

	[SecurityCritical]
	internal bool CheckDemand(CodeAccessPermission demand, PermissionToken permToken, RuntimeMethodHandleInternal rmh)
	{
		CompleteConstruction(null);
		if (PLS == null)
		{
			return false;
		}
		PLS.CheckDemand(demand, permToken, rmh);
		return false;
	}

	[SecurityCritical]
	internal bool CheckDemandNoHalt(CodeAccessPermission demand, PermissionToken permToken, RuntimeMethodHandleInternal rmh)
	{
		CompleteConstruction(null);
		if (PLS == null)
		{
			return true;
		}
		return PLS.CheckDemand(demand, permToken, rmh);
	}

	[SecurityCritical]
	internal bool CheckSetDemand(PermissionSet pset, RuntimeMethodHandleInternal rmh)
	{
		CompleteConstruction(null);
		if (PLS == null)
		{
			return false;
		}
		return PLS.CheckSetDemand(pset, rmh);
	}

	[SecurityCritical]
	internal bool CheckSetDemandWithModificationNoHalt(PermissionSet pset, out PermissionSet alteredDemandSet, RuntimeMethodHandleInternal rmh)
	{
		alteredDemandSet = null;
		CompleteConstruction(null);
		if (PLS == null)
		{
			return true;
		}
		return PLS.CheckSetDemandWithModification(pset, out alteredDemandSet, rmh);
	}

	[SecurityCritical]
	internal void DemandFlagsOrGrantSet(int flags, PermissionSet grantSet)
	{
		CompleteConstruction(null);
		if (PLS != null)
		{
			PLS.DemandFlagsOrGrantSet(flags, grantSet);
		}
	}

	[SecurityCritical]
	internal void GetZoneAndOrigin(ArrayList zoneList, ArrayList originList, PermissionToken zoneToken, PermissionToken originToken)
	{
		CompleteConstruction(null);
		if (PLS != null)
		{
			PLS.GetZoneAndOrigin(zoneList, originList, zoneToken, originToken);
		}
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal void CompleteConstruction(CompressedStack innerCS)
	{
		if (PLS != null)
		{
			return;
		}
		PermissionListSet pls = PermissionListSet.CreateCompressedState(this, innerCS);
		lock (this)
		{
			if (PLS == null)
			{
				m_pls = pls;
			}
		}
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal static extern SafeCompressedStackHandle GetDelayedCompressedStack(ref StackCrawlMark stackMark, bool walkStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void DestroyDelayedCompressedStack(IntPtr unmanagedCompressedStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern void DestroyDCSList(SafeCompressedStackHandle compressedStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int GetDCSCount(SafeCompressedStackHandle compressedStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern bool IsImmediateCompletionCandidate(SafeCompressedStackHandle compressedStack, out CompressedStack innerCS);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern DomainCompressedStack GetDomainCompressedStack(SafeCompressedStackHandle compressedStack, int index);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void GetHomogeneousPLS(PermissionListSet hgPLS);
}
