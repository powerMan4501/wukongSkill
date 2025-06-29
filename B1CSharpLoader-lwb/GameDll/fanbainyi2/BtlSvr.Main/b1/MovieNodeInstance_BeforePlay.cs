using System;
using b1.EventDelDefine;
using BtlB1;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_BeforePlay")]
public class MovieNodeInstance_BeforePlay : MovieNodeInstance
{
	private MovieCustom_BeforePlay CustomData { get; set; }

	private bool bUseAsyncTransBack { get; set; }

	private int DefeatSlowTimeExtendID { get; set; }

	public override void PostCreate()
	{
		if (!(base.ParentInstance == null))
		{
			DefeatSlowTimeExtendID = 0;
			FUStDefeatSlowTimeConfigDesc slowTimeConfigDescBySeqID = BGW_GameDB.GetSlowTimeConfigDescBySeqID(base.ParentInstance.SequenceId);
			if (slowTimeConfigDescBySeqID != null && slowTimeConfigDescBySeqID.TriggerType == EDefeatUITriggerType.Seq)
			{
				bUseAsyncTransBack = true;
				DefeatSlowTimeExtendID = slowTimeConfigDescBySeqID.ID;
			}
			else if (base.Node.NodeData.Length <= 1)
			{
				bUseAsyncTransBack = false;
			}
			else
			{
				CustomData = new MovieCustom_BeforePlay();
				CustomData.MergeFrom(base.Node.NodeData);
				bUseAsyncTransBack = CustomData.UseAsyncTransback;
			}
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (bUseAsyncTransBack)
		{
			base.ParentInstance.BeginTransBack();
		}
		if (DefeatSlowTimeExtendID <= 0)
		{
			TriggerFirstOutput();
			return;
		}
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		bGS_GSEventCollection.Evt_BeginDefeatSlowTime.Invoke(DefeatSlowTimeExtendID, EDefeatUITriggerType.Seq);
		bGS_GSEventCollection.Evt_EndDefeatSlowTime += new Del_Void_Int(OnEndDefeatSlowTime);
	}

	private void OnEndDefeatSlowTime(int ExtendID)
	{
		if (ExtendID == DefeatSlowTimeExtendID)
		{
			BGS_EventCollectionCS.Get(this).Evt_EndDefeatSlowTime -= new Del_Void_Int(OnEndDefeatSlowTime);
			TriggerFirstOutput();
		}
	}

	public override void Shutdown()
	{
		base.Shutdown();
		BGS_EventCollectionCS.Get(this).Evt_EndDefeatSlowTime -= new Del_Void_Int(OnEndDefeatSlowTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_BeforePlay");
	}

	static MovieNodeInstance_BeforePlay()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_BeforePlay)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_BeforePlay));
	}
}
