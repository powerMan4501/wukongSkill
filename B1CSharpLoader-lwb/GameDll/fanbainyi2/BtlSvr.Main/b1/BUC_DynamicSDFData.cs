using System.Collections.Generic;
using System.Collections.Specialized;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DynamicSDFData
{
	public TStrongObjectPtr<UNiagaraComponent> NS_Simulator = new TStrongObjectPtr<UNiagaraComponent>();

	public TStrongObjectPtr<UMaterialParameterCollection> GlobalMPC = new TStrongObjectPtr<UMaterialParameterCollection>();

	public TStrongObjectPtr<UNiagaraParameterCollectionInstance> GlobalNPC = new TStrongObjectPtr<UNiagaraParameterCollectionInstance>();

	public TStrongObjectPtr<UTextureRenderTarget2D> RT_DynamicSDF_Base = new TStrongObjectPtr<UTextureRenderTarget2D>();

	public TStrongObjectPtr<UTextureRenderTarget2D> RT_TimeData = new TStrongObjectPtr<UTextureRenderTarget2D>();

	public TStrongObjectPtr<UTextureRenderTarget2D> RT_DynamicSDF_Base_Accumulated = new TStrongObjectPtr<UTextureRenderTarget2D>();

	public string RTTexturesDir;

	public float SimulationSize;

	public float RTSize;

	public float BoneMaxPositionChangeFromPreviousThreshold;

	public int CurrentReceivedDataCount;

	public int MaxDataHandleCount;

	public FVector centerSnappedPos;

	public FVector centerSnappedPos_Previous;

	public FVector centerSnappedOffset;

	public FVector previousCenterSnappedOffset;

	public FVector centerSnappedPos_twoBefore;

	public FVector centerPos;

	public FVector previousCenterPos;

	public FVector centerOffset;

	private Dictionary<int, int> actorID_previous_dict = new Dictionary<int, int>();

	private Dictionary<int, FVector4> data_previous_dict = new Dictionary<int, FVector4>();

	private Dictionary<int, FVector4> data_twoBefore_dict = new Dictionary<int, FVector4>();

	private OrderedDictionary data_toNiagara_pos_dict = new OrderedDictionary();

	private OrderedDictionary data_toNiagara_velocity_dict = new OrderedDictionary();

	private bool havePreviousData;

	public Dictionary<int, FDispInteractInfo> previousData_dict = new Dictionary<int, FDispInteractInfo>();

	public Dictionary<int, FDispInteractInfo> twoBeforeData_dict = new Dictionary<int, FDispInteractInfo>();

	public BUC_DynamicSDFData()
	{
		RTTexturesDir = "/Game/00Main/Design/Tech/DynamicSDF/Textures/";
	}
}
