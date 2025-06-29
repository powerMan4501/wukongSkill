using System.Deployment.Internal.Isolation.Manifest;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal static class IsolationInterop
{
	internal struct CreateActContextParameters
	{
		[Flags]
		public enum CreateFlags
		{
			Nothing = 0,
			StoreListValid = 1,
			CultureListValid = 2,
			ProcessorFallbackListValid = 4,
			ProcessorValid = 8,
			SourceValid = 0x10,
			IgnoreVisibility = 0x20
		}

		[MarshalAs(UnmanagedType.U4)]
		public uint Size;

		[MarshalAs(UnmanagedType.U4)]
		public uint Flags;

		[MarshalAs(UnmanagedType.SysInt)]
		public IntPtr CustomStoreList;

		[MarshalAs(UnmanagedType.SysInt)]
		public IntPtr CultureFallbackList;

		[MarshalAs(UnmanagedType.SysInt)]
		public IntPtr ProcessorArchitectureList;

		[MarshalAs(UnmanagedType.SysInt)]
		public IntPtr Source;

		[MarshalAs(UnmanagedType.U2)]
		public ushort ProcArch;
	}

	internal struct CreateActContextParametersSource
	{
		[Flags]
		public enum SourceFlags
		{
			Definition = 1,
			Reference = 2
		}

		[MarshalAs(UnmanagedType.U4)]
		public uint Size;

		[MarshalAs(UnmanagedType.U4)]
		public uint Flags;

		[MarshalAs(UnmanagedType.U4)]
		public uint SourceType;

		[MarshalAs(UnmanagedType.SysInt)]
		public IntPtr Data;

		[SecurityCritical]
		public IntPtr ToIntPtr()
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(this));
			Marshal.StructureToPtr(this, intPtr, fDeleteOld: false);
			return intPtr;
		}

		[SecurityCritical]
		public static void Destroy(IntPtr p)
		{
			Marshal.DestroyStructure(p, typeof(CreateActContextParametersSource));
			Marshal.FreeCoTaskMem(p);
		}
	}

	internal struct CreateActContextParametersSourceDefinitionAppid
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint Size;

		[MarshalAs(UnmanagedType.U4)]
		public uint Flags;

		public IDefinitionAppId AppId;

		[SecurityCritical]
		public IntPtr ToIntPtr()
		{
			IntPtr intPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(this));
			Marshal.StructureToPtr(this, intPtr, fDeleteOld: false);
			return intPtr;
		}

		[SecurityCritical]
		public static void Destroy(IntPtr p)
		{
			Marshal.DestroyStructure(p, typeof(CreateActContextParametersSourceDefinitionAppid));
			Marshal.FreeCoTaskMem(p);
		}
	}

	private static object _synchObject = new object();

	private static volatile IIdentityAuthority _idAuth = null;

	private static volatile IAppIdAuthority _appIdAuth = null;

	public const string IsolationDllName = "clr.dll";

	public static Guid IID_ICMS = GetGuidOfType(typeof(ICMS));

	public static Guid IID_IDefinitionIdentity = GetGuidOfType(typeof(IDefinitionIdentity));

	public static Guid IID_IManifestInformation = GetGuidOfType(typeof(IManifestInformation));

	public static Guid IID_IEnumSTORE_ASSEMBLY = GetGuidOfType(typeof(IEnumSTORE_ASSEMBLY));

	public static Guid IID_IEnumSTORE_ASSEMBLY_FILE = GetGuidOfType(typeof(IEnumSTORE_ASSEMBLY_FILE));

	public static Guid IID_IEnumSTORE_CATEGORY = GetGuidOfType(typeof(IEnumSTORE_CATEGORY));

	public static Guid IID_IEnumSTORE_CATEGORY_INSTANCE = GetGuidOfType(typeof(IEnumSTORE_CATEGORY_INSTANCE));

	public static Guid IID_IEnumSTORE_DEPLOYMENT_METADATA = GetGuidOfType(typeof(IEnumSTORE_DEPLOYMENT_METADATA));

	public static Guid IID_IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY = GetGuidOfType(typeof(IEnumSTORE_DEPLOYMENT_METADATA_PROPERTY));

	public static Guid IID_IStore = GetGuidOfType(typeof(IStore));

	public static Guid GUID_SXS_INSTALL_REFERENCE_SCHEME_OPAQUESTRING = new Guid("2ec93463-b0c3-45e1-8364-327e96aea856");

	public static Guid SXS_INSTALL_REFERENCE_SCHEME_SXS_STRONGNAME_SIGNED_PRIVATE_ASSEMBLY = new Guid("3ab20ac0-67e8-4512-8385-a487e35df3da");

	public static IIdentityAuthority IdentityAuthority
	{
		[SecuritySafeCritical]
		get
		{
			if (_idAuth == null)
			{
				lock (_synchObject)
				{
					if (_idAuth == null)
					{
						_idAuth = GetIdentityAuthority();
					}
				}
			}
			return _idAuth;
		}
	}

	public static IAppIdAuthority AppIdAuthority
	{
		[SecuritySafeCritical]
		get
		{
			if (_appIdAuth == null)
			{
				lock (_synchObject)
				{
					if (_appIdAuth == null)
					{
						_appIdAuth = GetAppIdAuthority();
					}
				}
			}
			return _appIdAuth;
		}
	}

	[SecuritySafeCritical]
	public static Store GetUserStore()
	{
		return new Store(GetUserStore(0u, IntPtr.Zero, ref IID_IStore) as IStore);
	}

	[SecuritySafeCritical]
	internal static IActContext CreateActContext(IDefinitionAppId AppId)
	{
		CreateActContextParameters Params = default(CreateActContextParameters);
		Params.Size = (uint)Marshal.SizeOf(typeof(CreateActContextParameters));
		Params.Flags = 16u;
		Params.CustomStoreList = IntPtr.Zero;
		Params.CultureFallbackList = IntPtr.Zero;
		Params.ProcessorArchitectureList = IntPtr.Zero;
		Params.Source = IntPtr.Zero;
		Params.ProcArch = 0;
		CreateActContextParametersSource createActContextParametersSource = default(CreateActContextParametersSource);
		createActContextParametersSource.Size = (uint)Marshal.SizeOf(typeof(CreateActContextParametersSource));
		createActContextParametersSource.Flags = 0u;
		createActContextParametersSource.SourceType = 1u;
		createActContextParametersSource.Data = IntPtr.Zero;
		CreateActContextParametersSourceDefinitionAppid createActContextParametersSourceDefinitionAppid = default(CreateActContextParametersSourceDefinitionAppid);
		createActContextParametersSourceDefinitionAppid.Size = (uint)Marshal.SizeOf(typeof(CreateActContextParametersSourceDefinitionAppid));
		createActContextParametersSourceDefinitionAppid.Flags = 0u;
		createActContextParametersSourceDefinitionAppid.AppId = AppId;
		try
		{
			createActContextParametersSource.Data = createActContextParametersSourceDefinitionAppid.ToIntPtr();
			Params.Source = createActContextParametersSource.ToIntPtr();
			return CreateActContext(ref Params) as IActContext;
		}
		finally
		{
			if (createActContextParametersSource.Data != IntPtr.Zero)
			{
				CreateActContextParametersSourceDefinitionAppid.Destroy(createActContextParametersSource.Data);
				createActContextParametersSource.Data = IntPtr.Zero;
			}
			if (Params.Source != IntPtr.Zero)
			{
				CreateActContextParametersSource.Destroy(Params.Source);
				Params.Source = IntPtr.Zero;
			}
		}
	}

	[DllImport("clr.dll", PreserveSig = false)]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	internal static extern object CreateActContext(ref CreateActContextParameters Params);

	[DllImport("clr.dll", PreserveSig = false)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	internal static extern object CreateCMSFromXml([In] byte[] buffer, [In] uint bufferSize, [In] IManifestParseErrorCallback Callback, [In] ref Guid riid);

	[DllImport("clr.dll", PreserveSig = false)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	internal static extern object ParseManifest([In][MarshalAs(UnmanagedType.LPWStr)] string pszManifestPath, [In] IManifestParseErrorCallback pIManifestParseErrorCallback, [In] ref Guid riid);

	[DllImport("clr.dll", PreserveSig = false)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.IUnknown)]
	private static extern object GetUserStore([In] uint Flags, [In] IntPtr hToken, [In] ref Guid riid);

	[DllImport("clr.dll", PreserveSig = false)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Interface)]
	private static extern IIdentityAuthority GetIdentityAuthority();

	[DllImport("clr.dll", PreserveSig = false)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Interface)]
	private static extern IAppIdAuthority GetAppIdAuthority();

	internal static Guid GetGuidOfType(Type type)
	{
		GuidAttribute guidAttribute = (GuidAttribute)Attribute.GetCustomAttribute(type, typeof(GuidAttribute), inherit: false);
		return new Guid(guidAttribute.Value);
	}
}
