using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Enums;
using System.Diagnostics;

namespace MSOopdracht2Test;

public class CodeProgramExecutorTests
{
    [Fact]

    public void RunWithoutGrid()
    {
        List<ICommand> commands = new List<ICommand>()
        {
            new MoveCommand(1),
            new TurnCommand(TurnDirection.Right)
        };
        CodeProgram program = new CodeProgram(commands, "test");
        CodeProgramExecutor executor = new CodeProgramExecutor();
        List<string> output = executor.Run(program);
        string expectedOutput = "Move 1, Turn right., End state (1,0) facing South.";
        string actualOutput = string.Join(", ", output);

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void RunSuccessWithGrid()
    {
        char[,] mockGrid = new char[3, 1]
        {
            {' ' },
            {' ' }, 
            {'x' }
        };
        Grid grid = new Grid(mockGrid);
        List<ICommand> commands = new List<ICommand>()
        {
            new MoveCommand(2),
            new TurnCommand(TurnDirection.Right)
        };
        CodeProgram program = new CodeProgram(commands, "test");
        CodeProgramExecutor executor = new CodeProgramExecutor();
        List<string> output = executor.Run(program, grid);
        string expectedOutput = "Successfully reached end position, Move 2, Turn right., End state (2,0) facing South.";
        string actualOutput = string.Join(", ", output);

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void RunUnsuccessfulWithGrid()
    {
        char[,] mockGrid = new char[3, 1]
        {
            {' ' },
            {' ' },
            {'x' }
        };
        Grid grid = new Grid(mockGrid);
        List<ICommand> commands = new List<ICommand>()
        {
            new MoveCommand(1),
            new TurnCommand(TurnDirection.Right)
        };
        CodeProgram program = new CodeProgram(commands, "test");
        CodeProgramExecutor executor = new CodeProgramExecutor();
        List<string> output = executor.Run(program, grid);
        string expectedOutput = "Character did not end at the right position, Move 1, Turn right., End state (1,0) facing South.";
        string actualOutput = string.Join(", ", output);

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void RunUnsuccessfulBlockedWithGrid()
    {
        char[,] mockGrid = new char[3, 1]
        {
            {' ' },
            {' ' },
            {'+' }
        };
        Grid grid = new Grid(mockGrid);
        List<ICommand> commands = new List<ICommand>()
        {
            new MoveCommand(3),
            new TurnCommand(TurnDirection.Right)
        };
        CodeProgram program = new CodeProgram(commands, "test");
        CodeProgramExecutor executor = new CodeProgramExecutor();
        List<string> output = executor.Run(program, grid);
        string expectedOutput = "Runtime error: (2, 0) is blocked";
        string actualOutput = string.Join(", ", output);

        Assert.Equal(expectedOutput, actualOutput);
    }

    [Fact]
    public void RunUnsuccessfulOutOfBoundsWithGrid()
    {
        char[,] mockGrid = new char[3, 1]
        {
            {' ' },
            {' ' },
            {'x' }
        };
        Grid grid = new Grid(mockGrid);
        List<ICommand> commands = new List<ICommand>()
        {
            new TurnCommand(TurnDirection.Right),
            new MoveCommand(1)
        };
        CodeProgram program = new CodeProgram(commands, "test");
        CodeProgramExecutor executor = new CodeProgramExecutor();
        List<string> output = executor.Run(program, grid);
        string expectedOutput = "Runtime error: (0, 1) is outside of the grid";
        string actualOutput = string.Join(", ", output);

        Assert.Equal(expectedOutput, actualOutput);
    }
}