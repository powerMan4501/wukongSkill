using System.Collections;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
internal class TransitionCall : IMessage, IInternalMessage, IMessageSink, ISerializable
{
	private IDictionary _props;

	private IntPtr _sourceCtxID;

	private IntPtr _targetCtxID;

	private int _targetDomainID;

	private ServerIdentity _srvID;

	private Identity _ID;

	private CrossContextDelegate _delegate;

	private IntPtr _eeData;

	public IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			if (_props == null)
			{
				lock (this)
				{
					if (_props == null)
					{
						_props = new Hashtable();
					}
				}
			}
			return _props;
		}
	}

	ServerIdentity IInternalMessage.ServerIdentityObject
	{
		[SecurityCritical]
		get
		{
			if (_targetDomainID != 0 && _srvID == null)
			{
				lock (this)
				{
					Context contextInternal = Thread.GetContextInternal(_targetCtxID);
					if (contextInternal == null)
					{
						contextInternal = Context.DefaultContext;
					}
					_srvID = new ServerIdentity(null, Thread.GetContextInternal(_targetCtxID));
					_srvID.RaceSetServerObjectChain(this);
				}
			}
			return _srvID;
		}
		[SecurityCritical]
		set
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
		}
	}

	Identity IInternalMessage.IdentityObject
	{
		[SecurityCritical]
		get
		{
			return _ID;
		}
		[SecurityCritical]
		set
		{
			throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
		}
	}

	public IMessageSink NextSink
	{
		[SecurityCritical]
		get
		{
			return null;
		}
	}

	[SecurityCritical]
	internal TransitionCall(IntPtr targetCtxID, CrossContextDelegate deleg)
	{
		_sourceCtxID = Thread.CurrentContext.InternalContextID;
		_targetCtxID = targetCtxID;
		_delegate = deleg;
		_targetDomainID = 0;
		_eeData = IntPtr.Zero;
		_srvID = new ServerIdentity(null, Thread.GetContextInternal(_targetCtxID));
		_ID = _srvID;
		_ID.RaceSetChannelSink(CrossContextChannel.MessageSink);
		_srvID.RaceSetServerObjectChain(this);
	}

	[SecurityCritical]
	internal TransitionCall(IntPtr targetCtxID, IntPtr eeData, int targetDomainID)
	{
		_sourceCtxID = Thread.CurrentContext.InternalContextID;
		_targetCtxID = targetCtxID;
		_delegate = null;
		_targetDomainID = targetDomainID;
		_eeData = eeData;
		_srvID = null;
		_ID = new Identity("TransitionCallURI", null);
		CrossAppDomainData data = new CrossAppDomainData(_targetCtxID, _targetDomainID, Identity.ProcessGuid);
		string objectURI;
		IMessageSink channelSink = CrossAppDomainChannel.AppDomainChannel.CreateMessageSink(null, data, out objectURI);
		_ID.RaceSetChannelSink(channelSink);
	}

	internal TransitionCall(SerializationInfo info, StreamingContext context)
	{
		if (info == null || context.State != StreamingContextStates.CrossAppDomain)
		{
			throw new ArgumentNullException("info");
		}
		_props = (IDictionary)info.GetValue("props", typeof(IDictionary));
		_delegate = (CrossContextDelegate)info.GetValue("delegate", typeof(CrossContextDelegate));
		_sourceCtxID = (IntPtr)info.GetValue("sourceCtxID", typeof(IntPtr));
		_targetCtxID = (IntPtr)info.GetValue("targetCtxID", typeof(IntPtr));
		_eeData = (IntPtr)info.GetValue("eeData", typeof(IntPtr));
		_targetDomainID = info.GetInt32("targetDomainID");
	}

	[SecurityCritical]
	void IInternalMessage.SetURI(string uri)
	{
		throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
	}

	[SecurityCritical]
	void IInternalMessage.SetCallContext(LogicalCallContext callContext)
	{
		throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
	}

	[SecurityCritical]
	bool IInternalMessage.HasProperties()
	{
		throw new RemotingException(Environment.GetResourceString("Remoting_Default"));
	}

	[SecurityCritical]
	public IMessage SyncProcessMessage(IMessage msg)
	{
		try
		{
			LogicalCallContext oldcctx = Message.PropagateCallContextFromMessageToThread(msg);
			if (_delegate != null)
			{
				_delegate();
			}
			else
			{
				CallBackHelper callBackHelper = new CallBackHelper(_eeData, bFromEE: true, _targetDomainID);
				CrossContextDelegate crossContextDelegate = callBackHelper.Func;
				crossContextDelegate();
			}
			Message.PropagateCallContextFromThreadToMessage(msg, oldcctx);
			return this;
		}
		catch (Exception e)
		{
			ReturnMessage returnMessage = new ReturnMessage(e, new ErrorMessage());
			returnMessage.SetLogicalCallContext((LogicalCallContext)msg.Properties[Message.CallContextKey]);
			return returnMessage;
		}
	}

	[SecurityCritical]
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
	{
		IMessage msg2 = SyncProcessMessage(msg);
		replySink.SyncProcessMessage(msg2);
		return null;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null || context.State != StreamingContextStates.CrossAppDomain)
		{
			throw new ArgumentNullException("info");
		}
		info.AddValue("props", _props, typeof(IDictionary));
		info.AddValue("delegate", _delegate, typeof(CrossContextDelegate));
		info.AddValue("sourceCtxID", _sourceCtxID);
		info.AddValue("targetCtxID", _targetCtxID);
		info.AddValue("targetDomainID", _targetDomainID);
		info.AddValue("eeData", _eeData);
	}
}
