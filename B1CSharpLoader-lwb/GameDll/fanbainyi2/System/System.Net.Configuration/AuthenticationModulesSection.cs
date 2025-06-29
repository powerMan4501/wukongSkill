using System.Configuration;

namespace System.Net.Configuration;

public sealed class AuthenticationModulesSection : ConfigurationSection
{
	private ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

	private readonly ConfigurationProperty authenticationModules = new ConfigurationProperty(null, typeof(AuthenticationModuleElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

	[ConfigurationProperty("", IsDefaultCollection = true)]
	public AuthenticationModuleElementCollection AuthenticationModules => (AuthenticationModuleElementCollection)base[authenticationModules];

	protected override ConfigurationPropertyCollection Properties => properties;

	public AuthenticationModulesSection()
	{
		properties.Add(authenticationModules);
	}

	protected override void PostDeserialize()
	{
		if (base.EvaluationContext.IsMachineLevel)
		{
			return;
		}
		try
		{
			ExceptionHelper.UnmanagedPermission.Demand();
		}
		catch (Exception inner)
		{
			throw new ConfigurationErrorsException(SR.GetString("net_config_section_permission", "authenticationModules"), inner);
		}
	}

	protected override void InitializeDefault()
	{
		AuthenticationModules.Add(new AuthenticationModuleElement(typeof(NegotiateClient).AssemblyQualifiedName));
		AuthenticationModules.Add(new AuthenticationModuleElement(typeof(KerberosClient).AssemblyQualifiedName));
		AuthenticationModules.Add(new AuthenticationModuleElement(typeof(NtlmClient).AssemblyQualifiedName));
		AuthenticationModules.Add(new AuthenticationModuleElement(typeof(DigestClient).AssemblyQualifiedName));
		AuthenticationModules.Add(new AuthenticationModuleElement(typeof(BasicClient).AssemblyQualifiedName));
	}
}
