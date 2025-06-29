using System.Reflection;

namespace System.Runtime.Serialization;

internal class ValueTypeFixupInfo
{
	private long m_containerID;

	private FieldInfo m_parentField;

	private int[] m_parentIndex;

	public long ContainerID => m_containerID;

	public FieldInfo ParentField => m_parentField;

	public int[] ParentIndex => m_parentIndex;

	public ValueTypeFixupInfo(long containerID, FieldInfo member, int[] parentIndex)
	{
		if (member == null && parentIndex == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_MustSupplyParent"));
		}
		if (containerID == 0L && member == null)
		{
			m_containerID = containerID;
			m_parentField = member;
			m_parentIndex = parentIndex;
		}
		if (member != null)
		{
			if (parentIndex != null)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_MemberAndArray"));
			}
			if (member.FieldType.IsValueType && containerID == 0L)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_MustSupplyContainer"));
			}
		}
		m_containerID = containerID;
		m_parentField = member;
		m_parentIndex = parentIndex;
	}
}
