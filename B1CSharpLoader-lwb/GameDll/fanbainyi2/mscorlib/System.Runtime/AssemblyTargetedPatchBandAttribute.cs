namespace System.Runtime;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
public sealed class AssemblyTargetedPatchBandAttribute : Attribute
{
	private string m_targetedPatchBand;

	public string TargetedPatchBand => m_targetedPatchBand;

	public AssemblyTargetedPatchBandAttribute(string targetedPatchBand)
	{
		m_targetedPatchBand = targetedPatchBand;
	}
}
