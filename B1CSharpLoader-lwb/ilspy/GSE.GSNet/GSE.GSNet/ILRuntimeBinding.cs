using System;
using ILRuntime.Runtime.Enviorment;

namespace GSE.GSNet;

public class ILRuntimeBinding
{
	public static void Register(ILRuntime.Runtime.Enviorment.AppDomain appdomain)
	{
		appdomain.DelegateManager.RegisterMethodDelegate<int>();
		appdomain.DelegateManager.RegisterMethodDelegate<int>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, bool>();
		appdomain.DelegateManager.RegisterMethodDelegate<int, int>();
		appdomain.DelegateManager.RegisterMethodDelegate<byte[]>();
		appdomain.DelegateManager.RegisterMethodDelegate<ulong, byte[]>();
		appdomain.DelegateManager.RegisterMethodDelegate<ulong>();
		appdomain.DelegateManager.RegisterDelegateConvertor<NetChannel.OnClosed>((Delegate act) => (NetChannel.OnClosed)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<NetChannel.OnAuthSuccess>((Delegate act) => (NetChannel.OnAuthSuccess)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<NetChannel.OnConnectSuccess>((Delegate act) => (NetChannel.OnConnectSuccess)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<NetChannel.OnAuthFail>((Delegate act) => (NetChannel.OnAuthFail)delegate(int Code)
		{
			((Action<int>)act)(Code);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<NetChannel.OnRecvMsg>((Delegate act) => (NetChannel.OnRecvMsg)delegate(byte[] Buff)
		{
			((Action<byte[]>)act)(Buff);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<NetChannel.OnConnectFail>((Delegate act) => (NetChannel.OnConnectFail)delegate(int iRetryTimes, int iMaxRetryTimes)
		{
			((Action<int, int>)act)(iRetryTimes, iMaxRetryTimes);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ProxyRoleServerUpstream.OnServerConnectedHandler>((Delegate act) => (ProxyRoleServerUpstream.OnServerConnectedHandler)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ProxyRoleServerUpstream.OnServerClosedHandler>((Delegate act) => (ProxyRoleServerUpstream.OnServerClosedHandler)delegate
		{
			((Action)act)();
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ProxyRoleServerUpstream.OnSererClientResponseHandler>((Delegate act) => (ProxyRoleServerUpstream.OnSererClientResponseHandler)delegate(byte[] buffer)
		{
			((Action<byte[]>)act)(buffer);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ReverseProxyChannel.OnClientAuthSuccessHandler>((Delegate act) => (ReverseProxyChannel.OnClientAuthSuccessHandler)delegate(ulong roleid)
		{
			((Action<ulong>)act)(roleid);
		});
		appdomain.DelegateManager.RegisterDelegateConvertor<ReverseProxyChannel.OnClientMsgBuffRecvHandler>((Delegate act) => (ReverseProxyChannel.OnClientMsgBuffRecvHandler)delegate(ulong roleid, byte[] buffer)
		{
			((Action<ulong, byte[]>)act)(roleid, buffer);
		});
	}
}
