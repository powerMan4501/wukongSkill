using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Resources;

internal class FileBasedResourceGroveler : IResourceGroveler
{
	private ResourceManager.ResourceManagerMediator _mediator;

	public FileBasedResourceGroveler(ResourceManager.ResourceManagerMediator mediator)
	{
		_mediator = mediator;
	}

	[SecuritySafeCritical]
	public ResourceSet GrovelForResourceSet(CultureInfo culture, Dictionary<string, ResourceSet> localResourceSets, bool tryParents, bool createIfNotExists, ref StackCrawlMark stackMark)
	{
		string text = null;
		ResourceSet result = null;
		try
		{
			new FileIOPermission(PermissionState.Unrestricted).Assert();
			string resourceFileName = _mediator.GetResourceFileName(culture);
			text = FindResourceFile(culture, resourceFileName);
			if (text == null)
			{
				if (tryParents && culture.HasInvariantCultureName)
				{
					throw new MissingManifestResourceException(Environment.GetResourceString("MissingManifestResource_NoNeutralDisk") + Environment.NewLine + "baseName: " + _mediator.BaseNameField + "  locationInfo: " + ((_mediator.LocationInfo == null) ? "<null>" : _mediator.LocationInfo.FullName) + "  fileName: " + _mediator.GetResourceFileName(culture));
				}
			}
			else
			{
				result = CreateResourceSet(text);
			}
			return result;
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}

	public bool HasNeutralResources(CultureInfo culture, string defaultResName)
	{
		string text = FindResourceFile(culture, defaultResName);
		if (text == null || !File.Exists(text))
		{
			string moduleDir = _mediator.ModuleDir;
			if (text != null)
			{
				moduleDir = Path.GetDirectoryName(text);
			}
			return false;
		}
		return true;
	}

	private string FindResourceFile(CultureInfo culture, string fileName)
	{
		if (_mediator.ModuleDir != null)
		{
			string text = Path.Combine(_mediator.ModuleDir, fileName);
			if (File.Exists(text))
			{
				return text;
			}
		}
		if (File.Exists(fileName))
		{
			return fileName;
		}
		return null;
	}

	[SecurityCritical]
	private ResourceSet CreateResourceSet(string file)
	{
		if (_mediator.UserResourceSet == null)
		{
			return new RuntimeResourceSet(file);
		}
		object[] args = new object[1] { file };
		try
		{
			return (ResourceSet)Activator.CreateInstance(_mediator.UserResourceSet, args);
		}
		catch (MissingMethodException innerException)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ResMgrBadResSet_Type", _mediator.UserResourceSet.AssemblyQualifiedName), innerException);
		}
	}
}
