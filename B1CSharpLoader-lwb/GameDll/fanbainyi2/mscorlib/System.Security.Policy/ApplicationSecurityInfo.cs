using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Security.Util;
using System.Threading;

namespace System.Security.Policy;

[SecurityCritical]
[ComVisible(true)]
[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
public sealed class ApplicationSecurityInfo
{
	private ActivationContext m_context;

	private object m_appId;

	private object m_deployId;

	private object m_defaultRequest;

	private object m_appEvidence;

	public ApplicationId ApplicationId
	{
		get
		{
			if (m_appId == null && m_context != null)
			{
				ICMS applicationComponentManifest = m_context.ApplicationComponentManifest;
				ApplicationId value = ParseApplicationId(applicationComponentManifest);
				Interlocked.CompareExchange(ref m_appId, value, null);
			}
			return m_appId as ApplicationId;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_appId = value;
		}
	}

	public ApplicationId DeploymentId
	{
		get
		{
			if (m_deployId == null && m_context != null)
			{
				ICMS deploymentComponentManifest = m_context.DeploymentComponentManifest;
				ApplicationId value = ParseApplicationId(deploymentComponentManifest);
				Interlocked.CompareExchange(ref m_deployId, value, null);
			}
			return m_deployId as ApplicationId;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_deployId = value;
		}
	}

	public PermissionSet DefaultRequestSet
	{
		get
		{
			if (m_defaultRequest == null)
			{
				PermissionSet value = new PermissionSet(PermissionState.None);
				if (m_context != null)
				{
					ICMS applicationComponentManifest = m_context.ApplicationComponentManifest;
					string defaultPermissionSetID = ((IMetadataSectionEntry)applicationComponentManifest.MetadataSectionEntry).defaultPermissionSetID;
					object ppUnknown = null;
					if (defaultPermissionSetID != null && defaultPermissionSetID.Length > 0)
					{
						((ISectionWithStringKey)applicationComponentManifest.PermissionSetSection).Lookup(defaultPermissionSetID, out ppUnknown);
						if (ppUnknown is IPermissionSetEntry permissionSetEntry)
						{
							SecurityElement securityElement = SecurityElement.FromString(permissionSetEntry.AllData.XmlSegment);
							string text = securityElement.Attribute("temp:Unrestricted");
							if (text != null)
							{
								securityElement.AddAttribute("Unrestricted", text);
							}
							string strA = securityElement.Attribute("SameSite");
							if (string.Compare(strA, "Site", StringComparison.OrdinalIgnoreCase) == 0)
							{
								Url url = new Url(m_context.Identity.CodeBase);
								URLString uRLString = url.GetURLString();
								NetCodeGroup netCodeGroup = new NetCodeGroup(new AllMembershipCondition());
								SecurityElement securityElement2 = netCodeGroup.CreateWebPermission(uRLString.Host, uRLString.Scheme, uRLString.Port, "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
								if (securityElement2 != null)
								{
									securityElement.AddChild(securityElement2);
								}
								if (string.Compare("file:", 0, m_context.Identity.CodeBase, 0, 5, StringComparison.OrdinalIgnoreCase) == 0)
								{
									FileCodeGroup fileCodeGroup = new FileCodeGroup(new AllMembershipCondition(), FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery);
									PolicyStatement policyStatement = fileCodeGroup.CalculatePolicy(url);
									if (policyStatement != null)
									{
										PermissionSet permissionSet = policyStatement.PermissionSet;
										if (permissionSet != null)
										{
											securityElement.AddChild(permissionSet.GetPermission(typeof(FileIOPermission)).ToXml());
										}
									}
								}
							}
							value = new ReadOnlyPermissionSet(securityElement);
						}
					}
				}
				Interlocked.CompareExchange(ref m_defaultRequest, value, null);
			}
			return m_defaultRequest as PermissionSet;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_defaultRequest = value;
		}
	}

	public Evidence ApplicationEvidence
	{
		get
		{
			if (m_appEvidence == null)
			{
				Evidence evidence = new Evidence();
				if (m_context != null)
				{
					evidence = new Evidence();
					Url evidence2 = new Url(m_context.Identity.CodeBase);
					evidence.AddHostEvidence(evidence2);
					evidence.AddHostEvidence(Zone.CreateFromUrl(m_context.Identity.CodeBase));
					if (string.Compare("file:", 0, m_context.Identity.CodeBase, 0, 5, StringComparison.OrdinalIgnoreCase) != 0)
					{
						evidence.AddHostEvidence(Site.CreateFromUrl(m_context.Identity.CodeBase));
					}
					evidence.AddHostEvidence(new StrongName(new StrongNamePublicKeyBlob(DeploymentId.m_publicKeyToken), DeploymentId.Name, DeploymentId.Version));
					evidence.AddHostEvidence(new ActivationArguments(m_context));
				}
				Interlocked.CompareExchange(ref m_appEvidence, evidence, null);
			}
			return m_appEvidence as Evidence;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			m_appEvidence = value;
		}
	}

	internal ApplicationSecurityInfo()
	{
	}

	public ApplicationSecurityInfo(ActivationContext activationContext)
	{
		if (activationContext == null)
		{
			throw new ArgumentNullException("activationContext");
		}
		m_context = activationContext;
	}

	private static ApplicationId ParseApplicationId(ICMS manifest)
	{
		if (manifest.Identity == null)
		{
			return null;
		}
		return new ApplicationId(Hex.DecodeHexString(manifest.Identity.GetAttribute("", "publicKeyToken")), manifest.Identity.GetAttribute("", "name"), new Version(manifest.Identity.GetAttribute("", "version")), manifest.Identity.GetAttribute("", "processorArchitecture"), manifest.Identity.GetAttribute("", "culture"));
	}
}
