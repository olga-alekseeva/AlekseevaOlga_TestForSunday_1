using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using static System.Net.WebRequestMethods;

internal sealed class GalleryShowIcons : MonoBehaviour
{
    private List<Texture2D> galleryThumbnailList = new List<Texture2D>();
    private GallerySceneUIView _gallerySceneUIView;

    //public GalleryShowIcons()
    //{
    //    _gallerySceneUIView.contentContainer = transform.Find("Mask").Find("Content");
    //    Transform container = _gallerySceneUIView.contentContainer;
    //    _gallerySceneUIView.imageIcon = _gallerySceneUIView.contentContainer.Find("IconImage");
    //}
    private void Awake()

    {
        _gallerySceneUIView = GameObject.FindObjectOfType<GallerySceneUIView>();
       // _gallerySceneUIView.contentContainer = transform.Find("Mask").Find("Content");
       // Transform container = _gallerySceneUIView.contentContainer;
       // _gallerySceneUIView.imageIcon = _gallerySceneUIView.contentContainer.Find("IconImage");
      //  Transform imageIcon = _gallerySceneUIView.imageIcon;
}
void Start()
{
        string url = "http://data.ikppbb.com/test-task-unity-data/pics/1.jpg";
        WebRequests.GetTexture(url, (string error) =>
        {
            Debug.Log("Error: " + error);
        }, (Texture2D texture2D) =>
        {
            Sprite sprite = Sprite.Create(texture2D, new Rect(0, 0, texture2D.width, texture2D.height),
                new Vector2(.5f, .5f), 10f);
            _gallerySceneUIView.imageRenderer.sprite = sprite;
        }
        );
        
    }
    private void PrintIcons()
{
        Transform container = _gallerySceneUIView.contentContainer;
        Transform imageIcon = _gallerySceneUIView.imageIcon;
        foreach (Transform child in container)
        {
            if (child == imageIcon) continue;
            Destroy(child.gameObject);
        }

    }

   
}
