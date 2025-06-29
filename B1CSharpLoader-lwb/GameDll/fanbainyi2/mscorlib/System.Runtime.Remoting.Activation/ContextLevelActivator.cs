using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Activation;

[Serializable]
internal class ContextLevelActivator : IActivator
{
	private IActivator m_NextActivator;

	public virtual IActivator NextActivator
	{
		[SecurityCritical]
		get
		{
			return m_NextActivator;
		}
		[SecurityCritical]
		set
		{
			m_NextActivator = value;
		}
	}

	public virtual ActivatorLevel Level
	{
		[SecurityCritical]
		get
		{
			return ActivatorLevel.Context;
		}
	}

	internal ContextLevelActivator()
	{
		m_NextActivator = null;
	}

	internal ContextLevelActivator(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		m_NextActivator = (IActivator)info.GetValue("m_NextActivator", typeof(IActivator));
	}

	[SecurityCritical]
	[ComVisible(true)]
	public virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorMsg)
	{
		ctorMsg.Activator = ctorMsg.Activator.NextActivator;
		return ActivationServices.DoCrossContextActivation(ctorMsg);
	}
}
