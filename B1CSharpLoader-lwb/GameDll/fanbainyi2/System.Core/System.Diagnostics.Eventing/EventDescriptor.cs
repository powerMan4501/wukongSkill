using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Diagnostics.Eventing;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public struct EventDescriptor
{
	[FieldOffset(0)]
	private ushort m_id;

	[FieldOffset(2)]
	private byte m_version;

	[FieldOffset(3)]
	private byte m_channel;

	[FieldOffset(4)]
	private byte m_level;

	[FieldOffset(5)]
	private byte m_opcode;

	[FieldOffset(6)]
	private ushort m_task;

	[FieldOffset(8)]
	private long m_keywords;

	public int EventId => m_id;

	public byte Version => m_version;

	public byte Channel => m_channel;

	public byte Level => m_level;

	public byte Opcode => m_opcode;

	public int Task => m_task;

	public long Keywords => m_keywords;

	public EventDescriptor(int id, byte version, byte channel, byte level, byte opcode, int task, long keywords)
	{
		if (id < 0)
		{
			throw new ArgumentOutOfRangeException("id", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (id > 65535)
		{
			throw new ArgumentOutOfRangeException("id", System.SR.GetString("ArgumentOutOfRange_NeedValidId", 1, ushort.MaxValue));
		}
		m_id = (ushort)id;
		m_version = version;
		m_channel = channel;
		m_level = level;
		m_opcode = opcode;
		m_keywords = keywords;
		if (task < 0)
		{
			throw new ArgumentOutOfRangeException("task", System.SR.GetString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		if (task > 65535)
		{
			throw new ArgumentOutOfRangeException("task", System.SR.GetString("ArgumentOutOfRange_NeedValidId", 1, ushort.MaxValue));
		}
		m_task = (ushort)task;
	}
}
