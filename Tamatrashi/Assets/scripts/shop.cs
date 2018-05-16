using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {
	public class Item {
		public int price{ get; set; }
		public int sHa{ get; set; } //happiness stat
		public int sHu{ get; set; } //hunger stat
		public int sHe{ get; set; } //health stat
		public int sHy{ get; set; } //hygeine stat
		public Item(int itemPrice, int happiness, int hunger, int health, int hygeine){
			this.price = itemPrice;
			this.sHa = happiness;
			this.sHu = hunger;
			this.sHe = health;
			this.sHy = hygeine;
		}
	}
	public GameObject shopPanel;
	public Item donut;
	public Item smoothie;
	public Item ball;
	public Item bandaid;
	public Item soap;

	// Use this for initialization
	void Start () {
		donut = new Item(20, 1, 1, 0, -1); 
		smoothie = new Item(10, 0, 1, 0, -1);
		ball = new Item(15, 2, -1, 0, -1);
		bandaid = new Item(10, 0, 0, 1, 0);
		soap = new Item(0, 0, 0, 0, 1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showShop(){
		if (!shopPanel.activeSelf) {
			shopPanel.SetActive (true);
		} else if (shopPanel.activeSelf){
			shopPanel.SetActive (false);
		}
	}
}
