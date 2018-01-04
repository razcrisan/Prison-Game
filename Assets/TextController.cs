using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell,wall, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, lock_2, freedom};

	private States myState;


	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		if (myState == States.cell) 			{state_cell ();} 
		else if (myState == States.sheets_0) 	{state_sheets_0();}
		else if (myState == States.sheets_1) 	{state_sheets_1();}
		else if (myState == States.lock_0) 		{state_lock_0();}
		else if (myState == States.lock_1)		{state_lock_1();}
		else if (myState == States.lock_2)		{state_lock_2();}
		else if (myState == States.mirror) 		{state_mirror();}
		else if (myState == States.wall)		{state_wall();}
		else if (myState == States.cell_mirror)	{state_cell_mirror();}
		else if (myState == States.freedom) 	{state_freedom();}
	}

	void state_cell ()
	{
		text.text =  "You're in an Elf Cage after getting kidnapped by a human. "+
			"Your mission to retrieve the socks failed. " +
			"In your cell are some dirty sheets, a mirror for your miserable mug, and the door is locked.\n\n" +
			"You have to return to Elf City in time for Elf Supper or ELSE! :O " +
			"Here are your options." + 
			"Press 'S' to look at Sheets. " +
			"'M' to look at Mirror. " +
			"'L' to look at Lock. " +
			"Press 'R' to return to your cell";
		if (Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M)) 		{myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L)) 		{myState = States.lock_0;}
		else if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
	}

	void state_mirror ()
	{
		text.text =  "This old rusty mirror on the wall seems loose. Maybe theres something behind it? " +
			"'T' to take mirror " +
			"'W' to check wall behind mirror " +
			"Press 'R' to return to cell";
		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
		else if (Input.GetKeyDown (KeyCode.W)) 		{myState = States.wall;}
		else if (Input.GetKeyDown (KeyCode.T)) 		{myState = States.cell_mirror;}
	}
	void state_wall ()
	{
		text.text =  "You find a strong wire!" +
			"An Elf's most favored tool. Malleable yet sturdy, can reach places unreachable by an Elf." +
			"If anyone actually knew that is... " +
			"Elf should thing carefull on their next move... " +
			"'L' to look at Lock. " +
			"Press 'R' to return to cell";
		if (Input.GetKeyDown (KeyCode.L)) 		{myState = States.lock_2;}
		else if (Input.GetKeyDown (KeyCode.R)) 	{myState = States.cell;}
	
	}
	void state_cell_mirror ()
	{
		text.text =  "You gently take the mirror off the wall " +
			"'L' to look at Lock. " +
			"Press 'R' to return to cell";
		if (Input.GetKeyDown(KeyCode.L))   {myState = States.lock_1;}
		else if (Input.GetKeyDown (KeyCode.R)) 	{myState = States.cell;}
	}

	void state_sheets_0 ()
	{
		text.text =  "You can't believe you sleep in these things. " +
			"They smell a bit of mildew and cheese, surely it's time somebody changed them!" +
			"Perhaps you could use them as an instrument to your escape?..." +
			"Press R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
	}
	void state_sheets_1 ()
	{
		text.text =  "Holding a mirror in your hand you notice the cut from when you tried to run away from the human" +
			"Press R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.R))  	 {myState = States.cell_mirror;}
	}

	void state_lock_0 ()
	{
		text.text =  "This particular lock is one of those button combination locks. " +
			"You remember a technique where the guy was able to guess the combination" +
			"just by looking at the fingerprints on the buttons." +
			"For now, you should stick to brainstorming, maybe that will help." +
			"Press R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.R)) 		  {myState = States.cell;}
	}

	void state_lock_1 ()
	{
		text.text =  "You ever so carefully slide the mirror through the bars, and turn it " +
			"so you can just barely see the lock." +
			"You can just make out the fingerprints around the buttons. \n\n (The guards must have been sloppy with their lunch.) \n" +
			"Since they don't give you hangers in prison you have to dislocate your finger in order to reach the buttons" +
			"\n*SNAP!* Without making a sound a tears running down your face, you tap the buttons and hear a click!" +
			"\nPress O to open or " + 
			"R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.O))     	{myState = States.freedom;}
		else if (Input.GetKeyDown (KeyCode.R))      {myState = States.cell_mirror;}
	}

	void state_lock_2 ()
	{
		text.text =  "You ever so carefully slide the mirror through the bars, and turn it " +
			"so you can just barely see the lock." +
			"You can just make out the fingerprints around the buttons. \n (The guards must have been sloppy with their lunch.)" +
			"Since you found the wire, you can easily reach the buttons! \n" +
			"*CLICK!* the door clicks open! " +
			"Press O to open or " + 
			"R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.O))     	{myState = States.freedom;}
		else if (Input.GetKeyDown (KeyCode.R))      {myState = States.cell_mirror;}
	}
	void state_freedom ()
	{
		text.text =  "You escaped just in time! " +
			"Press G to go back in! Elfs love challanges!!! ";
		if (Input.GetKeyDown (KeyCode.O))     	{myState = States.cell;}
	}



}
