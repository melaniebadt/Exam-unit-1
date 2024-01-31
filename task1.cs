void MoveThisMany(int number) 
{
    for(int i = 0; i < number; i++)
    {
       Move();     
    }
};

void TurnThreeTimes()
{
    Turn();
    Turn();
    Turn();
};

Move();

for (int i = 0; i < 3; i++)
{
    MoveThisMany(37);
    Turn();
    MoveThisMany(2);
    Turn();
    MoveThisMany(37);
    TurnThreeTimes();
    MoveThisMany(2);
    TurnThreeTimes();
}

MoveThisMany(37);
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