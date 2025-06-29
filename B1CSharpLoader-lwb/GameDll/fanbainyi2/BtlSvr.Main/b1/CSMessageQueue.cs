using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Profile;

namespace b1;

public class CSMessageQueue
{
	public delegate void OnMessage(IntPtr MsgStruct);

	private static class StaticTypeLookUp<T>
	{
		private static int Index;

		public static int GetIndex()
		{
			if (Index == 0)
			{
				Index = s_TypeCounter++;
				sMsgTypeIndex2NameMap.Add(Index, typeof(T).FullName);
			}
			return Index;
		}
	}

	private static int s_TypeCounter = 1;

	public static Dictionary<int, string> sMsgTypeIndex2NameMap = new Dictionary<int, string>();

	private NativeStream MsgStream;

	private bool IsValid;

	private NativeStream.Writer MsgStreamWriter;

	private int MsgCount;

	private const int MagicNumber = 9873294;

	private Dictionary<long, List<OnMessage>> Handlers = new Dictionary<long, List<OnMessage>>();

	private Dictionary<string, int> DicMsgProfileStatId = new Dictionary<string, int>();

	public unsafe static void IntPtrToStruct<T>(IntPtr Ptr, ref T Buffer) where T : unmanaged
	{
		if (!(Ptr == IntPtr.Zero))
		{
			T* ptr = (T*)(void*)Ptr;
			Buffer = *ptr;
		}
	}

	public CSMessageQueue(int QueueSizeByte)
	{
		MsgStream = new NativeStream(QueueSizeByte);
		MsgStreamWriter = MsgStream.AsWriter();
		IsValid = true;
	}

	public void Dispose()
	{
		IsValid = false;
		MsgStream.Dispose();
	}

	internal void RegisterMessageType<T>() where T : unmanaged
	{
		StaticTypeLookUp<T>.GetIndex();
	}

	private long HashHandlerID<T>(Entity Ent) where T : unmanaged
	{
		long num = StaticTypeLookUp<T>.GetIndex();
		return Ent.GetHashCode() + (num << 32);
	}

	internal unsafe void EnqueueMessage<T>(ref T Msg) where T : unmanaged
	{
		if (IsValid)
		{
			long value = HashHandlerID<T>(Entity.Null);
			int value2 = sizeof(T);
			MsgStreamWriter.Write(ref value);
			MsgStreamWriter.Write(ref value2);
			MsgStreamWriter.Write(ref Msg);
			MsgCount++;
		}
	}

	internal unsafe void EnqueueMessageForEntity<T>(Entity Ent, ref T Msg) where T : unmanaged
	{
		if (IsValid)
		{
			long value = HashHandlerID<T>(Ent);
			int value2 = sizeof(T);
			MsgStreamWriter.Write(ref value);
			MsgStreamWriter.Write(ref value2);
			MsgStreamWriter.Write(ref Msg);
			MsgCount++;
		}
	}

	public void RegisterForMessage<T>(OnMessage Handler) where T : unmanaged
	{
		RegisterForEntityMessage<T>(Entity.Null, Handler);
	}

	public void RegisterForEntityMessage<T>(Entity Ent, OnMessage Handler) where T : unmanaged
	{
		long key = HashHandlerID<T>(Ent);
		if (!Handlers.TryGetValue(key, out var value))
		{
			value = new List<OnMessage>();
			Handlers[key] = value;
		}
		value.Add(Handler);
	}

	public void UnregisterForMessage<T>(OnMessage Handler) where T : unmanaged
	{
		UnregisterForEntityMessage<T>(Entity.Null, Handler);
	}

	public void UnregisterForEntityMessage<T>(Entity Ent, OnMessage Handler) where T : unmanaged
	{
		long key = HashHandlerID<T>(Ent);
		if (Handlers.TryGetValue(key, out var value))
		{
			value.Remove(Handler);
		}
	}

	public void DispatchAllMessage()
	{
		if (!IsValid)
		{
			return;
		}
		NativeStream.Reader reader = MsgStream.AsReader();
		long Buffer = 0L;
		int Buffer2 = 0;
		for (int i = 0; i < MsgCount; i++)
		{
			reader.Read(ref Buffer);
			reader.Read(ref Buffer2);
			IntPtr msgStruct = reader.ReadPtrBySize(Buffer2);
			_ = GSE_ProfileUtil.sOpenProfiler;
			if (Handlers.TryGetValue(Buffer, out var value))
			{
				for (int j = 0; j < value.Count; j++)
				{
					value[j](msgStruct);
				}
			}
		}
		MsgCount = 0;
		MsgStreamWriter = MsgStream.AsWriter();
	}
}
