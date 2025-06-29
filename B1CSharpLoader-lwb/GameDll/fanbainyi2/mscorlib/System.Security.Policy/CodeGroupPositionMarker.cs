namespace System.Security.Policy;

internal class CodeGroupPositionMarker
{
	internal int elementIndex;

	internal int groupIndex;

	internal SecurityElement element;

	internal CodeGroupPositionMarker(int elementIndex, int groupIndex, SecurityElement element)
	{
		this.elementIndex = elementIndex;
		this.groupIndex = groupIndex;
		this.element = element;
	}
}
