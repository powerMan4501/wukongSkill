namespace b1.Util;

public static class GSE_P4HelperCreator
{
	public delegate IGSE_P4Helper Del_CreateP4HelperInstance();

	public static Del_CreateP4HelperInstance CreateInstance_imp;

	public static IGSE_P4Helper CreateP4HelperInstance()
	{
		if (CreateInstance_imp != null)
		{
			return CreateInstance_imp();
		}
		return null;
	}
}
