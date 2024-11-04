namespace ET.Client
{
	[FriendOf(typeof(WindowCoreData))]
	[FriendOf(typeof(UIBaseWindow))]
	[UIEvent(WindowID.Win_UIGameStart)]
	public  class UIGameStartEventHandler : IUIEventHandler
	{
		public void OnInitWindowCoreData(UIBaseWindow uiBaseWindow)
		{
			uiBaseWindow.WindowData.WindowType = UIWindowType.Normal; 
		}

		public void OnInitComponent(UIBaseWindow uiBaseWindow)
		{
			uiBaseWindow.AddComponent<UIGameStartViewComponent>(); 
			uiBaseWindow.AddComponent<UIGameStart>(); 
		}

		public void OnRegisterUIEvent(UIBaseWindow uiBaseWindow)
		{
			uiBaseWindow.GetComponent<UIGameStart>().RegisterUIEvent(); 
		}

		public void OnReload(UIBaseWindow uiBaseWindow)
		{
			uiBaseWindow.GetComponent<UIGameStart>().ReloadUIEvent(); 
		}

		public void OnFocus(UIBaseWindow uiBaseWindow)
		{
			uiBaseWindow.GetComponent<UIGameStart>().Focus(); 
		}

		public void OnUnFocus(UIBaseWindow uiBaseWindow)
		{
			uiBaseWindow.GetComponent<UIGameStart>().UnFocus(); 
		}

		public void OnShowWindow(UIBaseWindow uiBaseWindow, Entity showData = null)
		{
			uiBaseWindow.GetComponent<UIGameStart>().ShowWindow(showData); 
		}

		public void OnHideWindow(UIBaseWindow uiBaseWindow)
		{

		}

		public void BeforeUnload(UIBaseWindow uiBaseWindow)
		{

		}
	}
}
