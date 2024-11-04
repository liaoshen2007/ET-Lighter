namespace ET.Client
{
	[FriendOf(typeof(UIGameStartViewComponent))]
	public class UIGameStartViewComponentAwakeSystem : AwakeSystem<UIGameStartViewComponent> 
	{
		protected override void Awake(UIGameStartViewComponent self)
		{
			self.uiTransform = self.GetParent<UIBaseWindow>().UITransform;
		}
	}


	[FriendOf(typeof(UIGameStartViewComponent))]
	public class UIGameStartViewComponentDestroySystem : DestroySystem<UIGameStartViewComponent> 
	{
		protected override void Destroy(UIGameStartViewComponent self)
		{
			self.DestroyWidget();

		}
	}
}
