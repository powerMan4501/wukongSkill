namespace b1;

public static class EnumInfo
{
	public static int GetEnumCnValue(string projName, string enumTypeName, string cnName)
	{
		if (projName == "B1" || projName == "X2")
		{
			return B1EnumInfo.GetEnumCnValue(enumTypeName, cnName);
		}
		return -1;
	}
}
