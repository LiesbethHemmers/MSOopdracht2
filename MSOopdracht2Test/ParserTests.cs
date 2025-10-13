using MSOopdracht2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MSOopdracht2Test
{
    public class ParserTests
    {
        [Fact]
        public void TxtParserTest()
        {
            string[] lines = {"Repeat 3 times",
                              "    Move 1",
                              "    Turn right",
                              "    Repeat 5 times",
                              "        Move 2",
                              "Turn left"
                              };


            IParser parser = new TxtParser();
            CodeProgram parsedProgram = parser.Parse(lines);

            //We can't simply check if lines is equal to a codeprogram, like the ones in ExamplePrograms,
            //because Assert.Equal check if the object references are equal and not the content.
            //Since lines and and a codeprogram will always be 2 different object references
            //, they will never be equal. 

            //So we have to check the commands by their properties:
            //Firstly, check the times of the RepeatCommand:
            ICommand commandWithoutDepth0 = parsedProgram.Commands[0];
            RepeatCommand repeatCommand0 = (RepeatCommand)commandWithoutDepth0;
            int repeatCommand0Times = repeatCommand0.times;
            Assert.Equal(3, repeatCommand0Times);

            //Secondly, check the turn of the turncommand, the other command without indentation:
            ICommand commandWithoutDepth1 = parsedProgram.Commands[1];
            TurnCommand turnCommand1 = (TurnCommand)commandWithoutDepth1;
            TurnDirection turnCommand1Direction = turnCommand1.turn;
            Assert.Equal(TurnDirection.Left, turnCommand1Direction);

            //Now we're going to check the commands in the first repeatcommand:
            ICommand commandWithOneDepth0 = repeatCommand0.Commands[0];
            MoveCommand moveCommand0 = (MoveCommand)commandWithOneDepth0;
            int moveCommand0Times = moveCommand0.steps;
            Assert.Equal(1, moveCommand0Times);

            ICommand commandWithOneDepth1 = repeatCommand0.Commands[1];
            TurnCommand turnCommand0 = (TurnCommand)commandWithOneDepth1;
            TurnDirection turnCommand0Direction = turnCommand0.turn;
            Assert.Equal(TurnDirection.Right, turnCommand0Direction);

            ICommand commandWithOneDepth2 = repeatCommand0.Commands[2];
            RepeatCommand repeatCommand1 = (RepeatCommand)commandWithOneDepth2;
            int repeatCommand1Times = repeatCommand1.times;
            Assert.Equal(5, repeatCommand1Times);

            //Lastly, we will the command in the second repeatcommand:
            ICommand commandWithTwoDepth0 = repeatCommand1.Commands[0];
            MoveCommand moveCommand1 = (MoveCommand)commandWithTwoDepth0;
            int moveCommand1Times = moveCommand1.steps;
            Assert.Equal(2, moveCommand1Times);
        }
    }
}
