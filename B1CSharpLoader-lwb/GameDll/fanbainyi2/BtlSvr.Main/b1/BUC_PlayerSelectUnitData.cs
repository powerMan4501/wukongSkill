using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_PlayerSelectUnitData
{
	private TStrongObjectPtr<UClass> mSelectedUnitActorClass = new TStrongObjectPtr<UClass>();

	private TStrongObjectPtr<AActor> mSelectedUnitActorInst = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mCurTarget = new TStrongObjectPtr<AActor>();

	private TStrongObjectPtr<AActor> mOwner = new TStrongObjectPtr<AActor>();

	public UClass SelectedUnitActorClass
	{
		get
		{
			return mSelectedUnitActorClass.Get();
		}
		set
		{
			mSelectedUnitActorClass.Set(value);
		}
	}

	public AActor SelectedUnitActorInst
	{
		get
		{
			return mSelectedUnitActorInst.Get();
		}
		set
		{
			mSelectedUnitActorInst.Set(value);
		}
	}

	public AActor CurTarget
	{
		get
		{
			return mCurTarget.Get();
		}
		set
		{
			mCurTarget.Set(value);
		}
	}

	public AActor Owner
	{
		get
		{
			return mOwner.Get();
		}
		set
		{
			mOwner.Set(value);
		}
	}
}
