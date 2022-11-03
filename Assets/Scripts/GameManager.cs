using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField]
	private Transform PuzzleField;

	[SerializeField]
	private GameObject Card;

	private List<GameObject> _cards = new List<GameObject>();

	void Awake()
	{
		for (int i=0; i < 8; i++)
		{
			var card = Instantiate(Card);
			Card.name = "" + i;
			card.transform.SetParent(PuzzleField, false);
			_cards.Add(card);
		}
	}

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
