using UnityEngine;
using System.Collections;

public class PosterManager : MonoBehaviour {

	bool isAsahiPoster = false;
	bool isKirinPoster = false;
	bool isPict;

	SpriteRenderer spriteRenderer;
	AudioSource audioSource;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Ended){
				Debug.Log ("Touch");
				
				Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
				Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
				
				Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
				Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
				
				
				if (colition2d.name == "poster_asahi")
				{ 
					Debug.Log(colition2d.name);

					spriteRenderer = colition2d.GetComponent<SpriteRenderer>();
					isAsahiPoster =! isAsahiPoster;
					Debug.Log(isAsahiPoster);

					if(isAsahiPoster){
					
					
					spriteRenderer.sprite = Resources.Load<Sprite>("SourcePictures/poster_asahi");
					audioSource = colition2d.GetComponent<AudioSource>();
					audioSource.Play();
					}

					if(!isAsahiPoster){
					
					spriteRenderer.sprite = Resources.Load<Sprite>("None");

					}

				}else if(colition2d.name == "poster_kirin") {
					Debug.Log(colition2d.name);
					spriteRenderer = colition2d.GetComponent<SpriteRenderer>();
					isKirinPoster =! isKirinPoster;

					if(isKirinPoster){
						
					spriteRenderer.sprite = Resources.Load<Sprite>("SourcePictures/poster_kirin");
					audioSource = colition2d.GetComponent<AudioSource>();
					audioSource.Play();
						
					}
					
					if(!isKirinPoster){
						
						spriteRenderer.sprite = Resources.Load<Sprite>("None");
						
					}
				}else if(colition2d.name == "8_pict_rikidoZan") {
					Debug.Log(colition2d.name);
					spriteRenderer = colition2d.GetComponent<SpriteRenderer>();
					isPict =! isPict;
					
					if(isPict){
						
						spriteRenderer.sprite = Resources.Load<Sprite>("SourcePictures/pict_rikidoZan");
						audioSource = colition2d.GetComponent<AudioSource>();
						audioSource.Play();
						
					}
					
					if(!isPict){
						
						spriteRenderer.sprite = Resources.Load<Sprite>("None");
						
					}
				}
				else if(colition2d.name == "23_pict_rikidoZan") {
					Debug.Log(colition2d.name);
					spriteRenderer = colition2d.GetComponent<SpriteRenderer>();
					isPict =! isPict;
					
					if(isPict){
						
						spriteRenderer.sprite = Resources.Load<Sprite>("SourcePictures/pict_rikidoZan");
						audioSource = colition2d.GetComponent<AudioSource>();
						audioSource.Play();
						
					}
					
					if(!isPict){
						
						spriteRenderer.sprite = Resources.Load<Sprite>("None");
						
					}
				}
			}
		}
	}
}
