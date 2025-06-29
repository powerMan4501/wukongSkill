using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b1;

public class FLoadingTipsRoleDataParam
{
	public bool IsConfigureWinePartner;

	public bool IsAllShortcutConfigureItem;

	public int TalentPointNum;

	public long SpiritNum;

	public int EquipQuality;

	public List<int> CompletedTaskList = new List<int>();

	public List<int> PlayerItemList = new List<int>();

	public List<int> TalentList = new List<int>();

	public List<int> FuncIdList = new List<int>();

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"IsConfigureWinePartner: {IsConfigureWinePartner}");
		stringBuilder.AppendLine($"IsAllShortcutConfigureItem: {IsAllShortcutConfigureItem}");
		stringBuilder.AppendLine($"TalentPointNum: {TalentPointNum}");
		stringBuilder.AppendLine($"SpiritNum: {SpiritNum}");
		stringBuilder.AppendLine($"EquipQuality: {EquipQuality}");
		stringBuilder.AppendLine("CompletedTaskList: " + string.Join(", ", CompletedTaskList.OrderBy((int item) => item)));
		stringBuilder.AppendLine("PlayerItemList: " + string.Join(", ", PlayerItemList.OrderBy((int item) => item)));
		stringBuilder.AppendLine("TalentList: " + string.Join(", ", TalentList.OrderBy((int item) => item)));
		stringBuilder.AppendLine("FuncIdList: " + string.Join(", ", FuncIdList.OrderBy((int item) => item)));
		return stringBuilder.ToString();
	}
}
