This is a part of bachelor's project, some parts are lacking (like integration with map module) because they doesn't exists yet.

Creates quest chain, that contains several logically connected actions 
- go to NPC1 coordinates
- talk to NPC1 
- go to NPC2 coordinates
- talk to NPC2

But there's also a chance that we don't know NPC1 location, which means that our quest can look like this:
- go to NPC1 coordinates
	- Get NPC1 coordinates from NPC3
	- Go to NPC3 (NPC3 doesn't want to talk to us unless we perform some actions for him)
		-Perform subquest for NPC3
			-Kill some enemies
		-Go back to NPC3
	- Talk to NPC3
- talk to NPC1 
- go to NPC2 coordinates
- talk to NPC2

