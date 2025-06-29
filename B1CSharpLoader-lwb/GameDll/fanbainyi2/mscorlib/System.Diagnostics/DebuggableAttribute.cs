using System.Runtime.InteropServices;

namespace System.Diagnostics;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class DebuggableAttribute : Attribute
{
	[Flags]
	[ComVisible(true)]
	[__DynamicallyInvokable]
	public enum DebuggingModes
	{
		[__DynamicallyInvokable]
		None = 0,
		[__DynamicallyInvokable]
		Default = 1,
		[__DynamicallyInvokable]
		DisableOptimizations = 0x100,
		[__DynamicallyInvokable]
		IgnoreSymbolStoreSequencePoints = 2,
		[__DynamicallyInvokable]
		EnableEditAndContinue = 4
	}

	private DebuggingModes m_debuggingModes;

	public bool IsJITTrackingEnabled => (m_debuggingModes & DebuggingModes.Default) != 0;

	public bool IsJITOptimizerDisabled => (m_debuggingModes & DebuggingModes.DisableOptimizations) != 0;

	public DebuggingModes DebuggingFlags => m_debuggingModes;

	public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled)
	{
		m_debuggingModes = DebuggingModes.None;
		if (isJITTrackingEnabled)
		{
			m_debuggingModes |= DebuggingModes.Default;
		}
		if (isJITOptimizerDisabled)
		{
			m_debuggingModes |= DebuggingModes.DisableOptimizations;
		}
	}

	[__DynamicallyInvokable]
	public DebuggableAttribute(DebuggingModes modes)
	{
		m_debuggingModes = modes;
	}
}
