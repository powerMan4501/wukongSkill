namespace b1.UI.GSPage;

internal interface IWidgetPoolManager
{
	void CreatePool(int PoolKey, int PoolSize, string PoolName);

	IPoolWidget ReuseWidget(int PoolKey);

	void ReuseAllPool();
}
