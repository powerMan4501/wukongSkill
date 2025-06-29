using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
internal class PartInfoTextBlock
{
	public int PartID;

	public string PartName;

	public UTextBlock PartIDTextBlock;

	public UTextBlock PartStageTextBlock;

	public UTextBlock PartNameTextBlock;

	public UTextBlock PartStateTextBlock;

	public UTextBlock PartDmgValueTextBlock;

	public PartInfoTextBlock(int _PartID, string _PartName, UTextBlock _PartIDTextBlock, UTextBlock _PartStageTextBlock, UTextBlock _PartNameTextBlock, UTextBlock _PartStateTextBlock, UTextBlock _PartDmgValueTextBlock)
	{
		PartID = _PartID;
		PartName = _PartName;
		PartIDTextBlock = _PartIDTextBlock;
		PartStageTextBlock = _PartStageTextBlock;
		PartNameTextBlock = _PartNameTextBlock;
		PartStateTextBlock = _PartStateTextBlock;
		PartDmgValueTextBlock = _PartDmgValueTextBlock;
	}
}
