using System;
using System.Collections.Generic;
using System.Linq;
using b1.GSMUICore.Event;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll")]
public class BUI_EndCreditsScroll : BUI_Widget
{
	private UCanvasPanel AnimWidgetConWidget;

	private UCanvasPanel ScrollWidgetConWidget;

	private PageData AllData;

	private EndCreditsPageData CurPageData;

	private List<EndCreditsPageData> RemainderDataList = new List<EndCreditsPageData>();

	private bool IsStartScroll;

	private bool IsAnimPlaying;

	private Queue<TStrongObjectPtr<BUI_EndCreditsPage>> CacheAnimPages = new Queue<TStrongObjectPtr<BUI_EndCreditsPage>>();

	private Queue<TStrongObjectPtr<BUI_EndCreditsPage>> CacheScrollPages = new Queue<TStrongObjectPtr<BUI_EndCreditsPage>>();

	private BUI_EndCreditsPage CurAnimWidget;

	private List<BUI_EndCreditsPage> CurScrollWidgets = new List<BUI_EndCreditsPage>();

	private GSMUIDelayExec AnimPageFinishEvent;

	private static bool CacheCount_IsValid;

	private static int CacheCount_Offset;

	private static bool CacheScrollSize_IsValid;

	private static int CacheScrollSize_Offset;

	private static bool CurPageIdx_IsValid;

	private static int CurPageIdx_Offset;

	private static bool ScrollOffset_IsValid;

	private static int ScrollOffset_Offset;

	private static bool ScrollSpeed_IsValid;

	private static int ScrollSpeed_Offset;

	private static bool IsPlaying_IsValid;

	private static int IsPlaying_Offset;

	private static FFieldAddress IsPlaying_PropertyAddress;

	private static bool IsEnding_IsValid;

	private static int IsEnding_Offset;

	private static FFieldAddress IsEnding_PropertyAddress;

	[DisplayName("预载数量")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:CacheCount")]
	public int CacheCount
	{
		get
		{
			CheckDestroyed();
			if (!CacheCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:CacheCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CacheCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:CacheCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CacheCount_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("预载区域大小")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:CacheScrollSize")]
	public int CacheScrollSize
	{
		get
		{
			CheckDestroyed();
			if (!CacheScrollSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:CacheScrollSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CacheScrollSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CacheScrollSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:CacheScrollSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CacheScrollSize_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("当前PageIdx")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:CurPageIdx")]
	public int CurPageIdx
	{
		get
		{
			CheckDestroyed();
			if (!CurPageIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:CurPageIdx");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CurPageIdx_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurPageIdx_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:CurPageIdx");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CurPageIdx_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("滚动区域")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:ScrollOffset")]
	public float ScrollOffset
	{
		get
		{
			CheckDestroyed();
			if (!ScrollOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:ScrollOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScrollOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:ScrollOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScrollOffset_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[DisplayName("滚动速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:ScrollSpeed")]
	public float ScrollSpeed
	{
		get
		{
			CheckDestroyed();
			if (!ScrollSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:ScrollSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ScrollSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScrollSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:ScrollSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ScrollSpeed_Offset), value);
			}
		}
	}

	[DisplayName("是否正在播放中")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:IsPlaying")]
	public bool IsPlaying
	{
		get
		{
			CheckDestroyed();
			if (!IsPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:IsPlaying");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsPlaying_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:IsPlaying");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsPlaying_Offset), 0, IsPlaying_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否在结束动画中")]
	[Category("GSProperty")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_EndCreditsScroll:IsEnding")]
	public bool IsEnding
	{
		get
		{
			CheckDestroyed();
			if (!IsEnding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:IsEnding");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEnding_Offset), 0, IsEnding_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEnding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_EndCreditsScroll:IsEnding");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEnding_Offset), 0, IsEnding_PropertyAddress.Address, value);
			}
		}
	}

	public event Action OnAnimFinised;

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
		CacheCount = 5;
		CacheScrollSize = 2160;
		ScrollSpeed = 100f;
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InitWidget();
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		UpdateCachePage();
		UpdatePageAction();
		UpdateScroll(InDeltaTime);
	}

	protected override void OnUIDestruct()
	{
		DestroyCache();
		base.OnUIDestruct();
	}

	private void InitWidget()
	{
		AnimWidgetConWidget = FindChildWidget("AnimWidgetCon") as UCanvasPanel;
		ScrollWidgetConWidget = FindChildWidget("ScrollWidgetCon") as UCanvasPanel;
	}

	public void InitData(PageData InData, int InPageIdx)
	{
		if (InData != null)
		{
			AllData = InData;
			SetCurPageIdx(InPageIdx);
			RemainderDataList.Clear();
			for (int i = CurPageIdx; i < AllData.PageList.Count; i++)
			{
				RemainderDataList.Add(AllData.PageList[i]);
			}
		}
	}

	private void DestroyCache()
	{
		while (CacheAnimPages.Count > 0)
		{
			BUI_EndCreditsPage bUI_EndCreditsPage = CacheAnimPages.Dequeue().Get();
			if (!bUI_EndCreditsPage.IsNullOrDestroyed())
			{
				bUI_EndCreditsPage.DestroyUI();
			}
		}
		CacheAnimPages.Clear();
		if (!CurAnimWidget.IsNullOrDestroyed())
		{
			CurAnimWidget.DestroyUI();
			CurAnimWidget = null;
		}
		while (CacheScrollPages.Count > 0)
		{
			BUI_EndCreditsPage bUI_EndCreditsPage2 = CacheScrollPages.Dequeue().Get();
			if (!bUI_EndCreditsPage2.IsNullOrDestroyed())
			{
				bUI_EndCreditsPage2.DestroyUI();
			}
		}
		CacheScrollPages.Clear();
		if (CurScrollWidgets == null)
		{
			return;
		}
		for (int num = CurScrollWidgets.Count - 1; num >= 0; num--)
		{
			BUI_EndCreditsPage bUI_EndCreditsPage3 = CurScrollWidgets[num];
			if (!bUI_EndCreditsPage3.IsNullOrDestroyed())
			{
				bUI_EndCreditsPage3.DestroyUI();
			}
		}
		CurScrollWidgets.Clear();
	}

	private void UpdateCachePage()
	{
		UpdateAnimPage();
		UpdateScrollPage();
		if (RemainderDataList != null && RemainderDataList.Count > 0)
		{
			UpdateCacheAnimPage();
			UpdateCacheScrollPage();
		}
	}

	private void UpdateAnimPage()
	{
		if (CurAnimWidget == null && CacheAnimPages.Count > 0)
		{
			TStrongObjectPtr<BUI_EndCreditsPage> tStrongObjectPtr = CacheAnimPages.Dequeue();
			if (tStrongObjectPtr != null)
			{
				CurAnimWidget = tStrongObjectPtr.Get();
			}
		}
	}

	private void UpdateScrollPage()
	{
		float num = 0f;
		foreach (BUI_EndCreditsPage curScrollWidget in CurScrollWidgets)
		{
			num += GetWidgetHeight(curScrollWidget);
		}
		while (num < (float)CacheScrollSize && CacheScrollPages.Count > 0)
		{
			BUI_EndCreditsPage bUI_EndCreditsPage = CacheScrollPages.Peek().Get();
			if (bUI_EndCreditsPage != null)
			{
				EndCreditsPageData endCreditsPageData = bUI_EndCreditsPage.GetData() as EndCreditsPageData;
				if (CurScrollWidgets.Count > 0 && endCreditsPageData.PageAction == EEndCreditsPageAction.AnimAndScroll)
				{
					break;
				}
			}
			TStrongObjectPtr<BUI_EndCreditsPage> tStrongObjectPtr = CacheScrollPages.Dequeue();
			BUI_EndCreditsPage bUI_EndCreditsPage2 = tStrongObjectPtr.Get();
			num += GetWidgetHeight(bUI_EndCreditsPage2);
			CurScrollWidgets.Add(bUI_EndCreditsPage2);
			tStrongObjectPtr.Delete();
		}
	}

	private void UpdateCacheAnimPage()
	{
		if (RemainderDataList == null || RemainderDataList.Count <= 0)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		while (RemainderDataList.Count > num2 && CacheAnimPages.Count < num)
		{
			EndCreditsPageData endCreditsPageData = RemainderDataList[num2];
			if (endCreditsPageData.PageAction == EEndCreditsPageAction.Anim)
			{
				if (num > 2)
				{
					break;
				}
				BUI_EndCreditsPage bUI_EndCreditsPage = CreatePage(endCreditsPageData);
				if (bUI_EndCreditsPage != null)
				{
					CacheAnimPages.Enqueue(new TStrongObjectPtr<BUI_EndCreditsPage>(bUI_EndCreditsPage));
				}
				RemainderDataList.RemoveAt(num2);
			}
			else
			{
				num2++;
			}
		}
	}

	private void UpdateCacheScrollPage()
	{
		if (RemainderDataList == null || RemainderDataList.Count <= 0)
		{
			return;
		}
		float num = 0f;
		foreach (TStrongObjectPtr<BUI_EndCreditsPage> cacheScrollPage in CacheScrollPages)
		{
			num += GetWidgetHeight(cacheScrollPage.Get());
		}
		int num2 = 0;
		int num3 = 0;
		while (RemainderDataList.Count > num3 && num < (float)CacheScrollSize)
		{
			EndCreditsPageData endCreditsPageData = RemainderDataList[num3];
			if (endCreditsPageData.PageAction == EEndCreditsPageAction.AnimAndScroll || endCreditsPageData.PageAction == EEndCreditsPageAction.Scroll || endCreditsPageData.PageAction == EEndCreditsPageAction.ScrollAnimEnd || endCreditsPageData.PageAction == EEndCreditsPageAction.SwitchSpeedScroll)
			{
				num2++;
				if (num2 > 2)
				{
					break;
				}
				BUI_EndCreditsPage bUI_EndCreditsPage = CreatePage(endCreditsPageData);
				if (bUI_EndCreditsPage != null)
				{
					num += GetWidgetHeight(bUI_EndCreditsPage);
					CacheScrollPages.Enqueue(new TStrongObjectPtr<BUI_EndCreditsPage>(bUI_EndCreditsPage));
				}
				RemainderDataList.RemoveAt(num3);
			}
			else
			{
				num3++;
			}
		}
	}

	private BUI_EndCreditsPage CreatePage(EndCreditsPageData Data)
	{
		if (string.IsNullOrEmpty(Data.PagePath))
		{
			return null;
		}
		BUI_EndCreditsPage bUI_EndCreditsPage = UGSE_UMGFuncLib.CreateUserWidget(this, Data.PagePath) as BUI_EndCreditsPage;
		if (bUI_EndCreditsPage == null)
		{
			return null;
		}
		bUI_EndCreditsPage.ApplyData(Data);
		UCanvasPanelSlot uCanvasPanelSlot = ((Data.PageAction == EEndCreditsPageAction.Anim) ? AnimWidgetConWidget : ScrollWidgetConWidget).AddChild(bUI_EndCreditsPage) as UCanvasPanelSlot;
		uCanvasPanelSlot.SetAutoSize(InbAutoSize: true);
		GSUIPanelSlotHelper.SetSlotToFullScreen(uCanvasPanelSlot);
		switch (Data.PageAction)
		{
		case EEndCreditsPageAction.Anim:
			uCanvasPanelSlot.SetAlignment(new FVector2D(0.5, 0.5));
			uCanvasPanelSlot.SetAnchors(new FAnchors
			{
				Minimum = new FVector2D(0.5, 0.5),
				Maximum = new FVector2D(0.5, 0.5)
			});
			break;
		case EEndCreditsPageAction.AnimAndScroll:
		case EEndCreditsPageAction.Scroll:
		case EEndCreditsPageAction.SwitchSpeedScroll:
		case EEndCreditsPageAction.ScrollAnimEnd:
			uCanvasPanelSlot.SetAlignment(new FVector2D(0.5, 0.0));
			uCanvasPanelSlot.SetAnchors(new FAnchors
			{
				Minimum = new FVector2D(0.5, 0.0),
				Maximum = new FVector2D(0.5, 0.0)
			});
			break;
		}
		bUI_EndCreditsPage.ForceLayoutPrepass();
		bUI_EndCreditsPage.SetVisibility(ESlateVisibility.Collapsed);
		return bUI_EndCreditsPage;
	}

	private float GetWidgetHeight(UWidget Widget)
	{
		if (Widget.IsNullOrDestroyed())
		{
			return 0f;
		}
		return Widget.GetDesiredSize().Y;
	}

	private void UpdatePageAction()
	{
		if (CurPageData == null)
		{
			return;
		}
		switch (CurPageData.PageAction)
		{
		case EEndCreditsPageAction.Anim:
			if (CurAnimWidget != null)
			{
				IsStartScroll = false;
				CurAnimWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			if (IsPlaying && !IsAnimPlaying && CurAnimWidget != null)
			{
				IsAnimPlaying = true;
				float inDelay2 = CurAnimWidget.PlayWidgetAnimationByInfoName("AnimShowStart");
				if (AnimPageFinishEvent != null)
				{
					ClearGSMUIEvent(AnimPageFinishEvent);
				}
				AnimPageFinishEvent = new GSMUIDelayExec(inDelay2, delegate
				{
					IsAnimPlaying = false;
					OnNext();
					CurAnimWidget.DestroyUI();
					CurAnimWidget = null;
					AnimPageFinishEvent = null;
				});
				AppendGSMUIEvent(AnimPageFinishEvent);
			}
			break;
		case EEndCreditsPageAction.AnimAndScroll:
			if (IsAnimPlaying)
			{
				break;
			}
			if (IsPlaying && !IsStartScroll)
			{
				BUI_EndCreditsPage bUI_EndCreditsPage = CurScrollWidgets.First();
				if (bUI_EndCreditsPage != null)
				{
					IsAnimPlaying = true;
					IsStartScroll = false;
					bUI_EndCreditsPage.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
					float inDelay = bUI_EndCreditsPage.PlayWidgetAnimationByInfoName("AnimShowStart");
					if (AnimPageFinishEvent != null)
					{
						ClearGSMUIEvent(AnimPageFinishEvent);
					}
					AnimPageFinishEvent = new GSMUIDelayExec(inDelay, delegate
					{
						IsAnimPlaying = false;
						IsStartScroll = true;
						UpdateScroll(0f);
					});
					AppendGSMUIEvent(AnimPageFinishEvent);
				}
				else
				{
					BGW_LogUtil.LogError("[BUI_EndCreditsScroll] UpdatePageAction load fail, Name = " + CurPageData.PageName + ", Path = " + CurPageData.PagePath);
				}
			}
			else
			{
				IsAnimPlaying = false;
				IsStartScroll = true;
			}
			SetScrollSpeed((float)CurPageData.ScrollSpeed);
			break;
		case EEndCreditsPageAction.SwitchSpeedScroll:
			IsAnimPlaying = false;
			IsStartScroll = true;
			SetScrollSpeed((float)CurPageData.ScrollSpeed);
			break;
		case EEndCreditsPageAction.Scroll:
		case EEndCreditsPageAction.ScrollAnimEnd:
			IsAnimPlaying = false;
			IsStartScroll = true;
			break;
		}
	}

	private void UpdateScroll(float InDeltaTime)
	{
		if (!IsStartScroll || IsEnding)
		{
			return;
		}
		if (IsPlaying)
		{
			ScrollOffset += ScrollSpeed * InDeltaTime;
			while (CurScrollWidgets.Count > 0)
			{
				BUI_EndCreditsPage bUI_EndCreditsPage = CurScrollWidgets.First();
				if (bUI_EndCreditsPage != null)
				{
					FVector2D desiredSize = bUI_EndCreditsPage.GetDesiredSize();
					if (desiredSize.IsZero() || !(desiredSize.Y <= ScrollOffset))
					{
						break;
					}
					bUI_EndCreditsPage.DestroyUI();
					CurScrollWidgets.RemoveAt(0);
					ScrollOffset -= desiredSize.Y;
					if (CurScrollWidgets.Count <= 0)
					{
						IsStartScroll = false;
					}
					OnNext();
				}
			}
		}
		EndCreditsPageData endCreditsPageData = null;
		float num = 0f - ScrollOffset;
		foreach (BUI_EndCreditsPage curScrollWidget in CurScrollWidgets)
		{
			if (!(curScrollWidget != null))
			{
				continue;
			}
			if (num > (float)CacheScrollSize)
			{
				curScrollWidget.SetVisibility(ESlateVisibility.Collapsed);
			}
			else
			{
				FVector2D desiredSize2 = curScrollWidget.GetDesiredSize();
				UCanvasPanelSlot uCanvasPanelSlot = curScrollWidget.Slot as UCanvasPanelSlot;
				if (uCanvasPanelSlot != null)
				{
					uCanvasPanelSlot.SetPosition(new FVector2D(0.0, num));
					num += desiredSize2.Y;
				}
				curScrollWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			endCreditsPageData = curScrollWidget.GetData() as EndCreditsPageData;
		}
		if (endCreditsPageData == null || endCreditsPageData.PageAction != EEndCreditsPageAction.ScrollAnimEnd || !((double)num <= endCreditsPageData.ScrollEndOffset))
		{
			return;
		}
		IsPlaying = false;
		IsEnding = true;
		float num2 = 0f;
		foreach (BUI_EndCreditsPage curScrollWidget2 in CurScrollWidgets)
		{
			if (!curScrollWidget2.IsNullOrDestroyed())
			{
				float num3 = curScrollWidget2.PlayWidgetAnimationByInfoName("AnimHide");
				if (num3 > num2)
				{
					num2 = num3;
				}
			}
		}
		AppendGSMUIEvent(new GSMUIDelayExec(num2, delegate
		{
			while (CurScrollWidgets.Count > 0)
			{
				BUI_EndCreditsPage bUI_EndCreditsPage2 = CurScrollWidgets.First();
				if (!bUI_EndCreditsPage2.IsNullOrDestroyed())
				{
					bUI_EndCreditsPage2.DestroyUI();
				}
				CurScrollWidgets.RemoveAt(0);
				OnNext();
			}
		}));
	}

	public void OnNext()
	{
		if (AllData != null)
		{
			if (CurPageIdx + 1 < AllData.PageList.Count)
			{
				CurPageIdx++;
				CurPageData = AllData.PageList[CurPageIdx];
				return;
			}
			CurPageIdx = -1;
			CurPageData = null;
			IsEnding = false;
			SetIsPlaying(InIsPlaying: false);
			this.OnAnimFinised?.Invoke();
		}
	}

	public void ResetData()
	{
		if (AnimPageFinishEvent != null)
		{
			ClearGSMUIEvent(AnimPageFinishEvent);
		}
		DestroyCache();
		IsStartScroll = false;
		IsAnimPlaying = false;
		IsEnding = false;
	}

	public void SetCurPageIdx(int InCurPageIdx)
	{
		ResetData();
		CurPageIdx = InCurPageIdx;
		if (AllData != null && AllData.PageList != null && InCurPageIdx >= 0 && InCurPageIdx < AllData.PageList.Count)
		{
			CurPageData = AllData.PageList[InCurPageIdx];
		}
		else
		{
			CurPageData = null;
		}
	}

	public bool IsPageDataEmpty()
	{
		return CurPageData == null;
	}

	public void SetScrollOffset(float InScrollOffset)
	{
		ScrollOffset = InScrollOffset;
	}

	public void SetScrollSpeed(float InScrollSpeed)
	{
		ScrollSpeed = InScrollSpeed;
	}

	public void SetIsPlaying(bool InIsPlaying)
	{
		IsPlaying = InIsPlaying;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_EndCreditsScroll");
		CacheCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CacheCount");
		CacheCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CacheCount", Classes.FIntProperty);
		CacheScrollSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CacheScrollSize");
		CacheScrollSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CacheScrollSize", Classes.FIntProperty);
		CurPageIdx_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurPageIdx");
		CurPageIdx_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurPageIdx", Classes.FIntProperty);
		ScrollOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollOffset");
		ScrollOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollOffset", Classes.FFloatProperty);
		ScrollSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ScrollSpeed");
		ScrollSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ScrollSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsPlaying_PropertyAddress, unrealStruct, "IsPlaying");
		IsPlaying_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsPlaying");
		IsPlaying_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsPlaying", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsEnding_PropertyAddress, unrealStruct, "IsEnding");
		IsEnding_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsEnding");
		IsEnding_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsEnding", Classes.FBoolProperty);
	}

	static BUI_EndCreditsScroll()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_EndCreditsScroll)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_EndCreditsScroll));
	}
}
