using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("a5c62f6d-5e3e-4cd9-b345-6b281d7a1d1e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IStore
{
	[SecurityCritical]
	void Transact([In] IntPtr cOperation, [In][MarshalAs(UnmanagedType.LPArray)] StoreTransactionOperation[] rgOperations, [Out][MarshalAs(UnmanagedType.LPArray)] uint[] rgDispositions, [Out][MarshalAs(UnmanagedType.LPArray)] int[] rgResults);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object BindReferenceToAssembly([In] uint Flags, [In] IReferenceIdentity ReferenceIdentity, [In] uint cDeploymentsToIgnore, [In][MarshalAs(UnmanagedType.LPArray)] IDefinitionIdentity[] DefinitionIdentity_DeploymentsToIgnore, [In] ref Guid riid);

	[SecurityCritical]
	void CalculateDelimiterOfDeploymentsBasedOnQuota([In] uint dwFlags, [In] IntPtr cDeployments, [In][MarshalAs(UnmanagedType.LPArray)] IDefinitionAppId[] rgpIDefinitionAppId_Deployments, [In] ref StoreApplicationReference InstallerReference, [In] ulong ulonglongQuota, [In][Out] ref IntPtr Delimiter, [In][Out] ref ulong SizeSharedWithExternalDeployment, [In][Out] ref ulong SizeConsumedByInputDeploymentArray);

	[SecurityCritical]
	IntPtr BindDefinitions([In] uint Flags, [In][MarshalAs(UnmanagedType.SysInt)] IntPtr Count, [In][MarshalAs(UnmanagedType.LPArray)] IDefinitionIdentity[] DefsToBind, [In] uint DeploymentsToIgnore, [In][MarshalAs(UnmanagedType.LPArray)] IDefinitionIdentity[] DefsToIgnore);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object GetAssemblyInformation([In] uint Flags, [In] IDefinitionIdentity DefinitionIdentity, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumAssemblies([In] uint Flags, [In] IReferenceIdentity ReferenceIdentity_ToMatch, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumFiles([In] uint Flags, [In] IDefinitionIdentity DefinitionIdentity, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumInstallationReferences([In] uint Flags, [In] IDefinitionIdentity DefinitionIdentity, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string LockAssemblyPath([In] uint Flags, [In] IDefinitionIdentity DefinitionIdentity, out IntPtr Cookie);

	[SecurityCritical]
	void ReleaseAssemblyPath([In] IntPtr Cookie);

	[SecurityCritical]
	ulong QueryChangeID([In] IDefinitionIdentity DefinitionIdentity);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumCategories([In] uint Flags, [In] IReferenceIdentity ReferenceIdentity_ToMatch, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumSubcategories([In] uint Flags, [In] IDefinitionIdentity CategoryId, [In][MarshalAs(UnmanagedType.LPWStr)] string SubcategoryPathPattern, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumCategoryInstances([In] uint Flags, [In] IDefinitionIdentity CategoryId, [In][MarshalAs(UnmanagedType.LPWStr)] string SubcategoryPath, [In] ref Guid riid);

	[SecurityCritical]
	void GetDeploymentProperty([In] uint Flags, [In] IDefinitionAppId DeploymentInPackage, [In] ref StoreApplicationReference Reference, [In] ref Guid PropertySet, [In][MarshalAs(UnmanagedType.LPWStr)] string pcwszPropertyName, out BLOB blob);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string LockApplicationPath([In] uint Flags, [In] IDefinitionAppId ApId, out IntPtr Cookie);

	[SecurityCritical]
	void ReleaseApplicationPath([In] IntPtr Cookie);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumPrivateFiles([In] uint Flags, [In] IDefinitionAppId Application, [In] IDefinitionIdentity DefinitionIdentity, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumInstallerDeploymentMetadata([In] uint Flags, [In] ref StoreApplicationReference Reference, [In] IReferenceAppId Filter, [In] ref Guid riid);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	object EnumInstallerDeploymentMetadataProperties([In] uint Flags, [In] ref StoreApplicationReference Reference, [In] IDefinitionAppId Filter, [In] ref Guid riid);
}
