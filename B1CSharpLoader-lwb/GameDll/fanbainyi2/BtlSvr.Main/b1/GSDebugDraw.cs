using System;
using System.Collections.Generic;
using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSDebugDraw")]
public class GSDebugDraw : BUI_Widget
{
	private class DebugBindData
	{
		private readonly GSDebugDraw DebugDraw;

		private readonly GSDebugDrawBase BindWidget;

		private readonly int ReqId;

		private DebugDataBase BindData;

		public DebugBindData(GSDebugDraw InDebugDraw, GSDebugDrawBase InBindWidget, DebugDataBase InBindData, int InReqId)
		{
			DebugDraw = InDebugDraw;
			BindWidget = InBindWidget;
			BindData = InBindData;
			ReqId = InReqId;
			BindWidget.InitData(ReqId, BindData);
			GSDebugDrawBase bindWidget = BindWidget;
			bindWidget.Evt_OnUIDestruct = (Action)Delegate.Combine(bindWidget.Evt_OnUIDestruct, new Action(OnDebugUIDestroy));
		}

		public void ReInitData(DebugDataBase InBindData)
		{
			BindData = InBindData;
			BindWidget.InitData(ReqId, BindData);
		}

		private void OnDebugUIDestroy()
		{
			GSDebugDrawBase bindWidget = BindWidget;
			bindWidget.Evt_OnUIDestruct = (Action)Delegate.Remove(bindWidget.Evt_OnUIDestruct, new Action(OnDebugUIDestroy));
			DebugDraw.DebugDrawWidgetDic.Remove(ReqId);
		}

		public void Stop()
		{
			BindWidget.Stop();
		}
	}

	private int _ReqId = 1;

	private Dictionary<EDebugDrawType, GSDebugDrawBase> DebugDrawWidgetRefDic = new Dictionary<EDebugDrawType, GSDebugDrawBase>();

	private Dictionary<int, DebugBindData> DebugDrawWidgetDic = new Dictionary<int, DebugBindData>();

	private static bool DrawScreenPoint_IsValid;

	private static int DrawScreenPoint_Offset;

	private static FFieldAddress DrawScreenPoint_PropertyAddress;

	private TArrayReadWriteMarshaler<DebugDrawPoint> DrawScreenPoint_Marshaler;

	private static bool DrawViewPortPoint_IsValid;

	private static int DrawViewPortPoint_Offset;

	private static FFieldAddress DrawViewPortPoint_PropertyAddress;

	private TArrayReadWriteMarshaler<DebugDrawPoint> DrawViewPortPoint_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.GSDebugDraw:DrawScreenPoint")]
	public TArrayReadWrite<DebugDrawPoint> DrawScreenPoint
	{
		get
		{
			CheckDestroyed();
			if (!DrawScreenPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDebugDraw:DrawScreenPoint");
				return null;
			}
			if (DrawScreenPoint_Marshaler == null)
			{
				DrawScreenPoint_Marshaler = new TArrayReadWriteMarshaler<DebugDrawPoint>(1, DrawScreenPoint_PropertyAddress, CachedMarshalingDelegates<DebugDrawPoint, DebugDrawPoint>.FromNative, CachedMarshalingDelegates<DebugDrawPoint, DebugDrawPoint>.ToNative);
			}
			return DrawScreenPoint_Marshaler.FromNative(IntPtr.Add(base.Address, DrawScreenPoint_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.GSDebugDraw:DrawViewPortPoint")]
	public TArrayReadWrite<DebugDrawPoint> DrawViewPortPoint
	{
		get
		{
			CheckDestroyed();
			if (!DrawViewPortPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSDebugDraw:DrawViewPortPoint");
				return null;
			}
			if (DrawViewPortPoint_Marshaler == null)
			{
				DrawViewPortPoint_Marshaler = new TArrayReadWriteMarshaler<DebugDrawPoint>(1, DrawViewPortPoint_PropertyAddress, CachedMarshalingDelegates<DebugDrawPoint, DebugDrawPoint>.FromNative, CachedMarshalingDelegates<DebugDrawPoint, DebugDrawPoint>.ToNative);
			}
			return DrawViewPortPoint_Marshaler.FromNative(IntPtr.Add(base.Address, DrawViewPortPoint_Offset));
		}
	}

	private int ReqId => _ReqId++;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InitDrawDebugPointLogic();
		InitDrawDebugDataLogic();
	}

	protected override void OnUIDestruct()
	{
		DestroyDrawDebugPointLogic();
		DestroyDrawDebugDataLogic();
		base.OnUIDestruct();
	}

	private void InitDrawDebugPointLogic()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_ScreenDebugDraw = (BGW_UIEventCollection.Del_UI_ScreenDebugDraw)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ScreenDebugDraw, new BGW_UIEventCollection.Del_UI_ScreenDebugDraw(AddDrawViewPortPoint));
			bGW_UIEventCollection.Evt_UI_ViewPortDebugDraw = (BGW_UIEventCollection.Del_UI_ScreenDebugDraw)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ViewPortDebugDraw, new BGW_UIEventCollection.Del_UI_ScreenDebugDraw(AddDrawScreenPoint));
			bGW_UIEventCollection.Evt_UI_RemoveDrawPointWithName = (BGW_UIEventCollection.Del_UI_String)Delegate.Combine(bGW_UIEventCollection.Evt_UI_RemoveDrawPointWithName, new BGW_UIEventCollection.Del_UI_String(RemoveDrawPointWithName));
			bGW_UIEventCollection.Evt_UI_ResetScreenDebugDraw = (BGW_UIEventCollection.Del_UI_Void)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ResetScreenDebugDraw, new BGW_UIEventCollection.Del_UI_Void(ResetPoint));
		}
	}

	private void DestroyDrawDebugPointLogic()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_ScreenDebugDraw = (BGW_UIEventCollection.Del_UI_ScreenDebugDraw)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ScreenDebugDraw, new BGW_UIEventCollection.Del_UI_ScreenDebugDraw(AddDrawViewPortPoint));
			bGW_UIEventCollection.Evt_UI_ViewPortDebugDraw = (BGW_UIEventCollection.Del_UI_ScreenDebugDraw)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ViewPortDebugDraw, new BGW_UIEventCollection.Del_UI_ScreenDebugDraw(AddDrawScreenPoint));
			bGW_UIEventCollection.Evt_UI_RemoveDrawPointWithName = (BGW_UIEventCollection.Del_UI_String)Delegate.Remove(bGW_UIEventCollection.Evt_UI_RemoveDrawPointWithName, new BGW_UIEventCollection.Del_UI_String(RemoveDrawPointWithName));
			bGW_UIEventCollection.Evt_UI_ResetScreenDebugDraw = (BGW_UIEventCollection.Del_UI_Void)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ResetScreenDebugDraw, new BGW_UIEventCollection.Del_UI_Void(ResetPoint));
		}
	}

	public void ResetPoint()
	{
		DrawScreenPoint.Clear();
		DrawViewPortPoint.Clear();
	}

	public void AddDrawScreenPoint(FVector2D Point, FLinearColor Color, float Size, string InName = "")
	{
		DrawScreenPoint.Add(new DebugDrawPoint(Point, Color, Size, InName));
	}

	public void AddDrawViewPortPoint(FVector2D Point, FLinearColor Color, float Size, string InName = "")
	{
		DrawViewPortPoint.Add(new DebugDrawPoint(Point, Color, Size, InName));
	}

	public void RemoveDrawPointWithName(string Name)
	{
		for (int num = DrawScreenPoint.Count - 1; num >= 0; num--)
		{
			if (DrawScreenPoint[num].Name == Name)
			{
				DrawScreenPoint.RemoveAt(num);
			}
		}
		for (int num2 = DrawViewPortPoint.Count - 1; num2 >= 0; num2--)
		{
			if (DrawViewPortPoint[num2].Name == Name)
			{
				DrawViewPortPoint.RemoveAt(num2);
			}
		}
	}

	private void InitDrawDebugDataLogic()
	{
		for (int i = 0; i < 3; i++)
		{
			GSDebugDrawBase gSDebugDrawBase = FindChildWidget($"BI_{(EDebugDrawType)i}") as GSDebugDrawBase;
			if (!(gSDebugDrawBase == null))
			{
				gSDebugDrawBase.SetVisibility(ESlateVisibility.Collapsed);
				DebugDrawWidgetRefDic.Add((EDebugDrawType)i, gSDebugDrawBase);
			}
		}
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_DrawDebugData = (BGW_UIEventCollection.Del_UI_DrawDebugData)Delegate.Combine(bGW_UIEventCollection.Evt_UI_DrawDebugData, new BGW_UIEventCollection.Del_UI_DrawDebugData(OnDrawDebugData));
			bGW_UIEventCollection.Evt_UI_ResetDebugData = (BGW_UIEventCollection.Del_UI_ResetDebugData)Delegate.Combine(bGW_UIEventCollection.Evt_UI_ResetDebugData, new BGW_UIEventCollection.Del_UI_ResetDebugData(OnResetDrawDebugData));
			bGW_UIEventCollection.Evt_UI_StopDrawDebugData = (BGW_UIEventCollection.Del_UI_Int)Delegate.Combine(bGW_UIEventCollection.Evt_UI_StopDrawDebugData, new BGW_UIEventCollection.Del_UI_Int(OnStopDrawDebugData));
		}
	}

	private void DestroyDrawDebugDataLogic()
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_DrawDebugData = (BGW_UIEventCollection.Del_UI_DrawDebugData)Delegate.Remove(bGW_UIEventCollection.Evt_UI_DrawDebugData, new BGW_UIEventCollection.Del_UI_DrawDebugData(OnDrawDebugData));
			bGW_UIEventCollection.Evt_UI_ResetDebugData = (BGW_UIEventCollection.Del_UI_ResetDebugData)Delegate.Remove(bGW_UIEventCollection.Evt_UI_ResetDebugData, new BGW_UIEventCollection.Del_UI_ResetDebugData(OnResetDrawDebugData));
			bGW_UIEventCollection.Evt_UI_StopDrawDebugData = (BGW_UIEventCollection.Del_UI_Int)Delegate.Remove(bGW_UIEventCollection.Evt_UI_StopDrawDebugData, new BGW_UIEventCollection.Del_UI_Int(OnStopDrawDebugData));
		}
	}

	private int OnDrawDebugData(DebugDataBase InData)
	{
		int num = -1;
		if (InData != null)
		{
			GSDebugDrawBase gSDebugDrawBase = TryGetWidget(InData.DebugDrawType);
			if (gSDebugDrawBase != null)
			{
				num = ReqId;
				gSDebugDrawBase.Play();
				DebugDrawWidgetDic.Add(num, new DebugBindData(this, gSDebugDrawBase, InData, num));
			}
		}
		return num;
	}

	private void OnResetDrawDebugData(int InReqId, DebugDataBase InData)
	{
		if (DebugDrawWidgetDic.TryGetValue(InReqId, out var value))
		{
			value.ReInitData(InData);
		}
	}

	private void OnStopDrawDebugData(int InReqId)
	{
		if (DebugDrawWidgetDic.TryGetValue(InReqId, out var value))
		{
			value.Stop();
			DebugDrawWidgetDic.Remove(InReqId);
		}
	}

	private GSDebugDrawBase TryGetWidget(EDebugDrawType DrawType)
	{
		GSDebugDrawBase widgetRef = GetWidgetRef(DrawType);
		if (widgetRef != null)
		{
			GSDebugDrawBase gSDebugDrawBase = UGSE_UMGFuncLib.CloneUserWidget(widgetRef, FName.None) as GSDebugDrawBase;
			widgetRef.GetParent().AddChild(gSDebugDrawBase);
			GSUIPanelSlotHelper.WidgetSlotCopy(widgetRef, gSDebugDrawBase);
			return gSDebugDrawBase;
		}
		return null;
	}

	private GSDebugDrawBase GetWidgetRef(EDebugDrawType DrawType)
	{
		if (DebugDrawWidgetRefDic.TryGetValue(DrawType, out var value))
		{
			return value;
		}
		return null;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSDebugDraw");
		NativeReflection.GetPropertyRef(ref DrawScreenPoint_PropertyAddress, unrealStruct, "DrawScreenPoint");
		DrawScreenPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DrawScreenPoint");
		DrawScreenPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DrawScreenPoint", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DrawViewPortPoint_PropertyAddress, unrealStruct, "DrawViewPortPoint");
		DrawViewPortPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DrawViewPortPoint");
		DrawViewPortPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DrawViewPortPoint", Classes.FArrayProperty);
	}

	static GSDebugDraw()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDebugDraw)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDebugDraw));
	}
}
