namespace System.Runtime.InteropServices.TCEAdapterGen;

internal static class NameSpaceExtractor
{
	private static char NameSpaceSeperator = '.';

	public static string ExtractNameSpace(string FullyQualifiedTypeName)
	{
		int num = FullyQualifiedTypeName.LastIndexOf(NameSpaceSeperator);
		if (num == -1)
		{
			return "";
		}
		return FullyQualifiedTypeName.Substring(0, num);
	}
}
