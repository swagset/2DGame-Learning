**A simple way to create a 2D space with the ability to move around it.**

## Info
**This project was made for learning purposes and does not use advanced console handling.**

Each frame is simply drawn by clearing the console with `Console.Clear()` and then redrawing the map in a loop.


**Movement is implemented by updating elements in a two-dimensional char array**. One common source of confusion is that the array is accessed as `[y, x]` (height first, width second), not the other way around. 
So, to move the player to the right, we first overwrite the current position with `map[Player[0], Player[1]] = MapIcon;`, then update the new position with `map[Player[0], ++Player[1]] = PlayerIcon;`.

Key input is handled with `ConsoleKeyInfo` and is bound to:
**WASD** - Move;
**Q** - Quit.
