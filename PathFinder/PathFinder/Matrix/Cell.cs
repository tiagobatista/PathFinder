namespace PathFinder.Matrix;

public class Cell
{
    private State _state;

    public override string ToString()
    {
        return $"{(int)_state}";
    }

    public void SetSolution()
    {
        if (_state == State.Wall)
        {
            throw new Exception("Ran into a wall!");
        }
        
        _state = State.Solution;
    }
}