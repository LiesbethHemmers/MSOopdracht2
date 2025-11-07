using MSOopdracht2;
using MSOopdracht2.Commands;
using MSOopdracht2.Enums;
using MSOopdracht2.Parsers;
using System.Numerics;

namespace MSOopdracht2Test
{
    public class ParserTests
    {
        [Fact]
        public void TxtProgramParserTest()
        {
            string[] lines = {"Repeat 3 times",
                              "    Move 1",
                              "    Turn right",
                              "    Repeat 5 times",
                              "        Move 2",
                              "Turn left"
                              };
            IProgramParser parser = new TxtProgramParser();
            CodeProgram parsedProgram = parser.Parse(lines);

            CodeProgram compareProgram = new CodeProgram(new List<ICommand>
                                                          {
                                                          new RepeatCommand(3, new List<ICommand>{
                                                          new MoveCommand(1),
                                                          new TurnCommand(TurnDirection.Right),
                                                          new RepeatCommand(5,new List<ICommand>
                                                          {
                                                              new MoveCommand(2)
                                                          })
                                                          }),
                                                          new TurnCommand(TurnDirection.Left)}
                                                          , "CompareProgram");
            Character character = new Character();
            Character character2 = new Character();

            //execute both programs
            parsedProgram.Execute(character2);
            compareProgram.Execute(character);

            //check if the end states are equal
            Assert.Equal(character2.Position, character.Position);
            Assert.Equal(character2.Direction, character.Direction);
        }

        [Fact]
        public void ZeroCommandsTest()
        {
            string[] lines = {"Repeat 2 times",
                              "    Repeat 5 times",
                              "Turn left"
                              };
            IProgramParser parser = new TxtProgramParser();
            CodeProgram parsedProgram = parser.Parse(lines);

            CodeProgram compareProgramZeroCommands = new CodeProgram(new List<ICommand>
                                                          {
                                                          new RepeatCommand(2, new List<ICommand>{
                                                          new RepeatCommand(5,new List<ICommand>
                                                          {
                                                          })
                                                          }),
                                                          new TurnCommand(TurnDirection.Left)}
                                                          , "CompareProgram");
            Character character = new Character();
            Character character2 = new Character();

            //execute both programs
            parsedProgram.Execute(character2);
            compareProgramZeroCommands.Execute(character);

            //check if the end states are equal
            Assert.Equal(character2.Position, character.Position);
            Assert.Equal(character2.Direction, character.Direction);
        }

        public void TxtProgramParserEmptyProgramTest()
        {
            string[] lines = {""
                              };

            IProgramParser parser = new TxtProgramParser();
            CodeProgram parsedProgram = parser.Parse(lines);

            CodeProgram compareProgramEmptyProgram = new CodeProgram(new List<ICommand>
                                                          {
                                                          }
                                                          , "CompareProgram");
            Character character = new Character();
            Character character2 = new Character();

            //execute both programs
            parsedProgram.Execute(character2);
            compareProgramEmptyProgram.Execute(character);

            //check if the end states are equal
            Assert.Equal(character2.Position, character.Position);
            Assert.Equal(character2.Direction, character.Direction);
        }

        [Fact]
        public void TxtGridParserTest()
        {
            string[] lines =
            {
                "oo+",
                "+o+",
                "+o+",
                "+ox"
            };
            IGridParser parser = new TxtGridParser();
            Vector2 expectedXPos = new Vector2(2, 3);

            Grid parsedGrid = parser.Parse(lines);

            Assert.Equal(3, parsedGrid.LoadedGrid.GetLength(0));
            Assert.Equal(4, parsedGrid.LoadedGrid.GetLength(1));
            Assert.Equal(expectedXPos, parsedGrid.GetXPosition());
            Assert.Equal('o', parsedGrid.GetSymbol(1,0));
        }

        [Fact]
        public void TxtGridParserEmptyGridTest()
        {
            string[] lines =
            {
                ""
            };

            IGridParser parser = new TxtGridParser();

            Grid parsedGrid = parser.Parse(lines);

            Assert.Equal(0, parsedGrid.LoadedGrid.GetLength(0));
            Assert.Equal(1, parsedGrid.LoadedGrid.GetLength(1));
        }
    }
}