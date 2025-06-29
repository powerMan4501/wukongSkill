using System.Collections.Generic;

namespace b1;

public class BUC_CharacterMaterialData : IBUC_CharacterMaterialData
{
	public Dictionary<EChangeMatUnitAttrType, List<MaterialParameterConfig>> ChangeMaterialByAttrRequest { get; set; } = new Dictionary<EChangeMatUnitAttrType, List<MaterialParameterConfig>>();
}
