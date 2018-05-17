using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {
	private float counter;
	public class Item {
		public int price{ get; set; }
		public int sHa{ get; set; } //happiness stat
		public int sHu{ get; set; } //hunger stat
		public int sHe{ get; set; } //health stat
		public int sHy{ get; set; } //hygiene stat
		public Item(int itemPrice, int happiness, int hunger, int health, int hygiene){
			this.price = itemPrice;
			this.sHa = happiness;
			this.sHu = hunger;
			this.sHe = health;
			this.sHy = hygiene;
		}
	}
	public int gold;
	public GameObject trashi;
	public GameObject shopPanel;
	public Item donut;
	public Item smoothie;
	public Item ball;
	public Item bandaid;
	public Item soap;
	List<Item> itemList = new List<Item>();
	private pet pet;
	// Use this for initialization
	void Start () {
		gold = 100;
		donut = new Item(20, 1, 1, 0, -1); 
		smoothie = new Item(10, 0, 1, 0, -1);
		ball = new Item(15, 2, -1, 0, -1);
		bandaid = new Item(10, 0, 0, 1, 0);
		soap = new Item(5, 0, 0, 0, 1);
		itemList.Add (donut);
		itemList.Add (smoothie);
		itemList.Add (ball);
		itemList.Add (bandaid);
		itemList.Add (soap);
		pet = trashi.GetComponent<pet>();
	}
	
	// Update is called once per frame
	void Update () {
		counter += Time.deltaTime;
		if (counter >= 5) {
			gold += 10;
			counter = 0;
		}
	}

	public void showShop(){
		if (!shopPanel.activeSelf) {
			shopPanel.SetActive (true);
		} else if (shopPanel.activeSelf){
			shopPanel.SetActive (false);
		}
	}

	public void useItem(int item){
		if (gold - itemList [item].price < 0) {
			return;
		} else {
			gold -= itemList [item].price;
			pet.updateStatus ("happiness", itemList [item].sHa);
			pet.updateStatus ("hunger", itemList [item].sHu);
			pet.updateStatus ("health", itemList [item].sHe);
			pet.updateStatus ("hygiene", itemList [item].sHy);
		}
	}
}
