using b1.Plugins.AsyncLoadingScreen;

namespace b1;

public class TeleportTemlate_NextChapterBase : TeleportTemplateBase
{
	private bool _isLoadingAdaptorPlayFinish;

	public override void OnBegin()
	{
		base.OnBegin();
		ChapterInfoHelper chapterInfoHelper = new ChapterInfoHelper(GameInst, GetTargetLevelId());
		GameInst.RegisterChapterInfo(chapterInfoHelper.GetChapterInfo());
		_isLoadingAdaptorPlayFinish = false;
		BGW_UIEventCollection.Get(GameInst).Evt_UI_PlayLoadingAdaptor(GetTargetLevelId(), B1: true, delegate
		{
			_isLoadingAdaptorPlayFinish = true;
		});
	}

	public override bool TickPreTeleportAction(float Delta)
	{
		return _isLoadingAdaptorPlayFinish;
	}

	public override EGSLoadingScreenType GetLoadingScreenType()
	{
		return EGSLoadingScreenType.Chapter;
	}

	public override void LoadingFadeAwayBegin()
	{
		BGW_UIEventCollection.Get(GameInst).Evt_UI_PlayLoadingAdaptor(GetTargetLevelId(), B1: false, null);
		base.LoadingFadeAwayBegin();
	}
}
