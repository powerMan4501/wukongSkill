using System;
using Google.Protobuf;
using Gs;
using GSE.OnlineBase;

namespace GSE.GSNet;

public class ReverseProxyChannel
{
	public delegate void OnClientMsgBuffRecvHandler(ulong roleid, byte[] buffer);

	public delegate void OnClientAuthSuccessHandler(ulong roleid);

	private ReverseProxyState state = new ReverseProxyState();

	private int DebugLocalServerDynamicBindingUpstreamIndex;

	public static OnClientMsgBuffRecvHandler DebugOnClientBufferRecvEvent;

	public static OnClientAuthSuccessHandler ClientAuthSuccessEvent;

	public static bool DebugLocalServer { get; set; }

	public override string ToString()
	{
		return state.bindUrl;
	}

	public bool Start(NetDriver driver, string Url)
	{
		if (driver == null)
		{
			LogHelper.LogError("start net connection:{0} but driver is null", Url);
			return false;
		}
		state.driver = driver;
		state.bindUrl = Url;
		if (!state.driver.Listen(OnNewClientConnx, OnClientConnxClosed, OnRecvClientConnx, Url, out var Error))
		{
			LogHelper.LogError("dirver listen fail err:{0} !", Error);
			return false;
		}
		LogHelper.LogWarn("listen ds final address:{0}", state.driver.ListeningAddress.ToString());
		return true;
	}

	public void Destroy()
	{
		CloseClientConnections();
		CloseUpstreamConnections();
		StopListen();
	}

	public void StopListen()
	{
		if (state.driver != null)
		{
			state.driver.StopListen();
			state.driver = null;
		}
	}

	public void CloseClientConnections()
	{
		foreach (ProxyRoleClientConnx connx in state.connxs)
		{
			CloseClientConnx(connx);
		}
		state.connxs.Clear();
	}

	public void CloseUpstreamConnections()
	{
		foreach (ProxyRoleServerUpstream upstream in state.upstreams)
		{
			upstream.server.Close();
			upstream.server = null;
			upstream.authed = false;
		}
		state.upstreams.Clear();
	}

	public void EnableUpstreamMsgRelay(bool bEnale, ulong RoleId = 0uL)
	{
		foreach (ProxyRoleServerUpstream upstream in state.upstreams)
		{
			if (upstream.RoleId == RoleId || RoleId == 0L)
			{
				upstream.relayDisable = !bEnale;
			}
		}
	}

	public void TickLowHz()
	{
		for (int num = state.connxs.Count - 1; num >= 0; num--)
		{
			if (state.connxs[num].connectState == TunnelConnectState.CHANNEL_STATE_CLOSED)
			{
				state.connxs.RemoveAt(num);
			}
			else if (state.connxs[num].connectState == TunnelConnectState.CHANNEL_STATE_AUTH && LocalTime.GetUnixTimeStamp() - state.connxs[num].stateChangeTime >= 10)
			{
				LogHelper.LogError("connection connecting upstream timeout");
				CloseClientConnx(state.connxs[num]);
			}
		}
	}

	public ProxyRoleServerUpstream FindUpstreamByRoleId(ulong RoleId)
	{
		for (int i = 0; i < state.upstreams.Count; i++)
		{
			if (state.upstreams[i].RoleId == RoleId)
			{
				return state.upstreams[i];
			}
		}
		return null;
	}

	private ProxyRoleClientConnx FindClientByUpstream(ProxyRoleServerUpstream stream)
	{
		if (stream == null)
		{
			return null;
		}
		for (int i = 0; i < state.connxs.Count; i++)
		{
			if (state.connxs[i].upstream == stream)
			{
				return state.connxs[i];
			}
		}
		return null;
	}

	public ProxyRoleClientConnx FindClientByRoleId(ulong RoleId)
	{
		for (int i = 0; i < state.upstreams.Count; i++)
		{
			if (state.upstreams[i].RoleId == RoleId)
			{
				return FindClientByUpstream(state.upstreams[i]);
			}
		}
		return null;
	}

	public bool StartCheckConnectToGameServer(ulong RoleId)
	{
		ProxyRoleServerUpstream proxyRoleServerUpstream = FindUpstreamByRoleId(RoleId);
		if (proxyRoleServerUpstream != null && proxyRoleServerUpstream.server == null)
		{
			return ReconnectToServer(proxyRoleServerUpstream);
		}
		return false;
	}

	public bool AddRoleAuth(ulong RoleId, ulong NetioAuthCookie, ulong ProxyAuthCookie, string UpUrl, bool ConnectServerImediately = false)
	{
		for (int i = 0; i < state.upstreams.Count; i++)
		{
			if (state.upstreams[i].RoleId == RoleId)
			{
				state.upstreams[i].NetioAuthCookie = NetioAuthCookie;
				state.upstreams[i].ProxyAuthCookie = ProxyAuthCookie;
				state.upstreams[i].upUrl = UpUrl;
				return true;
			}
		}
		ProxyRoleServerUpstream proxyRoleServerUpstream = new ProxyRoleServerUpstream
		{
			NetioAuthCookie = NetioAuthCookie,
			ProxyAuthCookie = ProxyAuthCookie,
			RoleId = RoleId,
			DsAuthToken = (ulong)new Random(1353623).Next(2000000000) + 1uL,
			upUrl = UpUrl,
			authed = false
		};
		if (ConnectServerImediately && !ReconnectToServer(proxyRoleServerUpstream))
		{
			return false;
		}
		state.upstreams.Add(proxyRoleServerUpstream);
		return true;
	}

	private void OnServerConnectStatus(ProxyRoleServerUpstream upstream, ulong Cookie, NetConnection connx, bool bSuccess, string Error)
	{
		if (Cookie != upstream.serverConnectCookie)
		{
			LogHelper.LogError("on server connect but cookie ({0},{1}) not equal !", Cookie, upstream.serverConnectCookie);
			return;
		}
		upstream.connectingServer = false;
		if (bSuccess)
		{
			upstream.server = connx;
			upstream.authed = false;
			upstream.verifyFailTimes = 0;
			LogHelper.LogInfo("role:{0} server:{1} connected, start authing ", upstream.RoleId, upstream.upUrl);
			UxNetMsg uxNetMsg = new UxNetMsg();
			uxNetMsg.Cmd = UxNetMsgCmd.AuthReq;
			uxNetMsg.AuthReq = new UxNetAuthReq
			{
				Proxy = new UxNetProxyHeader
				{
					RoleId = upstream.RoleId
				}
			};
			uxNetMsg.AuthToken = new UxNetAuthToken
			{
				NetioAuthCookie = upstream.NetioAuthCookie,
				ProxyAuthCookie = upstream.ProxyAuthCookie
			};
			ProxyRoleClientConnx proxyRoleClientConnx = FindClientByUpstream(upstream);
			if (proxyRoleClientConnx != null)
			{
				uxNetMsg.AuthReq.Proxy.ClientEp = proxyRoleClientConnx.client.Sock.RemoteEndPoint.ToString();
			}
			byte[] buff = PbEncoding.Encode(uxNetMsg);
			LowLevelServerFrameSend(upstream, buff);
		}
		else
		{
			LogHelper.LogError("role:{0} server:{1} connect fail:{2} retry:{3}", upstream.RoleId, upstream.upUrl, Error, upstream.retriedConnectTimes);
			if (upstream.retriedConnectTimes < 20)
			{
				ReconnectToServer(upstream);
			}
		}
	}

	public bool ReconnectToServer(ProxyRoleServerUpstream upstream)
	{
		if (DebugLocalServer)
		{
			upstream.server = null;
			upstream.connectingServer = false;
			upstream.authed = true;
			upstream.SessionTokenKey = 101010u;
			upstream.SessionTokenMagic = 1010101u;
			LogHelper.LogWarn("debug local server mode, no need to connecting game server .");
			return true;
		}
		if (upstream.connectingServer)
		{
			LogHelper.LogError("roleid:{0} is connecting server, reconnect is invalid !", upstream.RoleId);
			return false;
		}
		upstream.server = null;
		upstream.authed = false;
		upstream.retriedConnectTimes++;
		ulong Cookie = ++upstream.serverConnectCookie;
		if (!state.driver.Connect(delegate(NetConnection connx, bool bSuccess, string cError)
		{
			OnServerConnectStatus(upstream, Cookie, connx, bSuccess, cError);
		}, delegate
		{
			OnServerClosed(upstream, Cookie);
		}, delegate(byte[] Buffer, int Len)
		{
			OnServerReceived(upstream, Cookie, Buffer);
		}, upstream.upUrl, out var Error))
		{
			LogHelper.LogError("server connect url:{0} fail:{1}", upstream.upUrl, Error);
			return false;
		}
		upstream.connectingServer = true;
		return true;
	}

	private void OnServerClosed(ProxyRoleServerUpstream upstream, ulong Cookie)
	{
		if (Cookie != upstream.serverConnectCookie)
		{
			LogHelper.LogError("on server closed but cookie ({0},{1}) not equal !", Cookie, upstream.serverConnectCookie);
			return;
		}
		LogHelper.LogError("upstream role:{0} server closed retried:{1} will reconnecting", upstream.RoleId, upstream.retriedConnectTimes);
		ProxyRoleClientConnx proxyRoleClientConnx = FindClientByRoleId(upstream.RoleId);
		if (proxyRoleClientConnx != null)
		{
			CloseClientConnx(proxyRoleClientConnx);
		}
		upstream.OnServerClosedEvent?.Invoke();
		ReconnectToServer(upstream);
	}

	private void OnServerReceived(ProxyRoleServerUpstream upstream, ulong Cookie, byte[] Buffer)
	{
		if (Cookie != upstream.serverConnectCookie)
		{
			LogHelper.LogError("on server recv but cookie ({0},{1}) not equal !", Cookie, upstream.serverConnectCookie);
			return;
		}
		UxNetMsg uxNetMsg = PbEncoding.Decode<UxNetMsg>(Buffer);
		if (!upstream.authed)
		{
			if (uxNetMsg.Cmd != UxNetMsgCmd.AuthRes)
			{
				LogHelper.LogError("server auth received uxmsg cmd error:{0} !", uxNetMsg.Cmd);
			}
			else if (uxNetMsg.AuthRes.Ret == UxNetAuthResultType.UxnetAuthRetSuccess)
			{
				upstream.OnServerConnectedEvent?.Invoke();
				upstream.authed = true;
				upstream.SessionTokenKey = uxNetMsg.AuthRes.Token.SessionKey;
				upstream.SessionTokenMagic = uxNetMsg.AuthRes.Token.SessionMagic;
				ProxyRoleClientConnx proxyRoleClientConnx = FindClientByUpstream(upstream);
				if (proxyRoleClientConnx != null && proxyRoleClientConnx.connectState == TunnelConnectState.CHANNEL_STATE_AUTH_SUCCESS_WAIT_SERVER)
				{
					ClientAuthSucess(proxyRoleClientConnx);
				}
			}
			else
			{
				LogHelper.LogError("server auth received uxmsg auth fail error:{0} !", PbEncoding.ToStringInLine(uxNetMsg));
			}
		}
		else if (uxNetMsg.Cmd != UxNetMsgCmd.Payload)
		{
			LogHelper.LogError("server payload received uxmsg cmd error:{0} !", uxNetMsg.Cmd);
		}
		else if (!upstream.relayDisable)
		{
			upstream.OnServerClientResponseEvent?.Invoke(uxNetMsg.Payload.ToByteArray());
			ProxyRoleClientConnx proxyRoleClientConnx2 = FindClientByUpstream(upstream);
			if (proxyRoleClientConnx2 != null)
			{
				LowLevelClientFrameSend(proxyRoleClientConnx2, Buffer);
			}
		}
	}

	private void SwitchConnxState(ProxyRoleClientConnx connx, TunnelConnectState st)
	{
		LogHelper.LogError("WARNNING:connect state switch {0} -> {1}", connx.connectState, st);
		connx.connectState = st;
		connx.stateChangeTime = LocalTime.GetUnixTimeStamp();
	}

	private ProxyRoleServerUpstream VerifyAuthRole(ulong RoleId, ulong AuthToken)
	{
		for (int i = 0; i < state.upstreams.Count; i++)
		{
			if (state.upstreams[i].RoleId == RoleId)
			{
				ProxyRoleServerUpstream proxyRoleServerUpstream = state.upstreams[i];
				uint unixTimeStamp = LocalTime.GetUnixTimeStamp();
				if (proxyRoleServerUpstream.verifyFailTimes >= 50 && proxyRoleServerUpstream.lastVerifyCheckTime == unixTimeStamp)
				{
					return null;
				}
				if (proxyRoleServerUpstream.DsAuthToken == AuthToken)
				{
					return proxyRoleServerUpstream;
				}
				proxyRoleServerUpstream.verifyFailTimes++;
				proxyRoleServerUpstream.lastVerifyCheckTime = unixTimeStamp;
			}
		}
		if (DebugLocalServer)
		{
			for (int j = 0; j < state.upstreams.Count; j++)
			{
				if (state.upstreams[j].DsAuthToken == AuthToken)
				{
					return state.upstreams[j];
				}
			}
			if (state.upstreams.Count > 0)
			{
				ProxyRoleServerUpstream proxyRoleServerUpstream2 = state.upstreams[DebugLocalServerDynamicBindingUpstreamIndex % state.upstreams.Count];
				DebugLocalServerDynamicBindingUpstreamIndex++;
				if (AuthToken != 0)
				{
					proxyRoleServerUpstream2.DsAuthToken = AuthToken;
				}
				return proxyRoleServerUpstream2;
			}
		}
		return null;
	}

	private void CloseClientConnx(ProxyRoleClientConnx ProxyConnx)
	{
		if (ProxyConnx.client != null && ProxyConnx.connectState != TunnelConnectState.CHANNEL_STATE_CLOSED)
		{
			ProxyConnx.client.Close();
			ProxyConnx.client = null;
			SwitchConnxState(ProxyConnx, TunnelConnectState.CHANNEL_STATE_CLOSED);
			if (ProxyConnx.upstream != null && ProxyConnx.connectState == TunnelConnectState.CHANNEL_STATE_RELAY)
			{
				ProxyConnx.upstream = null;
			}
		}
	}

	private void ClientAuthSucess(ProxyRoleClientConnx ProxyConnx)
	{
		SendClientAuthSuccess(ProxyConnx);
		SwitchConnxState(ProxyConnx, TunnelConnectState.CHANNEL_STATE_RELAY);
		ProxyConnx.OnClientConnectedEvent?.Invoke();
	}

	private void OnRecvClientConnx(NetConnection client, byte[] Buffer, int Length)
	{
		LogHelper.LogWarn("client:{0} received msg buffer len:{1}", client.GetHashCode(), Length);
		ProxyRoleClientConnx proxyConnxByClient = GetProxyConnxByClient(client);
		if (proxyConnxByClient == null)
		{
			LogHelper.LogError("not found the connection client:{0}.", client.GetHashCode());
			client.Close();
		}
		else if (proxyConnxByClient.connectState == TunnelConnectState.CHANNEL_STATE_AUTH)
		{
			UxNetMsg uxNetMsg = PbEncoding.Decode<UxNetMsg>(Buffer);
			if (uxNetMsg.Cmd != UxNetMsgCmd.AuthReq)
			{
				LogHelper.LogError("auth state parse msg fail !");
				return;
			}
			ProxyRoleServerUpstream proxyRoleServerUpstream = VerifyAuthRole(uxNetMsg.AuthReq.Proxy.RoleId, uxNetMsg.AuthReq.Proxy.DsAuthToken);
			if (proxyRoleServerUpstream == null)
			{
				LogHelper.LogError("verify auth role fail:{0}", PbEncoding.ToStringInLine(uxNetMsg));
				CloseClientConnx(proxyConnxByClient);
				return;
			}
			ProxyRoleClientConnx proxyRoleClientConnx = FindClientByRoleId(proxyRoleServerUpstream.RoleId);
			if (proxyRoleClientConnx != null)
			{
				CloseClientConnx(proxyRoleClientConnx);
			}
			proxyConnxByClient.upstream = proxyRoleServerUpstream;
			if (proxyRoleServerUpstream.server != null || DebugLocalServer)
			{
				if (proxyRoleServerUpstream.authed)
				{
					ClientAuthSucess(proxyConnxByClient);
				}
				else
				{
					SwitchConnxState(proxyConnxByClient, TunnelConnectState.CHANNEL_STATE_AUTH_SUCCESS_WAIT_SERVER);
				}
				ClientAuthSuccessEvent?.Invoke(proxyRoleServerUpstream.RoleId);
			}
			else
			{
				ReconnectToServer(proxyRoleServerUpstream);
			}
		}
		else if (proxyConnxByClient.connectState == TunnelConnectState.CHANNEL_STATE_RELAY)
		{
			ProxyRoleServerUpstream upstream = proxyConnxByClient.upstream;
			if (upstream == null)
			{
				LogHelper.LogError("get client upstream fail");
				CloseClientConnx(proxyConnxByClient);
				return;
			}
			UxNetMsg uxNetMsg2 = PbEncoding.Decode<UxNetMsg>(Buffer);
			if (uxNetMsg2.Cmd != UxNetMsgCmd.Payload || uxNetMsg2.AuthToken.SessionKey != upstream.SessionTokenKey || uxNetMsg2.AuthToken.SessionMagic != upstream.SessionTokenMagic)
			{
				LogHelper.LogError("auth state parse msg cmd:{0} or verify cookie fail !", uxNetMsg2.Cmd);
				CloseClientConnx(proxyConnxByClient);
			}
			else if (upstream.authed)
			{
				if (DebugLocalServer)
				{
					DebugOnClientBufferRecvEvent?.Invoke(upstream.RoleId, uxNetMsg2.Payload.ToByteArray());
				}
				else if (!upstream.server.Send(Buffer))
				{
					LogHelper.LogError("forwarding upstream role:%{0} fail !", upstream.RoleId);
				}
			}
			else
			{
				LogHelper.LogError("forwarding upstream is not authed !");
			}
		}
		else
		{
			LogHelper.LogError("client state:{0} recv msg len:{1}", proxyConnxByClient.connectState, Buffer.Length);
		}
	}

	private ProxyRoleClientConnx GetProxyConnxByClient(NetConnection client)
	{
		for (int i = 0; i < state.connxs.Count; i++)
		{
			if (client == state.connxs[i].client)
			{
				return state.connxs[i];
			}
		}
		return null;
	}

	private void OnClientConnxClosed(NetConnection client)
	{
		LogHelper.LogWarn("client:{0} closed", client.GetHashCode());
		ProxyRoleClientConnx proxyConnxByClient = GetProxyConnxByClient(client);
		if (proxyConnxByClient != null)
		{
			proxyConnxByClient.OnClientClosedEvent?.Invoke();
			SwitchConnxState(proxyConnxByClient, TunnelConnectState.CHANNEL_STATE_CLOSED);
		}
	}

	private void OnNewClientConnx(NetConnection client)
	{
		ProxyRoleClientConnx proxyRoleClientConnx = new ProxyRoleClientConnx
		{
			client = client
		};
		SwitchConnxState(proxyRoleClientConnx, TunnelConnectState.CHANNEL_STATE_AUTH);
		state.connxs.Add(proxyRoleClientConnx);
		LogHelper.LogWarn("new connction:{0}<-{1}", proxyRoleClientConnx.GetHashCode(), client.GetHashCode());
	}

	private void SendClientAuthSuccess(ProxyRoleClientConnx connx)
	{
		byte[] buff = PbEncoding.Encode(new UxNetMsg
		{
			Cmd = UxNetMsgCmd.AuthRes,
			AuthRes = new UxNetAuthRes
			{
				Ret = UxNetAuthResultType.UxnetAuthRetSuccess,
				Token = new UxNetAuthToken
				{
					SessionKey = connx.upstream.SessionTokenKey,
					SessionMagic = connx.upstream.SessionTokenMagic
				}
			}
		});
		LowLevelClientFrameSend(connx, buff);
	}

	private bool LowLevelServerFrameSend(ProxyRoleServerUpstream stream, byte[] Buff)
	{
		int num = Buff.Length;
		if (num == 0)
		{
			LogHelper.LogError("error buff len:{0} {1}", Buff.Length, num);
			return false;
		}
		if (stream.server != null)
		{
			bool flag = stream.server.Send(Buff);
			if (!flag)
			{
				LogHelper.LogError("connect:{0} send fail buff len:{1} error:{2}", stream.server.ToString(), num, stream.server.GetError());
			}
			return flag;
		}
		return false;
	}

	public bool UxNetClientPayloadSend(ProxyRoleClientConnx connx, byte[] payload)
	{
		UxNetMsg uxNetMsg = new UxNetMsg();
		uxNetMsg.Cmd = UxNetMsgCmd.Payload;
		uxNetMsg.Payload = ByteString.CopyFrom(payload);
		uxNetMsg.AuthToken = new UxNetAuthToken();
		uxNetMsg.AuthToken.SessionKey = connx.upstream.SessionTokenKey;
		uxNetMsg.AuthToken.SessionMagic = connx.upstream.SessionTokenMagic;
		byte[] buff = PbEncoding.Encode(uxNetMsg);
		return LowLevelClientFrameSend(connx, buff);
	}

	private bool LowLevelClientFrameSend(ProxyRoleClientConnx connx, byte[] Buff)
	{
		int num = Buff.Length;
		if (num == 0)
		{
			LogHelper.LogError("error buff len:{0} {1}", Buff.Length, num);
			return false;
		}
		if (connx.client != null)
		{
			bool flag = connx.client.Send(Buff);
			if (!flag)
			{
				LogHelper.LogError("connect:{0} send fail buff len:{1} error:{2}", connx.client.ToString(), num, connx.client.GetError());
			}
			return flag;
		}
		return false;
	}
}
