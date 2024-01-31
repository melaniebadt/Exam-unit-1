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

for (int i = 0; i < 2; i++)
{
    MoveThisMany(11);
    Turn();
    MoveThisMany(2);
    Turn();
    MoveThisMany(11);
    TurnThreeTimes();

    if (i == 0)
    {
        MoveThisMany(2);
        TurnThreeTimes();
    }
}

MoveThisMany(2);

for (int i = 0; i < 2; i++)
{
    MoveThisMany(5);
    TurnThreeTimes();
    MoveThisMany(2);
    TurnThreeTimes();
    MoveThisMany(5);
    Turn();
    MoveThisMany(2);
    Turn();
}

MoveThisMany(5);
TurnThreeTimes();
MoveThisMany(3);
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