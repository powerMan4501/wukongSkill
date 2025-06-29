using System.IO;
using b1.BGW;
using UnrealEngine.Runtime;

namespace b1;

public abstract class PsmSubMachineState : IPsmState
{
	public PsmSubMachine ParentSubMachine { get; set; }

	protected PsmInstance ParentPsmInstance => ParentSubMachine?.ParentPsmInstance;

	protected UObject GetOwner()
	{
		return ParentSubMachine.GetOwner();
	}

	protected UObject ConvertSoftObjPath2Obj(string ObjPath)
	{
		if (!string.IsNullOrEmpty(ObjPath))
		{
			string path = ObjPath + "." + Path.GetFileNameWithoutExtension(ObjPath);
			return BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UObject>(path, ELoadResourceType.SyncLoadAndCache);
		}
		return null;
	}

	protected void NotifySelf(FGameplayTag EventTag)
	{
		ParentSubMachine.OnEvent(EventTag);
	}

	protected bool GetSubMachine<T>(out T OutSubMachine) where T : class
	{
		OutSubMachine = ParentSubMachine as T;
		return OutSubMachine != null;
	}

	public virtual void PostCreate(byte[] CustomDataBytes)
	{
	}

	public virtual void OnEnterAction()
	{
	}

	public virtual void OnExitAction()
	{
	}

	public virtual void OnTickAction(float InDeltaTime)
	{
	}

	public virtual void OnResetAction()
	{
		OnEnterAction();
	}

	public virtual void OnRecoverAction()
	{
		OnEnterAction();
	}

	public virtual void Shutdown()
	{
	}
}
