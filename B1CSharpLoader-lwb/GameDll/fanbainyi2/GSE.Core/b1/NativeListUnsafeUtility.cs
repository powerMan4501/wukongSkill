namespace b1;

public static class NativeListUnsafeUtility
{
	public unsafe static void* GetUnsafePtr<T>(this NativeList<T> nativeList) where T : unmanaged
	{
		return nativeList.m_ListData->buffer;
	}

	public unsafe static void* GetInternalListDataPtrUnchecked<T>(ref NativeList<T> nativeList) where T : unmanaged
	{
		return nativeList.m_ListData;
	}
}
