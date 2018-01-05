﻿using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {
	cell,wall, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, lock_2, corridor_0, corridor_1, corridor_2, corridor_3,
	stairs_0, stairs_1, stairs_2, floor, closet_door, in_closet, courtyard
	};

	private States myState;


	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		if 		(myState == States.cell) 		{cell ();} 
		else if (myState == States.sheets_0) 	{sheets_0();}
		else if (myState == States.sheets_1) 	{sheets_1();}
		else if (myState == States.lock_0) 		{lock_0();}
		else if (myState == States.lock_1)		{lock_1();}
		else if (myState == States.lock_2)		{lock_2();}
		else if (myState == States.mirror) 		{mirror();}
		else if (myState == States.wall)		{wall();}
		else if (myState == States.cell_mirror)	{cell_mirror();}
		else if (myState == States.corridor_0) 	{corridor_0();}
		else if (myState == States.corridor_0) 	{corridor_1();}
		else if (myState == States.corridor_0) 	{corridor_2();}
		else if (myState == States.corridor_0) 	{corridor_3();}
		else if (myState == States.stairs_0) 	{stairs_0();}
		else if (myState == States.stairs_0) 	{stairs_1();}
		else if (myState == States.stairs_0) 	{stairs_2();}
		else if (myState == States.floor) 		{floor();}
		else if (myState == States.closet_door) {closet_door();}
		else if (myState == States.in_closet) 	{in_closet();}
		else if (myState == States.courtyard) 	{courtyard();}

	}	

	void cell ()
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
		if 		(Input.GetKeyDown (KeyCode.S)) 		{myState = States.sheets_0;}
		else if (Input.GetKeyDown (KeyCode.M)) 		{myState = States.mirror;}
		else if (Input.GetKeyDown (KeyCode.L)) 		{myState = States.lock_0;}
		else if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
	}

	void mirror ()
	{
		text.text =  "This old rusty mirror on the wall seems loose. Maybe theres something behind it? " +
			"'T' to take mirror " +
			"'W' to check wall behind mirror " +
			"Press 'R' to return to cell";
		if 		(Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
		else if (Input.GetKeyDown (KeyCode.W)) 		{myState = States.wall;}
		else if (Input.GetKeyDown (KeyCode.T)) 		{myState = States.cell_mirror;}
	}
	void wall ()
	{
		text.text =  "You find a strong wire!" +
			"An Elf's most favored tool. Malleable yet sturdy, can reach places unreachable by an Elf." +
			"If anyone actually knew that is... " +
			"Elf should thing carefull on their next move... " +
			"'L' to look at Lock. " +
			"Press 'R' to return to cell";
		if 		(Input.GetKeyDown (KeyCode.L)) 	{myState = States.lock_2;}
		else if (Input.GetKeyDown (KeyCode.R)) 	{myState = States.cell;}
	
	}
	void cell_mirror ()
	{
		text.text =  "You gently take the mirror off the wall " +
			"You cant stop looking at your gash, could it be infected? " +
			"'L' to look at Lock. " +
			"S to look at sheets." +
			"Press 'R' to return to cell";
		if 		(Input.GetKeyDown(KeyCode.L))   {myState = States.lock_1;}
		else if (Input.GetKeyDown (KeyCode.R)) 	{myState = States.cell;}
		else if (Input.GetKeyDown (KeyCode.S)) 	{myState = States.sheets_1;}
	}

	void sheets_0 ()
	{
		text.text =  "You can't believe you sleep in these things. " +
			"They smell a bit of mildew and cheese, surely it's time somebody changed them!" +
			"Perhaps you could use them as an instrument to your escape?..." +
			"Press R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.R)) 		{myState = States.cell;}
	}
	void sheets_1 ()
	{
		text.text =  "Holding a mirror in your hand you notice the cut from when you tried to run away from the human" +
			"Press M to go back to examining the mirror.\n\n";
		if (Input.GetKeyDown (KeyCode.R))  	 {myState = States.cell_mirror;}
	}

	void lock_0 ()
	{
		text.text =  "This particular lock is one of those button combination locks. " +
			"You remember a technique where the guy was able to guess the combination" +
			"just by looking at the fingerprints on the buttons." +
			"For now, you should stick to brainstorming, maybe that will help." +
			"Press R to return to roam your cell.\n\n";
		if (Input.GetKeyDown (KeyCode.R)) 		  {myState = States.cell;}
	}

	void lock_1 ()
	{
		text.text =  "You ever so carefully slide the mirror through the bars, and turn it " +
			"so you can just barely see the lock." +
			"You can just make out the fingerprints around the buttons. \n\n (The guards must have been sloppy with their lunch.) \n" +
			"Since they don't give you hangers in prison you have to dislocate your finger in order to reach the buttons" +
			"\n*SNAP!* Without making a sound and tears running down your face, you tap the buttons and hear a click!" +
			"\nPress O to open the lock or " + 
			"M to look at yourself in the mirror.\n\n";
		if 		(Input.GetKeyDown (KeyCode.O))     	{myState = States.corridor_0;}
		else if (Input.GetKeyDown (KeyCode.M))      {myState = States.cell_mirror;}
	}

	void lock_2 ()
	{
		text.text =  "You ever so carefully slide the mirror through the bars, and turn it " +
			"so you can just barely see the lock." +
			"You can just make out the fingerprints around the buttons. \n (The guards must have been sloppy with their lunch.)" +
			"Since you found the wire, you can easily reach the buttons! \n" +
			"*CLICK!* the door clicks open! " +
			"Press O to open or " + 
			"R to return to roam your cell.\n\n";
		if 		(Input.GetKeyDown (KeyCode.O))     	{myState = States.corridor_0;}
		else if (Input.GetKeyDown (KeyCode.R))      {myState = States.cell_mirror;}
	}

	void corridor_0 ()
	{
		text.text =  "You managed to get out, the corridor looks empty and it's actually terribly cold." + 
			"Much much colder than the cell. Very wierd... " +
			"Press S to go up the stairs towards the light. " +
			"Press J to keep going down the long dark hallway.";
		if 		(Input.GetKeyDown (KeyCode.S))     	{myState = States.stairs_0;}
		else if (Input.GetKeyDown (KeyCode.J))     	{myState = States.corridor_1;}
	}
	void corridor_1 ()
	{
		text.text =  "You managed to get out, the corridor looks empty and it's actually terribly cold." + 
			"Much much colder than the cell. Very wierd... " +
			"Press G to go back in! Elfs love challanges! ";
		if 		(Input.GetKeyDown (KeyCode.O))     	{myState = States.cell;}
	}
	void corridor_2 ()
	{
		text.text =  "You managed to get out, the corridor looks empty and it's actually terribly cold." + 
			"Much much colder than the cell. Very wierd... " +
			"Press G to go back in! Elfs love challanges! ";
		if 		(Input.GetKeyDown (KeyCode.O))     	{myState = States.cell;}
	}

	void corridor_3 ()
	{
		text.text =  "You managed to get out, the corridor looks empty and it's actually terribly cold." + 
			"Much much colder than the cell. Very wierd... " +
			"Press G to go back in! Elfs love challanges! ";
		if 		(Input.GetKeyDown (KeyCode.O))     	{myState = States.cell;}
	}

	void stairs_0 ()
	{
		text.text =  "You start walking up the stairs towards the outside light. " +
			"You look realize its not yet break time, and you'll be caught immediately. " +
			"You quickly go back down the stairs by your cell and reconsider. " +
			"Press R to return back to the corridor ";
		if 		(Input.GetKeyDown (KeyCode.R))     	{myState = States.corridor_0;}
	}

	void stairs_1 ()
	{
		text.text =  "Unfortunately wielding a puny paperclip doesn't give you the confidence fight off the armed guards. " +
			"If only the the wire didnt break while picking you cell lock... " +
			"Press R to retreat down the stairs ";
		if 		(Input.GetKeyDown (KeyCode.R))     	{myState = States.corridor_1;}
	}

	void stairs_2 ()
	{
		text.text =  "Your confidence is at an all time high despite still being in prison. " +
			"You broke out of your cell and managed to pick the janitors closet open. " +
			"You still have the paperclip so it's not enough to fight the human guards, maybe theres something in here... " +
			"Press R to go back out corridor ";
		if 		(Input.GetKeyDown (KeyCode.R))     	{myState = States.corridor_2;}
	}

	void courtyard ()
	{
		text.text =  "You walk out into the courtyard looking smug dressed as the janitor. " +
			"One of the guards tips his hat as you walk by, another cat calls? " +
			"You quickly pick up the pace now, sweating profusely the sunset is right there. and just in time for supper! :D " +
			"Press P to play again! ";
		if 		(Input.GetKeyDown (KeyCode.P))     	{myState = States.cell;}
	}



}
