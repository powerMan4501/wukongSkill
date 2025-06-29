using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace System.Resources;

internal class ManifestBasedResourceGroveler : IResourceGroveler
{
	private ResourceManager.ResourceManagerMediator _mediator;

	public ManifestBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
	{
		_mediator = mediator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
	{
		ResourceSet value = null;
		Stream stream = null;
		RuntimeAssembly runtimeAssembly = null;
		CultureInfo cultureInfo = UltimateFallbackFixup(culture);
		if (cultureInfo.HasInvariantCultureName && _mediator.FallbackLoc == UltimateResourceFallbackLocation.MainAssembly)
		{
			runtimeAssembly = _mediator.MainAssembly;
		}
		else if (!cultureInfo.HasInvariantCultureName && !_mediator.TryLookingForSatellite(cultureInfo))
		{
			runtimeAssembly = null;
		}
		else
		{
			runtimeAssembly = GetSatelliteAssembly(cultureInfo, ref stackMark);
			if (runtimeAssembly == null && culture.HasInvariantCultureName && _mediator.FallbackLoc == UltimateResourceFallbackLocation.Satellite)
			{
				HandleSatelliteMissing();
			}
		}
		string resourceFileName = _mediator.GetResourceFileName(cultureInfo);
		if (runtimeAssembly != null)
		{
			lock (localResourceSets)
			{
				if (localResourceSets.TryGetValue(culture.Name, out value) && FrameworkEventSource.IsInitialized)
				{
					FrameworkEventSource.Log.ResourceManagerFoundResourceSetInCacheUnexpected(_mediator.BaseName, _mediator.MainAssembly, culture.Name);
				}
			}
			stream = GetManifestResourceStream(runtimeAssembly, resourceFileName, ref stackMark);
		}
		if (FrameworkEventSource.IsInitialized)
		{
			if (stream != null)
			{
				FrameworkEventSource.Log.ResourceManagerStreamFound(_mediator.BaseName, _mediator.MainAssembly, culture.Name, runtimeAssembly, resourceFileName);
			}
			else
			{
				FrameworkEventSource.Log.ResourceManagerStreamNotFound(_mediator.BaseName, _mediator.MainAssembly, culture.Name, runtimeAssembly, resourceFileName);
			}
		}
		if (createIfNotExists && stream != null && value == null)
		{
			if (FrameworkEventSource.IsInitialized)
			{
				FrameworkEventSource.Log.ResourceManagerCreatingResourceSet(_mediator.BaseName, _mediator.MainAssembly, culture.Name, resourceFileName);
			}
			value = CreateResourceSet(stream, runtimeAssembly);
		}
		else if (stream == null && tryParents && culture.HasInvariantCultureName)
		{
			HandleResourceStreamMissing(resourceFileName);
		}
		if (!createIfNotExists && stream != null && value == null && FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerNotCreatingResourceSet(_mediator.BaseName, _mediator.MainAssembly, culture.Name);
		}
		return value;
	}

	public bool HasNeutralResources(CultureInfo culture, string defaultResName)
	{
		string value = defaultResName;
		if (_mediator.LocationInfo != null && _mediator.LocationInfo.Namespace != null)
		{
			value = _mediator.LocationInfo.Namespace + Type.Delimiter + defaultResName;
		}
		string[] manifestResourceNames = _mediator.MainAssembly.GetManifestResourceNames();
		string[] array = manifestResourceNames;
		foreach (string text in array)
		{
			if (text.Equals(value))
			{
				return true;
			}
		}
		return false;
	}

	private CultureInfo UltimateFallbackFixup(CultureInfo lookForCulture)
	{
		CultureInfo result = lookForCulture;
		if (lookForCulture.Name == _mediator.NeutralResourcesCulture.Name && _mediator.FallbackLoc == UltimateResourceFallbackLocation.MainAssembly)
		{
			if (FrameworkEventSource.IsInitialized)
			{
				FrameworkEventSource.Log.ResourceManagerNeutralResourcesSufficient(_mediator.BaseName, _mediator.MainAssembly, lookForCulture.Name);
			}
			result = CultureInfo.InvariantCulture;
		}
		else if (lookForCulture.HasInvariantCultureName && _mediator.FallbackLoc == UltimateResourceFallbackLocation.Satellite)
		{
			result = _mediator.NeutralResourcesCulture;
		}
		return result;
	}

	[SecurityCritical]
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation)
	{
		string s = null;
		short fallbackLocation2 = 0;
		if (GetNeutralResourcesLanguageAttribute(((RuntimeAssembly)a).GetNativeHandle(), JitHelpers.GetStringHandleOnStack(ref s), out fallbackLocation2))
		{
			if (fallbackLocation2 < 0 || fallbackLocation2 > 1)
			{
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidNeutralResourcesLanguage_FallbackLoc", fallbackLocation2));
			}
			fallbackLocation = (UltimateResourceFallbackLocation)fallbackLocation2;
			try
			{
				return CultureInfo.GetCultureInfo(s);
			}
			catch (ArgumentException innerException)
			{
				if (a == typeof(object).Assembly)
				{
					return CultureInfo.InvariantCulture;
				}
				throw new ArgumentException(Environment.GetResourceString("Arg_InvalidNeutralResourcesLanguage_Asm_Culture", a.ToString(), s), innerException);
			}
		}
		if (FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerNeutralResourceAttributeMissing(a);
		}
		fallbackLocation = UltimateResourceFallbackLocation.MainAssembly;
		return CultureInfo.InvariantCulture;
	}

	[SecurityCritical]
	internal ResourceSet CreateResourceSet(Stream store, Assembly assembly)
	{
		if (store.CanSeek && store.Length > 4)
		{
			long position = store.Position;
			BinaryReader binaryReader = new BinaryReader(store);
			int num = binaryReader.ReadInt32();
			if (num == ResourceManager.MagicNumber)
			{
				int num2 = binaryReader.ReadInt32();
				string text = null;
				string text2 = null;
				if (num2 == ResourceManager.HeaderVersionNumber)
				{
					binaryReader.ReadInt32();
					text = binaryReader.ReadString();
					text2 = binaryReader.ReadString();
				}
				else
				{
					if (num2 <= ResourceManager.HeaderVersionNumber)
					{
						throw new NotSupportedException(Environment.GetResourceString("NotSupported_ObsoleteResourcesFile", _mediator.MainAssembly.GetSimpleName()));
					}
					int num3 = binaryReader.ReadInt32();
					long offset = binaryReader.BaseStream.Position + num3;
					text = binaryReader.ReadString();
					text2 = binaryReader.ReadString();
					binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
				}
				store.Position = position;
				if (CanUseDefaultResourceClasses(text, text2))
				{
					return new RuntimeResourceSet(store);
				}
				Type type = Type.GetType(text, throwOnError: true);
				IResourceReader resourceReader = (IResourceReader)Activator.CreateInstance(type, store);
				object[] args = new object[1] { resourceReader };
				Type type2 = ((!(_mediator.UserResourceSet == null)) ? _mediator.UserResourceSet : Type.GetType(text2, throwOnError: true, ignoreCase: false));
				return (ResourceSet)Activator.CreateInstance(type2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.CreateInstance, null, args, null, null);
			}
			store.Position = position;
		}
		if (_mediator.UserResourceSet == null)
		{
			return new RuntimeResourceSet(store);
		}
		object[] args2 = new object[2] { store, assembly };
		try
		{
			ResourceSet resourceSet = null;
			try
			{
				return (ResourceSet)Activator.CreateInstance(_mediator.UserResourceSet, args2);
			}
			catch (MissingMethodException)
			{
			}
			return (ResourceSet)Activator.CreateInstance(args: new object[1] { store }, type: _mediator.UserResourceSet);
		}
		catch (MissingMethodException innerException)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ResMgrBadResSet_Type", _mediator.UserResourceSet.AssemblyQualifiedName), innerException);
		}
	}

	[SecurityCritical]
	private Stream GetManifestResourceStream(RuntimeAssembly satellite, string fileName, ref StackCrawlMark stackMark)
	{
		bool skipSecurityCheck = _mediator.MainAssembly == satellite && _mediator.CallingAssembly == _mediator.MainAssembly;
		Stream stream = satellite.GetManifestResourceStream(_mediator.LocationInfo, fileName, skipSecurityCheck, ref stackMark);
		if (stream == null)
		{
			stream = CaseInsensitiveManifestResourceStreamLookup(satellite, fileName);
		}
		return stream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private Stream CaseInsensitiveManifestResourceStreamLookup(RuntimeAssembly satellite, string name)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (_mediator.LocationInfo != null)
		{
			string text = _mediator.LocationInfo.Namespace;
			if (text != null)
			{
				stringBuilder.Append(text);
				if (name != null)
				{
					stringBuilder.Append(Type.Delimiter);
				}
			}
		}
		stringBuilder.Append(name);
		string text2 = stringBuilder.ToString();
		CompareInfo compareInfo = CultureInfo.InvariantCulture.CompareInfo;
		string text3 = null;
		string[] manifestResourceNames = satellite.GetManifestResourceNames();
		foreach (string text4 in manifestResourceNames)
		{
			if (compareInfo.Compare(text4, text2, CompareOptions.IgnoreCase) == 0)
			{
				if (text3 != null)
				{
					throw new MissingManifestResourceException(Environment.GetResourceString("MissingManifestResource_MultipleBlobs", text2, satellite.ToString()));
				}
				text3 = text4;
			}
		}
		if (FrameworkEventSource.IsInitialized)
		{
			if (text3 != null)
			{
				FrameworkEventSource.Log.ResourceManagerCaseInsensitiveResourceStreamLookupSucceeded(_mediator.BaseName, _mediator.MainAssembly, satellite.GetSimpleName(), text2);
			}
			else
			{
				FrameworkEventSource.Log.ResourceManagerCaseInsensitiveResourceStreamLookupFailed(_mediator.BaseName, _mediator.MainAssembly, satellite.GetSimpleName(), text2);
			}
		}
		if (text3 == null)
		{
			return null;
		}
		bool skipSecurityCheck = _mediator.MainAssembly == satellite && _mediator.CallingAssembly == _mediator.MainAssembly;
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Stream manifestResourceStream = satellite.GetManifestResourceStream(text3, ref stackMark, skipSecurityCheck);
		if (manifestResourceStream != null && FrameworkEventSource.IsInitialized)
		{
			FrameworkEventSource.Log.ResourceManagerManifestResourceAccessDenied(_mediator.BaseName, _mediator.MainAssembly, satellite.GetSimpleName(), text3);
		}
		return manifestResourceStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	private RuntimeAssembly GetSatelliteAssembly(CultureInfo lookForCulture, ref StackCrawlMark stackMark)
	{
		if (!_mediator.LookedForSatelliteContractVersion)
		{
			_mediator.SatelliteContractVersion = _mediator.ObtainSatelliteContractVersion(_mediator.MainAssembly);
			_mediator.LookedForSatelliteContractVersion = true;
		}
		RuntimeAssembly runtimeAssembly = null;
		string satelliteAssemblyName = GetSatelliteAssemblyName();
		try
		{
			runtimeAssembly = _mediator.MainAssembly.InternalGetSatelliteAssembly(satelliteAssemblyName, lookForCulture, _mediator.SatelliteContractVersion, throwOnFileNotFound: false, ref stackMark);
		}
		catch (FileLoadException ex)
		{
			int hResult = ex._HResult;
			Win32Native.MakeHRFromErrorCode(5);
		}
		catch (BadImageFormatException)
		{
		}
		if (FrameworkEventSource.IsInitialized)
		{
			if (runtimeAssembly != null)
			{
				FrameworkEventSource.Log.ResourceManagerGetSatelliteAssemblySucceeded(_mediator.BaseName, _mediator.MainAssembly, lookForCulture.Name, satelliteAssemblyName);
			}
			else
			{
				FrameworkEventSource.Log.ResourceManagerGetSatelliteAssemblyFailed(_mediator.BaseName, _mediator.MainAssembly, lookForCulture.Name, satelliteAssemblyName);
			}
		}
		return runtimeAssembly;
	}

	private bool CanUseDefaultResourceClasses(string readerTypeName, string resSetTypeName)
	{
		if (_mediator.UserResourceSet != null)
		{
			return false;
		}
		AssemblyName asmName = new AssemblyName(ResourceManager.MscorlibName);
		if (readerTypeName != null && !ResourceManager.CompareNames(readerTypeName, ResourceManager.ResReaderTypeName, asmName))
		{
			return false;
		}
		if (resSetTypeName != null && !ResourceManager.CompareNames(resSetTypeName, ResourceManager.ResSetTypeName, asmName))
		{
			return false;
		}
		return true;
	}

	[SecurityCritical]
	private string GetSatelliteAssemblyName()
	{
		string simpleName = _mediator.MainAssembly.GetSimpleName();
		return simpleName + ".resources";
	}

	[SecurityCritical]
	private void HandleSatelliteMissing()
	{
		string text = _mediator.MainAssembly.GetSimpleName() + ".resources.dll";
		if (_mediator.SatelliteContractVersion != null)
		{
			text = text + ", Version=" + _mediator.SatelliteContractVersion.ToString();
		}
		AssemblyName assemblyName = new AssemblyName();
		assemblyName.SetPublicKey(_mediator.MainAssembly.GetPublicKey());
		byte[] publicKeyToken = assemblyName.GetPublicKeyToken();
		int num = publicKeyToken.Length;
		StringBuilder stringBuilder = new StringBuilder(num * 2);
		for (int i = 0; i < num; i++)
		{
			stringBuilder.Append(publicKeyToken[i].ToString("x", CultureInfo.InvariantCulture));
		}
		text = text + ", PublicKeyToken=" + stringBuilder;
		string text2 = _mediator.NeutralResourcesCulture.Name;
		if (text2.Length == 0)
		{
			text2 = "<invariant>";
		}
		throw new MissingSatelliteAssemblyException(Environment.GetResourceString("MissingSatelliteAssembly_Culture_Name", _mediator.NeutralResourcesCulture, text), text2);
	}

	[SecurityCritical]
	private void HandleResourceStreamMissing(string fileName)
	{
		if (_mediator.MainAssembly == typeof(object).Assembly && _mediator.BaseName.Equals("mscorlib"))
		{
			string message = "mscorlib.resources couldn't be found!  Large parts of the BCL won't work!";
			Environment.FailFast(message);
		}
		string text = string.Empty;
		if (_mediator.LocationInfo != null && _mediator.LocationInfo.Namespace != null)
		{
			text = _mediator.LocationInfo.Namespace + Type.Delimiter;
		}
		text += fileName;
		throw new MissingManifestResourceException(Environment.GetResourceString("MissingManifestResource_NoNeutralAsm", text, _mediator.MainAssembly.GetSimpleName()));
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetNeutralResourcesLanguageAttribute(RuntimeAssembly assemblyHandle, StringHandleOnStack cultureName, out short fallbackLocation);
}
