using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;

namespace System.Security.Authentication.ExtendedProtection;

[Serializable]
[TypeConverter(typeof(ExtendedProtectionPolicyTypeConverter))]
public class ExtendedProtectionPolicy : ISerializable
{
	private const string policyEnforcementName = "policyEnforcement";

	private const string protectionScenarioName = "protectionScenario";

	private const string customServiceNamesName = "customServiceNames";

	private const string customChannelBindingName = "customChannelBinding";

	private ServiceNameCollection customServiceNames;

	private PolicyEnforcement policyEnforcement;

	private ProtectionScenario protectionScenario;

	private ChannelBinding customChannelBinding;

	public ServiceNameCollection CustomServiceNames => customServiceNames;

	public PolicyEnforcement PolicyEnforcement => policyEnforcement;

	public ProtectionScenario ProtectionScenario => protectionScenario;

	public ChannelBinding CustomChannelBinding => customChannelBinding;

	public static bool OSSupportsExtendedProtection => AuthenticationManager.OSSupportsExtendedProtection;

	public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ServiceNameCollection customServiceNames)
	{
		if (policyEnforcement == PolicyEnforcement.Never)
		{
			throw new ArgumentException(SR.GetString("security_ExtendedProtectionPolicy_UseDifferentConstructorForNever"), "policyEnforcement");
		}
		if (customServiceNames != null && customServiceNames.Count == 0)
		{
			throw new ArgumentException(SR.GetString("security_ExtendedProtectionPolicy_NoEmptyServiceNameCollection"), "customServiceNames");
		}
		this.policyEnforcement = policyEnforcement;
		this.protectionScenario = protectionScenario;
		this.customServiceNames = customServiceNames;
	}

	public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ProtectionScenario protectionScenario, ICollection customServiceNames)
		: this(policyEnforcement, protectionScenario, (customServiceNames == null) ? null : new ServiceNameCollection(customServiceNames))
	{
	}

	public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement, ChannelBinding customChannelBinding)
	{
		if (policyEnforcement == PolicyEnforcement.Never)
		{
			throw new ArgumentException(SR.GetString("security_ExtendedProtectionPolicy_UseDifferentConstructorForNever"), "policyEnforcement");
		}
		if (customChannelBinding == null)
		{
			throw new ArgumentNullException("customChannelBinding");
		}
		this.policyEnforcement = policyEnforcement;
		protectionScenario = ProtectionScenario.TransportSelected;
		this.customChannelBinding = customChannelBinding;
	}

	public ExtendedProtectionPolicy(PolicyEnforcement policyEnforcement)
	{
		this.policyEnforcement = policyEnforcement;
		protectionScenario = ProtectionScenario.TransportSelected;
	}

	protected ExtendedProtectionPolicy(SerializationInfo info, StreamingContext context)
	{
		policyEnforcement = (PolicyEnforcement)info.GetInt32("policyEnforcement");
		protectionScenario = (ProtectionScenario)info.GetInt32("protectionScenario");
		customServiceNames = (ServiceNameCollection)info.GetValue("customServiceNames", typeof(ServiceNameCollection));
		byte[] array = (byte[])info.GetValue("customChannelBinding", typeof(byte[]));
		if (array != null)
		{
			customChannelBinding = SafeLocalFreeChannelBinding.LocalAlloc(array.Length);
			Marshal.Copy(array, 0, customChannelBinding.DangerousGetHandle(), array.Length);
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("ProtectionScenario=");
		stringBuilder.Append(protectionScenario.ToString());
		stringBuilder.Append("; PolicyEnforcement=");
		stringBuilder.Append(policyEnforcement.ToString());
		stringBuilder.Append("; CustomChannelBinding=");
		if (customChannelBinding == null)
		{
			stringBuilder.Append("<null>");
		}
		else
		{
			stringBuilder.Append(customChannelBinding.ToString());
		}
		stringBuilder.Append("; ServiceNames=");
		if (customServiceNames == null)
		{
			stringBuilder.Append("<null>");
		}
		else
		{
			bool flag = true;
			foreach (string customServiceName in customServiceNames)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(customServiceName);
			}
		}
		return stringBuilder.ToString();
	}

	[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("policyEnforcement", (int)policyEnforcement);
		info.AddValue("protectionScenario", (int)protectionScenario);
		info.AddValue("customServiceNames", customServiceNames, typeof(ServiceNameCollection));
		if (customChannelBinding == null)
		{
			info.AddValue("customChannelBinding", null, typeof(byte[]));
			return;
		}
		byte[] array = new byte[customChannelBinding.Size];
		Marshal.Copy(customChannelBinding.DangerousGetHandle(), array, 0, customChannelBinding.Size);
		info.AddValue("customChannelBinding", array, typeof(byte[]));
	}
}
