using System.Net;
using Google.Protobuf;
using Gs;
using GSE.OnlineBase;

namespace GSE.GSNet;

public class NetChannel
{
	public delegate void OnRecvMsg(byte[] Buff);

	public delegate void OnClosed();

	public delegate void OnConnectFail(int iRetryTimes, int iMaxRetryTimes);

	public delegate void OnConnectSuccess();

	public delegate void OnAuthFail(int code);

	public delegate void OnAuthSuccess();

	public class ChannelNotifier
	{
		public OnRecvMsg onRecvMsg;

		public OnClosed onClosed;

		public OnConnectFail onConnectFail;

		public OnConnectSuccess onConnectSuccess;

		public OnAuthFail onAuthFail;

		public OnAuthSuccess onAuthSuccess;
	}

	public ChannelNotifier notifier = new ChannelNotifier();

	private ChannelContext context;

	private ChannelState state;

	public string LocalIp
	{
		get
		{
			if (context.attachUpstream != null)
			{
				if (context.attachUpstream.server != null && context.attachUpstream.server.Sock != null)
				{
					return (context.attachUpstream.server.Sock.LocalEndPoint as IPEndPoint).Address.ToString();
				}
				return "";
			}
			return (state.connection.Sock.LocalEndPoint as IPEndPoint).Address.ToString();
		}
	}

	public int LocalPort
	{
		get
		{
			if (context.attachUpstream != null)
			{
				if (context.attachUpstream.server != null && context.attachUpstream.server.Sock != null)
				{
					return (context.attachUpstream.server.Sock.LocalEndPoint as IPEndPoint).Port;
				}
				return 0;
			}
			return (state.connection.Sock.LocalEndPoint as IPEndPoint).Port;
		}
	}

	public bool IsConnecting => state.is_connecting;

	public string GetLastError()
	{
		if (state.connection != null)
		{
			state.connection.GetError();
		}
		if (context.attachUpstream != null && context.attachUpstream.server != null)
		{
			return context.attachUpstream.server.GetError();
		}
		return "";
	}

	public override string ToString()
	{
		if (context.name != null && context.uri != null)
		{
			return context.name + "|" + context.uri;
		}
		return "nil";
	}

	public bool Start(NetDriver driver, ChannelContext context)
	{
		if (driver == null)
		{
			LogHelper.LogError("start net connection:{0} but driver is null", context.url);
			return false;
		}
		state.driver = driver;
		state.retriedConnectTimes = 0;
		this.context = context;
		if (this.context.maxRetryConnectTimes < 1)
		{
			this.context.maxRetryConnectTimes = 1;
		}
		if (this.context.maxConnectingTimeoutSeconds <= 5)
		{
			this.context.maxConnectingTimeoutSeconds = 30;
		}
		if (context.attachUpstream != null)
		{
			context.attachUpstream.OnServerClientResponseEvent = delegate(byte[] Buffer)
			{
				notifier.onRecvMsg?.Invoke(Buffer);
			};
			return true;
		}
		return Connect();
	}

	private bool Connect()
	{
		if (IsConnecting)
		{
			LogHelper.LogError("connection is connecting , cant call connect again !! please check the logic bug .");
		}
		if (GetChannelState() != ChannelConnectState.CHANNEL_STATE_CLOSED && GetChannelState() != ChannelConnectState.CHANNEL_STATE_CONNECT)
		{
			Stop();
		}
		LogHelper.LogInfo("connect:{0}:{1} connect times:{2}/{3} ...", context.name, context.url, state.retriedConnectTimes, context.maxRetryConnectTimes);
		state.connectState = ChannelConnectState.CHANNEL_STATE_CONNECT;
		if (notifier.onConnectFail != null && state.retriedConnectTimes > 0)
		{
			notifier.onConnectFail(state.retriedConnectTimes, context.maxRetryConnectTimes);
		}
		if (state.retriedConnectTimes >= context.maxRetryConnectTimes)
		{
			LogHelper.LogError("connect:{0} connect reach max times:{1}", context.url, state.retriedConnectTimes);
			SwitchChannelState(ChannelConnectState.CHANNEL_STATE_CLOSED);
			return false;
		}
		state.retriedConnectTimes++;
		if (!state.driver.Connect(OnConnectStatus, OnConnectionClosed, OnRecvDataFrame, context.url, out var Error))
		{
			LogHelper.LogError("init connect:{0} fail error:{1}", context.url, Error);
			if (notifier.onConnectFail != null)
			{
				notifier.onConnectFail(context.maxRetryConnectTimes, context.maxRetryConnectTimes);
				SwitchChannelState(ChannelConnectState.CHANNEL_STATE_CLOSED);
			}
			return false;
		}
		context.uri = Error;
		state.is_connecting = true;
		return true;
	}

	public void Stop()
	{
		if (state.connection != null)
		{
			state.connection.Close();
			state.connection = null;
		}
		if (context.attachUpstream != null && context.attachUpstream.server != null)
		{
			context.attachUpstream.server.Close();
		}
		state.is_connecting = false;
		SwitchChannelState(ChannelConnectState.CHANNEL_STATE_CLOSED);
	}

	public void TickLowHz()
	{
		if (state.connection != null && GetChannelState() != ChannelConnectState.CHANNEL_STATE_RELAY && GetChannelState() != ChannelConnectState.CHANNEL_STATE_CLOSED && (int)(LocalTime.GetUnixTimeStamp() - state.stateChangeTime) > context.maxConnectingTimeoutSeconds)
		{
			LogHelper.LogError("connect connection:{0} state:{1} time out ", context.name, state.connectState);
			state.connection.Close();
			if (notifier.onClosed != null && GetChannelState() != ChannelConnectState.CHANNEL_STATE_CONNECT)
			{
				notifier.onClosed();
			}
			SwitchChannelState(ChannelConnectState.CHANNEL_STATE_CLOSED);
		}
	}

	public bool SendMsg(byte[] Buff, int iBuff = 0)
	{
		if (iBuff == 0)
		{
			iBuff = Buff.Length;
		}
		if (context.attachUpstream != null)
		{
			if (context.attachUpstream.authed)
			{
				byte[] buffer = PbEncoding.Encode(new UxNetMsg
				{
					Cmd = UxNetMsgCmd.Payload,
					Payload = ByteString.CopyFrom(Buff, 0, iBuff),
					AuthToken = new UxNetAuthToken
					{
						SessionMagic = context.attachUpstream.SessionTokenMagic,
						SessionKey = context.attachUpstream.SessionTokenKey,
						ProxyAuthCookie = context.attachUpstream.ProxyAuthCookie
					}
				});
				return context.attachUpstream.server.Send(buffer);
			}
			LogHelper.LogError("attached server is not connected");
			return false;
		}
		if (state.connectState != ChannelConnectState.CHANNEL_STATE_RELAY)
		{
			LogHelper.LogError("connect state:{0} cant send msg len:{1}", state.connectState, iBuff);
			return false;
		}
		byte[] buff = PbEncoding.Encode(new UxNetMsg
		{
			Cmd = UxNetMsgCmd.Payload,
			Payload = ByteString.CopyFrom(Buff, 0, iBuff),
			AuthToken = new UxNetAuthToken
			{
				SessionMagic = state.sessionKey.SessionMagic,
				SessionKey = state.sessionKey.SessionKey
			}
		});
		return LowLevelFrameSend(buff);
	}

	public ChannelConnectState GetChannelState()
	{
		if (context.attachUpstream != null)
		{
			if (context.attachUpstream.authed)
			{
				return ChannelConnectState.CHANNEL_STATE_RELAY;
			}
			if (context.attachUpstream.server != null)
			{
				if (context.attachUpstream.server.ConnectState == ConnctionState.CONNECTION_ESTABLISHED)
				{
					return ChannelConnectState.CHANNEL_STATE_AUTH;
				}
				return ChannelConnectState.CHANNEL_STATE_CONNECT;
			}
			return ChannelConnectState.CHANNEL_STATE_CONNECT;
		}
		return state.connectState;
	}

	private void SwitchChannelState(ChannelConnectState st)
	{
		LogHelper.LogError("WARNNING:connect state switch {0} -> {1}", state.connectState, st);
		state.connectState = st;
		state.stateChangeTime = LocalTime.GetUnixTimeStamp();
	}

	private void OnConnectStatus(NetConnection connx, bool bSuccess, string Error)
	{
		state.is_connecting = false;
		if (!bSuccess)
		{
			LogHelper.LogError("connect fail:{0} retry times:{1}/{2}", Error, state.retriedConnectTimes, context.maxRetryConnectTimes);
			Connect();
		}
		else
		{
			state.connection = connx;
			state.retriedConnectTimes = 0;
			SwitchChannelState(ChannelConnectState.CHANNEL_STATE_AUTH);
			SendAuth();
		}
	}

	private void SendAuth()
	{
		UxNetMsg uxNetMsg = new UxNetMsg();
		uxNetMsg.Cmd = UxNetMsgCmd.AuthReq;
		uxNetMsg.AuthReq = new UxNetAuthReq();
		if (context.connectToProxy)
		{
			uxNetMsg.AuthReq.Proxy = new UxNetProxyHeader
			{
				RoleId = context.ProxyAuthRoleId,
				DsAuthToken = context.DSAuthToken
			};
		}
		else
		{
			uxNetMsg.AuthReq.Token = context.authToken;
			uxNetMsg.AuthReq.EnvPacked = ByteString.CopyFrom(context.loginEnv);
			uxNetMsg.AuthReq.WorldId = context.worldId;
		}
		byte[] buff = PbEncoding.Encode(uxNetMsg);
		LowLevelFrameSend(buff);
	}

	private void OnConnectionClosed()
	{
		if (state.connection != null)
		{
			LogHelper.LogError("connect:{0} closed for reason:{1} error:{2}", context.url, state.connection.GetCloseReason(), state.connection.GetError());
			state.connection = null;
			if (notifier.onConnectFail != null)
			{
				SwitchChannelState(ChannelConnectState.CHANNEL_STATE_CLOSED);
				notifier.onClosed();
			}
		}
	}

	private void OnRecvDataFrame(byte[] Buff, int iBuff)
	{
		UxNetMsg uxNetMsg = PbEncoding.Decode<UxNetMsg>(Buff);
		if (uxNetMsg.Cmd == UxNetMsgCmd.AuthRes)
		{
			if (uxNetMsg.AuthRes.Ret == UxNetAuthResultType.UxnetAuthRetSuccess)
			{
				state.sessionKey = uxNetMsg.AuthRes.Token;
				state.sessionRoleId = uxNetMsg.AuthRes.RoleId;
				SwitchChannelState(ChannelConnectState.CHANNEL_STATE_RELAY);
				if (notifier.onAuthSuccess != null)
				{
					notifier.onAuthSuccess();
				}
				return;
			}
			LogHelper.LogError("connect:{0} recv auth ret:{1} sub code:{2}", context.url, uxNetMsg.AuthRes.Ret, uxNetMsg.AuthRes.SubCode);
			SwitchChannelState(ChannelConnectState.CHANNEL_STATE_CLOSED);
			if (notifier.onAuthFail != null)
			{
				notifier.onAuthFail((int)uxNetMsg.AuthRes.Ret);
			}
		}
		else
		{
			if (uxNetMsg.Cmd == UxNetMsgCmd.UdpAck || uxNetMsg.Cmd == UxNetMsgCmd.WaitRes)
			{
				return;
			}
			if (uxNetMsg.Cmd == UxNetMsgCmd.Payload)
			{
				if (notifier.onRecvMsg != null && state.connectState == ChannelConnectState.CHANNEL_STATE_RELAY)
				{
					notifier.onRecvMsg(uxNetMsg.Payload.ToByteArray());
				}
			}
			else
			{
				LogHelper.LogError("connect:{0} recv unknown cmd:{1} state:{2}", context.url, uxNetMsg.Cmd, state.connectState);
			}
		}
	}

	private bool LowLevelFrameSend(byte[] Buff)
	{
		int num = Buff.Length;
		if (num == 0)
		{
			LogHelper.LogError("error buff len:{0} {1}", Buff.Length, num);
			return false;
		}
		if (state.connection != null)
		{
			bool flag = state.connection.Send(Buff);
			if (!flag)
			{
				LogHelper.LogError("connect:{0} send fail buff len:{1} error:{2}", context.url, num, state.connection.GetError());
			}
			return flag;
		}
		return false;
	}
}
