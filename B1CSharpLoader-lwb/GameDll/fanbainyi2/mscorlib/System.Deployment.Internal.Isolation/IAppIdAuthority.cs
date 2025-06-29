using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

[ComImport]
[Guid("8c87810c-2541-4f75-b2d0-9af515488e23")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAppIdAuthority
{
	[SecurityCritical]
	IDefinitionAppId TextToDefinition([In] uint Flags, [In][MarshalAs(UnmanagedType.LPWStr)] string Identity);

	[SecurityCritical]
	IReferenceAppId TextToReference([In] uint Flags, [In][MarshalAs(UnmanagedType.LPWStr)] string Identity);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string DefinitionToText([In] uint Flags, [In] IDefinitionAppId DefinitionAppId);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string ReferenceToText([In] uint Flags, [In] IReferenceAppId ReferenceAppId);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool AreDefinitionsEqual([In] uint Flags, [In] IDefinitionAppId Definition1, [In] IDefinitionAppId Definition2);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool AreReferencesEqual([In] uint Flags, [In] IReferenceAppId Reference1, [In] IReferenceAppId Reference2);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool AreTextualDefinitionsEqual([In] uint Flags, [In][MarshalAs(UnmanagedType.LPWStr)] string AppIdLeft, [In][MarshalAs(UnmanagedType.LPWStr)] string AppIdRight);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool AreTextualReferencesEqual([In] uint Flags, [In][MarshalAs(UnmanagedType.LPWStr)] string AppIdLeft, [In][MarshalAs(UnmanagedType.LPWStr)] string AppIdRight);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool DoesDefinitionMatchReference([In] uint Flags, [In] IDefinitionAppId DefinitionIdentity, [In] IReferenceAppId ReferenceIdentity);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	bool DoesTextualDefinitionMatchTextualReference([In] uint Flags, [In][MarshalAs(UnmanagedType.LPWStr)] string Definition, [In][MarshalAs(UnmanagedType.LPWStr)] string Reference);

	[SecurityCritical]
	ulong HashReference([In] uint Flags, [In] IReferenceAppId ReferenceIdentity);

	[SecurityCritical]
	ulong HashDefinition([In] uint Flags, [In] IDefinitionAppId DefinitionIdentity);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string GenerateDefinitionKey([In] uint Flags, [In] IDefinitionAppId DefinitionIdentity);

	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.LPWStr)]
	string GenerateReferenceKey([In] uint Flags, [In] IReferenceAppId ReferenceIdentity);

	[SecurityCritical]
	IDefinitionAppId CreateDefinition();

	[SecurityCritical]
	IReferenceAppId CreateReference();
}
