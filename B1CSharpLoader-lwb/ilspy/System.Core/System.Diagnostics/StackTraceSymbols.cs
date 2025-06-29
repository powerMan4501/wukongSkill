using System.Collections.Concurrent;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics;

internal sealed class StackTraceSymbols : IDisposable
{
	private readonly ConcurrentDictionary<IntPtr, MetadataReaderProvider> _metadataCache;

	public StackTraceSymbols()
	{
		_metadataCache = new ConcurrentDictionary<IntPtr, MetadataReaderProvider>();
	}

	void IDisposable.Dispose()
	{
		foreach (MetadataReaderProvider value in _metadataCache.Values)
		{
			value?.Dispose();
		}
		_metadataCache.Clear();
	}

	[SecuritySafeCritical]
	public void GetSourceLineInfo(string assemblyPath, IntPtr loadedPeAddress, int loadedPeSize, IntPtr inMemoryPdbAddress, int inMemoryPdbSize, int methodToken, int ilOffset, out string sourceFile, out int sourceLine, out int sourceColumn)
	{
		new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Assert();
		GetSourceLineInfoWithoutCasAssert(assemblyPath, loadedPeAddress, loadedPeSize, inMemoryPdbAddress, inMemoryPdbSize, methodToken, ilOffset, out sourceFile, out sourceLine, out sourceColumn);
	}

	[SecuritySafeCritical]
	public void GetSourceLineInfoWithoutCasAssert(string assemblyPath, IntPtr loadedPeAddress, int loadedPeSize, IntPtr inMemoryPdbAddress, int inMemoryPdbSize, int methodToken, int ilOffset, out string sourceFile, out int sourceLine, out int sourceColumn)
	{
		sourceFile = null;
		sourceLine = 0;
		sourceColumn = 0;
		try
		{
			MetadataReader metadataReader = TryGetReader(assemblyPath, loadedPeAddress, loadedPeSize, inMemoryPdbAddress, inMemoryPdbSize);
			if (metadataReader == null)
			{
				return;
			}
			Handle handle = MetadataTokens.Handle(methodToken);
			if (handle.Kind != HandleKind.MethodDefinition)
			{
				return;
			}
			MethodDebugInformationHandle handle2 = ((MethodDefinitionHandle)handle).ToDebugInformationHandle();
			MethodDebugInformation methodDebugInformation = metadataReader.GetMethodDebugInformation(handle2);
			if (methodDebugInformation.SequencePointsBlob.IsNil)
			{
				return;
			}
			SequencePointCollection sequencePoints = methodDebugInformation.GetSequencePoints();
			SequencePoint? sequencePoint = null;
			foreach (SequencePoint item in sequencePoints)
			{
				if (item.Offset <= ilOffset)
				{
					if (item.StartLine != 16707566)
					{
						sequencePoint = item;
					}
					continue;
				}
				break;
			}
			if (sequencePoint.HasValue)
			{
				sourceLine = sequencePoint.Value.StartLine;
				sourceColumn = sequencePoint.Value.StartColumn;
				sourceFile = metadataReader.GetString(metadataReader.GetDocument(sequencePoint.Value.Document).Name);
			}
		}
		catch (BadImageFormatException)
		{
		}
		catch (IOException)
		{
		}
	}

	[SecuritySafeCritical]
	[FileIOPermission(SecurityAction.Assert, AllFiles = (FileIOPermissionAccess.Read | FileIOPermissionAccess.PathDiscovery))]
	private MetadataReader TryGetReader(string assemblyPath, IntPtr loadedPeAddress, int loadedPeSize, IntPtr inMemoryPdbAddress, int inMemoryPdbSize)
	{
		if ((loadedPeAddress == IntPtr.Zero || assemblyPath == null) && inMemoryPdbAddress == IntPtr.Zero)
		{
			return null;
		}
		IntPtr key = ((inMemoryPdbAddress != IntPtr.Zero) ? inMemoryPdbAddress : loadedPeAddress);
		int num = 0;
		MetadataReaderProvider value;
		while (!_metadataCache.TryGetValue(key, out value))
		{
			num++;
			value = ((inMemoryPdbAddress != IntPtr.Zero) ? TryOpenReaderForInMemoryPdb(inMemoryPdbAddress, inMemoryPdbSize) : TryOpenReaderFromAssemblyFile(assemblyPath, loadedPeAddress, loadedPeSize));
			if (_metadataCache.TryAdd(key, value))
			{
				break;
			}
			value?.Dispose();
		}
		return value?.GetMetadataReader();
	}

	[SecuritySafeCritical]
	private unsafe static MetadataReaderProvider TryOpenReaderForInMemoryPdb(IntPtr inMemoryPdbAddress, int inMemoryPdbSize)
	{
		if (inMemoryPdbSize < 4 || *(uint*)(void*)inMemoryPdbAddress != 1112167234)
		{
			return null;
		}
		MetadataReaderProvider metadataReaderProvider = MetadataReaderProvider.FromMetadataImage((byte*)(void*)inMemoryPdbAddress, inMemoryPdbSize);
		try
		{
			metadataReaderProvider.GetMetadataReader();
			return metadataReaderProvider;
		}
		catch (BadImageFormatException)
		{
			metadataReaderProvider.Dispose();
			return null;
		}
	}

	[SecuritySafeCritical]
	private static PEReader TryGetPEReader(string assemblyPath, IntPtr loadedPeAddress, int loadedPeSize)
	{
		Stream stream = TryOpenFile(assemblyPath);
		if (stream != null)
		{
			return new PEReader(stream);
		}
		return null;
	}

	private static MetadataReaderProvider TryOpenReaderFromAssemblyFile(string assemblyPath, IntPtr loadedPeAddress, int loadedPeSize)
	{
		using (PEReader pEReader = TryGetPEReader(assemblyPath, loadedPeAddress, loadedPeSize))
		{
			if (pEReader == null)
			{
				return null;
			}
			if (pEReader.TryOpenAssociatedPortablePdb(assemblyPath, TryOpenFile, out var pdbReaderProvider, out var _))
			{
				return pdbReaderProvider;
			}
		}
		return null;
	}

	private static Stream TryOpenFile(string path)
	{
		if (!File.Exists(path))
		{
			return null;
		}
		try
		{
			return File.OpenRead(path);
		}
		catch
		{
			return null;
		}
	}
}
