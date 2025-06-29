namespace UnrealEngine.Runtime;

public class USharpPathAttribute : UUnrealTypePathAttribute
{
	public override bool IsManagedType => true;

	public USharpPathAttribute(string path)
	{
		Path = path;
	}
}
