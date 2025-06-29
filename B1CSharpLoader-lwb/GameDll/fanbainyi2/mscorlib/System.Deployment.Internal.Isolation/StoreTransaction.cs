using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Deployment.Internal.Isolation;

internal class StoreTransaction : IDisposable
{
	private ArrayList _list = new ArrayList();

	private StoreTransactionOperation[] _storeOps;

	public StoreTransactionOperation[] Operations
	{
		get
		{
			if (_storeOps == null)
			{
				_storeOps = GenerateStoreOpsList();
			}
			return _storeOps;
		}
	}

	public void Add(StoreOperationInstallDeployment o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationPinDeployment o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationSetCanonicalizationContext o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationSetDeploymentMetadata o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationStageComponent o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationStageComponentFile o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationUninstallDeployment o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationUnpinDeployment o)
	{
		_list.Add(o);
	}

	public void Add(StoreOperationScavenge o)
	{
		_list.Add(o);
	}

	~StoreTransaction()
	{
		Dispose(fDisposing: false);
	}

	void IDisposable.Dispose()
	{
		Dispose(fDisposing: true);
	}

	[SecuritySafeCritical]
	private void Dispose(bool fDisposing)
	{
		if (fDisposing)
		{
			GC.SuppressFinalize(this);
		}
		StoreTransactionOperation[] storeOps = _storeOps;
		_storeOps = null;
		if (storeOps == null)
		{
			return;
		}
		for (int i = 0; i != storeOps.Length; i++)
		{
			StoreTransactionOperation storeTransactionOperation = storeOps[i];
			if (storeTransactionOperation.Data.DataPtr != IntPtr.Zero)
			{
				switch (storeTransactionOperation.Operation)
				{
				case StoreTransactionOperationType.StageComponent:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationStageComponent));
					break;
				case StoreTransactionOperationType.StageComponentFile:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationStageComponentFile));
					break;
				case StoreTransactionOperationType.PinDeployment:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationPinDeployment));
					break;
				case StoreTransactionOperationType.UninstallDeployment:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationUninstallDeployment));
					break;
				case StoreTransactionOperationType.UnpinDeployment:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationUnpinDeployment));
					break;
				case StoreTransactionOperationType.InstallDeployment:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationInstallDeployment));
					break;
				case StoreTransactionOperationType.SetCanonicalizationContext:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationSetCanonicalizationContext));
					break;
				case StoreTransactionOperationType.SetDeploymentMetadata:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationSetDeploymentMetadata));
					break;
				case StoreTransactionOperationType.Scavenge:
					Marshal.DestroyStructure(storeTransactionOperation.Data.DataPtr, typeof(StoreOperationScavenge));
					break;
				}
				Marshal.FreeCoTaskMem(storeTransactionOperation.Data.DataPtr);
			}
		}
	}

	[SecuritySafeCritical]
	private StoreTransactionOperation[] GenerateStoreOpsList()
	{
		StoreTransactionOperation[] array = new StoreTransactionOperation[_list.Count];
		for (int i = 0; i != _list.Count; i++)
		{
			object obj = _list[i];
			Type type = obj.GetType();
			array[i].Data.DataPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(obj));
			Marshal.StructureToPtr(obj, array[i].Data.DataPtr, fDeleteOld: false);
			if (type == typeof(StoreOperationSetCanonicalizationContext))
			{
				array[i].Operation = StoreTransactionOperationType.SetCanonicalizationContext;
				continue;
			}
			if (type == typeof(StoreOperationStageComponent))
			{
				array[i].Operation = StoreTransactionOperationType.StageComponent;
				continue;
			}
			if (type == typeof(StoreOperationPinDeployment))
			{
				array[i].Operation = StoreTransactionOperationType.PinDeployment;
				continue;
			}
			if (type == typeof(StoreOperationUnpinDeployment))
			{
				array[i].Operation = StoreTransactionOperationType.UnpinDeployment;
				continue;
			}
			if (type == typeof(StoreOperationStageComponentFile))
			{
				array[i].Operation = StoreTransactionOperationType.StageComponentFile;
				continue;
			}
			if (type == typeof(StoreOperationInstallDeployment))
			{
				array[i].Operation = StoreTransactionOperationType.InstallDeployment;
				continue;
			}
			if (type == typeof(StoreOperationUninstallDeployment))
			{
				array[i].Operation = StoreTransactionOperationType.UninstallDeployment;
				continue;
			}
			if (type == typeof(StoreOperationSetDeploymentMetadata))
			{
				array[i].Operation = StoreTransactionOperationType.SetDeploymentMetadata;
				continue;
			}
			if (type == typeof(StoreOperationScavenge))
			{
				array[i].Operation = StoreTransactionOperationType.Scavenge;
				continue;
			}
			throw new Exception("How did you get here?");
		}
		return array;
	}
}
