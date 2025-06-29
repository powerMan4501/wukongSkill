using System.Reflection.Emit;

namespace System.Security;

internal class FrameSecurityDescriptorWithResolver : FrameSecurityDescriptor
{
	private DynamicResolver m_resolver;

	public DynamicResolver Resolver => m_resolver;
}
