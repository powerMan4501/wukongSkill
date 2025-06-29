using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_WatchDog
{
	public struct UserDynamicKeyInfo
	{
		public int ZoneId;

		public int DeviceId;

		public int DaysFrom20231212;

		public int PureNumber;

		public string BinString;
	}

	public delegate void OnServerLost();

	public float CheckFinalLostTimeThreshold = 25f;

	public float KeepAliveSendInterval = 5f;

	public OnServerLost onServerLost;

	private bool IsLostServer = true;

	private string MacAddr;

	private string VerifyLastTimeFormat;

	private string PrjPath;

	private string MiscInfo;

	private bool bNeedStoreLocalInfo;

	private float LastRecieveServerActiveTimer;

	private static DateTime SharedLastRecieveServerActiveTime = DateTime.Now;

	private float LowLevelTickCheckCountdown = 2f;

	private bool Enable;

	private bool bInited;

	private List<EndPoint> ValidKAServerList = new List<EndPoint>();

	private int curValidKAServerIndex;

	private EndPoint InvalidKAServerEp = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12800);

	private EndPoint LocalEp = new IPEndPoint(IPAddress.Any, 0);

	private Socket socket;

	private byte[] ServerMsgBuffer;

	private string UserServerIdAndDynamicKey;

	public string HostName = "";

	private int local_cookie_id;

	private static int global_cookie_id = 0;

	private static int UsingSocketNetUsingUdpOrTcpMode = 2;

	public static readonly string KA_EDITOR_DEFAULT_SERVER_HOST = "gshb.b1.gamesci.com.cn";

	public static readonly int KA_EDITOR_DEFAULT_SERVER_PORT = 12800;

	private string KASecKeySalt = "gsciv587!!!";

	private bool NeedKAEncryptBin;

	private byte[] KAEncryptKey;

	private byte[] MacAddrEncKey = new byte[6] { 148, 42, 95, 200, 30, 107 };

	private string KAEnMacAddr = "";

	private EndPoint RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

	private int KASendTryTimes;

	private int KASendTotalTimes;

	public string wxid = "";

	public bool LostServer => IsLostServer;

	private EndPoint KADefaultServerEp
	{
		get
		{
			if (ValidKAServerList.Count > 0)
			{
				return ValidKAServerList[curValidKAServerIndex];
			}
			return InvalidKAServerEp;
		}
	}

	public string UserId
	{
		get
		{
			if (string.IsNullOrEmpty(UserServerIdAndDynamicKey))
			{
				return HostName;
			}
			if (UserServerIdAndDynamicKey.Contains("."))
			{
				string[] array = UserServerIdAndDynamicKey.Split('.');
				if (array.Length != 0)
				{
					return array[0];
				}
			}
			return UserServerIdAndDynamicKey;
		}
	}

	public string UserControlKey
	{
		get
		{
			if (!string.IsNullOrEmpty(UserServerIdAndDynamicKey) && UserServerIdAndDynamicKey.Contains("."))
			{
				string[] array = UserServerIdAndDynamicKey.Split('.');
				if (array.Length > 2)
				{
					return array[2];
				}
			}
			return "";
		}
	}

	public string UserDynamicKey
	{
		get
		{
			if (!string.IsNullOrEmpty(UserServerIdAndDynamicKey) && UserServerIdAndDynamicKey.Contains("."))
			{
				string[] array = UserServerIdAndDynamicKey.Split('.');
				if (array.Length > 1)
				{
					return array[1];
				}
			}
			return "0";
		}
	}

	public bool ServerHideWaterMark
	{
		get
		{
			if (string.IsNullOrEmpty(UserControlKey))
			{
				return false;
			}
			if (UserControlKey.Contains("VX621"))
			{
				return true;
			}
			return false;
		}
	}

	public bool ServerIgnoreHeartBeatCheck
	{
		get
		{
			if (string.IsNullOrEmpty(UserControlKey))
			{
				return false;
			}
			if (UserControlKey.Contains("MX518"))
			{
				return true;
			}
			return false;
		}
	}

	private string BinManagedPath => FPaths.Combine(FPaths.ProjectDir, "Binaries", "Managed", "GSE.SechbPort.dll");

	private bool IsLosingServer
	{
		get
		{
			if (!IsLostServer)
			{
				return LastRecieveServerActiveTimer >= 2f * KeepAliveSendInterval;
			}
			return true;
		}
	}

	private bool IsLosingServerVeryLongWillSetServerLost => LastRecieveServerActiveTimer >= CheckFinalLostTimeThreshold;

	private bool IsSendKeepAliveIntervalTimeout
	{
		get
		{
			if (!IsLostServer)
			{
				return LastRecieveServerActiveTimer >= KeepAliveSendInterval;
			}
			return true;
		}
	}

	public DateTime LastConnectTime { get; private set; }

	public static bool ParseUserDynamicKey(string UserDynamicKey, ref UserDynamicKeyInfo OutKeyInfo)
	{
		if (string.IsNullOrEmpty(UserDynamicKey))
		{
			return false;
		}
		try
		{
			ulong num = ulong.Parse(UserDynamicKey, NumberStyles.HexNumber);
			OutKeyInfo.PureNumber = (int)num;
			uint num2 = (uint)(OutKeyInfo.PureNumber << 2);
			OutKeyInfo.BinString = "";
			for (int num3 = 27; num3 >= 0; num3--)
			{
				if (((num2 >> num3) & 1) == 1)
				{
					OutKeyInfo.BinString += "=";
				}
				else
				{
					OutKeyInfo.BinString += "o";
				}
			}
			OutKeyInfo.ZoneId = (int)(num & 0xF);
			num >>= 4;
			OutKeyInfo.DaysFrom20231212 = (int)(num & 0xFF);
			num >>= 8;
			OutKeyInfo.DeviceId = (int)(num & 0xFFF);
			return true;
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"parse key info fail {arg}");
			return false;
		}
	}

	public void SetActive(bool bEn)
	{
		Enable = bEn;
	}

	public void SaveIdentifyInfo()
	{
		if (bNeedStoreLocalInfo)
		{
			try
			{
				File.WriteAllText(BinManagedPath, BGW_LocalDevEnvUtils.GetMacAddress(MaxMac: true) + "|" + MiscInfo);
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("write sec file fail !" + ex.Message);
			}
		}
	}

	public void LoadIdentifyInfo()
	{
		if (!bNeedStoreLocalInfo && File.Exists(BinManagedPath))
		{
			try
			{
				string text = File.ReadAllText(BinManagedPath);
				MiscInfo = MiscInfo + "->" + text;
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError("read sec file fail !" + ex.Message);
			}
		}
	}

	private static string KAEncryptHex(string msg, byte[] key)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(msg);
		Cipher.XorEncrypt(bytes, key);
		return Convert.ToBase64String(bytes);
	}

	public void InitEnv(OnServerLost onLost, bool bStoreLocal, string KAServerNameConf, int ServerPort, bool TcpMode = true)
	{
		local_cookie_id = ++global_cookie_id;
		if (TcpMode)
		{
			UsingSocketNetUsingUdpOrTcpMode = 2;
		}
		else
		{
			UsingSocketNetUsingUdpOrTcpMode = 1;
		}
		onServerLost = onLost;
		IsLostServer = true;
		LastRecieveServerActiveTimer = 0f;
		LastConnectTime = DateTime.Now;
		HostName = BGW_LocalDevEnvUtils.GetLocalHostUserName() + "@" + BGW_LocalDevEnvUtils.GetHostName();
		MacAddr = BGW_LocalDevEnvUtils.GetMacAddress(MaxMac: true);
		string kAExtraId = DebugConfig.KAExtraId;
		if (kAExtraId.Length > 0)
		{
			MacAddr += "@";
			MacAddr += kAExtraId;
		}
		NeedKAEncryptBin = DebugConfig.KAExtraId.Length > 0;
		if (NeedKAEncryptBin)
		{
			KAEnMacAddr = KAEncryptHex(MacAddr, MacAddrEncKey);
			KAEncryptKey = Encoding.UTF8.GetBytes(BGW_LocalDevEnvUtils.CalcMd5(KAEnMacAddr + "xx" + KASecKeySalt));
		}
		PrjPath = FPaths.ConvertRelativePathToFull(FPaths.ProjectDir);
		bNeedStoreLocalInfo = bStoreLocal;
		MiscInfo = Environment.UserName + "|" + Environment.MachineName + "|" + BGW_LocalDevEnvUtils.GetLocalIpv4ListStr() + "|" + BGW_LocalDevEnvUtils.GetLocalP4EnvInfo();
		if (!bStoreLocal)
		{
			LoadIdentifyInfo();
		}
		else
		{
			SaveIdentifyInfo();
		}
		ServerMsgBuffer = new byte[8192];
		BGW_LocalDevEnvUtils.GetLocalIpv4();
		List<IPAddress> list = new List<IPAddress>();
		string[] array = KAServerNameConf.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			if (IPAddress.TryParse(text, out var address))
			{
				list.Add(address);
				continue;
			}
			try
			{
				list.AddRange(Dns.GetHostAddresses(text));
			}
			catch (Exception ex)
			{
				BGW_LogUtil.LogError($"ka idx:{i} get server name:{text} addr fail : {ex.Message}");
			}
		}
		if (list.Count > 0)
		{
			for (int j = 0; j < list.Count; j++)
			{
				ValidKAServerList.Add(new IPEndPoint(list[j], ServerPort));
			}
		}
		else
		{
			BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} get hb server name fail ! dns fail ? ");
		}
		bInited = true;
		Enable = true;
		CheckCreateOrConnectToServer();
	}

	private static void CheckConnectStatus(IAsyncResult ar)
	{
		try
		{
			((Socket)ar.AsyncState).EndConnect(ar);
		}
		catch (Exception)
		{
		}
	}

	private bool CheckCreateOrConnectToServer()
	{
		if (ValidKAServerList.Count <= 0)
		{
			return false;
		}
		if (socket == null)
		{
			curValidKAServerIndex = (curValidKAServerIndex + 1) % ValidKAServerList.Count;
		}
		if (UsingSocketNetUsingUdpOrTcpMode == 1)
		{
			if (socket == null)
			{
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				socket.Blocking = false;
				socket.Bind(LocalEp);
			}
			else if (!socket.IsBound)
			{
				socket.Bind(LocalEp);
			}
			return true;
		}
		if (socket == null)
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, optionValue: true);
			socket.Blocking = false;
			socket.ReceiveTimeout = 1;
			socket.SendTimeout = 1;
			socket.SendBufferSize = 4096;
			socket.ReceiveBufferSize = 1024;
			socket.Bind(LocalEp);
			socket.BeginConnect(KADefaultServerEp, CheckConnectStatus, socket);
			LastConnectTime = DateTime.Now;
			return false;
		}
		if (socket.Connected)
		{
			return true;
		}
		if ((DateTime.Now - LastConnectTime).TotalSeconds >= 4.0)
		{
			BGW_LogUtil.LogError("ka server connect timeout retry next ...");
			Close();
		}
		return false;
	}

	private int SocketRecvFromServer()
	{
		if (UsingSocketNetUsingUdpOrTcpMode == 1)
		{
			try
			{
				return socket.ReceiveFrom(ServerMsgBuffer, ref RemoteEndPoint);
			}
			catch (Exception arg)
			{
				BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} recv udp socket exc:{arg}");
				return 0;
			}
		}
		try
		{
			if (socket.Receive(ServerMsgBuffer, SocketFlags.Peek) == 0)
			{
				return 0;
			}
			string text = Encoding.UTF8.GetString(ServerMsgBuffer);
			int num = text.IndexOf("\n");
			if (num > 0)
			{
				string s = text.Substring(0, num + 1);
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				return socket.Receive(ServerMsgBuffer, bytes.Length, SocketFlags.None) - 1;
			}
			return 0;
		}
		catch (SocketException ex)
		{
			if (ex.SocketErrorCode == SocketError.WouldBlock || ex.SocketErrorCode == SocketError.TryAgain)
			{
				return 0;
			}
			BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} recv socket exc:{ex}");
		}
		catch (Exception arg2)
		{
			BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} recv exc:{arg2}");
		}
		Close();
		return 0;
	}

	private void SocketSendToServer(string msg, EndPoint ValidServerEp)
	{
		if (UsingSocketNetUsingUdpOrTcpMode == 1)
		{
			try
			{
				socket.SendTo(Encoding.UTF8.GetBytes(msg), ValidServerEp);
				return;
			}
			catch (Exception arg)
			{
				BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} send bytes fail:{arg}");
				return;
			}
		}
		try
		{
			socket.Send(Encoding.UTF8.GetBytes(msg + "\n"));
		}
		catch (SocketException arg2)
		{
			BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} send socket exc:{arg2}");
			Close();
		}
	}

	public static string GetMD5(string txt)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.UTF8.GetBytes(txt);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private void KeepAliveRecvCheck()
	{
		try
		{
			if (socket.Available <= 0)
			{
				return;
			}
			int num = SocketRecvFromServer();
			if (num <= 0)
			{
				return;
			}
			string text = Encoding.UTF8.GetString(ServerMsgBuffer, 0, num);
			string[] array = text.Split(',');
			if (array.Length == 2)
			{
				string text2 = VerifyLastTimeFormat.Substring(0, VerifyLastTimeFormat.Length - 3);
				if (StringParseHelper.SafeToLower(GetMD5(MacAddr + HostName + KASecKeySalt + text2)) == StringParseHelper.SafeToLower(array[1]))
				{
					UserServerIdAndDynamicKey = array[0].ToUpper();
					IsLostServer = false;
					LastRecieveServerActiveTimer = 0f;
					SharedLastRecieveServerActiveTime = DateTime.Now;
					KASendTryTimes = 0;
				}
				else
				{
					BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} verify hbserver fail from server");
				}
			}
			else
			{
				BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} recv error msg len:{array.Length} total:{text.Length} msg:{text}");
			}
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} socket receive fail exception:{arg}");
		}
	}

	private void KeepAliveSend()
	{
		KASendTryTimes++;
		KASendTotalTimes++;
		VerifyLastTimeFormat = DateTime.Now.ToString("yyyyMMddHHmmss");
		string text = $"{MacAddr},{HostName},{VerifyLastTimeFormat},{PrjPath},{MiscInfo}-{wxid}";
		if (NeedKAEncryptBin)
		{
			string text2 = KAEncryptHex(text.Replace(MacAddr + ",", ""), KAEncryptKey);
			text = KAEnMacAddr + ":" + text2;
		}
		SocketSendToServer(text, KADefaultServerEp);
	}

	private void SetKAServerLost()
	{
		BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} server check lost send try times:{KASendTryTimes} total:{KASendTotalTimes}");
		onServerLost?.Invoke();
		IsLostServer = true;
		LastRecieveServerActiveTimer = 0f;
	}

	public void Close()
	{
		if (socket != null)
		{
			socket.Close();
			socket = null;
		}
	}

	public void UpdateTick(float DeltaTime)
	{
		if (!Enable)
		{
			return;
		}
		LowLevelTickCheckCountdown -= DeltaTime;
		LastRecieveServerActiveTimer += DeltaTime;
		if (LowLevelTickCheckCountdown > 0f)
		{
			return;
		}
		TimeSpan timeSpan = DateTime.Now - SharedLastRecieveServerActiveTime;
		if ((double)LastRecieveServerActiveTimer > timeSpan.TotalSeconds)
		{
			LastRecieveServerActiveTimer = (float)timeSpan.TotalSeconds;
		}
		LowLevelTickCheckCountdown = 1f;
		if (IsLosingServer)
		{
			LowLevelTickCheckCountdown = 0.1f;
		}
		try
		{
			if (CheckCreateOrConnectToServer())
			{
				KeepAliveRecvCheck();
				if (IsSendKeepAliveIntervalTimeout)
				{
					KeepAliveSend();
				}
			}
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"ka:{local_cookie_id}:{KASendTotalTimes} check exception:{arg}");
		}
		if (IsLosingServerVeryLongWillSetServerLost)
		{
			SetKAServerLost();
		}
	}
}
