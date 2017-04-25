using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {forest_0, wreckage_0, tree_0, beach_0, boat_0, forest_1, tree_1, forest_2, beach_1, end_0, boat_1, boat_2, beach_2, map, end_1, end_2, boat_close, beach_3};
	private States myState;

	// Use this for initialization
	void Start () {
	
		myState = States.forest_0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//print (myState);
		
		if 		(myState == States.forest_0)	{state_forest_0();} 
		else if (myState == States.tree_0)		{state_tree_0();} 
		else if (myState == States.wreckage_0)	{state_wreckage_0();}
		else if (myState == States.beach_0)		{state_beach_0();}
		else if (myState == States.forest_1)	{state_forest_1();}
		else if (myState == States.boat_0)		{state_boat_0();}
		else if (myState == States.end_0)		{state_end_0();}
		else if (myState == States.beach_1)		{state_beach_1();}
		else if (myState == States.boat_1)		{state_boat_1();}
		else if (myState == States.boat_close)	{state_boat_close();}
		else if (myState == States.end_2)		{state_end_2();}
		else if (myState == States.boat_2)		{state_boat_2();}
		else if (myState == States.beach_2)		{state_beach_2();}
		else if (myState == States.beach_3)		{state_beach_3();}
		else if (myState == States.map)			{state_map();}
		else if (myState == States.end_1)		{state_end_1();} 
	
	}
	
	#region State handler methods
	
	void state_forest_0(){
		text.text = "You wake up in a complete deserted island with no memory of how you get there. " +
					"You realize you are in the forest and your luck won't last forever so you need to find a way out. " +
					"You look around and see a tree and the wreckage of the front of a small plane and a way to the beach.\n\n" + 
					"Press T to view the Tree, W to inspect the Wreckage or B to go to the Beach.";
		if 		(Input.GetKeyDown(KeyCode.T))	{myState = States.tree_0;}
		else if (Input.GetKeyDown(KeyCode.W))	{myState = States.wreckage_0;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.beach_0;}
	}
	
	void state_tree_0(){
		text.text = "You look at the tree and realize you can cut it down to create a raft, but you need a sharp tool.\n\n" + 
					"Press R to return the forest.";
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.forest_0;}
	}
	
	void state_wreckage_0(){
		text.text = "You inspect the wreckage and find an emergency axe.\n\n" + 
					"Press A to take the Axe or R to Return to the forest.";
		if 		(Input.GetKeyDown(KeyCode.R))	{myState = States.forest_0;}
		else if (Input.GetKeyDown(KeyCode.A))	{myState = States.forest_1;}
	}
	
	void state_beach_0(){
		text.text = "You look at a beatiful beach. There is a boat laying on the sand. \n\n" + 
					"Press B to inspect the Boat, R to Return to the forest or S to get out of the island swimming.";
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.boat_0;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.forest_0;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_0;}
	}
	
	void state_forest_1(){
		text.text = "While you take the axe, the wreckage starts to shake and the rests of the plane fall down." +
					"You manage to escape going back to the center of the forest. " +
					"You look around and see a tree blocking the way to the beach.\n\n" + 
					"Press C to Cut the tree with the axe and create a raft.";
		if (Input.GetKeyDown(KeyCode.C))	{myState = States.beach_1;}
	}
	
	void state_boat_0(){
		text.text = "You see a boat but it is upside down. You can use it to sail. \n\n" + 
					"Press I to Inspect the boat closely, S to Sail with the boat or R to Return to the beach.";
		if 		(Input.GetKeyDown(KeyCode.I))	{myState = States.boat_close;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.beach_0;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_0;}
	}
	
	void state_end_0(){
		text.text = "You drowned. \n\n" + 
					"Press Space to restart the game.";
		if (Input.GetKeyDown(KeyCode.Space))	{myState = States.forest_0;}
	}
	
	void state_boat_close(){
		text.text = "You look close and see a crack in the boat's hull. \n\n" + 
					"Press R to Return to the boat.";
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.boat_0;}
	}
	
	void state_beach_1(){
		text.text = "You look at a beatiful beach. There is a boat laying on the sand. \n\n" + 
					"Press B to inspect the Boat or S to use the raft and get out of the island Sailing.";
		if 		(Input.GetKeyDown(KeyCode.B))	{myState = States.boat_1;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_2;}
	}
	
	void state_boat_1(){
		text.text = "You see an upside down boat. You are too tired to turn it and use it. " +
					"But you can use the axe to crack its hull. \n\n" + 
					"Press C to Crack the boat's hull or R to Return to the beach.";
		if 		(Input.GetKeyDown(KeyCode.C))	{myState = States.boat_2;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.beach_1;}
	}
	
	void state_end_2(){
		text.text = "You sail without a clue of where you are going. You die after 2 days. \n\n" + 
					"Press Space to restart the game.";
		if (Input.GetKeyDown(KeyCode.Space))	{myState = States.forest_0;}
	}
	
	void state_boat_2(){
		text.text = "Beneath the boat's cracked hull, you see a compass. \n\n" + 
					"Press T to Take the compass or R to Return to the beach.";
		if 		(Input.GetKeyDown(KeyCode.T))	{myState = States.beach_3;}
		else if (Input.GetKeyDown(KeyCode.R))	{myState = States.beach_2;}
	}
	
	void state_beach_2(){
		text.text = "You look at a beatiful beach. There is a broken boat laying on the sand. \n\n" + 
					"Press B to inspect the Boat or S to take the raft and Sail.";
		if (Input.GetKeyDown(KeyCode.B))		{myState = States.boat_2;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_2;}
	}
	
	void state_beach_3(){
		text.text = "After collecting the compass you put it in your pocket. " + 
					"You sense there is something else in your pocket: it's a map! \n\n" + 
					"Press M to read the Map, S to sail South with the raft or N to sail North with the raft.";
		if 		(Input.GetKeyDown(KeyCode.M))	{myState = States.map;}
		else if (Input.GetKeyDown(KeyCode.S))	{myState = States.end_1;}
		else if (Input.GetKeyDown(KeyCode.N))	{myState = States.end_2;}
	}
	
	void state_map(){
		text.text = "You can somehow make sense of the map. " + 
					"You know you can sail South to get to the continent. \n\n" + 
					"Press R to return to the beach.";
		if (Input.GetKeyDown(KeyCode.R))	{myState = States.beach_3;} 
	}
	
	void state_end_1(){
		text.text = "You sail south and get to the continent. Congratulations, YOU WON. \n\n" + 
					"Press Space to restart the game.";
		if (Input.GetKeyDown(KeyCode.Space))	{myState = States.forest_0;}
	}
	#endregion
}
