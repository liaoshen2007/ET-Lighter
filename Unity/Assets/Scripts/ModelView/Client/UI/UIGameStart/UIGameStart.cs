namespace ET.Client
{
	[ComponentOf(typeof(UIBaseWindow))]
	public  class UIGameStart : Entity, IAwake, IUILogic
	{
		public UIGameStartViewComponent View { get => GetParent<UIBaseWindow>().GetComponent<UIGameStartViewComponent>();} 
	}
}
