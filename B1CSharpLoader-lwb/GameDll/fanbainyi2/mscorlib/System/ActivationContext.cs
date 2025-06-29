using System.Collections;
using System.Deployment.Internal.Isolation;
using System.Deployment.Internal.Isolation.Manifest;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(false)]
public sealed class ActivationContext : IDisposable, ISerializable
{
	public enum ContextForm
	{
		Loose,
		StoreBounded
	}

	internal enum ApplicationState
	{
		Undefined,
		Starting,
		Running
	}

	internal enum ApplicationStateDisposition
	{
		Undefined = 0,
		Starting = 1,
		StartingMigrated = 65537,
		Running = 2,
		RunningFirstTime = 131074
	}

	private ApplicationIdentity _applicationIdentity;

	private ArrayList _definitionIdentities;

	private ArrayList _manifests;

	private string[] _manifestPaths;

	private ContextForm _form;

	private ApplicationStateDisposition _appRunState;

	private IActContext _actContext;

	private const int DefaultComponentCount = 2;

	public ApplicationIdentity Identity => _applicationIdentity;

	public ContextForm Form => _form;

	public byte[] ApplicationManifestBytes => GetApplicationManifestBytes();

	public byte[] DeploymentManifestBytes => GetDeploymentManifestBytes();

	internal string[] ManifestPaths => _manifestPaths;

	internal string ApplicationDirectory
	{
		[SecurityCritical]
		get
		{
			if (_form == ContextForm.Loose)
			{
				return Path.GetDirectoryName(_manifestPaths[_manifestPaths.Length - 1]);
			}
			_actContext.ApplicationBasePath(0u, out var ApplicationPath);
			return ApplicationPath;
		}
	}

	internal string DataDirectory
	{
		[SecurityCritical]
		get
		{
			if (_form == ContextForm.Loose)
			{
				return null;
			}
			_actContext.GetApplicationStateFilesystemLocation(1u, UIntPtr.Zero, IntPtr.Zero, out var ppszPath);
			return ppszPath;
		}
	}

	internal ICMS ActivationContextData
	{
		[SecurityCritical]
		get
		{
			return ApplicationComponentManifest;
		}
	}

	internal ICMS DeploymentComponentManifest
	{
		[SecurityCritical]
		get
		{
			if (_form == ContextForm.Loose)
			{
				return (ICMS)_manifests[0];
			}
			return GetComponentManifest((IDefinitionIdentity)_definitionIdentities[0]);
		}
	}

	internal ICMS ApplicationComponentManifest
	{
		[SecurityCritical]
		get
		{
			if (_form == ContextForm.Loose)
			{
				return (ICMS)_manifests[_manifests.Count - 1];
			}
			return GetComponentManifest((IDefinitionIdentity)_definitionIdentities[_definitionIdentities.Count - 1]);
		}
	}

	internal ApplicationStateDisposition LastApplicationStateResult => _appRunState;

	private ActivationContext()
	{
	}

	[SecurityCritical]
	private ActivationContext(SerializationInfo info, StreamingContext context)
	{
		string applicationIdentityFullName = (string)info.GetValue("FullName", typeof(string));
		string[] array = (string[])info.GetValue("ManifestPaths", typeof(string[]));
		if (array == null)
		{
			CreateFromName(new ApplicationIdentity(applicationIdentityFullName));
		}
		else
		{
			CreateFromNameAndManifests(new ApplicationIdentity(applicationIdentityFullName), array);
		}
	}

	internal ActivationContext(ApplicationIdentity applicationIdentity)
	{
		CreateFromName(applicationIdentity);
	}

	internal ActivationContext(ApplicationIdentity applicationIdentity, string[] manifestPaths)
	{
		CreateFromNameAndManifests(applicationIdentity, manifestPaths);
	}

	[SecuritySafeCritical]
	private void CreateFromName(ApplicationIdentity applicationIdentity)
	{
		if (applicationIdentity == null)
		{
			throw new ArgumentNullException("applicationIdentity");
		}
		_applicationIdentity = applicationIdentity;
		IEnumDefinitionIdentity enumDefinitionIdentity = _applicationIdentity.Identity.EnumAppPath();
		_definitionIdentities = new ArrayList(2);
		IDefinitionIdentity[] array = new IDefinitionIdentity[1];
		while (enumDefinitionIdentity.Next(1u, array) == 1)
		{
			_definitionIdentities.Add(array[0]);
		}
		_definitionIdentities.TrimToSize();
		if (_definitionIdentities.Count <= 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidAppId"));
		}
		_manifestPaths = null;
		_manifests = null;
		_actContext = IsolationInterop.CreateActContext(_applicationIdentity.Identity);
		_form = ContextForm.StoreBounded;
		_appRunState = ApplicationStateDisposition.Undefined;
	}

	[SecuritySafeCritical]
	private void CreateFromNameAndManifests(ApplicationIdentity applicationIdentity, string[] manifestPaths)
	{
		if (applicationIdentity == null)
		{
			throw new ArgumentNullException("applicationIdentity");
		}
		if (manifestPaths == null)
		{
			throw new ArgumentNullException("manifestPaths");
		}
		_applicationIdentity = applicationIdentity;
		IEnumDefinitionIdentity enumDefinitionIdentity = _applicationIdentity.Identity.EnumAppPath();
		_manifests = new ArrayList(2);
		_manifestPaths = new string[manifestPaths.Length];
		IDefinitionIdentity[] array = new IDefinitionIdentity[1];
		int num = 0;
		while (enumDefinitionIdentity.Next(1u, array) == 1)
		{
			ICMS iCMS = (ICMS)IsolationInterop.ParseManifest(manifestPaths[num], null, ref IsolationInterop.IID_ICMS);
			if (IsolationInterop.IdentityAuthority.AreDefinitionsEqual(0u, iCMS.Identity, array[0]))
			{
				_manifests.Add(iCMS);
				_manifestPaths[num] = manifestPaths[num];
				num++;
				continue;
			}
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalAppIdMismatch"));
		}
		if (num != manifestPaths.Length)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_IllegalAppId"));
		}
		_manifests.TrimToSize();
		if (_manifests.Count <= 1)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidAppId"));
		}
		_definitionIdentities = null;
		_actContext = null;
		_form = ContextForm.Loose;
		_appRunState = ApplicationStateDisposition.Undefined;
	}

	~ActivationContext()
	{
		Dispose(fDisposing: false);
	}

	public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity)
	{
		return new ActivationContext(identity);
	}

	public static ActivationContext CreatePartialActivationContext(ApplicationIdentity identity, string[] manifestPaths)
	{
		return new ActivationContext(identity, manifestPaths);
	}

	public void Dispose()
	{
		Dispose(fDisposing: true);
		GC.SuppressFinalize(this);
	}

	[SecurityCritical]
	internal ICMS GetComponentManifest(IDefinitionIdentity component)
	{
		_actContext.GetComponentManifest(0u, component, ref IsolationInterop.IID_ICMS, out var ManifestInteface);
		return ManifestInteface as ICMS;
	}

	[SecuritySafeCritical]
	internal byte[] GetDeploymentManifestBytes()
	{
		string FullPath;
		if (_form == ContextForm.Loose)
		{
			FullPath = _manifestPaths[0];
		}
		else
		{
			_actContext.GetComponentManifest(0u, (IDefinitionIdentity)_definitionIdentities[0], ref IsolationInterop.IID_IManifestInformation, out var ManifestInteface);
			((IManifestInformation)ManifestInteface).get_FullPath(out FullPath);
			Marshal.ReleaseComObject(ManifestInteface);
		}
		return ReadBytesFromFile(FullPath);
	}

	[SecuritySafeCritical]
	internal byte[] GetApplicationManifestBytes()
	{
		string FullPath;
		if (_form == ContextForm.Loose)
		{
			FullPath = _manifestPaths[_manifests.Count - 1];
		}
		else
		{
			_actContext.GetComponentManifest(0u, (IDefinitionIdentity)_definitionIdentities[1], ref IsolationInterop.IID_IManifestInformation, out var ManifestInteface);
			((IManifestInformation)ManifestInteface).get_FullPath(out FullPath);
			Marshal.ReleaseComObject(ManifestInteface);
		}
		return ReadBytesFromFile(FullPath);
	}

	[SecuritySafeCritical]
	internal void PrepareForExecution()
	{
		if (_form != ContextForm.Loose)
		{
			_actContext.PrepareForExecution(IntPtr.Zero, IntPtr.Zero);
		}
	}

	[SecuritySafeCritical]
	internal ApplicationStateDisposition SetApplicationState(ApplicationState s)
	{
		if (_form == ContextForm.Loose)
		{
			return ApplicationStateDisposition.Undefined;
		}
		_actContext.SetApplicationRunningState(0u, (uint)s, out var ulDisposition);
		_appRunState = (ApplicationStateDisposition)ulDisposition;
		return _appRunState;
	}

	[SecuritySafeCritical]
	private void Dispose(bool fDisposing)
	{
		_applicationIdentity = null;
		_definitionIdentities = null;
		_manifests = null;
		_manifestPaths = null;
		if (_actContext != null)
		{
			Marshal.ReleaseComObject(_actContext);
		}
	}

	private static byte[] ReadBytesFromFile(string manifestPath)
	{
		byte[] array = null;
		using FileStream fileStream = new FileStream(manifestPath, FileMode.Open, FileAccess.Read);
		int num = (int)fileStream.Length;
		array = new byte[num];
		if (fileStream.CanSeek)
		{
			fileStream.Seek(0L, SeekOrigin.Begin);
		}
		fileStream.Read(array, 0, num);
		return array;
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (_applicationIdentity != null)
		{
			info.AddValue("FullName", _applicationIdentity.FullName, typeof(string));
		}
		if (_manifestPaths != null)
		{
			info.AddValue("ManifestPaths", _manifestPaths, typeof(string[]));
		}
	}
}
