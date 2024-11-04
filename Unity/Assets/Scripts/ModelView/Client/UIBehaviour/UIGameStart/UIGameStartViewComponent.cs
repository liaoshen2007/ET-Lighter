using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(UIBaseWindow))]
	[EnableMethod]
	public  class UIGameStartViewComponent : Entity, IAwake, IDestroy 
	{
		public Transform UiTransform => this.uiTransform;

		public Button E_GameStartButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GameStartButton == null )
     			{
		    		this.m_E_GameStartButton = UIFindHelper.FindDeepChild<Button>(this.uiTransform.gameObject,"Bg/BtnGroup/E_GameStart");
     			}
     			return this.m_E_GameStartButton;
     		}
     	}

		public Button E_GalleryButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GalleryButton == null )
     			{
		    		this.m_E_GalleryButton = UIFindHelper.FindDeepChild<Button>(this.uiTransform.gameObject,"Bg/BtnGroup/E_Gallery");
     			}
     			return this.m_E_GalleryButton;
     		}
     	}

		public Button E_ExitGameButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_ExitGameButton == null )
     			{
		    		this.m_E_ExitGameButton = UIFindHelper.FindDeepChild<Button>(this.uiTransform.gameObject,"Bg/BtnGroup/E_ExitGame");
     			}
     			return this.m_E_ExitGameButton;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_GameStartButton = null;
			this.m_E_GalleryButton = null;
			this.m_E_ExitGameButton = null;
			uiTransform = null;
		}

		private Button m_E_GameStartButton = null;
		private Button m_E_GalleryButton = null;
		private Button m_E_ExitGameButton = null;
		public Transform uiTransform = null;
	}
}
