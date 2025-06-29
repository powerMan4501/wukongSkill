using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Remoting.Proxies;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Remoting.Channels;

[ComVisible(true)]
public sealed class ChannelServices
{
	private static volatile object[] s_currentChannelData;

	private static object s_channelLock;

	private static volatile RegisteredChannelList s_registeredChannels;

	private static volatile IMessageSink xCtxChannel;

	[SecurityCritical]
	private unsafe static volatile Perf_Contexts* perf_Contexts;

	private static bool unloadHandlerRegistered;

	internal static object[] CurrentChannelData
	{
		[SecurityCritical]
		get
		{
			if (s_currentChannelData == null)
			{
				RefreshChannelData();
			}
			return s_currentChannelData;
		}
	}

	private static long remoteCalls
	{
		get
		{
			return Thread.GetDomain().RemotingData.ChannelServicesData.remoteCalls;
		}
		set
		{
			Thread.GetDomain().RemotingData.ChannelServicesData.remoteCalls = value;
		}
	}

	public static IChannel[] RegisteredChannels
	{
		[SecurityCritical]
		get
		{
			RegisteredChannelList registeredChannelList = s_registeredChannels;
			int count = registeredChannelList.Count;
			if (count == 0)
			{
				return new IChannel[0];
			}
			int num = count - 1;
			int num2 = 0;
			IChannel[] array = new IChannel[num];
			for (int i = 0; i < count; i++)
			{
				IChannel channel = registeredChannelList.GetChannel(i);
				if (!(channel is CrossAppDomainChannel))
				{
					array[num2++] = channel;
				}
			}
			return array;
		}
	}

	[SecuritySafeCritical]
	static unsafe ChannelServices()
	{
		s_currentChannelData = null;
		s_channelLock = new object();
		s_registeredChannels = new RegisteredChannelList();
		perf_Contexts = GetPrivateContextsPerfCounters();
		unloadHandlerRegistered = false;
	}

	private ChannelServices()
	{
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private unsafe static extern Perf_Contexts* GetPrivateContextsPerfCounters();

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity)
	{
		RegisterChannelInternal(chnl, ensureSecurity);
	}

	[SecuritySafeCritical]
	[Obsolete("Use System.Runtime.Remoting.ChannelServices.RegisterChannel(IChannel chnl, bool ensureSecurity) instead.", false)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static void RegisterChannel(IChannel chnl)
	{
		RegisterChannelInternal(chnl, ensureSecurity: false);
	}

	[SecurityCritical]
	internal unsafe static void RegisterChannelInternal(IChannel chnl, bool ensureSecurity)
	{
		if (chnl == null)
		{
			throw new ArgumentNullException("chnl");
		}
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(s_channelLock, ref lockTaken);
			string channelName = chnl.ChannelName;
			RegisteredChannelList registeredChannelList = s_registeredChannels;
			if (channelName == null || channelName.Length == 0 || -1 == registeredChannelList.FindChannelIndex(chnl.ChannelName))
			{
				if (ensureSecurity)
				{
					if (!(chnl is ISecurableChannel securableChannel))
					{
						throw new RemotingException(Environment.GetResourceString("Remoting_Channel_CannotBeSecured", chnl.ChannelName ?? chnl.ToString()));
					}
					securableChannel.IsSecured = ensureSecurity;
				}
				RegisteredChannel[] registeredChannels = registeredChannelList.RegisteredChannels;
				RegisteredChannel[] array = null;
				array = ((registeredChannels != null) ? new RegisteredChannel[registeredChannels.Length + 1] : new RegisteredChannel[1]);
				if (!unloadHandlerRegistered && !(chnl is CrossAppDomainChannel))
				{
					AppDomain.CurrentDomain.DomainUnload += UnloadHandler;
					unloadHandlerRegistered = true;
				}
				int channelPriority = chnl.ChannelPriority;
				int i;
				for (i = 0; i < registeredChannels.Length; i++)
				{
					RegisteredChannel registeredChannel = registeredChannels[i];
					if (channelPriority > registeredChannel.Channel.ChannelPriority)
					{
						array[i] = new RegisteredChannel(chnl);
						break;
					}
					array[i] = registeredChannel;
				}
				if (i == registeredChannels.Length)
				{
					array[registeredChannels.Length] = new RegisteredChannel(chnl);
				}
				else
				{
					for (; i < registeredChannels.Length; i++)
					{
						array[i + 1] = registeredChannels[i];
					}
				}
				if (perf_Contexts != null)
				{
					perf_Contexts->cChannels++;
				}
				s_registeredChannels = new RegisteredChannelList(array);
				RefreshChannelData();
				return;
			}
			throw new RemotingException(Environment.GetResourceString("Remoting_ChannelNameAlreadyRegistered", chnl.ChannelName));
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(s_channelLock);
			}
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public unsafe static void UnregisterChannel(IChannel chnl)
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(s_channelLock, ref lockTaken);
			if (chnl != null)
			{
				RegisteredChannelList registeredChannelList = s_registeredChannels;
				int num = registeredChannelList.FindChannelIndex(chnl);
				if (-1 == num)
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_ChannelNotRegistered", chnl.ChannelName));
				}
				RegisteredChannel[] registeredChannels = registeredChannelList.RegisteredChannels;
				RegisteredChannel[] array = null;
				array = new RegisteredChannel[registeredChannels.Length - 1];
				if (chnl is IChannelReceiver channelReceiver)
				{
					channelReceiver.StopListening(null);
				}
				int num2 = 0;
				int num3 = 0;
				while (num3 < registeredChannels.Length)
				{
					if (num3 == num)
					{
						num3++;
						continue;
					}
					array[num2] = registeredChannels[num3];
					num2++;
					num3++;
				}
				if (perf_Contexts != null)
				{
					perf_Contexts->cChannels--;
				}
				s_registeredChannels = new RegisteredChannelList(array);
			}
			RefreshChannelData();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(s_channelLock);
			}
		}
	}

	[SecurityCritical]
	internal static IMessageSink CreateMessageSink(string url, object data, out string objectURI)
	{
		IMessageSink messageSink = null;
		objectURI = null;
		RegisteredChannelList registeredChannelList = s_registeredChannels;
		int count = registeredChannelList.Count;
		for (int i = 0; i < count; i++)
		{
			if (registeredChannelList.IsSender(i))
			{
				IChannelSender channelSender = (IChannelSender)registeredChannelList.GetChannel(i);
				messageSink = channelSender.CreateMessageSink(url, data, out objectURI);
				if (messageSink != null)
				{
					break;
				}
			}
		}
		if (objectURI == null)
		{
			objectURI = url;
		}
		return messageSink;
	}

	[SecurityCritical]
	internal static IMessageSink CreateMessageSink(object data)
	{
		string objectURI;
		return CreateMessageSink(null, data, out objectURI);
	}

	[SecurityCritical]
	public static IChannel GetChannel(string name)
	{
		RegisteredChannelList registeredChannelList = s_registeredChannels;
		int num = registeredChannelList.FindChannelIndex(name);
		if (0 <= num)
		{
			IChannel channel = registeredChannelList.GetChannel(num);
			if (channel is CrossAppDomainChannel || channel is CrossContextChannel)
			{
				return null;
			}
			return channel;
		}
		return null;
	}

	[SecurityCritical]
	public static string[] GetUrlsForObject(MarshalByRefObject obj)
	{
		if (obj == null)
		{
			return null;
		}
		RegisteredChannelList registeredChannelList = s_registeredChannels;
		int count = registeredChannelList.Count;
		Hashtable hashtable = new Hashtable();
		bool fServer;
		Identity identity = MarshalByRefObject.GetIdentity(obj, out fServer);
		if (identity != null)
		{
			string objURI = identity.ObjURI;
			if (objURI != null)
			{
				for (int i = 0; i < count; i++)
				{
					if (!registeredChannelList.IsReceiver(i))
					{
						continue;
					}
					try
					{
						string[] urlsForUri = ((IChannelReceiver)registeredChannelList.GetChannel(i)).GetUrlsForUri(objURI);
						for (int j = 0; j < urlsForUri.Length; j++)
						{
							hashtable.Add(urlsForUri[j], urlsForUri[j]);
						}
					}
					catch (NotSupportedException)
					{
					}
				}
			}
		}
		ICollection keys = hashtable.Keys;
		string[] array = new string[keys.Count];
		int num = 0;
		foreach (string item in keys)
		{
			array[num++] = item;
		}
		return array;
	}

	[SecurityCritical]
	internal static IMessageSink GetChannelSinkForProxy(object obj)
	{
		IMessageSink result = null;
		if (RemotingServices.IsTransparentProxy(obj))
		{
			RealProxy realProxy = RemotingServices.GetRealProxy(obj);
			if (realProxy is RemotingProxy { IdentityObject: var identityObject })
			{
				result = identityObject.ChannelSink;
			}
		}
		return result;
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.RemotingConfiguration)]
	public static IDictionary GetChannelSinkProperties(object obj)
	{
		IMessageSink channelSinkForProxy = GetChannelSinkForProxy(obj);
		IClientChannelSink clientChannelSink = channelSinkForProxy as IClientChannelSink;
		if (clientChannelSink != null)
		{
			ArrayList arrayList = new ArrayList();
			do
			{
				IDictionary properties = clientChannelSink.Properties;
				if (properties != null)
				{
					arrayList.Add(properties);
				}
				clientChannelSink = clientChannelSink.NextChannelSink;
			}
			while (clientChannelSink != null);
			return new AggregateDictionary(arrayList);
		}
		if (channelSinkForProxy is IDictionary result)
		{
			return result;
		}
		return null;
	}

	internal static IMessageSink GetCrossContextChannelSink()
	{
		if (xCtxChannel == null)
		{
			xCtxChannel = CrossContextChannel.MessageSink;
		}
		return xCtxChannel;
	}

	[SecurityCritical]
	internal unsafe static void IncrementRemoteCalls(long cCalls)
	{
		remoteCalls += cCalls;
		if (perf_Contexts != null)
		{
			perf_Contexts->cRemoteCalls += (int)cCalls;
		}
	}

	[SecurityCritical]
	internal static void IncrementRemoteCalls()
	{
		IncrementRemoteCalls(1L);
	}

	[SecurityCritical]
	internal static void RefreshChannelData()
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(s_channelLock, ref lockTaken);
			s_currentChannelData = CollectChannelDataFromChannels();
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(s_channelLock);
			}
		}
	}

	[SecurityCritical]
	private static object[] CollectChannelDataFromChannels()
	{
		RemotingServices.RegisterWellKnownChannels();
		RegisteredChannelList registeredChannelList = s_registeredChannels;
		int count = registeredChannelList.Count;
		int receiverCount = registeredChannelList.ReceiverCount;
		object[] array = new object[receiverCount];
		int num = 0;
		int i = 0;
		int num2 = 0;
		for (; i < count; i++)
		{
			IChannel channel = registeredChannelList.GetChannel(i);
			if (channel == null)
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_ChannelNotRegistered", ""));
			}
			if (registeredChannelList.IsReceiver(i))
			{
				if ((array[num2] = ((IChannelReceiver)channel).ChannelData) != null)
				{
					num++;
				}
				num2++;
			}
		}
		if (num != receiverCount)
		{
			object[] array2 = new object[num];
			int num3 = 0;
			for (int j = 0; j < receiverCount; j++)
			{
				object obj = array[j];
				if (obj != null)
				{
					array2[num3++] = obj;
				}
			}
			array = array2;
		}
		return array;
	}

	private static bool IsMethodReallyPublic(MethodInfo mi)
	{
		if (!mi.IsPublic || mi.IsStatic)
		{
			return false;
		}
		if (!mi.IsGenericMethod)
		{
			return true;
		}
		Type[] genericArguments = mi.GetGenericArguments();
		foreach (Type type in genericArguments)
		{
			if (!type.IsVisible)
			{
				return false;
			}
		}
		return true;
	}

	[SecurityCritical]
	public static ServerProcessing DispatchMessage(IServerChannelSinkStack sinkStack, IMessage msg, out IMessage replyMsg)
	{
		ServerProcessing serverProcessing = ServerProcessing.Complete;
		replyMsg = null;
		try
		{
			if (msg == null)
			{
				throw new ArgumentNullException("msg");
			}
			IncrementRemoteCalls();
			ServerIdentity serverIdentity = CheckDisconnectedOrCreateWellKnownObject(msg);
			if (serverIdentity.ServerType == typeof(AppDomain))
			{
				throw new RemotingException(Environment.GetResourceString("Remoting_AppDomainsCantBeCalledRemotely"));
			}
			if (!(msg is IMethodCallMessage methodCallMessage))
			{
				if (!typeof(IMessageSink).IsAssignableFrom(serverIdentity.ServerType))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_AppDomainsCantBeCalledRemotely"));
				}
				serverProcessing = ServerProcessing.Complete;
				replyMsg = GetCrossContextChannelSink().SyncProcessMessage(msg);
			}
			else
			{
				MethodInfo methodInfo = (MethodInfo)methodCallMessage.MethodBase;
				if (!IsMethodReallyPublic(methodInfo) && !RemotingServices.IsMethodAllowedRemotely(methodInfo))
				{
					throw new RemotingException(Environment.GetResourceString("Remoting_NonPublicOrStaticCantBeCalledRemotely"));
				}
				RemotingMethodCachedData reflectionCachedData = InternalRemotingServices.GetReflectionCachedData(methodInfo);
				if (RemotingServices.IsOneWay(methodInfo))
				{
					serverProcessing = ServerProcessing.OneWay;
					GetCrossContextChannelSink().AsyncProcessMessage(msg, null);
				}
				else
				{
					serverProcessing = ServerProcessing.Complete;
					if (!serverIdentity.ServerType.IsContextful)
					{
						object[] args = new object[2] { msg, serverIdentity.ServerContext };
						replyMsg = (IMessage)CrossContextChannel.SyncProcessMessageCallback(args);
					}
					else
					{
						replyMsg = GetCrossContextChannelSink().SyncProcessMessage(msg);
					}
				}
			}
		}
		catch (Exception e)
		{
			if (serverProcessing != ServerProcessing.OneWay)
			{
				try
				{
					IMessage message2;
					if (msg == null)
					{
						IMessage message = new ErrorMessage();
						message2 = message;
					}
					else
					{
						message2 = msg;
					}
					IMethodCallMessage mcm = (IMethodCallMessage)message2;
					replyMsg = new ReturnMessage(e, mcm);
					if (msg != null)
					{
						((ReturnMessage)replyMsg).SetLogicalCallContext((LogicalCallContext)msg.Properties[Message.CallContextKey]);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return serverProcessing;
	}

	[SecurityCritical]
	public static IMessage SyncDispatchMessage(IMessage msg)
	{
		IMessage message = null;
		bool flag = false;
		try
		{
			if (msg == null)
			{
				throw new ArgumentNullException("msg");
			}
			IncrementRemoteCalls();
			if (!(msg is TransitionCall))
			{
				CheckDisconnectedOrCreateWellKnownObject(msg);
				MethodBase methodBase = ((IMethodMessage)msg).MethodBase;
				flag = RemotingServices.IsOneWay(methodBase);
			}
			IMessageSink crossContextChannelSink = GetCrossContextChannelSink();
			if (!flag)
			{
				message = crossContextChannelSink.SyncProcessMessage(msg);
			}
			else
			{
				crossContextChannelSink.AsyncProcessMessage(msg, null);
			}
		}
		catch (Exception e)
		{
			if (!flag)
			{
				try
				{
					IMessage message3;
					if (msg == null)
					{
						IMessage message2 = new ErrorMessage();
						message3 = message2;
					}
					else
					{
						message3 = msg;
					}
					IMethodCallMessage methodCallMessage = (IMethodCallMessage)message3;
					message = new ReturnMessage(e, methodCallMessage);
					if (msg != null)
					{
						((ReturnMessage)message).SetLogicalCallContext(methodCallMessage.LogicalCallContext);
					}
				}
				catch (Exception)
				{
				}
			}
		}
		return message;
	}

	[SecurityCritical]
	public static IMessageCtrl AsyncDispatchMessage(IMessage msg, IMessageSink replySink)
	{
		IMessageCtrl result = null;
		try
		{
			if (msg == null)
			{
				throw new ArgumentNullException("msg");
			}
			IncrementRemoteCalls();
			if (!(msg is TransitionCall))
			{
				CheckDisconnectedOrCreateWellKnownObject(msg);
			}
			result = GetCrossContextChannelSink().AsyncProcessMessage(msg, replySink);
		}
		catch (Exception e)
		{
			if (replySink != null)
			{
				try
				{
					IMethodCallMessage methodCallMessage = (IMethodCallMessage)msg;
					ReturnMessage returnMessage = new ReturnMessage(e, (IMethodCallMessage)msg);
					if (msg != null)
					{
						returnMessage.SetLogicalCallContext(methodCallMessage.LogicalCallContext);
					}
					replySink.SyncProcessMessage(returnMessage);
				}
				catch (Exception)
				{
				}
			}
		}
		return result;
	}

	[SecurityCritical]
	public static IServerChannelSink CreateServerChannelSinkChain(IServerChannelSinkProvider provider, IChannelReceiver channel)
	{
		if (provider == null)
		{
			return new DispatchChannelSink();
		}
		IServerChannelSinkProvider serverChannelSinkProvider = provider;
		while (serverChannelSinkProvider.Next != null)
		{
			serverChannelSinkProvider = serverChannelSinkProvider.Next;
		}
		serverChannelSinkProvider.Next = new DispatchChannelSinkProvider();
		IServerChannelSink result = provider.CreateSink(channel);
		serverChannelSinkProvider.Next = null;
		return result;
	}

	[SecurityCritical]
	internal static ServerIdentity CheckDisconnectedOrCreateWellKnownObject(IMessage msg)
	{
		ServerIdentity serverIdentity = InternalSink.GetServerIdentity(msg);
		if (serverIdentity == null || serverIdentity.IsRemoteDisconnected())
		{
			string uRI = InternalSink.GetURI(msg);
			if (uRI != null)
			{
				ServerIdentity serverIdentity2 = RemotingConfigHandler.CreateWellKnownObject(uRI);
				if (serverIdentity2 != null)
				{
					serverIdentity = serverIdentity2;
				}
			}
		}
		if (serverIdentity == null || serverIdentity.IsRemoteDisconnected())
		{
			string uRI2 = InternalSink.GetURI(msg);
			throw new RemotingException(Environment.GetResourceString("Remoting_Disconnected", uRI2));
		}
		return serverIdentity;
	}

	[SecurityCritical]
	internal static void UnloadHandler(object sender, EventArgs e)
	{
		StopListeningOnAllChannels();
	}

	[SecurityCritical]
	private static void StopListeningOnAllChannels()
	{
		try
		{
			RegisteredChannelList registeredChannelList = s_registeredChannels;
			int count = registeredChannelList.Count;
			for (int i = 0; i < count; i++)
			{
				if (registeredChannelList.IsReceiver(i))
				{
					IChannelReceiver channelReceiver = (IChannelReceiver)registeredChannelList.GetChannel(i);
					channelReceiver.StopListening(null);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[SecurityCritical]
	internal static void NotifyProfiler(IMessage msg, RemotingProfilerEvent profilerEvent)
	{
		switch (profilerEvent)
		{
		case RemotingProfilerEvent.ClientSend:
			if (RemotingServices.CORProfilerTrackRemoting())
			{
				RemotingServices.CORProfilerRemotingClientSendingMessage(out var id2, fIsAsync: false);
				if (RemotingServices.CORProfilerTrackRemotingCookie())
				{
					msg.Properties["CORProfilerCookie"] = id2;
				}
			}
			break;
		case RemotingProfilerEvent.ClientReceive:
		{
			if (!RemotingServices.CORProfilerTrackRemoting())
			{
				break;
			}
			Guid id = Guid.Empty;
			if (RemotingServices.CORProfilerTrackRemotingCookie())
			{
				object obj = msg.Properties["CORProfilerCookie"];
				if (obj != null)
				{
					id = (Guid)obj;
				}
			}
			RemotingServices.CORProfilerRemotingClientReceivingReply(id, fIsAsync: false);
			break;
		}
		}
	}

	[SecurityCritical]
	internal static string FindFirstHttpUrlForObject(string objectUri)
	{
		if (objectUri == null)
		{
			return null;
		}
		RegisteredChannelList registeredChannelList = s_registeredChannels;
		int count = registeredChannelList.Count;
		for (int i = 0; i < count; i++)
		{
			if (!registeredChannelList.IsReceiver(i))
			{
				continue;
			}
			IChannelReceiver channelReceiver = (IChannelReceiver)registeredChannelList.GetChannel(i);
			string fullName = channelReceiver.GetType().FullName;
			if (string.CompareOrdinal(fullName, "System.Runtime.Remoting.Channels.Http.HttpChannel") == 0 || string.CompareOrdinal(fullName, "System.Runtime.Remoting.Channels.Http.HttpServerChannel") == 0)
			{
				string[] urlsForUri = channelReceiver.GetUrlsForUri(objectUri);
				if (urlsForUri != null && urlsForUri.Length != 0)
				{
					return urlsForUri[0];
				}
			}
		}
		return null;
	}
}
