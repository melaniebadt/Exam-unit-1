for (int i = 0; i < 37; i++)
{
    Move();
}

for (int i = 0; i < 2; i++)
{
    Move();
}

for (int i = 0; i < 3; i++)
{
    Turn();
}

Move();

for (int i = 0; i < 3; i++)
{
    Move(37);
    Turn();
    Move(2);
    Turn();
    Move(37);
    Turn(3);
    Move(2);
    Turn(3);
}

Move(37);
Move();
AtGoal();

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion