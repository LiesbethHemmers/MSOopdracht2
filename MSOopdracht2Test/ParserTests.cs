using Microsoft.VisualStudio.TestPlatform.TestHost;
using MSOopdracht2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

namespace MSOopdracht2Test
{
    public class ParserTests
    {
        [Fact]
        public void TxtProgramParserTest()
        {
            //Initialize the test objects:
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
            List<string> trace = new List<string>();
            List<string> trace2 = new List<string>();

            //Execute both programs:
            parsedProgram.Execute(character2, trace2);
            compareProgram.Execute(character, trace);

            //Check if the end states are equal:
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
            Grid parsedGrid = parser.Parse(lines);
            Vector2 expectedXPos = new Vector2(2, 3);

            Assert.Equal(3, parsedGrid.LoadedGrid.GetLength(0));
            Assert.Equal(4, parsedGrid.LoadedGrid.GetLength(1));
            Assert.Equal(expectedXPos, parsedGrid.GetXPosition());
            Assert.Equal('o', parsedGrid.GetSymbol(1,0));
        }
    }
}
