using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Runtime.Debugger.Protocol;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Debugger;

public class DebuggerServer
{
	public const int Version = 4;

	private static readonly int currentProcessId = Process.GetCurrentProcess().Id;

	private TcpListener listener;

	private bool isUp;

	private bool shutdown;

	private int maxNewConnections = 1;

	private int port;

	private Thread mainLoop;

	private DebugSocket clientSocket;

	private MemoryStream sendStream = new MemoryStream(65536);

	private BinaryWriter bw;

	private DebugService ds;

	private EndPoint boardcastEndPoint;

	private Socket udpSocket;

	private int tcpListenerPort;

	private byte[] stringBuffer = new byte[1024];

	private MemoryStream sendStreamForUdp = new MemoryStream(65536);

	private BinaryWriter bwForUdp;

	private DateTime udpSendTime = DateTime.MinValue;

	public static Func<string> GetProjectNameFunction;

	public int Port
	{
		get
		{
			return port;
		}
		set
		{
			port = value;
		}
	}

	public DebugSocket Client => clientSocket;

	public bool IsAttached
	{
		get
		{
			if (clientSocket != null)
			{
				return !clientSocket.Disconnected;
			}
			return false;
		}
	}

	public DebuggerServer(DebugService ds)
	{
		this.ds = ds;
		bw = new BinaryWriter(sendStream);
		bwForUdp = new BinaryWriter(sendStreamForUdp);
	}

	public virtual string Start(bool boardcastDebuggerInfo)
	{
		shutdown = false;
		mainLoop = new Thread(NetworkLoop);
		mainLoop.Start();
		boardcastEndPoint = new IPEndPoint(IPAddress.Broadcast, port);
		if (boardcastDebuggerInfo)
		{
			tcpListenerPort = port + Process.GetCurrentProcess().Id;
			if (tcpListenerPort > 65535)
			{
				tcpListenerPort = tcpListenerPort % 64511 + 1024;
			}
		}
		else
		{
			tcpListenerPort = port;
		}
		listener = new TcpListener(IPAddress.Any, tcpListenerPort);
		try
		{
			listener.Start();
		}
		catch
		{
			return $"ILRuntime Debugger Error: Unable to use network port {tcpListenerPort}.";
		}
		isUp = true;
		if (boardcastDebuggerInfo)
		{
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			socket.EnableBroadcast = true;
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ExclusiveAddressUse, optionValue: false);
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, optionValue: true);
			udpSocket = socket;
		}
		return null;
	}

	private void WriteUTF8String(BinaryWriter bw, string val)
	{
		int bytes = Encoding.UTF8.GetBytes(val, 0, Math.Min(val.Length, 256), stringBuffer, 0);
		bw.Write((short)bytes);
		bw.Write(stringBuffer, 0, bytes);
	}

	public virtual void Stop()
	{
		isUp = false;
		shutdown = true;
		if (listener != null)
		{
			listener.Stop();
		}
		mainLoop = null;
		if (clientSocket != null)
		{
			clientSocket.Close();
		}
		if (udpSocket != null)
		{
			Socket socket = udpSocket;
			udpSocket = null;
			socket.Close();
		}
	}

	private void NetworkLoop()
	{
		while (!shutdown)
		{
			try
			{
				if (udpSocket != null && clientSocket == null)
				{
					DateTime now = DateTime.Now;
					if ((now - udpSendTime).TotalSeconds >= 0.5)
					{
						sendStreamForUdp.Position = 0L;
						WriteUTF8String(bwForUdp, (GetProjectNameFunction != null) ? GetProjectNameFunction() : "");
						WriteUTF8String(bwForUdp, (Environment.MachineName != null) ? Environment.MachineName : "");
						bwForUdp.Write(currentProcessId);
						bwForUdp.Write(tcpListenerPort);
						udpSocket.SendTo(sendStreamForUdp.GetBuffer(), (int)sendStreamForUdp.Position, SocketFlags.None, boardcastEndPoint);
						udpSendTime = now;
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				if (isUp && clientSocket == null)
				{
					int num = 0;
					while (listener.Pending() && num < maxNewConnections)
					{
						CreateNewSession(listener);
						num++;
					}
				}
				Thread.Sleep(1);
			}
			catch (ThreadAbortException)
			{
			}
			catch (Exception)
			{
			}
		}
	}

	private void CreateNewSession(TcpListener listener)
	{
		Socket socket = listener.AcceptSocket();
		clientSocket = new DebugSocket(socket);
		clientSocket.OnReciveMessage = OnReceive;
		clientSocket.OnClose = OnClose;
		ClientConnected();
	}

	private void ClientConnected()
	{
	}

	private void OnClose()
	{
		ds.Detach();
		clientSocket = null;
	}

	private void OnReceive(DebugMessageType type, byte[] buffer)
	{
		if (clientSocket == null || clientSocket.Disconnected)
		{
			return;
		}
		BinaryReader binaryReader = new BinaryReader(new MemoryStream(buffer));
		switch (type)
		{
		case DebugMessageType.CSAttach:
			SendAttachResult();
			break;
		case DebugMessageType.CSBindBreakpoint:
		{
			CSBindBreakpoint cSBindBreakpoint = new CSBindBreakpoint();
			cSBindBreakpoint.BreakpointHashCode = binaryReader.ReadInt32();
			cSBindBreakpoint.IsLambda = binaryReader.ReadBoolean();
			cSBindBreakpoint.NamespaceName = binaryReader.ReadString();
			string text = binaryReader.ReadString();
			cSBindBreakpoint.TypeName = (string.IsNullOrWhiteSpace(cSBindBreakpoint.NamespaceName) ? text : (cSBindBreakpoint.NamespaceName + "." + text));
			cSBindBreakpoint.MethodName = binaryReader.ReadString();
			cSBindBreakpoint.StartLine = binaryReader.ReadInt32();
			cSBindBreakpoint.EndLine = binaryReader.ReadInt32();
			cSBindBreakpoint.Enabled = binaryReader.ReadBoolean();
			cSBindBreakpoint.Condition = new BreakpointCondition();
			cSBindBreakpoint.Condition.Style = (BreakpointConditionStyle)binaryReader.ReadByte();
			if (cSBindBreakpoint.Condition.Style != BreakpointConditionStyle.None)
			{
				cSBindBreakpoint.Condition.Expression = binaryReader.ReadString();
			}
			cSBindBreakpoint.UsingInfos = new UsingInfo[binaryReader.ReadInt32() + 1];
			cSBindBreakpoint.UsingInfos[0] = new UsingInfo
			{
				Alias = null,
				Name = cSBindBreakpoint.NamespaceName
			};
			for (int i = 1; i < cSBindBreakpoint.UsingInfos.Length; i++)
			{
				cSBindBreakpoint.UsingInfos[i] = new UsingInfo
				{
					Alias = binaryReader.ReadString(),
					Name = binaryReader.ReadString()
				};
			}
			TryBindBreakpoint(cSBindBreakpoint);
			break;
		}
		case DebugMessageType.CSSetBreakpointEnabled:
			ds.SetBreakpointEnabled(binaryReader.ReadInt32(), binaryReader.ReadBoolean());
			break;
		case DebugMessageType.CSSetBreakpointCondition:
		{
			int bpHash = binaryReader.ReadInt32();
			BreakpointConditionStyle breakpointConditionStyle = (BreakpointConditionStyle)binaryReader.ReadByte();
			string expression = ((breakpointConditionStyle != BreakpointConditionStyle.None) ? binaryReader.ReadString() : null);
			ds.SetBreakpointCondition(bpHash, breakpointConditionStyle, expression);
			break;
		}
		case DebugMessageType.CSDeleteBreakpoint:
		{
			CSDeleteBreakpoint cSDeleteBreakpoint = new CSDeleteBreakpoint();
			cSDeleteBreakpoint.BreakpointHashCode = binaryReader.ReadInt32();
			ds.DeleteBreakpoint(cSDeleteBreakpoint.BreakpointHashCode);
			break;
		}
		case DebugMessageType.CSExecute:
		{
			CSExecute cSExecute = new CSExecute();
			cSExecute.ThreadHashCode = binaryReader.ReadInt32();
			ds.ExecuteThread(cSExecute.ThreadHashCode);
			break;
		}
		case DebugMessageType.CSStep:
		{
			CSStep cSStep = new CSStep();
			cSStep.ThreadHashCode = binaryReader.ReadInt32();
			cSStep.StepType = (StepTypes)binaryReader.ReadByte();
			ds.StepThread(cSStep.ThreadHashCode, cSStep.StepType);
			break;
		}
		case DebugMessageType.CSResolveVariable:
		{
			CSResolveVariable cSResolveVariable = new CSResolveVariable();
			cSResolveVariable.ThreadHashCode = binaryReader.ReadInt32();
			cSResolveVariable.FrameIndex = binaryReader.ReadInt32();
			cSResolveVariable.Variable = ReadVariableReference(binaryReader);
			VariableInfo variableInfo2;
			try
			{
				variableInfo2 = ds.ResolveVariable(cSResolveVariable.ThreadHashCode, cSResolveVariable.FrameIndex, cSResolveVariable.Variable, out var _);
			}
			catch (Exception ex3)
			{
				variableInfo2 = VariableInfo.GetException(ex3);
			}
			if (variableInfo2.Type != VariableTypes.Pending)
			{
				SendSCResolveVariableResult(variableInfo2);
			}
			break;
		}
		case DebugMessageType.CSResolveIndexAccess:
		{
			CSResolveIndexer cSResolveIndexer = new CSResolveIndexer();
			cSResolveIndexer.ThreadHashCode = binaryReader.ReadInt32();
			cSResolveIndexer.FrameIndex = binaryReader.ReadInt32();
			cSResolveIndexer.Body = ReadVariableReference(binaryReader);
			cSResolveIndexer.Index = ReadVariableReference(binaryReader);
			VariableInfo variableInfo;
			try
			{
				variableInfo = ds.ResolveIndexAccess(cSResolveIndexer.ThreadHashCode, cSResolveIndexer.FrameIndex, new VariableReference
				{
					Parent = cSResolveIndexer.Body,
					Parameters = new VariableReference[1] { cSResolveIndexer.Index }
				}, out var _);
			}
			catch (Exception ex2)
			{
				variableInfo = VariableInfo.GetException(ex2);
			}
			if (variableInfo.Type != VariableTypes.Pending)
			{
				SendSCResolveVariableResult(variableInfo);
			}
			break;
		}
		case DebugMessageType.CSEnumChildren:
		{
			int threadHashCode = binaryReader.ReadInt32();
			int frameIndex = binaryReader.ReadInt32();
			VariableReference parent = ReadVariableReference(binaryReader);
			VariableInfo[] array = null;
			try
			{
				array = ds.EnumChildren(threadHashCode, frameIndex, parent);
			}
			catch (Exception ex)
			{
				array = new VariableInfo[1] { VariableInfo.GetException(ex) };
			}
			if (array != null)
			{
				SendSCEnumChildrenResult(array);
			}
			break;
		}
		case DebugMessageType.SCAttachResult:
		case DebugMessageType.SCBindBreakpointResult:
		case DebugMessageType.SCModuleLoaded:
		case DebugMessageType.SCThreadStarted:
		case DebugMessageType.SCThreadEnded:
		case DebugMessageType.SCBreakpointHit:
		case DebugMessageType.SCStepComplete:
		case DebugMessageType.SCResolveVariableResult:
		case DebugMessageType.SCResolveIndexAccessResult:
			break;
		}
	}

	private VariableReference ReadVariableReference(BinaryReader br)
	{
		VariableReference variableReference = null;
		if (br.ReadBoolean())
		{
			variableReference = new VariableReference();
			variableReference.Address = br.ReadInt64();
			variableReference.Type = (VariableTypes)br.ReadByte();
			variableReference.Offset = br.ReadInt32();
			variableReference.Name = br.ReadString();
			variableReference.Parent = ReadVariableReference(br);
			int num = br.ReadInt32();
			variableReference.Parameters = new VariableReference[num];
			for (int i = 0; i < num; i++)
			{
				variableReference.Parameters[i] = ReadVariableReference(br);
			}
		}
		return variableReference;
	}

	private void SendAttachResult()
	{
		sendStream.Position = 0L;
		bw.Write((byte)0);
		bw.Write(4);
		DoSend(DebugMessageType.SCAttachResult);
		lock (ds.AppDomain.FreeIntepreters)
		{
			foreach (KeyValuePair<int, ILIntepreter> intepreter in ds.AppDomain.Intepreters)
			{
				SendSCThreadStarted(intepreter.Key);
			}
		}
	}

	private void DoSend(DebugMessageType type)
	{
		if (clientSocket != null && !clientSocket.Disconnected)
		{
			clientSocket.Send(type, sendStream.GetBuffer(), (int)sendStream.Position);
		}
	}

	private bool CheckCompilerGeneratedStateMachine(ILMethod ilm, ILRuntime.Runtime.Enviorment.AppDomain domain, int startLine, out ILMethod found)
	{
		MethodDefinition definition = ilm.Definition;
		CustomAttribute customAttribute = null;
		found = null;
		foreach (CustomAttribute customAttribute2 in definition.CustomAttributes)
		{
			string fullName = customAttribute2.AttributeType.FullName;
			if (fullName == "System.Runtime.CompilerServices.AsyncStateMachineAttribute" || fullName == "System.Runtime.CompilerServices.IteratorStateMachineAttribute")
			{
				customAttribute = customAttribute2;
			}
		}
		if (customAttribute != null && customAttribute.ConstructorArguments.Count > 0)
		{
			IType type = domain.GetType(customAttribute.ConstructorArguments[0].Value, null, null);
			if (type != null)
			{
				ilm = type.GetMethod("MoveNext", 0, declaredOnly: true) as ILMethod;
				if (ilm != null && ilm.StartLine <= startLine + 1 && ilm.EndLine >= startLine + 1)
				{
					found = ilm;
					return true;
				}
			}
		}
		return false;
	}

	private void TryBindBreakpoint(CSBindBreakpoint msg)
	{
		ILRuntime.Runtime.Enviorment.AppDomain appDomain = ds.AppDomain;
		SCBindBreakpointResult sCBindBreakpointResult = new SCBindBreakpointResult();
		sCBindBreakpointResult.BreakpointHashCode = msg.BreakpointHashCode;
		IType value;
		if (msg.IsLambda)
		{
			ILMethod found = null;
			KeyValuePair<string, IType>[] array = appDomain.LoadedTypes.ToArray();
			foreach (KeyValuePair<string, IType> keyValuePair in array)
			{
				if (keyValuePair.Value is ILType iLType && iLType.FullName.Contains(msg.TypeName))
				{
					foreach (IMethod method in iLType.GetMethods())
					{
						if (method.Name.Contains($"<{msg.MethodName}>"))
						{
							ILMethod iLMethod = (ILMethod)method;
							if (iLMethod.StartLine <= msg.StartLine + 1 && iLMethod.EndLine >= msg.StartLine + 1)
							{
								found = iLMethod;
								break;
							}
							if (CheckCompilerGeneratedStateMachine(iLMethod, appDomain, msg.StartLine, out found))
							{
								break;
							}
						}
					}
				}
				if (found != null)
				{
					break;
				}
			}
			if (found != null)
			{
				ds.SetBreakPoint(found.GetHashCode(), msg.BreakpointHashCode, msg.StartLine, msg.Enabled, msg.Condition, msg.UsingInfos);
				sCBindBreakpointResult.Result = BindBreakpointResults.OK;
			}
			else
			{
				sCBindBreakpointResult.Result = BindBreakpointResults.CodeNotFound;
			}
		}
		else if (appDomain.LoadedTypes.TryGetValue(msg.TypeName, out value))
		{
			if (value is ILType)
			{
				ILType iLType2 = (ILType)value;
				ILMethod found2 = null;
				if (msg.MethodName == ".ctor")
				{
					foreach (ILMethod constructor in iLType2.GetConstructors())
					{
						if (constructor.StartLine <= msg.StartLine + 1 && constructor.EndLine >= msg.StartLine + 1)
						{
							found2 = constructor;
							break;
						}
					}
				}
				else if (msg.MethodName == ".cctor")
				{
					ILMethod iLMethod2 = iLType2.GetStaticConstroctor() as ILMethod;
					if (iLMethod2.StartLine <= msg.StartLine + 1 && iLMethod2.EndLine >= msg.StartLine + 1)
					{
						found2 = iLMethod2;
					}
				}
				else
				{
					foreach (IMethod method2 in iLType2.GetMethods())
					{
						if (method2.Name == msg.MethodName)
						{
							ILMethod iLMethod3 = (ILMethod)method2;
							if (iLMethod3.StartLine <= msg.StartLine + 1 && iLMethod3.EndLine >= msg.StartLine + 1)
							{
								found2 = iLMethod3;
								break;
							}
							if (CheckCompilerGeneratedStateMachine(iLMethod3, appDomain, msg.StartLine, out found2))
							{
								break;
							}
						}
					}
				}
				if (found2 != null)
				{
					ds.SetBreakPoint(found2.GetHashCode(), msg.BreakpointHashCode, msg.StartLine, msg.Enabled, msg.Condition, msg.UsingInfos);
					sCBindBreakpointResult.Result = BindBreakpointResults.OK;
				}
				else
				{
					sCBindBreakpointResult.Result = BindBreakpointResults.CodeNotFound;
				}
			}
			else
			{
				sCBindBreakpointResult.Result = BindBreakpointResults.TypeNotFound;
			}
		}
		else
		{
			sCBindBreakpointResult.Result = BindBreakpointResults.TypeNotFound;
		}
		SendSCBindBreakpointResult(sCBindBreakpointResult);
	}

	private void SendSCBindBreakpointResult(SCBindBreakpointResult msg)
	{
		sendStream.Position = 0L;
		bw.Write(msg.BreakpointHashCode);
		bw.Write((byte)msg.Result);
		DoSend(DebugMessageType.SCBindBreakpointResult);
	}

	internal void SendSCBreakpointHit(int intpHash, int bpHash, KeyValuePair<int, StackFrameInfo[]>[] info, string error = "")
	{
		sendStream.Position = 0L;
		bw.Write(bpHash);
		bw.Write(intpHash);
		WriteStackFrames(info);
		bw.Write(error);
		DoSend(DebugMessageType.SCBreakpointHit);
	}

	internal void SendSCStepComplete(int intpHash, KeyValuePair<int, StackFrameInfo[]>[] info)
	{
		sendStream.Position = 0L;
		bw.Write(intpHash);
		WriteStackFrames(info);
		DoSend(DebugMessageType.SCStepComplete);
	}

	internal void SendSCResolveVariableResult(VariableInfo info)
	{
		lock (this)
		{
			sendStream.Position = 0L;
			WriteVariableInfo(info);
			DoSend(DebugMessageType.SCResolveVariableResult);
		}
	}

	internal void SendSCEnumChildrenResult(VariableInfo[] info)
	{
		lock (this)
		{
			sendStream.Position = 0L;
			if (info != null)
			{
				bw.Write(info.Length);
				for (int i = 0; i < info.Length; i++)
				{
					WriteVariableInfo(info[i]);
				}
			}
			else
			{
				bw.Write(0);
			}
			DoSend(DebugMessageType.SCEnumChildrenResult);
		}
	}

	private void WriteStackFrames(KeyValuePair<int, StackFrameInfo[]>[] info)
	{
		bw.Write(info.Length);
		for (int i = 0; i < info.Length; i++)
		{
			KeyValuePair<int, StackFrameInfo[]> keyValuePair = info[i];
			bw.Write(keyValuePair.Key);
			bw.Write(keyValuePair.Value.Length);
			StackFrameInfo[] value = keyValuePair.Value;
			foreach (StackFrameInfo stackFrameInfo in value)
			{
				WriteString(stackFrameInfo.MethodName);
				WriteString(stackFrameInfo.DocumentName);
				bw.Write(stackFrameInfo.StartLine);
				bw.Write(stackFrameInfo.StartColumn);
				bw.Write(stackFrameInfo.EndLine);
				bw.Write(stackFrameInfo.EndColumn);
				bw.Write(stackFrameInfo.ArgumentCount);
				bw.Write(stackFrameInfo.LocalVariables.Length);
				VariableInfo[] localVariables = stackFrameInfo.LocalVariables;
				foreach (VariableInfo k2 in localVariables)
				{
					WriteVariableInfo(k2);
				}
			}
		}
	}

	private void WriteString(string val)
	{
		bw.Write((val != null) ? val : "");
	}

	private void WriteVariableInfo(VariableInfo k)
	{
		bw.Write(k.Address);
		bw.Write((byte)k.Type);
		bw.Write(k.Offset);
		WriteString(k.Name);
		WriteString(k.Value);
		bw.Write((byte)k.ValueType);
		WriteString(k.TypeName);
		bw.Write(k.Expandable);
		bw.Write(k.IsPrivate);
		bw.Write(k.IsProtected);
	}

	internal void SendSCThreadStarted(int threadHash)
	{
		sendStream.Position = 0L;
		bw.Write(threadHash);
		DoSend(DebugMessageType.SCThreadStarted);
	}

	internal void SendSCThreadEnded(int threadHash)
	{
		sendStream.Position = 0L;
		bw.Write(threadHash);
		DoSend(DebugMessageType.SCThreadEnded);
	}

	public void NotifyModuleLoaded(string modulename)
	{
		sendStream.Position = 0L;
		WriteString(modulename);
		DoSend(DebugMessageType.SCModuleLoaded);
	}
}
