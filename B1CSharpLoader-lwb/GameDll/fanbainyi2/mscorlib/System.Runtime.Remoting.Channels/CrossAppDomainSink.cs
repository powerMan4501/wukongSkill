using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

internal class CrossAppDomainSink : InternalSink, IMessageSink
{
	internal const int GROW_BY = 8;

	internal static volatile int[] _sinkKeys;

	internal static volatile CrossAppDomainSink[] _sinks;

	internal const string LCC_DATA_KEY = "__xADCall";

	private static object staticSyncObject;

	private static InternalCrossContextDelegate s_xctxDel;

	internal CrossAppDomainData _xadData;

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	[SecuritySafeCritical]
	static CrossAppDomainSink()
	{
		staticSyncObject = new object();
		s_xctxDel = DoTransitionDispatchCallback;
	}

	internal CrossAppDomainSink(CrossAppDomainData xadData)
	{
		_xadData = xadData;
	}

	internal static void GrowArrays(int oldSize)
	{
		if (_sinks == null)
		{
			_sinks = new CrossAppDomainSink[8];
			_sinkKeys = new int[8];
			return;
		}
		CrossAppDomainSink[] array = new CrossAppDomainSink[_sinks.Length + 8];
		int[] array2 = new int[_sinkKeys.Length + 8];
		Array.Copy(_sinks, array, _sinks.Length);
		Array.Copy(_sinkKeys, array2, _sinkKeys.Length);
		_sinks = array;
		_sinkKeys = array2;
	}

	internal static CrossAppDomainSink FindOrCreateSink(CrossAppDomainData xadData)
	{
		lock (staticSyncObject)
		{
			int domainID = xadData.DomainID;
			if (_sinks == null)
			{
				GrowArrays(0);
			}
			int num = 0;
			while (_sinks[num] != null)
			{
				if (_sinkKeys[num] == domainID)
				{
					return _sinks[num];
				}
				num++;
				if (num == _sinks.Length)
				{
					GrowArrays(num);
					break;
				}
			}
			_sinks[num] = new CrossAppDomainSink(xadData);
			_sinkKeys[num] = domainID;
			return _sinks[num];
		}
	}

	internal static void DomainUnloaded(int domainID)
	{
		lock (staticSyncObject)
		{
			if (_sinks == null)
			{
				return;
			}
			int num = 0;
			int num2 = -1;
			while (_sinks[num] != null)
			{
				if (_sinkKeys[num] == domainID)
				{
					num2 = num;
				}
				num++;
				if (num == _sinks.Length)
				{
					break;
				}
			}
			if (num2 != -1)
			{
				_sinkKeys[num2] = _sinkKeys[num - 1];
				_sinks[num2] = _sinks[num - 1];
				_sinkKeys[num - 1] = 0;
				_sinks[num - 1] = null;
			}
		}
	}

	[SecurityCritical]
	internal static byte[] DoDispatch(byte[] reqStmBuff, SmuggledMethodCallMessage smuggledMcm, out SmuggledMethodReturnMessage smuggledMrm)
	{
		IMessage message = null;
		if (smuggledMcm != null)
		{
			ArrayList deserializedArgs = smuggledMcm.FixupForNewAppDomain();
			message = new MethodCall(smuggledMcm, deserializedArgs);
		}
		else
		{
			MemoryStream stm = new MemoryStream(reqStmBuff);
			message = CrossAppDomainSerializer.DeserializeMessage(stm);
		}
		LogicalCallContext logicalCallContext = Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext;
		logicalCallContext.SetData("__xADCall", true);
		IMessage message2 = ChannelServices.SyncDispatchMessage(message);
		logicalCallContext.FreeNamedDataSlot("__xADCall");
		smuggledMrm = SmuggledMethodReturnMessage.SmuggleIfPossible(message2);
		if (smuggledMrm != null)
		{
			return null;
		}
		if (message2 != null)
		{
			LogicalCallContext logicalCallContext2 = (LogicalCallContext)message2.Properties[Message.CallContextKey];
			if (logicalCallContext2 != null && logicalCallContext2.Principal != null)
			{
				logicalCallContext2.Principal = null;
			}
			return CrossAppDomainSerializer.SerializeMessage(message2).GetBuffer();
		}
		return null;
	}

	[SecurityCritical]
	internal static object DoTransitionDispatchCallback(object[] args)
	{
		byte[] reqStmBuff = (byte[])args[0];
		SmuggledMethodCallMessage smuggledMcm = (SmuggledMethodCallMessage)args[1];
		SmuggledMethodReturnMessage smuggledMrm = null;
		byte[] array = null;
		try
		{
			array = DoDispatch(reqStmBuff, smuggledMcm, out smuggledMrm);
		}
		catch (Exception e)
		{
			IMessage msg = new ReturnMessage(e, new ErrorMessage());
			array = CrossAppDomainSerializer.SerializeMessage(msg).GetBuffer();
			msg = null;
		}
		args[2] = smuggledMrm;
		return array;
	}

	[SecurityCritical]
	internal byte[] DoTransitionDispatch(byte[] reqStmBuff, SmuggledMethodCallMessage smuggledMcm, out SmuggledMethodReturnMessage smuggledMrm)
	{
		byte[] array = null;
		object[] array2 = new object[3] { reqStmBuff, smuggledMcm, null };
		array = (byte[])Thread.CurrentThread.InternalCrossContextCallback(null, _xadData.ContextID, _xadData.DomainID, s_xctxDel, array2);
		smuggledMrm = (SmuggledMethodReturnMessage)array2[2];
		return array;
	}

	[SecurityCritical]
	public virtual IMessage SyncProcessMessage(IMessage reqMsg)
	{
		IMessage message = InternalSink.ValidateMessage(reqMsg);
		if (message != null)
		{
			return message;
		}
		IPrincipal principal = null;
		IMessage message2 = null;
		try
		{
			if (reqMsg is IMethodCallMessage { LogicalCallContext: { } logicalCallContext })
			{
				principal = logicalCallContext.RemovePrincipalIfNotSerializable();
			}
			MemoryStream memoryStream = null;
			SmuggledMethodCallMessage smuggledMethodCallMessage = SmuggledMethodCallMessage.SmuggleIfPossible(reqMsg);
			if (smuggledMethodCallMessage == null)
			{
				memoryStream = CrossAppDomainSerializer.SerializeMessage(reqMsg);
			}
			LogicalCallContext logicalCallContext2 = CallContext.SetLogicalCallContext(null);
			MemoryStream memoryStream2 = null;
			byte[] array = null;
			SmuggledMethodReturnMessage smuggledMrm;
			try
			{
				array = ((smuggledMethodCallMessage == null) ? DoTransitionDispatch(memoryStream.GetBuffer(), null, out smuggledMrm) : DoTransitionDispatch(null, smuggledMethodCallMessage, out smuggledMrm));
			}
			finally
			{
				CallContext.SetLogicalCallContext(logicalCallContext2);
			}
			if (smuggledMrm != null)
			{
				ArrayList deserializedArgs = smuggledMrm.FixupForNewAppDomain();
				message2 = new MethodResponse((IMethodCallMessage)reqMsg, smuggledMrm, deserializedArgs);
			}
			else if (array != null)
			{
				memoryStream2 = new MemoryStream(array);
				message2 = CrossAppDomainSerializer.DeserializeMessage(memoryStream2, reqMsg as IMethodCallMessage);
			}
		}
		catch (Exception e)
		{
			try
			{
				message2 = new ReturnMessage(e, reqMsg as IMethodCallMessage);
			}
			catch (Exception)
			{
			}
		}
		if (principal != null && message2 is IMethodReturnMessage { LogicalCallContext: var logicalCallContext3 })
		{
			logicalCallContext3.Principal = principal;
		}
		return message2;
	}

	[SecurityCritical]
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
	{
		ADAsyncWorkItem aDAsyncWorkItem = new ADAsyncWorkItem(reqMsg, this, replySink);
		WaitCallback callBack = aDAsyncWorkItem.FinishAsyncWork;
		ThreadPool.QueueUserWorkItem(callBack);
		return null;
	}
}
