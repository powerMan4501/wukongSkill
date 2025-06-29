namespace b1.Protobuf.DataAPI;

public static class BG_TableToolP4HelperCreator
{
	public delegate IBG_TableToolP4Helper Del_CreateP4HelperInstance();

	public static Del_CreateP4HelperInstance CreateInstance_imp;

	public static IBG_TableToolP4Helper CreateP4HelperInstance()
	{
		if (CreateInstance_imp != null)
		{
			return CreateInstance_imp();
		}
		return null;
	}
}
