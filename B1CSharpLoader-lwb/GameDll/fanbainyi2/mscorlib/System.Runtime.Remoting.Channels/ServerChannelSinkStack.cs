using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

[SecurityCritical]
[ComVisible(true)]
public class ServerChannelSinkStack : IServerChannelSinkStack, IServerResponseChannelSinkStack
{
	private class SinkStack
	{
		public SinkStack PrevStack;

		public IServerChannelSink Sink;

		public object State;
	}

	private SinkStack _stack;

	private SinkStack _rememberedStack;

	private IMessage _asyncMsg;

	private MethodInfo _asyncEnd;

	private object _serverObject;

	private IMethodCallMessage _msg;

	internal object ServerObject
	{
		set
		{
			_serverObject = value;
		}
	}

	[SecurityCritical]
	public void Push(IServerChannelSink sink, object state)
	{
		SinkStack sinkStack = new SinkStack();
		sinkStack.PrevStack = _stack;
		sinkStack.Sink = sink;
		sinkStack.State = state;
		_stack = sinkStack;
	}

	[SecurityCritical]
	public object Pop(IServerChannelSink sink)
	{
		if (_stack == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_PopOnEmptySinkStack"));
		}
		while (_stack.Sink != sink)
		{
			_stack = _stack.PrevStack;
			if (_stack == null)
			{
				break;
			}
		}
		if (_stack.Sink == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_PopFromSinkStackWithoutPush"));
		}
		object state = _stack.State;
		_stack = _stack.PrevStack;
		return state;
	}

	[SecurityCritical]
	public void Store(IServerChannelSink sink, object state)
	{
		if (_stack == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_StoreOnEmptySinkStack"));
		}
		while (_stack.Sink != sink)
		{
			_stack = _stack.PrevStack;
			if (_stack == null)
			{
				break;
			}
		}
		if (_stack.Sink == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_StoreOnSinkStackWithoutPush"));
		}
		SinkStack sinkStack = new SinkStack();
		sinkStack.PrevStack = _rememberedStack;
		sinkStack.Sink = sink;
		sinkStack.State = state;
		_rememberedStack = sinkStack;
		Pop(sink);
	}

	[SecurityCritical]
	public void StoreAndDispatch(IServerChannelSink sink, object state)
	{
		Store(sink, state);
		FlipRememberedStack();
		CrossContextChannel.DoAsyncDispatch(_asyncMsg, null);
	}

	private void FlipRememberedStack()
	{
		if (_stack != null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_CantCallFRSWhenStackEmtpy"));
		}
		while (_rememberedStack != null)
		{
			SinkStack sinkStack = new SinkStack();
			sinkStack.PrevStack = _stack;
			sinkStack.Sink = _rememberedStack.Sink;
			sinkStack.State = _rememberedStack.State;
			_stack = sinkStack;
			_rememberedStack = _rememberedStack.PrevStack;
		}
	}

	[SecurityCritical]
	public void AsyncProcessResponse(IMessage msg, ITransportHeaders headers, Stream stream)
	{
		if (_stack == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_CantCallAPRWhenStackEmpty"));
		}
		IServerChannelSink sink = _stack.Sink;
		object state = _stack.State;
		_stack = _stack.PrevStack;
		sink.AsyncProcessResponse(this, state, msg, headers, stream);
	}

	[SecurityCritical]
	public Stream GetResponseStream(IMessage msg, ITransportHeaders headers)
	{
		if (_stack == null)
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Channel_CantCallGetResponseStreamWhenStackEmpty"));
		}
		IServerChannelSink sink = _stack.Sink;
		object state = _stack.State;
		_stack = _stack.PrevStack;
		Stream responseStream = sink.GetResponseStream(this, state, msg, headers);
		Push(sink, state);
		return responseStream;
	}

	[SecurityCritical]
	public void ServerCallback(IAsyncResult ar)
	{
		if (_asyncEnd != null)
		{
			RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(_asyncEnd);
			MethodInfo mi = (MethodInfo)_msg.MethodBase;
			RemotingMethodCachedData reflectionCachedData2 = InternalRemotingServices.GetReflectionCachedData(mi);
			ParameterInfo[] parameters = reflectionCachedData.Parameters;
			object[] array = new object[parameters.Length];
			array[parameters.Length - 1] = ar;
			object[] args = _msg.Args;
			AsyncMessageHelper.GetOutArgs(reflectionCachedData2.Parameters, args, array);
			StackBuilderSink stackBuilderSink = new StackBuilderSink(_serverObject);
			object[] outArgs;
			object ret = stackBuilderSink.PrivateProcessMessage(_asyncEnd.MethodHandle, Message.CoerceArgs(_asyncEnd, array, parameters), _serverObject, out outArgs);
			if (outArgs != null)
			{
				outArgs = ArgMapper.ExpandAsyncEndArgsToSyncArgs(reflectionCachedData2, outArgs);
			}
			stackBuilderSink.CopyNonByrefOutArgsFromOriginalArgs(reflectionCachedData2, args, ref outArgs);
			IMessage msg = new ReturnMessage(ret, outArgs, _msg.ArgCount, Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext, _msg);
			AsyncProcessResponse(msg, null, null);
		}
	}
}
