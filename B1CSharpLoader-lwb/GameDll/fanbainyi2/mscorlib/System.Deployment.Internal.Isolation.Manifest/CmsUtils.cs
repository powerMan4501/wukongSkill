using System.IO;
using System.Runtime.Hosting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;

namespace System.Deployment.Internal.Isolation.Manifest;

[SecuritySafeCritical]
[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
internal static class CmsUtils
{
	internal static void GetEntryPoint(ActivationContext activationContext, out string fileName, out string parameters)
	{
		parameters = null;
		fileName = null;
		ICMS applicationComponentManifest = activationContext.ApplicationComponentManifest;
		if (applicationComponentManifest == null || applicationComponentManifest.EntryPointSection == null)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_NoMain"));
		}
		IEnumUnknown enumUnknown = (IEnumUnknown)applicationComponentManifest.EntryPointSection._NewEnum;
		uint celtFetched = 0u;
		object[] array = new object[1];
		if (enumUnknown.Next(1u, array, ref celtFetched) != 0 || celtFetched != 1)
		{
			return;
		}
		IEntryPointEntry entryPointEntry = (IEntryPointEntry)array[0];
		EntryPointEntry allData = entryPointEntry.AllData;
		if (allData.CommandLine_File != null && allData.CommandLine_File.Length > 0)
		{
			fileName = allData.CommandLine_File;
		}
		else
		{
			IAssemblyReferenceEntry assemblyReferenceEntry = null;
			object ppUnknown = null;
			if (allData.Identity != null)
			{
				((ISectionWithReferenceIdentityKey)applicationComponentManifest.AssemblyReferenceSection).Lookup(allData.Identity, out ppUnknown);
				assemblyReferenceEntry = (IAssemblyReferenceEntry)ppUnknown;
				fileName = assemblyReferenceEntry.DependentAssembly.Codebase;
			}
		}
		parameters = allData.CommandLine_Parameters;
	}

	internal static IAssemblyReferenceEntry[] GetDependentAssemblies(ActivationContext activationContext)
	{
		IAssemblyReferenceEntry[] array = null;
		ICMS applicationComponentManifest = activationContext.ApplicationComponentManifest;
		if (applicationComponentManifest == null)
		{
			return null;
		}
		ISection assemblyReferenceSection = applicationComponentManifest.AssemblyReferenceSection;
		uint num = assemblyReferenceSection?.Count ?? 0;
		if (num != 0)
		{
			uint celtFetched = 0u;
			array = new IAssemblyReferenceEntry[num];
			IEnumUnknown enumUnknown = (IEnumUnknown)assemblyReferenceSection._NewEnum;
			object[] rgelt = array;
			int num2 = enumUnknown.Next(num, rgelt, ref celtFetched);
			if (celtFetched != num || num2 < 0)
			{
				return null;
			}
		}
		return array;
	}

	internal static string GetEntryPointFullPath(ActivationArguments activationArguments)
	{
		return GetEntryPointFullPath(activationArguments.ActivationContext);
	}

	internal static string GetEntryPointFullPath(ActivationContext activationContext)
	{
		GetEntryPoint(activationContext, out var fileName, out var _);
		if (!string.IsNullOrEmpty(fileName))
		{
			string text = activationContext.ApplicationDirectory;
			if (text == null || text.Length == 0)
			{
				text = Directory.UnsafeGetCurrentDirectory();
			}
			return Path.Combine(text, fileName);
		}
		return fileName;
	}

	internal static bool CompareIdentities(ActivationContext activationContext1, ActivationContext activationContext2)
	{
		if (activationContext1 == null || activationContext2 == null)
		{
			return activationContext1 == activationContext2;
		}
		return IsolationInterop.AppIdAuthority.AreDefinitionsEqual(0u, activationContext1.Identity.Identity, activationContext2.Identity.Identity);
	}

	internal static bool CompareIdentities(ApplicationIdentity applicationIdentity1, ApplicationIdentity applicationIdentity2, ApplicationVersionMatch versionMatch)
	{
		if (applicationIdentity1 == null || applicationIdentity2 == null)
		{
			return applicationIdentity1 == applicationIdentity2;
		}
		uint flags = versionMatch switch
		{
			ApplicationVersionMatch.MatchExactVersion => 0u, 
			ApplicationVersionMatch.MatchAllVersions => 1u, 
			_ => throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", (int)versionMatch), "versionMatch"), 
		};
		return IsolationInterop.AppIdAuthority.AreDefinitionsEqual(flags, applicationIdentity1.Identity, applicationIdentity2.Identity);
	}

	internal static string GetFriendlyName(ActivationContext activationContext)
	{
		ICMS deploymentComponentManifest = activationContext.DeploymentComponentManifest;
		IMetadataSectionEntry metadataSectionEntry = (IMetadataSectionEntry)deploymentComponentManifest.MetadataSectionEntry;
		IDescriptionMetadataEntry descriptionData = metadataSectionEntry.DescriptionData;
		string result = string.Empty;
		if (descriptionData != null)
		{
			DescriptionMetadataEntry allData = descriptionData.AllData;
			result = ((allData.Publisher != null) ? $"{allData.Publisher} {allData.Product}" : allData.Product);
		}
		return result;
	}

	internal static void CreateActivationContext(string fullName, string[] manifestPaths, bool useFusionActivationContext, out ApplicationIdentity applicationIdentity, out ActivationContext activationContext)
	{
		applicationIdentity = new ApplicationIdentity(fullName);
		activationContext = null;
		if (useFusionActivationContext)
		{
			if (manifestPaths != null)
			{
				activationContext = new ActivationContext(applicationIdentity, manifestPaths);
			}
			else
			{
				activationContext = new ActivationContext(applicationIdentity);
			}
		}
	}

	internal static Evidence MergeApplicationEvidence(Evidence evidence, ApplicationIdentity applicationIdentity, ActivationContext activationContext, string[] activationData)
	{
		return MergeApplicationEvidence(evidence, applicationIdentity, activationContext, activationData, null);
	}

	internal static Evidence MergeApplicationEvidence(Evidence evidence, ApplicationIdentity applicationIdentity, ActivationContext activationContext, string[] activationData, ApplicationTrust applicationTrust)
	{
		Evidence evidence2 = new Evidence();
		ActivationArguments evidence3 = ((activationContext == null) ? new ActivationArguments(applicationIdentity, activationData) : new ActivationArguments(activationContext, activationData));
		evidence2 = new Evidence();
		evidence2.AddHostEvidence(evidence3);
		if (applicationTrust != null)
		{
			evidence2.AddHostEvidence(applicationTrust);
		}
		if (activationContext != null)
		{
			Evidence applicationEvidence = new ApplicationSecurityInfo(activationContext).ApplicationEvidence;
			if (applicationEvidence != null)
			{
				evidence2.MergeWithNoDuplicates(applicationEvidence);
			}
		}
		if (evidence != null)
		{
			evidence2.MergeWithNoDuplicates(evidence);
		}
		return evidence2;
	}
}
