using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Messaging;

[Serializable]
[SecurityCritical]
[CLSCompliant(false)]
[ComVisible(true)]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMethodCallMessage, IMethodMessage, IMessage
{
	internal Type _activationType;

	internal string _activationTypeName;

	internal IList _contextProperties;

	internal object[] _callSiteActivationAttributes;

	internal IActivator _activator;

	public object[] CallSiteActivationAttributes
	{
		[SecurityCritical]
		get
		{
			return _callSiteActivationAttributes;
		}
	}

	public Type ActivationType
	{
		[SecurityCritical]
		get
		{
			if (_activationType == null && _activationTypeName != null)
			{
				_activationType = RemotingServices.InternalGetTypeFromQualifiedTypeName(_activationTypeName, partialFallback: false);
			}
			return _activationType;
		}
	}

	public string ActivationTypeName
	{
		[SecurityCritical]
		get
		{
			return _activationTypeName;
		}
	}

	public IList ContextProperties
	{
		[SecurityCritical]
		get
		{
			if (_contextProperties == null)
			{
				_contextProperties = new ArrayList();
			}
			return _contextProperties;
		}
	}

	public override IDictionary Properties
	{
		[SecurityCritical]
		get
		{
			lock (this)
			{
				if (InternalProperties == null)
				{
					InternalProperties = new Hashtable();
				}
				if (ExternalProperties == null)
				{
					ExternalProperties = new CCMDictionary(this, InternalProperties);
				}
				return ExternalProperties;
			}
		}
	}

	public IActivator Activator
	{
		[SecurityCritical]
		get
		{
			return _activator;
		}
		[SecurityCritical]
		set
		{
			_activator = value;
		}
	}

	public ConstructionCall(Header[] headers)
		: base(headers)
	{
	}

	public ConstructionCall(IMessage m)
		: base(m)
	{
	}

	internal ConstructionCall(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	[SecurityCritical]
	internal override bool FillSpecialHeader(string key, object value)
	{
		if (key != null)
		{
			if (key.Equals("__ActivationType"))
			{
				_activationType = null;
			}
			else if (key.Equals("__ContextProperties"))
			{
				_contextProperties = (IList)value;
			}
			else if (key.Equals("__CallSiteActivationAttributes"))
			{
				_callSiteActivationAttributes = (object[])value;
			}
			else if (key.Equals("__Activator"))
			{
				_activator = (IActivator)value;
			}
			else
			{
				if (!key.Equals("__ActivationTypeName"))
				{
					return base.FillSpecialHeader(key, value);
				}
				_activationTypeName = (string)value;
			}
		}
		return true;
	}
}
