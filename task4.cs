void TurnThisMany(int number)
{
    for(int i = 0; i < number; i++)
    {
       Turn();     
    }
};

void MoveThisMany(int number) 
{
    for(int i = 0; i < number; i++)
    {
       Move();     
    }
};

int[] Turns =     {1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 1, 1, 3, 1, 3, 1, 3, 1, 3, 1};
int[] Movements = {4, 4, 1, 1, 3, 1, 5, 3, 1, 1, 2, 1, 2, 5, 1, 1, 2, 3, 3, 1, 2, 3, 3, 5, 1, 4, 1, 1, 1, 2, 1, 4, 2};

while (!AtGoal())
{
    for (int i = 0; i < Math.Max(Turns.Length, Movements.Length);i++)
    {
        if(i < Turns.Length)
        {
            TurnThisMany(Turns[i]);
        }

        if(i < Movements.Length)
        {
            MoveThisMany(Movements[i]);
        }
    }
}

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