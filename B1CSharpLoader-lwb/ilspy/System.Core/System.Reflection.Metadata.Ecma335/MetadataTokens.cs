namespace System.Reflection.Metadata.Ecma335;

internal static class MetadataTokens
{
	public static readonly int TableCount = 64;

	public static int GetHeapOffset(Handle handle)
	{
		if (!handle.IsHeapHandle)
		{
			Throw.HeapHandleRequired();
		}
		if (handle.IsVirtual)
		{
			return -1;
		}
		return handle.Offset;
	}

	public static int GetToken(Handle handle)
	{
		if (!handle.IsEntityOrUserStringHandle)
		{
			Throw.EntityOrUserStringHandleRequired();
		}
		if (handle.IsVirtual)
		{
			return 0;
		}
		return handle.Token;
	}

	public static bool TryGetTableIndex(HandleKind type, out TableIndex index)
	{
		if ((int)type < TableCount && ((1L << (int)type) & 0xFF1FC9FFFFFFFFL) != 0L)
		{
			index = (TableIndex)type;
			return true;
		}
		index = TableIndex.Module;
		return false;
	}

	public static Handle Handle(int token)
	{
		if (!TokenTypeIds.IsEntityOrUserStringToken((uint)token))
		{
			Throw.InvalidToken();
		}
		return System.Reflection.Metadata.Handle.FromVToken((uint)token);
	}

	private static int ToRowId(int rowNumber)
	{
		return rowNumber & 0xFFFFFF;
	}

	public static MethodDefinitionHandle MethodDefinitionHandle(int rowNumber)
	{
		return System.Reflection.Metadata.MethodDefinitionHandle.FromRowId(ToRowId(rowNumber));
	}

	public static MethodDebugInformationHandle MethodDebugInformationHandle(int rowNumber)
	{
		return System.Reflection.Metadata.MethodDebugInformationHandle.FromRowId(ToRowId(rowNumber));
	}
}
